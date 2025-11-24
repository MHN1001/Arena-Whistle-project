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
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Employees.User_Controls;
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Person.Clients;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Clients
{
    public partial class FindClientForm : Form
    {
        ClsClient client;

        public FindClientForm()
        {
            InitializeComponent();
        }

        public delegate void ObjectEventHandler(ClsClient ClientObj);
        public event ObjectEventHandler DataSent;


        private void FindClientForm_Load(object sender, EventArgs e)
        {
            BtnContinue.Visible = false;
            uC_findPerson1.Start();
        }


        private void BtnContinue_Click(object sender, EventArgs e)
        {
            PassClientID(client);
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uC_findPerson1_OnClientFoundSuccessfully(ClsClient obj)
        {
            client = obj;

            BtnContinue.Visible = true;
        }

        private void uC_findPerson1_OnExit()
        {
            this.Close();
        }

        private void uC_findPerson1_OnLoadingFailed()
        {
            client = null;
            BtnContinue.Visible = false;
        }

        private void uC_findPerson1_OnNotFound()
        {
            BtnContinue.Visible = false;

        }

        private void uC_findPerson1_OnShowFullDataButtonClicked(ClsClient obj)
        {
            ShowFullPersonDataForm showFullPersonDataForm = new ShowFullPersonDataForm(obj);
            this.Hide();
            showFullPersonDataForm.ShowDialog();
            this.Show();
        }









        private void PassClientID(ClsClient ClientObj)
        {
            DataSent?.Invoke(ClientObj);
        }
    }
}
