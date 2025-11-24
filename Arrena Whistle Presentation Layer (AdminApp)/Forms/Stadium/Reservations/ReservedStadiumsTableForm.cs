using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arena_Whistle_Buisness_layer;
using ControlLibrary.Helpers;
using Guna.UI2.WinForms;
using ShowAllStadiums_ControlLibrary;
using ShowAllStadiums_ControlLibrary.Validations;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Stadium
{
    public partial class ReservedStadiumsTableForm : Form
    {
        public ReservedStadiumsTableForm()
        {
            InitializeComponent();
        }

        private void ReservedStadiumsTableForm_Load(object sender, EventArgs e)
        {
            uC_DGV1.ExecuteData(ClsStadiumReservation.GetStadiumReservationTableForAdmin());
            uC_DGV1.ControlContextMenuStripItemsVisibility(false, false, true, false, false, true);
            uC_DGV1.SetTitle("Reserved Stadiums");
        }
        private void uC_DGV1_OnCancelTSMIclicked(DataGridViewRow obj)
        {
            int ReservationId = clsValidation.GetCellValueIfNotNull<int>(obj, "ReservationID");

            if(ReservationId > 0)
            {
                if(ClsStadiumReservation.CancelReservation(ReservationId, Global.ClsGlobal.CurrentUser.UserID))
                {
                    //uC_DGV1.DeleteTheTargetRow<int>("ReservationID", ReservationId);
                    GlobalMessages.CancelSuccessfully("The Resevation has been Canceled.");
                    uC_DGV1.ExecuteData(ClsStadiumReservation.GetStadiumReservationTableForAdmin());
                }
            }
            else
            {
                GlobalMessages.CancelFailed("The reservation isn't canceled.");
            }
        }
        private void uC_DGV1_OnCloseButtonClicked()
        {
            this.Close();
        }
        private void uC_DGV1_OnAddTSMIclicked()
        {
            ShowAllStadiumsForm showAllStadiumsForm = new ShowAllStadiumsForm();
            showAllStadiumsForm.MdiParent = this.MdiParent;
            showAllStadiumsForm.Show();
            this.Close();
        }

        private void uC_DGV1_Load(object sender, EventArgs e)
        {

        }
    }
}
