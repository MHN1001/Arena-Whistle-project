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
using ControlLibrary.Helpers;
using ShowAllStadiums_ControlLibrary.Global_Util_Class;

namespace ShowAllStadiums_ControlLibrary.Stadiums
{
    public partial class UC_BookingStadiumProcess : UserControl
    {
        public UC_BookingStadiumProcess()
        {
            InitializeComponent();
        }


        public event Action OnBookinButtonClicked;
        protected virtual void BookinButtonClicked()
        {
            Action Handler = OnBookinButtonClicked;

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


        public event Action OnAddedSucessfully;
        protected virtual void AddedSucessfully()
        {
            Action Handler = OnAddedSucessfully;

            if(Handler != null)
            {
                Handler();
            }
        }



        public class Variables
        {
            public ClsBooking BookingObj;

            public (DataRowView RowsStadiumsRow, List<string> List_StadiumImages) Stadium;

            public Dictionary<string, int> PaymentMethods;

            public decimal CurrentBookingPrice;

            public int? AvailableRefereeID;

            public double chosenMinutes;

            public bool IsValideDateTime;

            public DataView BookingTable;

            public int? ByUserID = null;


        }
        public Variables LocalVb = new Variables();






        private void UC_BookingStadiumProcess_Load(object sender, EventArgs e)
        {
        }
        private void NUPnumberofplayers_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPriceLabel(CalculateCurrentPrice());
        }
        private void NUPnumberofballs_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPriceLabel(CalculateCurrentPrice());
        }
        private void RbClothing_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPriceLabel(CalculateCurrentPrice());
        }
        private void RbRefree_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPriceLabel(CalculateCurrentPrice());
        }
        private void RbShower_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPriceLabel(CalculateCurrentPrice());
        }
        private void dtpTimePeriod_Validating(object sender, CancelEventArgs e)
        {

        }
        private void dtpStartTime_ValueChanged(object sender, EventArgs e)
        {
            ChangeEndTimeValue();
            UpdateTotalPriceLabel(CalculateCurrentPrice());
        }
        private void dtpEndTime_ValueChanged(object sender, EventArgs e)
        {
            if(IsValidatePeriodPlayTime())
            {
                UpdateTotalPriceLabel(CalculateCurrentPrice());
            }
        }
        private void btnBookNow_Click(object sender, EventArgs e)
        {
            if(OnBookinButtonClicked != null)
            {
                BookinButtonClicked();
            }
            BookingProcess();
        }











        private void IntializeBookingObjectAfterSaving()
        {

            LocalVb.BookingObj.StaduimID = Convert.ToInt32(LocalVb.Stadium.RowsStadiumsRow["StadiumID"]);
            LocalVb.BookingObj.NumberOfPlayers = (byte)NUPnumberofplayers.Value;
            LocalVb.BookingObj.NumberOFBalls = (byte)NUPnumberofballs.Value;
            LocalVb.BookingObj.MatchDate = dtpMatchDate.Value;
            LocalVb.BookingObj.StartTime = ( (DateTime)dtpStartTime.Value ).TimeOfDay;
            LocalVb.BookingObj.EndTime = ( (DateTime)dtpEndTime.Value ).TimeOfDay;
            LocalVb.BookingObj.Clothing = rbClothingYES.Checked ? true : false;
            LocalVb.BookingObj.Refree = rbRefereeYES.Checked ? true : false;
            LocalVb.BookingObj.Shower = rbShowerYES.Checked ? true : false;
            LocalVb.BookingObj.PaymentID = (int)cbPaymentMethod.SelectedValue;
            LocalVb.BookingObj.TotalPrice = LocalVb.CurrentBookingPrice;

        }
        private void ShwoWarningMessage(string message)
        {
            MessageBox.Show(message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private bool CheckIsValideDateTime()
        {
            if(LocalVb.IsValideDateTime)
            {
                if(LocalVb.BookingTable == null)
                    return true;


                LocalVb.BookingObj.MatchDate = dtpMatchDate.Value;
                LocalVb.BookingObj.StartTime = ( (DateTime)dtpStartTime.Value ).TimeOfDay;
                LocalVb.BookingObj.EndTime = ( (DateTime)dtpEndTime.Value ).TimeOfDay;


                if(LocalVb.BookingObj.CheckifMatchgDateTimeHasNoOverLapWithDataBaseBookings(LocalVb.BookingTable))
                {
                    return true;
                }
                else
                {
                    ShwoWarningMessage("Please Check Your Date Time");
                }
            }
            else
            {
                ShwoWarningMessage("Please Check Your End Time");
            }
            return false;

        }
        private void CallAddedSucessfullyEvent()
        {
            if(OnAddedSucessfully != null)
            {
                AddedSucessfully();
            }
        }
        private void CallAddedFailedEvent()
        {
            if(OnAddedFailed != null)
            {
                AddedFailed();
            }
        }
        private void EnableBookinButton(bool enable)
        {
            btnBookNow.Enabled = enable;
        }
        private void BookingProcess()
        {
            if(!CheckIsValideDateTime())
                return;

            if(!GlobalMessages.Confirm("Are you Sure You want To Book this Stadium ?")) return;


            IntializeBookingObjectAfterSaving();


            if(LocalVb.BookingObj._AddStadiumBooking(Convert.ToByte(cbPaymentMethod.SelectedValue),LocalVb.ByUserID))
            {
                EnableBookinButton(true);

                MessageBox.Show("Booking Added Sucessfully", "SUCCESSFULLY", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CallAddedSucessfullyEvent();
            }
            else
            {
                MessageBox.Show("Added Failed", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CallAddedFailedEvent();
            }

        }
        private void ChangeEndTimeValue()
        {
            dtpEndTime.MinDate = dtpStartTime.Value.AddHours(1);
            dtpEndTime.Value = dtpEndTime.MinDate;
            ExecuteErrorProvider(dtpEndTime, string.Empty);
        }
        private decimal CalculateCurrentPrice()
        {
            return GetCurrentPrice() + GetAddiditionalPriceOfNumberOfBalls() + GetAddiditionalPriceOfClothing() +
                   GetAddiditionalPriceOfReferee() + GetAddiditionalPriceOfShower()
                   + GetAddiditionalPriceOfPeriodTime();
        }
        private decimal GetCurrentPrice()
        {
            return LocalVb.CurrentBookingPrice;
        }
        private decimal GetAddiditionalPriceOfNumberOfBalls()
        {
            return Convert.ToDecimal(NUPnumberofballs.Tag) * NUPnumberofballs.Value;

        }
        private decimal GetAddiditionalPriceOfClothing()
        {
            if(rbClothingYES.Checked)
            {
                return Convert.ToDecimal(gbClothing.Tag) * NUPnumberofplayers.Value;
            }
            return 0;
        }
        private decimal GetAddiditionalPriceOfReferee()
        {
            if(rbRefereeYES.Checked)
            {
                return Convert.ToDecimal(gbReferee.Tag);
            }
            return 0;
        }
        private decimal GetAddiditionalPriceOfShower()
        {
            if(rbShowerYES.Checked)
            {
                return Convert.ToDecimal(gbShower.Tag);
            }
            return 0;
        }
        private decimal GetAddiditionalPriceOfPeriodTime()
        {
            decimal PricePerMinute = Convert.ToDecimal(LocalVb.Stadium.RowsStadiumsRow["RentalPricePerHour"]) / 60;
            return Convert.ToDecimal(LocalVb.chosenMinutes) * PricePerMinute;
        }
        private double GetMinutesBetween(TimeSpan start, TimeSpan end)
        {
            // Calculate the total difference
            TimeSpan difference = end.Add(TimeSpan.FromSeconds(1)) - start;

            // Return the count (always positive)
            return Math.Round(difference.TotalMinutes, 0);
        }
        private bool IsValidatePeriodPlayTime()
        {
            LocalVb.chosenMinutes = GetMinutesBetween(dtpStartTime.Value.TimeOfDay, dtpEndTime.Value.TimeOfDay);

            if(LocalVb.chosenMinutes >= 60 && LocalVb.chosenMinutes <= 120)
            {
                LocalVb.IsValideDateTime = true;
                ExecuteErrorProvider(dtpEndTime, string.Empty);
                return LocalVb.IsValideDateTime;
            }
            else
            {
                LocalVb.IsValideDateTime = false;
                ExecuteErrorProvider(dtpEndTime, "Available Time Periods Should Be :\n-1 Hour\n-1 Hour and Half\n-2 Hours");
                return LocalVb.IsValideDateTime;

            }
        }
        private void ExecuteErrorProvider(object control, string ErroMessage)
        {
            errorProvider1.SetError((Control)control, ErroMessage);
        }
        public void BindDataToControls((DataRowView RowsStadiumsRow, List<string> List_StadiumImages) Stadium)
        {
            PassStadiumInfo(Stadium);

            IntializeLocalVariablesClass(Stadium);

            PrepareBookingControls();


            UpdateTotalPriceLabel(CalculateCurrentPrice());

        }
        private void SetUpDefaultPricesOnUsersControlTags(Dictionary<string, decimal> DefaultPrices)
        {
            NUPnumberofballs.Tag = DefaultPrices["DefaultPricePerBall"];
            gbClothing.Tag = DefaultPrices["DefaultPriceClothingPerOnePlayer"];
            gbShower.Tag = DefaultPrices["DefaultShowerPrice"];
            gbReferee.Tag = DefaultPrices["DefaultRefereePrice"];

        }
        
        private void PassStadiumInfo((DataRowView RowsStadiumsRow, List<string> List_StadiumImages) Stadium)
        {
            uC_ShowStadiumCard1.PassStadiumforDisplay(Stadium);
        }
        private void UpdateTotalPriceLabel(decimal Price)
        {
            lblTotalPrice.Text = string.Concat("TOTAL PRICE : ", Math.Round(Price, 2), " $");
            lblTotalPrice.Left = Cls_UI_Utility.CenterLabel(lblTotalPrice.Width, gbTotalPrice.Width);
        }
        private void IntializePaymentMethodsComboBox()
        {
            LocalVb.PaymentMethods = ClsPaymentMethod.GetPaymentMethods();

            cbPaymentMethod.DataSource = new BindingSource(LocalVb.PaymentMethods, null);
            cbPaymentMethod.DisplayMember = "Key";
            cbPaymentMethod.ValueMember = "Value";

            if(cbPaymentMethod.Items.Contains("Cash"))
            {
                cbPaymentMethod.SelectedItem = "Cash";
            }

        }
        private void IntializeLocalVariablesClass((DataRowView RowsStadiumsRow, List<string> List_StadiumImages) Stadium)
        {
            LocalVb.BookingObj = new ClsBooking();

            LocalVb.Stadium = Stadium;

            LocalVb.CurrentBookingPrice = Convert.ToDecimal(LocalVb.Stadium.RowsStadiumsRow["RentalPricePerHour"]);

            LocalVb.PaymentMethods = ClsPaymentMethod.GetPaymentMethods();

            LocalVb.chosenMinutes = 0;

            LocalVb.BookingTable = ClsBooking.GetSBookingTableForClient();
            //
            //LocalVb.chosenMinutes = GetMinutesBetween(dtpStartTime.Value.TimeOfDay, dtpEndTime.Value.TimeOfDay);
            LocalVb.chosenMinutes = 59;
        }
        private void CheckRefereeAvailability()
        {
            LocalVb.AvailableRefereeID = ClsRefree.GetAvailableRefreeID();

            if(LocalVb.AvailableRefereeID != null)
            {
                gbReferee.Enabled = true;
            }
            else
            {
                gbReferee.Enabled = false;
            }

        }
        private void PrepareBookingControls()
        {
            NUPnumberofplayers.Minimum = 8;
            NUPnumberofplayers.Value = NUPnumberofplayers.Minimum;
            NUPnumberofplayers.Maximum = 12;
            NUPnumberofballs.Value = 1;
            NUPnumberofballs.Minimum = NUPnumberofballs.Value;
            NUPnumberofballs.Maximum = 3;
            dtpMatchDate.MinDate = DateTime.Now;
            dtpMatchDate.Value = dtpMatchDate.MinDate;
            dtpStartTime.MinDate = DateTime.Now;
            dtpStartTime.Value = dtpStartTime.MinDate;
            rbClothingNO.Checked = true;
            rbRefreeNO.Checked = true;
            CheckRefereeAvailability();
            rbShowerNO.Checked = true;
            IntializePaymentMethodsComboBox();
            UpdateTotalPriceLabel(LocalVb.CurrentBookingPrice);

            Dictionary<string, decimal> DefaultPrices = ClsDefaultPricesB.GetDefaultPrices();
            SetUpDefaultPricesOnUsersControlTags(DefaultPrices);
        }

    }
}
