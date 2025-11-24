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

namespace ShowAllStadiums_ControlLibrary.Global__User_Controls
{
    public partial class Uc_UpdateUserNameAndPassword : UserControl
    {
        public Uc_UpdateUserNameAndPassword()
        {
            InitializeComponent();
        }



        public event Action<string> OnUserNameisAvailable;
        protected virtual void UserNameisAvailable(string username)
        {
            Action<string> Handler = OnUserNameisAvailable;
            if(Handler != null)
            {
                Handler(username);
            }
        }

        public event Action OnUpdatingFailed;
        protected virtual void UpdatingFailed()
        {
            Action Handler = OnUpdatingFailed;
            if(Handler != null)
            {
                Handler();
            }
        }


        public event Action OnUpdatedSuccessfully;
        protected virtual void UpdatedSuccessfully()
        {
            Action Handler = OnUpdatedSuccessfully;
            if(Handler != null)
            {
                Handler();
            }
        }




        private void Uc_UpdateUserNameAndPassword_Load(object sender, EventArgs e)
        {
            uc_UpdatePassword1.EnableSavingButton(false);
        }
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if(txtUserName.IsValid(ref e, errorProvider1, "Username is requied !"))
            {
                uc_UpdatePassword1.PassUserName(txtUserName.Text);
                uc_UpdatePassword1.EnableSavingButton(true);
            }
            else
            {
                uc_UpdatePassword1.EnableSavingButton(false);
            }


        }
        private void uc_UpdatePassword1_OnUpdatingFailed()
        {
            if(OnUpdatingFailed != null)
                UpdatingFailed();
        }
        private void uc_UpdatePassword1_OnUpdatedSuccessfully()
        {
            if(OnUpdatedSuccessfully != null)
                UpdatedSuccessfully();

        }






        public void PassClientID(int clientID, int? ByUserID)
        {
            uc_UpdatePassword1.PassClientID(clientID, ByUserID);
        }
        public void PassUserID(int UserID, int ByUserID)
        {
            uc_UpdatePassword1.PassUserID(UserID, ByUserID);
        }
    }
}
