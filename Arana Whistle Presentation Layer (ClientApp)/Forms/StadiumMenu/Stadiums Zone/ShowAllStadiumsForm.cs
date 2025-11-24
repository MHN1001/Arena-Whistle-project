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
    public partial class ShowAllStadiumsForm : Form
    {
        public ShowAllStadiumsForm()
        {
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowAllStadiumsForm_Load(object sender, EventArgs e)
        {
            uC_ShowStadiums1.Execute(ClsStadium.GetAllStadiums());
            uC_ShowStadiums1.ChangeTitle("All Stadiums");
        }




        private void uC_ShowStadiums1_OnLoadingFailed()
        {
            this.Close();

        }

        private void uC_ShowStadiums1_OnBookingNowButtonClicked(ShowAllStadiums_ControlLibrary.Stadiums.UC_ShowStadiums.TargetStadiumEventArgs obj)
        {
            BookingStadiumProcessForm bookingStadium = new BookingStadiumProcessForm((obj.RowsStadiumsRow, obj.List_StadiumImages));
            this.Hide();
            bookingStadium.ShowDialog();
            this.Show();

        }

        private void uC_ShowStadiums1_OnReserveNowButtonClicked(int obj)
        {
            //obj = stadiumID
            ReserveStadiumForm reserveStadiumForm = new ReserveStadiumForm(Global.CurrentClient.ClientID, obj);
            this.Hide();
            reserveStadiumForm.ShowDialog();
            this.Show();
        }

    

        private void uC_ShowStadiums1_OnShowAsStadiumsAsATableButtonClicked(DataView obj)
        {
            ShowAllStadiumsAsTableForm allStadiumsAsTableForm = new ShowAllStadiumsAsTableForm(obj, "All Stadiums");
            this.Hide();
            allStadiumsAsTableForm.ShowDialog();
            this.Show();
        }
    }
}
