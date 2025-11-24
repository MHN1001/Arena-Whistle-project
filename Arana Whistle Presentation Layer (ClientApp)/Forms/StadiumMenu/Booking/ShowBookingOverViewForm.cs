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
using ShowAllStadiums_ControlLibrary;
using ShowAllStadiums_ControlLibrary.Global_Util_Class;

namespace Arana_Whistle_Presentation_Layer.Forms.StadiumMenu.Booking
{
    public partial class ShowBookingOverViewForm : Form
    {
        public ShowBookingOverViewForm(int StadiumID, int BookingID)
        {
            InitializeComponent();

            this.StadiumID = StadiumID;
            this.BookingID = BookingID;
        }

        int StadiumID = 0, BookingID = 0;


        private void ShowBookingOverViewForm_Load(object sender, EventArgs e)
        {
            CenterLabel();

            uC_BookingInfosSummary1.LoadBookingData(BookingID);
            uC_BookingInfosSummary1.ShowFullDataButton = false;
            uC_StadiumInfosSummary1.LoadStadiumDataByID(StadiumID);
            uC_StadiumInfosSummary1.ShowFullDataButton = false;
        }

        private void uC_StadiumInfosSummary1_OnLoadingFailed()
        {
            PerformOnLoadingFailedProcess();
        }

        private void uC_BookingInfosSummary1_OnLoadingFailed()
        {
            PerformOnLoadingFailedProcess();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void uC_BookingInfosSummary1_Load(object sender, EventArgs e)
        {

        }

        private void uC_BookingInfosSummary1_OnShowFullDataButtonClicked(ClsBooking obj)
        {

        }








        private void CenterLabel()
        {
            lblTitle.Left = Cls_UI_Utility.CenterLabel(lblTitle.Width, this.Width);
        }
        private void PerformOnLoadingFailedProcess()
        {
            MessageBox.Show("LOADING FAILED !", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }
    }
}
