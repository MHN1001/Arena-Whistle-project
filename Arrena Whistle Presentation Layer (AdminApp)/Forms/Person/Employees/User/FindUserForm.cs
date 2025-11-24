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

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Person.Employees.User
{
    public partial class FindUserForm : Form
    {


        ClsUser _UserObj;

        public FindUserForm()
        {
            InitializeComponent();
        }



        private void FindUserForm_Load(object sender, EventArgs e)
        {
            BtnContinue.Visible = false;
            uC_FindUser1.Start();
        }

        private void uC_FindUser1_OnLoadingFailed()
        {
            _UserObj = null;
            BtnContinue.Visible = false;
        }

        private void uC_FindUser1_OnShowFullDataButtonClicked(Arena_Whistle_Buisness_layerm.ClsPerson obj)
        {
            ShowFullPersonDataForm showFullPersonDataForm = new ShowFullPersonDataForm(obj);
            showFullPersonDataForm.MdiParent = this.MdiParent;
            showFullPersonDataForm.Show();
        }

        private void uC_FindUser1_OnUserIsFoundSuccessfully(Arena_Whistle_Buisness_layer.ClsUser obj)
        {
            _UserObj = obj;
            
            BtnContinue.Visible = true;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            UpdateUserChoicesForm updateUserChoicesForm = new UpdateUserChoicesForm(_UserObj);
            updateUserChoicesForm.MdiParent = this.MdiParent;
            updateUserChoicesForm.Show();
            this.Close();
        }

        private void uC_FindUser1_OnExit()
        {
            this.Close();
        }

        private void uC_FindUser1_OnNotFound()
        {
            BtnContinue.Visible = false;
        }
    }
}
