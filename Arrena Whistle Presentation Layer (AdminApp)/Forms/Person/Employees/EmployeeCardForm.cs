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
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Employees.User_Controls;
using ControlLibrary.Helpers;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Employees
{
    public partial class EmployeeCardForm : Form
    {
        public EmployeeCardForm(ClsEmployee employee)
        {
            InitializeComponent();

            _employee = employee;
        }

        ClsEmployee _employee;

        private void EmployeeCardForm_Load(object sender, EventArgs e)
        {
            if(_employee == null)
            {
                GlobalMessages.ShowLoadingFailed();
                return;
            }

            uC_ShowEmployeeCard1.LoadEmployeeData(_employee);
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uC_ShowEmployeeCard1_OnLoadingFailed()
        {
            this.Close();
        }

        private void uC_ShowEmployeeCard1_OnShowAllPersonInfosButtonClicked(Arena_Whistle_Buisness_layerm.ClsPerson obj)
        {
            ShowFullPersonDataForm showFullPersonDataForm = new ShowFullPersonDataForm(obj);
            showFullPersonDataForm.MdiParent = this.MdiParent;
            showFullPersonDataForm.Show();
        }




    }
}
