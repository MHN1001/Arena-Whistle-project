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
using ControlLibrary.Helpers;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Employees.User
{
    public partial class UpdateUserNameAndPasswordForm : Form
    {
        public UpdateUserNameAndPasswordForm(ClsUser UserObj)
        {
            InitializeComponent();

            this.UserObj = UserObj;
        }


        ClsUser UserObj;

        private void UpdateUserNameAndPasswordForm_Load(object sender, EventArgs e)
        {
            if(! CheckUserObject()) return;

            uc_UpdateUserNameAndPassword1.PassUserID(UserObj.UserID, Global.ClsGlobal.CurrentUser.UserID);
        }

        private void uc_UpdateUserNameAndPassword1_OnUpdatedSuccessfully()
        {
            this.Close();
        }

        private void uc_UpdateUserNameAndPassword1_OnUpdatingFailed()
        {

        }

        private void uc_UpdateUserNameAndPassword1_OnUserNameisAvailable(string obj)
        {

        }







        private bool CheckUserObject()
        {
            if(UserObj == null)
            {
                GlobalMessages.ShowLoadingFailed();
                uc_UpdateUserNameAndPassword1.Enabled = false;
                return false;
            }

            return true;

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
