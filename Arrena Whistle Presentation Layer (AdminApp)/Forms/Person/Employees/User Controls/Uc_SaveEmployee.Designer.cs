namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Employees
{
    partial class Uc_SaveEmployee
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
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbActive = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbInActive = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2HtmlLabel38 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpExitDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpHireDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel17 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbDepartmeents = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTittle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.ChbExited = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtSalary = new ShowAllStadiums_ControlLibrary.CustomTextBox();
            this.uC_PersonnalInfosAsSummary1 = new ShowAllStadiums_ControlLibrary.Person.UC_PersonnalInfosAsSummary();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(143, 339);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(54, 21);
            this.guna2HtmlLabel3.TabIndex = 394;
            this.guna2HtmlLabel3.Text = "Status : ";
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.guna2GroupBox4.BorderRadius = 20;
            this.guna2GroupBox4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2GroupBox4.BorderThickness = 2;
            this.guna2GroupBox4.Controls.Add(this.rbActive);
            this.guna2GroupBox4.Controls.Add(this.rbInActive);
            this.guna2GroupBox4.CustomBorderColor = System.Drawing.Color.RosyBrown;
            this.guna2GroupBox4.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox4.CustomizableEdges.BottomLeft = false;
            this.guna2GroupBox4.CustomizableEdges.TopRight = false;
            this.guna2GroupBox4.FillColor = System.Drawing.Color.LightCyan;
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox4.Location = new System.Drawing.Point(143, 366);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.Size = new System.Drawing.Size(225, 36);
            this.guna2GroupBox4.TabIndex = 393;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.rbActive.CheckedState.BorderThickness = 0;
            this.rbActive.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.rbActive.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbActive.CheckedState.InnerOffset = -4;
            this.rbActive.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.rbActive.ForeColor = System.Drawing.Color.Black;
            this.rbActive.Location = new System.Drawing.Point(14, 6);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(69, 23);
            this.rbActive.TabIndex = 397;
            this.rbActive.Text = "Active";
            this.rbActive.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.rbActive.UncheckedState.BorderThickness = 2;
            this.rbActive.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbActive.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbInActive
            // 
            this.rbInActive.AutoSize = true;
            this.rbInActive.Checked = true;
            this.rbInActive.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.rbInActive.CheckedState.BorderThickness = 0;
            this.rbInActive.CheckedState.FillColor = System.Drawing.Color.Red;
            this.rbInActive.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbInActive.CheckedState.InnerOffset = -4;
            this.rbInActive.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.rbInActive.ForeColor = System.Drawing.Color.Black;
            this.rbInActive.Location = new System.Drawing.Point(126, 6);
            this.rbInActive.Name = "rbInActive";
            this.rbInActive.Size = new System.Drawing.Size(82, 23);
            this.rbInActive.TabIndex = 398;
            this.rbInActive.TabStop = true;
            this.rbInActive.Text = "InActive";
            this.rbInActive.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.rbInActive.UncheckedState.BorderThickness = 2;
            this.rbInActive.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbInActive.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2HtmlLabel38
            // 
            this.guna2HtmlLabel38.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel38.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel38.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel38.Location = new System.Drawing.Point(18, 249);
            this.guna2HtmlLabel38.Name = "guna2HtmlLabel38";
            this.guna2HtmlLabel38.Size = new System.Drawing.Size(53, 21);
            this.guna2HtmlLabel38.TabIndex = 391;
            this.guna2HtmlLabel38.Text = "Salary  : ";
            // 
            // dtpExitDate
            // 
            this.dtpExitDate.AutoRoundedCorners = true;
            this.dtpExitDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpExitDate.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.dtpExitDate.BorderThickness = 2;
            this.dtpExitDate.Checked = true;
            this.dtpExitDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.dtpExitDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExitDate.ForeColor = System.Drawing.Color.Aqua;
            this.dtpExitDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpExitDate.Location = new System.Drawing.Point(269, 273);
            this.dtpExitDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpExitDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpExitDate.Name = "dtpExitDate";
            this.dtpExitDate.ShowUpDown = true;
            this.dtpExitDate.Size = new System.Drawing.Size(225, 36);
            this.dtpExitDate.TabIndex = 390;
            this.dtpExitDate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.dtpExitDate.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.LowerCase;
            this.dtpExitDate.Value = new System.DateTime(2025, 3, 29, 16, 27, 35, 318);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(269, 250);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(68, 21);
            this.guna2HtmlLabel2.TabIndex = 389;
            this.guna2HtmlLabel2.Text = "Exit Date: ";
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.AutoRoundedCorners = true;
            this.dtpHireDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpHireDate.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.dtpHireDate.BorderThickness = 2;
            this.dtpHireDate.Checked = true;
            this.dtpHireDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.dtpHireDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHireDate.ForeColor = System.Drawing.Color.Aqua;
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpHireDate.Location = new System.Drawing.Point(269, 192);
            this.dtpHireDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpHireDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.ShowUpDown = true;
            this.dtpHireDate.Size = new System.Drawing.Size(225, 36);
            this.dtpHireDate.TabIndex = 388;
            this.dtpHireDate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.dtpHireDate.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.LowerCase;
            this.dtpHireDate.Value = new System.DateTime(2025, 3, 29, 16, 27, 35, 318);
            // 
            // guna2HtmlLabel17
            // 
            this.guna2HtmlLabel17.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel17.Location = new System.Drawing.Point(269, 169);
            this.guna2HtmlLabel17.Name = "guna2HtmlLabel17";
            this.guna2HtmlLabel17.Size = new System.Drawing.Size(75, 21);
            this.guna2HtmlLabel17.TabIndex = 387;
            this.guna2HtmlLabel17.Text = "Hire Date : ";
            // 
            // cbDepartmeents
            // 
            this.cbDepartmeents.AutoRoundedCorners = true;
            this.cbDepartmeents.BackColor = System.Drawing.Color.Transparent;
            this.cbDepartmeents.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.cbDepartmeents.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDepartmeents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartmeents.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDepartmeents.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDepartmeents.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbDepartmeents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDepartmeents.ItemHeight = 30;
            this.cbDepartmeents.Location = new System.Drawing.Point(18, 192);
            this.cbDepartmeents.Name = "cbDepartmeents";
            this.cbDepartmeents.Size = new System.Drawing.Size(225, 36);
            this.cbDepartmeents.TabIndex = 386;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(18, 168);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(94, 21);
            this.guna2HtmlLabel1.TabIndex = 385;
            this.guna2HtmlLabel1.Text = "Department : ";
            // 
            // lblTittle
            // 
            this.lblTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblTittle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTittle.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lblTittle.Location = new System.Drawing.Point(422, 3);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(89, 46);
            this.lblTittle.TabIndex = 384;
            this.lblTittle.Text = "Mode";
            this.lblTittle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnSave.Enabled = false;
            this.btnSave.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Aqua;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSave.IndicateFocus = true;
            this.btnSave.Location = new System.Drawing.Point(362, 480);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(211, 36);
            this.btnSave.TabIndex = 396;
            this.btnSave.Text = "Save";
            this.btnSave.UseTransparentBackground = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ChbExited
            // 
            this.ChbExited.AutoSize = true;
            this.ChbExited.Checked = true;
            this.ChbExited.CheckedState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.ChbExited.CheckedState.BorderRadius = 3;
            this.ChbExited.CheckedState.BorderThickness = 1;
            this.ChbExited.CheckedState.FillColor = System.Drawing.Color.Black;
            this.ChbExited.CheckMarkColor = System.Drawing.Color.Cyan;
            this.ChbExited.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChbExited.Location = new System.Drawing.Point(272, 311);
            this.ChbExited.Name = "ChbExited";
            this.ChbExited.Size = new System.Drawing.Size(55, 17);
            this.ChbExited.TabIndex = 398;
            this.ChbExited.Text = "Exited";
            this.ChbExited.UncheckedState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.ChbExited.UncheckedState.BorderRadius = 3;
            this.ChbExited.UncheckedState.BorderThickness = 1;
            this.ChbExited.UncheckedState.FillColor = System.Drawing.Color.Aqua;
            this.ChbExited.CheckedChanged += new System.EventHandler(this.ChbExited_CheckedChanged);
            // 
            // txtSalary
            // 
            this.txtSalary.AutoRoundedCorners = true;
            this.txtSalary.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalary.DefaultText = "";
            this.txtSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalary.ForeColor = System.Drawing.Color.Black;
            this.txtSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalary.InputType = ShowAllStadiums_ControlLibrary.CustomTextBox.InputTypeEnum.NumberInput;
            this.txtSalary.IsRequired = true;
            this.txtSalary.Location = new System.Drawing.Point(18, 273);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PlaceholderText = "";
            this.txtSalary.SelectedText = "";
            this.txtSalary.Size = new System.Drawing.Size(225, 36);
            this.txtSalary.TabIndex = 397;
            this.txtSalary.Validating += new System.ComponentModel.CancelEventHandler(this.txtSalary_Validating);
            // 
            // uC_PersonnalInfosAsSummary1
            // 
            this.uC_PersonnalInfosAsSummary1.BackColor = System.Drawing.Color.Transparent;
            this.uC_PersonnalInfosAsSummary1.Location = new System.Drawing.Point(527, 168);
            this.uC_PersonnalInfosAsSummary1.Name = "uC_PersonnalInfosAsSummary1";
            this.uC_PersonnalInfosAsSummary1.ShowFullDataButton = false;
            this.uC_PersonnalInfosAsSummary1.Size = new System.Drawing.Size(388, 244);
            this.uC_PersonnalInfosAsSummary1.TabIndex = 395;
            this.uC_PersonnalInfosAsSummary1.OnShowAllInfosButtonClick += new System.Action<Arena_Whistle_Buisness_layerm.ClsPerson>(this.uC_PersonnalInfosAsSummary1_OnShowAllInfosButtonClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Uc_SaveEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.ChbExited);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.uC_PersonnalInfosAsSummary1);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2GroupBox4);
            this.Controls.Add(this.guna2HtmlLabel38);
            this.Controls.Add(this.dtpExitDate);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.guna2HtmlLabel17);
            this.Controls.Add(this.cbDepartmeents);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.lblTittle);
            this.Name = "Uc_SaveEmployee";
            this.Size = new System.Drawing.Size(946, 587);
            this.Load += new System.EventHandler(this.Uc_SaveEmployee_Load);
            this.guna2GroupBox4.ResumeLayout(false);
            this.guna2GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShowAllStadiums_ControlLibrary.Person.UC_PersonnalInfosAsSummary uC_PersonnalInfosAsSummary1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel38;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpExitDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHireDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel17;
        private Guna.UI2.WinForms.Guna2ComboBox cbDepartmeents;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTittle;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2RadioButton rbActive;
        private Guna.UI2.WinForms.Guna2RadioButton rbInActive;
        private ShowAllStadiums_ControlLibrary.CustomTextBox txtSalary;
        private Guna.UI2.WinForms.Guna2CheckBox ChbExited;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
