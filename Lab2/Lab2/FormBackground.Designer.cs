namespace Lab2
{
    partial class FormBackground
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelExample = new System.Windows.Forms.Panel();
            this.groupBoxStyles = new System.Windows.Forms.GroupBox();
            this.buttonPepega = new System.Windows.Forms.Button();
            this.buttonpath = new System.Windows.Forms.Button();
            this.buttonLines = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonTD = new System.Windows.Forms.Button();
            this.groupBoxStyles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelExample
            // 
            this.panelExample.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelExample.Location = new System.Drawing.Point(12, 12);
            this.panelExample.Name = "panelExample";
            this.panelExample.Size = new System.Drawing.Size(174, 122);
            this.panelExample.TabIndex = 0;
            this.panelExample.Paint += new System.Windows.Forms.PaintEventHandler(this.panelExample_Paint);
            // 
            // groupBoxStyles
            // 
            this.groupBoxStyles.Controls.Add(this.buttonTD);
            this.groupBoxStyles.Controls.Add(this.buttonPepega);
            this.groupBoxStyles.Controls.Add(this.buttonpath);
            this.groupBoxStyles.Controls.Add(this.buttonLines);
            this.groupBoxStyles.Controls.Add(this.button2);
            this.groupBoxStyles.Controls.Add(this.buttonColor);
            this.groupBoxStyles.Location = new System.Drawing.Point(12, 140);
            this.groupBoxStyles.Name = "groupBoxStyles";
            this.groupBoxStyles.Size = new System.Drawing.Size(174, 197);
            this.groupBoxStyles.TabIndex = 1;
            this.groupBoxStyles.TabStop = false;
            this.groupBoxStyles.Text = "Стили";
            // 
            // buttonPepega
            // 
            this.buttonPepega.Location = new System.Drawing.Point(7, 140);
            this.buttonPepega.Name = "buttonPepega";
            this.buttonPepega.Size = new System.Drawing.Size(161, 23);
            this.buttonPepega.TabIndex = 4;
            this.buttonPepega.Text = "Пепега";
            this.buttonPepega.UseVisualStyleBackColor = true;
            this.buttonPepega.Click += new System.EventHandler(this.buttonPepega_Click);
            // 
            // buttonpath
            // 
            this.buttonpath.Location = new System.Drawing.Point(7, 110);
            this.buttonpath.Name = "buttonpath";
            this.buttonpath.Size = new System.Drawing.Size(161, 23);
            this.buttonpath.TabIndex = 3;
            this.buttonpath.Text = "Путь";
            this.buttonpath.UseVisualStyleBackColor = true;
            this.buttonpath.Click += new System.EventHandler(this.buttonpath_Click);
            // 
            // buttonLines
            // 
            this.buttonLines.Location = new System.Drawing.Point(7, 80);
            this.buttonLines.Name = "buttonLines";
            this.buttonLines.Size = new System.Drawing.Size(161, 23);
            this.buttonLines.TabIndex = 2;
            this.buttonLines.Text = "Штриховка";
            this.buttonLines.UseVisualStyleBackColor = true;
            this.buttonLines.Click += new System.EventHandler(this.buttonLines_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Градиент";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonGrad_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(6, 20);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(162, 23);
            this.buttonColor.TabIndex = 0;
            this.buttonColor.Text = "Заливка";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(19, 343);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(69, 25);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(111, 343);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(69, 25);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonTD
            // 
            this.buttonTD.Location = new System.Drawing.Point(7, 169);
            this.buttonTD.Name = "buttonTD";
            this.buttonTD.Size = new System.Drawing.Size(161, 23);
            this.buttonTD.TabIndex = 5;
            this.buttonTD.Text = "т. д.";
            this.buttonTD.UseVisualStyleBackColor = true;
            this.buttonTD.Click += new System.EventHandler(this.buttonTD_Click);
            // 
            // FormBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 373);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxStyles);
            this.Controls.Add(this.panelExample);
            this.Name = "FormBackground";
            this.Text = "Выбор стиля";
            this.groupBoxStyles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelExample;
        private System.Windows.Forms.GroupBox groupBoxStyles;
        private System.Windows.Forms.Button buttonpath;
        private System.Windows.Forms.Button buttonLines;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonPepega;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonTD;
    }
}