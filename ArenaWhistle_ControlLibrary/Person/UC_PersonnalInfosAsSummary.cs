using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arena_Whistle_Buisness_layerm;

namespace ShowAllStadiums_ControlLibrary.Person
{
    public partial class UC_PersonnalInfosAsSummary : UserControl
    {
        public UC_PersonnalInfosAsSummary()
        {
            InitializeComponent();
        }


        public bool ShowFullDataButton
        {
            get => ImgBtnShowFullInfos.Enabled;
            set => ImgBtnShowFullInfos.Enabled = value;
        }





        public event Action OnPersonDataLoadFailed;
        protected virtual void PersonDataLoadFailed()
        {
            Action Handler = OnPersonDataLoadFailed;

            if(Handler != null)
            {
                Handler();
            }
        }



        public event Action<ClsPerson> OnShowAllInfosButtonClick;
        protected virtual void ShowAllInfosButtonClick(ClsPerson personobj)
        {
            Action<ClsPerson> Handler = OnShowAllInfosButtonClick;

            if(Handler != null)
            {
                Handler(personobj);
            }
        }






        private ClsPerson PersonObj;

        private void ImgBShowFullInfos_Click(object sender, EventArgs e)
        {
            if(OnShowAllInfosButtonClick != null)
                ShowAllInfosButtonClick(PersonObj);
        }

        private void CallAllLoadingPersonDataFailedSubscribers()
        {
            //Tell All subscribers : there is failed loading  
            if(OnPersonDataLoadFailed != null)
                PersonDataLoadFailed();
        }

        public void LoadPersonData(int PersonID)
        {
            PersonObj = ClsPerson.FindPersonbyID(PersonID);

            if(PersonObj != null)
            {
                txtFullName.Text = PersonObj.FirstName + " " + PersonObj.LastName;

                txtBirthDate.Text = PersonObj.BirthDate.ToShortDateString();

                txtIDnumber.Text = PersonObj.IdentificationNumber ?? "Empty";

                txtPhoneNumber.Text = PersonObj.PhoneNumber1;

                ImgBtnShowFullInfos.Enabled = true;
            }
            else
            {
                ImgBtnShowFullInfos.Enabled = false;
                CallAllLoadingPersonDataFailedSubscribers();
            }
        }

        public void LoadPersonData(ClsPerson PersonObj)
        {
            this.PersonObj = PersonObj;

            if(PersonObj != null)
            {
                txtFullName.Text = PersonObj.FirstName + " " + PersonObj.LastName;

                txtBirthDate.Text = PersonObj.BirthDate.ToShortDateString();

                txtIDnumber.Text = PersonObj.IdentificationNumber ?? "Empty";

                txtPhoneNumber.Text = PersonObj.PhoneNumber1;

                ImgBtnShowFullInfos.Enabled = true;
            }
            else
            {
                ImgBtnShowFullInfos.Enabled = false;
                CallAllLoadingPersonDataFailedSubscribers();
            }
        }

        public void ResetData()
        {
            PersonObj = null;
            ShowPersonInfos("-", "-","-");
            ShowFullDataButton = false;                        
                                           
        }
        public void ShowPersonInfos(string fullName, string BirthDate, string phoneNumber)
        {
            txtFullName.Text = fullName;
            txtBirthDate.Text = BirthDate;
            txtIDnumber.Text = "-";
            txtPhoneNumber.Text = phoneNumber;
        }
    }
}
