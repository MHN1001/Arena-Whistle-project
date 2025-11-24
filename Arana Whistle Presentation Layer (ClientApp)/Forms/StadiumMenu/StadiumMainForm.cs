using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arana_Whistle_Presentation_Layer.Forms.StadiumMenu.Booking;
using Arana_Whistle_Presentation_Layer.Forms.StadiumMenu.Matches;
using Arana_Whistle_Presentation_Layer.Forms.StadiumMenu.Reservation;
using Arana_Whistle_Presentation_Layer.Forms.StadiumMenu.Stadiums_Zone;
using Arena_Whistle_Buisness_layer;
using Arrena_Whistle_Admin_Presentation_Layer.Forms_and_UserControls.Matches;
using ShowAllStadiums_ControlLibrary.Global_Util_Class;
namespace Arana_Whistle_Presentation_Layer.Forms.StadiumMenu
{
    public partial class StadiumMainForm : Form
    {
        public StadiumMainForm()
        {
            InitializeComponent();
        }


        private void StadiumMainForm_Load(object sender, EventArgs e)
        {
            CenterLabel();

        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void btnAllStadiums_Click(object sender, EventArgs e)
        {
            ShowAllStadiumsForm allStadiumsForm = new ShowAllStadiumsForm();
            this.Hide();
            allStadiumsForm.ShowDialog();
            this.Show();
        }

        private void btnAvailableStadiums_Click(object sender, EventArgs e)
        {
            AvailableStadiumsForm availableStadiums  = new AvailableStadiumsForm();
            this.Hide();
            availableStadiums.ShowDialog(); 
            this.Show();
                
        }

        private void btnBoockedStadiums_Click(object sender, EventArgs e)
        {
            BookedStadiumsTableForm stadiumsTableForm  = new BookedStadiumsTableForm();
            this.Hide();
            stadiumsTableForm.ShowDialog();
            this.Show();


        }

        private void btnCurrentMatched_Click(object sender, EventArgs e)
        {
            CurrentMatchesAsTableForm currentMatches = new CurrentMatchesAsTableForm();
            this.Hide();
            currentMatches.ShowDialog();
            this.Show();
        }

        private void btnShowResevations_Click(object sender, EventArgs e)
        {
            ReservedStadiumsTableForm reservedStadiumsTableForm = new ReservedStadiumsTableForm();
            this.Hide();
            reservedStadiumsTableForm.ShowDialog();
            this.Show();
        }









        private void CenterLabel()
        {
            lblTitle.Left = Cls_UI_Utility.CenterLabel(lblTitle.Width, this.Width);
        }
    }
}
