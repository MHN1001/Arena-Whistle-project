using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Stadium
{
    public partial class ReserveStadiumForm : Form
    {
        public ReserveStadiumForm(int ClientID, int StadiumID)
        {
            InitializeComponent();
            this.ClientID = ClientID;
            this.StadiumID = StadiumID;
        }

        int ClientID,  StadiumID;

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReserveStadiumForm_Load(object sender, EventArgs e)
        {
            uC_ReserveStadium1.PassIdsForControls(this.ClientID , this.StadiumID , Global.ClsGlobal.CurrentUser.UserID);
        }
    }
}
