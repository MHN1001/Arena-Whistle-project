using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arena_Whistle_Data_Access_Layer;

namespace Arena_Whistle_Buisness_layer
{
    public class ClsDepartment
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        private enum _EnMode { Add, Update }
        private _EnMode mode;

        public ClsDepartment()
        {
            this.DepartmentID = 0;
            this.DepartmentName = "";

            mode = _EnMode.Add;
        }

        private ClsDepartment(int DepartmentID, string DepartmentName)
        {
            this.DepartmentID = DepartmentID;
            this.DepartmentName = DepartmentName;


            mode = _EnMode.Update;
        }



        public static bool IsDepartmentExist(int DepartmentID)
        {
            return ClsDepartmentDA.IsDepartmentExist(DepartmentID);
        }


        public static byte CountDepartments()
        {
            return ClsDepartmentDA.CountDepartments();
        }

        public static DataView GetDepartmentTable()
        {
            return ClsDepartmentDA.GetDepartmentTable();
        }

        public static List<string> GetDepartmentNames()
        {
            return ClsDepartmentDA.GetDepartmentNames();
        }


        public static ClsDepartment FindDepartment(int DepartmentID)
        {
            string DepartmentName = "";

            if(ClsDepartmentDA.FindDepartment(DepartmentID, ref DepartmentName)) ;
            {
                return new ClsDepartment(DepartmentID, DepartmentName);
            }
            return null;
        }

        public bool AddDepartment()
        {
            if(this.DepartmentName == "")
                return false;

            this.DepartmentID = ClsDepartmentDA.AddDepartment(this.DepartmentName);

            return this.DepartmentID > 0;
        }

        public bool UpdateDepartment()
        {
            return ClsDepartmentDA.UpdateDepartment(this.DepartmentID, this.DepartmentName);
        }
        public static bool DeleteDepartment(int DepartmentID)
        {
            return ClsDepartmentDA.DeleteDepartment(DepartmentID);
        }



        public bool save()
        {
            switch(mode)
            {
                case _EnMode.Add:
                {
                    if(AddDepartment())
                    {
                        mode = _EnMode.Update;
                        return true;
                    }
                    else
                        return false;
                }
                case _EnMode.Update:
                {
                    return UpdateDepartment();
                }
            }
            return false;
        }
    }
}
