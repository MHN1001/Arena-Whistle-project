namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Person.Clients.User_Controls
{
    partial class UpdateClientCredentialsForm
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
            this.uc_UpdateUserNameAndPassword1 = new ShowAllStadiums_ControlLibrary.Global__User_Controls.Uc_UpdateUserNameAndPassword();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblTittle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // uc_UpdateUserNameAndPassword1
            // 
            this.uc_UpdateUserNameAndPassword1.BackColor = System.Drawing.Color.LightCyan;
            this.uc_UpdateUserNameAndPassword1.Location = new System.Drawing.Point(275, 107);
            this.uc_UpdateUserNameAndPassword1.Name = "uc_UpdateUserNameAndPassword1";
            this.uc_UpdateUserNameAndPassword1.Size = new System.Drawing.Size(389, 433);
            this.uc_UpdateUserNameAndPassword1.TabIndex = 371;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_login_40;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(910, 3);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.Size = new System.Drawing.Size(31, 31);
            this.guna2ImageButton1.TabIndex = 386;
            this.guna2ImageButton1.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblTittle
            // 
            this.lblTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblTittle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTittle.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lblTittle.Location = new System.Drawing.Point(334, 6);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(261, 46);
            this.lblTittle.TabIndex = 385;
            this.lblTittle.Text = "Update Login Info";
            this.lblTittle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateClientCredentialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(946, 587);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.uc_UpdateUserNameAndPassword1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateClientCredentialsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateClientCredentialsForm";
            this.Load += new System.EventHandler(this.UpdateClientCredentialsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ShowAllStadiums_ControlLibrary.Global__User_Controls.Uc_UpdateUserNameAndPassword uc_UpdateUserNameAndPassword1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTittle;
    }
}