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
using ShowAllStadiums_ControlLibrary.Global_Util_Class;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Users
{
    public partial class SaveUserPermessionForm : Form
    {
        public SaveUserPermessionForm(ClsUser user, bool lastSavingStep)
        {
            InitializeComponent();

            this.userObj = user;
            LastSavingStep = lastSavingStep;
        }

        ClsUser userObj;
        public bool LastSavingStep;


        private void SaveUserStep1_Load(object sender, EventArgs e)
        {
            PrepareContinueButton();

            uC_SaveUserPermissions1.Start(userObj, LastSavingStep);
        }

        private void uC_SaveUserPermissions1_OnShowAllPersonInfosButtonClicked(Arena_Whistle_Buisness_layerm.ClsPerson obj)
        {
            ShowFullPersonDataForm showFullPersonDataForm = new ShowFullPersonDataForm(obj);
            this.Hide();
            showFullPersonDataForm.ShowDialog();
            this.Show();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            AddUserNameAndPasswordForm addUserNameAndPasswordForm = new AddUserNameAndPasswordForm(userObj);
            addUserNameAndPasswordForm.MdiParent = this.MdiParent;
            addUserNameAndPasswordForm.Show();
            this.Close();
        }

        private void uC_SaveUserPermissions1_OnUserObjectPropertiesSavedSuccessfully(ClsUser obj)
        {
            this.userObj = obj;
            if(obj != null)
            {
                btnContinue.Enabled = true;
            }
        }
      
        private void uC_SaveUserPermissions1_OnLoadingFailed()
        {
            this.Close();
        }

        private void uC_SaveUserPermissions1_OnSavingFailed()
        {
            //this.Close();
        }

        private void uC_SaveUserPermissions1_OnSaveduccessfully(ClsUser obj)
        {
            this.Close();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        private void PrepareContinueButton()
        {
            this.btnContinue.Enabled = false;


            this.btnContinue.Visible = !LastSavingStep;
        }

    }
}
