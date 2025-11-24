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
    public static class ClsPaymentCardTypeDA
    {
        public static Dictionary<int, string> GetPaymentCardTypes()
        {
            Dictionary<int, string> cardTypes = new Dictionary<int, string>();

            try
            {
                using(SqlConnection conn = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    conn.Open(); // synchronous open

                    using(SqlCommand cmd = new SqlCommand("SP_GetPaymentCardTypes", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using(SqlDataReader reader = cmd.ExecuteReader()) // synchronous
                        {
                            while(reader.Read())
                            {
                                int id = Convert.ToInt32(reader["CardTypeID"]);
                                string name = reader["CardType"].ToString();

                                cardTypes[id] = name;
                            }
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

            return cardTypes;
        }

    }
}
