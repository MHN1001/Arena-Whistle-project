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
using Arrena_Whistle_Admin_Presentation_Layer.Forms_and_UserControls.Matches;
using ControlLibrary.Helpers;
using ShowAllStadiums_ControlLibrary.Validations;

namespace Arana_Whistle_Presentation_Layer.Forms.StadiumMenu.Matches
{
    public partial class CurrentMatchesAsTableForm : Form
    {
        public CurrentMatchesAsTableForm()
        {
            InitializeComponent();
        }

        private void CurrentMatchesAsTableForm_Load(object sender, EventArgs e)
        {
            uC_DGV1.ExecuteData(ClsMatch.GetCurrentMatchesTableForClient());
            uC_DGV1.ControlContextMenuStripItemsVisibility(true, false, false, false, false, false);
            uC_DGV1.SetTitle("Current Matches");
        }

        private void uC_DGV1_OnCloseButtonClicked()
        {
            this.Close();
        }

        private void uC_DGV1_OnShowTSMIclicked(DataGridViewRow obj)
        {
            if(obj != null)
            {
                string startTime = obj.Cells["StartTime"]?.Value?.ToString();
                string EndTime = obj.Cells["EndTime"]?.Value?.ToString();

                int? StadiumID = clsValidation.GetCellValueIfNotNull<int?>(obj, "StadiumID");
                int? bookingID = clsValidation.GetCellValueIfNotNull<int?>(obj, "BookingID");

                if(!string.IsNullOrEmpty(startTime) && !string.IsNullOrEmpty(EndTime) && StadiumID != null && bookingID != null)
                {
                    ShowCurrentMatchTimeLeftForm timeLeftForm = new ShowCurrentMatchTimeLeftForm((startTime, EndTime), StadiumID.GetValueOrDefault(), bookingID.GetValueOrDefault());
                    timeLeftForm.ShowDialog();
                }
                else
                {
                    GlobalMessages.ShowLoadingFailed();
                }
            }
        }

        private void uC_DGV1_Load(object sender, EventArgs e)
        {

        }
    }
}
