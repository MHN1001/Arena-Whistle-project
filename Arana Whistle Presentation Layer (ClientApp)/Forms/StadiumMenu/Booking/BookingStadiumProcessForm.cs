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

namespace Arana_Whistle_Presentation_Layer.Forms.StadiumMenu
{
    public partial class BookingStadiumProcessForm : Form
    {
        public BookingStadiumProcessForm((DataRowView RowsStadiumsRow, List<string> List_StadiumsImages) Stadium)
        {
            InitializeComponent();

            this.Stadium = Stadium;
        }

        private (DataRowView RowsStadiumsRow, List<string> List_StadiumsImages) Stadium;

        private void BookingStadiumProcessForm_Load(object sender, EventArgs e)
        {
            uC_BookingStadiumProcess1.BindDataToControls(this.Stadium);

         }
        private void uC_BookingStadiumProcess1_Load(object sender, EventArgs e)
        {

        }

        private void uC_BookingStadiumProcess1_OnBookinButtonClicked()
        {
            uC_BookingStadiumProcess1.LocalVb.BookingObj.ResponsiblePlayerID = Global.CurrentClient.ClientID;

            uC_BookingStadiumProcess1.OnBookinButtonClicked -= uC_BookingStadiumProcess1_OnBookinButtonClicked;

        }

        private void uC_BookingStadiumProcess1_OnAddedSucessfully()
        {
            this.Close();
        }

        private void uC_BookingStadiumProcess1_OnAddedFailed()
        {
            this.Close();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
