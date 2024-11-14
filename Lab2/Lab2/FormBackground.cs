using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Lab2
{
    public partial class FormBackground : Form
    {
        public event Action<Image, Brush> dataEnter;
        private Image backImage;
        private Brush backBrush;
        private ColorBlend cBlend = new ColorBlend(3);
        private RectangleF rect1;
        public FormBackground(Image lastImage, RectangleF panelForm1)
        {
            InitializeComponent();
            backBrush = new SolidBrush(Color.White);
            backImage = lastImage;
            panelExample.Invalidate();
            rect1 = panelForm1;
            for (int i = 0; i < cBlend.Colors.Length; i++) cBlend.Colors[i] = Color.White;
        }

        private void backImageCreator()
        {
            Bitmap bmp = new Bitmap(panelExample.Width, panelExample.Height);
            panelExample.DrawToBitmap(bmp, new Rectangle(0, 0, panelExample.Width, panelExample.Height));
            backImage = bmp;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorChanger = new ColorDialog();
            colorChanger.FullOpen = true;
            if (colorChanger.ShowDialog() == DialogResult.Cancel) return;
            backBrush = new SolidBrush(colorChanger.Color);
            panelExample.Invalidate();
            backImageCreator();
        }
        private void buttonGrad_Click(object sender, EventArgs e)
        {
            FormGradColor gradColorSelector = new FormGradColor(1, cBlend);
            gradColorSelector.dataEnter += ColorReceiver;
            gradColorSelector.ShowDialog();
            LinearGradientBrush gradientBrush = new LinearGradientBrush(panelExample.ClientRectangle, cBlend.Colors[0], cBlend.Colors[2], 45);
            cBlend.Positions = new float[3] { 0f, 0.5f, 1f };
            gradientBrush.InterpolationColors = cBlend;
            backBrush = gradientBrush;
            panelExample.Invalidate();
            backImageCreator();
        }

        private void buttonLines_Click(object sender, EventArgs e)
        {
            FormGradColor gradColorSelector = new FormGradColor(2, cBlend);
            gradColorSelector.dataEnter += ColorReceiver;
            gradColorSelector.ShowDialog();
            backBrush = new HatchBrush(HatchStyle.DiagonalCross, cBlend.Colors[0], cBlend.Colors[1]);
            panelExample.Invalidate();
            backImage = null;
        }

        private void buttonpath_Click(object sender, EventArgs e)
        {
            FormGradColor gradColorSelector = new FormGradColor(3, cBlend);
            gradColorSelector.dataEnter += ColorReceiver;
            gradColorSelector.ShowDialog();
            PointF[] points = new PointF[15];
            Random random = new Random();
            PointF pnt = new PointF();
            for (int i = 0; i < 15; i++)
            {
                pnt.X = random.Next(0, (int)rect1.Width);
                pnt.Y = random.Next(0, (int)rect1.Height);
                points[i] = pnt;
            }
            PathGradientBrush pathBrush = new PathGradientBrush(points);
            pathBrush.CenterColor = cBlend.Colors[0];
            pathBrush.SurroundColors = new Color[] { cBlend.Colors[1] };
            panelExample.BackColor = cBlend.Colors[2];
            backBrush = pathBrush;
            backImage = null;
            panelExample.Invalidate();
        }

        private void buttonPepega_Click(object sender, EventArgs e)
        {
            TextureBrush textureBrush = new TextureBrush(Properties.Resources.pepe);
            textureBrush.ScaleTransform((float)panelExample.Width / Properties.Resources.pepe.Width, (float)panelExample.Height / Properties.Resources.pepe.Height);
            backBrush = textureBrush;
            panelExample.Invalidate();
            backImage = Properties.Resources.pepe;
        }

        private void buttonTD_Click(object sender, EventArgs e)
        {
            TextureBrush textureBrush = new TextureBrush(Properties.Resources.td);
            textureBrush.ScaleTransform((float)panelExample.Width / Properties.Resources.td.Width, (float)panelExample.Height / Properties.Resources.td.Height);
            backBrush = textureBrush;
            panelExample.Invalidate();
            backImage = Properties.Resources.td;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            dataEnter?.Invoke(backImage, backBrush);
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void panelExample_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(backBrush, panelExample.ClientRectangle);
        }

        private void ColorReceiver(ColorBlend recievedColor)
        {
            cBlend = recievedColor;
        }
    }
}
