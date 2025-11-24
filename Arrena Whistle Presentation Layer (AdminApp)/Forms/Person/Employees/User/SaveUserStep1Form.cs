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

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Employees.User_Controls
{
    public partial class SaveUserStep1Form : Form
    {
        public SaveUserStep1Form(ClsEmployee _employeeObj = null, bool LastSavingStep = true)
        {
            InitializeComponent();
            this.LastSavingStep = LastSavingStep;
            this._employeeObj = _employeeObj;
        }

        bool LastSavingStep;
        private ClsEmployee _employeeObj;


        private void SaveEmployeeForm1_Load(object sender, EventArgs e)
        {
            PrepareContinueButton();

            uC_SavePerson1.Start(_employeeObj);
            uC_SavePerson1.DestinationPath = "C:\\Users\\Admin\\source\\repos\\Arena Whistle Project\\Arena Whistle Photos\\Employees Images";
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            SaveEmployeeStep2Form signUpForm2 = new SaveEmployeeStep2Form(_employeeObj, LastSavingStep);

            signUpForm2.MdiParent = this.MdiParent;
            signUpForm2.Show();
            this.Close();
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void uC_SavePerson1_OnPersonObjectPropertiesSavedSuccessfully_1(Arena_Whistle_Buisness_layerm.ClsPerson obj)
        {
            _employeeObj = (ClsEmployee)obj;
            this.btnContinue.Enabled = true;
        }







        private void PrepareContinueButton()
        {
            this.btnContinue.Enabled = false;



            this.btnContinue.Visible = !LastSavingStep;

        }

        private void uC_SavePerson1_OnUpdatedSuccessfully(ClsPerson obj)
        {
            this.Close();
        }
    }
}
