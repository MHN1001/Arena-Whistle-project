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
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Employees.User_Controls;
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Users;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Person.Employees.User
{
    public partial class UpdateUserChoicesForm : Form
    {
        public UpdateUserChoicesForm(ClsUser Targetuser)
        {
            InitializeComponent();

            this._TergetUser = Targetuser;
        }

        private ClsUser _TergetUser;

        private void btnUpdatePersonaInfos_Click(object sender, EventArgs e)
        {
            SaveUserStep1Form saveEmployeeForm1 = new SaveUserStep1Form(_TergetUser, true);
            saveEmployeeForm1.MdiParent = this.MdiParent;
            saveEmployeeForm1.Show();
            this.Close();
        }

        private void BtnUpdateEmployeeDetails_Click(object sender, EventArgs e)
        {
            SaveEmployeeStep2Form saveEmployeeStep2Form = new SaveEmployeeStep2Form(_TergetUser, true);
            saveEmployeeStep2Form.MdiParent = this.MdiParent;
            saveEmployeeStep2Form.Show();
            this.Close();
        }

        private void btnUpdatePermissions_Click(object sender, EventArgs e)
        {
            SaveUserPermessionForm saveUserPermessionForm = new SaveUserPermessionForm(_TergetUser, true);
            saveUserPermessionForm.MdiParent = this.MdiParent;
            saveUserPermessionForm.Show();
            this.Close();
        }

        private void UpdateUserChoicesForm_Load(object sender, EventArgs e)
        {
            if(_TergetUser != null)
                txtUserName.Text = _TergetUser.FullName();

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
