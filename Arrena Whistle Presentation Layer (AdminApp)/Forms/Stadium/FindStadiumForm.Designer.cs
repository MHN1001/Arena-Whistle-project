namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Stadium
{
    partial class FindStadiumForm
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
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.uC_FindStadium1 = new Arrena_Whistle_Admin_Presentation_Layer.Forms.Stadium.User_Controls.UC_FindStadium();
            this.BtnContinue = new Guna.UI2.WinForms.Guna2Button();
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
            this.btnCloseForm.Location = new System.Drawing.Point(878, 5);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCloseForm.Size = new System.Drawing.Size(31, 31);
            this.btnCloseForm.TabIndex = 368;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lblTitle.Location = new System.Drawing.Point(332, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(281, 46);
            this.lblTitle.TabIndex = 370;
            this.lblTitle.Text = "Search For Stadium";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uC_FindStadium1
            // 
            this.uC_FindStadium1.BackColor = System.Drawing.Color.Transparent;
            this.uC_FindStadium1.Location = new System.Drawing.Point(40, 182);
            this.uC_FindStadium1.Name = "uC_FindStadium1";
            this.uC_FindStadium1.Size = new System.Drawing.Size(832, 233);
            this.uC_FindStadium1.TabIndex = 371;
            this.uC_FindStadium1.OnStadiumFoundSuccessfully += new System.Action<Arena_Whistle_Buisness_layer.ClsStadium>(this.uC_FindStadium1_OnStadiumFoundSuccessfully);
            this.uC_FindStadium1.OnExit += new System.Action(this.uC_FindStadium1_OnExit);
            this.uC_FindStadium1.OnLoadingFailed += new System.Action(this.uC_FindStadium1_OnLoadingFailed);
            // 
            // BtnContinue
            // 
            this.BtnContinue.Animated = true;
            this.BtnContinue.AutoRoundedCorners = true;
            this.BtnContinue.BackColor = System.Drawing.Color.Transparent;
            this.BtnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnContinue.BorderColor = System.Drawing.Color.Cyan;
            this.BtnContinue.BorderThickness = 2;
            this.BtnContinue.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.BtnContinue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnContinue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnContinue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnContinue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnContinue.FillColor = System.Drawing.Color.DarkSlateGray;
            this.BtnContinue.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnContinue.ForeColor = System.Drawing.Color.Aqua;
            this.BtnContinue.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_forward_button_100;
            this.BtnContinue.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnContinue.IndicateFocus = true;
            this.BtnContinue.Location = new System.Drawing.Point(357, 433);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(211, 36);
            this.BtnContinue.TabIndex = 372;
            this.BtnContinue.Text = "Continue";
            this.BtnContinue.UseTransparentBackground = true;
            this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // FindStadiumForm
            // 
            this.AcceptButton = this.BtnContinue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(914, 587);
            this.Controls.Add(this.BtnContinue);
            this.Controls.Add(this.uC_FindStadium1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCloseForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FindStadiumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindStadiumForm";
            this.Load += new System.EventHandler(this.FindStadiumForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnCloseForm;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private User_Controls.UC_FindStadium uC_FindStadium1;
        private Guna.UI2.WinForms.Guna2Button BtnContinue;
    }
}