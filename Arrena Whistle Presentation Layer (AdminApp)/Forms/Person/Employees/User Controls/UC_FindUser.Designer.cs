namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Person.Employees.User
{
    partial class UC_FindUser
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
            this.uC_ShowEmployeeCard1 = new Arrena_Whistle_Admin_Presentation_Layer.Forms_and_UserControls.Employees.UC_ShowEmployeeCard();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbFinddBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TextBox = new ShowAllStadiums_ControlLibrary.CustomTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // uC_ShowEmployeeCard1
            // 
            this.uC_ShowEmployeeCard1.BackColor = System.Drawing.Color.Transparent;
            this.uC_ShowEmployeeCard1.Location = new System.Drawing.Point(4, 64);
            this.uC_ShowEmployeeCard1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uC_ShowEmployeeCard1.Name = "uC_ShowEmployeeCard1";
            this.uC_ShowEmployeeCard1.Size = new System.Drawing.Size(787, 252);
            this.uC_ShowEmployeeCard1.TabIndex = 388;
            this.uC_ShowEmployeeCard1.OnLoadingFailed += new System.Action(this.uC_ShowEmployeeCard1_OnLoadingFailed);
            this.uC_ShowEmployeeCard1.OnShowAllPersonInfosButtonClicked += new System.Action<Arena_Whistle_Buisness_layerm.ClsPerson>(this.uC_ShowEmployeeCard1_OnShowAllPersonInfosButtonClicked);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.guna2GroupBox2.BorderRadius = 7;
            this.guna2GroupBox2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2GroupBox2.BorderThickness = 2;
            this.guna2GroupBox2.Controls.Add(this.btnSearch);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.RosyBrown;
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(518, 19);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(47, 39);
            this.guna2GroupBox2.TabIndex = 391;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSearch.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSearch.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_search_100;
            this.btnSearch.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSearch.ImageRotate = 0F;
            this.btnSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearch.Location = new System.Drawing.Point(2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSearch.Size = new System.Drawing.Size(41, 35);
            this.btnSearch.TabIndex = 368;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(9, 1);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(61, 21);
            this.guna2HtmlLabel8.TabIndex = 390;
            this.guna2HtmlLabel8.Text = "Find By : ";
            // 
            // cbFinddBy
            // 
            this.cbFinddBy.AutoRoundedCorners = true;
            this.cbFinddBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFinddBy.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.cbFinddBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFinddBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFinddBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFinddBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFinddBy.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cbFinddBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFinddBy.ItemHeight = 30;
            this.cbFinddBy.Items.AddRange(new object[] {
            "UserID ID",
            "User Name"});
            this.cbFinddBy.Location = new System.Drawing.Point(4, 22);
            this.cbFinddBy.Name = "cbFinddBy";
            this.cbFinddBy.Size = new System.Drawing.Size(286, 36);
            this.cbFinddBy.TabIndex = 389;
            this.cbFinddBy.SelectedIndexChanged += new System.EventHandler(this.cbFinddBy_SelectedIndexChanged);
            // 
            // TextBox
            // 
            this.TextBox.AutoRoundedCorners = true;
            this.TextBox.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox.DefaultText = "";
            this.TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox.ForeColor = System.Drawing.Color.Black;
            this.TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox.InputType = ShowAllStadiums_ControlLibrary.CustomTextBox.InputTypeEnum.NumberInput;
            this.TextBox.IsRequired = true;
            this.TextBox.Location = new System.Drawing.Point(296, 22);
            this.TextBox.Name = "TextBox";
            this.TextBox.PlaceholderText = "";
            this.TextBox.SelectedText = "";
            this.TextBox.Size = new System.Drawing.Size(207, 36);
            this.TextBox.TabIndex = 392;
            this.TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UC_FindUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.cbFinddBy);
            this.Controls.Add(this.uC_ShowEmployeeCard1);
            this.Name = "UC_FindUser";
            this.Size = new System.Drawing.Size(796, 314);
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Forms_and_UserControls.Employees.UC_ShowEmployeeCard uC_ShowEmployeeCard1;
        private ShowAllStadiums_ControlLibrary.CustomTextBox TextBox;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2ComboBox cbFinddBy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
