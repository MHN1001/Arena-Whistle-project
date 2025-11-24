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

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Stadium
{
    public partial class ShowStadiumsAsTableForm : Form
    {
        public ShowStadiumsAsTableForm(DataView Stadiums, string title)
        {
            InitializeComponent();
            this._Stadiums = Stadiums;
            this._Title = title;
        }

        DataView _Stadiums;
        string _Title;

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowStadiumsAsTableForm_Load(object sender, EventArgs e)
        {
            uC_DGV1.ExecuteData(_Stadiums);
            uC_DGV1.ControlContextMenuStripItemsVisibility(false, false, true, true, true, false);
            uC_DGV1.SetTitle(_Title);
        }

        private void uC_DGV1_OnCloseButtonClicked()
        {
            this.Close();
        }

        private void uC_DGV1_OnAddTSMIclicked()
        {
            SaveStadiumForm saveStadiumForm = new SaveStadiumForm();
            saveStadiumForm.MdiParent = this.MdiParent;
            saveStadiumForm.Show();
        }

        private void uC_DGV1_OnUpdateTSMIclicked(DataGridViewRow obj)
        {
            SaveStadiumForm saveStadiumForm = new SaveStadiumForm(ClsStadium.FindStadium((int)obj.Cells["StadiumID"].Value));
            saveStadiumForm.MdiParent = this.MdiParent;
            saveStadiumForm.Show();
        }

        private void uC_DGV1_OnDeleteTSMIclicked(DataGridViewRow obj)
        {
            int? StadiumID = clsValidation.GetCellValueIfNotNull<int?>(obj, "StadiumID");

            if(StadiumID != null)
            {

                if(ClsStadium.DeleteStadium(StadiumID.GetValueOrDefault(), Global.ClsGlobal.CurrentUser.UserID))
                {

                    if(uC_DGV1.DeleteTheTargetRow<int?>("StadiumID", StadiumID))
                    {
                        GlobalMessages.DeletedSucessfully();

                        return;
                    }
                }
            }
            GlobalMessages.DeletedFailed();
        }

        private void uC_DGV1_Load(object sender, EventArgs e)
        {

        }
    }
}
