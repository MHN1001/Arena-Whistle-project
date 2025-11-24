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
    public partial class UC_ShowFullBookingInfo : UserControl
    {
        public UC_ShowFullBookingInfo()
        {
            InitializeComponent();
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






        private void UC_ShowFullBookingInfo_Load(object sender, EventArgs e)
        {

        }






        public void LoadBookingData(ClsBooking BookingObj)
        {

            if(BookingObj == null)
            {
                if(OnLoadingFailed != null)
                    LoadingFailed();
            }
            else
            {
                FillControlsByStadiumData(BookingObj);
            }

        }
        private void FillControlsByStadiumData(ClsBooking BookingObj)
        {
            txtClientName.Text = ClsClient.FindClient(BookingObj.ResponsiblePlayerID).FullName();
            txtStadiumName.Text = ClsStadium.FindStadium(BookingObj.StaduimID).StadiumName;
            txtNo_ofPlayers.Text = BookingObj.NumberOfPlayers.ToString();
            txtNo_ofBalls.Text = BookingObj.NumberOFBalls.ToString();
            txtBookingDate.Text = BookingObj.BookingDate.ToString();
            txtPlayDate.Text = BookingObj.MatchDate.ToString();
            txtStartTime.Text = BookingObj.StartTime.ToString();
            txtEndTime.Text = BookingObj.EndTime.ToString();
            txtShower.Text = BookingObj.Shower ? "Yes" : "No";
            txtClothes.Text = BookingObj.Clothing ? "Yes" : "No";
            txtRefree.Text = BookingObj.Refree ? "Yes" : "No";
            txtTotalPrice.Text = BookingObj.TotalPrice.ToString() + " $";           
        }
    }
}
