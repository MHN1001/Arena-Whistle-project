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
using Arrena_Whistle_Admin_Presentation_Layer.Forms.Clients;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Stadium
{
    public partial class AvailableStadiumsForm : Form
    {
        public AvailableStadiumsForm()
        {
            InitializeComponent();
        }

        private enum enCurrentOparetion { ReserveStadium, BookingStadium }
        private enCurrentOparetion currentOparetion;

        private (DataRowView Stadium, List<string> StadiumImages) _Stadium;

        private int _StadiumID;

        private void AvailableStadiumsForm_Load(object sender, EventArgs e)
        {
            uC_ShowStadiums1.Execute(ClsStadium.GetAvailableStadiums());
            uC_ShowStadiums1.ChangeTitle("Available Stadiums");

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uC_ShowStadiums1_OnLoadingFailed()
        {
            this.Close();
        }
        private void uC_ShowStadiums1_OnShowAsStadiumsAsATableButtonClicked(DataView obj)
        {
            ShowStadiumsAsTableForm showStadiumsAsTableForm = new ShowStadiumsAsTableForm(obj, "Available Stadiums");
            showStadiumsAsTableForm.MdiParent = this.MdiParent;
            showStadiumsAsTableForm.Show();
        }

        private void uC_ShowStadiums1_OnBookingNowButtonClicked(ShowAllStadiums_ControlLibrary.Stadiums.UC_ShowStadiums.TargetStadiumEventArgs obj)
        {
            currentOparetion = enCurrentOparetion.BookingStadium;

            this._Stadium.Stadium = obj.RowsStadiumsRow;
            this._Stadium.StadiumImages = obj.List_StadiumImages;

            CallFindClientForm();
        }

        private void uC_ShowStadiums1_OnReserveNowButtonClicked(int obj)
        {
            currentOparetion = enCurrentOparetion.ReserveStadium;
            this._StadiumID = obj;

            CallFindClientForm();
        }




        private void CallFindClientForm()
        {
            FindClientForm findClientForm = new FindClientForm();
            findClientForm.DataSent += GetTargetClientID;
            findClientForm.MdiParent = this.MdiParent;
            findClientForm.Show();
        }
        private void GetTargetClientID(ClsClient Client)
        {
            switch(currentOparetion)
            {
                case enCurrentOparetion.ReserveStadium:
                {
                    ReserveStadiumForm reserveStadiumForm = new ReserveStadiumForm(Client.ClientID, _StadiumID);
                    reserveStadiumForm.MdiParent = this.MdiParent;
                    reserveStadiumForm.Show();
                    break;
                }
                case enCurrentOparetion.BookingStadium:
                {
                    BookingStadiumForm bookingStadiumForm = new BookingStadiumForm(_Stadium, Client.ClientID);
                    this.MdiParent = this.MdiParent;
                    bookingStadiumForm.Show();
                    break;
                }
            }
        }

    }
}
