using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Whistle_Data_Access_Layer
{
    public static class ClsStadiumFloorTypeDA
    {
        public static HashSet<string> GetAvailableStadiumFloors()
        {
            HashSet<string> floorTypes = new HashSet<string>();

            try
            {
                using(SqlConnection conn = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand cmd = new SqlCommand("SP_GetAvailableStadiumFloors", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                if(!( reader["FloorType"] is DBNull ))
                                {
                                    floorTypes.Add(reader["FloorType"].ToString());
                                }
                            }
                        }
                    }
                }
            }
            catch(SqlException sqlEx)
            {
                // Handle SQL-related exceptions (e.g., bad SP, connection issues)
            }
            catch(Exception ex)
            {
                // Handle any other unexpected errors

            }

            return floorTypes;

        }
    }
}

