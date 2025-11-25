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
    public partial class Uc_UpdatePassword : UserControl
    {
        public Uc_UpdatePassword()
        {
            InitializeComponent();
        }

        //public event Action<string> AfterDataIsLoaded;
        //protected virtual void DataIsLoaded(string UserName)
        //{
        //    Action<string> Handler = AfterDataIsLoaded;
        //    if(Handler != null)
        //    {
        //        Handler(UserName);
        //    }
        //}

        public event Action OnSaveButtonClicked;
        protected virtual void SaveButtonClicked()
        {
            Action Handler = OnSaveButtonClicked;
            if(Handler != null)
            {
                Handler();
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


        public enum SaveFor { Client, User }
        public SaveFor saveFor { get; set; } = SaveFor.Client;


        //private ClsClient clientObj;
        //private ClsUser UserObj;
        private int UserID;
        private string CurrentUserPassword;
        private int ClientID;
        private string CurrentClientPassword;
        private string NewUserName;
        private string NewPassword;
        int? ByUserID;

        private void txtCurrentPass_Validating(object sender, CancelEventArgs e)
        {
            if(saveFor == SaveFor.Client)
            {
                e.Cancel = !txtCurrentPass.IsPasswordsMatches(ClsUtilB.ComputeHash(txtCurrentPass.Text), CurrentClientPassword,
                                                                errorProvider1,
                                                               "The Given Passwords is not matched with Account Password !");

            }
            else
            {
                e.Cancel = !txtCurrentPass.IsPasswordsMatches(ClsUtilB.ComputeHash(txtCurrentPass.Text), CurrentUserPassword,
                                                           errorProvider1,
                                                          "The Given Passwords is not matched with Account Password !");
            }
        }

        private void txtNewPass_Validating(object sender, CancelEventArgs e)
        {
            txtNewPass.IsValid(ref e, errorProvider1, "Password Is Required !");
        }

        private void txtConfirmPass_Validating(object sender, CancelEventArgs e)
        {
            if(txtConfirmPass.IsValid(ref e, errorProvider1, "Confirm Password Is Required !"))
            {
                //if IsPasswordsMatches mathod return false then CancelEventArgs = true
                e.Cancel = !txtConfirmPass.IsPasswordsMatches(txtConfirmPass.Text, txtNewPass.Text,
                                                             errorProvider1,
                                                             "The Given Passwords is not matched !");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            CallOnSaveButtonClickedEventSubscribers();
            Save();
        }


















        private void CallOnSaveButtonClickedEventSubscribers()
        {
            if(OnSaveButtonClicked != null)
                SaveButtonClicked();
        }
        private void ClearAllTexBoxes()
        {
            txtCurrentPass.Focus();

            //txtCurrentPass.Text = string.Empty;
            txtNewPass.Text = string.Empty;
            txtConfirmPass.Text = string.Empty;

        }
        private void Save()
        {
            bool Sucess = false;

            switch(saveFor)
            {
                case SaveFor.Client:
                {
                    Sucess = SaveProcessForClientObj();
                    break;
                }

                case SaveFor.User:
                {
                    Sucess = SaveProcessForUserObj();
                    break;
                }
            }

            if(Sucess)
                ClearAllTexBoxes();
        }
        private bool PerformValidateChildren()
        {
            if(!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void CallOnUpdatingFailedEventSubscribers()
        {
            if(OnUpdatingFailed != null)
                UpdatingFailed();
        }
        private void CallOnUpdatedSuccessfullyEventSubscribers()
        {
            if(OnUpdatedSuccessfully != null)
                UpdatedSuccessfully();
        }
        private bool SaveProcessForClientObj()
        {
            if(!PerformValidateChildren())
                return false;

            if(!GlobalMessages.Confirm("Are you Sure You want to Update ?")) return false;


             NewPassword = ClsUtilB.ComputeHash(txtConfirmPass.Text);

            bool _SavedSuccessfully = false;

            
                if(( _SavedSuccessfully = ClsClient.UpdateClientNameAndPAssword(ClientID, NewUserName,NewPassword, ByUserID) ))
                {
                    GlobalMessages.ShowSavingSuccess("UserName And Password Has been updated sucessfully !");
                    CallOnUpdatedSuccessfullyEventSubscribers();
                }
                else
                {
                    GlobalMessages.ShowSavingFailed();

                    CallOnUpdatingFailedEventSubscribers();
                }
            
            return _SavedSuccessfully;
        }
        private bool SaveProcessForUserObj()
        {
            if(!PerformValidateChildren())
                return false;

            if(!GlobalMessages.Confirm("Are you Sure You want to Update this password ?")) return false;



            NewPassword = ClsUtilB.ComputeHash(txtConfirmPass.Text);

            bool _SavedSuccessfully = false;

            if(( _SavedSuccessfully = ClsUser.UpdateUserNameAndPAssword(UserID, NewUserName, NewPassword, ByUserID.GetValueOrDefault()) ))
            {
                GlobalMessages.ShowSavingSuccess("UserName And Password Has been updated sucessfully !");
                CallOnUpdatedSuccessfullyEventSubscribers();
            }
            else
            {
                GlobalMessages.ShowSavingFailed();

                CallOnUpdatingFailedEventSubscribers();
            }
            return _SavedSuccessfully;
        }
        public void PassClientID(int ClientID, int? ByUserID)
        {
            this.ClientID = ClientID;
            this.CurrentClientPassword = ClsClient.FindClient(ClientID).Password;
            this.ByUserID = ByUserID;
            saveFor = SaveFor.Client;
        }
        public void PassUserID(int UserID, int ByUserID)
        {
            this.UserID = UserID;
            this.CurrentUserPassword = ClsUser.FindUser(UserID).Password;
            this.ByUserID = ByUserID;
            saveFor = SaveFor.User;
        }
        public void PassUserName(string UserName)
        {
            this.NewUserName = UserName;
        }
        public void EnableSavingButton(bool status)
        {
            btnSave.Enabled = status;
        }
    }
}
