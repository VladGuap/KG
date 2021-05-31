namespace tomogram_visualizer
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
			this.glControl1 = new OpenTK.GLControl();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			this.trackBar3 = new System.Windows.Forms.TrackBar();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
			this.SuspendLayout();
			// 
			// glControl1
			// 
			this.glControl1.BackColor = System.Drawing.Color.Black;
			this.glControl1.Location = new System.Drawing.Point(287, 12);
			this.glControl1.Name = "glControl1";
			this.glControl1.Size = new System.Drawing.Size(501, 410);
			this.glControl1.TabIndex = 0;
			this.glControl1.VSync = false;
			this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(100, 225);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(168, 45);
			this.trackBar1.TabIndex = 2;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// trackBar2
			// 
			this.trackBar2.Location = new System.Drawing.Point(100, 302);
			this.trackBar2.Maximum = 1500;
			this.trackBar2.Minimum = -1000;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(168, 45);
			this.trackBar2.TabIndex = 3;
			this.trackBar2.Value = 11;
			this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
			// 
			// trackBar3
			// 
			this.trackBar3.Location = new System.Drawing.Point(100, 377);
			this.trackBar3.Maximum = 1000;
			this.trackBar3.Minimum = 10;
			this.trackBar3.Name = "trackBar3";
			this.trackBar3.Size = new System.Drawing.Size(168, 45);
			this.trackBar3.TabIndex = 4;
			this.trackBar3.Value = 94;
			this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 225);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Current layer:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 302);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Minimum TF:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 377);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Width TF:";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(11, 125);
			this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(56, 17);
			this.radioButton1.TabIndex = 11;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Quads";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(118, 176);
			this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(61, 17);
			this.radioButton2.TabIndex = 12;
			this.radioButton2.Text = "Texture";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(11, 176);
			this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(80, 17);
			this.radioButton3.TabIndex = 13;
			this.radioButton3.Text = "Quads Strip";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.trackBar3);
			this.Controls.Add(this.trackBar2);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.glControl1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Tomogram";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

