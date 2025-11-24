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
using static ShowAllStadiums_ControlLibrary.Stadiums.UC_ShowStadiums;

namespace ShowAllStadiums_ControlLibrary.Stadiums
{
    public partial class UC_StadiumInfosSummary : UserControl
    {
        public UC_StadiumInfosSummary()
        {
            InitializeComponent();
        }



        public bool ShowFullDataButton
        {
            get => btnShowFullData.Enabled;
            set => btnShowFullData.Enabled = value;
        }


        public event Action OnLoadingFailed;
        protected virtual void LoadingFailed()
        {
            Action Handler = OnLoadingFailed;

            if(Handler != null)
            {
                Handler();
            }
        }


        public event Action<ClsStadium> OnShowFullDataButtonClicked;
        protected virtual void ShowFullDataButtonClicked(ClsStadium Stadium)
        {
            Action<ClsStadium> Handler = OnShowFullDataButtonClicked;

            if(Handler != null)
            {
                Handler(Stadium);
            }
        }


        ClsStadium StadiumObj;


        private void UC_StadiumInfosSummary_Load(object sender, EventArgs e)
        {
            ResetControls();
        }
        private void btnShowFullData_Click(object sender, EventArgs e)
        {
                if(OnShowFullDataButtonClicked != null)
                ShowFullDataButtonClicked(StadiumObj);
        }
        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }







        public void ResetControls()
        {
            txtLengthAndWidth.Text = "-";
            txtPrice.Text = "-";
            txtSportType.Text = "-";
            txtStadiumName.Text = "-";
        }



        public void LoadStadiumDataByID(int StadiumID)
        {
            this.StadiumObj = ClsStadium.FindStadium(StadiumID);

            if(StadiumObj == null)
            {
                btnShowFullData.Enabled = false;

                if(OnLoadingFailed != null)
                    LoadingFailed();
            }
            else
            {
                FillControlsByStadiumData();
            }

        }

        public void LoadStadiumDataByObj(ClsStadium StadiumObj)
        {
            if(StadiumObj == null)
            {
                if(OnLoadingFailed != null)
                    LoadingFailed();
            }
            else
            {
                this.StadiumObj = StadiumObj;
                FillControlsByStadiumData();
            }

        }

        private void FillControlsByStadiumData()
        {
            txtStadiumName.Text = StadiumObj.StadiumName.ToString();
            txtSportType.Text = StadiumObj.SportType.ToString();
            txtPrice.Text = StadiumObj.RentalPricePerHour.ToString() + " $";
            txtLengthAndWidth.Text = ClsStadium.CalCulateStadiumSurface(StadiumObj.Length.ToString(),
                                                                        this.StadiumObj.Width.ToString()).ToString() + " m²";

            //btnShowFullData.Enabled =true;
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

    }
}
