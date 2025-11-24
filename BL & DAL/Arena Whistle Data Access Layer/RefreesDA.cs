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
    public static class ClsRefereeDA
    {
        public static DataView GetRefreesTable()
        {
            DataTable datatable = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_GetRefreesTable", connection))
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

        static public bool FindReferees(int RefreeID, ref int EmployeeID, ref bool Available)
        {
            bool IsFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                using(SqlCommand command = new SqlCommand("[SP_GetRefreeByID]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@RefreeID", RefreeID));

                    command.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@Available", SqlDbType.Bit) { Direction = ParameterDirection.Output });
                    command.Parameters.Add(new SqlParameter("@IsFound", SqlDbType.Bit) { Direction = ParameterDirection.Output });



                    connection.Open();
                    command.ExecuteNonQuery();



                    if(IsFound = Convert.ToBoolean(command.Parameters["@IsFound"].Value))
                    {
                        // Retrieve output parameters
                        EmployeeID = Convert.ToInt32(command.Parameters["@EmployeeID"].Value);
                        Available = Convert.ToBoolean(command.Parameters["@Available"].Value);
                    }
                }
            }
            catch(SqlException ex)
            {
                // Optional: log exception
            }


            return IsFound;
        }

        public static int AddReferee(ref int PersonID, string FirstName, string LastName,
                                     string Gender, string PhoneNumber1,
                                     string PhoneNumber2, string Email1,
                                     string Email2, string Adress,
                                     DateTime BirthDate, string CountryName,
                                     string IdentificationNumber, string ImagePath,


                                     ref int EmployeeID, string Department,
                                     DateTime HireDat, DateTime? ExitDate,
                                     decimal Salary, int Status,

                                     bool Available,

                                     int? ByUserID)
        {
            int RefreeID = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("[SP_AddNewrRefree]", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        //Using session_context stored procuder for passing RefreeID to People Sql Trigger
                        command.CommandText = "EXEC sp_set_session_context @key = N'ByUserID', @value = @ByUserID";
                        if(ByUserID != null)
                            command.Parameters.AddWithValue("@ByUserID", ByUserID);


                        //person param
                        command.Parameters.AddWithValue("@RefreeFirstName", FirstName);
                        command.Parameters.AddWithValue("@RefreeLastName", LastName);
                        command.Parameters.AddWithValue("@RefreeGender", Gender);
                        command.Parameters.AddWithValue("@RefreeBirthDate", BirthDate);
                        command.Parameters.AddWithValue("@RefreeCountry", CountryName);

                        if(!string.IsNullOrEmpty(IdentificationNumber))
                            command.Parameters.AddWithValue("@RefreeIdentificationNumber", IdentificationNumber);
                        else
                            command.Parameters.AddWithValue("@RefreeIdentificationNumber", DBNull.Value);

                        command.Parameters.AddWithValue("@RefreePhoneNumber1", PhoneNumber1);

                        if(!string.IsNullOrEmpty(PhoneNumber2))
                            command.Parameters.AddWithValue("@RefreePhoneNumber2", PhoneNumber2);
                        else
                            command.Parameters.AddWithValue("@RefreePhoneNumber2", DBNull.Value);

                        if(!string.IsNullOrEmpty(Email1))
                            command.Parameters.AddWithValue("@RefreeEmail1", Email1);
                        else
                            command.Parameters.AddWithValue("@RefreeEmail1", DBNull.Value);

                        if(!string.IsNullOrEmpty(Email2))
                            command.Parameters.AddWithValue("@RefreeEmail2", Email2);
                        else
                            command.Parameters.AddWithValue("@RefreeEmail2", DBNull.Value);

                        if(!string.IsNullOrEmpty(Adress))
                            command.Parameters.AddWithValue("@RefreeAddress", Adress);
                        else
                            command.Parameters.AddWithValue("@RefreeAddress", DBNull.Value);

                        if(!string.IsNullOrEmpty(ImagePath))
                            command.Parameters.AddWithValue("@RefreeImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@RefreeImagePath", DBNull.Value);

                        command.Parameters.Add(new SqlParameter("@RefreeNewPersonID", SqlDbType.Int) { Direction = ParameterDirection.Output });


                        //Employee Params
                        command.Parameters.AddWithValue("@RefreeDepartment", Department);
                        command.Parameters.AddWithValue("@RefreeHireDate", HireDat);
                        if(ExitDate != null)
                            command.Parameters.AddWithValue("@RefreeExitDate", ExitDate);
                        else
                            command.Parameters.AddWithValue("@RefreeExitDate", DBNull.Value);
                        command.Parameters.AddWithValue("@RefreeSalary", Salary);
                        command.Parameters.AddWithValue("@RefreeStatus", Status);

                        command.Parameters.Add(new SqlParameter("@RefreeNewEmployeeID", SqlDbType.Int) { Direction = ParameterDirection.Output });


                        //refree params
                        command.Parameters.AddWithValue("@Available", Available);


                        command.Parameters.Add(new SqlParameter("@newRefreeID", SqlDbType.Int) { Direction = ParameterDirection.Output });

                        connection.Open();
                        command.ExecuteNonQuery();

                        PersonID = Convert.ToInt32(command.Parameters["@RefreeNewPersonID"].Value);
                        EmployeeID = Convert.ToInt32(command.Parameters["@RefreeNewEmployeeID"].Value);
                        RefreeID = Convert.ToInt32(command.Parameters["@newRefreeID"].Value);
                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return RefreeID;
        }

        public static bool Updaterefree(int PersonID, string FirstName, string LastName,
                             string Gender, string PhoneNumber1,
                             string PhoneNumber2, string Email1,
                             string Email2, string Adress,
                             DateTime BirthDate, string CountryName,
                             string IdentificationNumber, string ImagePath,


                             int EmployeeID, string Department,
                             DateTime HireDat, DateTime? ExitDate,
                             decimal Salary, int Status,


                              int RefreeID, bool Available,

                              int? ByUserID)
        {
            int EffectedRows = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_UpdateRefree", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        //Using session_context stored procuder for passing RefreeID to People Sql Trigger
                        command.CommandText = "EXEC sp_set_session_context @key = N'ByUserID', @value = @ByUserID";
                        if(ByUserID != null)
                            command.Parameters.AddWithValue("@ByUserID", ByUserID);

                        //person 
                        command.Parameters.AddWithValue("@RefreePersonID", PersonID);
                        command.Parameters.AddWithValue("@RefreeFirstName", FirstName);
                        command.Parameters.AddWithValue("@RefreeLastName", LastName);
                        command.Parameters.AddWithValue("@RefreeGender", Gender);
                        command.Parameters.AddWithValue("@RefreeBirthDate", BirthDate);
                        command.Parameters.AddWithValue("@RefreeCountry", CountryName);

                        if(!string.IsNullOrEmpty(IdentificationNumber))
                            command.Parameters.AddWithValue("@RefreeIdentificationNumber", IdentificationNumber);
                        else
                            command.Parameters.AddWithValue("@RefreeIdentificationNumber", DBNull.Value);

                        command.Parameters.AddWithValue("@RefreePhoneNumber1", PhoneNumber1);

                        if(!string.IsNullOrEmpty(PhoneNumber2))
                            command.Parameters.AddWithValue("@RefreePhoneNumber2", PhoneNumber2);
                        else
                            command.Parameters.AddWithValue("@RefreePhoneNumber2", DBNull.Value);

                        if(!string.IsNullOrEmpty(Email1))
                            command.Parameters.AddWithValue("@RefreeEmail1", Email1);
                        else
                            command.Parameters.AddWithValue("@RefreeEmail1", DBNull.Value);

                        if(!string.IsNullOrEmpty(Email2))
                            command.Parameters.AddWithValue("@RefreeEmail2", Email2);
                        else
                            command.Parameters.AddWithValue("@RefreeEmail2", DBNull.Value);

                        if(!string.IsNullOrEmpty(Adress))
                            command.Parameters.AddWithValue("@RefreeAddress", Adress);
                        else
                            command.Parameters.AddWithValue("@RefreeAddress", DBNull.Value);

                        if(!string.IsNullOrEmpty(ImagePath))
                            command.Parameters.AddWithValue("@RefreeImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@RefreeImagePath", DBNull.Value);


                        //employee
                        command.Parameters.AddWithValue("@RefreeEmployeeID", EmployeeID);
                        command.Parameters.AddWithValue("@RefreeDepartment", Department);
                        command.Parameters.AddWithValue("@RefreeHireDate", HireDat);
                        if(ExitDate != null)
                            command.Parameters.AddWithValue("@RefreeExitDate", ExitDate);
                        else
                            command.Parameters.AddWithValue("@RefreeExitDate", DBNull.Value);
                        command.Parameters.AddWithValue("@RefreeSalary", Salary);
                        command.Parameters.AddWithValue("@RefreeStatus", Status);


                        //user
                        command.Parameters.AddWithValue("@RefreeID", RefreeID);
                        command.Parameters.AddWithValue("@Available", Available);



                        connection.Open();
                        EffectedRows = command.ExecuteNonQuery();

                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return EffectedRows > 0;
        }


        public static bool DeleteReferee(int RefreeID, int ByUserID)
        {
            byte EffectedRows = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_DeleteRefree", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        //Using session_context stored procuder for passing UserID to People Sql Trigger
                        command.CommandText = "EXEC sp_set_session_context @key = N'ByUserID', @value = @ByUserID";
                            command.Parameters.AddWithValue("@ByUserID", ByUserID);

                        command.Parameters.AddWithValue("@RefreeID", RefreeID);


                        connection.Open();
                        EffectedRows = Convert.ToByte(command.ExecuteNonQuery());
                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return ( EffectedRows > 0 );
        }

        public static int? GetAvailableRefereeID()
        {
            int? AvailableRefreeID = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_GetAvailableRefreeID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@RefreeID", SqlDbType.Int) { Direction = ParameterDirection.Output });

                        connection.Open();

                        AvailableRefreeID = Convert.ToByte(command.ExecuteScalar());
                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return AvailableRefreeID == 0 ? null : AvailableRefreeID;
        }

        public static bool UpdateAvailabilityStatus(int RefreeID, bool Available, int? ByUserID)
        {
            int EffectedRows = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("SP_UpdateAvailabilityStatus", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        //Using session_context stored procuder for passing RefreeID to People Sql Trigger
                        command.CommandText = "EXEC sp_set_session_context @key = N'ByUserID', @value = @ByUserID";
                        if(ByUserID != null)
                            command.Parameters.AddWithValue("@ByUserID", ByUserID);

                       
                        
                        command.Parameters.AddWithValue("@RefreeID", RefreeID);
                        command.Parameters.AddWithValue("@Available", Available);



                        connection.Open();
                        EffectedRows = command.ExecuteNonQuery();

                    }
                }
            }
            catch(SqlException ex)
            {

            }

            return EffectedRows > 0;
        }

    }
}
