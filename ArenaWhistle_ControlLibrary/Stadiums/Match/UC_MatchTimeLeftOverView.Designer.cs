namespace ShowAllStadiums_ControlLibrary.Stadiums.Match
{
    partial class UC_MatchTimeLeftOverView
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
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.uC_BookingInfosSummary1 = new ShowAllStadiums_ControlLibrary.Stadiums.UC_BookingInfosSummary();
            this.uC_StadiumInfosSummary1 = new ShowAllStadiums_ControlLibrary.Stadiums.UC_StadiumInfosSummary();
            this.uC_ShowCurrentMatchTimeLeft1 = new ShowAllStadiums_ControlLibrary.Stadiums.UC_ShowCurrentMatchTimeLeft();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lblTitle.Location = new System.Drawing.Point(268, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(382, 49);
            this.lblTitle.TabIndex = 337;
            this.lblTitle.Text = "Current Match Overview";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // uC_BookingInfosSummary1
            // 
            this.uC_BookingInfosSummary1.BackColor = System.Drawing.Color.Transparent;
            this.uC_BookingInfosSummary1.Location = new System.Drawing.Point(497, 326);
            this.uC_BookingInfosSummary1.Name = "uC_BookingInfosSummary1";
            this.uC_BookingInfosSummary1.ShowFullDataButton = false;
            this.uC_BookingInfosSummary1.Size = new System.Drawing.Size(388, 244);
            this.uC_BookingInfosSummary1.TabIndex = 2;
            this.uC_BookingInfosSummary1.OnLoadingFailed += new System.Action(this.uC_BookingInfosSummary1_OnLoadingFailed);
            // 
            // uC_StadiumInfosSummary1
            // 
            this.uC_StadiumInfosSummary1.BackColor = System.Drawing.Color.Transparent;
            this.uC_StadiumInfosSummary1.Location = new System.Drawing.Point(57, 115);
            this.uC_StadiumInfosSummary1.Name = "uC_StadiumInfosSummary1";
            this.uC_StadiumInfosSummary1.ShowFullDataButton = false;
            this.uC_StadiumInfosSummary1.Size = new System.Drawing.Size(830, 172);
            this.uC_StadiumInfosSummary1.TabIndex = 1;
            this.uC_StadiumInfosSummary1.OnLoadingFailed += new System.Action(this.uC_StadiumInfosSummary1_OnLoadingFailed);
            // 
            // uC_ShowCurrentMatchTimeLeft1
            // 
            this.uC_ShowCurrentMatchTimeLeft1.BackColor = System.Drawing.Color.Transparent;
            this.uC_ShowCurrentMatchTimeLeft1.Location = new System.Drawing.Point(57, 309);
            this.uC_ShowCurrentMatchTimeLeft1.Name = "uC_ShowCurrentMatchTimeLeft1";
            this.uC_ShowCurrentMatchTimeLeft1.Size = new System.Drawing.Size(309, 276);
            this.uC_ShowCurrentMatchTimeLeft1.TabIndex = 0;
            this.uC_ShowCurrentMatchTimeLeft1.OnLoadingFailed += new System.Action(this.uC_ShowCurrentMatchTimeLeft1_OnLoadingFailed);
            this.uC_ShowCurrentMatchTimeLeft1.OnCurrentMatchIsDone += new System.Action(this.uC_ShowCurrentMatchTimeLeft1_OnCurrentMatchIsDone);
            // 
            // UC_MatchTimeLeftOverView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.uC_BookingInfosSummary1);
            this.Controls.Add(this.uC_StadiumInfosSummary1);
            this.Controls.Add(this.uC_ShowCurrentMatchTimeLeft1);
            this.Name = "UC_MatchTimeLeftOverView";
            this.Size = new System.Drawing.Size(946, 587);
            this.Load += new System.EventHandler(this.UC_MatchTimeLeftOverView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC_ShowCurrentMatchTimeLeft uC_ShowCurrentMatchTimeLeft1;
        private UC_StadiumInfosSummary uC_StadiumInfosSummary1;
        private UC_BookingInfosSummary uC_BookingInfosSummary1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
    }
}
