using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arana_Whistle_Presentation_Layer.Forms.StadiumMenu
{
    public partial class ReserveStadiumForm : Form
    {
        public ReserveStadiumForm(int ClientID , int StadiumID)
        {
            InitializeComponent();

            this.StadiumID = StadiumID;
            this.ClientID = ClientID;
        }


        int ClientID ,  StadiumID;

        private void ReserveStadiumForm_Load(object sender, EventArgs e)
        {
            uC_ReserveStadium1.PassIdsForControls(ClientID , StadiumID, null);
            DisableShowAllInfosBtn();
        }





        private void DisableShowAllInfosBtn()
        {
            uC_ReserveStadium1.EnableBtnShowAllPersonIfos(false);
            uC_ReserveStadium1.EnableBtnShowAllStadiumInfos(false);
        }

        private void uC_ReserveStadium1_OnAddedFailed()
        {
        }

        private void uC_ReserveStadium1_OnAddedSuccessfully()
        {
            this.Close();
        }

        private void uC_ReserveStadium1_OnLoadFailed()
        {
            this.Close();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
