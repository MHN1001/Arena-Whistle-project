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
using Guna.UI2.WinForms;
using ShowAllStadiums_ControlLibrary.Validations;

namespace Arana_Whistle_Presentation_Layer.Forms.StadiumMenu.Booking
{
    public partial class BookedStadiumsTableForm : Form
    {
        public BookedStadiumsTableForm()
        {
            InitializeComponent();
        }

        private void BookedStadiumsTableForm_Load(object sender, EventArgs e)
        {
            uC_DGV1.ExecuteData(ClsBooking.GetSBookingTableForClient());
            uC_DGV1.ControlContextMenuStripItemsVisibility(false, true, false, false, false, false);
            uC_DGV1.SetTitle("Booked Stadiums");
        }
        private void uC_DGV1_OnCloseButtonClicked()
        {
            this.Close();
        }
        private void uC_DGV1_OnShowAsSummaryTSMIclicked(DataGridViewRow obj)
        {
            if(obj != null)
            {
                int? StadiumID = clsValidation.GetCellValueIfNotNull<int?>(obj, "StadiumID");
                int? bookingID = clsValidation.GetCellValueIfNotNull<int?>(obj, "StadiumBookingID");

                if(StadiumID != null && bookingID != null)
                {
                    ShowBookingOverViewForm timeLeftForm = new ShowBookingOverViewForm(StadiumID.GetValueOrDefault(), bookingID.GetValueOrDefault());
                    timeLeftForm.Show();
                }
                else
                {
                    GlobalMessages.ShowLoadingFailed();
                }
            }
        }

        private void uC_DGV1_Load(object sender, EventArgs e)
        {

        }
    }
}

