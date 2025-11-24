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

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Stadium
{
    public partial class BookingStadiumForm : Form
    {
        public BookingStadiumForm((DataRowView Stadium, List<string> StadiumImages) Stadium, int ClientID)
        {
            InitializeComponent();

            this._Stadium = Stadium;
            this._ClientID = ClientID;
        }

        (DataRowView Stadium, List<string> StadiumImages) _Stadium;
        int _ClientID;

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookingStadiumForm_Load(object sender, EventArgs e)
        {
            uC_BookingStadiumProcess1.BindDataToControls(this._Stadium);
        }

        private void uC_BookingStadiumProcess1_OnAddedFailed()
        {

        }

        private void uC_BookingStadiumProcess1_OnAddedSucessfully()
        {
            this.Close();
        }

        private void uC_BookingStadiumProcess1_OnBookinButtonClicked()
        {
            uC_BookingStadiumProcess1.LocalVb.BookingObj.ResponsiblePlayerID = _ClientID;
            uC_BookingStadiumProcess1.LocalVb.ByUserID = Global.ClsGlobal.CurrentUser.UserID;

            uC_BookingStadiumProcess1.OnBookinButtonClicked -=  uC_BookingStadiumProcess1_OnBookinButtonClicked;
        }
    }
}
