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
using ShowAllStadiums_ControlLibrary.Validations;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Person.Employees.User
{
    public partial class ShowAllUsersForm : Form
    {
        public ShowAllUsersForm()
        {
            InitializeComponent();
        }

        private void ShowAllUsersForm_Load(object sender, EventArgs e)
        {
            uC_DGV1.ExecuteData(ClsUser.GetUserTable());
            uC_DGV1.ControlContextMenuStripItemsVisibility(false, false, true, true, true, false);
            uC_DGV1.SetTitle("All Users");
        }

        private void uC_DGV1_OnCloseButtonClicked()
        {
            this.Close();
        }

        private void uC_DGV1_OnAddTSMIclicked()
        {
            SaveUserStep1Form saveEmployeeForm1 = new SaveUserStep1Form(null, false);
            saveEmployeeForm1.MdiParent = this.MdiParent;
            saveEmployeeForm1.Show();
        }

        private void uC_DGV1_OnUpdateTSMIclicked(DataGridViewRow obj)
        {
            if(obj != null)
            {
                int? UserID = clsValidation.GetCellValueIfNotNull<int?>(obj, "UserID");


                if(UserID != null)
                {
                    ClsUser USEROBJ = ClsUser.FindUser(UserID.GetValueOrDefault());
                    if(USEROBJ != null)
                    {
                        UpdateUserChoicesForm _updateUserChoicesForm = new UpdateUserChoicesForm(USEROBJ);
                        _updateUserChoicesForm.MdiParent = this.MdiParent;
                        _updateUserChoicesForm.Show();
                        //this.Close();

                        return;
                    }

                }
                GlobalMessages.ShowLoadingFailed();
            }
        }

        private void uC_DGV1_OnDeleteTSMIclicked(DataGridViewRow obj)
        {
            int? USERID = clsValidation.GetCellValueIfNotNull<int?>(obj, "UserID");

            if(USERID != null)
            {

                if(ClsUser.DeleteUser(USERID.GetValueOrDefault(), Global.ClsGlobal.CurrentUser.UserID))
                {

                    if(uC_DGV1.DeleteTheTargetRow("UserID" , USERID))
                    {
                        GlobalMessages.DeletedSucessfully();

                        return;
                    }
                }
            }
            GlobalMessages.DeletedFailed();
        }

        private void uC_DGV1_Load(object sender, EventArgs e)
        {

        }
    }
}
