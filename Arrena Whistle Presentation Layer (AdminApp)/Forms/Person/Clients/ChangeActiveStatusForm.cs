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
using Arrena_Whistle_Admin_Presentation_Layer.Forms_and_UserControls.Clients;
using ControlLibrary.Helpers;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Person.Clients
{
    public partial class ChangeActiveStatusForm : Form
    {
        public ChangeActiveStatusForm(ClsClient clientObj)
        {
            InitializeComponent();

            this._clientObj = clientObj;
        }

        ClsClient _clientObj;

        private void ChangeActiveStatusForm_Load(object sender, EventArgs e)
        {
            if(CheckObjectIfNull()) return;

            LoadCurrentStatus();
            uC_PersonnalInfosAsSummary1.LoadPersonData(_clientObj);
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _clientObj.IsActive = rbActive.Checked;

            if(_clientObj.saveClient())
            {
                GlobalMessages.ShowSavingSuccess("Client Status Updated Sucessfully.");
            }
            else
            {
                GlobalMessages.ShowSavingFailed();
            }

        }
        private void uC_PersonnalInfosAsSummary1_OnShowAllInfosButtonClick(Arena_Whistle_Buisness_layerm.ClsPerson obj)
        {
            ShowClientCardForm showClientCard = new ShowClientCardForm(obj);
            showClientCard.MdiParent = this.MdiParent;
            showClientCard.Show();

        }
        private void uC_PersonnalInfosAsSummary1_OnPersonDataLoadFailed()
        {
            this.Close();
        }





        private bool CheckObjectIfNull()
        {
            if(_clientObj == null)
            {
                GlobalMessages.ShowLoadingFailed();
                return true;
            }
            else
            {

                return false;
            }
        }
        private void LoadCurrentStatus()
        {
            if(_clientObj.IsActive) 
                rbActive.Checked = true;
            else
                rbInActive.Checked = true;
        }

    }
}
