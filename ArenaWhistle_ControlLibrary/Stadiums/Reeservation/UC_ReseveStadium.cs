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
using ShowAllStadiums_ControlLibrary.Global_Util_Class;
using ControlLibrary.Helpers;

namespace ShowAllStadiums_ControlLibrary.Stadiums
{
    public partial class UC_ReserveStadium : UserControl
    {
        public UC_ReserveStadium()
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


        public event Action OnAddedSuccessfully;
        protected virtual void AddedSuccessfully()
        {
            Action Handler = OnAddedSuccessfully;
            if(Handler != null)
            {
                Handler();
            }
        }


        public event Action OnAddedFailed;
        protected virtual void AddedFailed()
        {
            Action Handler = OnAddedFailed;
            if(Handler != null)
            {
                Handler();
            }
        }



        int ClientID;
        int StadiumID;
        int? ByUserID;


        private void UC_ReseveStadium_Load(object sender, EventArgs e)
        {
            lblTitle.Left = Cls_UI_Utility.CenterLabel(lblTitle.Width, this.Width);
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if(!GlobalMessages.Confirm("Do you Want to Reserve This Stadium ?"))
                return;

            ClsStadiumReservation reservation = new ClsStadiumReservation();

            reservation.StadiumID = this.StadiumID;
            reservation.ClientID = this.ClientID;

            if(!reservation.AddStadiumReservation(this.ByUserID))
            {
                GlobalMessages.ShowSavingFailed();

                if(OnAddedFailed != null)
                    AddedFailed();
            }
            else
            {
                GlobalMessages.ShowSavingSuccess();

                if(OnAddedSuccessfully != null)
                {
                    AddedSuccessfully();
                }
            }
        }

        private void uC_StadiumInfosSummary1_OnLoadingFailed()
        {
            GlobalMessages.ShowLoadingFailed();

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
            GlobalMessages.ShowLoadingFailed();

            if(OnLoadFailed != null)
                OnLoadFailed();
        }

        private void uC_PersonnalInfosAsSummary1_OnShowAllInfosButtonClick(ClsPerson obj)
        {
            if(OnShowAllInfosButtonClick_FromPersonControl != null)
                ShowAllInfosButtonClick_FromPersonControl(obj);
        }









        public void EnableBtnShowAllStadiumInfos(bool status)
        {
            uC_StadiumInfosSummary1.ShowFullDataButton = status;
        }
        public void EnableBtnShowAllPersonIfos(bool status)
        {
            uC_PersonnalInfosAsSummary1.ShowFullDataButton = status;
        }
        public void PassIdsForControls(int ClientID, int StadiumID, int? ByUserID)
        {
            this.ClientID = ClientID;
            this.StadiumID = StadiumID;
            this.ByUserID = ByUserID;

            uC_PersonnalInfosAsSummary1.LoadPersonData(ClsClient.FindClient(ClientID).PersonID);
            uC_StadiumInfosSummary1.LoadStadiumDataByID(StadiumID);
        }
    }
}
