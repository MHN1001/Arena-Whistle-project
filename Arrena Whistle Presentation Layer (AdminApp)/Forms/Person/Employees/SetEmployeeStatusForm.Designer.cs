namespace Arrena_Whistle_Admin_Presentation_Layer.Forms_and_UserControls.Employees
{
    partial class SetEmployeeStatusForm
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
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rrActive = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbInActive = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnBookNow = new Guna.UI2.WinForms.Guna2Button();
            this.btnCloseForm = new Guna.UI2.WinForms.Guna2ImageButton();
            this.uC_ShowEmployeeCard1 = new Arrena_Whistle_Admin_Presentation_Layer.Forms_and_UserControls.Employees.UC_ShowEmployeeCard();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblTittle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTittle.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lblTittle.Location = new System.Drawing.Point(335, 12);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(278, 46);
            this.lblTittle.TabIndex = 362;
            this.lblTittle.Text = "Set Emplyee Status";
            this.lblTittle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox3.BorderRadius = 10;
            this.guna2GroupBox3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2GroupBox3.BorderThickness = 2;
            this.guna2GroupBox3.Controls.Add(this.guna2HtmlLabel4);
            this.guna2GroupBox3.Controls.Add(this.guna2GroupBox1);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.DarkSlateGray;
            this.guna2GroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox3.FillColor = System.Drawing.Color.LightCyan;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Cyan;
            this.guna2GroupBox3.Location = new System.Drawing.Point(281, 383);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(388, 99);
            this.guna2GroupBox3.TabIndex = 368;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(23, 27);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(86, 35);
            this.guna2HtmlLabel4.TabIndex = 352;
            this.guna2HtmlLabel4.Text = "Status :";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.rrActive);
            this.guna2GroupBox1.Controls.Add(this.rbInActive);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.RosyBrown;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.CustomizableEdges.BottomLeft = false;
            this.guna2GroupBox1.CustomizableEdges.TopRight = false;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.LightCyan;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(121, 24);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(250, 46);
            this.guna2GroupBox1.TabIndex = 351;
            // 
            // rrActive
            // 
            this.rrActive.AutoSize = true;
            this.rrActive.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.rrActive.CheckedState.BorderThickness = 0;
            this.rrActive.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.rrActive.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rrActive.CheckedState.InnerOffset = -4;
            this.rrActive.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rrActive.ForeColor = System.Drawing.Color.Black;
            this.rrActive.Location = new System.Drawing.Point(14, 7);
            this.rrActive.Name = "rrActive";
            this.rrActive.Size = new System.Drawing.Size(85, 30);
            this.rrActive.TabIndex = 346;
            this.rrActive.Text = "Active";
            this.rrActive.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.rrActive.UncheckedState.BorderThickness = 2;
            this.rrActive.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rrActive.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbInActive
            // 
            this.rbInActive.AutoSize = true;
            this.rbInActive.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.rbInActive.CheckedState.BorderThickness = 0;
            this.rbInActive.CheckedState.FillColor = System.Drawing.Color.Red;
            this.rbInActive.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbInActive.CheckedState.InnerOffset = -4;
            this.rbInActive.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInActive.ForeColor = System.Drawing.Color.Black;
            this.rbInActive.Location = new System.Drawing.Point(141, 8);
            this.rbInActive.Name = "rbInActive";
            this.rbInActive.Size = new System.Drawing.Size(102, 30);
            this.rbInActive.TabIndex = 347;
            this.rbInActive.Text = "InActive";
            this.rbInActive.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.rbInActive.UncheckedState.BorderThickness = 2;
            this.rbInActive.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbInActive.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // btnBookNow
            // 
            this.btnBookNow.Animated = true;
            this.btnBookNow.AutoRoundedCorners = true;
            this.btnBookNow.BackColor = System.Drawing.Color.Transparent;
            this.btnBookNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBookNow.BorderColor = System.Drawing.Color.Cyan;
            this.btnBookNow.BorderThickness = 2;
            this.btnBookNow.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnBookNow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBookNow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBookNow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBookNow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBookNow.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnBookNow.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnBookNow.ForeColor = System.Drawing.Color.Aqua;
            this.btnBookNow.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBookNow.IndicateFocus = true;
            this.btnBookNow.Location = new System.Drawing.Point(390, 514);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(180, 40);
            this.btnBookNow.TabIndex = 369;
            this.btnBookNow.Text = "Save";
            this.btnBookNow.UseTransparentBackground = true;
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
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
            this.btnCloseForm.Location = new System.Drawing.Point(912, 3);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCloseForm.Size = new System.Drawing.Size(31, 31);
            this.btnCloseForm.TabIndex = 370;
            // 
            // uC_ShowEmployeeCard1
            // 
            this.uC_ShowEmployeeCard1.BackColor = System.Drawing.Color.Transparent;
            this.uC_ShowEmployeeCard1.Location = new System.Drawing.Point(88, 126);
            this.uC_ShowEmployeeCard1.Name = "uC_ShowEmployeeCard1";
            this.uC_ShowEmployeeCard1.Size = new System.Drawing.Size(787, 251);
            this.uC_ShowEmployeeCard1.TabIndex = 371;
            // 
            // SetEmployeeStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(946, 587);
            this.Controls.Add(this.uC_ShowEmployeeCard1);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.btnBookNow);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.lblTittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetEmployeeStatusForm";
            this.Text = "SetEmployeeStatusFromcs";
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTittle;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2RadioButton rrActive;
        private Guna.UI2.WinForms.Guna2RadioButton rbInActive;
        private Guna.UI2.WinForms.Guna2Button btnBookNow;
        private Guna.UI2.WinForms.Guna2ImageButton btnCloseForm;
        private UC_ShowEmployeeCard uC_ShowEmployeeCard1;
    }
}