using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Whistle_Data_Access_Layer
{
    public static class DefaultPricesDA
    {
        public static Dictionary<string, decimal> GetDefaultPrices()
        {
            var DefaultPrices = new Dictionary<string, decimal>();

            using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
            using(SqlCommand command = new SqlCommand("dbo.Sp_DefaultPrices", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            DefaultPrices["DefaultPricePerBall"] = reader.GetDecimal(reader.GetOrdinal("DefaultPricePerBall"));
                            DefaultPrices["DefaultShowerPrice"] = reader.GetDecimal(reader.GetOrdinal("DefaultShowerPrice"));
                            DefaultPrices["DefaultPriceClothingPerOnePlayer"] = reader.GetDecimal(reader.GetOrdinal("DefaultPriceClothingPerOnePlayer"));
                            DefaultPrices["DefaultRefereePrice"] = reader.GetDecimal(reader.GetOrdinal("DefaultRefereePrice"));
                        }
                    }
                }
                catch(Exception ex)
                {
                    //throw new Exception("Error fetching default DefaultPrices: " + ex.Message, ex);
                }
            }

            return DefaultPrices;
        }
    }
}

