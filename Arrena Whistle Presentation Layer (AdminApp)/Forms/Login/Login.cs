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
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Main_Menu;
using Arrena_Whistle_Admin_Presentation_Layer.Global;
using System.Configuration;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms_and_UserControls
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCreateMyAccount_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            GetStoredLoginData();

            txtUserName.Focus();
        }

        private void pbbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            txtUserName.IsValid(ref e, errorProvider1, "User Name Is Required !");

        }

        private void txtPassWord_Validating(object sender, CancelEventArgs e)
        {
            txtPassWord.IsValid(ref e, errorProvider1, "Password Should not be Empty !");

        }








        private void GetStoredLoginData()
        {
            (string UserName, string Password)? LoginInfos;

            if(( LoginInfos = ClsUtilB.GetSavedCredentials(ConfigurationManager.AppSettings["RegistryPath"]) ) != null)
            {
                txtUserName.Text = LoginInfos.Value.UserName;
                txtPassWord.Text = LoginInfos.Value.Password;
                ChbRememberMe.Checked = true;
            }
            else
                ChbRememberMe.Checked = false;
        }
        private void CallUserMainForm()
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            this.Hide();
            mainMenuForm.ShowDialog();
            this.Show();
        }
        private void PerformRememberMeProcess()
        {

            if(ChbRememberMe.Checked)
            {
                //store username and password
                ClsUtilB.RememberUsernameAndPassword(ConfigurationManager.AppSettings["RegistryPath"] ,txtUserName.Text.Trim(), txtPassWord.Text.Trim());

            }
            else
            {
                //store empty username and password
                ClsUtilB.RememberUsernameAndPassword(ConfigurationManager.AppSettings["RegistryPath"] ,"", "");

            }
        }
        private void Login()
        {
            if(!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClsUser User = ClsUser.FindClientByUserNameAndPassword(txtUserName.Text.Trim(),
                                                                   ClsUtilB.ComputeHash(txtPassWord.Text.Trim()));

            if(User != null)
            {
                ClsGlobal.CurrentUser = User;

                PerformRememberMeProcess();

                CallUserMainForm();
            }
            else
            {
                MessageBox.Show("Not Found\nPlease enter your Account Login Informations Correctly !"
                                , "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                                 MessageBoxDefaultButton.Button1);
            }
        }
    }
}
