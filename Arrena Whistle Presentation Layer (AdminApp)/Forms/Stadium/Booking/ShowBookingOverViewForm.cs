using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Employees.User_Controls;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Stadium.Booking
{
    public partial class ShowBookingOverViewForm : Form
    {
        public ShowBookingOverViewForm(int PersonID, int StadiumID, int BookingID)
        {
            InitializeComponent();

            this.PersonID = PersonID;
            this.StadiumID = StadiumID;
            this.BookingID = BookingID;
        }

        int PersonID, StadiumID, BookingID;

        private void uC_BookingOverView1_OnLoadingFailed()
        {
            this.Close();
        }

        private void uC_BookingOverView1_OnShowAllInfosButtonClick_FromPersonControl(Arena_Whistle_Buisness_layerm.ClsPerson obj)
        {
            ShowFullPersonDataForm showFullPersonDataForm = new ShowFullPersonDataForm(obj);
            showFullPersonDataForm.ShowDialog();
        }

        private void uC_BookingOverView1_OnShowFullDataButtonClicked_FromBookingControl(Arena_Whistle_Buisness_layer.ClsBooking obj)
        {
            ShowFullBookingDataForm showFullBookingDataForm = new ShowFullBookingDataForm(obj);
            showFullBookingDataForm.ShowDialog();
        }

        //private void uC_BookingOverView1_OnShowFullDataButtonClicked_FromStadiumControl(Arena_Whistle_Buisness_layer.ClsStadium obj)
        //{

        //}

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowBookingOverViewForm_Load(object sender, EventArgs e)
        {
            uC_BookingOverView1.PassIDsForUserControls(PersonID, StadiumID, BookingID);
        }
    }
}
