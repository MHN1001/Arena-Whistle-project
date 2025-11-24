using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Whistle_Data_Access_Layer
{
    public static class ClsStadiumImageDA
    {
        public static List<string> GetAllStadiumImages(int StadiumID)
        {
            var stadiumImages = new List<string>();

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_GetStadiumImages", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameter for StadiumID
                        command.Parameters.AddWithValue("@StadiumID", StadiumID);

                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                stadiumImages.Add(reader["StadiumImagePath"].ToString());
                            }
                        }
                    }
                }
            }
            catch(SqlException ex)
            {
                // Handle exception (log or rethrow)
            }

            return stadiumImages;
        }
        public static int AddingStadiumImageByStadiumID(string StadiumImagePath, int StadiumID, int ByUserID)
        {
            int NewStadiumImageID = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_AddNewStadium", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;



                        command.Parameters.AddWithValue("@StadiumImagePath", StadiumImagePath);
                        command.Parameters.AddWithValue("@StadiumID", StadiumID);


                        command.Parameters.Add(new SqlParameter("@NewStadiumImageID", SqlDbType.Int) { Direction = ParameterDirection.Output });

                        connection.Open();

                        ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(ByUserID, connection);

                        command.ExecuteNonQuery();

                        NewStadiumImageID = Convert.ToInt32(command.Parameters["@NewStadiumImageID"].Value);
                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return NewStadiumImageID;
        }
        public static bool UpdateStadiumImage(int StadiumImageID, string NewImagePath, int ByUserID)
        {
            int EffectedRows = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_UpdateStadiumImagePath", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        command.Parameters.AddWithValue("@StadiumImageID", StadiumImageID);
                        command.Parameters.AddWithValue("@StadiumImagePath", NewImagePath);


                        connection.Open();

                        ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(ByUserID, connection);


                        EffectedRows = command.ExecuteNonQuery();

                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return EffectedRows > 0;
        }
        public static bool DeleteImage(int StadiumImageID, int ByUserID)
        {
            byte EffectedRows = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_DeleteStadiumImage", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;



                        command.Parameters.AddWithValue("@StadiumImageID", StadiumImageID);


                        connection.Open();

                        ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(ByUserID, connection);


                        EffectedRows = Convert.ToByte(command.ExecuteNonQuery());

                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return ( EffectedRows > 0 );
        }
    }
}
