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
using ControlLibrary.Helpers;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Person.Clients.User_Controls
{
    public partial class UpdateClientCredentialsForm : Form
    {

        ClsClient client;

        public UpdateClientCredentialsForm(ClsClient client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void UpdateClientCredentialsForm_Load(object sender, EventArgs e)
        {
            if(!CheckUserObject()) return;

            uc_UpdateUserNameAndPassword1.PassClientID(client.ClientID, Global.ClsGlobal.CurrentUser.UserID);
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        private bool CheckUserObject()
        {
            if(client == null)
            {
                GlobalMessages.ShowLoadingFailed();
                uc_UpdateUserNameAndPassword1.Enabled = false;
                return false;
            }

            return true;

        }

    }
}
