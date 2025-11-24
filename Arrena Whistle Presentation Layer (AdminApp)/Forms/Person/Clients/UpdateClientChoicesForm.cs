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
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Person.Clients.User_Controls;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Person.Clients
{
    public partial class UpdateClientChoicesForm : Form
    {

        ClsClient client;

        public UpdateClientChoicesForm(ClsClient client)
        {
            InitializeComponent();

            this.client = client;
        }

        private void UpdateClientChoicesForm_Load(object sender, EventArgs e)
        {
            if(client != null) txtFullName.Text = client.FullName();
        }

        private void BtnUpdateEmployeeDetails_Click(object sender, EventArgs e)
        {
            UpdateClientCredentialsForm updateClientCredentialsForm = new UpdateClientCredentialsForm(client);
            updateClientCredentialsForm.MdiParent = this.MdiParent;
            updateClientCredentialsForm.Show();
            //this.Close();
        }

        private void btnUpdatePersonaInfos_Click(object sender, EventArgs e)
        {
            SaveClientForm saveClientForm = new SaveClientForm(client);
            saveClientForm.MdiParent = this.MdiParent;
            //this.Hide();
            saveClientForm.Show();
            //this.Close();
        }

        private void btnChangeActiveStatus_Click(object sender, EventArgs e)
        {
            ChangeActiveStatusForm changeActiveStatusForm = new ChangeActiveStatusForm(client);
            changeActiveStatusForm.MdiParent = this.MdiParent;
            changeActiveStatusForm.Show();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
