namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Users
{
    partial class AddUserNameAndPasswordForm
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
            this.uc_AddUserNameAndPassword1 = new ShowAllStadiums_ControlLibrary.Global__User_Controls.Uc_AddUserNameAndPassword();
            this.lblTittle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCloseForm = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // uc_AddUserNameAndPassword1
            // 
            this.uc_AddUserNameAndPassword1.BackColor = System.Drawing.Color.LightCyan;
            this.uc_AddUserNameAndPassword1.Location = new System.Drawing.Point(283, 150);
            this.uc_AddUserNameAndPassword1.Name = "uc_AddUserNameAndPassword1";
            this.uc_AddUserNameAndPassword1.saveFor = ShowAllStadiums_ControlLibrary.Global__User_Controls.Uc_AddUserNameAndPassword.SaveFor.Client;
            this.uc_AddUserNameAndPassword1.Size = new System.Drawing.Size(377, 328);
            this.uc_AddUserNameAndPassword1.TabIndex = 0;
            this.uc_AddUserNameAndPassword1.OnAddingFailed += new System.Action(this.uc_AddUserNameAndPassword1_OnAddingFailed);
            this.uc_AddUserNameAndPassword1.OnUserAddedSuccessfully += new System.Action<Arena_Whistle_Buisness_layer.ClsUser>(this.uc_AddUserNameAndPassword1_OnUserAddedSuccessfully);
            // 
            // lblTittle
            // 
            this.lblTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblTittle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTittle.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lblTittle.Location = new System.Drawing.Point(362, 12);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(212, 46);
            this.lblTittle.TabIndex = 381;
            this.lblTittle.Text = "Add Login Info";
            this.lblTittle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnCloseForm.Location = new System.Drawing.Point(910, 3);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCloseForm.Size = new System.Drawing.Size(31, 31);
            this.btnCloseForm.TabIndex = 382;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // AddUserNameAndPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(946, 587);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.uc_AddUserNameAndPassword1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUserNameAndPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveUserStep2";
            this.Load += new System.EventHandler(this.SaveUserStep2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShowAllStadiums_ControlLibrary.Global__User_Controls.Uc_AddUserNameAndPassword uc_AddUserNameAndPassword1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTittle;
        private Guna.UI2.WinForms.Guna2ImageButton btnCloseForm;
    }
}