using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arena_Whistle_Buisness_layer;
using Arena_Whistle_Buisness_layerm;
using ControlLibrary.Helpers;
using ShowAllStadiums_ControlLibrary.Properties;
using TheArtOfDevHtmlRenderer.Adapters;

namespace ShowAllStadiums_ControlLibrary.Person
{
    public partial class UC_SavePerson : UserControl
    {
        public UC_SavePerson()
        {
            InitializeComponent();
        }


        //event 
        public event Action OnPersonDataLoadFailed;
        protected virtual void PersonDataLoadFailed()
        {
            Action Handler = OnPersonDataLoadFailed;

            if(Handler != null)
            {
                Handler();
            }
        }


        public event Action<ClsPerson> OnPersonAddedSuccessfully;
        protected virtual void PersonAddedSuccessfully(ClsPerson PersonObj)
        {
            Action<ClsPerson> Handler = OnPersonAddedSuccessfully;
            if(Handler != null)
            {
                Handler(PersonObj);
            }
        }


        //Updated Successfully 
        public event Action<ClsPerson> OnUpdatedSuccessfully;
        protected virtual void UpdatedSuccessfully(ClsPerson PersonObj)
        {
            Action<ClsPerson> Handler = OnUpdatedSuccessfully;
            if(Handler != null)
            {
                Handler(PersonObj);
            }
        }



        public event Action<ClsPerson> OnPersonObjectPropertiesSavedSuccessfully;
        protected virtual void PersonObjectPropertiesSavedSuccessfully(ClsPerson PersonObj)
        {
            Action<ClsPerson> Handler = OnPersonObjectPropertiesSavedSuccessfully;
            if(Handler != null)
            {
                Handler(PersonObj);
            }
        }




        public int PersonID = 0;
        public ClsPerson PersonObj;
        public string DestinationPath;



        private ClsPerson.SaveMode _SaveMode = ClsPerson.SaveMode.Add;
        public ClsPerson.SaveMode SaveMode
        {
            get
            {
                return _SaveMode;
            }
            set
            {
                _SaveMode = value;

                switch(_SaveMode)
                {

                    case ClsPerson.SaveMode.Add:
                    {
                        lblTitle.Text = "ADD MODE";
                        break;
                    }

                    case ClsPerson.SaveMode.Update:
                    {
                        lblTitle.Text = "UPDATE MODE";
                        break;
                    }
                }
            }
        }

        private void UC_SavePerson_Load(object sender, EventArgs e)
        {
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            txtFirstName.IsValid(ref e, errorProvider1, "First Name Is Required !");
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            txtLastName.IsValid(ref e, errorProvider1, "Last Name Is Required !");
        }


        private void txtIdentificationNumber_Validating(object sender, CancelEventArgs e)
        {
            txtIdentificationNumber.IsValid(ref e, errorProvider1, "First Name Is Required !");
        }
        private void txtIdentificationNumber_TextChanged(object sender, EventArgs e)
        {
            txtIdentificationNumber.IsRequired = ChangeRequiredPropertyForTextBox(txtIdentificationNumber.Text);
        }
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            HandlingGenderChange();
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            HandlingGenderChange();
        }

        private void txtPhone1_Validating(object sender, CancelEventArgs e)
        {
            txtPhone1.IsValid(ref e, errorProvider1, "Phone number 1 Is Required !");
        }

        private void txtPhone2_Validating(object sender, CancelEventArgs e)
        {
            txtPhone2.IsValid(ref e, errorProvider1, "Phone numer 2 Should be digits !");
        }
        private void txtPhone2_TextChanged(object sender, EventArgs e)
        {
            txtPhone2.IsRequired = ChangeRequiredPropertyForTextBox(txtPhone2.Text);
        }

        private void txtEmail1_Validating(object sender, CancelEventArgs e)
        {
            txtEmail1.IsValid(ref e, errorProvider1, "Invalid Email Form");
        }
        private void txtEmail1_TextChanged(object sender, EventArgs e)
        {
            txtEmail1.IsRequired = ChangeRequiredPropertyForTextBox(txtEmail1.Text);
        }

        private void txtEmail2_Validating(object sender, CancelEventArgs e)
        {
            txtEmail2.IsValid(ref e, errorProvider1, "Invalid Email Form");
        }
        private void txtEmail2_TextChanged(object sender, EventArgs e)
        {
            txtEmail2.IsRequired = ChangeRequiredPropertyForTextBox(txtEmail2.Text);
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            GetImagePath();
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            RemoveImagePath();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePerson();
        }



        public void Start(ClsPerson PersonObj)
        {
            this.PersonObj = PersonObj;

            CheckSaveStatus(PersonObj);

            SetUpControls();

        }

        private bool IntializePersonObjectBeforSavingProcess()
        {
            PersonObj.FirstName = txtFirstName.Text.Trim();

            PersonObj.LastName = txtLastName.Text.Trim();

            if(rbMale.Checked)
                PersonObj.Gender = "Male";
            else
                PersonObj.Gender = "Female";

            PersonObj.BirthDate = dtpBirthDate.Value;

            if(!string.IsNullOrWhiteSpace(txtIdentificationNumber.Text))
                PersonObj.IdentificationNumber = txtIdentificationNumber.Text.Trim();
            else

                PersonObj.IdentificationNumber = string.Empty;

            PersonObj.CountryName = cbCountry.SelectedItem.ToString();

            PersonObj.PhoneNumber1 = txtPhone1.Text.Trim();

            if(!string.IsNullOrWhiteSpace(txtPhone2.Text))
                PersonObj.PhoneNumber2 = txtPhone2.Text.Trim();
            else
                PersonObj.PhoneNumber2 = string.Empty;

            if(!string.IsNullOrWhiteSpace(txtEmail1.Text))
                PersonObj.Email1 = txtEmail1.Text.Trim();
            else
                PersonObj.Email1 = string.Empty;


            if(!string.IsNullOrWhiteSpace(txtEmail2.Text))
                PersonObj.Email2 = txtEmail2.Text.Trim();
            else
                PersonObj.Email2 = string.Empty;

            if(!string.IsNullOrWhiteSpace(txtAdress1.Text))
                PersonObj.Adress = txtAdress1.Text.Trim();
            else
                PersonObj.Adress = string.Empty;

            return _HandlePersonImage();
        }

        private bool _HandlePersonImage()
        {
            if(PersonObj.ImagePath != pbPersonImage.ImageLocation)
            {
                if(!string.IsNullOrEmpty(PersonObj.ImagePath))
                {
                    //first we delete the old image from the folder.

                    try
                    {
                        File.Delete(PersonObj.ImagePath);
                        PersonObj.ImagePath = string.Empty;
                    }
                    catch(IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if(pbPersonImage.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if(ClsUtilB.CopyImageToProjectImagesFolder(ref SourceImageFile, DestinationPath))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        PersonObj.ImagePath = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }

            return true;
        }

        private void CallAddedSuccessfullySubscribers(ClsPerson personObj)
        {
            if(OnPersonAddedSuccessfully != null)
                PersonAddedSuccessfully(personObj);
        }
        private void CallUpdatedSuccessfullySubscribers(ClsPerson personObj)
        {
            if(OnUpdatedSuccessfully != null)
                UpdatedSuccessfully(personObj);
        }

        private void CallPersonObjectPropertiesSavedSuccessfully_EventSubsribers(ClsPerson personObj)
        {
            if(OnPersonObjectPropertiesSavedSuccessfully != null)
                PersonObjectPropertiesSavedSuccessfully(personObj);
        }
        private void EnableSaveButton(bool status)
        {
            btnSave.Enabled = status;
        }
        private void SavePerson()
        {
            if(!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                GlobalMessages.NotValid();
                return;
            }

            if(!GlobalMessages.Confirm("Are you Sure You want To Save ?")) return;



            if(!IntializePersonObjectBeforSavingProcess())
                return;



            bool _SavedSuccessfully = false;

            if(PersonObj._Mode == ClsPerson.SaveMode.Add)
            {

                EnableSaveButton(false);
                CallPersonObjectPropertiesSavedSuccessfully_EventSubsribers(PersonObj);


                return;
            }

            else if(PersonObj._Mode == ClsPerson.SaveMode.Update)
            {
                if(( _SavedSuccessfully = PersonObj.savePerson() ))
                {
                    CallUpdatedSuccessfullySubscribers(PersonObj);
                }
            }


            if(_SavedSuccessfully)
            {
                GlobalMessages.ShowSavingSuccess("Person Saved Successfully !");
            }
            else
            {
                 GlobalMessages.ShowSavingFailed();

            }

        }
        private void HandlingGenderChange()
        {
            if(pbPersonImage.ImageLocation == null)
            {
                if(rbMale.Checked)
                    _SetDefaultImageForPerson(rbMale);
                else
                    _SetDefaultImageForPerson(rbFemale);

            }
        }
        private void GetImagePath()
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbPersonImage.ImageLocation = openFileDialog1.FileName;

                btnDeleteImage.BringToFront();
            }
        }
        private void RemoveImagePath()
        {
            pbPersonImage.ImageLocation = null;

            HandlingGenderChange();

            btnSave.Focus(); // to avoid auto Focus

            btnDeleteImage.SendToBack();
        }
        private bool ChangeRequiredPropertyForTextBox(string TextBoxContent)
        {
            if(!string.IsNullOrWhiteSpace(TextBoxContent))
                return true;
            else
                return false;
        }
        private void SetInputRequirementForTextBoxes()
        {
            txtFirstName.IsRequired = true;
            txtLastName.IsRequired = true;
            txtIdentificationNumber.IsRequired = false;
            txtPhone1.IsRequired = true;
            txtPhone2.IsRequired = false;
            txtEmail1.IsRequired = false;
            txtEmail2.IsRequired = false;
            txtAdress1.IsRequired = false;
        }
        private void SetMaxValueForDtp()
        {
            dtpBirthDate.MaxDate = DateTime.Now.AddYears(-18);
        }
        private void FillCountryComboBoxInAddMode()
        {
            cbCountry.Items.Add("Morocco");
            cbCountry.SelectedIndex = 0;
        }
        private void FillControlsBySaveMode()
        {
            if(SaveMode == ClsPerson.SaveMode.Add)
            {
                FillCountryComboBoxInAddMode();
                SetMaxValueForDtp();
                rbMale.Checked = true;
                _SetDefaultImageForPerson(rbMale);
            }
            else
            {
                LoadPersonDataInUpdateMode();
            }
        }
        private void SetUpControls()
        {
            SetInputRequirementForTextBoxes();
            FillControlsBySaveMode();
            EnableSaveButton(true);
        }
        private void CallAllLoadingPersonDataFailedSubscribers()
        {
            //Tell All subscribers : there is failed loading  
            if(OnPersonDataLoadFailed != null)
                PersonDataLoadFailed();
        }
        private void DisableAllControls()
        {
            //Desable all Uc Controls to stop User Using it
            this.Enabled = false;
        }
        private void _SetDefaultImageForPerson(RadioButton radioButton)
        {
            if(radioButton == rbMale)
            {
                pbPersonImage.Image = Resources.Default_Male;
            }

            else if(radioButton == rbFemale)
            {
                pbPersonImage.Image = Resources.Default_Femal;
            }
        }
        private void LoadPersonDataInUpdateMode()
        {
            if(this._SaveMode == ClsPerson.SaveMode.Update)
            {
                txtFirstName.Text = PersonObj.FirstName;

                txtLastName.Text = PersonObj.LastName;


                txtIdentificationNumber.Text = PersonObj.IdentificationNumber;


                dtpBirthDate.Value = PersonObj.BirthDate;

                if(PersonObj.Gender.ToUpper() == "MALE")
                {
                    rbMale.Checked = true;
                }
                else
                    rbFemale.Checked = true;

                txtPhone1.Text = PersonObj.PhoneNumber1;


                txtPhone2.Text = PersonObj.PhoneNumber2;




                txtEmail1.Text = PersonObj.Email1;



                txtEmail2.Text = PersonObj.Email2;



                txtAdress1.Text = PersonObj.Adress;



                cbCountry.Items.Add(PersonObj.CountryName);
                cbCountry.SelectedItem = cbCountry.Items[0];



                if(PersonObj.ImagePath != null)
                {
                    pbPersonImage.ImageLocation = PersonObj.ImagePath;
                    btnDeleteImage.BringToFront();
                }
                else
                {
                    if(rbMale.Checked)
                        _SetDefaultImageForPerson(rbMale);
                    else
                        _SetDefaultImageForPerson(rbFemale);

                    btnAddImage.BringToFront();
                }

            }
        }

        private void CheckSaveStatus(ClsPerson Person)
        {
            if(PersonObj != null)
            {

                this.SaveMode = PersonObj._Mode;

                //else
                //{
                //    CallAllLoadingPersonDataFailedSubscribers();

                //    DisableAllControls();

                //    return false;
                //}
            }
            else
            {
                this.PersonObj = new ClsEmployee()  ;
                this.SaveMode = PersonObj._Mode;
            }
        }

    }
}
