namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelBezier = new System.Windows.Forms.Label();
            this.textBoxBezier = new System.Windows.Forms.TextBox();
            this.buttonNURBS = new System.Windows.Forms.Button();
            this.buttonBall = new System.Windows.Forms.Button();
            this.buttonStartScale = new System.Windows.Forms.Button();
            this.buttonBackground = new System.Windows.Forms.Button();
            this.buttonColorFunc = new System.Windows.Forms.Button();
            this.buttonRandomFunc = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonSaveNURBS = new System.Windows.Forms.Button();
            this.panelFunc = new Lab2.DbBufPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panelFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSaveNURBS);
            this.groupBox1.Controls.Add(this.labelBezier);
            this.groupBox1.Controls.Add(this.textBoxBezier);
            this.groupBox1.Controls.Add(this.buttonNURBS);
            this.groupBox1.Controls.Add(this.buttonBall);
            this.groupBox1.Controls.Add(this.buttonStartScale);
            this.groupBox1.Controls.Add(this.buttonBackground);
            this.groupBox1.Controls.Add(this.buttonColorFunc);
            this.groupBox1.Controls.Add(this.buttonRandomFunc);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(374, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // labelBezier
            // 
            this.labelBezier.AutoSize = true;
            this.labelBezier.Location = new System.Drawing.Point(103, 254);
            this.labelBezier.Name = "labelBezier";
            this.labelBezier.Size = new System.Drawing.Size(0, 13);
            this.labelBezier.TabIndex = 10;
            // 
            // textBoxBezier
            // 
            this.textBoxBezier.Location = new System.Drawing.Point(2, 251);
            this.textBoxBezier.Name = "textBoxBezier";
            this.textBoxBezier.Size = new System.Drawing.Size(95, 20);
            this.textBoxBezier.TabIndex = 9;
            this.textBoxBezier.TextChanged += new System.EventHandler(this.textBoxBezier_TextChanged);
            // 
            // buttonNURBS
            // 
            this.buttonNURBS.Location = new System.Drawing.Point(2, 138);
            this.buttonNURBS.Name = "buttonNURBS";
            this.buttonNURBS.Size = new System.Drawing.Size(101, 21);
            this.buttonNURBS.TabIndex = 7;
            this.buttonNURBS.Text = "NURBS";
            this.buttonNURBS.UseVisualStyleBackColor = true;
            this.buttonNURBS.Click += new System.EventHandler(this.buttonNURBS_Click);
            // 
            // buttonBall
            // 
            this.buttonBall.Location = new System.Drawing.Point(2, 111);
            this.buttonBall.Name = "buttonBall";
            this.buttonBall.Size = new System.Drawing.Size(207, 21);
            this.buttonBall.TabIndex = 6;
            this.buttonBall.Text = "Шар";
            this.buttonBall.UseVisualStyleBackColor = true;
            this.buttonBall.Click += new System.EventHandler(this.buttonBall_Click);
            // 
            // buttonStartScale
            // 
            this.buttonStartScale.Location = new System.Drawing.Point(175, 248);
            this.buttonStartScale.Name = "buttonStartScale";
            this.buttonStartScale.Size = new System.Drawing.Size(34, 23);
            this.buttonStartScale.TabIndex = 5;
            this.buttonStartScale.Text = "1.0";
            this.buttonStartScale.UseVisualStyleBackColor = true;
            this.buttonStartScale.Click += new System.EventHandler(this.buttonStartScale_Click);
            // 
            // buttonBackground
            // 
            this.buttonBackground.Location = new System.Drawing.Point(106, 68);
            this.buttonBackground.Name = "buttonBackground";
            this.buttonBackground.Size = new System.Drawing.Size(103, 21);
            this.buttonBackground.TabIndex = 4;
            this.buttonBackground.Text = "Стиль фона";
            this.buttonBackground.UseVisualStyleBackColor = true;
            this.buttonBackground.Click += new System.EventHandler(this.buttonBackground_Click);
            // 
            // buttonColorFunc
            // 
            this.buttonColorFunc.Location = new System.Drawing.Point(2, 68);
            this.buttonColorFunc.Name = "buttonColorFunc";
            this.buttonColorFunc.Size = new System.Drawing.Size(101, 21);
            this.buttonColorFunc.TabIndex = 3;
            this.buttonColorFunc.Text = "Цвет графика";
            this.buttonColorFunc.UseVisualStyleBackColor = true;
            this.buttonColorFunc.Click += new System.EventHandler(this.buttonColorFunc_Click);
            // 
            // buttonRandomFunc
            // 
            this.buttonRandomFunc.Location = new System.Drawing.Point(2, 12);
            this.buttonRandomFunc.Name = "buttonRandomFunc";
            this.buttonRandomFunc.Size = new System.Drawing.Size(207, 21);
            this.buttonRandomFunc.TabIndex = 1;
            this.buttonRandomFunc.Text = "Случайная функция";
            this.buttonRandomFunc.UseVisualStyleBackColor = true;
            this.buttonRandomFunc.Click += new System.EventHandler(this.buttonRandomFunc_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(2, 39);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(207, 21);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить как изображение";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonSaveNURBS
            // 
            this.buttonSaveNURBS.Location = new System.Drawing.Point(110, 135);
            this.buttonSaveNURBS.Name = "buttonSaveNURBS";
            this.buttonSaveNURBS.Size = new System.Drawing.Size(99, 23);
            this.buttonSaveNURBS.TabIndex = 11;
            this.buttonSaveNURBS.Text = "Сохр. NURBS";
            this.buttonSaveNURBS.UseVisualStyleBackColor = true;
            this.buttonSaveNURBS.Click += new System.EventHandler(this.buttonSaveNURBS_Click);
            // 
            // panelFunc
            // 
            this.panelFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFunc.Controls.Add(this.label1);
            this.panelFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFunc.Location = new System.Drawing.Point(0, 0);
            this.panelFunc.Name = "panelFunc";
            this.panelFunc.Size = new System.Drawing.Size(374, 277);
            this.panelFunc.TabIndex = 1;
            this.panelFunc.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelFunc_Paint);
            this.panelFunc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelFunc_MouseClick);
            this.panelFunc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFunc_MouseDown);
            this.panelFunc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelFunc_MouseMove);
            this.panelFunc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelFunc_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 277);
            this.Controls.Add(this.panelFunc);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MyDesmos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelFunc.ResumeLayout(false);
            this.panelFunc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBackground;
        private System.Windows.Forms.Button buttonColorFunc;
        private System.Windows.Forms.Button buttonRandomFunc;
        private System.Windows.Forms.Button buttonSave;
        private DbBufPanel panelFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStartScale;
        private System.Windows.Forms.Button buttonBall;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonNURBS;
        private System.Windows.Forms.Label labelBezier;
        private System.Windows.Forms.TextBox textBoxBezier;
        private System.Windows.Forms.Button buttonSaveNURBS;
    }
}

