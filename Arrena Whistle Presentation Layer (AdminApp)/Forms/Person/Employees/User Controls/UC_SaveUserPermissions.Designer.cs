namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Person.Employees.User
{
    partial class UC_SaveUserPermissions
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
            this.gbPermessions = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPermessionTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.gbChoosingPermessions = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbYes = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbNo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblTittle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.uC_ShowEmployeeCard1 = new Arrena_Whistle_Admin_Presentation_Layer.Forms_and_UserControls.Employees.UC_ShowEmployeeCard();
            this.gbPermessions.SuspendLayout();
            this.gbChoosingPermessions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPermessions
            // 
            this.gbPermessions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbPermessions.BorderRadius = 10;
            this.gbPermessions.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbPermessions.BorderThickness = 2;
            this.gbPermessions.Controls.Add(this.guna2HtmlLabel1);
            this.gbPermessions.Controls.Add(this.lblPermessionTitle);
            this.gbPermessions.Controls.Add(this.btnNext);
            this.gbPermessions.Controls.Add(this.gbChoosingPermessions);
            this.gbPermessions.CustomBorderColor = System.Drawing.Color.DarkSlateGray;
            this.gbPermessions.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.gbPermessions.FillColor = System.Drawing.Color.LightCyan;
            this.gbPermessions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPermessions.ForeColor = System.Drawing.Color.Cyan;
            this.gbPermessions.Location = new System.Drawing.Point(4, 325);
            this.gbPermessions.Name = "gbPermessions";
            this.gbPermessions.Size = new System.Drawing.Size(787, 173);
            this.gbPermessions.TabIndex = 385;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(242, 81);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(144, 28);
            this.guna2HtmlLabel1.TabIndex = 376;
            this.guna2HtmlLabel1.Text = "Set permession : ";
            // 
            // lblPermessionTitle
            // 
            this.lblPermessionTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPermessionTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPermessionTitle.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermessionTitle.ForeColor = System.Drawing.Color.Black;
            this.lblPermessionTitle.Location = new System.Drawing.Point(292, 9);
            this.lblPermessionTitle.Name = "lblPermessionTitle";
            this.lblPermessionTitle.Size = new System.Drawing.Size(203, 40);
            this.lblPermessionTitle.TabIndex = 375;
            this.lblPermessionTitle.Text = "Permession title";
            this.lblPermessionTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Animated = true;
            this.btnNext.AutoRoundedCorners = true;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.BorderColor = System.Drawing.Color.Cyan;
            this.btnNext.BorderThickness = 2;
            this.btnNext.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnNext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.Aqua;
            this.btnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNext.IndicateFocus = true;
            this.btnNext.Location = new System.Drawing.Point(333, 132);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 30);
            this.btnNext.TabIndex = 372;
            this.btnNext.Text = "Next";
            this.btnNext.UseTransparentBackground = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // gbChoosingPermessions
            // 
            this.gbChoosingPermessions.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.gbChoosingPermessions.BorderRadius = 20;
            this.gbChoosingPermessions.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbChoosingPermessions.BorderThickness = 2;
            this.gbChoosingPermessions.Controls.Add(this.rbYes);
            this.gbChoosingPermessions.Controls.Add(this.rbNo);
            this.gbChoosingPermessions.CustomBorderColor = System.Drawing.Color.RosyBrown;
            this.gbChoosingPermessions.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.gbChoosingPermessions.CustomizableEdges.BottomLeft = false;
            this.gbChoosingPermessions.CustomizableEdges.TopRight = false;
            this.gbChoosingPermessions.FillColor = System.Drawing.Color.LightCyan;
            this.gbChoosingPermessions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbChoosingPermessions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbChoosingPermessions.Location = new System.Drawing.Point(403, 78);
            this.gbChoosingPermessions.Name = "gbChoosingPermessions";
            this.gbChoosingPermessions.Size = new System.Drawing.Size(155, 32);
            this.gbChoosingPermessions.TabIndex = 351;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.rbYes.CheckedState.BorderThickness = 0;
            this.rbYes.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.rbYes.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbYes.CheckedState.InnerOffset = -4;
            this.rbYes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.rbYes.ForeColor = System.Drawing.Color.Black;
            this.rbYes.Location = new System.Drawing.Point(12, 5);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(48, 23);
            this.rbYes.TabIndex = 399;
            this.rbYes.Text = "Yes";
            this.rbYes.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.rbYes.UncheckedState.BorderThickness = 2;
            this.rbYes.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbYes.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbYes.CheckedChanged += new System.EventHandler(this.rbYes_CheckedChanged);
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Checked = true;
            this.rbNo.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.rbNo.CheckedState.BorderThickness = 0;
            this.rbNo.CheckedState.FillColor = System.Drawing.Color.Red;
            this.rbNo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbNo.CheckedState.InnerOffset = -4;
            this.rbNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.rbNo.ForeColor = System.Drawing.Color.Black;
            this.rbNo.Location = new System.Drawing.Point(100, 4);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(47, 23);
            this.rbNo.TabIndex = 400;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.rbNo.UncheckedState.BorderThickness = 2;
            this.rbNo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbNo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.BorderColor = System.Drawing.Color.Cyan;
            this.btnSave.BorderThickness = 2;
            this.btnSave.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Aqua;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSave.IndicateFocus = true;
            this.btnSave.Location = new System.Drawing.Point(296, 508);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(211, 36);
            this.btnSave.TabIndex = 383;
            this.btnSave.Text = "Save";
            this.btnSave.UseTransparentBackground = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTittle
            // 
            this.lblTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblTittle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTittle.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lblTittle.Location = new System.Drawing.Point(242, 3);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(313, 46);
            this.lblTittle.TabIndex = 384;
            this.lblTittle.Text = "Manage Permessions";
            this.lblTittle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uC_ShowEmployeeCard1
            // 
            this.uC_ShowEmployeeCard1.BackColor = System.Drawing.Color.Transparent;
            this.uC_ShowEmployeeCard1.Location = new System.Drawing.Point(4, 68);
            this.uC_ShowEmployeeCard1.Name = "uC_ShowEmployeeCard1";
            this.uC_ShowEmployeeCard1.Size = new System.Drawing.Size(787, 251);
            this.uC_ShowEmployeeCard1.TabIndex = 386;
            this.uC_ShowEmployeeCard1.OnLoadingFailed += new System.Action(this.uC_ShowEmployeeCard1_OnLoadingFailed);
            this.uC_ShowEmployeeCard1.OnShowAllPersonInfosButtonClicked += new System.Action<Arena_Whistle_Buisness_layerm.ClsPerson>(this.uC_ShowEmployeeCard1_OnShowAllPersonInfosButtonClicked);
            // 
            // UC_SaveUserPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.uC_ShowEmployeeCard1);
            this.Controls.Add(this.gbPermessions);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTittle);
            this.Name = "UC_SaveUserPermissions";
            this.Size = new System.Drawing.Size(792, 549);
            this.Load += new System.EventHandler(this.UC_SaveUserPermissions_Load);
            this.gbPermessions.ResumeLayout(false);
            this.gbPermessions.PerformLayout();
            this.gbChoosingPermessions.ResumeLayout(false);
            this.gbChoosingPermessions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Forms_and_UserControls.Employees.UC_ShowEmployeeCard uC_ShowEmployeeCard1;
        private Guna.UI2.WinForms.Guna2GroupBox gbPermessions;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPermessionTitle;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2GroupBox gbChoosingPermessions;
        private Guna.UI2.WinForms.Guna2RadioButton rbYes;
        private Guna.UI2.WinForms.Guna2RadioButton rbNo;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTittle;
    }
}
