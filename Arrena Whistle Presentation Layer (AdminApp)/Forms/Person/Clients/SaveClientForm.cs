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


namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Clients
{
    public partial class SaveClientForm : Form
    {
        public SaveClientForm(ClsClient client)
        {
            InitializeComponent();
            this.client = client;
        }

        ClsClient client;

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveClientForm_Load(object sender, EventArgs e)
        {
            uC_SavePerson1.Start(client);
        }

        private void uC_SavePerson1_OnUpdatedSuccessfully(Arena_Whistle_Buisness_layerm.ClsPerson obj)
        {
            this.Close();

        }

        private void uC_SavePerson1_OnPersonDataLoadFailed()
        {
            this.Close();
        }

        private void uC_SavePerson1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
