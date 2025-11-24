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
using ControlLibrary.Helpers;

namespace ShowAllStadiums_ControlLibrary.Global__User_Controls
{
    public partial class Uc_AddUserNameAndPassword : UserControl
    {
        public Uc_AddUserNameAndPassword()
        {
            InitializeComponent();
        }

        public event Action OnAddingFailed;
        protected virtual void AddingFailed()
        {
            Action Handler = OnAddingFailed;
            if(Handler != null)
            {
                Handler();
            }
        }



        public event Action<ClsClient> OnClientAddedSuccessfully;
        protected virtual void ClientAddedSuccessfully(ClsClient ClientObj)
        {
            Action<ClsClient> Handler = OnClientAddedSuccessfully;
            if(Handler != null)
            {
                Handler(ClientObj);
            }
        }


        public event Action<ClsUser> OnUserAddedSuccessfully;
        protected virtual void AddedUserSuccessfully(ClsUser UserObj)
        {
            Action<ClsUser> Handler = OnUserAddedSuccessfully;
            if(Handler != null)
            {
                Handler(UserObj);
            }
        }

        public enum SaveFor { Client, User }
        public SaveFor saveFor { get; set; } = SaveFor.Client;


        private ClsClient clientObj;
        private ClsUser UserObj;


        private void Uc_AddNewPassword_Load(object sender, EventArgs e)
        {

        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            txtUserName.IsValid(ref e, errorProvider1, "Username Is Required !");
        }
        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            txtPass.IsValid(ref e, errorProvider1, "Password Is Required !");
        }

        private void txtConfirmPass_Validating(object sender, CancelEventArgs e)
        {
            if(txtConfirmPass.IsValid(ref e, errorProvider1, "Confirm Password Is Required !"))
            {
                //if IsPasswordsMatches mathod return false then CancelEventArgs = true
                e.Cancel = !txtConfirmPass.IsPasswordsMatches(txtConfirmPass.Text, txtPass.Text,
                                                             errorProvider1,
                                                             "The Given Passwords is not matched !");
            }


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }





        private void Save()
        {
            if(!this.ValidateChildren())
            {
                GlobalMessages.NotValid();
                return;
            }

            bool _SavedSuccessfully = false;

            switch(saveFor)
            {
                case SaveFor.Client:
                {
                    _SavedSuccessfully = SaveProcessForClientObj();
                    break;
                }

                case SaveFor.User:
                {
                    _SavedSuccessfully = SaveProcessForUserObj();
                    break;
                }
            }

            if(_SavedSuccessfully)
            {

                OpenMessageBoxInSavedSucesssfulyCase();
                CallSavedSucessfullyEvent();
            }
            else
            {
                if(!GlobalMessages.ShowSavingFailed())
                {
                    CallOnAddingFailedEventSubscribers();
                }
            }
        }

        private void CallOnAddingFailedEventSubscribers()
        {
            if(OnAddingFailed != null)
                AddingFailed();
        }

        private void CallSavedSucessfullyEvent()
        {
            switch(saveFor)
            {
                case SaveFor.Client:
                {
                    CalOnlClientAddedSuccessfullyEventSubscribers(clientObj);
                    break;
                }
                case SaveFor.User:
                {
                    CallOnUserAddedSuccessfullyEventSubscribers(UserObj);
                    break;
                }
            }
        }
        private void CalOnlClientAddedSuccessfullyEventSubscribers(ClsClient ClientObj)
        {
            if(OnClientAddedSuccessfully != null)
                ClientAddedSuccessfully(ClientObj);
        }

        private void CallOnUserAddedSuccessfullyEventSubscribers(ClsUser UserObj)
        {
            if(OnUserAddedSuccessfully != null)
                AddedUserSuccessfully(UserObj);
        }
        private void OpenMessageBoxInSavedSucesssfulyCase()
        {
            switch(saveFor)
            {
                case SaveFor.Client:
                {
                    GlobalMessages.ShowSavingSuccess("Client Aaccout Has Beeen Saved Sucessfully");
                    break;
                }

                case SaveFor.User:
                {
                    GlobalMessages.ShowSavingSuccess("User Account Has Been Added Sucessfully");
                    break;
                }
            }
        }


        /// <summary>
        /// If return true means retry if false  close  form
        /// </summary>
        /// <returns></returns>

        private bool SaveProcessForClientObj()
        {
            clientObj.UserName = txtUserName.Text.Trim();
            clientObj.Password = txtConfirmPass.Text;


            if(clientObj._Mode == ClsClient.SaveMode.Add)
            {
                return clientObj.saveClient();

            }
            return false;
        }
        private bool SaveProcessForUserObj()
        {
            UserObj.UserName = txtUserName.Text.Trim();
            UserObj.Password = txtConfirmPass.Text;

            if(UserObj._Mode == ClsClient.SaveMode.Add)
            {
                return UserObj.SaveUser();
            }
            return false;
        }


        public void PassPersonObjForClientSavingProcess(ClsPerson personObj)
        {
            this.clientObj = (ClsClient)personObj;
            saveFor = SaveFor.Client;

        }

        public void PassUserObj(ClsUser UserObj)
        {
            this.UserObj = UserObj;
            saveFor = SaveFor.User;
        }

    }
}
