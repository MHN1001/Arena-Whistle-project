using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Whistle_Data_Access_Layer
{
    public class ClsCountryDA
    {
        public static HashSet<string> GetContriesTable()
        {
            HashSet<string> countries = new HashSet<string>();

            try
            {
                using(SqlConnection conn = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    conn.Open();

                    using(SqlCommand cmd = new SqlCommand("Sp_GetCountriesNames", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                countries.Add(reader["CountryName"].ToString());
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

            return countries;
        }

        public  static async Task<HashSet<string>> GetContriesTableAsync()
        {
            HashSet<string> countries = new HashSet<string>();

            try
            {
                using(SqlConnection conn = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    conn.OpenAsync();

                    using(SqlCommand cmd = new SqlCommand("Sp_GetCountriesNames", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using(SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            while(await reader.ReadAsync())
                            {
                                countries.Add(reader["CountryName"].ToString());
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

            return countries;
        }

    }
}
