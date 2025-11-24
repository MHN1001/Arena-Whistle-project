using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms_and_UserControls.Matches
{
    public partial class ShowCurrentMatchTimeLeft : Form
    {
        public ShowCurrentMatchTimeLeft((string StartTime, string EndTime) MatchPeriodTime, int StadiumID, int BookingID)
        {
            InitializeComponent();

            this.MatchPeriodTime.StartTime = MatchPeriodTime.StartTime;
            this.MatchPeriodTime.EndTime = MatchPeriodTime.EndTime;

            this.StadiumID = StadiumID;
            this.BookingID = BookingID;
        }

        (string StartTime, string EndTime) MatchPeriodTime;
        int StadiumID, BookingID;

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uC_MatchTimeLeftOverView1_OnCurrentMatchIsDone()
        {
            this.Close();
        }

        private void uC_MatchTimeLeftOverView1_OnLoadingFailed()
        {
            this.Close();
        }

        private void ShowCurrentMatchTimeLeft_Load(object sender, EventArgs e)
        {
            uC_MatchTimeLeftOverView1.PassDataToControls(MatchPeriodTime, StadiumID, BookingID);
        }
    }
}
