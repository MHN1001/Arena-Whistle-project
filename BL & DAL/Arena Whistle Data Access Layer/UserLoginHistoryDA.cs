using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arena_Whistle_Data_Access_Layer
{
    public static class ClsUserLoginHistoryDA
    {
        public static DataView GetUsersLoginHistoryDataView()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection conn = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    conn.Open();

                    using(SqlCommand cmd = new SqlCommand("SP_GetUsersLoginHistory", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);  // Fill DataTable directly from SP
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

            // Return as DataView for binding or filtering
            return dt.DefaultView;
        }

    }
}
