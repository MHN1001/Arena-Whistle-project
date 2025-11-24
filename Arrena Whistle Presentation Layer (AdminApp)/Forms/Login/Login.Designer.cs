namespace Arrena_Whistle_Admin_Presentation_Layer.Forms_and_UserControls
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.GbClientInfos = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ChbRememberMe = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtPassWord = new ShowAllStadiums_ControlLibrary.CustomTextBox();
            this.txtUserName = new ShowAllStadiums_ControlLibrary.CustomTextBox();
            this.guna2HtmlLabel38 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel36 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.pbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbbtnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbClientInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(150, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(154, 57);
            this.guna2HtmlLabel1.TabIndex = 333;
            this.guna2HtmlLabel1.Text = "Log In";
            // 
            // GbClientInfos
            // 
            this.GbClientInfos.BackColor = System.Drawing.Color.Transparent;
            this.GbClientInfos.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.GbClientInfos.Controls.Add(this.ChbRememberMe);
            this.GbClientInfos.Controls.Add(this.txtPassWord);
            this.GbClientInfos.Controls.Add(this.txtUserName);
            this.GbClientInfos.Controls.Add(this.guna2HtmlLabel38);
            this.GbClientInfos.Controls.Add(this.guna2HtmlLabel36);
            this.GbClientInfos.Controls.Add(this.btnLogin);
            this.GbClientInfos.CustomBorderColor = System.Drawing.Color.Transparent;
            this.GbClientInfos.FillColor = System.Drawing.Color.Transparent;
            this.GbClientInfos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GbClientInfos.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.GbClientInfos.Location = new System.Drawing.Point(12, 113);
            this.GbClientInfos.Name = "GbClientInfos";
            this.GbClientInfos.Size = new System.Drawing.Size(463, 359);
            this.GbClientInfos.TabIndex = 334;
            // 
            // ChbRememberMe
            // 
            this.ChbRememberMe.AutoSize = true;
            this.ChbRememberMe.Checked = true;
            this.ChbRememberMe.CheckedState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.ChbRememberMe.CheckedState.BorderRadius = 3;
            this.ChbRememberMe.CheckedState.BorderThickness = 1;
            this.ChbRememberMe.CheckedState.FillColor = System.Drawing.Color.Black;
            this.ChbRememberMe.CheckMarkColor = System.Drawing.Color.Cyan;
            this.ChbRememberMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChbRememberMe.Location = new System.Drawing.Point(68, 225);
            this.ChbRememberMe.Name = "ChbRememberMe";
            this.ChbRememberMe.Size = new System.Drawing.Size(104, 19);
            this.ChbRememberMe.TabIndex = 331;
            this.ChbRememberMe.Text = "Remember me";
            this.ChbRememberMe.UncheckedState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.ChbRememberMe.UncheckedState.BorderRadius = 3;
            this.ChbRememberMe.UncheckedState.BorderThickness = 1;
            this.ChbRememberMe.UncheckedState.FillColor = System.Drawing.Color.Aqua;
            // 
            // txtPassWord
            // 
            this.txtPassWord.AutoRoundedCorners = true;
            this.txtPassWord.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.txtPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassWord.DefaultText = "";
            this.txtPassWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassWord.ForeColor = System.Drawing.Color.Black;
            this.txtPassWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassWord.InputType = ShowAllStadiums_ControlLibrary.CustomTextBox.InputTypeEnum.PassWordInput;
            this.txtPassWord.IsRequired = true;
            this.txtPassWord.Location = new System.Drawing.Point(68, 188);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PlaceholderText = "";
            this.txtPassWord.SelectedText = "";
            this.txtPassWord.Size = new System.Drawing.Size(314, 31);
            this.txtPassWord.TabIndex = 1;
            this.txtPassWord.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassWord_Validating);
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
            this.txtUserName.Location = new System.Drawing.Point(68, 114);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(314, 31);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // guna2HtmlLabel38
            // 
            this.guna2HtmlLabel38.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel38.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel38.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel38.Location = new System.Drawing.Point(68, 87);
            this.guna2HtmlLabel38.Name = "guna2HtmlLabel38";
            this.guna2HtmlLabel38.Size = new System.Drawing.Size(85, 21);
            this.guna2HtmlLabel38.TabIndex = 264;
            this.guna2HtmlLabel38.Text = "User Name : ";
            // 
            // guna2HtmlLabel36
            // 
            this.guna2HtmlLabel36.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel36.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel36.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel36.Location = new System.Drawing.Point(68, 161);
            this.guna2HtmlLabel36.Name = "guna2HtmlLabel36";
            this.guna2HtmlLabel36.Size = new System.Drawing.Size(76, 21);
            this.guna2HtmlLabel36.TabIndex = 265;
            this.guna2HtmlLabel36.Text = "Password : ";
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.BorderColor = System.Drawing.Color.Cyan;
            this.btnLogin.BorderThickness = 2;
            this.btnLogin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.Aqua;
            this.btnLogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLogin.IndicateFocus = true;
            this.btnLogin.Location = new System.Drawing.Point(155, 272);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(134, 38);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Enter";
            this.btnLogin.UseTransparentBackground = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.FillColor = System.Drawing.Color.Transparent;
            this.pbImage.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources._12;
            this.pbImage.ImageRotate = 0F;
            this.pbImage.Location = new System.Drawing.Point(536, 113);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(345, 359);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 332;
            this.pbImage.TabStop = false;
            // 
            // pbbtnClose
            // 
            this.pbbtnClose.BackColor = System.Drawing.Color.Transparent;
            this.pbbtnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pbbtnClose.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.pbbtnClose.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_login_40;
            this.pbbtnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.pbbtnClose.ImageRotate = 0F;
            this.pbbtnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.pbbtnClose.Location = new System.Drawing.Point(894, 6);
            this.pbbtnClose.Name = "pbbtnClose";
            this.pbbtnClose.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.pbbtnClose.Size = new System.Drawing.Size(31, 24);
            this.pbbtnClose.TabIndex = 331;
            this.pbbtnClose.Click += new System.EventHandler(this.pbbtnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(930, 550);
            this.Controls.Add(this.GbClientInfos);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.pbbtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.GbClientInfos.ResumeLayout(false);
            this.GbClientInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox pbImage;
        private Guna.UI2.WinForms.Guna2ImageButton pbbtnClose;
        private Guna.UI2.WinForms.Guna2GroupBox GbClientInfos;
        private Guna.UI2.WinForms.Guna2CheckBox ChbRememberMe;
        private ShowAllStadiums_ControlLibrary.CustomTextBox txtPassWord;
        private ShowAllStadiums_ControlLibrary.CustomTextBox txtUserName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel38;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel36;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}