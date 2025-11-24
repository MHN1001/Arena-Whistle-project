using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Whistle_Data_Access_Layer
{
    public class ClsDepartmentDA
    {
        public static bool IsDepartmentExist(int DepartmentID)
        {
            bool ISFound = false;

            SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString);

            string query = @"select y='y' from Departments
                             where DepartmentID = @DepartmentID";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);



            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                ISFound = reader.HasRows;

                reader.Close();
            }

            catch
            {
                ISFound = false;
            }
            finally
            {
                connection.Close();
            }

            return ISFound;
        }
        public static byte CountDepartments()
        {
            byte FieldOfSportTypes = 0;

            SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString);

            string query = @"select Count(*) from Departments";


            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if(result != null && ( byte.TryParse(result.ToString(), out byte CountResult) ))
                {
                    FieldOfSportTypes = CountResult;
                }
            }

            catch
            {
                FieldOfSportTypes = 0;
            }
            finally
            {
                connection.Close();
            }

            return FieldOfSportTypes;


        }




        public static List<string> GetDepartmentNames()
        {
            var departmentNames = new List<string>();

            using(SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString))
            using(SqlCommand command = new SqlCommand("SP_GetAllDepartments", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        departmentNames.Add(reader.GetString(0));
                    }
                }
            }

            return departmentNames;
        }





        public static DataView GetDepartmentTable()
        {
            DataTable datatable = new DataTable();
            DataView DepartmentsDataView = new DataView();


            SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString);

            string query = @"select * from Departments";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    datatable.Load(reader);
                    DepartmentsDataView = datatable.DefaultView;
                }

                reader.Close();
            }

            catch
            {
            }
            finally
            {
                connection.Close();
            }

            return DepartmentsDataView;
        }
        public static bool DeleteDepartment(int DepartmentID)
        {
            string DeleteQuery = @"delete from Departments
                                   where DepartmentID = @DepartmentID";

            SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString);

            SqlCommand command = new SqlCommand(DeleteQuery, connection);


            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);



            int EffectedRows = 0;
            try
            {
                connection.Open();

                EffectedRows = command.ExecuteNonQuery();

            }
            catch
            {
                EffectedRows = 0;
            }
            finally
            {
                connection.Close();
            }


            return ( EffectedRows > 0 );
        }
        static public bool FindDepartment(int DepartmentID, ref string DepartmentName)
        {
            bool ISFound = false;

            SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString);

            string query = @"select * from Departments
                             where DepartmentID = @DepartmentID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);


            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {

                    ISFound = true;

                    DepartmentName = Convert.ToString(reader["DepartmentName"]);

                }
                else
                {
                    ISFound = false;
                }

                reader.Close();

            }
            catch
            {
                ISFound = false;
            }
            finally
            {
                connection.Close();
            }


            return ISFound;
        }
        public static int AddDepartment(string DepartmentName)
        {
            int DepartmentID = 0;

            SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString);

            string query = @"insert into Departments(DepartmentName)
                            values
                            (@DepartmentName);
                            select SCOPE_IDENTITY()";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DepartmentName", DepartmentName);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if(Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    DepartmentID = insertedID;
                }


            }
            catch
            {
                DepartmentID = 0;
            }
            finally
            {
                connection.Close();
            }

            return DepartmentID;
        }

        public static bool UpdateDepartment(int DepartmentID, string DepartmentName)
        {
            string UpdateQuery = @"update Departments
                                    set
                                    DepartmentName = @DepartmentName
                                    where DepartmentID = @DepartmentID";

            SqlConnection connection = new SqlConnection(ClsSettingDA.ConnectionString);


            SqlCommand command = new SqlCommand(UpdateQuery, connection);


            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            command.Parameters.AddWithValue("@DepartmentName", DepartmentName);



            int EffectedRows = 0;

            try
            {
                connection.Open();

                EffectedRows = command.ExecuteNonQuery();

            }
            catch
            {
                EffectedRows = 0;
            }
            finally
            {
                connection.Close();
            }


            return ( EffectedRows > 0 );
        }





    }
}
