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

namespace ShowAllStadiums_ControlLibrary.Stadiums
{
    public partial class UC_BookingOverView : UserControl
    {
        public UC_BookingOverView()
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



        public event Action<ClsBooking> OnShowFullDataButtonClicked_FromBookingControl;
        protected virtual void ShowFullDataButtonClicked_FromBookingControl(ClsBooking BookingObj)
        {
            Action<ClsBooking> Handler = OnShowFullDataButtonClicked_FromBookingControl;

            if(Handler != null)
            {
                Handler(BookingObj);
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







        private void UC_BookingOverView_Load(object sender, EventArgs e)
        {
        }
        private void uC_PersonnalInfosAsSummary1_OnPersonDataLoadFailed()
        {
            if(OnLoadingFailed != null)
                LoadingFailed();

        }

        private void uC_PersonnalInfosAsSummary1_OnShowAllInfosButtonClick(Arena_Whistle_Buisness_layerm.ClsPerson obj)
        {
            if(OnShowAllInfosButtonClick_FromPersonControl != null)
                ShowAllInfosButtonClick_FromPersonControl(obj);
        }

        private void uC_StadiumInfosSummary1_OnLoadingFailed()
        {
            if(OnLoadingFailed != null)
                LoadingFailed();
        }

        private void uC_StadiumInfosSummary1_OnShowFullDataButtonClicked(Arena_Whistle_Buisness_layer.ClsStadium obj)
        {
            if(OnShowFullDataButtonClicked_FromStadiumControl != null)
                ShowFullDataButtonClicked_FromStadiumControl(obj);
        }

        private void uC_BookingInfosSummary1_OnLoadingFailed()
        {
            if(OnLoadingFailed != null)
                LoadingFailed();
        }

        private void uC_BookingInfosSummary1_OnShowFullDataButtonClicked(Arena_Whistle_Buisness_layer.ClsBooking obj)
        {
            if(OnShowFullDataButtonClicked_FromBookingControl != null)
                ShowFullDataButtonClicked_FromBookingControl(obj);
        }





        public void PassIDsForUserControls(int PersonID, int StadiumID, int BookingID)
        {
            uC_PersonnalInfosAsSummary1.LoadPersonData(PersonID);
            uC_StadiumInfosSummary1.LoadStadiumDataByID(StadiumID);
            uC_BookingInfosSummary1.LoadBookingData(BookingID);

        }

    }
}
