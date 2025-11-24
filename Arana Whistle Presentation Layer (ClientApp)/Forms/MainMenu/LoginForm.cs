using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arana_Whistle_Presentation_Layer.Login.Registry;
using Arena_Whistle_Buisness_layer;

namespace Arana_Whistle_Presentation_Layer.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }



        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();

        }
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            txtUserName.IsValid(ref e, errorProvider1, "User Naame Is Required !");
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
            signUpForm1.ShowDialog();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }




        private void CallClientMainForm()
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.ShowDialog();

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

                this.Hide();
                CallClientMainForm();
            }
            else
            {
                MessageBox.Show("Not Found\nPlease enter your Account Login Informations Correctly !"
                                ,"Not Found" , MessageBoxButtons.OK , MessageBoxIcon.Warning ,
                                 MessageBoxDefaultButton.Button1 );
            }
        }

    }
}
