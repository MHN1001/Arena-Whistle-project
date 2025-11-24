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
using ControlLibrary.Helpers;
using ShowAllStadiums_ControlLibrary.Validations;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms_and_UserControls.Matches
{
    public partial class ShowCurrentMatchesTableForm : Form
    {
        public ShowCurrentMatchesTableForm()
        {
            InitializeComponent();
        }

        private void ShowCurrentMatchesTableForm_Load(object sender, EventArgs e)
        {
            uC_DGV1.ExecuteData(ClsMatch.GetCurrentMatchesListForAdmin());
            uC_DGV1.ControlContextMenuStripItemsVisibility(true, false, false, false, false, false);
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
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
                    ShowCurrentMatchTimeLeft timeLeftForm = new ShowCurrentMatchTimeLeft((startTime, EndTime), StadiumID.GetValueOrDefault(), bookingID.GetValueOrDefault());
                    timeLeftForm.MdiParent = this.MdiParent;
                    timeLeftForm.Show();
                    this.Close();
                }
                else
                {
                    GlobalMessages.ShowLoadingFailed();
                }
            }
        }

        private void uC_DGV1_OnCloseButtonClicked()
        {
            this.Close();
        }

        private void uC_DGV1_OnDGV_IsEmpty()
        {

        }
        private void uC_DGV1_Load(object sender, EventArgs e)
        {

        }


    }
}
