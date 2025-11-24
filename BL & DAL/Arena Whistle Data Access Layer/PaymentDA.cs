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
    public static class ClsPaymentMethodDA
    {
        public static Dictionary<string, int> GetPaymentMethods()
        {
            Dictionary<string, int> paymentMethods = new Dictionary<string, int>();

            try
            {
                using(SqlConnection conn = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    conn.Open();

                    using(SqlCommand cmd = new SqlCommand("Sp_GetPaymentMethods", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                int id = Convert.ToInt32(reader["PaymentMethodID"]);
                                string name = reader["MethodName"].ToString(); // note typo in column name

                                paymentMethods[name] = id;
                            }
                        }
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }

            return paymentMethods;
        }


        public static string GetPaymentMethodNameByID(int paymentMethodID)
        {
            string methodName = null;

            using(SqlConnection conn = new SqlConnection(ClsSettingDA.ConnectionString))
            {
                using(SqlCommand cmd = new SqlCommand("sp_GetPaymentMethodNameByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PaymentMethodID", paymentMethodID);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if(result != null && result != DBNull.Value)
                    {
                        methodName = result.ToString();
                    }
                }
            }

            return methodName;
        }
    }
}
