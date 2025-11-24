using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShowAllStadiums_ControlLibrary.Properties;

namespace ShowAllStadiums_ControlLibrary.Stadiums
{
    public partial class UC_ShowStadiumCard : UserControl
    {
        public UC_ShowStadiumCard()
        {
            InitializeComponent();
        }




        (DataRowView RowsStadiumsRow, List<string> List_StadiumImages) Stadium;
        byte StadiumImageIndex = 0;

        private void UC_ShowStadiumCard_Load(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayStadiumImages();

        }


        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }






        public void ResetAllControls()
        {
            txtStadiumName.Text = string.Empty;
            txtSportType.Text = string.Empty;
            txtFloorType.Text = string.Empty;
            txtCapacity.Text = string.Empty;
            txtRentalpricePerHour.Text = string.Empty;
            txtLength.Text = string.Empty;
            txtWidth.Text = string.Empty; ;
            txtLighting.Text = string.Empty;
            txtConveredHall.Text = string.Empty;
            txtAvailable.Text = string.Empty;

            pbStadiumImage.Image = Resources.Question;

        }
        public void PassStadiumforDisplay((DataRowView RowsStadiumsRow, List<string> List_StadiumImages) Stadium)
        {
            this.Stadium = (null, null);
            this.Stadium = Stadium;

            ShowStadium();
        }
        public void ShowStadium()
        {

            txtStadiumName.Text = Stadium.RowsStadiumsRow["StadiumName"].ToString();
            txtSportType.Text = Stadium.RowsStadiumsRow["SportType"].ToString();
            txtFloorType.Text = Stadium.RowsStadiumsRow["FloorType"].ToString();
            txtCapacity.Text = Stadium.RowsStadiumsRow["Capacity"].ToString();
            txtRentalpricePerHour.Text = Stadium.RowsStadiumsRow["RentalPricePerHour"].ToString() + " $";
            txtLength.Text = Stadium.RowsStadiumsRow["Length"].ToString() + " m";
            txtWidth.Text = Stadium.RowsStadiumsRow["Width"].ToString() + " m"; ;
            txtLighting.Text = Stadium.RowsStadiumsRow["Lighting"].ToString().ToUpper() == "TRUE" ? "Available" : "Not Available";
            txtConveredHall.Text = Stadium.RowsStadiumsRow["ConveredHall"].ToString().ToUpper() == "TRUE" ? "Available" : "Not Available";
            txtAvailable.Text = Stadium.RowsStadiumsRow["Available"].ToString().ToUpper() == "TRUE" ? "Yes" : "No";

            if(!CheckIfIStadiumsImageListIsEmpty())
            {
                timer1.Start();
                DisplayStadiumImages();
            }
            else
            {
                timer1.Stop();
            }

        }
        private void DisplayStadiumImages()
        {

            if(StadiumImageIndex >= 0 && StadiumImageIndex < Stadium.List_StadiumImages.Count)
            {
                pbStadiumImage.ImageLocation = Stadium.List_StadiumImages[StadiumImageIndex];
            }

            StadiumImageIndex++;

            if(StadiumImageIndex == Stadium.List_StadiumImages.Count)
            {
                StadiumImageIndex = 0;
            }

        }
        private bool CheckIfIStadiumsImageListIsEmpty()
        {
            if(Stadium.List_StadiumImages.Count == 0)
            {
                pbStadiumImage.Image = Resources.Question;
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
