namespace Lab2
{
    partial class FormGradColor
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
            this.buttonColor1 = new System.Windows.Forms.Button();
            this.buttonColor2 = new System.Windows.Forms.Button();
            this.buttonColor3 = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.panelColor1 = new System.Windows.Forms.Panel();
            this.panelColor2 = new System.Windows.Forms.Panel();
            this.panelColor3 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonColor1
            // 
            this.buttonColor1.Location = new System.Drawing.Point(12, 12);
            this.buttonColor1.Name = "buttonColor1";
            this.buttonColor1.Size = new System.Drawing.Size(75, 23);
            this.buttonColor1.TabIndex = 0;
            this.buttonColor1.Text = "Цвет 1";
            this.buttonColor1.UseVisualStyleBackColor = true;
            this.buttonColor1.Click += new System.EventHandler(this.buttonColor1_Click);
            // 
            // buttonColor2
            // 
            this.buttonColor2.Location = new System.Drawing.Point(12, 42);
            this.buttonColor2.Name = "buttonColor2";
            this.buttonColor2.Size = new System.Drawing.Size(75, 23);
            this.buttonColor2.TabIndex = 1;
            this.buttonColor2.Text = "Цвет 2";
            this.buttonColor2.UseVisualStyleBackColor = true;
            this.buttonColor2.Click += new System.EventHandler(this.buttonColor2_Click);
            // 
            // buttonColor3
            // 
            this.buttonColor3.Location = new System.Drawing.Point(13, 72);
            this.buttonColor3.Name = "buttonColor3";
            this.buttonColor3.Size = new System.Drawing.Size(75, 23);
            this.buttonColor3.TabIndex = 2;
            this.buttonColor3.Text = "Цвет 3";
            this.buttonColor3.UseVisualStyleBackColor = true;
            this.buttonColor3.Click += new System.EventHandler(this.buttonColor3_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(13, 102);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(145, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // panelColor1
            // 
            this.panelColor1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelColor1.Location = new System.Drawing.Point(93, 12);
            this.panelColor1.Name = "panelColor1";
            this.panelColor1.Size = new System.Drawing.Size(64, 23);
            this.panelColor1.TabIndex = 4;
            // 
            // panelColor2
            // 
            this.panelColor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelColor2.Location = new System.Drawing.Point(93, 41);
            this.panelColor2.Name = "panelColor2";
            this.panelColor2.Size = new System.Drawing.Size(64, 23);
            this.panelColor2.TabIndex = 5;
            // 
            // panelColor3
            // 
            this.panelColor3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelColor3.Location = new System.Drawing.Point(93, 70);
            this.panelColor3.Name = "panelColor3";
            this.panelColor3.Size = new System.Drawing.Size(64, 23);
            this.panelColor3.TabIndex = 5;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(13, 132);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(145, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormGradColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 167);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.panelColor3);
            this.Controls.Add(this.panelColor2);
            this.Controls.Add(this.panelColor1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonColor3);
            this.Controls.Add(this.buttonColor2);
            this.Controls.Add(this.buttonColor1);
            this.Name = "FormGradColor";
            this.Text = "Градиент";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonColor1;
        private System.Windows.Forms.Button buttonColor2;
        private System.Windows.Forms.Button buttonColor3;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Panel panelColor1;
        private System.Windows.Forms.Panel panelColor2;
        private System.Windows.Forms.Panel panelColor3;
        private System.Windows.Forms.Button buttonCancel;
    }
}