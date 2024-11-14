using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Lab2
{
    public partial class Form1 : Form
    {
        public struct BezierPoint
        {
            public PointF position;
            public float weight;
        }
        //функция
        private IFunction function;
        //скаляры
        private float scaler;
        private int movingBezierIndex = -1;
        private int drawingIndex = 0;
        //стиль
        private Color funcColor;
        private Brush backBrush;
        //точки
        private PointF centerXY;
        private PointF lastXY; //для определения дельты перемещения графика
        private PointF ballPoint;
        private BezierPoint[] beziers;
        List<List<PointF>> BezierLine = new List<List<PointF>>();
        //флаги
        private bool isMovingScreen = false;
        private bool isMovingBezier = false;
        private bool ballExists = false;
        private bool nurbsCreatingMode = false;
        private bool randomNurb = false;


        public Form1()
        {
            InitializeComponent();
            setStartParametres();
            funcColor = Color.Red;
            panelFunc.MouseWheel += PanelFunc_MouseWheel;
            backBrush = new SolidBrush(Color.White);
        }

        #region XY methods
        private void setStartParametres()
        {
            function = null;
            randomNurb = false;
            ballExists = false;
            nurbsCreatingMode = false;
            movingBezierIndex = -1;
            centerXY = new PointF((panelFunc.Right - panelFunc.Left) / 2 + panelFunc.Left, (panelFunc.Top - panelFunc.Bottom) / 2 + panelFunc.Bottom);
            scaler = 40;
            label1.Text = " ";
            buttonBall.Enabled = true;
            beziers = new BezierPoint[0];
            if (beziers != null) beziers = new BezierPoint[beziers.Length];
            textBoxBezier.Enabled = false;
            textBoxBezier.Text = labelBezier.Text = " ";
        }

        private void XYLinesInit(Graphics g)
        {
            try
            {
                float[] dash = { scaler / 8, scaler / 8 };
                Pen p = new Pen(Color.Black);
                p.Width = 2;
                g.DrawLine(p, centerXY.X, panelFunc.Top, centerXY.X, panelFunc.Bottom);
                g.DrawLine(p, panelFunc.Left, centerXY.Y, panelFunc.Right, centerXY.Y);
                p.DashPattern = dash;
                g.DrawEllipse(p, centerXY.X - scaler, centerXY.Y - scaler, scaler * 2, scaler * 2);
            }
            catch
            {
                MessageBox.Show("Out of memory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                setStartParametres();
                panelFunc.Invalidate();
            }
        }

        private PointF PanelToFuncXY(PointF pnt)
        {
            if (pnt.Y > centerXY.Y) pnt.Y = -Math.Abs(pnt.Y - centerXY.Y) / scaler;
            else pnt.Y = Math.Abs(centerXY.Y - pnt.Y) / scaler;
            if (pnt.X > centerXY.X) pnt.X = Math.Abs(pnt.X - centerXY.X) / scaler;
            else pnt.X = -Math.Abs(centerXY.X - pnt.X) / scaler;
            return pnt;
        }

        private PointF FuncToPanelXY(PointF pnt)
        {
            pnt.X = scaler * pnt.X + centerXY.X;
            pnt.Y = -scaler * pnt.Y + centerXY.Y;
            return pnt;
        }
        #endregion

        #region Draw methods
        private void DrawFunc(Graphics g)
        {
            List<PointF> funcPointList = new List<PointF>();
            PointF pnt = new Point();
            Pen p = new Pen(funcColor);
            p.Width = 2;
            if (function != null)
            {
                for (float i = 0; i < panelFunc.Width; i++)
                {
                    pnt.X = i;
                    pnt.Y = 0;
                    pnt = PanelToFuncXY(pnt);
                    pnt.Y = function.calc(pnt.X);
                    funcPointList.Add(FuncToPanelXY(pnt));
                }
                for (int i = 1; i < funcPointList.Count(); i++) {
                    if (funcPointList[i - 1].Y <= funcPointList[i].Y && function is tg)
                    {
                        PointF tgPoint = new PointF(funcPointList[i - 1].X, 0);
                        g.DrawLine(p, funcPointList[i - 1], tgPoint);
                        tgPoint = new PointF(funcPointList[i].X, panelFunc.Height);
                        g.DrawLine(p, tgPoint, funcPointList[i]);
                        continue;
                    }
                    g.DrawLine(p, funcPointList[i - 1], funcPointList[i]);
                }
            }
        }

        private void DrawBall(Graphics g, PointF position)
        {
            Pen p = new Pen(funcColor);
            PointF currentPoint = FuncToPanelXY(position);
            currentPoint.X -= scaler/2;
            currentPoint.Y -= scaler;
            g.DrawEllipse(p, currentPoint.X, currentPoint.Y, scaler, scaler);
        }

        private void DrawBeziers(Graphics g)
        {
            PointF currentPoint = new PointF();
            PointF nextPoint = new PointF();
            Pen pointPen = new Pen(Color.Orange);
            Pen linePen = new Pen (Color.Black);
            Brush pointBrush = new SolidBrush(Color.OrangeRed);
            pointPen.Width = 6;
            linePen.Width = 2;
            for (int i = 0; i < beziers.Count(); i++)
            {
                currentPoint = FuncToPanelXY(beziers[i].position);
                if (i + 1 != beziers.Count())
                {
                    nextPoint = FuncToPanelXY(beziers[i+1].position);
                    g.DrawLine(linePen, currentPoint, nextPoint);
                }
                currentPoint.X -= 40 / 6;
                currentPoint.Y -= 40 / 6;
                if (movingBezierIndex == i)
                {
                    Pen choosedBezier = new Pen(Color.OrangeRed);
                    choosedBezier.Width = 6;
                    g.DrawEllipse(choosedBezier, currentPoint.X, currentPoint.Y, 40 / 3, 40 / 3);
                    g.FillEllipse(new SolidBrush(Color.Yellow), currentPoint.X, currentPoint.Y, 40 / 3, 40 / 3);
                }
                else
                {
                    g.DrawEllipse(pointPen, currentPoint.X, currentPoint.Y, 40 / 3, 40 / 3);
                    g.FillEllipse(pointBrush, currentPoint.X, currentPoint.Y, 40 / 3, 40 / 3);
                }
            }
        }

        private void DrawCurve(Graphics g, int drawingIndex)
        {
            Pen p = new Pen(funcColor);
            p.Width = 2;
            if (nurbsCreatingMode)
            {
                BezierLine.Add(curveCalc());
                drawingIndex = BezierLine.Count() - 1;
            }
            for (int i = 1; i < BezierLine[drawingIndex].Count(); i++)
            {
                g.DrawLine(p, FuncToPanelXY(BezierLine[drawingIndex][i - 1]), FuncToPanelXY(BezierLine[drawingIndex][i]));
            }
            if (nurbsCreatingMode) BezierLine.Remove(BezierLine.Last());
        }

        private void backgroundStyle(Image recievedImage, Brush recievedBrush)
        {
            if (recievedImage != null)
            {
                panelFunc.BackgroundImage = recievedImage;
            }
            else if (recievedBrush != null)
            {
                backBrush = recievedBrush;
                panelFunc.BackgroundImage = null;
            }
        }
        #endregion

        #region Calculation region
        private List<PointF> curveCalc()
        {
            List<PointF> nurbsDrawingPoints = new List<PointF>();
            for (int i = 0; i < 1000; i++)
            {
                PointF resultPoint = new PointF(0, 0);
                PointF resultPointAdditional = new PointF(0, 0);
                for (int j = 0; j < beziers.Count(); j++)
                {
                    resultPoint.X += Binom((beziers.Count() - 1), j) * (float)Math.Pow((1 - (float)i / 1000), ((beziers.Count() - 1) - j)) * (float)Math.Pow((float)i / 1000, j) * beziers[j].position.X * beziers[j].weight;
                    resultPoint.Y += Binom((beziers.Count() - 1), j) * (float)Math.Pow((1 - (float)i / 1000), ((beziers.Count() - 1) - j)) * (float)Math.Pow((float)i / 1000, j) * beziers[j].position.Y * beziers[j].weight;
                    resultPointAdditional.X += Binom((beziers.Count() - 1), j) * (float)Math.Pow((1 - (float)i / 1000), ((beziers.Count() - 1) - j)) * (float)Math.Pow((float)i / 1000, j) * beziers[j].weight;
                    resultPointAdditional.Y += Binom((beziers.Count() - 1), j) * (float)Math.Pow((1 - (float)i / 1000), ((beziers.Count() - 1) - j)) * (float)Math.Pow((float)i / 1000, j) * beziers[j].weight;
                }
                resultPoint.X = resultPoint.X / resultPointAdditional.X;
                resultPoint.Y = resultPoint.Y / resultPointAdditional.Y;
                nurbsDrawingPoints.Add(resultPoint);
            }
            return nurbsDrawingPoints;
        }

        private float Binom(int n, int k)
        {
            return (float)Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        private int Factorial(int n)
        {
            int res = 1;
            for (int i = 1; i < n+1; i++)
            {
                res *= i;
            }
            return res;
        }
        #endregion

        #region Buttons
        private void buttonRandomFunc_Click(object sender, EventArgs e)
        {
            Random choice = new Random();
            int n = 5;
            if (BezierLine.Count() > 0) n = 6;
            setStartParametres();
            switch (choice.Next(0, n))
            {
                case 0:
                    function = new _2x_5();
                    break;
                case 1:
                    function = new x_2();
                    break;
                case 2:
                    function = new x_3();
                    break;
                case 3:
                    function = new sin();
                    break;
                case 4:
                    function = new tg();
                    break;
                case 5:
                    drawingIndex = choice.Next(0, BezierLine.Count());
                    buttonBall.Enabled = false;
                    function = null;
                    randomNurb = true;
                    break;
            }
            panelFunc.Invalidate();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "jpg Image |*.jpg";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(panelFunc.Width, panelFunc.Height);
                panelFunc.DrawToBitmap(bmp, new Rectangle(0, 0, panelFunc.Width, panelFunc.Height));
                bmp.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }

        }

        private void buttonColorFunc_Click(object sender, EventArgs e)
        {
            ColorDialog colorChanger = new ColorDialog();
            colorChanger.FullOpen = true;
            colorChanger.Color = funcColor;
            if (colorChanger.ShowDialog() == DialogResult.Cancel) return;
            funcColor = colorChanger.Color;
            panelFunc.Invalidate();
        }

        private void buttonBackground_Click(object sender, EventArgs e)
        {
            FormBackground background = new FormBackground(panelFunc.BackgroundImage, panelFunc.ClientRectangle);
            background.dataEnter += backgroundStyle;
            background.ShowDialog();
            panelFunc.Invalidate();
        }

        private void buttonBall_Click(object sender, EventArgs e)
        {
            if (function != null)
            {
                ballPoint = new PointF(0, 0);
                ballPoint = PanelToFuncXY(ballPoint);
                ballPoint.Y = function.calc(ballPoint.X);
                ballExists = true;
                panelFunc.Invalidate();
            }
        }

        private void buttonNURBS_Click(object sender, EventArgs e)
        {
            setStartParametres();
            nurbsCreatingMode = true;
            panelFunc.Invalidate();
        }

        private void buttonStartScale_Click(object sender, EventArgs e)
        {
            centerXY = new PointF((panelFunc.Right - panelFunc.Left) / 2 + panelFunc.Left, (panelFunc.Top - panelFunc.Bottom) / 2 + panelFunc.Bottom);
            scaler = 40;
            textBoxBezier.Enabled = false;
            textBoxBezier.Text = labelBezier.Text = " ";
            panelFunc.Invalidate();
        }
        #endregion

        #region panelFunc
        private void PanelFunc_Paint(object sender, PaintEventArgs e)
        {
            if (panelFunc.BackgroundImage == null) e.Graphics.FillRectangle(backBrush, panelFunc.ClientRectangle);
            XYLinesInit(e.Graphics);
            DrawFunc(e.Graphics);
            if (randomNurb) DrawCurve(e.Graphics, drawingIndex);
            if (ballExists) DrawBall(e.Graphics, ballPoint);
            if (nurbsCreatingMode && beziers != null)
            {
                DrawBeziers(e.Graphics);
                if (beziers.Count() > 2) DrawCurve(e.Graphics, drawingIndex);
            }
        }

        private void PanelFunc_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && scaler < 300)
                scaler *= 1.1f;
            else if (e.Delta < 0 && scaler > 5)
                scaler /= 1.1f;
            panelFunc.Invalidate();
            if (scaler != 40) label1.Text = ((float)scaler / 40).ToString();
        }

        private void panelFunc_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < beziers.Count(); i++)
                {
                    PointF currentBezier = FuncToPanelXY(beziers[i].position);
                    if (Math.Abs(e.Location.X - currentBezier.X) < 40 / 3 && Math.Abs(e.Location.Y - currentBezier.Y) < 40 / 3)
                    {
                        movingBezierIndex = i;
                        isMovingBezier = true;
                        lastXY = e.Location;
                        textBoxBezier.Enabled = true;
                        if (movingBezierIndex != -1) textBoxBezier.Text = beziers[movingBezierIndex].weight.ToString();
                        labelBezier.Text = "- вес точки";
                        return;
                    }
                }
                movingBezierIndex = -1;
                isMovingScreen = true;
                lastXY = e.Location;
            }
            //else if ()
        }

        private void panelFunc_MouseUp(object sender, MouseEventArgs e)
        {
            isMovingScreen = isMovingBezier = false;
        }

        private void panelFunc_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMovingBezier)
            {
                PointF currentXY = e.Location;
                PointF delta = new PointF();
                delta.X = currentXY.X - lastXY.X;
                delta.Y = currentXY.Y - lastXY.Y;
                lastXY = FuncToPanelXY(beziers[movingBezierIndex].position);
                lastXY.X += delta.X;
                lastXY.Y += delta.Y;
                beziers[movingBezierIndex].position = PanelToFuncXY(lastXY);
                lastXY = currentXY;
                panelFunc.Invalidate();
            }
            else if (isMovingScreen)
            {
                PointF currentXY = e.Location;
                PointF delta = new PointF();
                delta.X = currentXY.X - lastXY.X;
                delta.Y = currentXY.Y - lastXY.Y;
                lastXY = currentXY;
                centerXY.X += delta.X;
                centerXY.Y += delta.Y;
                panelFunc.Invalidate();
            }
        }

        private void panelFunc_MouseClick(object sender, MouseEventArgs e)
        {
            PointF position = e.Location;
            if (nurbsCreatingMode && e.Button == MouseButtons.Right)
            {
                if (movingBezierIndex != -1)
                {
                    movingBezierIndex = -1;
                    textBoxBezier.Enabled = false;
                    textBoxBezier.Text = labelBezier.Text = " ";
                }
                Array.Resize(ref beziers, beziers.Length + 1);
                beziers[beziers.Length - 1].position = PanelToFuncXY(e.Location);
                beziers[beziers.Length - 1].weight = 1;
            }
            else if (nurbsCreatingMode && e.Button == MouseButtons.Left)
            {
                //textBoxBezier.Enabled = false;
                //textBoxBezier.Text = labelBezier.Text = " ";
                for (int i = 0; i < beziers.Count(); i++)
                {
                    PointF currentBezier = FuncToPanelXY(beziers[i].position);
                    if (Math.Abs(position.X - currentBezier.X) < 40 / 3 && Math.Abs(position.Y - currentBezier.Y) < 40 / 3)
                    {
                        movingBezierIndex = i;
                        textBoxBezier.Enabled = true;
                        if (movingBezierIndex != -1) textBoxBezier.Text = beziers[movingBezierIndex].weight.ToString();
                        labelBezier.Text = "- вес точки";
                        break;
                    }
                }
            }
            panelFunc.Invalidate();
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (function != null)
            {
                ballPoint.X += 0.5F;
                ballPoint.Y = function.calc(ballPoint.X);
                panelFunc.Invalidate();
            }
        }

        private void textBoxBezier_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBezier.Text.Length > 0 && movingBezierIndex != -1)
            {
                float res = 0;
                float.TryParse(textBoxBezier.Text, out res);
                if (res > -1) beziers[movingBezierIndex].weight = res;
                panelFunc.Invalidate();
            }
        }

        private void buttonSaveNURBS_Click(object sender, EventArgs e)
        {
            BezierLine.Add(curveCalc());
        }
    }
}
