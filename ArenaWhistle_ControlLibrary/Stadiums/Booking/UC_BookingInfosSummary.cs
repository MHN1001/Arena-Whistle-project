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

namespace ShowAllStadiums_ControlLibrary.Stadiums
{
    public partial class UC_BookingInfosSummary : UserControl
    {
        public UC_BookingInfosSummary()
        {
            InitializeComponent();
        }

        public bool ShowFullDataButton
        {
            get => BtnShowFullData.Enabled;
            set => BtnShowFullData.Enabled = value;
        }



        public event Action OnLoadingFailed;
        protected virtual void LoadingFailed()
        {
            Action Handler = OnLoadingFailed;

            if(Handler != null)
            {
                Handler();
            }
        }

        public event Action<ClsBooking> OnShowFullDataButtonClicked;
        protected virtual void ShowFullDataButtonClicked(ClsBooking BookingObj)
        {
            Action<ClsBooking> Handler = OnShowFullDataButtonClicked;

            if(Handler != null)
            {
                Handler(BookingObj);
            }
        }



        private void BtnShowFullData_Click(object sender, EventArgs e)
        {
            if(OnShowFullDataButtonClicked != null)
                ShowFullDataButtonClicked(bookingObj);
        }





        ClsBooking bookingObj;




        public void LoadBookingData(int BookingID)
        {
            bookingObj = ClsBooking.FindStadiumBooking(BookingID);

            if(bookingObj == null)
            {
                BtnShowFullData.Enabled = false;

                if(OnLoadingFailed != null)
                    LoadingFailed();
            }
            else
            {
                FillControlsByStadiumData();
            }

        }
        private void FillControlsByStadiumData()
        {
            txtBookingDate.Text = bookingObj.BookingDate.ToString();
            txtPlayingDate.Text = bookingObj.MatchDate.ToString();
            txtStartTime.Text = bookingObj.StartTime.ToString();
            txtTotalPrice.Text = bookingObj.TotalPrice.ToString() + " $";

            BtnShowFullData.Enabled = true;
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
