namespace ShowAllStadiums_ControlLibrary.Global__User_Controls
{
    partial class Uc_UpdateUserNameAndPassword
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
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtUserName = new ShowAllStadiums_ControlLibrary.CustomTextBox();
            this.uc_UpdatePassword1 = new ShowAllStadiums_ControlLibrary.Global__User_Controls.Uc_UpdatePassword();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(63, 20);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(85, 21);
            this.guna2HtmlLabel5.TabIndex = 358;
            this.guna2HtmlLabel5.Text = "User Name : ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtUserName
            // 
            this.txtUserName.AutoRoundedCorners = true;
            this.txtUserName.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.InputType = ShowAllStadiums_ControlLibrary.CustomTextBox.InputTypeEnum.TextInput;
            this.txtUserName.IsRequired = true;
            this.txtUserName.Location = new System.Drawing.Point(61, 47);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(266, 36);
            this.txtUserName.TabIndex = 359;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // uc_UpdatePassword1
            // 
            this.uc_UpdatePassword1.BackColor = System.Drawing.Color.LightCyan;
            this.uc_UpdatePassword1.Location = new System.Drawing.Point(5, 101);
            this.uc_UpdatePassword1.Name = "uc_UpdatePassword1";
            this.uc_UpdatePassword1.saveFor = ShowAllStadiums_ControlLibrary.Global__User_Controls.Uc_UpdatePassword.SaveFor.Client;
            this.uc_UpdatePassword1.Size = new System.Drawing.Size(380, 329);
            this.uc_UpdatePassword1.TabIndex = 0;
            this.uc_UpdatePassword1.OnUpdatingFailed += new System.Action(this.uc_UpdatePassword1_OnUpdatingFailed);
            this.uc_UpdatePassword1.OnUpdatedSuccessfully += new System.Action(this.uc_UpdatePassword1_OnUpdatedSuccessfully);
            // 
            // Uc_UpdateUserNameAndPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.uc_UpdatePassword1);
            this.Name = "Uc_UpdateUserNameAndPassword";
            this.Size = new System.Drawing.Size(389, 433);
            this.Load += new System.EventHandler(this.Uc_UpdateUserNameAndPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Uc_UpdatePassword uc_UpdatePassword1;
        private CustomTextBox txtUserName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
