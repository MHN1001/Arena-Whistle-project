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
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Person.Clients;
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Person.Employees;
using Arrena_Whistle_Admin_Presentation_Layer.Forms_and_UserControls.Clients;
using ControlLibrary.Helpers;
using ShowAllStadiums_ControlLibrary.Validations;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Employees
{
    public partial class ShowAllEmployeesForm : Form
    {
        public ShowAllEmployeesForm()
        {
            InitializeComponent();
        }

        private void ShowAllEmployeesForm_Load(object sender, EventArgs e)
        {
            uC_DGV1.ExecuteData(ClsEmployee.GetEmployeeTable());
            uC_DGV1.ControlContextMenuStripItemsVisibility(false, true, true, true, true, false);
            uC_DGV1.SetTitle("Employees");
        }

        private void uC_DGV1_OnShowAsSummaryTSMIclicked(DataGridViewRow obj)
        {
            if(obj != null)
            {
                int? EmployeeID = clsValidation.GetCellValueIfNotNull<int?>(obj, "EmployeeID");


                if(EmployeeID != null)
                {
                    ClsEmployee Employee = ClsEmployee.FindEmployee(EmployeeID.GetValueOrDefault());
                    if(Employee != null)
                    {
                        EmployeeCardForm employeeCard = new EmployeeCardForm(Employee);
                        employeeCard.MdiParent = this.MdiParent;
                        employeeCard.Show();
                        //this.Close();

                        return;
                    }

                }
                GlobalMessages.ShowLoadingFailed();
            }
        }

        private void uC_DGV1_OnCloseButtonClicked()
        {
            this.Close();
        }

        private void uC_DGV1_OnDeleteTSMIclicked(DataGridViewRow obj)
        {
            int? EmployeeID = clsValidation.GetCellValueIfNotNull<int?>(obj, "EmployeeID");

            if(EmployeeID != null)
            {

                if(ClsEmployee.DeleteEmployee(EmployeeID.GetValueOrDefault(), Global.ClsGlobal.CurrentUser.UserID))
                {

                    if(uC_DGV1.DeleteTheTargetRow("EmployeeID", EmployeeID))
                    {
                        GlobalMessages.DeletedSucessfully();

                        return;
                    }
                }
            }
            GlobalMessages.DeletedFailed();
        }

        private void uC_DGV1_OnAddTSMIclicked()
        {
            SaveEmployeeStep1Form saveEmployeeForm1 = new SaveEmployeeStep1Form( null ,true);
            saveEmployeeForm1.MdiParent = this.MdiParent;
            saveEmployeeForm1.Show();
        }

        private void uC_DGV1_OnUpdateTSMIclicked(DataGridViewRow obj)
        {
            if(obj != null)
            {
                int? EmployeeID = clsValidation.GetCellValueIfNotNull<int?>(obj, "EmployeeID");


                if(EmployeeID != null)
                {
                    ClsEmployee Employee = ClsEmployee.FindEmployee(EmployeeID.GetValueOrDefault());
                    if(Employee != null)
                    {
                        SaveEmployeeStep2Form SaveEmployeeStep2Form = new SaveEmployeeStep2Form(Employee, true);
                        SaveEmployeeStep2Form.MdiParent = this.MdiParent;
                        SaveEmployeeStep2Form.Show();
                        //this.Close();

                        return;
                    }

                }
                GlobalMessages.ShowLoadingFailed();
            }
        }

        private void uC_DGV1_Load(object sender, EventArgs e)
        {

        }
    }
}
