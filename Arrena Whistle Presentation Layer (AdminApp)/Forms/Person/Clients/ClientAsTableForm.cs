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
using Arena_Whistle_Buisness_layerm;
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Person.Clients;
using Arrena_Whistle_Admin_Presentation_Layer.Forms_and_UserControls.Clients;
using ControlLibrary.Helpers;
using ShowAllStadiums_ControlLibrary.Validations;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Clients
{
    public partial class ClientAsTableForm : Form
    {
        public ClientAsTableForm(bool ActiveClients, bool InActiveClients)
        {
            InitializeComponent();

            _ActiveClients = ActiveClients;
            _InActiveClients = InActiveClients;
        }

        bool _ActiveClients, _InActiveClients;

        private void ClientAsTableForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void uC_DGV1_Load(object sender, EventArgs e)
        {

        }

        private void uC_DGV1_OnShowTSMIclicked(DataGridViewRow obj)
        {
            if(obj != null)
            {
                int? PersonID = clsValidation.GetCellValueIfNotNull<int?>(obj, "PersonID");


                if(PersonID != null)
                {
                    ClsPerson PersonObj = ClsPerson.FindPersonbyID(PersonID.GetValueOrDefault());
                    if(PersonObj != null)
                    {
                        ShowClientCardForm showClientCardForm = new ShowClientCardForm(PersonObj);
                        showClientCardForm.MdiParent = this.MdiParent;
                        showClientCardForm.Show();
                        //this.Close();

                        return;
                    }

                }
                GlobalMessages.ShowLoadingFailed();
            }
        }

        private void uC_DGV1_OnUpdateTSMIclicked(DataGridViewRow obj)
        {
            if(obj != null)
            {
                int? StadiumID = clsValidation.GetCellValueIfNotNull<int?>(obj, "ClientID");


                if(StadiumID != null)
                {
                    ClsClient client = ClsClient.FindClient(StadiumID.GetValueOrDefault());
                    if(client != null)
                    {
                        UpdateClientChoicesForm updateClientChoicesForm = new UpdateClientChoicesForm(client);
                        updateClientChoicesForm.MdiParent = this.MdiParent;
                        updateClientChoicesForm.Show();
                        this.Close();

                        return;
                    }

                }
                GlobalMessages.ShowLoadingFailed();
            }
        }

        private void uC_DGV1_OnCloseButtonClicked()
        {
            this.Close();
        }

        private void uC_DGV1_OnDeleteTSMIclicked(DataGridViewRow obj)
        {
            int? ClientID = clsValidation.GetCellValueIfNotNull<int?>(obj, "ClientID");

            if(ClientID != null)
            {

                if(ClsClient.DeleteClient(ClientID.GetValueOrDefault(), Global.ClsGlobal.CurrentUser.UserID))
                {

                    if(uC_DGV1.DeleteTheTargetRow("ClientID", ClientID))
                    {
                        GlobalMessages.DeletedSucessfully();

                        return;
                    }
                }
            }
            GlobalMessages.DeletedFailed();
        }











        private void LoadData()
        {
             if(_InActiveClients && _ActiveClients)
            {
                uC_DGV1.ExecuteData(ClsClient.GetClients(null));
                uC_DGV1.ControlContextMenuStripItemsVisibility(true, false, false, true, false, false);
                uC_DGV1.SetTitle("All Clients");

                return;
            }

            else if(_ActiveClients)
            {
                uC_DGV1.ExecuteData(ClsClient.GetClients(true));
                uC_DGV1.ControlContextMenuStripItemsVisibility(true, false, false, true, true, false);
                uC_DGV1.SetTitle("Active Clients"); 

                return;
            }
            else if(_InActiveClients)
            {
                uC_DGV1.ExecuteData(ClsClient.GetClients(false));
                uC_DGV1.ControlContextMenuStripItemsVisibility(true, false, false, true, false, false);
                uC_DGV1.SetTitle("InActive Clients");
            }
        }
    }
}
