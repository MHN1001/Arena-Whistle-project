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

namespace Arana_Whistle_Presentation_Layer.Forms.AboutClient
{
    public partial class ClientMainForm : Form
    {
        public ClientMainForm()
        {
            InitializeComponent();
        }

        private void ClientMainForm_Load(object sender, EventArgs e)
        {
            uC_showPersonCard1.LoadPersonDataByID(Global.CurrentClient.PersonID);
            uC_SavePerson1.Start(Global.CurrentClient);
            uc_UpdatePassword1.PassClientID(Global.CurrentClient.ClientID, null);
        }


        private void btnCloseForm_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        private void uC_showPersonCard1_Load(object sender, EventArgs e)
        {
        }
        private void uc_UpdatePassword1_Load(object sender, EventArgs e)
        {

        }

        private void uC_showPersonCard1_OnPersonDataLoadFailed()
        {
            MessageBox.Show("Failed to Loading Person data :(");
        }

        private void uC_SavePerson1_Load(object sender, EventArgs e)
        {

        }

        private void uC_SavePerson1_OnUpdatedSuccessfully(Arena_Whistle_Buisness_layerm.ClsPerson obj)
        {
            Global.CurrentClient = (ClsClient)obj;

            UpdateClientInfos();
        }




        private void UpdateClientInfos()
        {
            uC_showPersonCard1.LoadPersonDataByID(Global.CurrentClient.PersonID);
        }



        private void uc_UpdatePassword1_OnUpdatingFailed()
        {
            MessageBox.Show("Failed to  update password");

        }

        private void uc_UpdatePassword1_OnClientUpdatedSuccessfully(string obj)
        {
            Global.CurrentClient.Password = obj;
            MessageBox.Show("Your Password Has been Updated Sucessfully !", "Sucessfull");

        }
    }
}
