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

namespace ShowAllStadiums_ControlLibrary.Stadiums
{
    public partial class UC_ShowStadiums : UserControl
    {

        public UC_ShowStadiums()
        {
            InitializeComponent();
        }


        //public enum EnEnableChoosingButton { Show, Hide }
        //public EnEnableChoosingButton EnableChoosingButton
        //{
        //    get
        //    {
        //        return EnableChoosingButton;
        //    }
        //    set
        //    {

        //        EnableChoosingButton = value;


        //        if(EnableChoosingButton == EnEnableChoosingButton.Hide)
        //        {
        //            this.btnChooseStadium.Enabled = false;
        //        }
        //        else
        //        {
        //            this.btnChooseStadium.Enabled = true;

        //        }

        //    }
        //}



        public event Action OnLoadingFailed;
        protected virtual void LoadingFailed()
        {
            Action Handler = OnLoadingFailed;

            if(Handler != null)
            {
                Handler();
            }
        }

        public event Action<DataView> OnShowAsStadiumsAsATableButtonClicked;
        protected virtual void ShowAsStadiumsAsATableButtonClicked(DataView Stadiums)
        {
            Action<DataView> Handler = OnShowAsStadiumsAsATableButtonClicked;

            if(Handler != null)
            {
                Handler(Stadiums);
            }
        }



        public class TargetStadiumEventArgs : EventArgs
        {
            public DataRowView RowsStadiumsRow { get; }
            public List<string> List_StadiumImages { get; }

            public TargetStadiumEventArgs(DataRowView row, List<string> images)
            {
                RowsStadiumsRow = row;
                List_StadiumImages = images;
            }
        }
        public event Action<TargetStadiumEventArgs> OnBookingNowButtonClicked;
        protected virtual void BookingNowButtonClicked(TargetStadiumEventArgs Stadium)
        {
            Action<TargetStadiumEventArgs> Handler = OnBookingNowButtonClicked;

            if(Handler != null)
            {
                Handler(Stadium);
            }
        }


        public event Action<int> OnReserveNowButtonClicked;
        protected virtual void ReserveNowButtonClicked(int StadiumID)
        {
            Action<int> Handler = OnReserveNowButtonClicked;

            if(Handler != null)
            {
                Handler(StadiumID);
            }
        }




        private (DataView Stadiums, DataView StadiumsImages) _Stadiums;
        public int _StadiumIndex = 0;


        private void UC_ShowAllStadiums_Load(object sender, EventArgs e)
        {
        }
        private void uC_ShowStadiumCard1_Load(object sender, EventArgs e)
        {

        }
        private void btnShowAsATable_Click(object sender, EventArgs e)
        {
            if(OnShowAsStadiumsAsATableButtonClicked != null)
            {
                ShowAsStadiumsAsATableButtonClicked(_Stadiums.Stadiums);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            ShowNextStadium();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowPreviousStadium();
        }
        private void cbSportTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilteringStadiumsDataView();
            EnableBackButton(false);
            EnableNextButton(true);
            ShowStadium(false);
        }
        private TargetStadiumEventArgs GetTargetStadiumOject(int stadiumIndex)
        {
            (DataRowView StadiumsRow, List<string> List_StadiumsImages) targetStadium = ClsStadium.IterateThrowStadiums(_Stadiums, stadiumIndex);

            return new TargetStadiumEventArgs(targetStadium.StadiumsRow, targetStadium.List_StadiumsImages);
        }
        private void btnBookStadium_Click(object sender, EventArgs e)
        {
            if(OnBookingNowButtonClicked != null)
            {
                int Index = _StadiumIndex;
                BookingNowButtonClicked(GetTargetStadiumOject(Index));
            }
        }
        private void btnReserveNow_Click(object sender, EventArgs e)
        {
            if(OnReserveNowButtonClicked != null)
            {
                int Index = _StadiumIndex;
                ReserveNowButtonClicked(GetCurrentStadiumID());
            }
        }













        private int GetCurrentStadiumID()
        {
            return Convert.ToInt32(_Stadiums.Stadiums[_StadiumIndex].Row["StadiumID"]);
        }
        private void FilteringStadiumsDataView()
        {

            _Stadiums.Stadiums.RowFilter = $"SportType = '{cbSportTypes.SelectedItem}'";

            //resorting stadium by stadium id
            _Stadiums.Stadiums.Sort = "StadiumID";

            _StadiumIndex = 0;

        }
        private void ShowNextStadium()
        {
            ShowStadium(true);
        }
        private void EnableBackButton(bool status)
        {
            this.btnBack.Enabled = status;
        }
        private void EnableNextButton(bool status)
        {
            this.btnNext.Enabled = status;
        }
        private void ShowPreviousStadium()
        {
            if(_StadiumIndex > 0)
            {
                _StadiumIndex--;
                ShowStadium(false);

                if(_StadiumIndex <= 0)
                {
                    EnableBackButton(false);

                    EnableNextButton(true);
                }
            }

        }
        public void Execute((DataView Stadiums, DataView StadiumsImages) Stadiums)
        {
            if(!GetAllStadiumsFromDataBase(Stadiums))
            {
                ExecuteOnLoadingFailedEvent();
                ShowInformationMessage("No Stadiums Available To show", "Empty");
                return;
            }

            LoadAvailableSportTypes();
            //ShowStadium();
        }
        private void ExecuteOnLoadingFailedEvent()
        {
            if(OnLoadingFailed != null)
            {
                LoadingFailed();
            }
        }
        private void LoadAvailableSportTypes()
        {
            HashSet<string> SportTypesNames = ClsSportType.GetAvailableSportTypes();

            while(SportTypesNames.Count > 0)
            {
                string SportType = SportTypesNames.Last();

                cbSportTypes.Items.Add(SportType);

                SportTypesNames.Remove(SportType);
            }

            if(cbSportTypes.Items.Contains("Football"))
            {
                cbSportTypes.SelectedItem = "Football";
            }

        }
        private void IncreasStadiumIndexAfterCallTheNextStadium()
        {
            _StadiumIndex++;
            if(_StadiumIndex == _Stadiums.Stadiums.Count - 1)
            {
                EnableNextButton(false);
                EnableBackButton(true);
            }
        }
        private void ShowStadium(bool IncreaseStadiumIndex)
        {
            (DataRowView RowsStadiumsRow, List<string> List_StadiumsImages) Stadium = (null, null);

            if(IncreaseStadiumIndex)
                IncreasStadiumIndexAfterCallTheNextStadium();

            Stadium = ClsStadium.IterateThrowStadiums(_Stadiums, _StadiumIndex);

            if(Stadium != (null, null))
            {
                uC_ShowStadiumCard1.PassStadiumforDisplay(Stadium);
                EnableChoosingButtonsByStadiumAvailability(Stadium.RowsStadiumsRow);
            }
            else
            {
                EnableNextButton(false);
                EnableBackButton(false);
                uC_ShowStadiumCard1.ResetAllControls();
                ShowInformationMessage($"There is no {cbSportTypes.SelectedItem} stadiums To Show it !", "Not Available");
            }


        }
        private void EnableChoosingButtonsByStadiumAvailability(DataRowView RowsStadiumsRow)
        {
            btnBookNow.Enabled = CheckIfAvailableStadium(RowsStadiumsRow);
            btnReserveNow.Enabled = btnBookNow.Enabled;
        }
        private bool CheckIfAvailableStadium(DataRowView RowsStadiumsRow)
        {
            return Convert.ToBoolean(RowsStadiumsRow["Available"]);
        }
        private void ShowInformationMessage(string Errormessage, string ErrorTitle)
        {
            MessageBox.Show(Errormessage, ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool GetAllStadiumsFromDataBase((DataView Stadiums, DataView StadiumsImages) Stadiums)
        {
            _Stadiums = Stadiums;

            if(_Stadiums.Stadiums == null)
                return false;
            else
                return true;
        }
        public void ChangeTitle(string Title)
        {
            lblTittle.Text = Title;
            lblTittle.Left = Cls_UI_Utility.CenterLabel(lblTittle.Width, gbTitle.Width);
        }
    }
}
