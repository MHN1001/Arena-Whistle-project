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
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Users;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Employees
{
    public partial class SaveEmployeeStep2Form : Form
    {
        public SaveEmployeeStep2Form(ClsEmployee EmployeeObj, bool lastSavingStep)
        {
            InitializeComponent();

            this.EmployeeObj = EmployeeObj;
            this.LastSavingStep = lastSavingStep;
        }


        //public delegate void DataSentHandler();
        //public event DataSentHandler OnObjectIsNotFilled;

        //public delegate void DataSentHandler2();
        //public event DataSentHandler2 OnClientAddedSuccessfully;

        //public delegate void DataSentHandler3();
        //public event DataSentHandler3 OnAddingFailed;



        public bool LastSavingStep;

        private ClsEmployee EmployeeObj;


        private void SaveEmployeeStep2Form_Load(object sender, EventArgs e)
        {
            PrepareContinueButton();

            uc_SaveEmployee1.LastSavingStep = this.LastSavingStep;
            uc_SaveEmployee1.Start(EmployeeObj);

        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            SaveUserPermessionForm saveUserPermessionForm = new SaveUserPermessionForm(new ClsUser(this.EmployeeObj), LastSavingStep);
            saveUserPermessionForm.MdiParent = this.MdiParent;

            saveUserPermessionForm.Show();
            this.Close();
        }


        private void uc_SaveEmployee1_OnEmployeeObjectPropertiesSavedSuccessfully(ClsEmployee obj)
        {
            EmployeeObj = obj;
            ShowContinueBotton(true);

        }

        private void PrepareContinueButton()
        {
            this.btnContinue.Enabled = false;


            this.btnContinue.Visible = !LastSavingStep;
        }
        private void ShowContinueBotton(bool status)
        {
            btnContinue.Enabled = status;
        }

        private void uc_SaveEmployee1_OnSaveduccessfully(ClsEmployee obj)
        {
            this.Close();
        }

        private void uc_SaveEmployee1_OnDataLoadFailed()
        {
            this.Close();
        }

        private void uc_SaveEmployee1_OnSavingFailed()
        {
            //this.Close();
        }

        private void uc_SaveEmployee1_OnShowAllPersonInfosButtonClicked(Arena_Whistle_Buisness_layerm.ClsPerson obj)
        {
            ShowFullPersonDataForm showFullPersonData = new ShowFullPersonDataForm(obj);
            showFullPersonData.MdiParent = this.MdiParent;
            showFullPersonData.Show();
        }

    }
}
