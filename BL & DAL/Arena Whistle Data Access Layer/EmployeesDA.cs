using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Whistle_Data_Access_Layer
{
    public static class ClsEmployeesDA
    {

        public static DataView GetEmployeesTable()
        {

            DataTable datatable = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_GetEmployeesTable", connection))
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
        public static bool FindEmployeeByID(int EmployeeID,
                                        ref int PersonID,
                                        ref string Department,
                                        ref DateTime HireDate,
                                        ref DateTime? ExitDate,
                                        ref decimal Salary,
                                        ref int Status)
        {
            bool IsFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                using(SqlCommand command = new SqlCommand("SP_GetEmployeeByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@EmployeeID", EmployeeID));

                    command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@Department", SqlDbType.NVarChar, 20) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@HireDate", SqlDbType.Date) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@ExitDate", SqlDbType.Date) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@Salary", SqlDbType.SmallMoney) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@Status", SqlDbType.TinyInt) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@IsFound", SqlDbType.Bit) { Direction = ParameterDirection.Output });

                    connection.Open();
                    command.ExecuteNonQuery();



                    if(IsFound = Convert.ToBoolean(command.Parameters["@IsFound"].Value))
                    {
                        // Retrieve output parameters
                        PersonID = Convert.ToInt32(command.Parameters["@PersonID"].Value);
                        Department = command.Parameters["@Department"].Value.ToString();
                        HireDate = Convert.ToDateTime(command.Parameters["@HireDate"].Value);
                        ExitDate = VAlidationDA.checkOutputParameterIfNull<DateTime?>(command.Parameters["@ExitDate"]);
                        Salary = Convert.ToDecimal(command.Parameters["@Salary"].Value);
                        Status = Convert.ToInt32(command.Parameters["@Status"].Value);
                    }
                }
            }
            catch(SqlException ex)
            {
                // Optional: log exception
            }


            return IsFound;
        }


        public static int AddingEmployee(ref int PersonID, string FirstName, string LastName,
                                     string Gender, string PhoneNumber1,
                                     string PhoneNumber2, string Email1,
                                     string Email2, string Adress,
                                     DateTime BirthDate, string CountryName,
                                     string IdentificationNumber, string ImagePath,

                                         string Department,
                                        DateTime HireDat, DateTime? ExitDate,
                                        decimal Salary, int Status, int UserID)
        {
            int EmployeeID = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_AddNewEmployee", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;



                        //person
                        command.Parameters.AddWithValue("@EmployeeFirstName", FirstName);
                        command.Parameters.AddWithValue("@EmployeeLastName", LastName);
                        command.Parameters.AddWithValue("@EmployeeGender", Gender);
                        command.Parameters.AddWithValue("@EmployeeBirthDate", BirthDate);
                        command.Parameters.AddWithValue("@EmployeeCountry", CountryName);

                        if(!string.IsNullOrEmpty(IdentificationNumber))
                            command.Parameters.AddWithValue("@EmployeeIdentificationNumber", IdentificationNumber);
                        else
                            command.Parameters.AddWithValue("@EmployeeIdentificationNumber", DBNull.Value);

                        command.Parameters.AddWithValue("@EmployeePhoneNumber1", PhoneNumber1);

                        if(!string.IsNullOrEmpty(PhoneNumber2))
                            command.Parameters.AddWithValue("@EmployeePhoneNumber2", PhoneNumber2);
                        else
                            command.Parameters.AddWithValue("@EmployeePhoneNumber2", DBNull.Value);

                        if(!string.IsNullOrEmpty(Email1))
                            command.Parameters.AddWithValue("@EmployeeEmail1", Email1);
                        else
                            command.Parameters.AddWithValue("@EmployeeEmail1", DBNull.Value);

                        if(!string.IsNullOrEmpty(Email2))
                            command.Parameters.AddWithValue("@EmployeeEmail2", Email2);
                        else
                            command.Parameters.AddWithValue("@EmployeeEmail2", DBNull.Value);

                        if(!string.IsNullOrEmpty(Adress))
                            command.Parameters.AddWithValue("@EmployeeAddress", Adress);
                        else
                            command.Parameters.AddWithValue("@EmployeeAddress", DBNull.Value);

                        if(!string.IsNullOrEmpty(ImagePath))
                            command.Parameters.AddWithValue("@EmployeeImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@EmployeeImagePath", DBNull.Value);

                        command.Parameters.Add(new SqlParameter("@EmployeeNewPersonID", SqlDbType.Int) { Direction = ParameterDirection.Output });



                        //employee
                        command.Parameters.AddWithValue("@Department", Department);
                        command.Parameters.AddWithValue("@HireDate", HireDat);
                        if(ExitDate != null)
                            command.Parameters.AddWithValue("@ExitDate", ExitDate);
                        else
                            command.Parameters.AddWithValue("@ExitDate", DBNull.Value);
                        command.Parameters.AddWithValue("@Salary", Salary);
                        command.Parameters.AddWithValue("@Status", Status);


                        command.Parameters.Add(new SqlParameter("@newEmployeeID", SqlDbType.Int) { Direction = ParameterDirection.Output });

                        connection.Open();

                        ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(UserID, connection);


                        command.ExecuteNonQuery();

                        EmployeeID = Convert.ToInt32(command.Parameters["@newEmployeeID"].Value);
                        PersonID = Convert.ToInt32(command.Parameters["@EmployeeNewPersonID"].Value);
                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return EmployeeID;
        }
        public static bool UpdateEmployee(int PersonID, string FirstName, string LastName,
                                          string Gender, string PhoneNumber1,
                                          string PhoneNumber2, string Email1,
                                          string Email2, string Adress,
                                          DateTime BirthDate, string CountryName,
                                          string IdentificationNumber, string ImagePath,


                                         int EmployeeID, string Department,
                                          DateTime HireDat, DateTime? ExitDate,
                                          decimal Salary, int Status, int UserID)
        {
            int EffectedRows = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_UpdateEmployee", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;




                        //person params
                        command.Parameters.AddWithValue("@EmployeePersonID", PersonID);
                        command.Parameters.AddWithValue("@EmployeeFirstName", FirstName);
                        command.Parameters.AddWithValue("@EmployeeLastName", LastName);
                        command.Parameters.AddWithValue("@EmployeeGender", Gender);
                        command.Parameters.AddWithValue("@EmployeeBirthDate", BirthDate);
                        command.Parameters.AddWithValue("@EmployeeCountry", CountryName);

                        if(!string.IsNullOrEmpty(IdentificationNumber))
                            command.Parameters.AddWithValue("@EmployeeIdentificationNumber", IdentificationNumber);
                        else
                            command.Parameters.AddWithValue("@EmployeeIdentificationNumber", DBNull.Value);

                        command.Parameters.AddWithValue("@EmployeePhoneNumber1", PhoneNumber1);

                        if(!string.IsNullOrEmpty(PhoneNumber2))
                            command.Parameters.AddWithValue("@EmployeePhoneNumber2", PhoneNumber2);
                        else
                            command.Parameters.AddWithValue("@EmployeePhoneNumber2", DBNull.Value);

                        if(!string.IsNullOrEmpty(Email1))
                            command.Parameters.AddWithValue("@EmployeeEmail1", Email1);
                        else
                            command.Parameters.AddWithValue("@EmployeeEmail1", DBNull.Value);

                        if(!string.IsNullOrEmpty(Email2))
                            command.Parameters.AddWithValue("@EmployeeEmail2", Email2);
                        else
                            command.Parameters.AddWithValue("@EmployeeEmail2", DBNull.Value);

                        if(!string.IsNullOrEmpty(Adress))
                            command.Parameters.AddWithValue("@EmployeeAddress", Adress);
                        else
                            command.Parameters.AddWithValue("@EmployeeAddress", DBNull.Value);

                        if(!string.IsNullOrEmpty(ImagePath))
                            command.Parameters.AddWithValue("@EmployeeImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@EmployeeImagePath", DBNull.Value);






                        //employee
                        command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                        command.Parameters.AddWithValue("@Department", Department);
                        command.Parameters.AddWithValue("@HireDate", HireDat);
                        if(ExitDate != null)
                            command.Parameters.AddWithValue("@ExitDate", ExitDate);
                        else
                            command.Parameters.AddWithValue("@ExitDate", DBNull.Value);
                        command.Parameters.AddWithValue("@Salary", Salary);
                        command.Parameters.AddWithValue("@Status", Status);


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



        public static bool DeleteEmployee(int EmployeeID, int UserID)
        {
            byte EffectedRows = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_DeleteEmployee", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;



                        command.Parameters.AddWithValue("@EmployeeID", EmployeeID);


                        connection.Open();
                        ClsUtilDA.SendUserIDTo_Session_context_StoredProsuderIn_CRUD_oparetions(UserID, connection);

                        EffectedRows = Convert.ToByte(command.ExecuteNonQuery());

                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return ( EffectedRows > 0 );
        }

        public static int GetEmployeePersonID(int EmployeeID)
        {
            int EmployeePersonID = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_GetEmployeePersonID", connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@EmployeeID", EmployeePersonID);
                        command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Direction = ParameterDirection.Output });


                        connection.Open();
                        command.ExecuteNonQuery();


                        EmployeePersonID = Convert.ToInt32(command.Parameters["@PersonID"].Value);
                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return EmployeePersonID;
        }
       
        public static bool IsEmployeeExist(int EmployeeID)
        {
            bool ISFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("[SP_CheckEmployeeExistenceByID]", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

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
