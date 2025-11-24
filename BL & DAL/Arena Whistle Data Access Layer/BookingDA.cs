using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Whistle_Data_Access_Layer
{


    public static class BookingDA
    {
        public static bool FindStadiumBooking(
            int stadiumBookingID,
            out int ClientID,
            out int stadiumID,
            out byte numberOfPlayers,
            out byte numberOfBalls,
            out DateTime bookingDate,
            out DateTime MatchDate,
            out TimeSpan startTime,
            out TimeSpan endTime,
            out bool shower,
            out bool clothing,
            out bool referee,
            out decimal totalPrice,
            out int paymentID)
        {
            // Initialize defaults
            ClientID = 0;
            stadiumID = 0;
            numberOfPlayers = 0;
            numberOfBalls = 0;
            bookingDate = default;
            MatchDate = default;
            startTime = default;
            endTime = default;
            shower = false;
            clothing = false;
            referee = false;
            totalPrice = 0;
            paymentID = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                using(SqlCommand cmd = new SqlCommand("Sp_GetStadiumBookingById", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Input
                    cmd.Parameters.AddWithValue("@StadiumBookingID", stadiumBookingID);

                    // Outputs
                    cmd.Parameters.Add("@ClientID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@StadiumID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@NumberOfPlayers", SqlDbType.TinyInt).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@NumberOfBalls", SqlDbType.TinyInt).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@BookingDate", SqlDbType.Date).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@MatchDate", SqlDbType.Date).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@StartTime", SqlDbType.Time).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@EndTime", SqlDbType.Time).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Shower", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Clothing", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Referee", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@TotalPrice", SqlDbType.SmallMoney).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@PaymentID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@IsFound", SqlDbType.Bit).Direction = ParameterDirection.Output;

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    // Check if found
                    bool isFound = cmd.Parameters["@IsFound"].Value != DBNull.Value && (bool)cmd.Parameters["@IsFound"].Value;
                    if(!isFound)
                    {
                        return false; // Booking not found
                    }

                    // Fill outputs
                    ClientID = Convert.ToInt32(cmd.Parameters["@ClientID"].Value);
                    stadiumID = Convert.ToInt32(cmd.Parameters["@StadiumID"].Value);
                    numberOfPlayers = Convert.ToByte(cmd.Parameters["@NumberOfPlayers"].Value);
                    numberOfBalls = Convert.ToByte(cmd.Parameters["@NumberOfBalls"].Value);
                    bookingDate = Convert.ToDateTime(cmd.Parameters["@BookingDate"].Value);
                    MatchDate = Convert.ToDateTime(cmd.Parameters["@MatchDate"].Value);
                    startTime = (TimeSpan)cmd.Parameters["@StartTime"].Value;
                    endTime = (TimeSpan)cmd.Parameters["@EndTime"].Value;
                    shower = Convert.ToBoolean(cmd.Parameters["@Shower"].Value);
                    clothing = Convert.ToBoolean(cmd.Parameters["@Clothing"].Value);
                    referee = Convert.ToBoolean(cmd.Parameters["@Referee"].Value);
                    totalPrice = Convert.ToDecimal(cmd.Parameters["@TotalPrice"].Value);
                    paymentID = VAlidationDA.checkOutputParameterIfNull<int>(cmd.Parameters["@PaymentID"]);

                    return true;
                }
            }
            catch(SqlException ex)
            {

            }

            return false;
        }
        public static (int BookingID, int PaymentID) AddingStadiumBooking(int ClientID, int stadiumID, byte numberOfPlayers
                                      , byte numberOFBalls, DateTime MatchDate,
                                       TimeSpan StartTime, TimeSpan EndTime
                                      , bool shower, bool clothing, bool refree, decimal totalPrice, byte PaymentMethodeID,

                                       int? UserID)
        {
            int newBookingID = 0;
            int PaymentID = 0;

            try
            {
                using(SqlConnection conn = new SqlConnection(ClsSettingDA.ConnectionString))
                {


                    using(SqlCommand cmd = new SqlCommand("Sp_AddStadiumBooking", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        // Input parameters
                        cmd.Parameters.AddWithValue("@ClientID", ClientID);
                        cmd.Parameters.AddWithValue("@BookingStadiumID", stadiumID);
                        cmd.Parameters.AddWithValue("@NumberOfPlayers", numberOfPlayers);
                        cmd.Parameters.AddWithValue("@NumberOfBalls", numberOFBalls);
                        cmd.Parameters.AddWithValue("@BookingMatchDate", MatchDate);
                        cmd.Parameters.AddWithValue("@StartTime", StartTime);
                        cmd.Parameters.AddWithValue("@EndTime", EndTime);
                        cmd.Parameters.AddWithValue("@Shower", shower);
                        cmd.Parameters.AddWithValue("@Clothing", clothing);
                        cmd.Parameters.AddWithValue("@Referee", refree);
                        cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                        cmd.Parameters.AddWithValue("@PaymentMethodID", PaymentMethodeID);

                        cmd.Parameters.Add(new SqlParameter("@NewStadiumBookingID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        });
                        cmd.Parameters.Add(new SqlParameter("@PaymentID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        });

                        conn.Open();

                        if(UserID != null)
                            ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(UserID, conn);


                        cmd.ExecuteNonQuery();

                        // Retrieve the new booking ID
                        newBookingID = Convert.ToInt32(cmd.Parameters["@NewStadiumBookingID"].Value);
                        PaymentID = Convert.ToInt32(cmd.Parameters["@PaymentID"].Value);
                    }
                }
            }
            catch(Exception ex)
            {
                // Optionally handle/log the exception
                //throw new Exception("Error adding stadium booking.", ex);
            }

            return (newBookingID, PaymentID);
        }


        //public static bool UpdatePersonInfo(int StadiumBookingID, int ClientID, int stadiumID, byte numberOfPlayers
        //                              , byte numberOFBalls, DateTime bookingDate, DateTime MatchDate, TimeSpan StartTime, TimeSpan EndTime
        //                              , bool shower, bool clothing, bool referee, decimal totalPrice,

        //                               int UserID)
        //{
        //    int rowsAffected = 0;

        //    try
        //    {
        //        using(SqlConnection conn = new SqlConnection(ClsSettingDA.ConnectionString))
        //        {

        //            using(SqlCommand cmd = new SqlCommand("Sp_UpdateStadiumBooking", conn))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.CommandText = "EXEC sp_set_session_context @key = N'ByUserID', @value = @ByUserID";
        //                cmd.Parameters.AddWithValue("@ByUserID", UserID);

        //                // Add input parameters
        //                cmd.Parameters.AddWithValue("@StadiumBookingID", StadiumBookingID);
        //                cmd.Parameters.AddWithValue("@ClientID", ClientID);
        //                cmd.Parameters.AddWithValue("@StadiumID", stadiumID);
        //                cmd.Parameters.AddWithValue("@NumberOfPlayers", numberOfPlayers);
        //                cmd.Parameters.AddWithValue("@NumberOfBalls", numberOFBalls);
        //                cmd.Parameters.AddWithValue("@BookingDate", bookingDate);
        //                cmd.Parameters.AddWithValue("@PlayingDate", MatchDate);
        //                cmd.Parameters.AddWithValue("@StartTime", StartTime);
        //                cmd.Parameters.AddWithValue("@EndTime", EndTime);
        //                cmd.Parameters.AddWithValue("@Shower", shower);
        //                cmd.Parameters.AddWithValue("@Clothing", clothing);
        //                cmd.Parameters.AddWithValue("@Referee", referee);
        //                cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);

        //                conn.Open();
        //                rowsAffected = cmd.ExecuteNonQuery();

        //            }
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        // Optionally log or handle the exception
        //        //throw new Exception("Error updating stadium booking.", ex);
        //    }

        //    return rowsAffected > 0;
        //}


        public static bool DeleteStadiumBooking(int StadiumBookingID, int UserID)
        {
            byte EffectedRows = 0;

            try
            {
                using(SqlConnection conn = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand cmd = new SqlCommand("Sp_DeleteStadiumBooking", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;



                        // Input parameter
                        cmd.Parameters.AddWithValue("@StadiumBookingID", StadiumBookingID);

                        conn.Open();


                        ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(UserID, conn);


                        // Execute delete
                        EffectedRows = (byte)cmd.ExecuteNonQuery();

                    }
                }
            }
            catch(Exception ex)
            {
                // Optionally handle/log the exception
                //throw new Exception("Error deleting stadium booking.", ex);
            }
            return EffectedRows > 0;
        }


        public static DataView GetSBookingTableForClient()
        {
            DataTable datatable = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_GetBookingsTableForClient", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        connection.Open();
                        SqlDataReader dataReader = command.ExecuteReader();

                        if(dataReader.HasRows)
                        {
                            datatable.Load(dataReader);
                        }
                        else
                            return null;
                    }
                }
            }
            catch(SqlException ex)
            {
                //
                //
                //

            }

            return datatable.DefaultView;
        }


        public static DataView GetSBookingTableForAdmin()
        {
            DataTable datatable = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_GetBookingsTableForAdmin", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        connection.Open();
                        SqlDataReader dataReader = command.ExecuteReader();

                        if(dataReader.HasRows)
                        {
                            datatable.Load(dataReader);
                        }
                        else
                            return null;
                    }
                }
            }
            catch(SqlException ex)
            {
                //
                //
                //

            }

            return datatable.DefaultView;
        }

        public static DataView GetStadiumBookingDatesTable()
        {
            DataTable datatable = new DataTable();
            DataView StadiumBookingDataView = new DataView();


            SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString);

            string query = @"select 
                             [Stadium Name] = (select StadiumName 
                                               from Stadiums 
                             				  where Stadiums.StadiumID = StadiumBooking.StaduimID),
                             BookingDate,
                             PlayingDate,
                             StartTime,
                             EndTime
                             from StadiumBooking
                             where BookingDate  >= cast (getdate() as date)";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    datatable.Load(reader);
                    StadiumBookingDataView = datatable.DefaultView;
                }

                reader.Close();
            }

            catch(Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return StadiumBookingDataView;
        }
    }
}

