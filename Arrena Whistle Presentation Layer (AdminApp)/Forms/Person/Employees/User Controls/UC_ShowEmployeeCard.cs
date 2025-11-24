using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arena_Whistle_Buisness_layer;
using Arena_Whistle_Buisness_layerm;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms_and_UserControls.Employees
{
    public partial class UC_ShowEmployeeCard : UserControl
    {
        public UC_ShowEmployeeCard()
        {
            InitializeComponent();
        }

        public event Action OnLoadingFailed;
        protected virtual void LoadingFailed()
        {
            Action Handler = OnLoadingFailed;

            if(Handler != null)
            {
                Handler();
            }
        }



        public event Action<ClsPerson> OnShowAllPersonInfosButtonClicked;
        protected virtual void ShowAllPersonInfosButtonClicked(ClsPerson personobj)
        {
            Action<ClsPerson> Handler = OnShowAllPersonInfosButtonClicked;
            if(Handler != null)
            {
                Handler(personobj);
            }
        }

        private void UC_ShowEmployeeCard_Load(object sender, EventArgs e)
        {

        }

        private void uC_PersonnalInfosAsSummary1_OnShowAllInfosButtonClick(Arena_Whistle_Buisness_layerm.ClsPerson obj)
        {
            if(OnShowAllPersonInfosButtonClicked != null)
                ShowAllPersonInfosButtonClicked(obj);
        }


        public void LoadEmployeeData(ClsEmployee employee)
        {
            switch(employee._Mode)
            {
                case ClsPerson.SaveMode.Add:
                {
                    LoadEmployeeDataInAddMode(employee);
                    break;
                }
                case ClsPerson.SaveMode.Update:
                {
                    LoadEmployeeDataInUpdateMode(employee);

                    break;
                }
            }
        }

        private void LoadEmployeeDataInAddMode(ClsEmployee employee)
        {
            if(employee != null)
            {
                uC_PersonnalInfosAsSummary1.ShowPersonInfos(employee.FullName(),
                                        employee.BirthDate.ToShortDateString(),
                                        employee.PhoneNumber1);

                txtDepartments.Text = employee.Department;
                if(employee.ExitDate != null)
                    txtExitDate.Text = employee.ExitDate.Value.ToShortDateString();
                else
                    txtExitDate.Text = "-";
                txtHireDate.Text = employee.HireDate.ToShortDateString();
                txtSalary.Text = employee.Salary.ToString();
                txtStatus.Text = employee.Status.ToString();

                uC_PersonnalInfosAsSummary1.ShowFullDataButton = false;
            }
            else
            {
                if(OnLoadingFailed != null)
                    LoadingFailed();
            }
        }

        private void LoadEmployeeDataInUpdateMode(ClsEmployee employee)
        {
            if(employee != null)
            {
                uC_PersonnalInfosAsSummary1.LoadPersonData((ClsPerson)employee);

                txtDepartments.Text = employee.Department;
                if(employee.ExitDate != null)
                    txtExitDate.Text = employee.ExitDate.Value.ToShortDateString();
                else
                    txtExitDate.Text = "-";
                txtHireDate.Text = employee.HireDate.ToShortDateString();
                txtSalary.Text = employee.Salary.ToString();
                txtStatus.Text = employee.Status.ToString();

                uC_PersonnalInfosAsSummary1.ShowFullDataButton = true;

            }
            else
            {
                if(OnLoadingFailed != null)
                    LoadingFailed();
            }
        }
        public void ResetControlsData()
        {
            uC_PersonnalInfosAsSummary1.ResetData();
            
            txtExitDate.Text = "-";
            txtHireDate.Text = "-";
            txtSalary.Text = "-";
            txtStatus.Text = "-";
        }

        private void uC_PersonnalInfosAsSummary1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
