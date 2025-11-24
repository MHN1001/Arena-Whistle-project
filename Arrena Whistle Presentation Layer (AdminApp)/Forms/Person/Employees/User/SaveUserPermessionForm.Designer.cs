namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Users
{
    partial class SaveUserPermessionForm
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
            this.btnCloseForm = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnContinue = new Guna.UI2.WinForms.Guna2Button();
            this.uC_SaveUserPermissions1 = new Arrena_Whistle_Admin_Presentation_Layer.Forms.Person.Employees.User.UC_SaveUserPermissions();
            this.SuspendLayout();
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
            this.btnCloseForm.Location = new System.Drawing.Point(907, 5);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCloseForm.Size = new System.Drawing.Size(31, 31);
            this.btnCloseForm.TabIndex = 379;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
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
            this.btnContinue.Location = new System.Drawing.Point(374, 559);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(211, 36);
            this.btnContinue.TabIndex = 385;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseTransparentBackground = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // uC_SaveUserPermissions1
            // 
            this.uC_SaveUserPermissions1.BackColor = System.Drawing.Color.LightCyan;
            this.uC_SaveUserPermissions1.Location = new System.Drawing.Point(80, 6);
            this.uC_SaveUserPermissions1.Name = "uC_SaveUserPermissions1";
            this.uC_SaveUserPermissions1.Size = new System.Drawing.Size(792, 549);
            this.uC_SaveUserPermissions1.TabIndex = 386;
            this.uC_SaveUserPermissions1.OnLoadingFailed += new System.Action(this.uC_SaveUserPermissions1_OnLoadingFailed);
            this.uC_SaveUserPermissions1.OnSavingFailed += new System.Action(this.uC_SaveUserPermissions1_OnSavingFailed);
            this.uC_SaveUserPermissions1.OnSaveduccessfully += new System.Action<Arena_Whistle_Buisness_layer.ClsUser>(this.uC_SaveUserPermissions1_OnSaveduccessfully);
            this.uC_SaveUserPermissions1.OnUserObjectPropertiesSavedSuccessfully += new System.Action<Arena_Whistle_Buisness_layer.ClsUser>(this.uC_SaveUserPermissions1_OnUserObjectPropertiesSavedSuccessfully);
            this.uC_SaveUserPermissions1.OnShowAllPersonInfosButtonClicked += new System.Action<Arena_Whistle_Buisness_layerm.ClsPerson>(this.uC_SaveUserPermissions1_OnShowAllPersonInfosButtonClicked);
            // 
            // SaveUserPermessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(946, 599);
            this.Controls.Add(this.uC_SaveUserPermissions1);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnCloseForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaveUserPermessionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveUserStep1";
            this.Load += new System.EventHandler(this.SaveUserStep1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton btnCloseForm;
        private Person.Employees.User.UC_SaveUserPermissions uC_SaveUserPermissions1;
        private Guna.UI2.WinForms.Guna2Button btnContinue;
    }
}