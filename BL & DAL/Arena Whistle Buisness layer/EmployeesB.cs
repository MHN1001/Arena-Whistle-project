using System;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Arena_Whistle_Buisness_layerm;
using Arena_Whistle_Data_Access_Layer;

namespace Arena_Whistle_Buisness_layer
{
    public class ClsEmployee : ClsPerson
    {

        public enum EmployeeStatus
        {
            Non = 1,
            Active,
            Inactive,
            OnLeave,
            Probation,
            Terminated
        }

        protected int EmployeesID { get; set; }
        public string Department { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public decimal Salary { get; set; }
        public EmployeeStatus Status { get; set; }


        public ClsEmployee() : base()
        {

            this.EmployeesID = 0;
            this.Department = "";
            this.HireDate = new DateTime();
            this.ExitDate = new DateTime();
            this.Salary = 0;
            this.Status = EmployeeStatus.Non;
        }

        protected ClsEmployee(int PersonID, string FirstName, string LastName, string Gender,
                            string PhoneNumber1,
                            string PhoneNumber2,
                            string Email1,
                            string Email2,
                            string Adress,
                            DateTime BirthDate, string countryName, string IdentificationNumber,
                            string ImagePath

                            , int EmployeesID, string Department, DateTime HireDat, DateTime? ExitDate, decimal Salary, EmployeeStatus Status)

                            : base(PersonID, FirstName, LastName, Gender, PhoneNumber1, PhoneNumber2,
                                   Email1, Email2, Adress, BirthDate, countryName, IdentificationNumber, ImagePath)
        {
            this.EmployeesID = EmployeesID;
            this.Department = Department;
            this.HireDate = HireDat;
            this.ExitDate = ExitDate;
            this.Salary = Salary;
            this.Status = Status;
        }


        public ClsEmployee(ClsEmployee emp) : base(emp.PersonID, emp.FirstName, emp.LastName, emp.Gender,
                                                   emp.PhoneNumber1, emp.PhoneNumber2,
                                                   emp.Email1, emp.Email2, emp.Adress,
                                                   emp.BirthDate, emp.CountryName, emp.IdentificationNumber, emp.ImagePath)
        {
            this.EmployeesID = emp.EmployeesID;
            this.Department = emp.Department;
            this.HireDate = emp.HireDate;
            this.ExitDate = emp.ExitDate;
            this.Salary = emp.Salary;
            this.Status = emp.Status;
        }





        public static ClsEmployee FindEmployee(int EmployeeID)
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
                Status = (EmployeeStatus)StatusID;

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


                    return new ClsEmployee(PersonID, FirstName, LastName, Gender, PhoneNumber1, PhoneNumber2
                                           , Email1, Email2, Adress, BirthDate, CountryName, IdentificationNumber
                                            , ImagePath, EmployeeID, Department, HireDate, ExitDate, Salary, Status);
                }
            }
            return null;
        }
        public static DataView GetEmployeeTable()
        {
            return ClsEmployeesDA.GetEmployeesTable();
        }
        public bool AddingEmployee(int CreatedByUserID)
        {
            int PersonID = 0;

            this.EmployeesID = ClsEmployeesDA.AddingEmployee(ref PersonID, this.FirstName, this.LastName, this.Gender, this.PhoneNumber1
                                                            , this.PhoneNumber2, this.Email1, this.Email2, this.Adress, this.BirthDate
                                                            , this.CountryName, this.IdentificationNumber, this.ImagePath,

                                                             this.Department, this.HireDate,
                                                             this.ExitDate, this.Salary, (int)this.Status, CreatedByUserID);


            if(this.EmployeesID > 0)
            {
                this.PersonID = PersonID;
                return true;
            }
            return false;

        }

        public bool UpdateEmployee(bool UpdatePerson, int UpdatedByUserID)
        {
            return ClsEmployeesDA.UpdateEmployee(this.PersonID, this.FirstName, this.LastName, this.Gender, this.PhoneNumber1
                                                , this.PhoneNumber2, this.Email1, this.Email2, this.Adress, this.BirthDate
                                                , this.CountryName, this.IdentificationNumber, this.ImagePath,

                                                  this.EmployeesID, this.Department, this.HireDate
                                                 , this.ExitDate, this.Salary, (int)this.Status, UpdatedByUserID);
        }


        public static bool DeleteEmployee(int EmployeeID, int DeleteByUserID)
        {
            return ClsEmployeesDA.DeleteEmployee(EmployeeID, DeleteByUserID);
        }



        public static int GetEmployeePersonID(int EmployeeID)
        {
            return ClsEmployeesDA.GetEmployeePersonID(EmployeeID);
        }
        public static bool ISEmployeeExist(int EmployeeID)
        {
            return ClsEmployeesDA.IsEmployeeExist(EmployeeID);
        }

    }
}
