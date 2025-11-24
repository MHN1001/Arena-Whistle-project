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

namespace ShowAllStadiums_ControlLibrary.Stadiums.Reeservation
{
    public partial class UC_ShowReservationOverView : UserControl
    {
        public UC_ShowReservationOverView()
        {
            InitializeComponent();
        }

        public event Action OnLoadFailed;
        protected virtual void DataLoadFailed()
        {
            Action Handler = OnLoadFailed;

            if(Handler != null)
            {
                Handler();
            }
        }




        public event Action<ClsPerson> OnShowAllInfosButtonClick_FromPersonControl;
        protected virtual void ShowAllInfosButtonClick_FromPersonControl(ClsPerson personobj)
        {
            Action<ClsPerson> Handler = OnShowAllInfosButtonClick_FromPersonControl;

            if(Handler != null)
            {
                Handler(personobj);
            }
        }


        public event Action<ClsStadium> OnShowFullDataButtonClicked_FromStadiumControl;
        protected virtual void ShowFullDataButtonClicked_FromStadiumControl(ClsStadium Stadium)
        {
            Action<ClsStadium> Handler = OnShowFullDataButtonClicked_FromStadiumControl;

            if(Handler != null)
            {
                Handler(Stadium);
            }
        }


        private void UC_ShowReservationOverView_Load(object sender, EventArgs e)
        {

        }
        private void uC_StadiumInfosSummary1_OnLoadingFailed()
        {
            if(OnLoadFailed != null)
                OnLoadFailed();
        }

        private void uC_StadiumInfosSummary1_OnShowFullDataButtonClicked(ClsStadium obj)
        {
            if(OnShowFullDataButtonClicked_FromStadiumControl != null)
                ShowFullDataButtonClicked_FromStadiumControl(obj);
        }

        private void uC_PersonnalInfosAsSummary1_OnPersonDataLoadFailed()
        {
            if(OnLoadFailed != null)
                OnLoadFailed();
        }

        private void uC_PersonnalInfosAsSummary1_OnShowAllInfosButtonClick(ClsPerson obj)
        {
            if(OnShowAllInfosButtonClick_FromPersonControl != null)
                ShowAllInfosButtonClick_FromPersonControl(obj);
        }





        public void LoadReservationInfo(int ReservationID)
        {
            ClsStadiumReservation reservation = ClsStadiumReservation.Find(ReservationID);

            if(reservation != null)
            {
                uC_PersonnalInfosAsSummary1.LoadPersonData(ClsClient.FindClient(reservation.ClientID).PersonID);
                uC_StadiumInfosSummary1.LoadStadiumDataByID(reservation.StadiumID);
                txtStatus.Text = reservation.Status.ToString();
            }
        }

    }
}
