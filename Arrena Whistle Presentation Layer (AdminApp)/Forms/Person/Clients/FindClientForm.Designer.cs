namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Clients
{
    partial class FindClientForm
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
            this.lblTittle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCloseForm = new Guna.UI2.WinForms.Guna2ImageButton();
            this.uC_findPerson1 = new Arrena_Whistle_Admin_Presentation_Layer.Forms.Clients.UC_findPerson();
            this.BtnContinue = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblTittle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTittle.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lblTittle.Location = new System.Drawing.Point(383, 3);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(171, 46);
            this.lblTittle.TabIndex = 366;
            this.lblTittle.Text = "Find Clients";
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
            this.btnCloseForm.Location = new System.Drawing.Point(913, 1);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCloseForm.Size = new System.Drawing.Size(31, 31);
            this.btnCloseForm.TabIndex = 367;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // uC_findPerson1
            // 
            this.uC_findPerson1.BackColor = System.Drawing.Color.Transparent;
            this.uC_findPerson1.Location = new System.Drawing.Point(271, 105);
            this.uC_findPerson1.Name = "uC_findPerson1";
            this.uC_findPerson1.Size = new System.Drawing.Size(411, 420);
            this.uC_findPerson1.TabIndex = 368;
            this.uC_findPerson1.OnClientFoundSuccessfully += new System.Action<Arena_Whistle_Buisness_layer.ClsClient>(this.uC_findPerson1_OnClientFoundSuccessfully);
            this.uC_findPerson1.OnExit += new System.Action(this.uC_findPerson1_OnExit);
            this.uC_findPerson1.OnShowFullDataButtonClicked += new System.Action<Arena_Whistle_Buisness_layer.ClsClient>(this.uC_findPerson1_OnShowFullDataButtonClicked);
            this.uC_findPerson1.OnLoadingFailed += new System.Action(this.uC_findPerson1_OnLoadingFailed);
            this.uC_findPerson1.OnNotFound += new System.Action(this.uC_findPerson1_OnNotFound);
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
            this.BtnContinue.Location = new System.Drawing.Point(370, 532);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(211, 36);
            this.BtnContinue.TabIndex = 389;
            this.BtnContinue.Text = "Continue";
            this.BtnContinue.UseTransparentBackground = true;
            this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // FindClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(946, 587);
            this.Controls.Add(this.BtnContinue);
            this.Controls.Add(this.uC_findPerson1);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.lblTittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FindClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindClientForm";
            this.Load += new System.EventHandler(this.FindClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTittle;
        private Guna.UI2.WinForms.Guna2ImageButton btnCloseForm;
        private UC_findPerson uC_findPerson1;
        private Guna.UI2.WinForms.Guna2Button BtnContinue;
    }
}