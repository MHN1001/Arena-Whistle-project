using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Whistle_Data_Access_Layer
{
    public static class ClsStadiumReservationDA
    {


        public static int AddReservation(int StadiumID, int ClientID, int? ByUserID)
        {
            int newReservationId = 0;

            try
            {
                using(SqlConnection conn = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand cmd = new SqlCommand("Sp_AddReservation", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        // Input parameters
                        cmd.Parameters.AddWithValue("@StadiumID", StadiumID);
                        cmd.Parameters.AddWithValue("@ClientID", ClientID);

                        // Output parameter
                        SqlParameter outputIdParam = new SqlParameter("@NewReservationID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputIdParam);

                        conn.Open();

                        if(ByUserID != null)
                            ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(ByUserID, conn);

                        cmd.ExecuteNonQuery();

                        newReservationId = Convert.ToInt32(outputIdParam.Value);
                    }
                }
            }
            catch(SqlException ex)
            {
                // Log SQL-specific errors
                // Optionally rethrow or return a special value (like -1)
                /*                throw;
                */
            }
            catch(Exception ex)
            {
                // Log general errors
                /*                throw;
                */
            }

            return newReservationId;
        }
        public static bool CancelReservation(int ReservationID, int ByUserID)
        {

            int rowsAffected = 0;

            try
            {
                using(SqlConnection conn = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand cmd = new SqlCommand("Sp_CancelReservation", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Input parameter
                        cmd.Parameters.AddWithValue("@ReservationID", ReservationID);

                        conn.Open();


                        ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(ByUserID, conn);


                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(SqlException ex)
            {
                //throw; // Or return false instead of throwing
            }
            catch(Exception ex)
            {
                /*throw;*/ // Or return false
            }

            return rowsAffected > 0;
        }



        public static bool GetReservationByID(int reservationID,
            ref int stadiumID,
            ref int clientID,
            ref DateTime reservationDate,
            ref byte reservationStatus)
        {
            bool isFound = false;

            using(SqlConnection conn = new SqlConnection(ClsSettingDA.ConnectionString))
            {
                using(SqlCommand cmd = new SqlCommand("sp_GetStadiumReservationByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);

                    conn.Open();
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            isFound = true;
                            stadiumID = (int)reader["StadiumID"];
                            clientID = (int)reader["ClientID"];
                            reservationDate = (DateTime)reader["ReservationDate"];
                            reservationStatus = (byte)reader["ReservationStatus"];
                        }
                    }
                }
            }

            return isFound;
        }



        public static DataView GetStadiumReservationTableForClient()
        {

            DataTable dtReservations = new DataTable();

            try
            {
                using(SqlConnection conn = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand cmd = new SqlCommand("SP_GetReservationsTableForClient", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();

                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dtReservations.Load(reader);
                        }
                    }
                }
            }
            catch(SqlException ex)
            {

            }
            catch(Exception ex)
            {

            }

            return dtReservations.DefaultView;
        }
        public static DataView GetStadiumReservationTableForAdmin()
        {
            DataTable dtReservations = new DataTable();

            try
            {
                using(SqlConnection conn = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand cmd = new SqlCommand("SP_GetReservationsTableForAdmin", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();

                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dtReservations.Load(reader);
                        }
                    }
                }
            }
            catch(SqlException ex)
            {

            }
            catch(Exception ex)
            {

            }

            return dtReservations.DefaultView;
        }
    }
}
