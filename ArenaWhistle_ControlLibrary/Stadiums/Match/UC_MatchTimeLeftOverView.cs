using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShowAllStadiums_ControlLibrary.Global_Util_Class;

namespace ShowAllStadiums_ControlLibrary.Stadiums.Match
{
    public partial class UC_MatchTimeLeftOverView : UserControl
    {
        public UC_MatchTimeLeftOverView()
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



        public event Action OnCurrentMatchIsDone;
        protected virtual void CurrentMatchIsDone()
        {
            Action Handler = OnCurrentMatchIsDone;

            if(Handler != null)
            {
                Handler();
            }
        }

        //events
        private void UC_MatchTimeLeftOverView_Load(object sender, EventArgs e)
        {
            CenterLabel();
        }
        private void uC_StadiumInfosSummary1_OnLoadingFailed()
        {
            ExecuteOnLoadingFailedEvent();
        }

        private void uC_BookingInfosSummary1_OnLoadingFailed()
        {
            ExecuteOnLoadingFailedEvent();
        }

        private void uC_ShowCurrentMatchTimeLeft1_OnLoadingFailed()
        {
            ExecuteOnLoadingFailedEvent();
        }

        private void uC_ShowCurrentMatchTimeLeft1_OnCurrentMatchIsDone()
        {
            executeOnCurrentMatchTimeIsDoneEventProcess();
        }




        private void executeOnCurrentMatchTimeIsDoneEventProcess()
        {
            MessageBox.Show("The Match Time Is Done !\nGo Back to Booking zone if you want to bookin This Stadium", "FINISHED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if(OnCurrentMatchIsDone != null)
                CurrentMatchIsDone();
        }
        private void ExecuteOnLoadingFailedEvent()
        {
            MessageBox.Show("The data is loaded incorrectly !", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            if(OnLoadingFailed != null)
            {
                LoadingFailed();
            }
        }
        private void CenterLabel()
        {
            lblTitle.Left = Cls_UI_Utility.CenterLabel(lblTitle.Width, this.Width);
        }
        public void PassDataToControls((string StartTime, string EndTime) MatchTimePeriod, int StadiumID, int BookingID)
        {
            uC_StadiumInfosSummary1.LoadStadiumDataByID(StadiumID);
            uC_BookingInfosSummary1.LoadBookingData(BookingID);
            uC_ShowCurrentMatchTimeLeft1.PassTargetRow(MatchTimePeriod);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
