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
using ShowAllStadiums_ControlLibrary.Global_Util_Class;


namespace ShowAllStadiums_ControlLibrary.Stadiums
{
    public partial class UC_ShowCurrentMatchTimeLeft : UserControl
    {
        public UC_ShowCurrentMatchTimeLeft()
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

        int CurrentSecondsLeft = 0;


        private void UC_ShowCurrentMatchTimeLeft_Load(object sender, EventArgs e)
        {

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            ProgressBar.Value++;

            CurrentSecondsLeft--;

            UpdateTimeLeftLabels(CurrentSecondsLeft);

            if(CurrentSecondsLeft == 0)
            {
                TurnOnTimer(false);
                CallOnCurrentMatchIdDoneEventt();
            }
        }








        private void TurnOnTimer(bool status)
        {
            if(status)
                timer.Start();
            else
                timer.Stop();
        }

        private void CenterLabelInsideGroupBox(Label lbl)
        {
            if(lbl == LblMinutesLeft)
                LblMinutesLeft.Left = Cls_UI_Utility.CenterLabel(LblMinutesLeft.Width, GbMinutesLeft.Width);
            else if(lbl == LblTotalSeconds)
                LblTotalSeconds.Left = Cls_UI_Utility.CenterLabel(LblTotalSeconds.Width, GbTotalSeconds.Width);
        }

        private void UpdateMinutesLeftLabel(int TotalSeconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(TotalSeconds);
            LblMinutesLeft.Text = time.ToString(@"hh\:mm\:ss");

            CenterLabelInsideGroupBox(LblMinutesLeft);
        }

        private void UpdateTotalSecondsLeftLabel(int TotalSeconds)
        {
            LblTotalSeconds.Text = TotalSeconds.ToString() + " s";

            CenterLabelInsideGroupBox(LblTotalSeconds);
        }
        private void UpdateTimeLeftLabels(int TotalSeconds)
        {
            UpdateMinutesLeftLabel(TotalSeconds);
            UpdateTotalSecondsLeftLabel(TotalSeconds);
        }
        private bool PrepareProgressBarSettings(int MaxValue, int Value)
        {
            if(Value <= 0)
            {
                CallOnCurrentMatchIdDoneEventt();
                return false;
            }

            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = MaxValue;
            ProgressBar.Value = Value;

            return true;
        }

        private void CallLoadingFailedEvent()
        {
            if(OnLoadingFailed != null)
                LoadingFailed();
        }

        private void CallOnCurrentMatchIdDoneEventt()
        {
            if(OnCurrentMatchIsDone != null)
                CurrentMatchIsDone();
        }

        private void SetUpCurrentSecondsLeft(int Value)
        {
            this.CurrentSecondsLeft = Value;
        }
        public void PassTargetRow((string StartTime, string EndTime) MatchTimePeriod)
        {
            (int? Pb_MaxValue, int? Pb_Value) PbValues = ClsMatch.GetMaxValueAndValueFromTheTargetMatch(MatchTimePeriod.StartTime, MatchTimePeriod.EndTime);

            if(!( PbValues.Pb_MaxValue == null || PbValues.Pb_Value == null ))
            {
                if(!PrepareProgressBarSettings(PbValues.Pb_MaxValue ?? 0, PbValues.Pb_Value ?? 0))
                {
                    return;
                }

                SetUpCurrentSecondsLeft(PbValues.Pb_MaxValue.GetValueOrDefault() - PbValues.Pb_Value.GetValueOrDefault());

                UpdateTimeLeftLabels(CurrentSecondsLeft);
                TurnOnTimer(true);
            }
            else
            {
                CallLoadingFailedEvent();
            }


        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
