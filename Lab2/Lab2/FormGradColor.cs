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

namespace Lab2
{
    public partial class FormGradColor : Form
    {
        public event Action<ColorBlend> dataEnter;
        private ColorDialog colorChanger = new ColorDialog();
        private ColorBlend cBlend = new ColorBlend(3);
        public FormGradColor(int choice, ColorBlend lastBlend)
        {
            InitializeComponent();
            panelColor1.BackColor = cBlend.Colors[0];
            panelColor2.BackColor = cBlend.Colors[1];
            panelColor3.BackColor = cBlend.Colors[2];
            cBlend.Colors = new Color[3];
            if (choice == 2) buttonColor3.Enabled = panelColor3.Enabled = false;
            else if (choice == 3) buttonColor3.Text = "Цвет фона";
            cBlend = lastBlend;
        }

        private void buttonColor1_Click(object sender, EventArgs e)
        {
            colorChanger.Color = cBlend.Colors[0];
            if (colorChanger.ShowDialog() == DialogResult.Cancel) return;
            panelColor1.BackColor = cBlend.Colors[0] = colorChanger.Color;
        }

        private void buttonColor2_Click(object sender, EventArgs e)
        {
            colorChanger.Color = cBlend.Colors[1];
            if (colorChanger.ShowDialog() == DialogResult.Cancel) return;
            panelColor2.BackColor = cBlend.Colors[1] = colorChanger.Color;
        }

        private void buttonColor3_Click(object sender, EventArgs e)
        {
            colorChanger.Color = cBlend.Colors[2];
            if (colorChanger.ShowDialog() == DialogResult.Cancel) return;
            panelColor3.BackColor= cBlend.Colors[2] = colorChanger.Color;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            dataEnter?.Invoke(cBlend);
            DialogResult=DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }
    }
}
