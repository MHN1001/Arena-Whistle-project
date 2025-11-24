using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arana_Whistle_Presentation_Layer.Login.Registry;
using Arena_Whistle_Buisness_layer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Arana_Whistle_Presentation_Layer.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        Dictionary<byte, string> Images = new Dictionary<byte, string>
        {
            { 1, @"C:\Users\Admin\source\repos\Arena Whistle Project\Arena Whistle Photos\Login Form Picures\1.png" },
            { 2,  @"C:\Users\Admin\source\repos\Arena Whistle Project\Arena Whistle Photos\Login Form Picures\2.png" },
            { 3,  @"C:\Users\Admin\source\repos\Arena Whistle Project\Arena Whistle Photos\Login Form Picures\3.png" },
            { 4,  @"C:\Users\Admin\source\repos\Arena Whistle Project\Arena Whistle Photos\Login Form Picures\4.png" },
            { 5,  @"C:\Users\Admin\source\repos\Arena Whistle Project\Arena Whistle Photos\Login Form Picures\5.png" },
            { 6,  @"C:\Users\Admin\source\repos\Arena Whistle Project\Arena Whistle Photos\Login Form Picures\6.png" },
            { 7,  @"C:\Users\Admin\source\repos\Arena Whistle Project\Arena Whistle Photos\Login Form Picures\7.png" },
            { 8,  @"C:\Users\Admin\source\repos\Arena Whistle Project\Arena Whistle Photos\Login Form Picures\8.png" },
            { 9,  @"C:\Users\Admin\source\repos\Arena Whistle Project\Arena Whistle Photos\Login Form Picures\9.png" },
            { 10, @"C:\Users\Admin\source\repos\Arena Whistle Project\Arena Whistle Photos\Login Form Picures\10.png" },
            { 11, @"C:\Users\Admin\source\repos\Arena Whistle Project\Arena Whistle Photos\Login Form Picures\11.png" },
            { 12, @"C:\Users\Admin\source\repos\Arena Whistle Project\Arena Whistle Photos\Login Form Picures\12.png" },
            { 13, @"C:\Users\Admin\source\repos\Arena Whistle Project\Arena Whistle Photos\Login Form Picures\13.png" },
        };
        byte ImgIndex = 0;


        private void LoginForm_Load(object sender, EventArgs e)
        {
            GetStoredLoginData();

            txtUserName.Focus();

            timer1.Start();

        }
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            txtUserName.IsValid(ref e, errorProvider1, "User Name Is Required !");
        }
        private void txtPassWord_Validating(object sender, CancelEventArgs e)
        {
            txtPassWord.IsValid(ref e, errorProvider1, "Password Should not be Empty !");
        }
        private void pbbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void linkLblCreateNewAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm1cs signUpForm1 = new SignUpForm1cs();
            this.Hide();
            signUpForm1.ShowDialog();
            this.Show();

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ImgIndex++ == 13)
                ImgIndex = 1;

           pbImage.ImageLocation = Images[ImgIndex];
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
        private void CallClientMainForm()
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            this.Hide();
            mainMenuForm.ShowDialog();
            this.Show();
        }
        private void Login()
        {
            if(!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClsClient client = ClsClient.FindClientByUserNameAndPassword(txtUserName.Text.Trim(),
                                                                         ClsUtilB.ComputeHash(txtPassWord.Text.Trim()));

            if(client != null)
            {
                Global.CurrentClient = client;

                if(ChbRememberMe.Checked)
                {
                    //store username and password
                    ClsUtilB.RememberUsernameAndPassword(ConfigurationManager.AppSettings["RegistryPath"] ,txtUserName.Text.Trim(), txtPassWord.Text.Trim());

                }
                else
                {
                    //store empty username and password
                    ClsUtilB.RememberUsernameAndPassword(ConfigurationManager.AppSettings["RegistryPath"]  ,"", "");

                }

                CallClientMainForm();
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
