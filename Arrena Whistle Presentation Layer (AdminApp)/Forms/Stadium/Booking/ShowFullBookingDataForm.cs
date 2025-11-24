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


namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Stadium.Booking
{
    public partial class ShowFullBookingDataForm : Form
    {
        public ShowFullBookingDataForm(ClsBooking booking)
        {
            InitializeComponent();

            _bookingObj = booking;
        }


        ClsBooking _bookingObj;

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowFullBookingDataForm_Load(object sender, EventArgs e)
        {
            uC_ShowFullBookingInfo1.LoadBookingData(_bookingObj);
        }

        private void uC_ShowFullBookingInfo1_OnLoadingFailed()
        {
            this.Close();
        }
    }
}
