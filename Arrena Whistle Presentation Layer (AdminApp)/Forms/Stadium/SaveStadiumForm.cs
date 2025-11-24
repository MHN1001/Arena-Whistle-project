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
    public partial class SaveStadiumForm : Form
    {
        public SaveStadiumForm(ClsStadium Stadium = null)
        {
            InitializeComponent();

            this.Stadium = Stadium;
        }

        ClsStadium Stadium;

        private void AddNewStadiumForm_Load(object sender, EventArgs e)
        {

            callUC();
        }


        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uC_SaveStadium1_OnSavedFailed()
        {

        }

        private void uC_SaveStadium1_OnStadiumDataLoadFailed()
        {

        }

        private void uC_SaveStadium1_OnStadiumSavedSuccessfully(Arena_Whistle_Buisness_layer.ClsStadium obj)
        {

        }

        private void uC_SaveStadium1_Load(object sender, EventArgs e)
        {

        }



        private void callUC()
        {
           if(Stadium == null)
                uC_SaveStadium1.Start();
           else
                uC_SaveStadium1.Start(Stadium);
        }
    }
}
