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

namespace Arana_Whistle_Presentation_Layer.Forms.StadiumMenu.Stadiums_Zone
{
    public partial class AvailableStadiumsForm : Form
    {
        public AvailableStadiumsForm()
        {
            InitializeComponent();
        }


        private void AvailableStadiumsForm_Load(object sender, EventArgs e)
        {
            uC_ShowAvailableStadiums.Execute(ClsStadium.GetAvailableStadiums());
            uC_ShowAvailableStadiums.ChangeTitle("Available Stadiums");
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uC_ShowAvailableStadiums_OnLoadingFailed()
        {
            this.Close();
        }

        private void uC_ShowAvailableStadiums_OnShowAsStadiumsAsATableButtonClicked(DataRowView obj)
        {
        }

        private void uC_ShowAvailableStadiums_OnReserveNowButtonClicked(int obj)
        {
            //obj = stadiumID
            ReserveStadiumForm reserveStadiumForm = new ReserveStadiumForm(Global.CurrentClient.ClientID, obj);
            this.Hide();
            reserveStadiumForm.ShowDialog();
            this.Show();
        }

        private void uC_ShowAvailableStadiums_OnBookingNowButtonClicked(ShowAllStadiums_ControlLibrary.Stadiums.UC_ShowStadiums.TargetStadiumEventArgs obj)
        {
            BookingStadiumProcessForm bookingStadium = new BookingStadiumProcessForm((obj.RowsStadiumsRow, obj.List_StadiumImages));
            bookingStadium.ShowDialog();

        }

        private void uC_ShowAvailableStadiums_OnShowAsStadiumsAsATableButtonClicked(DataView obj)
        {
            ShowAllStadiumsAsTableForm allStadiumsAsTableForm = new ShowAllStadiumsAsTableForm(obj, "Available Stadiums");
            this.Hide();
            allStadiumsAsTableForm.ShowDialog();
            this.Show();

        }
    }
}
