using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Whistle_Data_Access_Layer
{
    public static class PermessionDA
    {
        public static Dictionary<byte, (string PermissionName, int PermissionValue)> GetPermissions()
        {
            var permissions = new Dictionary<byte, (string, int)>();
            byte index = 0;

            using(SqlConnection conn = new SqlConnection(ClsSettingDA.ConnectionString))
            using(SqlCommand cmd = new SqlCommand("Sp_GetPermissionsForUser", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        string name = reader.GetString(0);
                        int value = reader.GetInt32(1);

                        // Add to dictionary with index as key
                        permissions.Add(index, (name, value));
                        index++;
                    }
                }
            }

            return permissions;
        }
    }
}
