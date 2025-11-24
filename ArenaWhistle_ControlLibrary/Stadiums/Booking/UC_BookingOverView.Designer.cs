namespace ShowAllStadiums_ControlLibrary.Stadiums
{
    partial class UC_BookingOverView
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
            this.uC_BookingInfosSummary1 = new ShowAllStadiums_ControlLibrary.Stadiums.UC_BookingInfosSummary();
            this.uC_PersonnalInfosAsSummary1 = new ShowAllStadiums_ControlLibrary.Person.UC_PersonnalInfosAsSummary();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lblTitle.Location = new System.Drawing.Point(226, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(496, 49);
            this.lblTitle.TabIndex = 334;
            this.lblTitle.Text = " Booking Informations Overview";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uC_StadiumInfosSummary1
            // 
            this.uC_StadiumInfosSummary1.BackColor = System.Drawing.Color.Transparent;
            this.uC_StadiumInfosSummary1.Location = new System.Drawing.Point(56, 102);
            this.uC_StadiumInfosSummary1.Name = "uC_StadiumInfosSummary1";
            this.uC_StadiumInfosSummary1.Size = new System.Drawing.Size(830, 172);
            this.uC_StadiumInfosSummary1.TabIndex = 2;
            this.uC_StadiumInfosSummary1.OnLoadingFailed += new System.Action(this.uC_StadiumInfosSummary1_OnLoadingFailed);
            this.uC_StadiumInfosSummary1.OnShowFullDataButtonClicked += new System.Action<Arena_Whistle_Buisness_layer.ClsStadium>(this.uC_StadiumInfosSummary1_OnShowFullDataButtonClicked);
            // 
            // uC_BookingInfosSummary1
            // 
            this.uC_BookingInfosSummary1.BackColor = System.Drawing.Color.Transparent;
            this.uC_BookingInfosSummary1.Location = new System.Drawing.Point(496, 280);
            this.uC_BookingInfosSummary1.Name = "uC_BookingInfosSummary1";
            this.uC_BookingInfosSummary1.Size = new System.Drawing.Size(390, 244);
            this.uC_BookingInfosSummary1.TabIndex = 1;
            this.uC_BookingInfosSummary1.OnLoadingFailed += new System.Action(this.uC_BookingInfosSummary1_OnLoadingFailed);
            this.uC_BookingInfosSummary1.OnShowFullDataButtonClicked += new System.Action<Arena_Whistle_Buisness_layer.ClsBooking>(this.uC_BookingInfosSummary1_OnShowFullDataButtonClicked);
            // 
            // uC_PersonnalInfosAsSummary1
            // 
            this.uC_PersonnalInfosAsSummary1.BackColor = System.Drawing.Color.Black;
            this.uC_PersonnalInfosAsSummary1.Location = new System.Drawing.Point(56, 280);
            this.uC_PersonnalInfosAsSummary1.Name = "uC_PersonnalInfosAsSummary1";
            this.uC_PersonnalInfosAsSummary1.Size = new System.Drawing.Size(388, 244);
            this.uC_PersonnalInfosAsSummary1.TabIndex = 0;
            this.uC_PersonnalInfosAsSummary1.OnPersonDataLoadFailed += new System.Action(this.uC_PersonnalInfosAsSummary1_OnPersonDataLoadFailed);
            this.uC_PersonnalInfosAsSummary1.OnShowAllInfosButtonClick += new System.Action<Arena_Whistle_Buisness_layerm.ClsPerson>(this.uC_PersonnalInfosAsSummary1_OnShowAllInfosButtonClick);
            // 
            // UC_BookingOverView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.uC_StadiumInfosSummary1);
            this.Controls.Add(this.uC_BookingInfosSummary1);
            this.Controls.Add(this.uC_PersonnalInfosAsSummary1);
            this.Name = "UC_BookingOverView";
            this.Size = new System.Drawing.Size(946, 587);
            this.Load += new System.EventHandler(this.UC_BookingOverView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Person.UC_PersonnalInfosAsSummary uC_PersonnalInfosAsSummary1;
        private UC_BookingInfosSummary uC_BookingInfosSummary1;
        private UC_StadiumInfosSummary uC_StadiumInfosSummary1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
    }
}
