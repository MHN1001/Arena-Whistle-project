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

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Users
{
    public partial class AddUserNameAndPasswordForm : Form
    {
        public AddUserNameAndPasswordForm(ClsUser user)
        {
            InitializeComponent();

            this.userobj = user;
        }

        ClsUser userobj;

        private void SaveUserStep2_Load(object sender, EventArgs e)
        {
            uc_AddUserNameAndPassword1.PassUserObj(userobj);
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uc_AddUserNameAndPassword1_OnAddingFailed()
        {
            //this.Close();
        }

        private void uc_AddUserNameAndPassword1_OnUserAddedSuccessfully(ClsUser obj)
        {
            this.Close();
        }
    }
}
