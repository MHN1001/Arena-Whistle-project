using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arena_Whistle_Data_Access_Layer;
using System.Data;

namespace Arena_Whistle_Buisness_layer
{
    public class ClsRefree : ClsEmployee
    {
        private int RefreeID { get; set; }

        public bool Available { get; set; }

        public ClsRefree() : base()
        {
            this.RefreeID = 0;
            this.Available = false;
        }

        protected ClsRefree(int PersonID, string FirstName, string LastName, string Gender,
                          string PhoneNumber1,
                          string PhoneNumber2,
                          string Email1,
                          string Email2,
                          string Adress,
                          DateTime BirthDate, string CountryName, string IdentificationNumber,
                          string ImagePath,
                          int EmployeesID, string Department, DateTime HireDat, DateTime? ExitDate,
                          decimal Salary, EmployeeStatus Status,
                          int RefreeID, bool Available)

                         : base
                         (PersonID, FirstName, LastName, Gender, PhoneNumber1, PhoneNumber2,
                          Email1, Email2, Adress, BirthDate, CountryName, IdentificationNumber, ImagePath,
                          EmployeesID, Department, HireDat, ExitDate, Salary, Status)
        {
            this.RefreeID = RefreeID;
            this.Available = Available;
        }



        public static DataView GetRefreesTable()
        {
            return ClsRefereeDA.GetRefreesTable();
        }
        public static ClsRefree FindRefrees(int RefreeID)
        {
            bool Available = false;
            int EmployeeID = 0;


            if(ClsRefereeDA.FindReferees(RefreeID, ref EmployeeID, ref Available))
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

                        return new ClsRefree(PersonID, FirstName, LastName, Gender, PhoneNumber1, PhoneNumber2,
                                           Email1, Email2, Adress, BirthDate, CountryName, IdentificationNumber,
                                           ImagePath, EmployeeID, Department, HireDate, ExitDate, Salary, Status
                                           , RefreeID, Available);
                    }
                }
            }
            return null;
        }
        protected bool AddRefrees(int? CreatedByUserID)
        {
            int PersonID = 0, EmployeeID = 0;

            this.RefreeID = ClsRefereeDA.AddReferee(ref PersonID, this.FirstName, this.LastName, this.Gender, this.PhoneNumber1
                                              , this.PhoneNumber2, this.Email1, this.Email2, this.Adress, this.BirthDate
                                              , this.CountryName, this.IdentificationNumber, this.ImagePath,
                                             ref EmployeeID, this.Department, this.HireDate, this.ExitDate, this.Salary
                                              , (int)this.Status, this.Available, CreatedByUserID);
            if(this.RefreeID > 0)
            {
                this.PersonID = PersonID;
                this.EmployeesID = EmployeesID;
                return true;
            }
            return false;

        }
        protected bool UpdateRefree(int? ModifiedByUserID = null)
        {
            return ClsRefereeDA.Updaterefree(this.PersonID, this.FirstName, this.LastName, this.Gender, this.PhoneNumber1
                                              , this.PhoneNumber2, this.Email1, this.Email2, this.Adress, this.BirthDate
                                              , this.CountryName, this.IdentificationNumber, this.ImagePath,
                                              this.EmployeesID, this.Department, this.HireDate, this.ExitDate, this.Salary
                                              , (int)this.Status, this.RefreeID, this.Available, ModifiedByUserID);
        }
        public static bool DeleteRefrees(int RefreeID, int DeletedByUserID)
        {
            return ClsRefereeDA.DeleteReferee(RefreeID, DeletedByUserID);
        }
        public static int? GetAvailableRefreeID()
        {
            return ClsRefereeDA.GetAvailableRefereeID();
        }
        public bool SaveRefree(int? ByUserID = null)
        {
            switch(_Mode)
            {
                case SaveMode.Add:


                if(AddRefrees(ByUserID))
                {
                    _Mode = SaveMode.Update;
                    return true;
                }
                else
                    return false;

                case SaveMode.Update:
                {
                    return UpdateRefree(ByUserID);
                }

            }
            return false;
        }
    }

}






