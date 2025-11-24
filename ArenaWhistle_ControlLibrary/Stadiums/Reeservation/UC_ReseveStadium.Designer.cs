namespace ShowAllStadiums_ControlLibrary.Stadiums
{
    partial class UC_ReserveStadium
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
            this.btnReserve = new Guna.UI2.WinForms.Guna2Button();
            this.uC_PersonnalInfosAsSummary1 = new ShowAllStadiums_ControlLibrary.Person.UC_PersonnalInfosAsSummary();
            this.uC_StadiumInfosSummary1 = new ShowAllStadiums_ControlLibrary.Stadiums.UC_StadiumInfosSummary();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lblTitle.Location = new System.Drawing.Point(355, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(245, 46);
            this.lblTitle.TabIndex = 334;
            this.lblTitle.Text = "Reserve Stadium ";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReserve
            // 
            this.btnReserve.Animated = true;
            this.btnReserve.AutoRoundedCorners = true;
            this.btnReserve.BackColor = System.Drawing.Color.Transparent;
            this.btnReserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReserve.BorderColor = System.Drawing.Color.Cyan;
            this.btnReserve.BorderThickness = 2;
            this.btnReserve.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnReserve.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReserve.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReserve.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReserve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReserve.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnReserve.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnReserve.ForeColor = System.Drawing.Color.Aqua;
            this.btnReserve.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnReserve.IndicateFocus = true;
            this.btnReserve.Location = new System.Drawing.Point(183, 412);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(180, 40);
            this.btnReserve.TabIndex = 359;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseTransparentBackground = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // uC_PersonnalInfosAsSummary1
            // 
            this.uC_PersonnalInfosAsSummary1.BackColor = System.Drawing.Color.Black;
            this.uC_PersonnalInfosAsSummary1.Location = new System.Drawing.Point(502, 303);
            this.uC_PersonnalInfosAsSummary1.Name = "uC_PersonnalInfosAsSummary1";
            this.uC_PersonnalInfosAsSummary1.ShowFullDataButton = true;
            this.uC_PersonnalInfosAsSummary1.Size = new System.Drawing.Size(388, 244);
            this.uC_PersonnalInfosAsSummary1.TabIndex = 360;
            this.uC_PersonnalInfosAsSummary1.OnPersonDataLoadFailed += new System.Action(this.uC_PersonnalInfosAsSummary1_OnPersonDataLoadFailed);
            this.uC_PersonnalInfosAsSummary1.OnShowAllInfosButtonClick += new System.Action<Arena_Whistle_Buisness_layerm.ClsPerson>(this.uC_PersonnalInfosAsSummary1_OnShowAllInfosButtonClick);
            // 
            // uC_StadiumInfosSummary1
            // 
            this.uC_StadiumInfosSummary1.BackColor = System.Drawing.Color.Transparent;
            this.uC_StadiumInfosSummary1.Location = new System.Drawing.Point(60, 86);
            this.uC_StadiumInfosSummary1.Name = "uC_StadiumInfosSummary1";
            this.uC_StadiumInfosSummary1.ShowFullDataButton = true;
            this.uC_StadiumInfosSummary1.Size = new System.Drawing.Size(830, 172);
            this.uC_StadiumInfosSummary1.TabIndex = 361;
            this.uC_StadiumInfosSummary1.OnLoadingFailed += new System.Action(this.uC_StadiumInfosSummary1_OnLoadingFailed);
            this.uC_StadiumInfosSummary1.OnShowFullDataButtonClicked += new System.Action<Arena_Whistle_Buisness_layer.ClsStadium>(this.uC_StadiumInfosSummary1_OnShowFullDataButtonClicked);
            // 
            // UC_ReserveStadium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.uC_StadiumInfosSummary1);
            this.Controls.Add(this.uC_PersonnalInfosAsSummary1);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_ReserveStadium";
            this.Size = new System.Drawing.Size(946, 587);
            this.Load += new System.EventHandler(this.UC_ReseveStadium_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnReserve;
        private Person.UC_PersonnalInfosAsSummary uC_PersonnalInfosAsSummary1;
        private UC_StadiumInfosSummary uC_StadiumInfosSummary1;
    }
}
