using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Arena_Whistle_Data_Access_Layer;
using System.Data;
using Arena_Whistle_Buisness_layerm;

namespace Arena_Whistle_Buisness_layer
{
    public class ClsClient : ClsPerson
    {
        public int ClientID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }


        public ClsClient() : base()
        {
            this.ClientID = 0;
            this.UserName = "";
            this.Password = "";
            this.IsActive = true;
        }
        private ClsClient(int PersonID, string FirstName, string LastName, string Gender,
                                   string PhoneNumber1,
                                   string PhoneNumber2,
                                   string Email1,
                                   string Email2,
                                   string Adress,
                                   DateTime BirthDate, string countryName, string IdentificationNumber,
                                   string ImagePath,

                                   int ClientID, string userName, string password, bool IsActive)

                                   : base(PersonID, FirstName, LastName, Gender, PhoneNumber1, PhoneNumber2,
                                   Email1, Email2, Adress, BirthDate, countryName, IdentificationNumber, ImagePath)

        {
            this.ClientID = ClientID;
            this.UserName = userName;
            this.Password = password;
            this.IsActive = IsActive;
        }



        public static ClsClient FindClient(string userName)
        {
            int clientID = 0;
            int personID = 0;
            string password = "";
            bool isActive = false;

            // Call DL method
            if(ClsClientDA.FindClientByUserName(userName, ref clientID, ref personID, ref password, ref isActive))
            {
                // Prepare person data
                string firstName = "";
                string lastName = "";
                string gender = "";
                string countryName = "";
                string phoneNumber = "";
                string phoneNumber2 = "";
                string email = "";
                string email2 = "";
                string address = "";
                string identificationNumber = "";
                string imagePath = "";
                DateTime birthDate = default(DateTime);

                // Load person info using existing PersonDL
                if(ClsPersonDA.FindPersonbyID(personID, ref firstName, ref lastName, ref gender,
                                               ref phoneNumber, ref phoneNumber2, ref email, ref email2,
                                               ref address, ref birthDate, ref countryName, ref identificationNumber, ref imagePath))
                {
                    // Return fully constructed client
                    return new ClsClient(personID, firstName, lastName, gender, phoneNumber, phoneNumber2,
                                         email, email2, address, birthDate, countryName, identificationNumber,
                                         imagePath, clientID, userName, password, isActive);
                }
            }

            return null;
        }

        public static ClsClient FindClient(int ClientID)
        {
            string userName = "", Pass = "";
            int PersonID = 0;
            bool IsActive = false;

            if(ClsClientDA.FindClient(ClientID, ref userName, ref Pass, ref PersonID, ref IsActive))
            {


                string FirstName = "", LastName = "", Gender = "", CountryName = "", PhoneNumber1 = "",
                       PhoneNumber2 = "", Email1 = "", Email2 = " ", Adress = "", IdentificationNumber = "",
                       ImagePath = "";

                DateTime BirthDate = new DateTime();

                if(ClsPersonDA.FindPersonbyID(PersonID, ref FirstName, ref LastName,
                                              ref Gender, ref PhoneNumber1, ref PhoneNumber2,
                                              ref Email1, ref Email2, ref Adress,
                                              ref BirthDate, ref CountryName
                                             , ref IdentificationNumber
                                             , ref ImagePath))
                {

                    return new ClsClient(PersonID, FirstName, LastName, Gender, PhoneNumber1, PhoneNumber2,
                                                 Email1, Email2, Adress, BirthDate, CountryName, IdentificationNumber,
                                                 ImagePath, ClientID, userName, Pass, IsActive);

                }
            }
            return null;
        }
        public static ClsClient FindClientByUserNameAndPassword(string userName, string Pass)
        {
            int PersonID = 0;
            int ClientID = 0;
            bool IsActive = false;

            if(ClsClientDA.FindClientByUserNameAndPassword(ref ClientID, userName, Pass, ref PersonID, ref IsActive))
            {


                string FirstName = "", LastName = "", Gender = "", CountryName = "", PhoneNumber1 = "",
                       PhoneNumber2 = "", Email1 = "", Email2 = " ", Adress = "", IdentificationNumber = "",
                       ImagePath = "";

                DateTime BirthDate = new DateTime();

                if(ClsPersonDA.FindPersonbyID(PersonID, ref FirstName, ref LastName,
                                              ref Gender, ref PhoneNumber1, ref PhoneNumber2,
                                              ref Email1, ref Email2, ref Adress,
                                              ref BirthDate, ref CountryName
                                             , ref IdentificationNumber
                                             , ref ImagePath))
                {

                    return new ClsClient(PersonID, FirstName, LastName, Gender, PhoneNumber1, PhoneNumber2,
                                                 Email1, Email2, Adress, BirthDate, CountryName, IdentificationNumber,
                                                 ImagePath, ClientID, userName, Pass, IsActive);

                }
            }
            return null;
        }
        public static DataView GetClientsTable()
        {
            return ClsClientDA.GetClientsTable();
        }


        private bool AddClient(int? CreatedByUserID = null)
        {
            int PersonID = 0;

            this.ClientID = ClsClientDA.AddClient(ref PersonID, this.FirstName, this.LastName, this.Gender, this.PhoneNumber1
                                                , this.PhoneNumber2, this.Email1, this.Email2, this.Adress, this.BirthDate
                                                , this.CountryName, this.IdentificationNumber, this.ImagePath,
                                                   this.UserName, ClsUtilB.ComputeHash(this.Password), this.IsActive, CreatedByUserID);

            if(this.ClientID > 0)
            {
                this.PersonID = PersonID;
                return true;
            }
            return false;
        }
        private bool UpdateClient(int? UpdatedByUserID = null)
        {

            return ClsClientDA.UpdateClient(this.PersonID, this.FirstName, this.LastName, this.Gender, this.PhoneNumber1
                                      , this.PhoneNumber2, this.Email1, this.Email2, this.Adress, this.BirthDate
                                      , this.CountryName, this.IdentificationNumber, this.ImagePath,

                                        this.ClientID, this.UserName, this.Password, this.IsActive, UpdatedByUserID);

        }
        public static bool DeleteClient(int ClientID, int? DeletedByUserID = null)
        {
            return ClsClientDA.DeleteClient(ClientID, DeletedByUserID);
        }

        public static DataView GetClients(bool? isActive)
        {
            return ClsClientDA.GetClientsView(isActive);
        }

        public static bool IsClientExist(int ClientID)
        {
            return ClsClientDA.IsClientExist(ClientID);
        }

        public static bool UpdateClientNameAndPAssword(int ClientID, string NewUserName, string NewPassword, int? ByUserID)
        {
            return ClsClientDA.UpdateClientCredentials(ClientID, NewUserName, NewPassword, ByUserID);
        }


        public bool saveClient()
        {
            switch(_Mode)
            {
                case SaveMode.Add:
                {
                    if(AddClient())
                    {
                        _Mode = SaveMode.Update;
                        return true;
                    }
                    else
                        return false;
                }
                case SaveMode.Update:
                {
                    return UpdateClient();
                    ;
                }
            }
            return false;
        }
    }
}

