using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Whistle_Data_Access_Layer
{
    public static class ClsSportTypeDA
    {
        public static HashSet<string> GetAvailableSportTypes()
        {
            HashSet<string> sportTypes = new HashSet<string>();

            using(SqlConnection conn = new SqlConnection(ClsSettingDA.ConnectionString))
            {
                using(SqlCommand cmd = new SqlCommand("SP_GetAvailableSportTypes", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            // Assuming SportType column is a string (nvarchar/varchar)
                            sportTypes.Add(reader["SportType"].ToString());
                        }
                    }
                }
            }

            return sportTypes;
        }

    }
}
