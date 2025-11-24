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
    public partial class FindStadiumForm : Form
    {
        public FindStadiumForm()
        {
            InitializeComponent();
        }

        ClsStadium TargetStadium;

        private void FindStadiumForm_Load(object sender, EventArgs e)
        {
            BtnContinue.Visible = false;
        }

        private void uC_FindStadium1_OnExit()
        {
            this.Close();
        }

        private void uC_FindStadium1_OnLoadingFailed()
        {
            //this.Close();
        }

        private void uC_FindStadium1_OnStadiumFoundSuccessfully(Arena_Whistle_Buisness_layer.ClsStadium obj)
        {
            this.TargetStadium = obj;
            BtnContinue.Visible = true;
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            SaveStadiumForm UpdateStadiumForm = new SaveStadiumForm(TargetStadium);
            UpdateStadiumForm.ShowDialog();
            UpdateStadiumForm.MdiParent = this.MdiParent;
            this.Close();

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
