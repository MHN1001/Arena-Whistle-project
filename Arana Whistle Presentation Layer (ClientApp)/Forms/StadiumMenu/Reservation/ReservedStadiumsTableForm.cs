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

namespace Arana_Whistle_Presentation_Layer.Forms.StadiumMenu.Reservation
{
    public partial class ReservedStadiumsTableForm : Form
    {
        public ReservedStadiumsTableForm()
        {
            InitializeComponent();
        }

        private void ReservedStadiumsForm_Load(object sender, EventArgs e)
        {
            uC_DGV1.ExecuteData(ClsStadiumReservation.GetStadiumReservationTableForClient());
            uC_DGV1.ControlContextMenuStripItemsVisibility(false, false, false, false, false, false);
            uC_DGV1.SetTitle("Booked Stadiums");
        }
        private void uC_DGV1_OnCloseButtonClicked()
        {
            this.Close();
        }
    }
}
