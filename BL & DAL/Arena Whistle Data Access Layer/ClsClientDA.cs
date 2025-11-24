using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Arena_Whistle_Data_Access_Layer
{
    public class ClsClientDA
    {

        public static DataView GetClientsView(bool? isActive)
        {
            DataTable dt = new DataTable();

            using(SqlConnection conn = new SqlConnection(ClsSettingDA.ConnectionString))
            using(SqlCommand cmd = new SqlCommand("SP_GetClientsTable", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                if(isActive.HasValue)
                    cmd.Parameters.AddWithValue("@IsActive", isActive.Value);
                else
                    cmd.Parameters.AddWithValue("@IsActive", DBNull.Value);

                conn.Open(); // REQUIRED

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt.DefaultView; // return DataView
        }


        public static bool UpdateClientCredentials(int clientID, string userName, string password, int? ByUserID)
        {
            using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
            using(SqlCommand cmd = new SqlCommand("Sp_UpdateClientCredentials", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ClientID", clientID);
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Password", password);

                connection.Open();


                if(ByUserID != null)
                {
                    ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(ByUserID, connection);
                }

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0; // true if update succeeded
            }
        }

        public static bool FindClientByUserName(
        string userName,
        ref int clientID,
        ref int personID,
        ref string password,
        ref bool isActive)
        {
            bool isFound = false;

            using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand("Sp_GetClientByUserName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", userName);

                    connection.Open();
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            clientID = Convert.ToInt32(reader["ClientID"]);
                            personID = Convert.ToInt32(reader["PersonID"]);
                            password = reader["Password"].ToString();
                            isActive = Convert.ToBoolean(reader["IsActive"]);
                            isFound = true;
                        }
                    }
                }
            }

            return isFound;
        }

        static public bool FindClient(int ClientID,
                                      ref string userName,
                                      ref string password,
                                      ref int PersonID,
                                      ref bool IsActive)
        {
            bool IsFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_GetClientByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ClientID", ClientID);

                        command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@IsActive", SqlDbType.Bit) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@IsFound", SqlDbType.Bit) { Direction = ParameterDirection.Output });


                        connection.Open();
                        command.ExecuteNonQuery();


                        //Retrieve Output parmeters
                        if(IsFound = (bool)command.Parameters["@IsFound"].Value)
                        {

                            PersonID = Convert.ToInt32(command.Parameters["@PersonID"].Value);
                            userName = command.Parameters["@UserName"].Value.ToString();
                            password = command.Parameters["@Password"].Value.ToString();
                            IsActive = Convert.ToBoolean(command.Parameters["@IsActive"].Value);

                        }
                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return IsFound;
        }

        static public bool FindClientByUserNameAndPassword(ref int ClientID,
                                                               string userName,
                                                               string password,
                                                            ref int PersonID,
                                                            ref bool IsActive)
        {
            bool IsFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_GetClientByUserNameAndPassWord", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserName", userName);
                        command.Parameters.AddWithValue("@Password", password);


                        command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@ClientID", SqlDbType.Int) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@IsActive", SqlDbType.Bit) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@IsFound", SqlDbType.Bit) { Direction = ParameterDirection.Output });


                        connection.Open();
                        command.ExecuteNonQuery();


                        //Retrieve Output parmeters
                        if(IsFound = (bool)command.Parameters["@IsFound"].Value)
                        {
                            PersonID = Convert.ToInt32(command.Parameters["@PersonID"].Value);
                            ClientID = Convert.ToInt32(command.Parameters["@ClientID"].Value);
                            IsActive = Convert.ToBoolean(command.Parameters["@IsActive"].Value);

                        }
                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return IsFound;
        }
        public static DataView GetClientsTable()
        {

            DataTable datatable = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_GetClientsTable", connection))
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


        public static int AddClient(ref int PersonID, string FirstName, string LastName,
                                     string Gender, string PhoneNumber1,
                                     string PhoneNumber2, string Email1,
                                     string Email2, string Adress,
                                     DateTime BirthDate, string CountryName,
                                     string IdentificationNumber, string ImagePath,


                                     string userName, string password, bool IsActive, int? ByUserID)
        {
            int ClientID = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_AddNewClient", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        //person params
                        command.Parameters.AddWithValue("@ClientFirstName", FirstName);
                        command.Parameters.AddWithValue("@ClientLastName", LastName);
                        command.Parameters.AddWithValue("@ClientGender", Gender);
                        command.Parameters.AddWithValue("@ClientBirthDate", BirthDate);
                        command.Parameters.AddWithValue("@ClientCountry", CountryName);

                        if(!string.IsNullOrEmpty(IdentificationNumber))
                            command.Parameters.AddWithValue("@ClientIdentificationNumber", IdentificationNumber);
                        else
                            command.Parameters.AddWithValue("@ClientIdentificationNumber", DBNull.Value);

                        command.Parameters.AddWithValue("@ClientPhoneNumber1", PhoneNumber1);

                        if(!string.IsNullOrEmpty(PhoneNumber2))
                            command.Parameters.AddWithValue("@ClientPhoneNumber2", PhoneNumber2);
                        else
                            command.Parameters.AddWithValue("@ClientPhoneNumber2", DBNull.Value);

                        if(!string.IsNullOrEmpty(Email1))
                            command.Parameters.AddWithValue("@ClientEmail1", Email1);
                        else
                            command.Parameters.AddWithValue("@ClientEmail1", DBNull.Value);

                        if(!string.IsNullOrEmpty(Email2))
                            command.Parameters.AddWithValue("@ClientEmail2", Email2);
                        else
                            command.Parameters.AddWithValue("@ClientEmail2", DBNull.Value);

                        if(!string.IsNullOrEmpty(Adress))
                            command.Parameters.AddWithValue("@ClientAddress", Adress);
                        else
                            command.Parameters.AddWithValue("@ClientAddress", DBNull.Value);

                        if(!string.IsNullOrEmpty(ImagePath))
                            command.Parameters.AddWithValue("@ClientImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@ClientImagePath", DBNull.Value);

                        command.Parameters.Add(new SqlParameter("@ClientNewPersonID", SqlDbType.Int) { Direction = ParameterDirection.Output });



                        //Client
                        command.Parameters.AddWithValue("@UserName", userName);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@IsActive", IsActive);

                        command.Parameters.Add(new SqlParameter("@newClientID", SqlDbType.Int) { Direction = ParameterDirection.Output });

                        connection.Open();

                        if(ByUserID != null)
                        {
                            ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(ByUserID, connection);
                        }
                        command.ExecuteNonQuery();


                        ClientID = Convert.ToInt32(command.Parameters["@newClientID"].Value);
                        PersonID = Convert.ToInt32(command.Parameters["@ClientNewPersonID"].Value);
                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return ClientID;
        }
        public static bool UpdateClient(int PersonID, string FirstName, string LastName,
                                     string Gender, string PhoneNumber1,
                                     string PhoneNumber2, string Email1,
                                     string Email2, string Adress,
                                     DateTime BirthDate, string CountryName,
                                     string IdentificationNumber, string ImagePath,

                                     int ClientID, string userName, string password, bool IsActive,
                                     int? ByUserID)
        {
            int EffectedRows = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_UpdateClient", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        //person params
                        command.Parameters.AddWithValue("@ClientPersonID", PersonID);
                        command.Parameters.AddWithValue("@ClientFirstName", FirstName);
                        command.Parameters.AddWithValue("@ClientLastName", LastName);
                        command.Parameters.AddWithValue("@ClientGender", Gender);
                        command.Parameters.AddWithValue("@ClientBirthDate", BirthDate);
                        command.Parameters.AddWithValue("@ClientCountry", CountryName);

                        if(!string.IsNullOrEmpty(IdentificationNumber))
                            command.Parameters.AddWithValue("@ClientIdentificationNumber", IdentificationNumber);
                        else
                            command.Parameters.AddWithValue("@ClientIdentificationNumber", DBNull.Value);

                        command.Parameters.AddWithValue("@ClientPhoneNumber1", PhoneNumber1);

                        if(!string.IsNullOrEmpty(PhoneNumber2))
                            command.Parameters.AddWithValue("@ClientPhoneNumber2", PhoneNumber2);
                        else
                            command.Parameters.AddWithValue("@ClientPhoneNumber2", DBNull.Value);

                        if(!string.IsNullOrEmpty(Email1))
                            command.Parameters.AddWithValue("@ClientEmail1", Email1);
                        else
                            command.Parameters.AddWithValue("@ClientEmail1", DBNull.Value);

                        if(!string.IsNullOrEmpty(Email2))
                            command.Parameters.AddWithValue("@ClientEmail2", Email2);
                        else
                            command.Parameters.AddWithValue("@ClientEmail2", DBNull.Value);

                        if(!string.IsNullOrEmpty(Adress))
                            command.Parameters.AddWithValue("@ClientAddress", Adress);
                        else
                            command.Parameters.AddWithValue("@ClientAddress", DBNull.Value);

                        if(!string.IsNullOrEmpty(ImagePath))
                            command.Parameters.AddWithValue("@ClientImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@ClientImagePath", DBNull.Value);


                        //Client params
                        command.Parameters.AddWithValue("@ClientID", ClientID);
                        command.Parameters.AddWithValue("@UserName", userName);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@IsActive", IsActive);



                        connection.Open();

                        if(ByUserID != null)
                        {
                            ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(ByUserID, connection);
                        }
                        EffectedRows = command.ExecuteNonQuery();

                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return EffectedRows > 0;
        }
        public static bool DeleteClient(int ClientID, int? ByUserID)
        {

            byte EffectedRows = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_DeleteClient", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        command.Parameters.AddWithValue("@ClientID", ClientID);


                        connection.Open();

                        if(ByUserID != null)
                        {
                            ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(ByUserID, connection);
                        }


                        EffectedRows = Convert.ToByte(command.ExecuteNonQuery());

                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return ( EffectedRows > 0 );
        }



        public static bool IsClientExist(int ClientID)
        {
            bool ISFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_CheckPersonExistByPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ClientID", ClientID);


                        connection.Open();
                        ISFound = Convert.ToBoolean(command.ExecuteScalar());

                    }
                }
            }
            catch(SqlException ex)
            {

            }


            return ISFound;
        }

    }
}
