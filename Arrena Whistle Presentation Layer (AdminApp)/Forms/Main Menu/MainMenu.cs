using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arena_Whistle_Buisness_layer;
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Clients;
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Employees;
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Employees.User;
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Employees.User_Controls;
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Person.Employees.User;
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Stadium;
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Users;
using Arrena_Whistle_Admin_Presentation_Layer.Forms_and_UserControls.Matches;
using Arrena_Whistle_Admin_Presentation_Layer.Forms_and_UserControls.Stadium;
// Import your Global Namespace
using Arrena_Whistle_Admin_Presentation_Layer.Global;
using TheArtOfDevHtmlRenderer.Adapters.Entities;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Main_Menu
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.LightCyan;
            SetMenuItemColor(menuStrip1.Items, Color.LightCyan);

            PositionCloseButton();

            ApplyBackground();
        }
        private void ApplyBackground()
        {
            foreach(Control c in this.Controls)
            {
                if(c is MdiClient client)
                {
                    // Get the original image
                    Image original = Properties.Resources.Final_logo;

                    // Create a NEW bitmap that is the exact size of the MdiClient area
                    // This "bakes" the stretch into the image itself
                    client.BackgroundImage = new Bitmap(original, client.Width, client.Height);

                    return;
                }
            }
        }
        private void SetMenuItemColor(ToolStripItemCollection items, Color color)
        {
            foreach(ToolStripItem item in items)
            {
                if(item is ToolStripMenuItem menuItem)
                {
                    menuItem.BackColor = color;

                    // Apply to children (sub menus)
                    if(menuItem.HasDropDownItems)
                    {
                        SetMenuItemColor(menuItem.DropDownItems, color);
                    }
                }
            }
        }

        private void PositionCloseButton()
        {
            int padding = 2;
            btnCloseForm.Top = padding;
            btnCloseForm.Left = this.ClientSize.Width - btnCloseForm.Width - padding;
        }

        // ===========================================================
        //  PERMISSION CHECK LOGIC
        // ===========================================================
        private bool CheckAccess(ClsGlobal.Permission permission)
        {
            // 1. Safety Check: Is a user logged in?
            if(ClsGlobal.CurrentUser == null)
            {
                MessageBox.Show("No user is currently logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // 2. Full Access Check (Admin)
            // -1 is the value for FullAccess in your Enum
            if(ClsGlobal.CurrentUser.Permission == (int)ClsGlobal.Permission.FullAccess)
            {
                return true;
            }

            // 3. Bitwise Permission Check
            // We cast to (int) to perform the bitwise AND operation
            if(( ClsGlobal.CurrentUser.Permission & (int)permission ) == (int)permission)
            {
                return true;
            }

            // 4. Access Denied
            MessageBox.Show($"Access Denied: You do not have permission to access this feature.",
                            "Restricted Access",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            return false;
        }







        // ===========================================================
        //  STADIUM EVENTS
        // ===========================================================
        private void showAllStadiumsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(!CheckAccess(ClsGlobal.Permission.ShowAllStadiums)) return;

            ShowAllStadiumsForm showAllStadiumsForm = new ShowAllStadiumsForm();
            showAllStadiumsForm.MdiParent = this;
            showAllStadiumsForm.Show();
        }

        private void showAvailabeStadiumsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(!CheckAccess(ClsGlobal.Permission.ShowAvailableStadiums)) return;

            AvailableStadiumsForm availableStadiumsForm = new AvailableStadiumsForm();
            availableStadiumsForm.MdiParent = this;
            availableStadiumsForm.Show();
        }

        private void AllStadiumAsTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckAccess(ClsGlobal.Permission.ShowAllStadiumsTable)) return;

            ShowStadiumsAsTableForm ShowStadiumsAsTableForm = new ShowStadiumsAsTableForm(ClsStadium.GetAvailableStadiums().Stadiums, "All Stadiums");
            ShowStadiumsAsTableForm.MdiParent = this;
            ShowStadiumsAsTableForm.Show();
        }

        private void addNewStadiumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckAccess(ClsGlobal.Permission.AddNewStadium)) return;

            SaveStadiumForm addNewStadiumForm = new SaveStadiumForm(null);
            addNewStadiumForm.MdiParent = this;
            addNewStadiumForm.Show();
        }

        private void updateStadiumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckAccess(ClsGlobal.Permission.UpdateStadium)) return;

            FindStadiumForm FindStadiumForm = new FindStadiumForm();
            FindStadiumForm.MdiParent = this;
            FindStadiumForm.Show();
        }

        // ===========================================================
        //  MATCH EVENTS
        // ===========================================================
        private void showAllCurrenntMatchesTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckAccess(ClsGlobal.Permission.ShowCurrentMatches)) return;

            ShowCurrentMatchesTableForm currentMatchesTableForm = new ShowCurrentMatchesTableForm();
            currentMatchesTableForm.MdiParent = this;
            currentMatchesTableForm.Show();
        }

        private void showAllMatchedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckAccess(ClsGlobal.Permission.ShowMatchesHistory)) return;

            Form_ShowMatches form_Show = new Form_ShowMatches();
            // Corrected: Use 'this' as parent for MDI child
            form_Show.MdiParent = this;
            form_Show.Show();
        }

        // ===========================================================
        //  BOOKING & RESERVATIONS EVENTS
        // ===========================================================
        private void showBookedStadiumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckAccess(ClsGlobal.Permission.ShowBookedStadiums)) return;

            BookedStadiumsTableForm bookedStadiumsTableForm = new BookedStadiumsTableForm();
            bookedStadiumsTableForm.MdiParent = this;
            bookedStadiumsTableForm.Show();
        }

        // Duplicate menu item handler for table view
        private void showBookingStadiumsTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckAccess(ClsGlobal.Permission.ShowBookedStadiums)) return;

            BookedStadiumsTableForm bookedStadiumsTableForm = new BookedStadiumsTableForm();
            bookedStadiumsTableForm.MdiParent = this;
            bookedStadiumsTableForm.Show();
        }

        private void bookingStadiumToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if(!CheckAccess(ClsGlobal.Permission.BookingStadium)) return;

            AvailableStadiumsForm availableStadiumsForm = new AvailableStadiumsForm();
            availableStadiumsForm.MdiParent = this;
            availableStadiumsForm.Show();
        }

        private void showReservedStadiumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckAccess(ClsGlobal.Permission.ShowReservedStadiums)) return;

            ReservedStadiumsTableForm reservedStadiumsTableForm = new ReservedStadiumsTableForm();
            reservedStadiumsTableForm.MdiParent = this;
            reservedStadiumsTableForm.Show();
        }

        // Duplicate menu item handler
        private void reservedStadiumsTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckAccess(ClsGlobal.Permission.ShowReservedStadiums)) return;

            ReservedStadiumsTableForm reservedStadiumsTableForm = new ReservedStadiumsTableForm();
            reservedStadiumsTableForm.MdiParent = this;
            reservedStadiumsTableForm.Show();
        }

        private void reserveStadiumToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if(!CheckAccess(ClsGlobal.Permission.ReserveStadium)) return;

            ShowAllStadiumsForm showAllStadiumsForm = new ShowAllStadiumsForm();
            showAllStadiumsForm.MdiParent = this;
            showAllStadiumsForm.Show();
        }

        // ===========================================================
        //  CLIENTS EVENTS
        // ===========================================================
        private void allClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckAccess(ClsGlobal.Permission.AllClients)) return;

            ClientAsTableForm clientTableForm = new ClientAsTableForm(true, true);
            clientTableForm.MdiParent = this;
            clientTableForm.Show();
        }

        private void ActiveClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckAccess(ClsGlobal.Permission.ActiveClients)) return;

            ClientAsTableForm clientTableForm = new ClientAsTableForm(true, false);
            clientTableForm.MdiParent = this;
            clientTableForm.Show();
        }

        private void inActiveClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckAccess(ClsGlobal.Permission.InActiveClients)) return;

            ClientAsTableForm clientTableForm = new ClientAsTableForm(false, true);
            clientTableForm.MdiParent = this;
            clientTableForm.Show();
        }

        private void findClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mapping "Find Client" to "All Clients" permission
            if(!CheckAccess(ClsGlobal.Permission.AllClients)) return;

            FindClientForm findClientForm = new FindClientForm();
            findClientForm.MdiParent = this;
            findClientForm.Show();
        }

        // ===========================================================
        //  EMPLOYEES EVENTS
        // ===========================================================
        private void showAllEmployeesTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckAccess(ClsGlobal.Permission.ShowAllEmployees)) return;

            ShowAllEmployeesForm showAllEmployeesForm = new ShowAllEmployeesForm();
            showAllEmployeesForm.MdiParent = this;
            showAllEmployeesForm.Show();
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // You removed specific "Add Employee" permission, so we check 
            // if they have access to Employees module or are Admin.
            // Here we check ShowAllEmployees as the gatekeeper.
            if(!CheckAccess(ClsGlobal.Permission.ShowAllEmployees)) return;

            SaveUserStep1Form saveEmployeeForm = new SaveUserStep1Form(null, false);
            saveEmployeeForm.MdiParent = this;
            saveEmployeeForm.Show();
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckAccess(ClsGlobal.Permission.ShowAllEmployees)) return;

            ClsEmployee employee = ClsEmployee.FindEmployee(2);
            SaveEmployeeStep2Form saveEmployeeStep2Form = new SaveEmployeeStep2Form(employee, true);
            saveEmployeeStep2Form.MdiParent = this;
            saveEmployeeStep2Form.Show();
        }

        // ===========================================================
        //  USER EVENTS
        // ===========================================================
        private void showAllUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckAccess(ClsGlobal.Permission.ShowAllUsers)) return;

            ShowAllUsersForm showAllUsersForm = new ShowAllUsersForm();
            showAllUsersForm.MdiParent = this;
            showAllUsersForm.Show();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckAccess(ClsGlobal.Permission.AddNewUser)) return;

            SaveUserStep1Form saveEmployeeForm = new SaveUserStep1Form(null, false);
            saveEmployeeForm.MdiParent = this;
            saveEmployeeForm.Show();
        }

        private void updateUserPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckAccess(ClsGlobal.Permission.UpdateUser)) return;

            FindUserForm findUserForm = new FindUserForm();
            findUserForm.MdiParent = this;
            findUserForm.Show();
        }

        private void findUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mapping "Find User" to "Show All Users" permission
            if(!CheckAccess(ClsGlobal.Permission.ShowAllUsers)) return;

            FindUserForm findUserForm = new FindUserForm();
            findUserForm.MdiParent = this;
            findUserForm.Show();
        }

        // ===========================================================
        //  WINDOW CONTROLS
        // ===========================================================
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainMenuForm_ResizeEnd(object sender, EventArgs e)
        {
            PositionCloseButton();
        }

        private void dddddddToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}