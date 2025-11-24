using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arena_Whistle_Buisness_layerm;
using Arena_Whistle_Data_Access_Layer;

namespace Arena_Whistle_Buisness_layer
{
    public class ClsUser : ClsEmployee
    {

        public int UserID;
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permission { get; set; }





        // Default constructor
        public ClsUser() : base()
        {
            this.UserID = 0;
            this.UserName = string.Empty;
            this.Password = string.Empty;
        }

        // Full constructor
        protected ClsUser(int PersonID, string FirstName, string LastName, string Gender,
                          string PhoneNumber1,
                          string PhoneNumber2,
                          string Email1,
                          string Email2,
                          string Adress,
                          DateTime BirthDate, string CountryName, string IdentificationNumber,
                          string ImagePath,
                          int EmployeesID, string Department, DateTime HireDat, DateTime? ExitDate,
                          decimal Salary, EmployeeStatus Status,

                          int UserID, string UserName, string Password, int Permission)

                  : base
                  (PersonID, FirstName, LastName, Gender, PhoneNumber1, PhoneNumber2,
                   Email1, Email2, Adress, BirthDate, CountryName, IdentificationNumber, ImagePath,
                   EmployeesID, Department, HireDat, ExitDate, Salary, Status)
        {

            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.Permission = Permission;

        }

        public ClsUser(ClsEmployee emp) : base(emp)
        {
            this.UserID = 0;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.Permission = 0;

            _Mode = SaveMode.Add;
        }


        public static ClsUser FindUser(int UserID)
        {
            string Username = "", Password = "";
            int EmployeeID = 0, Permession = 0;


            if(ClsUserDA.FindUserByID(UserID, ref EmployeeID, ref Username, ref Password, ref Permession))
            {

                int PersonID = 0;
                string Department = "";
                DateTime HireDate = new DateTime();
                DateTime? ExitDate = null;
                decimal Salary = 0;

                int StatusID = 0;
                EmployeeStatus Status = EmployeeStatus.Non;


                if(ClsEmployeesDA.FindEmployeeByID(EmployeeID, ref PersonID, ref Department, ref HireDate,
                                                   ref ExitDate, ref Salary, ref StatusID))
                {

                    string FirstName = "", LastName = "", Gender = "", CountryName = "", PhoneNumber1 = ""
                          , PhoneNumber2 = "", Email1 = "", Email2 = " ", Adress = "", IdentificationNumber = "",
                           ImagePath = "";

                    DateTime BirthDate = new DateTime();

                    if(ClsPersonDA.FindPersonbyID(PersonID, ref FirstName, ref LastName,
                                                  ref Gender, ref PhoneNumber1, ref PhoneNumber2,
                                                  ref Email1, ref Email2, ref Adress,
                                                  ref BirthDate, ref CountryName
                                                 , ref IdentificationNumber
                                                 , ref ImagePath))
                    {

                        return new ClsUser(PersonID, FirstName, LastName, Gender, PhoneNumber1, PhoneNumber2,
                                           Email1, Email2, Adress, BirthDate, CountryName, IdentificationNumber,
                                           ImagePath, EmployeeID, Department, HireDate, ExitDate, Salary, Status
                                           , UserID, Username, Password, Permession);
                    }
                }
            }
            return null;
        }


        public static ClsUser FindUser(string UserName)
        {
            int UserID = 0;
            int EmployeeID = 0;
            string Password = "";
            int Permission = 0;

            // 1. Find the user by username
            if(ClsUserDA.FindUserByUserName(UserName, ref UserID, ref EmployeeID, ref Password, ref Permission))
            {
                int PersonID = 0;
                string Department = "";
                DateTime HireDate = new DateTime();
                DateTime? ExitDate = null;
                decimal Salary = 0;

                int StatusID = 0;
                EmployeeStatus Status = EmployeeStatus.Non;

                // 2. Find employee info
                if(ClsEmployeesDA.FindEmployeeByID(EmployeeID, ref PersonID, ref Department,
                                                   ref HireDate, ref ExitDate, ref Salary, ref StatusID))
                {
                    string FirstName = "", LastName = "", Gender = "", CountryName = "";
                    string PhoneNumber1 = "", PhoneNumber2 = "", Email1 = "", Email2 = "";
                    string Adress = "", IdentificationNumber = "", ImagePath = "";
                    DateTime BirthDate = new DateTime();

                    // 3. Find person info
                    if(ClsPersonDA.FindPersonbyID(PersonID, ref FirstName, ref LastName, ref Gender,
                                                  ref PhoneNumber1, ref PhoneNumber2, ref Email1, ref Email2,
                                                  ref Adress, ref BirthDate, ref CountryName,
                                                  ref IdentificationNumber, ref ImagePath))
                    {
                        // 4. Create and return the full user object
                        return new ClsUser(PersonID, FirstName, LastName, Gender, PhoneNumber1, PhoneNumber2,
                                           Email1, Email2, Adress, BirthDate, CountryName, IdentificationNumber,
                                           ImagePath, EmployeeID, Department, HireDate, ExitDate, Salary, Status,
                                           UserID, UserName, Password, Permission);
                    }
                }
            }

            return null;
        }



        public static ClsUser FindClientByUserNameAndPassword(string userName, string Pass)
        {

            int UserID = 0, EmployeeID = 0, Permession = 0;


            if(ClsUserDA.FindUserByUserNameAndPassword(ref UserID, ref EmployeeID, userName, Pass, ref Permession))
            {

                int PersonID = 0;
                string Department = "";
                DateTime HireDate = new DateTime();
                DateTime? ExitDate = null;
                decimal Salary = 0;

                int StatusID = 0;
                EmployeeStatus Status = EmployeeStatus.Non;


                if(ClsEmployeesDA.FindEmployeeByID(EmployeeID, ref PersonID, ref Department, ref HireDate,
                                                   ref ExitDate, ref Salary, ref StatusID))
                {

                    string FirstName = "", LastName = "", Gender = "", CountryName = "", PhoneNumber1 = ""
                          , PhoneNumber2 = "", Email1 = "", Email2 = " ", Adress = "", IdentificationNumber = "",
                           ImagePath = "";

                    DateTime BirthDate = new DateTime();

                    if(ClsPersonDA.FindPersonbyID(PersonID, ref FirstName, ref LastName,
                                                  ref Gender, ref PhoneNumber1, ref PhoneNumber2,
                                                  ref Email1, ref Email2, ref Adress,
                                                  ref BirthDate, ref CountryName
                                                 , ref IdentificationNumber
                                                 , ref ImagePath))
                    {

                        return new ClsUser(PersonID, FirstName, LastName, Gender, PhoneNumber1, PhoneNumber2,
                                           Email1, Email2, Adress, BirthDate, CountryName, IdentificationNumber,
                                           ImagePath, EmployeeID, Department, HireDate, ExitDate, Salary, Status
                                           , UserID, userName, Pass, Permession);
                    }
                }
            }
            return null;
        }









        public static DataView GetUserTable()
        {
            return ClsUserDA.GetUsersTable();
        }
        public bool AddingUser(int? CreatedByUserID)
        {
            int PersonID = 0, EmployeeID = 0;

            this.UserID = ClsUserDA.AddingUser(ref PersonID, this.FirstName, this.LastName, this.Gender, this.PhoneNumber1
                                              , this.PhoneNumber2, this.Email1, this.Email2, this.Adress, this.BirthDate
                                              , this.CountryName, this.IdentificationNumber, this.ImagePath,
                                             ref EmployeeID, this.Department, this.HireDate, this.ExitDate, this.Salary
                                              , (int)this.Status, this.UserName, ClsUtilB.ComputeHash(this.Password),
                                              this.Permission, CreatedByUserID);
            if(this.UserID > 0)
            {
                this.PersonID = PersonID;
                this.EmployeesID = EmployeesID;
                return true;
            }
            return false;
        }
        public bool UpdateUser(int? ModifiedByUserID = null)
        {
            return ClsUserDA.UpdateUser(this.PersonID, this.FirstName, this.LastName, this.Gender, this.PhoneNumber1
                                              , this.PhoneNumber2, this.Email1, this.Email2, this.Adress, this.BirthDate
                                              , this.CountryName, this.IdentificationNumber, this.ImagePath,
                                              this.EmployeesID, this.Department, this.HireDate, this.ExitDate, this.Salary
                                              , (int)this.Status, this.UserID, this.UserName, ModifiedByUserID);
        }
        public static bool DeleteUser(int UserID, int DeletedByUserID)
        {
            return ClsUserDA.DeleteUser(UserID, DeletedByUserID);
        }

        public static bool IsUserExist(int UserID)
        {
            return ClsUserDA.IsUserExist(UserID);
        }
        public static bool UpdatePassword(int UserID, string NewPassword, int ByUser)
        {
            return ClsUserDA.UpdatePassword(UserID, NewPassword, ByUser);
        }
        public static bool UpdatePermession(int UserID, int NewPermession, int ByUserID)
        {
            return ClsUserDA.UpdatePermession(UserID, NewPermession, ByUserID);
        }
        public static bool UpdateUserName(int UserID, string NewUserName, int ByUserID)
        {
            return ClsUserDA.UpdateUserName(UserID, NewUserName, ByUserID);
        }

        public static bool UpdateUserNameAndPAssword(int UserID, string NewUserName, string NewPassword, int ByUserID)
        {
            return ClsUserDA.UpdateUserCredentials(UserID, NewUserName, NewPassword, ByUserID);
        }



        public bool SaveUser(int? ByUserID = null)
        {
            switch(_Mode)
            {
                case SaveMode.Add:
                {
                    if(AddingUser(ByUserID))
                    {
                        _Mode = SaveMode.Update;
                        return true;
                    }
                    else
                        return false;
                }
                case SaveMode.Update:
                {
                    return UpdateUser(ByUserID);
                }
            }
            return false;
        }
    }
}
