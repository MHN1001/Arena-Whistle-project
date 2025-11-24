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

namespace Arana_Whistle_Presentation_Layer.Forms.Login.Registry
{
    public partial class SignUpForm2 : Form
    {
        public SignUpForm2(ClsClient clientObj)
        {
            InitializeComponent();

            this.clientObj = clientObj;
        }

        public delegate void DataSentHandler();
        public event DataSentHandler OnObjectIsNotFilled;

        public delegate void DataSentHandler2();
        public event DataSentHandler2 OnClientAddedSuccessfully;

        public delegate void DataSentHandler3();
        public event DataSentHandler3 OnAddingFailed;


        private ClsClient clientObj;



        private void SignUpForm2_Load(object sender, EventArgs e)
        {
            if(!CheckClientObjectAfterContinue())
                this.Close();

            uc_AddUserNameAndPassword1.PassPersonObjForClientSavingProcess(clientObj);
        }
        private void uc_AddUserNameAndPassword1_OnClientAddedSuccessfully(ClsClient obj)
        {
            OnClientAddedSuccessfully?.Invoke();
            this.Close();

        }
        private void uc_AddUserNameAndPassword1_OnAddingFailed()
        {

            OnAddingFailed?.Invoke();
            this.Close();
        }





        private bool CheckClientObjectAfterContinue()
        {
            if(clientObj == null)
            {
                OnObjectIsNotFilled?.Invoke();
                MessageBox.Show("The Given Informations Is not Send Correctly", "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
