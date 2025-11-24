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
using ShowAllStadiums_ControlLibrary.Properties;
using TheArtOfDevHtmlRenderer.Adapters;
using ShowAllStadiums_ControlLibrary.Global_Util_Class;

namespace ShowAllStadiums_ControlLibrary.Person
{
    public partial class UC_showPersonCard : UserControl
    {
        public UC_showPersonCard()
        {
            InitializeComponent();
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

        private void UC_showPersonCard_Load(object sender, EventArgs e)
        {
        }

        private void _SetDefaultImageForPerson(string StrGender)
        {
            if(StrGender.ToUpper() == "MALE")
            {
                pbPersonImage.Image = Resources.Default_Male;
            }

            else
            {
                pbPersonImage.Image = Resources.Default_Femal;
            }
        }

        private void CallAllLoadingPersonDataFailedSubscribers()
        {
            //Tell All subscribers : there is failed loading  
            if(OnPersonDataLoadFailed != null)
                PersonDataLoadFailed();
        }

        private void RecenterLabel()
        {
            this.lblFullName.Left = Cls_UI_Utility.CenterLabel(lblFullName.Width, this.Width);
        }

        public void LoadPersonDataByID(int PersonID)
        {
            ClsPerson PersonObj = ClsPerson.FindPersonbyID(PersonID);

            if(PersonObj != null)
            {
                lblFullName.Text = PersonObj.FirstName + " " + PersonObj.LastName;
                RecenterLabel();


                txtGender.Text = PersonObj.Gender;

                txtBirthDate.Text = PersonObj.BirthDate.ToShortDateString();

                txtIDnumber.Text = PersonObj.IdentificationNumber;

                txtCountry.Text = PersonObj.CountryName;

                txtPhoneNumber1.Text = PersonObj.PhoneNumber1;


                if(PersonObj.PhoneNumber2 != null)
                {
                    txtPhoneNumber2.Text = PersonObj.PhoneNumber2;
                }
                else
                    txtPhoneNumber2.Text = "Empty";


                if(PersonObj.Email1 != null)
                {
                    txtEmail1.Text = PersonObj.Email1;
                }
                else
                    txtEmail1.Text = "Empty";

                if(PersonObj.Email2 != null)
                {
                    txtEmail2.Text = PersonObj.Email2;
                }
                else
                    txtEmail2.Text = "Empty";

                if(PersonObj.Adress != null)
                {
                    txtAdress1.Text = PersonObj.Adress;
                }
                else
                    txtAdress1.Text = "Empty";


                if(PersonObj.ImagePath != null)
                {
                    pbPersonImage.ImageLocation = PersonObj.ImagePath;
                }
                else
                {
                    _SetDefaultImageForPerson(PersonObj.Gender);
                }
            }
            else
            {
                CallAllLoadingPersonDataFailedSubscribers();
            }
        }

        public void LoadPersonDataByObject(ClsPerson Person)
        {

            if(Person != null)
            {
                lblFullName.Text = Person.FirstName + " " + Person.LastName;
                RecenterLabel();


                txtGender.Text = Person.Gender;

                txtBirthDate.Text = Person.BirthDate.ToShortDateString();

                txtIDnumber.Text = Person.IdentificationNumber;

                txtCountry.Text = Person.CountryName;

                txtPhoneNumber1.Text = Person.PhoneNumber1;


                if(Person.PhoneNumber2 != null)
                {
                    txtPhoneNumber2.Text = Person.PhoneNumber2;
                }
                else
                    txtPhoneNumber2.Text = "Empty";


                if(Person.Email1 != null)
                {
                    txtEmail1.Text = Person.Email1;
                }
                else
                    txtEmail1.Text = "Empty";

                if(Person.Email2 != null)
                {
                    txtEmail2.Text = Person.Email2;
                }
                else
                    txtEmail2.Text = "Empty";

                if(Person.Adress != null)
                {
                    txtAdress1.Text = Person.Adress;
                }
                else
                    txtAdress1.Text = "Empty";


                if(Person.ImagePath != null)
                {
                    pbPersonImage.ImageLocation = Person.ImagePath;
                }
                else
                {
                    _SetDefaultImageForPerson(Person.Gender);
                }
            }
            else
            {
                CallAllLoadingPersonDataFailedSubscribers();
            }
        }

    }
}
