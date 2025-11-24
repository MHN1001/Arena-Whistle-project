using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arana_Whistle_Presentation_Layer.Forms.Login.Registry;
using Arena_Whistle_Buisness_layer;
using Arena_Whistle_Buisness_layerm;
namespace Arana_Whistle_Presentation_Layer.Login.Registry
{
    public partial class SignUpForm1cs : Form
    {
        public SignUpForm1cs()
        {
            InitializeComponent();
        }

        private ClsClient _ClientObj;

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUpForm1cs_Load(object sender, EventArgs e)
        {
            uC_SavePerson1.Start(new ClsClient());
            uC_SavePerson1.DestinationPath = "C:\\Users\\Admin\\source\\repos\\Arena Whistle Project\\Arena Whistle Photos\\Client Images";
        }
        private void uC_SavePerson1_OnPersonObjectPropertiesSavedSuccessfully(Arena_Whistle_Buisness_layerm.ClsPerson obj)
        {
            _ClientObj = (ClsClient)obj;
            this.btnContinue.Enabled = true;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            SignUpForm2 signUpForm2 = new SignUpForm2(_ClientObj);
            signUpForm2.OnObjectIsNotFilled += SignUpForm2_OnObjectIsNotFille;
            signUpForm2.OnClientAddedSuccessfully += SignUpForm2_OnClientAddedSuccessfully;
            signUpForm2.OnAddingFailed += SignUpForm2_OnAddingFailed;
            signUpForm2.ShowDialog();
            this.Close();
        }


        private void SignUpForm2_OnObjectIsNotFille()
        {
            this.Show();
        }

        private void SignUpForm2_OnClientAddedSuccessfully()
        {
            this.Close();
        }
        private void SignUpForm2_OnAddingFailed()
        {
            this.Close();
        }

        private void uC_SavePerson1_Load(object sender, EventArgs e)
        {

        }
    }
}
