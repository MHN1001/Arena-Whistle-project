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

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Person.Employees.User
{
    public partial class UC_FindUser : UserControl
    {
        public event Action<ClsUser> OnUserIsFoundSuccessfully;
        protected virtual void UserIsFoundSuccessfully(ClsUser UserObj)
        {
            Action<ClsUser> Handler = OnUserIsFoundSuccessfully;

            if(Handler != null)
            {
                Handler(UserObj);
            }
        }


        public event Action OnExit;
        protected virtual void Exit()
        {
            Action Handler = OnExit;

            if(Handler != null)
            {
                Handler();
            }
        }



        public event Action<ClsPerson> OnShowFullDataButtonClicked;
        protected virtual void ShowFullDataButtonClicked(ClsPerson PersonObj)
        {
            Action<ClsPerson> Handler = OnShowFullDataButtonClicked;

            if(Handler != null)
            {
                Handler(PersonObj);
            }
        }


        public event Action OnLoadingFailed;
        protected virtual void LoadingFailed()
        {
            Action Handler = OnLoadingFailed;

            if(Handler != null)
            {
                Handler();
            }
        }



        public event Action OnNotFound;
        protected virtual void NotFound()
        {
            Action Handler = OnNotFound;

            if(Handler != null)
            {
                Handler();
            }
        }



        public UC_FindUser()
        {
            InitializeComponent();
        }



        ClsUser UserObj;



        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetUserObject();
        }
        private void uC_ShowEmployeeCard1_OnLoadingFailed()
        {
            if(OnLoadingFailed != null) LoadingFailed();
        }
        private void uC_ShowEmployeeCard1_OnShowAllPersonInfosButtonClicked(Arena_Whistle_Buisness_layerm.ClsPerson obj)
        {
            if(OnShowFullDataButtonClicked != null)
                ShowFullDataButtonClicked(obj);
        }
        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox.IsValid(ref e, errorProvider1, "Invalid Input");
        }
        private void cbFinddBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbFinddBy.SelectedItem.ToString())
            {
                case "User ID":
                {
                    TextBox.Clear();
                    TextBox.InputType = ShowAllStadiums_ControlLibrary.CustomTextBox.InputTypeEnum.NumberInput;
                    break;
                }
                case "User Name":
                {
                    TextBox.Clear();
                    TextBox.InputType = ShowAllStadiums_ControlLibrary.CustomTextBox.InputTypeEnum.TextInput;
                    break;
                }
            }
        }












        public void Start()
        {
            PrepareFindControls();
        }
        private void CallOnExitEvent()
        {
            if(OnExit != null)
                Exit();
        }
        private void CallOnNotFoundEvent()
        {
            if(OnNotFound != null)
                NotFound();
        }
        private void CallOnStadiumIsFound()
        {
            if(OnUserIsFoundSuccessfully != null)
                UserIsFoundSuccessfully(UserObj);
        }
        private void GetUserObject()
        {
            if(!this.ValidateChildren()) return;

            UserObj = null;

            switch(TextBox.InputType)
            {
                case ShowAllStadiums_ControlLibrary.CustomTextBox.InputTypeEnum.NumberInput:
                {
                    UserObj = ClsUser.FindUser(Convert.ToInt32(TextBox.Text));
                    break;
                }
                case ShowAllStadiums_ControlLibrary.CustomTextBox.InputTypeEnum.TextInput:
                {
                    UserObj = ClsUser.FindUser(TextBox.Text.Trim());
                    break;
                }
            }

            if(UserObj != null)
            {
                CallOnStadiumIsFound();
                uC_ShowEmployeeCard1.LoadEmployeeData(UserObj);
            }
            else
            {
                if(!GlobalMessages.NotFound())
                {
                    CallOnExitEvent();
                }
                else
                {
                    uC_ShowEmployeeCard1.ResetControlsData();
                    ClearTextBox();
                }

                CallOnNotFoundEvent();
            }

        }
        private void ClearTextBox()
        {
            TextBox.Clear();
        }
        private void PrepareFindControls()
        {
            PrepareTextBox();
            PrepareComboBox();
        }
        private void PrepareTextBox()
        {
            TextBox.Clear();
            TextBox.InputType = ShowAllStadiums_ControlLibrary.CustomTextBox.InputTypeEnum.NumberInput;
            TextBox.IsRequired = true;
        }
        private void PrepareComboBox()
        {
            cbFinddBy.Items.Clear();
            cbFinddBy.Items.Add("User ID");
            cbFinddBy.Items.Add("User Name");
            cbFinddBy.SelectedIndex = 0; // default
        }

    }
}
