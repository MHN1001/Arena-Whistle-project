using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arena_Whistle_Data_Access_Layer;

namespace Arena_Whistle_Buisness_layer
{
    public class ClsStadiumReservation
    {

        public enum EnReservationStatus { Pending = 1, Served = 2, Cancelled = 3 }


        private int ReservationID { get; set; }
        public int StadiumID { get; set; }
        public int ClientID { get; set; }
        private DateTime ReservationDate { get; }
        public EnReservationStatus Status { get; }



        public ClsStadiumReservation()
        {
            this.ReservationID = 0;
            this.StadiumID = 0;
            this.ClientID = 0;
            this.ReservationDate = new DateTime();
            this.Status = EnReservationStatus.Pending;
        }
        private ClsStadiumReservation(
            int reservationID,
            int stadiumID,
            int clientID,
            DateTime reservationDate,
            EnReservationStatus status)
        {
            ReservationID = reservationID;
            StadiumID = stadiumID;
            ClientID = clientID;
            ReservationDate = reservationDate;
            Status = status;
        }



        public static ClsStadiumReservation Find(int reservationID)
        {
            int stadiumID = 0;
            int clientID = 0;
            DateTime reservationDate = DateTime.MinValue;
            byte reservationStatus = 0;

            bool isFound = ClsStadiumReservationDA.GetReservationByID(
                                                                      reservationID,
                                                                      ref stadiumID,
                                                                      ref clientID,
                                                                      ref reservationDate,
                                                                      ref reservationStatus);

            if(isFound)
            {
                // cast the tinyint to enum safely
                EnReservationStatus status = (EnReservationStatus)reservationStatus;

                return new ClsStadiumReservation(
                    reservationID,
                    stadiumID,
                    clientID,
                    reservationDate,
                    status);
            }

            return null;
        }
        

        public bool AddStadiumReservation(int? ByUserID)
        {
            this.ReservationID = ClsStadiumReservationDA.AddReservation(this.StadiumID, this.ClientID, ByUserID);

            return ( this.ReservationID > 0 );

        }

        public static bool CancelReservation(int reservationID  , int ByUserID)
        {
            return ClsStadiumReservationDA.CancelReservation(reservationID, ByUserID);
        }



        public static DataView GetStadiumReservationTableForClient()
        {
            return ClsStadiumReservationDA.GetStadiumReservationTableForClient();
        }
        public static DataView GetStadiumReservationTableForAdmin()
        {
            return ClsStadiumReservationDA.GetStadiumReservationTableForAdmin();
        }

    }
}
