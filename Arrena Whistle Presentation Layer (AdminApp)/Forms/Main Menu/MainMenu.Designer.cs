namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Main_Menu
{
    partial class MainMenuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllStadiumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findStadiumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllStadiumsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showAvailabeStadiumsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStadiumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStadiumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllCurrenntMatchesTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllMatchedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showBookedStadiumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingStadiumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showReservedStadiumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reserveStadiumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shozToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inActiveClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllEmployeesTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCloseForm = new Guna.UI2.WinForms.Guna2ImageButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightCyan;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.uSERSToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(895, 108);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllStadiumsToolStripMenuItem,
            this.matchesToolStripMenuItem,
            this.bookingToolStripMenuItem1,
            this.reservationsToolStripMenuItem});
            this.ToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_stadium_100__1_;
            this.ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(203, 104);
            this.ToolStripMenuItem.Text = "Stadiums";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.dddddddToolStripMenuItem_Click);
            // 
            // showAllStadiumsToolStripMenuItem
            // 
            this.showAllStadiumsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findStadiumToolStripMenuItem,
            this.showAllStadiumsToolStripMenuItem1,
            this.showAvailabeStadiumsToolStripMenuItem1,
            this.addNewStadiumToolStripMenuItem,
            this.updateStadiumToolStripMenuItem});
            this.showAllStadiumsToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_show_property_100;
            this.showAllStadiumsToolStripMenuItem.Name = "showAllStadiumsToolStripMenuItem";
            this.showAllStadiumsToolStripMenuItem.Size = new System.Drawing.Size(195, 30);
            this.showAllStadiumsToolStripMenuItem.Text = "Stadiums";
            // 
            // findStadiumToolStripMenuItem
            // 
            this.findStadiumToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_find_100;
            this.findStadiumToolStripMenuItem.Name = "findStadiumToolStripMenuItem";
            this.findStadiumToolStripMenuItem.Size = new System.Drawing.Size(295, 30);
            this.findStadiumToolStripMenuItem.Text = "Show All Stadiums Table";
            this.findStadiumToolStripMenuItem.Click += new System.EventHandler(this.AllStadiumAsTableToolStripMenuItem_Click);
            // 
            // showAllStadiumsToolStripMenuItem1
            // 
            this.showAllStadiumsToolStripMenuItem1.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_show_password_100;
            this.showAllStadiumsToolStripMenuItem1.Name = "showAllStadiumsToolStripMenuItem1";
            this.showAllStadiumsToolStripMenuItem1.Size = new System.Drawing.Size(295, 30);
            this.showAllStadiumsToolStripMenuItem1.Text = "Show All Stadiums";
            this.showAllStadiumsToolStripMenuItem1.Click += new System.EventHandler(this.showAllStadiumsToolStripMenuItem1_Click);
            // 
            // showAvailabeStadiumsToolStripMenuItem1
            // 
            this.showAvailabeStadiumsToolStripMenuItem1.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_show_password_100;
            this.showAvailabeStadiumsToolStripMenuItem1.Name = "showAvailabeStadiumsToolStripMenuItem1";
            this.showAvailabeStadiumsToolStripMenuItem1.Size = new System.Drawing.Size(295, 30);
            this.showAvailabeStadiumsToolStripMenuItem1.Text = "Show Availabe Stadiums";
            this.showAvailabeStadiumsToolStripMenuItem1.Click += new System.EventHandler(this.showAvailabeStadiumsToolStripMenuItem1_Click);
            // 
            // addNewStadiumToolStripMenuItem
            // 
            this.addNewStadiumToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_add_item_100;
            this.addNewStadiumToolStripMenuItem.Name = "addNewStadiumToolStripMenuItem";
            this.addNewStadiumToolStripMenuItem.Size = new System.Drawing.Size(295, 30);
            this.addNewStadiumToolStripMenuItem.Text = "Add New Stadium";
            this.addNewStadiumToolStripMenuItem.Click += new System.EventHandler(this.addNewStadiumToolStripMenuItem_Click);
            // 
            // updateStadiumToolStripMenuItem
            // 
            this.updateStadiumToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_update_100;
            this.updateStadiumToolStripMenuItem.Name = "updateStadiumToolStripMenuItem";
            this.updateStadiumToolStripMenuItem.Size = new System.Drawing.Size(295, 30);
            this.updateStadiumToolStripMenuItem.Text = "Update Stadium";
            this.updateStadiumToolStripMenuItem.Click += new System.EventHandler(this.updateStadiumToolStripMenuItem_Click);
            // 
            // matchesToolStripMenuItem
            // 
            this.matchesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllCurrenntMatchesTableToolStripMenuItem,
            this.showAllMatchedToolStripMenuItem});
            this.matchesToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_show_property_100;
            this.matchesToolStripMenuItem.Name = "matchesToolStripMenuItem";
            this.matchesToolStripMenuItem.Size = new System.Drawing.Size(195, 30);
            this.matchesToolStripMenuItem.Text = "Matches";
            // 
            // showAllCurrenntMatchesTableToolStripMenuItem
            // 
            this.showAllCurrenntMatchesTableToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_show_property_100;
            this.showAllCurrenntMatchesTableToolStripMenuItem.Name = "showAllCurrenntMatchesTableToolStripMenuItem";
            this.showAllCurrenntMatchesTableToolStripMenuItem.Size = new System.Drawing.Size(359, 30);
            this.showAllCurrenntMatchesTableToolStripMenuItem.Text = "Show All Current Matches Table";
            this.showAllCurrenntMatchesTableToolStripMenuItem.Click += new System.EventHandler(this.showAllCurrenntMatchesTableToolStripMenuItem_Click);
            // 
            // showAllMatchedToolStripMenuItem
            // 
            this.showAllMatchedToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_show_property_100;
            this.showAllMatchedToolStripMenuItem.Name = "showAllMatchedToolStripMenuItem";
            this.showAllMatchedToolStripMenuItem.Size = new System.Drawing.Size(359, 30);
            this.showAllMatchedToolStripMenuItem.Text = "Show all matches history";
            this.showAllMatchedToolStripMenuItem.Click += new System.EventHandler(this.showAllMatchedToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem1
            // 
            this.bookingToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showBookedStadiumsToolStripMenuItem,
            this.bookingStadiumToolStripMenuItem});
            this.bookingToolStripMenuItem1.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_show_property_1001;
            this.bookingToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bookingToolStripMenuItem1.Name = "bookingToolStripMenuItem1";
            this.bookingToolStripMenuItem1.Size = new System.Drawing.Size(195, 30);
            this.bookingToolStripMenuItem1.Text = "Booking";
            // 
            // showBookedStadiumsToolStripMenuItem
            // 
            this.showBookedStadiumsToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_show_property_100;
            this.showBookedStadiumsToolStripMenuItem.Name = "showBookedStadiumsToolStripMenuItem";
            this.showBookedStadiumsToolStripMenuItem.Size = new System.Drawing.Size(284, 30);
            this.showBookedStadiumsToolStripMenuItem.Text = "Show Booked stadiums";
            this.showBookedStadiumsToolStripMenuItem.Click += new System.EventHandler(this.showBookedStadiumsToolStripMenuItem_Click);
            // 
            // bookingStadiumToolStripMenuItem
            // 
            this.bookingStadiumToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_process_100;
            this.bookingStadiumToolStripMenuItem.Name = "bookingStadiumToolStripMenuItem";
            this.bookingStadiumToolStripMenuItem.Size = new System.Drawing.Size(284, 30);
            this.bookingStadiumToolStripMenuItem.Text = "Booking Stadium";
            this.bookingStadiumToolStripMenuItem.Click += new System.EventHandler(this.bookingStadiumToolStripMenuItem_Click_1);
            // 
            // reservationsToolStripMenuItem
            // 
            this.reservationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showReservedStadiumsToolStripMenuItem,
            this.reserveStadiumToolStripMenuItem});
            this.reservationsToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_show_property_1001;
            this.reservationsToolStripMenuItem.Name = "reservationsToolStripMenuItem";
            this.reservationsToolStripMenuItem.Size = new System.Drawing.Size(195, 30);
            this.reservationsToolStripMenuItem.Text = "Reservations";
            // 
            // showReservedStadiumsToolStripMenuItem
            // 
            this.showReservedStadiumsToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_show_property_100;
            this.showReservedStadiumsToolStripMenuItem.Name = "showReservedStadiumsToolStripMenuItem";
            this.showReservedStadiumsToolStripMenuItem.Size = new System.Drawing.Size(302, 30);
            this.showReservedStadiumsToolStripMenuItem.Text = "Show Reserved Stadiums";
            this.showReservedStadiumsToolStripMenuItem.Click += new System.EventHandler(this.showReservedStadiumsToolStripMenuItem_Click);
            // 
            // reserveStadiumToolStripMenuItem
            // 
            this.reserveStadiumToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_process_100;
            this.reserveStadiumToolStripMenuItem.Name = "reserveStadiumToolStripMenuItem";
            this.reserveStadiumToolStripMenuItem.Size = new System.Drawing.Size(302, 30);
            this.reserveStadiumToolStripMenuItem.Text = "Reserve Stadium";
            this.reserveStadiumToolStripMenuItem.Click += new System.EventHandler(this.reserveStadiumToolStripMenuItem_Click_1);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allClientsToolStripMenuItem,
            this.shozToolStripMenuItem,
            this.inActiveClientsToolStripMenuItem});
            this.clientsToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.clientsToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_client_100_2;
            this.clientsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(182, 104);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // allClientsToolStripMenuItem
            // 
            this.allClientsToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_show_property_100;
            this.allClientsToolStripMenuItem.Name = "allClientsToolStripMenuItem";
            this.allClientsToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.allClientsToolStripMenuItem.Text = "All Clients";
            this.allClientsToolStripMenuItem.Click += new System.EventHandler(this.allClientsToolStripMenuItem_Click);
            // 
            // shozToolStripMenuItem
            // 
            this.shozToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_show_property_100;
            this.shozToolStripMenuItem.Name = "shozToolStripMenuItem";
            this.shozToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.shozToolStripMenuItem.Text = "Active Clients";
            this.shozToolStripMenuItem.Click += new System.EventHandler(this.ActiveClientsToolStripMenuItem_Click);
            // 
            // inActiveClientsToolStripMenuItem
            // 
            this.inActiveClientsToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_show_property_100;
            this.inActiveClientsToolStripMenuItem.Name = "inActiveClientsToolStripMenuItem";
            this.inActiveClientsToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.inActiveClientsToolStripMenuItem.Text = "InActive Clients";
            this.inActiveClientsToolStripMenuItem.Click += new System.EventHandler(this.inActiveClientsToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllEmployeesTableToolStripMenuItem});
            this.employeesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.employeesToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_employee_94;
            this.employeesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(212, 104);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // showAllEmployeesTableToolStripMenuItem
            // 
            this.showAllEmployeesTableToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_show_property_100;
            this.showAllEmployeesTableToolStripMenuItem.Name = "showAllEmployeesTableToolStripMenuItem";
            this.showAllEmployeesTableToolStripMenuItem.Size = new System.Drawing.Size(259, 30);
            this.showAllEmployeesTableToolStripMenuItem.Text = "Show All Employees";
            this.showAllEmployeesTableToolStripMenuItem.Click += new System.EventHandler(this.showAllEmployeesTableToolStripMenuItem_Click);
            // 
            // uSERSToolStripMenuItem
            // 
            this.uSERSToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.uSERSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllUsersToolStripMenuItem,
            this.addNewUserToolStripMenuItem,
            this.updateUserPasswordToolStripMenuItem});
            this.uSERSToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uSERSToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_admin_100;
            this.uSERSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uSERSToolStripMenuItem.Name = "uSERSToolStripMenuItem";
            this.uSERSToolStripMenuItem.Size = new System.Drawing.Size(180, 104);
            this.uSERSToolStripMenuItem.Text = "USERS";
            // 
            // showAllUsersToolStripMenuItem
            // 
            this.showAllUsersToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_show_property_100;
            this.showAllUsersToolStripMenuItem.Name = "showAllUsersToolStripMenuItem";
            this.showAllUsersToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.showAllUsersToolStripMenuItem.Text = "Show All Users";
            this.showAllUsersToolStripMenuItem.Click += new System.EventHandler(this.showAllUsersToolStripMenuItem_Click);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_add_item_100;
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // updateUserPasswordToolStripMenuItem
            // 
            this.updateUserPasswordToolStripMenuItem.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_update_100;
            this.updateUserPasswordToolStripMenuItem.Name = "updateUserPasswordToolStripMenuItem";
            this.updateUserPasswordToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.updateUserPasswordToolStripMenuItem.Text = "Update User";
            this.updateUserPasswordToolStripMenuItem.Click += new System.EventHandler(this.updateUserPasswordToolStripMenuItem_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.LightCyan;
            this.btnCloseForm.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCloseForm.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCloseForm.Image = global::Arrena_Whistle_Admin_Presentation_Layer.Properties.Resources.icons8_login_40;
            this.btnCloseForm.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCloseForm.ImageRotate = 0F;
            this.btnCloseForm.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCloseForm.Location = new System.Drawing.Point(862, 2);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCloseForm.Size = new System.Drawing.Size(31, 31);
            this.btnCloseForm.TabIndex = 369;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(895, 514);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "HHHHHHH";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResizeEnd += new System.EventHandler(this.MainMenuForm_ResizeEnd);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllStadiumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shozToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllStadiumsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showAvailabeStadiumsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem findStadiumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStadiumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllCurrenntMatchesTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllEmployeesTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStadiumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showBookedStadiumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingStadiumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showReservedStadiumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reserveStadiumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllMatchedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllUsersToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ImageButton btnCloseForm;
        private System.Windows.Forms.ToolStripMenuItem inActiveClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allClientsToolStripMenuItem;
    }
}