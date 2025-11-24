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

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms_and_UserControls.Clients
{
    public partial class ShowClientCardForm : Form
    {
        public ShowClientCardForm(ClsPerson person)
        {
            InitializeComponent();

            this._PersonObj = person;
        }
        ClsPerson _PersonObj;


        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowClientCardForm_Load(object sender, EventArgs e)
        {
            uC_showPersonCard1.LoadPersonDataByObject(_PersonObj);
        }

        private void uC_showPersonCard1_OnPersonDataLoadFailed()
        {
            this.Close();
         
        }
    }
}
