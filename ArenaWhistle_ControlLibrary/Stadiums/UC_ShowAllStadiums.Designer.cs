namespace ShowAllStadiums_ControlLibrary.Stadiums
{
    partial class UC_ShowStadiums
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
            this.cbSportTypes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnShowAsATable = new Guna.UI2.WinForms.Guna2Button();
            this.lblTittle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnBookNow = new Guna.UI2.WinForms.Guna2Button();
            this.uC_ShowStadiumCard1 = new ShowAllStadiums_ControlLibrary.Stadiums.UC_ShowStadiumCard();
            this.gbTitle = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnReserveNow = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.gbTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSportTypes
            // 
            this.cbSportTypes.BackColor = System.Drawing.Color.Transparent;
            this.cbSportTypes.BorderColor = System.Drawing.Color.Cyan;
            this.cbSportTypes.BorderRadius = 17;
            this.cbSportTypes.BorderThickness = 2;
            this.cbSportTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSportTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSportTypes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSportTypes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSportTypes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.cbSportTypes.ForeColor = System.Drawing.Color.Black;
            this.cbSportTypes.ItemHeight = 30;
            this.cbSportTypes.Location = new System.Drawing.Point(14, 43);
            this.cbSportTypes.Name = "cbSportTypes";
            this.cbSportTypes.Size = new System.Drawing.Size(245, 36);
            this.cbSportTypes.TabIndex = 358;
            this.cbSportTypes.SelectedIndexChanged += new System.EventHandler(this.cbSportTypes_SelectedIndexChanged);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(14, 12);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(96, 25);
            this.guna2HtmlLabel7.TabIndex = 357;
            this.guna2HtmlLabel7.Text = "Sport Type : ";
            // 
            // btnShowAsATable
            // 
            this.btnShowAsATable.Animated = true;
            this.btnShowAsATable.AutoRoundedCorners = true;
            this.btnShowAsATable.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAsATable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowAsATable.BorderColor = System.Drawing.Color.Cyan;
            this.btnShowAsATable.BorderThickness = 2;
            this.btnShowAsATable.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnShowAsATable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowAsATable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowAsATable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowAsATable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowAsATable.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnShowAsATable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnShowAsATable.ForeColor = System.Drawing.Color.Aqua;
            this.btnShowAsATable.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnShowAsATable.IndicateFocus = true;
            this.btnShowAsATable.Location = new System.Drawing.Point(140, 154);
            this.btnShowAsATable.Name = "btnShowAsATable";
            this.btnShowAsATable.Size = new System.Drawing.Size(180, 40);
            this.btnShowAsATable.TabIndex = 359;
            this.btnShowAsATable.Text = "Show as a Table";
            this.btnShowAsATable.UseTransparentBackground = true;
            this.btnShowAsATable.Click += new System.EventHandler(this.btnShowAsATable_Click);
            // 
            // lblTittle
            // 
            this.lblTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblTittle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTittle.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.lblTittle.Location = new System.Drawing.Point(138, 3);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(185, 46);
            this.lblTittle.TabIndex = 360;
            this.lblTittle.Text = "All Stadiums";
            this.lblTittle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.guna2GroupBox2.BorderRadius = 20;
            this.guna2GroupBox2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2GroupBox2.BorderThickness = 2;
            this.guna2GroupBox2.Controls.Add(this.guna2GroupBox3);
            this.guna2GroupBox2.Controls.Add(this.guna2GroupBox1);
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel7);
            this.guna2GroupBox2.Controls.Add(this.cbSportTypes);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.RosyBrown;
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox2.FillColor = System.Drawing.Color.LightCyan;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(94, 210);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(271, 287);
            this.guna2GroupBox2.TabIndex = 361;
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.guna2GroupBox3.BorderRadius = 20;
            this.guna2GroupBox3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2GroupBox3.BorderThickness = 2;
            this.guna2GroupBox3.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox3.Controls.Add(this.btnBack);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.RosyBrown;
            this.guna2GroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox3.FillColor = System.Drawing.Color.LightCyan;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox3.Location = new System.Drawing.Point(19, 141);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(85, 136);
            this.guna2GroupBox3.TabIndex = 363;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(23, 17);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(41, 25);
            this.guna2HtmlLabel2.TabIndex = 362;
            this.guna2HtmlLabel2.Text = "Back";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBack.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnBack.Image = global::ShowAllStadiums_ControlLibrary.Properties.Resources.icons8_back_to_100;
            this.btnBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnBack.ImageRotate = 0F;
            this.btnBack.ImageSize = new System.Drawing.Size(50, 50);
            this.btnBack.Location = new System.Drawing.Point(11, 56);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnBack.Size = new System.Drawing.Size(63, 70);
            this.btnBack.TabIndex = 361;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Controls.Add(this.btnNext);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.RosyBrown;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.LightCyan;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(169, 141);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(85, 136);
            this.guna2GroupBox1.TabIndex = 362;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(23, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(40, 25);
            this.guna2HtmlLabel1.TabIndex = 361;
            this.guna2HtmlLabel1.Text = "Next";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNext.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnNext.Image = global::ShowAllStadiums_ControlLibrary.Properties.Resources.icons8_next_100;
            this.btnNext.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnNext.ImageRotate = 0F;
            this.btnNext.ImageSize = new System.Drawing.Size(50, 50);
            this.btnNext.Location = new System.Drawing.Point(12, 55);
            this.btnNext.Name = "btnNext";
            this.btnNext.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnNext.Size = new System.Drawing.Size(61, 70);
            this.btnNext.TabIndex = 360;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            this.btnBookNow.Location = new System.Drawing.Point(94, 548);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(123, 33);
            this.btnBookNow.TabIndex = 362;
            this.btnBookNow.Text = "Book now";
            this.btnBookNow.UseTransparentBackground = true;
            this.btnBookNow.Click += new System.EventHandler(this.btnBookStadium_Click);
            // 
            // uC_ShowStadiumCard1
            // 
            this.uC_ShowStadiumCard1.BackColor = System.Drawing.Color.Transparent;
            this.uC_ShowStadiumCard1.Location = new System.Drawing.Point(461, 5);
            this.uC_ShowStadiumCard1.Name = "uC_ShowStadiumCard1";
            this.uC_ShowStadiumCard1.Size = new System.Drawing.Size(443, 576);
            this.uC_ShowStadiumCard1.TabIndex = 0;
            this.uC_ShowStadiumCard1.Load += new System.EventHandler(this.uC_ShowStadiumCard1_Load);
            // 
            // gbTitle
            // 
            this.gbTitle.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.gbTitle.BorderRadius = 20;
            this.gbTitle.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbTitle.BorderThickness = 0;
            this.gbTitle.Controls.Add(this.lblTittle);
            this.gbTitle.CustomBorderColor = System.Drawing.Color.RosyBrown;
            this.gbTitle.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.gbTitle.FillColor = System.Drawing.Color.LightCyan;
            this.gbTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbTitle.Location = new System.Drawing.Point(3, 5);
            this.gbTitle.Name = "gbTitle";
            this.gbTitle.Size = new System.Drawing.Size(452, 54);
            this.gbTitle.TabIndex = 363;
            // 
            // btnReserveNow
            // 
            this.btnReserveNow.Animated = true;
            this.btnReserveNow.AutoRoundedCorners = true;
            this.btnReserveNow.BackColor = System.Drawing.Color.Transparent;
            this.btnReserveNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReserveNow.BorderColor = System.Drawing.Color.Cyan;
            this.btnReserveNow.BorderThickness = 2;
            this.btnReserveNow.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnReserveNow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReserveNow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReserveNow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReserveNow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReserveNow.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnReserveNow.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnReserveNow.ForeColor = System.Drawing.Color.Aqua;
            this.btnReserveNow.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnReserveNow.IndicateFocus = true;
            this.btnReserveNow.Location = new System.Drawing.Point(242, 548);
            this.btnReserveNow.Name = "btnReserveNow";
            this.btnReserveNow.Size = new System.Drawing.Size(123, 33);
            this.btnReserveNow.TabIndex = 364;
            this.btnReserveNow.Text = "Reserve now";
            this.btnReserveNow.UseTransparentBackground = true;
            this.btnReserveNow.Click += new System.EventHandler(this.btnReserveNow_Click);
            // 
            // UC_ShowStadiums
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.btnReserveNow);
            this.Controls.Add(this.gbTitle);
            this.Controls.Add(this.btnBookNow);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.btnShowAsATable);
            this.Controls.Add(this.uC_ShowStadiumCard1);
            this.Name = "UC_ShowStadiums";
            this.Size = new System.Drawing.Size(946, 587);
            this.Load += new System.EventHandler(this.UC_ShowAllStadiums_Load);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.gbTitle.ResumeLayout(false);
            this.gbTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UC_ShowStadiumCard uC_ShowStadiumCard1;
        private Guna.UI2.WinForms.Guna2ComboBox cbSportTypes;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2Button btnShowAsATable;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTittle;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnNext;
        private Guna.UI2.WinForms.Guna2Button btnBookNow;
        private Guna.UI2.WinForms.Guna2GroupBox gbTitle;
        private Guna.UI2.WinForms.Guna2Button btnReserveNow;
    }
}
