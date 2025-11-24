namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Employees
{
    partial class SaveEmployeeStep2Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uC_BookingInfosSummary1 = new ShowAllStadiums_ControlLibrary.Stadiums.UC_BookingInfosSummary();
            this.uc_AddUserNameAndPassword1 = new ShowAllStadiums_ControlLibrary.Global__User_Controls.Uc_AddUserNameAndPassword();
            this.btnContinue = new Guna.UI2.WinForms.Guna2Button();
            this.btnCloseForm = new Guna.UI2.WinForms.Guna2ImageButton();
            this.uc_SaveEmployee1 = new Arrena_Whistle_Admin_Presentation_Layer.Forms.Employees.Uc_SaveEmployee();
            this.SuspendLayout();
            // 
            // uC_BookingInfosSummary1
            // 
            this.uC_BookingInfosSummary1.BackColor = System.Drawing.Color.Transparent;
            this.uC_BookingInfosSummary1.Location = new System.Drawing.Point(0, 0);
            this.uC_BookingInfosSummary1.Name = "uC_BookingInfosSummary1";
            this.uC_BookingInfosSummary1.ShowFullDataButton = true;
            this.uC_BookingInfosSummary1.Size = new System.Drawing.Size(388, 244);
            this.uC_BookingInfosSummary1.TabIndex = 0;
            // 
            // uc_AddUserNameAndPassword1
            // 
            this.uc_AddUserNameAndPassword1.BackColor = System.Drawing.Color.LightCyan;
            this.uc_AddUserNameAndPassword1.Location = new System.Drawing.Point(0, 0);
            this.uc_AddUserNameAndPassword1.Name = "uc_AddUserNameAndPassword1";
            this.uc_AddUserNameAndPassword1.saveFor = ShowAllStadiums_ControlLibrary.Global__User_Controls.Uc_AddUserNameAndPassword.SaveFor.Client;
            this.uc_AddUserNameAndPassword1.Size = new System.Drawing.Size(377, 328);
            this.uc_AddUserNameAndPassword1.TabIndex = 0;
            // 
            // btnContinue
            // 
            this.btnContinue.Animated = true;
            this.btnContinue.AutoRoundedCorners = true;
            this.btnContinue.BackColor = System.Drawing.Color.Transparent;
            this.btnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnContinue.BorderColor = System.Drawing.Color.Cyan;
            this.btnContinue.BorderThickness = 2;
            this.btnContinue.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnContinue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnContinue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnContinue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnContinue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnContinue.Enabled = false;
            this.btnContinue.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnContinue.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.Aqua;
            this.btnContinue.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.arrow_right;
            this.btnContinue.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnContinue.IndicateFocus = true;
            this.btnContinue.Location = new System.Drawing.Point(361, 536);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(211, 36);
            this.btnContinue.TabIndex = 384;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseTransparentBackground = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCloseForm.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCloseForm.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_login_40;
            this.btnCloseForm.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCloseForm.ImageRotate = 0F;
            this.btnCloseForm.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCloseForm.Location = new System.Drawing.Point(910, 5);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCloseForm.Size = new System.Drawing.Size(31, 31);
            this.btnCloseForm.TabIndex = 369;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // uc_SaveEmployee1
            // 
            this.uc_SaveEmployee1.BackColor = System.Drawing.Color.LightCyan;
            this.uc_SaveEmployee1.Location = new System.Drawing.Point(-1, 2);
            this.uc_SaveEmployee1.Name = "uc_SaveEmployee1";
            this.uc_SaveEmployee1.SaveMode = Arena_Whistle_Buisness_layerm.ClsPerson.SaveMode.Add;
            this.uc_SaveEmployee1.Size = new System.Drawing.Size(946, 587);
            this.uc_SaveEmployee1.TabIndex = 385;
            this.uc_SaveEmployee1.OnDataLoadFailed += new System.Action(this.uc_SaveEmployee1_OnDataLoadFailed);
            this.uc_SaveEmployee1.OnSavingFailed += new System.Action(this.uc_SaveEmployee1_OnSavingFailed);
            this.uc_SaveEmployee1.OnSaveduccessfully += new System.Action<Arena_Whistle_Buisness_layer.ClsEmployee>(this.uc_SaveEmployee1_OnSaveduccessfully);
            this.uc_SaveEmployee1.OnEmployeeObjectPropertiesSavedSuccessfully += new System.Action<Arena_Whistle_Buisness_layer.ClsEmployee>(this.uc_SaveEmployee1_OnEmployeeObjectPropertiesSavedSuccessfully);
            this.uc_SaveEmployee1.OnShowAllPersonInfosButtonClicked += new System.Action<Arena_Whistle_Buisness_layerm.ClsPerson>(this.uc_SaveEmployee1_OnShowAllPersonInfosButtonClicked);
            // 
            // SaveEmployeeStep2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(946, 587);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.uc_SaveEmployee1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaveEmployeeStep2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveEmployeeStep2Form";
            this.Load += new System.EventHandler(this.SaveEmployeeStep2Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnCloseForm;
        private ShowAllStadiums_ControlLibrary.Stadiums.UC_BookingInfosSummary uC_BookingInfosSummary1;
        private ShowAllStadiums_ControlLibrary.Global__User_Controls.Uc_AddUserNameAndPassword uc_AddUserNameAndPassword1;
        private Guna.UI2.WinForms.Guna2Button btnContinue;
        private Uc_SaveEmployee uc_SaveEmployee1;
    }
}