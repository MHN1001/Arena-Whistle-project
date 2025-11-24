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
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Stadium.Booking;
using Arrena_Whistle_Admin_Presentation_Layer.Forms_and_UserControls.Matches;
using ControlLibrary.Helpers;
using ShowAllStadiums_ControlLibrary.Validations;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Stadium
{
    public partial class BookedStadiumsTableForm : Form
    {
        public BookedStadiumsTableForm()
        {
            InitializeComponent();
        }

        private void BookedStadiumsTableForm_Load(object sender, EventArgs e)
        {
            uC_DGV1.ExecuteData(ClsBooking.GetSBookingTableForAdmin());
            uC_DGV1.ControlContextMenuStripItemsVisibility(false, true, true, false, false, false);
            uC_DGV1.SetTitle("Booked Stadiums");
        }

        private void uC_DGV1_Load(object sender, EventArgs e)
        {

        }

        private void uC_DGV1_OnCloseButtonClicked()
        {
            this.Close();
        }

        private void uC_DGV1_OnAddTSMIclicked()
        {
            AvailableStadiumsForm availableStadiumsForm = new AvailableStadiumsForm();
            availableStadiumsForm.Show();
        }

        private void uC_DGV1_OnShowAsSummaryTSMIclicked(DataGridViewRow obj)
        {
            if(obj != null)
            {
                int? StadiumID = clsValidation.GetCellValueIfNotNull<int?>(obj, "StadiumID");
                int? bookingID = clsValidation.GetCellValueIfNotNull<int?>(obj, "BookingID");
                int? PersonID = clsValidation.GetCellValueIfNotNull<int?>(obj, "PersonID");

                if(PersonID != null && StadiumID != null && bookingID != null)
                {
                    ShowBookingOverViewForm timeLeftForm = new ShowBookingOverViewForm(PersonID.GetValueOrDefault(), StadiumID.GetValueOrDefault(), bookingID.GetValueOrDefault());
                    timeLeftForm.Show();
                }
                else
                {
                    GlobalMessages.ShowLoadingFailed();
                }
            }
        }
    }
}
