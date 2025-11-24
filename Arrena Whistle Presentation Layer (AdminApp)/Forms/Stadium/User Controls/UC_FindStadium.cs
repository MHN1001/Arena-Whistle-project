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
using ShowAllStadiums_ControlLibrary;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Stadium.User_Controls
{
    public partial class UC_FindStadium : UserControl
    {
        public UC_FindStadium()
        {
            InitializeComponent();
        }



        public event Action<ClsStadium> OnStadiumFoundSuccessfully;
        protected virtual void StadiumFoundSuccessfully(ClsStadium StadiumObj)
        {
            Action<ClsStadium> Handler = OnStadiumFoundSuccessfully;

            if(Handler != null)
            {
                Handler(StadiumObj);
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



        public event Action<ClsStadium> OnShowFullDataButtonClicked;
        protected virtual void ShowFullDataButtonClicked(ClsStadium Stadium)
        {
            Action<ClsStadium> Handler = OnShowFullDataButtonClicked;

            if(Handler != null)
            {
                Handler(Stadium);
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




        private ClsStadium _StadiumObj;




        private void uC_StadiumInfosSummary1_Load(object sender, EventArgs e)
        {
        }
        private void UC_FindStadium_Load(object sender, EventArgs e)
        {
            PrepareFindControls();
        }
        private void uC_StadiumInfosSummary1_OnShowFullDataButtonClicked(ClsStadium obj)
        {
            if(OnShowFullDataButtonClicked != null)
                ShowFullDataButtonClicked(obj);
        }
        private void uC_StadiumInfosSummary1_OnLoadingFailed()
        {
            if(OnLoadingFailed != null) LoadingFailed();
        }
        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox.IsValid(ref e, errorProvider1, "Invalid Input");
        }
        private void cbFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbFinddBy.SelectedItem.ToString())
            {
                case "Stadium ID":
                {
                    TextBox.Clear();
                    TextBox.InputType = ShowAllStadiums_ControlLibrary.CustomTextBox.InputTypeEnum.NumberInput;
                    break;
                }
                case "Stadium Name":
                {
                    TextBox.Clear();
                    TextBox.InputType = ShowAllStadiums_ControlLibrary.CustomTextBox.InputTypeEnum.TextInput;
                    break;
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetStadiumObject();
        }






        private void CallOnExitEvent()
        {
            if(OnExit != null)
                Exit();
        }
        private void CallOnStadiumIsFound()
        {
            if(OnStadiumFoundSuccessfully != null)
                StadiumFoundSuccessfully(_StadiumObj);
        }
        private void GetStadiumObject()
        {
            if(! this.ValidateChildren()) return;

            switch(TextBox.InputType)
            {
                case ShowAllStadiums_ControlLibrary.CustomTextBox.InputTypeEnum.NumberInput:
                {
                    _StadiumObj = ClsStadium.FindStadium(Convert.ToInt32(TextBox.Text));
                    break;
                }
                case ShowAllStadiums_ControlLibrary.CustomTextBox.InputTypeEnum.TextInput:
                {
                    _StadiumObj = ClsStadium.FindStadiumByStadiumName(TextBox.Text);
                    break;
                }
            }

            if(_StadiumObj != null)
            {
                CallOnStadiumIsFound();
                uC_StadiumInfosSummary1.LoadStadiumDataByObj(_StadiumObj);
            }
            else
            {
                if(!GlobalMessages.NotFound())
                {
                    CallOnExitEvent();
                }
                else
                {
                    uC_StadiumInfosSummary1.ResetControls();
                    ClearTextBox();
                }
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
            cbFinddBy.Items.Add("Stadium ID");
            cbFinddBy.Items.Add("Stadium Name");
            cbFinddBy.SelectedIndex = 0; // default
        }

    }
}

