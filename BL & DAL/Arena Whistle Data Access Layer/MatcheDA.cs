using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Arena_Whistle_Data_Access_Layer
{
    public static class ClsMatchesDA
    {
        public static DataView GetCurrentMatchesListForAdmin()
        {
            DataTable dt = new DataTable();

            using(SqlConnection conn = new SqlConnection(ClsSettingDA.ConnectionString))
            {
                conn.Open();   // ← OPEN CONNECTION HERE

                using(SqlCommand cmd = new SqlCommand("SP_GetCurrentMatchesListForAdmin", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt.DefaultView;
        }
        public static DataView GetAllMatchesTableForAdmin()
        {
            DataTable datatable = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_GetMatchesListForAdmin", connection))
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
        public static DataView GetCurrentMatchesTableForClient()
        {
            DataTable datatable = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_GetCurrentMatchesTableForClient", connection))
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
    }
}
