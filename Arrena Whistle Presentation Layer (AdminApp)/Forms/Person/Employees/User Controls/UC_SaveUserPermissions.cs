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
using ShowAllStadiums_ControlLibrary.Global_Util_Class;
using ShowAllStadiums_ControlLibrary.Person;
using static Arena_Whistle_Buisness_layerm.ClsPerson;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Person.Employees.User
{
    public partial class UC_SaveUserPermissions : UserControl
    {
        public event Action OnLoadingFailed;
        protected virtual void LoadingFailed()
        {
            Action Handler = OnLoadingFailed;

            if(Handler != null)
            {
                Handler();
            }
        }


        public event Action OnSavingFailed;
        protected virtual void SavingFailed()
        {
            Action Handler = OnSavingFailed;

            if(Handler != null)
            {
                Handler();
            }
        }

        public event Action<ClsUser> OnSaveduccessfully;
        protected virtual void Saveduccessfully(ClsUser UserObj)
        {
            Action<ClsUser> Handler = OnSaveduccessfully;
            if(Handler != null)
            {
                Handler(UserObj);
            }
        }



        public event Action<ClsUser> OnUserObjectPropertiesSavedSuccessfully;
        protected virtual void UserObjectPropertiesSavedSuccessfully(ClsUser UserObj)
        {
            Action<ClsUser> Handler = OnUserObjectPropertiesSavedSuccessfully;
            if(Handler != null)
            {
                Handler(UserObj);
            }
        }


        public event Action<ClsPerson> OnShowAllPersonInfosButtonClicked;
        protected virtual void ShowAllPersonInfosButtonClicked(ClsPerson personobj)
        {
            Action<ClsPerson> Handler = OnShowAllPersonInfosButtonClicked;
            if(Handler != null)
            {
                Handler(personobj);
            }
        }






        public UC_SaveUserPermissions()
        {
            InitializeComponent();
        }


        ClsUser userObj;
        private Dictionary<byte, (string PermissionName, int PermissionValue)> _Permessions;
        private byte _PermessionIndex = 0;
        public bool LastSavingStep;

        private void uC_ShowEmployeeCard1_OnShowAllPersonInfosButtonClicked(Arena_Whistle_Buisness_layerm.ClsPerson obj)
        {
            if(OnShowAllPersonInfosButtonClicked != null)
                ShowAllPersonInfosButtonClicked(obj);
        }
        private void UC_SaveUserPermissions_Load(object sender, EventArgs e)
        {

        }
        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            if(rbYes.Checked) OnRbYesIsChecked();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(( _PermessionIndex++ ) >= _Permessions.Keys.Max())
            {
                btnNext.Click -= btnNext_Click;
                DisableChoosingPermessionsControls();

                return;
            }

            rbNo.Checked = true;
            UpdateCurrentPermessionTitle(_PermessionIndex);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveUser();
        }
        private void uC_ShowEmployeeCard1_OnLoadingFailed()
        {
            CallSavedFailedEvent();
        }







        public void SaveUser()
        {
            if(userObj._Mode == ClsPerson.SaveMode.Add)
            {

                if(LastSavingStep)
                {
                    if(userObj.AddingUser(Global.ClsGlobal.CurrentUser.UserID))
                    {
                        GlobalMessages.ShowSavingSuccess();
                        CallSavedSucessfullyEvent();

                        return;
                    }
                }
                else
                {
                    btnSave.Enabled = false;

                    if(OnUserObjectPropertiesSavedSuccessfully != null)
                        UserObjectPropertiesSavedSuccessfully(userObj);


                    return;
                }
            }
            else if(userObj._Mode == ClsPerson.SaveMode.Update)
            {
                if(ClsUser.UpdatePermession(userObj.UserID, userObj.Permission , (Global.ClsGlobal.CurrentUser.UserID) ))
                {
                    GlobalMessages.ShowSavingSuccess();
                    CallSavedSucessfullyEvent();

                    return;
                }
            }


            GlobalMessages.ShowSavingFailed();
            CallSavedFailedEvent();
        }
        private void CallSavedFailedEvent()
        {
            if(OnSavingFailed != null)
                SavingFailed();
        }
        private void CallLoadingFailedEvent()
        {
            if(OnLoadingFailed != null)
                LoadingFailed();
        }

        private void CallSavedSucessfullyEvent()
        {
            if(OnSaveduccessfully != null)
                Saveduccessfully(this.userObj);
        }
        public void Start(ClsUser userObj, bool LastSavingStep)
        {
            this.LastSavingStep = LastSavingStep;
            this.userObj = userObj;

            if(!CheckUserObject()) CallLoadingFailedEvent();


            PrepareControls();
            FillUserInfos();
        }
        private void FillUserInfos()
        {
            uC_ShowEmployeeCard1.LoadEmployeeData((ClsEmployee)userObj);
        }
        private void OnRbYesIsChecked()
        {
            if(_PermessionIndex == 0)
            {
                if(GlobalMessages.Confirm("Do You Want To Give Full Permission For This User ?"))
                {
                    userObj.Permission = _Permessions[_PermessionIndex].PermissionValue;
                    DisableChoosingPermessionsControls();
                }
                else
                {
                    rbNo.Checked = true;
                }
            }

            else if(_PermessionIndex > 0)
                userObj.Permission += _Permessions[_PermessionIndex].PermissionValue;
        }
        private void DisableChoosingPermessionsControls()
        {
            btnNext.Enabled = false;
            gbChoosingPermessions.Enabled = false;
        }
        private void PrepareControls()
        {
            gbChoosingPermessions.Enabled = true;
            btnNext.Enabled = true;
            LoadPermessions();
            SetTitlePosition();
        }
        private void LoadPermessions()
        {
            this._Permessions = PermessionB.GetPermissions();

            if(_Permessions.Keys.Count <= 0)
            {
                GlobalMessages.SomeThingWrong();
                //raise an event
            }

            _PermessionIndex = 0;

            UpdateCurrentPermessionTitle(_PermessionIndex);
        }
        private void SetTitlePosition()
        {
            lblTittle.Left = Cls_UI_Utility.CenterLabel(lblTittle.Width, this.Width);
        }
        private void UpdateCurrentPermessionTitle(byte PermessionIndex)
        {
            lblPermessionTitle.Text = _Permessions[PermessionIndex].PermissionName;
            lblPermessionTitle.Left = Cls_UI_Utility.CenterLabel(lblPermessionTitle.Width, gbPermessions.Width);
        }
        private bool CheckUserObject()
        {
            if(userObj == null)
            {
                GlobalMessages.ShowLoadingFailed();
                return false;
            }
            else { return true; }

        }

    }
}
