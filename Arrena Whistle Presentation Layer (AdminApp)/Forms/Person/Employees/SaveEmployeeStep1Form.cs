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
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Employees;
using Arrena_Whistle_Admin_Presentation_Layer.Global;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Person.Employees
{
    public partial class SaveEmployeeStep1Form : Form
    {

        public SaveEmployeeStep1Form(ClsEmployee _employeeObj = null, bool LastSavingStep = true)
        {
            InitializeComponent();

            this.LastSavingStep = LastSavingStep;
            this._employeeObj = _employeeObj;
        }

        bool LastSavingStep;
        private ClsEmployee _employeeObj;

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            SaveEmployeeStep2Form signUpForm2 = new SaveEmployeeStep2Form(_employeeObj, LastSavingStep);

            signUpForm2.MdiParent = this.MdiParent;
            signUpForm2.Show();
            this.Close();
        }

        private void SaveEmployeeStep1Form_Load(object sender, EventArgs e)
        {
            PrepareContinueButton();

            uC_SavePerson1.Start(_employeeObj);
            uC_SavePerson1.DestinationPath = ClsGlobal.DestinationFile;
        }


        private void uC_SavePerson1_OnUpdatedSuccessfully(Arena_Whistle_Buisness_layerm.ClsPerson obj)
        {
            this.Close();
        }

        private void uC_SavePerson1_OnPersonObjectPropertiesSavedSuccessfully(Arena_Whistle_Buisness_layerm.ClsPerson obj)
        {
            _employeeObj = (ClsEmployee)obj;
            this.btnContinue.Enabled = true;
        }







        private void PrepareContinueButton()
        {
            this.btnContinue.Enabled = false;

            if(_employeeObj != null)
                this.btnContinue.Visible = !LastSavingStep;

        }

    }
}
