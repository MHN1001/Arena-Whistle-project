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

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Employees.User_Controls
{
    public partial class ShowFullPersonDataForm : Form
    {
        public ShowFullPersonDataForm(ClsPerson PersonID)
        {
            InitializeComponent();

            this._person = PersonID;
        }

        private  ClsPerson _person;

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uC_showPersonCard1_Load(object sender, EventArgs e)
        {
            uC_showPersonCard1.LoadPersonDataByObject(_person);

        }

        private void uC_showPersonCard1_OnPersonDataLoadFailed()
        {
            this.Close();
        }
    }
}
