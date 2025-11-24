using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arena_Whistle_Data_Access_Layer;
using static Arena_Whistle_Buisness_layerm.ClsPerson;

namespace Arena_Whistle_Buisness_layer
{
    public class ClsBooking
    {
        public int StadiumBookingID { get; set; }
        public int ResponsiblePlayerID { get; set; }
        public int StaduimID { get; set; }
        public byte NumberOfPlayers { get; set; }
        public byte NumberOFBalls { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime MatchDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool Shower { get; set; }
        public bool Clothing { get; set; }
        public bool Refree { get; set; }
        public decimal TotalPrice { get; set; }
        public int? PaymentID { get; set; }


        public DataView BookingList;


        //public enum _enMode { add, update }
        //public _enMode Mode;

        public ClsBooking()
        {
            this.StadiumBookingID = 0;
            this.ResponsiblePlayerID = 0;
            this.StaduimID = 0;
            this.NumberOfPlayers = 0;
            this.NumberOFBalls = 0;
            this.BookingDate = new DateTime();
            this.MatchDate = new DateTime();
            this.StartTime = new TimeSpan();
            this.EndTime = new TimeSpan();
            this.Shower = false;
            this.Clothing = false;
            this.Refree = false;
            this.TotalPrice = 0;
            this.PaymentID = null;


            //Mode = _enMode.add;
        }


        private ClsBooking(int bookingID, int ClientID, int staduimID, byte numberOfPlayers
                                 , byte numberOFBalls, DateTime bookingDate, DateTime MatchDate, TimeSpan StartTime, TimeSpan EndTime
                                 , bool shower, bool clothing, bool refree, decimal totalPrice, int? paymentID)
        {
            StadiumBookingID = bookingID;
            ResponsiblePlayerID = ClientID;
            StaduimID = staduimID;
            NumberOfPlayers = numberOfPlayers;
            NumberOFBalls = numberOFBalls;
            BookingDate = bookingDate;
            this.MatchDate = MatchDate;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            Shower = shower;
            Clothing = clothing;
            Refree = refree;
            TotalPrice = totalPrice;
            PaymentID = paymentID;


            //Mode = _enMode.update;
        }

        public static ClsBooking FindStadiumBooking(int StadiumBookingID)
        {
            if(BookingDA.FindStadiumBooking(StadiumBookingID,
                                             out int responsiblePlayerID, out int stadiumID, out byte numberOfPlayers,
                                             out byte numberOfBalls, out DateTime bookingDate, out DateTime MatchDate,
                                             out TimeSpan startTime, out TimeSpan EndTime,
                                             out bool shower, out bool clothing, out bool referee,
                                             out decimal totalPrice, out int paymentID))
            {

                return new ClsBooking(StadiumBookingID, responsiblePlayerID, stadiumID, numberOfPlayers
                                                     , numberOfBalls, bookingDate, MatchDate, startTime, EndTime
                                                     , shower, clothing, referee, totalPrice, paymentID);

            }
            return null;
        }

        //add match oparetion inside add / delete sp
        public bool _AddStadiumBooking( byte PaymentMethodeID , int? ByUserID = null)
        {
            int PaymentID  = 0;

            (this.StadiumBookingID , PaymentID ) = BookingDA.AddingStadiumBooking(this.ResponsiblePlayerID, this.StaduimID, this.NumberOfPlayers
                                                     , this.NumberOFBalls,  this.MatchDate, this.StartTime, this.EndTime
                                                     , this.Shower, this.Clothing, this.Refree, this.TotalPrice, PaymentMethodeID , ByUserID);
           
            if(this.StadiumBookingID > 0)
            {
                this.PaymentID = PaymentID;
                return true;
            }

            return false;

        }
       
        //private bool _UpdateStadiumBooking(int ByUserID)
        //{
        //    return BookingDA.UpdatePersonInfo(this.StadiumBookingID, this.ResponsiblePlayerID, this.StaduimID, this.NumberOfPlayers
        //                                             , this.NumberOFBalls, this.BookingDate, this.MatchDate, this.StartTime, this.EndTime
        //                                             , this.Shower, this.Clothing, this.Refree, this.TotalPrice,  ByUserID);
        //}
        public static bool DeleteStadiumBooking(int StadiumBookingID, int ByUserID)
        {
            return BookingDA.DeleteStadiumBooking(StadiumBookingID, ByUserID);
        }
     
        public static DataView GetSBookingTableForClient()
        {
            return BookingDA.GetSBookingTableForClient();

        }
        public static DataView GetSBookingTableForAdmin()
        {
            return BookingDA.GetSBookingTableForAdmin();
        }
        
        //Function will return all bookings with the same input date
        public static DataView GetBookingDatesListByBookingDate(DataView Dv, DateTime BookingDate)
        {
            Dv.RowFilter = $"PlayingDate = #{BookingDate: yyyy-MM-dd}#";

            return Dv;
        }
        
        private DataView _GetAllMatchesPeriodsListByMatchDate(DataView Dv, DateTime MatchDate)
        {
            Dv.RowFilter = $"MatchDate = #{MatchDate: yyyy-MM-dd}#";


            return Dv.ToTable(true, "StartTime", "EndTime").DefaultView;
        }

        //Return true if input date exist
        private bool _IsMatchDateExistInBookingList(DataView DV, DateTime MatchDate)
        {
            return DV.ToTable().AsEnumerable().Any(Row => Row.Field<DateTime>("MatchDate").Date == MatchDate.Date);
        }

        //If returned false that means there is a over lap between periods
        public bool CheckifMatchgDateTimeHasNoOverLapWithDataBaseBookings(DataView DV)
        {
            if(_IsMatchDateExistInBookingList(DV, this.MatchDate))
            {
                DataView MatchesPeriods_Dv = this._GetAllMatchesPeriodsListByMatchDate(DV, this.MatchDate);

                foreach(DataRowView PeriodRow in MatchesPeriods_Dv)
                {
                    if(( this.StartTime < (TimeSpan)PeriodRow["EndTime"] && this.EndTime > (TimeSpan)PeriodRow["StartTime"] ))
                    { 
                        return false;
                    }
                }
                return true;
            }
            return true;
        }
    }
}
