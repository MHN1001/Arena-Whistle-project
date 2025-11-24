namespace ShowAllStadiums_ControlLibrary.Stadiums.Reeservation
{
    partial class UC_ShowReservationOverView
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
            this.uC_StadiumInfosSummary1 = new ShowAllStadiums_ControlLibrary.Stadiums.UC_StadiumInfosSummary();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.uC_PersonnalInfosAsSummary1 = new ShowAllStadiums_ControlLibrary.Person.UC_PersonnalInfosAsSummary();
            this.guna2GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lblTitle.Location = new System.Drawing.Point(288, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(335, 49);
            this.lblTitle.TabIndex = 335;
            this.lblTitle.Text = "Reserve Informations";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uC_StadiumInfosSummary1
            // 
            this.uC_StadiumInfosSummary1.BackColor = System.Drawing.Color.Transparent;
            this.uC_StadiumInfosSummary1.Location = new System.Drawing.Point(56, 102);
            this.uC_StadiumInfosSummary1.Name = "uC_StadiumInfosSummary1";
            this.uC_StadiumInfosSummary1.Size = new System.Drawing.Size(830, 172);
            this.uC_StadiumInfosSummary1.TabIndex = 337;
            this.uC_StadiumInfosSummary1.OnLoadingFailed += new System.Action(this.uC_StadiumInfosSummary1_OnLoadingFailed);
            this.uC_StadiumInfosSummary1.OnShowFullDataButtonClicked += new System.Action<Arena_Whistle_Buisness_layer.ClsStadium>(this.uC_StadiumInfosSummary1_OnShowFullDataButtonClicked);
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox3.BorderRadius = 10;
            this.guna2GroupBox3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2GroupBox3.BorderThickness = 2;
            this.guna2GroupBox3.Controls.Add(this.txtStatus);
            this.guna2GroupBox3.Controls.Add(this.guna2HtmlLabel11);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.DarkSlateGray;
            this.guna2GroupBox3.FillColor = System.Drawing.Color.LightCyan;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Cyan;
            this.guna2GroupBox3.Location = new System.Drawing.Point(531, 280);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(355, 244);
            this.guna2GroupBox3.TabIndex = 367;
            this.guna2GroupBox3.Text = "Reserve Infos";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoRoundedCorners = true;
            this.txtStatus.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtStatus.BackColor = System.Drawing.Color.Transparent;
            this.txtStatus.BorderColor = System.Drawing.Color.Cyan;
            this.txtStatus.BorderRadius = 14;
            this.txtStatus.BorderThickness = 2;
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStatus.DefaultText = "dsddddddd";
            this.txtStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStatus.FillColor = System.Drawing.Color.SlateGray;
            this.txtStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtStatus.ForeColor = System.Drawing.Color.Aqua;
            this.txtStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStatus.Location = new System.Drawing.Point(150, 64);
            this.txtStatus.MaxLength = 15;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PlaceholderText = "";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.SelectedText = "";
            this.txtStatus.Size = new System.Drawing.Size(202, 31);
            this.txtStatus.TabIndex = 335;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(14, 61);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(77, 31);
            this.guna2HtmlLabel11.TabIndex = 307;
            this.guna2HtmlLabel11.Text = "Status : ";
            // 
            // uC_PersonnalInfosAsSummary1
            // 
            this.uC_PersonnalInfosAsSummary1.BackColor = System.Drawing.Color.Transparent;
            this.uC_PersonnalInfosAsSummary1.Location = new System.Drawing.Point(56, 280);
            this.uC_PersonnalInfosAsSummary1.Name = "uC_PersonnalInfosAsSummary1";
            this.uC_PersonnalInfosAsSummary1.Size = new System.Drawing.Size(388, 244);
            this.uC_PersonnalInfosAsSummary1.TabIndex = 368;
            this.uC_PersonnalInfosAsSummary1.OnPersonDataLoadFailed += new System.Action(this.uC_PersonnalInfosAsSummary1_OnPersonDataLoadFailed);
            this.uC_PersonnalInfosAsSummary1.OnShowAllInfosButtonClick += new System.Action<Arena_Whistle_Buisness_layerm.ClsPerson>(this.uC_PersonnalInfosAsSummary1_OnShowAllInfosButtonClick);
            // 
            // UC_ShowReservationOverView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.uC_PersonnalInfosAsSummary1);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.uC_StadiumInfosSummary1);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_ShowReservationOverView";
            this.Size = new System.Drawing.Size(946, 587);
            this.Load += new System.EventHandler(this.UC_ShowReservationOverView_Load);
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private UC_StadiumInfosSummary uC_StadiumInfosSummary1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2TextBox txtStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Person.UC_PersonnalInfosAsSummary uC_PersonnalInfosAsSummary1;
    }
}
