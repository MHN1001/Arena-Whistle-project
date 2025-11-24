using System;
using Arena_Whistle_Buisness_layer;
using Arena_Whistle_Data_Access_Layer;


namespace Arena_Whistle_Buisness_layerm
{
    public class ClsPerson
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName()
        {
            return this.FirstName + " " + this.LastName;
        }
        public string Gender { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Adress { get; set; }
        public DateTime BirthDate { get; set; }
        public string CountryName { get; set; }
        public string IdentificationNumber { get; set; }
        public string ImagePath { get; set; }


        public enum SaveMode { Add, Update };
        public SaveMode _Mode;

        public ClsPerson()
        {
            this.PersonID = 0;
            this.FirstName = "";
            this.LastName = "";
            this.Gender = "";
            this.PhoneNumber1 = "";
            this.PhoneNumber2 = "";
            this.Email1 = "";
            this.Email2 = "";
            this.Adress = "";
            this.BirthDate = new DateTime();
            this.CountryName = "";
            this.IdentificationNumber = "";
            this.ImagePath = "";

            _Mode = SaveMode.Add;
        }
        protected ClsPerson(int PersonID, string FirstName, string LastName, string Gender,
                            string PhoneNumber1,
                            string PhoneNumber2,
                            string Email1,
                            string Email2,
                            string Adress,
                            DateTime BirthDate, string countryName, string IdentificationNumber,
                            string ImagePath)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.PhoneNumber1 = PhoneNumber1;
            this.PhoneNumber2 = PhoneNumber2;
            this.Email1 = Email1;
            this.Email2 = Email2;
            this.Adress = Adress;
            this.BirthDate = BirthDate;
            this.CountryName = countryName;
            this.IdentificationNumber = IdentificationNumber;
            this.ImagePath = ImagePath;

            _Mode = SaveMode.Update;
        }




        public static ClsPerson FindPersonbyID(int PersonID)
        {

            string FirstName = "", LastName = "", Gender = "", CountryName = "", PhoneNumber1 = ""
                  , PhoneNumber2 = "", Email1 = "", Email2 = " ", Adress = "", IdentificationNumber = "",
                   ImagePath = "";

            DateTime BirthDate = new DateTime();


            if(ClsPersonDA.FindPersonbyID(PersonID, ref FirstName, ref LastName,
                                          ref Gender, ref PhoneNumber1, ref PhoneNumber2,
                                          ref Email1, ref Email2, ref Adress,
                                          ref BirthDate, ref CountryName
                                         , ref IdentificationNumber
                                         , ref ImagePath))
            {


                return new ClsPerson(PersonID, FirstName, LastName, Gender, PhoneNumber1, PhoneNumber2
                                     , Email1, Email2, Adress, BirthDate, CountryName, IdentificationNumber
                                     , ImagePath);

            }
            else
                return null;
        }


        //public static ClsPerson FindPersonbyFullName(string FirstName, string LastName)
        //{
        //    int PersonID = 0;
        //    string Gender = "", IdentificationNumber = "", CountryName = "", PhoneNumber1 = "",
        //           PhoneNumber2 = "", Email1 = "", Email2 = " ", Adress = "",
        //           ImagePath = "";

        //    DateTime BirthDate = new DateTime();


        //    if(ClsPersonDA.FindPersonbyFullName(ref PersonID, FirstName.Trim(), LastName.Trim(),
        //                                  ref Gender, ref PhoneNumber1, ref PhoneNumber2,
        //                                  ref Email1, ref Email2, ref Adress,
        //                                  ref BirthDate, ref CountryName
        //                                 , ref IdentificationNumber
        //                                 , ref ImagePath))
        //    {


        //        return new ClsPerson(PersonID, FirstName, LastName, Gender, PhoneNumber1, PhoneNumber2
        //                             , Email1, Email2, Adress, BirthDate, CountryName, IdentificationNumber
        //                             , ImagePath);

        //    }
        //    else
        //        return null;
        //}
        //public static ClsPerson FindPersonbyIdentificationNumber(string IdentificationNumber)
        //{
        //    int PersonID = 0;
        //    string FirstName = "", LastName = "", Gender = "", CountryName = "", PhoneNumber1 = "",
        //           PhoneNumber2 = "", Email1 = "", Email2 = " ", Adress = "",
        //           ImagePath = "";

        //    DateTime BirthDate = new DateTime();


        //    if(ClsPersonDA.FindPersonbyIdentificationNumber(ref PersonID, ref FirstName, ref LastName,
        //                                  ref Gender, ref PhoneNumber1, ref PhoneNumber2,
        //                                  ref Email1, ref Email2, ref Adress,
        //                                  ref BirthDate, ref CountryName
        //                                 , IdentificationNumber
        //                                 , ref ImagePath))
        //    {


        //        return new ClsPerson(PersonID, FirstName, LastName, Gender, PhoneNumber1, PhoneNumber2
        //                             , Email1, Email2, Adress, BirthDate, CountryName, IdentificationNumber
        //                             , ImagePath);

        //    }
        //    else
        //        return null;
        //}
        //public static ClsPerson FindPersonbyPhoneNumber(string PhoneNumber)
        //{

        //    int PersonID = 0;
        //    string FirstName = "", LastName = "", Gender = "", CountryName = "",
        //           PhoneNumber1 = "", PhoneNumber2 = "", Email1 = "", Email2 = " ", Adress = "", IdentificationNumber = "",
        //           ImagePath = "";

        //    DateTime BirthDate = new DateTime();


        //    if(ClsPersonDA.FindPersonbyPhoneNumber(PhoneNumber, ref PersonID, ref FirstName, ref LastName,
        //                                  ref Gender, ref PhoneNumber1, ref PhoneNumber2,
        //                                  ref Email1, ref Email2, ref Adress,
        //                                  ref BirthDate, ref CountryName
        //                                 , ref IdentificationNumber
        //                                 , ref ImagePath))
        //    {


        //        return new ClsPerson(PersonID, FirstName, LastName, Gender, PhoneNumber, PhoneNumber2
        //                             , Email1, Email2, Adress, BirthDate, CountryName, IdentificationNumber
        //                             , ImagePath);

        //    }
        //    else
        //        return null;
        //}
        //public static ClsPerson FindPersonbyEmail(string Email)
        //{

        //    int PersonID = 0;
        //    string FirstName = "", LastName = "", Gender = "", CountryName = "", PhoneNumber1 = ""
        //          , PhoneNumber2 = "", Email1 = " ", Email2 = " ", Adress = "", IdentificationNumber = "",
        //           ImagePath = "";

        //    DateTime BirthDate = new DateTime();


        //    if(ClsPersonDA.FindPersonbyEmail(Email, ref PersonID, ref FirstName, ref LastName,
        //                                  ref Gender, ref PhoneNumber1, ref PhoneNumber2,
        //                                  ref Email1, ref Email2, ref Adress,
        //                                  ref BirthDate, ref CountryName
        //                                 , ref IdentificationNumber
        //                                 , ref ImagePath))
        //    {


        //        return new ClsPerson(PersonID, FirstName, LastName, Gender, PhoneNumber1, PhoneNumber2
        //                             , Email, Email2, Adress, BirthDate, CountryName, IdentificationNumber
        //                             , ImagePath);

        //    }
        //    else
        //        return null;
        //}




        protected bool _AddingPerson(int? ByUserID = null)
        {

            this.PersonID = ClsPersonDA.AddingPerson(this.FirstName, this.LastName, this.Gender,
                                                     this.PhoneNumber1, this.PhoneNumber2,
                                                     this.Email1, this.Email2,
                                                     this.Adress, this.BirthDate, this.CountryName,
                                                     this.IdentificationNumber, this.ImagePath, ByUserID);



            return ( this.PersonID > 0 );

        }
        protected bool _UpdatePerson(int? ByUserID = null)
        {
            if(ClsPersonDA.UpdatePersonInfo(this.PersonID, this.FirstName, this.LastName, this.Gender,
                                            this.PhoneNumber1, this.PhoneNumber2,
                                            this.Email1, this.Email2,
                                            this.Adress, this.BirthDate, this.CountryName,
                                            this.IdentificationNumber, this.ImagePath, ByUserID))
            {
                return true;
            }
            else { return false; }
        }
        public static bool DeletePerson(int PersonID, int? ByUserID = null)
        {
            return ( ClsPersonDA.DeletePersonInfos(PersonID, null) );
        }


        public static bool IsPersonExistByPersonID(int PersonID)
        {
            return ClsPersonDA.IsPersonEsxistByPersonID(PersonID);
        }
        public static bool GetPersonIDByIdentificationNumber(string IdentificationNumbe)
        {
            return ClsPersonDA.IsPersonExistByIdentificationNumber(IdentificationNumbe);
        }



        public bool savePerson()
        {
            switch(_Mode)
            {
                case SaveMode.Add:
                {
                    if(_AddingPerson())
                    {
                        _Mode = SaveMode.Update;
                        return true;
                    }
                    else
                        return false;
                }
                case SaveMode.Update:
                {
                    return _UpdatePerson();
                }
            }
            return false;
        }


        ~ClsPerson()
        {
        }
    }
}


