using System;
using System.Data;
using System.Data.SqlClient;


namespace Arena_Whistle_Data_Access_Layer
{
    public static class ClsPersonDA
    {

        public static bool FindPersonbyID(int PersonID, ref string FirstName,
                                              ref string LastName, ref string Gender,
                                              ref string PhoneNumber1,
                                              ref string PhoneNumber2,
                                              ref string Email1,
                                              ref string Email2,
                                              ref string Adress,
                                              ref DateTime BirthDate
                                            , ref string CountryName, ref string IdentificationNumber,
                                              ref string ImagePath)
        {
            bool IsFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_GetPersonByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        command.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Gender", SqlDbType.NVarChar, 10) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@BirthDate", SqlDbType.Date) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Country", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@IdentificationNumber", SqlDbType.NVarChar, 20) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@PhoneNumber1", SqlDbType.VarChar, 15) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@PhoneNumber2", SqlDbType.VarChar, 15) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Email1", SqlDbType.VarChar, 254) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Email2", SqlDbType.VarChar, 254) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 255) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@ImagePath", SqlDbType.NVarChar, 250) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@IsFound", SqlDbType.Bit) { Direction = ParameterDirection.Output });



                        connection.Open();
                        command.ExecuteNonQuery();


                        //Retrieve Output parmeters
                        if(IsFound = (bool)command.Parameters["@IsFound"].Value)
                        {
                            FirstName = command.Parameters["@FirstName"].Value.ToString();
                            LastName = command.Parameters["@LastName"].Value.ToString();
                            Gender = command.Parameters["@Gender"].Value.ToString();
                            BirthDate = Convert.ToDateTime(command.Parameters["@BirthDate"].Value);
                            CountryName = command.Parameters["@Country"].Value.ToString();
                            IdentificationNumber = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@IdentificationNumber"]);
                            PhoneNumber1 = command.Parameters["@PhoneNumber1"].Value.ToString();
                            PhoneNumber2 = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@PhoneNumber2"]);
                            Email1 = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@Email1"]);
                            Email2 = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@Email2"]);
                            Adress = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@Address"]);
                            ImagePath = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@ImagePath"]);
                        }
                    }
                }
            }
            catch(SqlException ex)
            {

            }


            return IsFound;
        }

        public static bool FindPersonbyFullName(ref int PersonID, string FirstName,
                                               string LastName, ref string Gender,
                                              ref string PhoneNumber1,
                                              ref string PhoneNumber2,
                                              ref string Email1,
                                              ref string Email2,
                                              ref string Adress,
                                              ref DateTime BirthDate
                                            , ref string CountryName, ref string IdentificationNumber,
                                              ref string ImagePath)
        {
            bool IsFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_GetPersonByFullName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);

                        command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Gender", SqlDbType.NVarChar, 10) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@BirthDate", SqlDbType.Date) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Country", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@IdentificationNumber", SqlDbType.NVarChar, 20) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@PhoneNumber1", SqlDbType.VarChar, 15) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@PhoneNumber2", SqlDbType.VarChar, 15) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Email1", SqlDbType.VarChar, 254) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Email2", SqlDbType.VarChar, 254) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 255) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@ImagePath", SqlDbType.NVarChar, 250) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@IsFound", SqlDbType.Bit) { Direction = ParameterDirection.Output });



                        connection.Open();
                        command.ExecuteNonQuery();


                        //Retrieve Output parmeters
                        if(IsFound = (bool)command.Parameters["@IsFound"].Value)
                        {
                            PersonID = Convert.ToInt32(command.Parameters["@PersonID"].Value);
                            Gender = command.Parameters["@Gender"].Value.ToString();
                            BirthDate = Convert.ToDateTime(command.Parameters["@BirthDate"].Value);
                            CountryName = command.Parameters["@Country"].Value.ToString();
                            IdentificationNumber = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@IdentificationNumber"]);
                            PhoneNumber1 = command.Parameters["@PhoneNumber1"].Value.ToString();
                            PhoneNumber2 = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@PhoneNumber2"]);
                            Email1 = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@Email1"]);
                            Email2 = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@Email2"]);
                            Adress = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@Address"]);
                            ImagePath = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@ImagePath"]);
                        }
                    }
                }
            }
            catch(SqlException ex)
            {

            }


            return IsFound;
        }

        public static bool FindPersonbyIdentificationNumber(ref int PersonID, ref string FirstName,
                                                            ref string LastName, ref string Gender,
                                                            ref string PhoneNumber1,
                                                            ref string PhoneNumber2,
                                                            ref string Email1,
                                                            ref string Email2,
                                                            ref string Adress,
                                                            ref DateTime BirthDate,
                                                            ref string CountryName, string IdentificationNumber,
                                                            ref string ImagePath)
        {
            bool IsFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_GetPersonBy.I.No", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@IdentificationNumber", IdentificationNumber);


                        command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Gender", SqlDbType.NVarChar, 10) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Gender", SqlDbType.NVarChar, 10) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@BirthDate", SqlDbType.Date) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Country", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@PhoneNumber1", SqlDbType.VarChar, 15) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@PhoneNumber2", SqlDbType.VarChar, 15) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Email1", SqlDbType.VarChar, 254) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Email2", SqlDbType.VarChar, 254) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 255) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@ImagePath", SqlDbType.NVarChar, 250) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@IsFound", SqlDbType.Bit) { Direction = ParameterDirection.Output });



                        connection.Open();
                        command.ExecuteNonQuery();


                        //Retrieve Output parmeters
                        if(IsFound = (bool)command.Parameters["@IsFound"].Value)
                        {
                            PersonID = Convert.ToInt32(command.Parameters["@PersonID"].Value);
                            FirstName = command.Parameters["@FirstName"].Value.ToString();
                            LastName = command.Parameters["@LastName"].Value.ToString();
                            Gender = command.Parameters["@Gender"].Value.ToString();
                            BirthDate = Convert.ToDateTime(command.Parameters["@BirthDate"].Value);
                            CountryName = command.Parameters["@Country"].Value.ToString();
                            PhoneNumber1 = command.Parameters["@PhoneNumber1"].Value.ToString();
                            PhoneNumber2 = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@PhoneNumber2"]);
                            Email1 = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@Email1"]);
                            Email2 = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@Email2"]);
                            Adress = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@Address"]);
                            ImagePath = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@ImagePath"]);
                        }
                    }
                }
            }
            catch(SqlException ex)
            {

            }


            return IsFound;
        }

        public static bool FindPersonbyPhoneNumber(string PN_Search, ref int PersonID, ref string FirstName,
                                                   ref string LastName, ref string Gender,
                                                   ref string PhoneNumber1,
                                                   ref string PhoneNumber2,
                                                   ref string Email1,
                                                   ref string Email2,
                                                   ref string Adress,
                                                   ref DateTime BirthDate,
                                                   ref string CountryName, ref string IdentificationNumber,
                                                   ref string ImagePath)
        {
            bool IsFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_GetPersonByPhoneNumber", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PhoneNumber1", PN_Search);

                        command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Gender", SqlDbType.NVarChar, 10) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@BirthDate", SqlDbType.Date) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Country", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@IdentificationNumber", SqlDbType.NVarChar, 20) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@PhoneNumber1", SqlDbType.VarChar, 15) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@PhoneNumber2", SqlDbType.VarChar, 15) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Email1", SqlDbType.VarChar, 254) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Email2", SqlDbType.VarChar, 254) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 255) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@ImagePath", SqlDbType.NVarChar, 250) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@IsFound", SqlDbType.Bit) { Direction = ParameterDirection.Output });



                        connection.Open();
                        command.ExecuteNonQuery();


                        //Retrieve Output parmeters
                        if(IsFound = (bool)command.Parameters["@IsFound"].Value)
                        {
                            PersonID = Convert.ToInt32(command.Parameters["@PersonID"].Value);
                            FirstName = command.Parameters["@FirstName"].Value.ToString();
                            LastName = command.Parameters["@LastName"].Value.ToString();
                            Gender = command.Parameters["@Gender"].Value.ToString();
                            BirthDate = Convert.ToDateTime(command.Parameters["@BirthDate"].Value);
                            CountryName = command.Parameters["@Country"].Value.ToString();
                            IdentificationNumber = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@IdentificationNumber"]);
                            PhoneNumber1 = command.Parameters["@PhoneNumber1"].Value.ToString();
                            PhoneNumber2 = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@PhoneNumber2"]);
                            Email1 = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@Email1"]);
                            Email2 = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@Email2"]);
                            Adress = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@Address"]);
                            ImagePath = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@ImagePath"]);



                        }
                    }
                }
            }
            catch(SqlException ex)
            {

            }


            return IsFound;
        }

        public static bool FindPersonbyEmail(string Email_Search, ref int PersonID, ref string FirstName,
                                         ref string LastName, ref string Gender,
                                         ref string PhoneNumber1,
                                         ref string PhoneNumber2,
                                         ref string Email1,
                                         ref string Email2,
                                         ref string Adress,
                                         ref DateTime BirthDate,
                                         ref string CountryName, ref string IdentificationNumber,
                                         ref string ImagePath)
        {
            bool IsFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_GetPersonByEmail", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Email_Search", Email_Search);

                        command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Gender", SqlDbType.NVarChar, 10) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@BirthDate", SqlDbType.Date) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Country", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@IdentificationNumber", SqlDbType.NVarChar, 20) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@PhoneNumber1", SqlDbType.VarChar, 15) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@PhoneNumber2", SqlDbType.VarChar, 15) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Email1", SqlDbType.VarChar, 254) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Email2", SqlDbType.VarChar, 254) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar, 255) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@ImagePath", SqlDbType.NVarChar, 250) { Direction = ParameterDirection.Output });
                        command.Parameters.Add(new SqlParameter("@IsFound", SqlDbType.Bit) { Direction = ParameterDirection.Output });



                        connection.Open();
                        command.ExecuteNonQuery();


                        //Retrieve Output parmeters
                        if(IsFound = (bool)command.Parameters["@IsFound"].Value)
                        {
                            PersonID = Convert.ToInt32(command.Parameters["@PersonID"].Value);
                            FirstName = command.Parameters["@FirstName"].Value.ToString();
                            LastName = command.Parameters["@LastName"].Value.ToString();
                            Gender = command.Parameters["@Gender"].Value.ToString();
                            BirthDate = Convert.ToDateTime(command.Parameters["@BirthDate"].Value);
                            CountryName = command.Parameters["@Country"].Value.ToString();
                            IdentificationNumber = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@IdentificationNumber"]);
                            PhoneNumber1 = command.Parameters["@PhoneNumber1"].Value.ToString();
                            PhoneNumber2 = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@PhoneNumber2"]);
                            Email1 = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@Email1"]);
                            Email2 = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@Email2"]);
                            Adress = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@Address"]);
                            ImagePath = VAlidationDA.checkOutputParameterIfNull<string>(command.Parameters["@ImagePath"]);



                        }
                    }
                }
            }
            catch(SqlException ex)
            {

            }


            return IsFound;
        }

        public static int AddingPerson(string FirstName,
                                          string LastName,
                                          string Gender,
                                          string PhoneNumber1,
                                          string PhoneNumber2,
                                          string Email1,
                                          string Email2,
                                          string Adress,
                                          DateTime BirthDate,
                                          string CountryName,
                                          string IdentificationNumber,
                                          string ImagePath,
                                          int? UserID)
        {
            int PersonID = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_AddNewPerson", connection))
                    {


                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@BirthDate", BirthDate);
                        command.Parameters.AddWithValue("@Country", CountryName);

                        if(!string.IsNullOrEmpty(IdentificationNumber))
                            command.Parameters.AddWithValue("@IdentificationNumber", IdentificationNumber);
                        else
                            command.Parameters.AddWithValue("@IdentificationNumber", DBNull.Value);

                        command.Parameters.AddWithValue("@PhoneNumber1", PhoneNumber1);

                        if(!string.IsNullOrEmpty(PhoneNumber2))
                            command.Parameters.AddWithValue("@PhoneNumber2", PhoneNumber2);
                        else
                            command.Parameters.AddWithValue("@PhoneNumber2", DBNull.Value);

                        if(!string.IsNullOrEmpty(Email1))
                            command.Parameters.AddWithValue("@Email1", Email1);
                        else
                            command.Parameters.AddWithValue("@Email1", DBNull.Value);

                        if(!string.IsNullOrEmpty(Email2))
                            command.Parameters.AddWithValue("@Email2", Email2);
                        else
                            command.Parameters.AddWithValue("@Email2", DBNull.Value);

                        if(!string.IsNullOrEmpty(Adress))
                            command.Parameters.AddWithValue("@Address", Adress);
                        else
                            command.Parameters.AddWithValue("@Address", DBNull.Value);

                        if(!string.IsNullOrEmpty(ImagePath))
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@ImagePath", DBNull.Value);


                        command.Parameters.Add(new SqlParameter("@newPersonID", SqlDbType.Int) { Direction = ParameterDirection.Output });

                        connection.Open();

                        if(UserID != null)
                        {
                            ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(UserID, connection);
                        }


                        command.ExecuteNonQuery();


                        PersonID = Convert.ToInt32(command.Parameters["@newPersonID"].Value);
                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return PersonID;
        }

        public static bool UpdatePersonInfo(int PersonID,
                                            string FirstName,
                                            string LastName,
                                            string Gender,
                                            string PhoneNumber1,
                                            string PhoneNumber2,
                                            string Email1,
                                            string Email2,
                                            string Adress,
                                            DateTime BirthDate,
                                            string CountryName,
                                            string IdentificationNumber,
                                            string ImagePath,
                                            int? UserID)
        {
            int EffectedRows = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_UpdatePerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;



                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@BirthDate", BirthDate);
                        command.Parameters.AddWithValue("@Country", CountryName);

                        if(!string.IsNullOrEmpty(IdentificationNumber))
                            command.Parameters.AddWithValue("@IdentificationNumber", IdentificationNumber);
                        else
                            command.Parameters.AddWithValue("@IdentificationNumber", DBNull.Value);

                        command.Parameters.AddWithValue("@PhoneNumber1", PhoneNumber1);

                        if(!string.IsNullOrEmpty(PhoneNumber2))
                            command.Parameters.AddWithValue("@PhoneNumber2", PhoneNumber2);
                        else
                            command.Parameters.AddWithValue("@PhoneNumber2", DBNull.Value);

                        if(!string.IsNullOrEmpty(Email1))
                            command.Parameters.AddWithValue("@Email1", Email1);
                        else
                            command.Parameters.AddWithValue("@Email1", DBNull.Value);

                        if(!string.IsNullOrEmpty(Email2))
                            command.Parameters.AddWithValue("@Email2", Email2);
                        else
                            command.Parameters.AddWithValue("@Email2", DBNull.Value);

                        if(!string.IsNullOrEmpty(Adress))
                            command.Parameters.AddWithValue("@Address", Adress);
                        else
                            command.Parameters.AddWithValue("@Address", DBNull.Value);

                        if(!string.IsNullOrEmpty(ImagePath))
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

                        connection.Open();

                        if(UserID != null)
                        {
                            ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(UserID, connection);
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


        public static bool IsPersonEsxistByPersonID(int PersonID)
        {
            bool ISFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_CheckPersonExistByPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", PersonID);


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
        public static bool IsPersonExistByIdentificationNumber(string IdentificationNumbe)
        {
            bool ISFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_CheckPersonExistByI_NO", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@IdentificationNumber", IdentificationNumbe);


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
        public static bool DeletePersonInfos(int PersonID, int? UserID)
        {
            byte EffectedRows = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_CheckPersonExistByI_NO", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        command.Parameters.AddWithValue("@PersonID", PersonID);


                        connection.Open();

                        if(UserID != null)
                        {
                            ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(UserID, connection);
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
    }
}

