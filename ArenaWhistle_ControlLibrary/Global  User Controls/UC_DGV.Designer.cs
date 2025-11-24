namespace ShowAllStadiums_ControlLibrary.Global__User_Controls
{
    partial class UC_DGV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDGV = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CMS = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.TSMI_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_showAsSummary = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.gbDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.CMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDGV
            // 
            this.gbDGV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbDGV.BorderRadius = 10;
            this.gbDGV.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbDGV.Controls.Add(this.btnClose);
            this.gbDGV.Controls.Add(this.DGV);
            this.gbDGV.CustomBorderColor = System.Drawing.Color.DarkCyan;
            this.gbDGV.CustomizableEdges.BottomLeft = false;
            this.gbDGV.CustomizableEdges.BottomRight = false;
            this.gbDGV.CustomizableEdges.TopLeft = false;
            this.gbDGV.CustomizableEdges.TopRight = false;
            this.gbDGV.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDGV.ForeColor = System.Drawing.Color.Cyan;
            this.gbDGV.Location = new System.Drawing.Point(0, 0);
            this.gbDGV.Name = "gbDGV";
            this.gbDGV.Size = new System.Drawing.Size(914, 587);
            this.gbDGV.TabIndex = 371;
            this.gbDGV.Text = "Title";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.BackgroundColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.ColumnHeadersHeight = 41;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGV.ContextMenuStrip = this.CMS;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.DGV.Location = new System.Drawing.Point(0, 40);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowTemplate.Height = 37;
            this.DGV.Size = new System.Drawing.Size(914, 547);
            this.DGV.TabIndex = 0;
            this.DGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Cyan;
            this.DGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.DGV.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.DGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV.ThemeStyle.BackColor = System.Drawing.Color.LightCyan;
            this.DGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.DGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            this.DGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGV.ThemeStyle.HeaderStyle.Height = 41;
            this.DGV.ThemeStyle.ReadOnly = true;
            this.DGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.DGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Cyan;
            this.DGV.ThemeStyle.RowsStyle.Height = 37;
            this.DGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.DGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // CMS
            // 
            this.CMS.BackColor = System.Drawing.Color.LightCyan;
            this.CMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CMS.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Show,
            this.TSMI_showAsSummary,
            this.TSMI_Add,
            this.TSMI_Update,
            this.TSMI_Delete,
            this.TSMI_Cancel});
            this.CMS.Name = "CMS";
            this.CMS.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.CMS.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CMS.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.CMS.RenderStyle.ColorTable = null;
            this.CMS.RenderStyle.RoundedEdges = true;
            this.CMS.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.CMS.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CMS.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CMS.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.CMS.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.CMS.Size = new System.Drawing.Size(166, 136);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Image = global::ShowAllStadiums_ControlLibrary.Properties.Resources.icons8_login_40;
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(877, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Size = new System.Drawing.Size(31, 31);
            this.btnClose.TabIndex = 369;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TSMI_Show
            // 
            this.TSMI_Show.Image = global::ShowAllStadiums_ControlLibrary.Properties.Resources.icons8_show_100;
            this.TSMI_Show.Name = "TSMI_Show";
            this.TSMI_Show.Size = new System.Drawing.Size(165, 22);
            this.TSMI_Show.Text = "Show ";
            this.TSMI_Show.Click += new System.EventHandler(this.TSMI_Show_Click);
            // 
            // TSMI_showAsSummary
            // 
            this.TSMI_showAsSummary.Image = global::ShowAllStadiums_ControlLibrary.Properties.Resources.icons8_show_password_100;
            this.TSMI_showAsSummary.Name = "TSMI_showAsSummary";
            this.TSMI_showAsSummary.Size = new System.Drawing.Size(165, 22);
            this.TSMI_showAsSummary.Text = "Show as summary";
            this.TSMI_showAsSummary.Click += new System.EventHandler(this.TSMI_showAsSummary_Click);
            // 
            // TSMI_Add
            // 
            this.TSMI_Add.Image = global::ShowAllStadiums_ControlLibrary.Properties.Resources.icons8_add_item_100;
            this.TSMI_Add.Name = "TSMI_Add";
            this.TSMI_Add.Size = new System.Drawing.Size(165, 22);
            this.TSMI_Add.Text = "Add";
            this.TSMI_Add.Click += new System.EventHandler(this.TSMI_Add_Click);
            // 
            // TSMI_Update
            // 
            this.TSMI_Update.Image = global::ShowAllStadiums_ControlLibrary.Properties.Resources.icons8_update_100;
            this.TSMI_Update.Name = "TSMI_Update";
            this.TSMI_Update.Size = new System.Drawing.Size(165, 22);
            this.TSMI_Update.Text = "Update";
            this.TSMI_Update.Click += new System.EventHandler(this.TSMI_Update_Click);
            // 
            // TSMI_Delete
            // 
            this.TSMI_Delete.Image = global::ShowAllStadiums_ControlLibrary.Properties.Resources.icons8_delete_100;
            this.TSMI_Delete.Name = "TSMI_Delete";
            this.TSMI_Delete.Size = new System.Drawing.Size(165, 22);
            this.TSMI_Delete.Text = "Delete";
            this.TSMI_Delete.Click += new System.EventHandler(this.TSMI_Delete_Click);
            // 
            // TSMI_Cancel
            // 
            this.TSMI_Cancel.Image = global::ShowAllStadiums_ControlLibrary.Properties.Resources.icons8_cancel_100;
            this.TSMI_Cancel.Name = "TSMI_Cancel";
            this.TSMI_Cancel.Size = new System.Drawing.Size(165, 22);
            this.TSMI_Cancel.Text = "Cancel";
            this.TSMI_Cancel.Click += new System.EventHandler(this.TSMI_Cancel_Click);
            // 
            // UC_DGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDGV);
            this.Name = "UC_DGV";
            this.Size = new System.Drawing.Size(914, 587);
            this.Load += new System.EventHandler(this.UC_DGV_Load);
            this.gbDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.CMS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbDGV;
        private Guna.UI2.WinForms.Guna2DataGridView DGV;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Show;
        private System.Windows.Forms.ToolStripMenuItem TSMI_showAsSummary;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Add;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Update;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Delete;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Cancel;
    }
}
