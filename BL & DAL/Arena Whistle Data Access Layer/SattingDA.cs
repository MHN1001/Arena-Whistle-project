using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Whistle_Data_Access_Layer
{
    public class ClsSettingDA
    {
        public static string ConnectionString = "Server=.;Database=Arena Whistle;User ID=sa;Password=123456";

        public static float GetDefaultPricePerBall()
        {

            float DefaultPricePerBall = 0;

            SqlConnection connection = new SqlConnection(ConnectionString);

            string query = @"select top 1 DefaultPricePerBall from Settings";


            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if(Result != null && float.TryParse(Result.ToString(), out float Price))
                {
                    DefaultPricePerBall = Price;
                }


            }
            catch
            {
                DefaultPricePerBall = 0;
            }
            finally
            {
                connection.Close();
            }

            return DefaultPricePerBall;


        }

        public static float GetDefaultShowerPrice()
        {

            float ShowerPrice = 0;

            SqlConnection connection = new SqlConnection(ConnectionString);

            string query = @"select top 1 DefaultShowerPrice from Settings";


            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if(Result != null && float.TryParse(Result.ToString(), out float Price))
                {
                    ShowerPrice = Price;
                }


            }
            catch
            {
                ShowerPrice = 0;
            }
            finally
            {
                connection.Close();
            }

            return ShowerPrice;


        }

        public static float GetDefaultRefereePrice()
        {

            float DefaultRefereePrice = 0;

            SqlConnection connection = new SqlConnection(ConnectionString);

            string query = @"select top 1 DefaultRefereePrice from Settings
";


            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if(Result != null && float.TryParse(Result.ToString(), out float Price))
                {
                    DefaultRefereePrice = Price;
                }


            }
            catch
            {
                DefaultRefereePrice = 0;
            }
            finally
            {
                connection.Close();
            }

            return DefaultRefereePrice;


        }


        public static float GetDefaultPriceClothingPerOnePlayer()
        {

            float DefaultPriceClothingPerOnePlayer = 0;

            SqlConnection connection = new SqlConnection(ConnectionString);

            string query = @"select top 1 DefaultPriceClothingPerOnePlayer from Settings";


            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if(Result != null && float.TryParse(Result.ToString(), out float Price))
                {
                    DefaultPriceClothingPerOnePlayer = Price;
                }


            }
            catch
            {
                DefaultPriceClothingPerOnePlayer = 0;
            }
            finally
            {
                connection.Close();
            }

            return DefaultPriceClothingPerOnePlayer;


        }
    }
}
