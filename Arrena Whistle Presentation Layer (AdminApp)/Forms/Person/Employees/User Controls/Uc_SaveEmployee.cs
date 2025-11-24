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
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Employees.User_Controls;
using ControlLibrary.Helpers;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Employees
{
    public partial class Uc_SaveEmployee : UserControl
    {
        public Uc_SaveEmployee()
        {
            InitializeComponent();
        }



        public event Action OnDataLoadFailed;
        protected virtual void DataLoadFailed()
        {
            Action Handler = OnDataLoadFailed;

            if(Handler != null)
            {
                Handler();
            }
        }


        public event Action OnSavingFailed;
        protected virtual void SavingFailed()
        {
            Action Handler = OnSavingFailed;

            if(Handler != null)
            {
                Handler();
            }
        }


        public event Action<ClsEmployee> OnSaveduccessfully;
        protected virtual void Saveduccessfully(ClsEmployee EmployeeObj)
        {
            Action<ClsEmployee> Handler = OnSaveduccessfully;
            if(Handler != null)
            {
                Handler(EmployeeObj);
            }
        }



        public event Action<ClsEmployee> OnEmployeeObjectPropertiesSavedSuccessfully;
        protected virtual void EmployeeObjectPropertiesSavedSuccessfully(ClsEmployee EmployeeObj)
        {
            Action<ClsEmployee> Handler = OnEmployeeObjectPropertiesSavedSuccessfully;
            if(Handler != null)
            {
                Handler(EmployeeObj);
            }
        }



        public event Action<ClsPerson> OnShowAllPersonInfosButtonClicked;
        protected virtual void ShowAllPersonInfosButtonClicked(ClsPerson PersonObj)
        {
            Action<ClsPerson> Handler = OnShowAllPersonInfosButtonClicked;
            if(Handler != null)
            {
                Handler(PersonObj);
            }
        }





        public bool LastSavingStep = true;
        private bool _UpdatePersonInfos = false;




        private ClsPerson.SaveMode _SaveMode = ClsPerson.SaveMode.Add;
        public ClsPerson.SaveMode SaveMode
        {
            get
            {
                return _SaveMode;
            }
            set
            {
                _SaveMode = value;

                switch(_SaveMode)
                {

                    case ClsPerson.SaveMode.Add:
                    {
                        lblTittle.Text = "ADD MODE";
                        break;
                    }

                    case ClsPerson.SaveMode.Update:
                    {
                        lblTittle.Text = "UPDATE MODE";
                        break;
                    }
                }
            }
        }






        private ClsEmployee _employeeObj;


        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveProcess();
        }
        private void ChbExited_CheckedChanged(object sender, EventArgs e)
        {
            dtpExitDate.Enabled = ChbExited.Checked;
        }

        private void txtSalary_Validating(object sender, CancelEventArgs e)
        {
            txtSalary.IsValid(ref e, errorProvider1, "Invalid Salary");
        }
        private void uC_PersonnalInfosAsSummary1_OnShowAllInfosButtonClick(ClsPerson obj)
        {
            if(OnShowAllPersonInfosButtonClicked != null)
                ShowAllPersonInfosButtonClicked(_employeeObj);
        }









        private void SaveProcess()
        {
            if(!IsValidateChildren())
            {
                GlobalMessages.NotValid();
                return;
            }

            if(_employeeObj._Mode == ClsPerson.SaveMode.Add)
            {
                    IntializeEmployeeObjectBeforAdding();

                if(LastSavingStep)
                {

                    if(_employeeObj.AddingEmployee(Global.ClsGlobal.CurrentUser.UserID))
                    {
                        GlobalMessages.ShowSavingSuccess();

                        CallSavedSucessfullyEvent();

                        uC_PersonnalInfosAsSummary1.LoadPersonData(_employeeObj.PersonID);

                        _SaveMode = ClsPerson.SaveMode.Update;

                        return;
                    }
                }
                else
                {
                    btnSave.Enabled = false;

                    if(OnEmployeeObjectPropertiesSavedSuccessfully != null)
                        EmployeeObjectPropertiesSavedSuccessfully(_employeeObj);


                    return;
                }
            }
            else if(_employeeObj._Mode == ClsPerson.SaveMode.Update)
            {
                IntializeEmployeeObjectBeforUpdating();

                if(_employeeObj.UpdateEmployee(_UpdatePersonInfos, Global.ClsGlobal.CurrentUser.UserID))
                {
                    GlobalMessages.ShowSavingSuccess();
                    CallSavedSucessfullyEvent();

                    return;
                }
            }


            GlobalMessages.ShowSavingFailed();
            CallSavedFailedEvent();
        }
        private void CallSavedFailedEvent()
        {
            if(OnSavingFailed != null)
                SavingFailed();
        }
        private void CallSavedSucessfullyEvent()
        {
            if(OnSaveduccessfully != null)
                Saveduccessfully(this._employeeObj);
        }
        private void IntializeEmployeeObjectBeforAdding()
        {
            _employeeObj.Department = cbDepartmeents.SelectedItem.ToString();
            _employeeObj.Salary = Convert.ToDecimal(txtSalary.Text);
            _employeeObj.Status = rbActive.Checked ? ClsEmployee.EmployeeStatus.Active : ClsEmployee.EmployeeStatus.Inactive;
            _employeeObj.HireDate = dtpHireDate.Value;
            _employeeObj.ExitDate = null;

        }

        private void IntializeEmployeeObjectBeforUpdating()
        {
            _employeeObj.Department = cbDepartmeents.SelectedItem.ToString();
            _employeeObj.Salary = Convert.ToDecimal(txtSalary.Text);
            _employeeObj.Status = rbActive.Checked ? ClsEmployee.EmployeeStatus.Active : ClsEmployee.EmployeeStatus.Inactive;
            _employeeObj.HireDate = dtpHireDate.Value;
            if(ChbExited.Checked) _employeeObj.ExitDate = dtpExitDate.Value;
            else _employeeObj.ExitDate = null;
        }

        private bool IsValidateChildren()
        {
            if(!this.ValidateChildren() || string.IsNullOrEmpty(cbDepartmeents.SelectedItem.ToString()))
                return false;
            else return true;
        }
        public void Start(ClsEmployee employee)
        {
            this._employeeObj = employee;

            if(!checkOject())
            {
                CallOnLoadingFailedEvent();

                return;
            }

            PrepareControls();
        }
        private void CallOnLoadingFailedEvent()
        {
            if(OnDataLoadFailed != null)
                DataLoadFailed();
        }
        private bool checkOject()
        {

            if(this._employeeObj != null)
                return true;
            else return false;
        }
        private void LoadEmployeeDataInUpdateMode()
        {
            cbDepartmeents.SelectedItem = _employeeObj.Department;
            txtSalary.Text = _employeeObj.Salary.ToString();

            dtpHireDate.MinDate = _employeeObj.HireDate;
            dtpHireDate.Value = dtpHireDate.MinDate;
            dtpHireDate.Enabled = false;

            if(_employeeObj.ExitDate != null)
            {
                ChbExited.Checked = true;
                ChbExited.Enabled = false;
                dtpExitDate.MinDate = _employeeObj.ExitDate.Value;
                dtpExitDate.MaxDate = _employeeObj.ExitDate.Value;
                dtpExitDate.Value = _employeeObj.ExitDate.Value;
                dtpExitDate.Enabled = false;
            }

            rbActive.Checked = _employeeObj.Status == ClsEmployee.EmployeeStatus.Active;
        }
        private void LoadEmployeeDataInAddMode()
        {
            txtSalary.Clear();

            if(cbDepartmeents.Items.Count > 0)
                cbDepartmeents.SelectedIndex = 0;

            dtpHireDate.MinDate = DateTime.Now;
            dtpHireDate.Value = DateTime.Now;

            dtpExitDate.MaxDate = DateTime.Now;
            dtpExitDate.Value = dtpExitDate.MinDate;

            rbActive.Checked = true;

            ChbExited.Checked = false;
            ChbExited.Enabled = false;

        }
        private void PrepareControls()
        {
            btnSave.Enabled = true;
            SaveMode = _employeeObj._Mode;

            IntializeDepartmentComboBox();

            switch(_employeeObj._Mode)
            {
                case ClsPerson.SaveMode.Add:
                {
                    LoadEmployeeDataInAddMode();

                    uC_PersonnalInfosAsSummary1.ShowPersonInfos(_employeeObj.FullName(),
                                        _employeeObj.BirthDate.ToShortDateString(),
                                        _employeeObj.PhoneNumber1);
                    uC_PersonnalInfosAsSummary1.ShowFullDataButton = false;
                    break;
                }

                case ClsPerson.SaveMode.Update:
                {
                    LoadEmployeeDataInUpdateMode();
                    uC_PersonnalInfosAsSummary1.LoadPersonData(_employeeObj.PersonID);
                    uC_PersonnalInfosAsSummary1.ShowFullDataButton = true;
                    break;
                }
            }




        }
        private void IntializeDepartmentComboBox()
        {
            cbDepartmeents.Items.Clear();

            List<string> departmentNames = ClsDepartment.GetDepartmentNames();

            foreach(string name in departmentNames)
            {
                cbDepartmeents.Items.Add(name);
            }
        }

        private void Uc_SaveEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
