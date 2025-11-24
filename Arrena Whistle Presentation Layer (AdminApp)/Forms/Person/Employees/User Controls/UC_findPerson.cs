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

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Clients
{
    public partial class UC_findPerson : UserControl
    {

        public event Action<ClsClient> OnClientFoundSuccessfully;
        protected virtual void UserIsFoundSuccessfully(ClsClient ClientObj)
        {
            Action<ClsClient> Handler = OnClientFoundSuccessfully;

            if(Handler != null)
            {
                Handler(ClientObj);
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



        public event Action<ClsClient> OnShowFullDataButtonClicked;
        protected virtual void ShowFullDataButtonClicked(ClsClient ClientObj)
        {
            Action<ClsClient> Handler = OnShowFullDataButtonClicked;

            if(Handler != null)
            {
                Handler(ClientObj);
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


        public UC_findPerson()
        {
            InitializeComponent();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox.IsValid(ref e, errorProvider1, "Invalid Input");

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetClientObject();
        }

        private void cbFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbFinddBy.SelectedItem.ToString())
            {
                case "Client ID":
                {
                    TextBox.Clear();
                    TextBox.InputType = ShowAllStadiums_ControlLibrary.CustomTextBox.InputTypeEnum.NumberInput;
                    break;
                }
                case "Client User Name":
                {
                    TextBox.Clear();
                    TextBox.InputType = ShowAllStadiums_ControlLibrary.CustomTextBox.InputTypeEnum.TextInput;
                    break;
                }
            }
        }
        private void uC_PersonnalInfosAsSummary1_OnShowAllInfosButtonClick(Arena_Whistle_Buisness_layerm.ClsPerson obj)
        {
            if(OnShowFullDataButtonClicked != null)
            {
                ShowFullDataButtonClicked(client);
            }
        }

        private void uC_PersonnalInfosAsSummary1_OnPersonDataLoadFailed()
        {
            if(OnLoadingFailed != null)
                LoadingFailed();
        }





        ClsClient client;



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
            if(OnClientFoundSuccessfully != null)
                UserIsFoundSuccessfully(client);
        }
        private void GetClientObject()
        {
            if(!this.ValidateChildren()) return;

            client = null;

            switch(TextBox.InputType)
            {
                case ShowAllStadiums_ControlLibrary.CustomTextBox.InputTypeEnum.NumberInput:
                {
                    client = ClsClient.FindClient(Convert.ToInt32(TextBox.Text));
                    break;
                }
                case ShowAllStadiums_ControlLibrary.CustomTextBox.InputTypeEnum.TextInput:
                {
                    client = ClsClient.FindClient(TextBox.Text);
                    break;
                }
            }

            if(client != null)
            {
                CallOnStadiumIsFound();
                uC_PersonnalInfosAsSummary1.LoadPersonData(client);
            }
            else
            {
                if(!GlobalMessages.NotFound())
                {
                    CallOnExitEvent();
                }
                else
                {
                    uC_PersonnalInfosAsSummary1.ResetData();
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
            cbFinddBy.Items.Add("Client ID");
            cbFinddBy.Items.Add("Client User Name");
            cbFinddBy.SelectedIndex = 0; // default
        }

    }
}
