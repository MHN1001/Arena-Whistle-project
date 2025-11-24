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

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms_and_UserControls.Stadium
{
    public partial class Form_ShowMatches : Form
    {
        public Form_ShowMatches()
        {
            InitializeComponent();
        }

        private void uC_DGV1_OnCloseButtonClicked()
        {
            this.Close();
        }

        private void Form_ShowMatches_Load(object sender, EventArgs e)
        {
            uC_DGV1.ExecuteData(ClsMatch.GetAllMatchesTable());
            uC_DGV1.ControlContextMenuStripItemsVisibility(false, false ,false, false, false, false);
            uC_DGV1.SetTitle("All Matches");
        }
    }
}
