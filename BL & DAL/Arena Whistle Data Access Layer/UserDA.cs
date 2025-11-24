using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Arena_Whistle_Data_Access_Layer
{
    public static class ClsUserDA
    {










        public static DataView GetUsersTable()
        {
            DataTable datatable = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_GetUsersTable", connection))
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

        public static bool FindUserByUserName(string UserName,
                                              ref int UserID,
                                              ref int EmployeeID,
                                              ref string Password,
                                              ref int Permission)
        {
            bool IsFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                using(SqlCommand command = new SqlCommand("SP_GetUserByUserName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Input
                    command.Parameters.Add(new SqlParameter("@UserName", UserName));

                    // Outputs
                    command.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@Permission", SqlDbType.Int) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@IsFound", SqlDbType.Bit) { Direction = ParameterDirection.Output });

                    connection.Open();
                    command.ExecuteNonQuery();

                    if(IsFound = Convert.ToBoolean(command.Parameters["@IsFound"].Value))
                    {
                        UserID = Convert.ToInt32(command.Parameters["@UserID"].Value);
                        EmployeeID = Convert.ToInt32(command.Parameters["@EmployeeID"].Value);
                        Password = command.Parameters["@Password"].Value.ToString();
                        Permission = Convert.ToInt32(command.Parameters["@Permission"].Value);
                    }
                }
            }
            catch(SqlException ex)
            {
                // Log exception if needed
            }

            return IsFound;
        }

        public static bool FindUserByID(int UserID,
                                        ref int EmployeeID,
                                        ref string UserName
                                       , ref string Password
                                       , ref int Permission)
        {
            bool IsFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                using(SqlCommand command = new SqlCommand("SP_GetUserByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@UserID", UserID));

                    command.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@Permession", SqlDbType.Int) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@IsFound", SqlDbType.Bit) { Direction = ParameterDirection.Output });


                    connection.Open();
                    command.ExecuteNonQuery();



                    if(IsFound = Convert.ToBoolean(command.Parameters["@IsFound"].Value))
                    {
                        // Retrieve output parameters
                        EmployeeID = Convert.ToInt32(command.Parameters["@EmployeeID"].Value);
                        UserName = command.Parameters["@UserName"].Value.ToString();
                        Password = command.Parameters["@Password"].Value.ToString();
                        Permission = Convert.ToInt32(command.Parameters["@Permession"].Value);
                    }
                }
            }
            catch(SqlException ex)
            {
                // Optional: log exception
            }


            return IsFound;
        }



        static public bool FindUserByUserNameAndPassword(ref int UserID,
                                                          ref int EmployeeID,
                                                           string UserName
                                                         , string Password
                                                         , ref int Permission)
        {
            bool IsFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                using(SqlCommand command = new SqlCommand("SP_GetUserByUserNameAndPassWord", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);



                    command.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@Permession", SqlDbType.Int) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@IsFound", SqlDbType.Bit) { Direction = ParameterDirection.Output });


                    connection.Open();
                    command.ExecuteNonQuery();



                    if(IsFound = Convert.ToBoolean(command.Parameters["@IsFound"].Value))
                    {
                        // Retrieve output parameters
                        UserID = Convert.ToInt32(command.Parameters["@UserID"].Value);
                        EmployeeID = Convert.ToInt32(command.Parameters["@EmployeeID"].Value);
                        Permission = Convert.ToInt32(command.Parameters["@Permession"].Value);
                    }
                }
            }
            catch(SqlException ex)
            {
                // Optional: log exception
            }


            return IsFound;
        }


        public static int AddingUser(ref int PersonID, string FirstName, string LastName,
                                     string Gender, string PhoneNumber1,
                                     string PhoneNumber2, string Email1,
                                     string Email2, string Adress,
                                     DateTime BirthDate, string CountryName,
                                     string IdentificationNumber, string ImagePath,


                                     ref int EmployeeID, string Department,
                                     DateTime HireDat, DateTime? ExitDate,
                                     decimal Salary, int Status,


                                      string UserName, string Password
                                    , int Permission, int? ByUserID)

        {
            int UserID = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_AddNewUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // person params
                        command.Parameters.AddWithValue("@UserFirstName", FirstName);
                        command.Parameters.AddWithValue("@UserLastName", LastName);
                        command.Parameters.AddWithValue("@UserGender", Gender);
                        command.Parameters.AddWithValue("@UserBirthDate", BirthDate);
                        command.Parameters.AddWithValue("@UserCountry", CountryName);

                        command.Parameters.AddWithValue("@UserIdentificationNumber",
                             string.IsNullOrEmpty(IdentificationNumber) ? (object)DBNull.Value : IdentificationNumber);

                        command.Parameters.AddWithValue("@UserPhoneNumber1", PhoneNumber1);
                        command.Parameters.AddWithValue("@UserPhoneNumber2",
                             string.IsNullOrEmpty(PhoneNumber2) ? (object)DBNull.Value : PhoneNumber2);

                        command.Parameters.AddWithValue("@UserEmail1",
                             string.IsNullOrEmpty(Email1) ? (object)DBNull.Value : Email1);

                        command.Parameters.AddWithValue("@UserEmail2",
                             string.IsNullOrEmpty(Email2) ? (object)DBNull.Value : Email2);

                        command.Parameters.AddWithValue("@UserAddress",
                             string.IsNullOrEmpty(Adress) ? (object)DBNull.Value : Adress);

                        command.Parameters.AddWithValue("@UserImagePath",
                             string.IsNullOrEmpty(ImagePath) ? (object)DBNull.Value : ImagePath);

                        command.Parameters.Add(new SqlParameter("@UseNewPersonID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        });

                        // Employee params
                        command.Parameters.AddWithValue("@UserDepartment", Department);
                        command.Parameters.AddWithValue("@UserHireDate", HireDat);
                        command.Parameters.AddWithValue("@UserExitDate",
                             ExitDate.HasValue ? (object)ExitDate : DBNull.Value);

                        command.Parameters.AddWithValue("@UserSalary", Salary);
                        command.Parameters.AddWithValue("@UserStatus", Status);

                        command.Parameters.Add(new SqlParameter("@UsernewEmployeeID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        });

                        // User params
                        command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@Permission", Permission);

                        command.Parameters.Add(new SqlParameter("@newUserID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        });

                        connection.Open();

                        ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(ByUserID, connection);

                        command.ExecuteNonQuery();

                        PersonID = Convert.ToInt32(command.Parameters["@UseNewPersonID"].Value);
                        EmployeeID = Convert.ToInt32(command.Parameters["@UsernewEmployeeID"].Value);
                        UserID = Convert.ToInt32(command.Parameters["@newUserID"].Value);
                    }
                }

            }
            catch(SqlException ex)
            {

            }

            return UserID;
        }


        public static bool UpdateUser(int PersonID, string FirstName, string LastName,
                                     string Gender, string PhoneNumber1,
                                     string PhoneNumber2, string Email1,
                                     string Email2, string Adress,
                                     DateTime BirthDate, string CountryName,
                                     string IdentificationNumber, string ImagePath,


                                      int EmployeeID, string Department,
                                     DateTime HireDat, DateTime? ExitDate,
                                     decimal Salary, int Status,


                                      int UserID, string UserName,
                                      int? ByUserID)
        {
            int EffectedRows = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_UpdateUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        //person 
                        command.Parameters.AddWithValue("@UserPersonID", PersonID);
                        command.Parameters.AddWithValue("@UserFirstName", FirstName);
                        command.Parameters.AddWithValue("@UserLastName", LastName);
                        command.Parameters.AddWithValue("@UserGender", Gender);
                        command.Parameters.AddWithValue("@UserBirthDate", BirthDate);
                        command.Parameters.AddWithValue("@UserCountry", CountryName);

                        command.Parameters.AddWithValue("@UserIdentificationNumber",
                            string.IsNullOrEmpty(IdentificationNumber) ? (object)DBNull.Value : IdentificationNumber);

                        command.Parameters.AddWithValue("@UserPhoneNumber1", PhoneNumber1);

                        command.Parameters.AddWithValue("@UserPhoneNumber2",
                            string.IsNullOrEmpty(PhoneNumber2) ? (object)DBNull.Value : PhoneNumber2);

                        command.Parameters.AddWithValue("@UserEmail1",
                            string.IsNullOrEmpty(Email1) ? (object)DBNull.Value : Email1);

                        command.Parameters.AddWithValue("@UserEmail2",
                            string.IsNullOrEmpty(Email2) ? (object)DBNull.Value : Email2);

                        command.Parameters.AddWithValue("@UserAddress",
                            string.IsNullOrEmpty(Adress) ? (object)DBNull.Value : Adress);

                        command.Parameters.AddWithValue("@UserImagePath",
                            string.IsNullOrEmpty(ImagePath) ? (object)DBNull.Value : ImagePath);


                        // employee params
                        command.Parameters.AddWithValue("@UserEmployeeID", EmployeeID);
                        command.Parameters.AddWithValue("@UserDepartment", Department);
                        command.Parameters.AddWithValue("@UserHireDate", HireDat);

                        command.Parameters.AddWithValue("@UserExitDate",
                            ExitDate.HasValue ? (object)ExitDate : DBNull.Value);

                        command.Parameters.AddWithValue("@UserSalary", Salary);
                        command.Parameters.AddWithValue("@UserStatus", Status);


                        // user params
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@UserName", UserName);



                        connection.Open();

                        ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(ByUserID, connection);

                        EffectedRows = command.ExecuteNonQuery();

                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return EffectedRows > 0;
        }


        public static bool DeleteUser(int UserID, int ByUserID)
        {
            byte EffectedRows = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_DeleteUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", UserID);


                        connection.Open();

                        ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(ByUserID, connection);

                        EffectedRows = Convert.ToByte(command.ExecuteNonQuery());
                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return ( EffectedRows > 0 );
        }

        public static bool IsUserExist(int UserID)
        {
            bool ISFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_CheckUserExistenceByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", UserID);

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


        public static bool UpdatePassword(int UserID, string NewHashPassword, int ByUserID)
        {
            int EffectedRows = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_UpdateUserPassword", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;



                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@Password", NewHashPassword);

                        connection.Open();

                        ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(ByUserID, connection);

                        EffectedRows = command.ExecuteNonQuery();

                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return EffectedRows > 0;
        }
        public static bool UpdatePermession(int UserID, int NewPermession, int ByUserID)
        {
            int EffectedRows = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_UpdateUserPermission", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@Permission", NewPermession);

                        connection.Open();

                        ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(UserID, connection);

                        EffectedRows = command.ExecuteNonQuery();

                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return EffectedRows > 0;
        }
        public static bool UpdateUserName(int UserID, string NewUserName, int ByUserID)
        {
            int EffectedRows = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_UpdateUserName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;



                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@UserName", NewUserName);

                        connection.Open();

                        ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(ByUserID, connection);

                        EffectedRows = command.ExecuteNonQuery();

                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return EffectedRows > 0;
        }
        public static bool UpdateUserCredentials(int userID, string userName, string password, int ByUserID)
        {
            using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
            using(SqlCommand cmd = new SqlCommand("Sp_UpdateUserCredentials", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserID", userID);
                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Password", password);

                connection.Open();

                ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(ByUserID, connection);

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }


    }
}
