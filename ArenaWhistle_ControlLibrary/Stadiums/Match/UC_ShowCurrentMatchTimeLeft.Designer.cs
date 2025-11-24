namespace ShowAllStadiums_ControlLibrary.Stadiums
{
    partial class UC_ShowCurrentMatchTimeLeft
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
            if(disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.GbMinutesLeft = new Guna.UI2.WinForms.Guna2GroupBox();
            this.LblMinutesLeft = new System.Windows.Forms.Label();
            this.GbTotalSeconds = new Guna.UI2.WinForms.Guna2GroupBox();
            this.LblTotalSeconds = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).BeginInit();
            this.ProgressBar.SuspendLayout();
            this.GbMinutesLeft.SuspendLayout();
            this.GbTotalSeconds.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time Left\r\n";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.guna2GroupBox1.BorderRadius = 17;
            this.guna2GroupBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.guna2PictureBox6);
            this.guna2GroupBox1.Controls.Add(this.ProgressBar);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.RosyBrown;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.CustomizableEdges.BottomLeft = false;
            this.guna2GroupBox1.CustomizableEdges.TopRight = false;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.LightCyan;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(1, 1);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(308, 275);
            this.guna2GroupBox1.TabIndex = 363;
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // guna2PictureBox6
            // 
            this.guna2PictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox6.BackgroundImage = global::ShowAllStadiums_ControlLibrary.Properties.Resources.icons8_time_left_100;
            this.guna2PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox6.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox6.ImageRotate = 0F;
            this.guna2PictureBox6.Location = new System.Drawing.Point(190, 0);
            this.guna2PictureBox6.Name = "guna2PictureBox6";
            this.guna2PictureBox6.Size = new System.Drawing.Size(38, 44);
            this.guna2PictureBox6.TabIndex = 385;
            this.guna2PictureBox6.TabStop = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Controls.Add(this.GbMinutesLeft);
            this.ProgressBar.Controls.Add(this.GbTotalSeconds);
            this.ProgressBar.FillColor = System.Drawing.Color.Lime;
            this.ProgressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProgressBar.ForeColor = System.Drawing.Color.White;
            this.ProgressBar.Location = new System.Drawing.Point(41, 47);
            this.ProgressBar.Minimum = 0;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressColor = System.Drawing.Color.Red;
            this.ProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProgressBar.Size = new System.Drawing.Size(222, 222);
            this.ProgressBar.TabIndex = 4;
            this.ProgressBar.Text = "ProgressBar";
            this.ProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.ProgressBar.Value = 12;
            // 
            // GbMinutesLeft
            // 
            this.GbMinutesLeft.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.GbMinutesLeft.BorderRadius = 10;
            this.GbMinutesLeft.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.GbMinutesLeft.BorderThickness = 0;
            this.GbMinutesLeft.Controls.Add(this.LblMinutesLeft);
            this.GbMinutesLeft.CustomBorderColor = System.Drawing.Color.RosyBrown;
            this.GbMinutesLeft.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.GbMinutesLeft.FillColor = System.Drawing.Color.LightCyan;
            this.GbMinutesLeft.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GbMinutesLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GbMinutesLeft.Location = new System.Drawing.Point(35, 71);
            this.GbMinutesLeft.Name = "GbMinutesLeft";
            this.GbMinutesLeft.Size = new System.Drawing.Size(153, 51);
            this.GbMinutesLeft.TabIndex = 387;
            // 
            // LblMinutesLeft
            // 
            this.LblMinutesLeft.AutoSize = true;
            this.LblMinutesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMinutesLeft.ForeColor = System.Drawing.Color.Red;
            this.LblMinutesLeft.Location = new System.Drawing.Point(34, 11);
            this.LblMinutesLeft.Name = "LblMinutesLeft";
            this.LblMinutesLeft.Size = new System.Drawing.Size(87, 31);
            this.LblMinutesLeft.TabIndex = 3;
            this.LblMinutesLeft.Text = "00:00";
            // 
            // GbTotalSeconds
            // 
            this.GbTotalSeconds.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.GbTotalSeconds.BorderRadius = 10;
            this.GbTotalSeconds.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.GbTotalSeconds.BorderThickness = 0;
            this.GbTotalSeconds.Controls.Add(this.LblTotalSeconds);
            this.GbTotalSeconds.CustomBorderColor = System.Drawing.Color.RosyBrown;
            this.GbTotalSeconds.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.GbTotalSeconds.FillColor = System.Drawing.Color.LightCyan;
            this.GbTotalSeconds.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GbTotalSeconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GbTotalSeconds.Location = new System.Drawing.Point(52, 140);
            this.GbTotalSeconds.Name = "GbTotalSeconds";
            this.GbTotalSeconds.Size = new System.Drawing.Size(122, 34);
            this.GbTotalSeconds.TabIndex = 386;
            // 
            // LblTotalSeconds
            // 
            this.LblTotalSeconds.AutoSize = true;
            this.LblTotalSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalSeconds.ForeColor = System.Drawing.Color.Red;
            this.LblTotalSeconds.Location = new System.Drawing.Point(41, 6);
            this.LblTotalSeconds.Name = "LblTotalSeconds";
            this.LblTotalSeconds.Size = new System.Drawing.Size(33, 20);
            this.LblTotalSeconds.TabIndex = 3;
            this.LblTotalSeconds.Text = "0 s";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // UC_ShowCurrentMatchTimeLeft
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "UC_ShowCurrentMatchTimeLeft";
            this.Size = new System.Drawing.Size(309, 276);
            this.Load += new System.EventHandler(this.UC_ShowCurrentMatchTimeLeft_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).EndInit();
            this.ProgressBar.ResumeLayout(false);
            this.GbMinutesLeft.ResumeLayout(false);
            this.GbMinutesLeft.PerformLayout();
            this.GbTotalSeconds.ResumeLayout(false);
            this.GbTotalSeconds.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label LblTotalSeconds;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressBar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox6;
        private System.Windows.Forms.Timer timer;
        private Guna.UI2.WinForms.Guna2GroupBox GbTotalSeconds;
        private Guna.UI2.WinForms.Guna2GroupBox GbMinutesLeft;
        private System.Windows.Forms.Label LblMinutesLeft;
    }
}
