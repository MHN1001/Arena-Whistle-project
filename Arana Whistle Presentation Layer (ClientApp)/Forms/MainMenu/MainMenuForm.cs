using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arana_Whistle_Presentation_Layer.Forms.AboutClient;
using Arana_Whistle_Presentation_Layer.Forms.StadiumMenu;
using Arena_Whistle_Buisness_layer;
using ShowAllStadiums_ControlLibrary.Global_Util_Class;

namespace Arana_Whistle_Presentation_Layer.Forms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            SayWelcomeToCurrentClientOnTitle();

        }


        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            StadiumMainForm stadiumMainForm = new StadiumMainForm();
            stadiumMainForm.ShowDialog();
        }
        private void btnCreateMyAccount_Click(object sender, EventArgs e)
        {
            ClientMainForm clientMainForm = new ClientMainForm();
            clientMainForm.ShowDialog();
        }






        private void SayWelcomeToCurrentClientOnTitle()
        {
            lblWelcomeTitle.Text = $"Welcome \n {Global.CurrentClient.UserName}";
            lblWelcomeTitle.Left =  Cls_UI_Utility.CenterLabel(lblWelcomeTitle.Width, this.Width);
               
        }

  

        private void uC_ShowStadiums1_Load_1(object sender, EventArgs e)
        { 
        }

        private void lblWelcomeTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
