using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arena_Whistle_Buisness_layer;
using Arena_Whistle_Buisness_layerm;
using Arrena_Whistle_Admin_Presentation_Layer.Global;
using ControlLibrary.Helpers;
using ShowAllStadiums_ControlLibrary;

namespace Arrena_Whistle_Admin_Presentation_Layer.Forms.Stadium.User_Controls
{
    public partial class UC_SaveStadium : UserControl
    {
        public UC_SaveStadium()
        {
            InitializeComponent();


            EnsureImageFolderExists();
        }






        public event Action OnStadiumDataLoadFailed;
        protected virtual void StadiumDataLoadFailed()
        {
            Action Handler = OnStadiumDataLoadFailed;

            if(Handler != null)
            {
                Handler();
            }
        }


        public event Action<ClsStadium> OnStadiumSavedSuccessfully;
        protected virtual void StadiumSavedSuccessfully(ClsStadium StadiumObj)
        {
            Action<ClsStadium> Handler = OnStadiumSavedSuccessfully;

            if(Handler != null)
            {
                Handler(StadiumObj);
            }
        }


        //Updated Successfully 
        public event Action OnSavedFailed;
        protected virtual void SavingFailed()
        {
            Action Handler = OnSavedFailed;
            if(Handler != null)
            {
                Handler();
            }
        }





        // ====== Fields & Constants ======
        private ClsStadium _stadium;
        private List<string> _CurrentimagePaths = new List<string>();
        private int _currentImageIndex = 0;
        private readonly string _stadiumImagesFolder = @"C:\Users\Admin\source\repos\Arena Whistle Project\Arena Whistle Photos\Stadium Images";










        private void btnNext_Click(object sender, EventArgs e)
        {
            NavigateNextImage();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NavigatePreviousImage();
        }
        private void txtStadiumName_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !txtStadiumName.IsValid(ref e, errorProvider1, "Invalid stadium Name !");
        }

        private void txtPricePerHour_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !txtPricePerHour.IsValid(ref e, errorProvider1, "Invalid Price !");

        }
        private void btnAddimage_Click(object sender, EventArgs e)
        {
            AddImage();
        }

        private void btnDeleteimage_Click(object sender, EventArgs e)
        {
            DeleteCurrentImage();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveStadium();
        }

















        // ====== Initialization ======
        private void EnsureImageFolderExists()
        {
            if(!Directory.Exists(_stadiumImagesFolder))
                Directory.CreateDirectory(_stadiumImagesFolder);
        }



        private void callOnLoadedFailed()
        {
            if(OnStadiumDataLoadFailed != null)
                StadiumDataLoadFailed();

        }
        private void InitializeNewStadium()
        {
            _stadium = new ClsStadium();
        }

        // ====== Satrt This UC ======
        public void Start(ClsStadium stadium = null)
        {
            if(stadium == null)
            {
                InitializeNewStadium();
                UpdateTitle();
            }
            else
            {
                _stadium = stadium;

                if(_stadium == null)
                {
                    GlobalMessages.NotFound();
                    callOnLoadedFailed();

                    return;
                }
            }

            FillUIControls();

        }


        private void FillUIControls()
        {
            switch(_stadium.Mode)
            {
                case ClsStadium.enMode.Add:
                {
                    FillUIInAddMode();
                    break;
                }
                case ClsStadium.enMode.Update:
                {
                    FillUIFromStadiumInUpdateMode();
                    break;
                }
            }
            UpdateTitle();
            LoadStadiumImages();
        }
        private void FillUIFromStadiumInUpdateMode()
        {
            txtStadiumName.Text = _stadium.StadiumName;
            FillSoprtType();
            FillFloorType();
            cbSportType.SelectedItem = _stadium.SportType;

            cbStadiumFloor.SelectedItem = _stadium.FloorType;

            NUP_Length.Value = (decimal)_stadium.Length;
            NUP_width.Value = (decimal)_stadium.Width;
            Nup_Capacity.Value = _stadium.Capacity;
            txtPricePerHour.Text = _stadium.RentalPricePerHour.ToString();

            rbAvailableYes.Checked = _stadium.Available;
            rbAvailableNo.Checked = !_stadium.Available;
            rbLightingYes.Checked = _stadium.Lighting;
            rbLightingNo.Checked = !_stadium.Lighting;
            rbConveredHallYes.Checked = _stadium.ConvertedHall;
            rbConveredHallNo.Checked = !_stadium.ConvertedHall;
        }


        private void FillSoprtType()
        {
            HashSet<string> sportTypes = ClsSportType.GetAvailableSportTypes();

            foreach(string sportType in sportTypes)
            {
                cbSportType.Items.Add(sportType);
            }

            if(cbSportType.Items.Count > 0) cbSportType.SelectedIndex = 0;
        }
        private void FillFloorType()
        {
            HashSet<string> StadiumFloorTypes = ClsStadiumFloorTypeB.GetAvailableStadiumFloors();

            foreach(string FloorType in StadiumFloorTypes)
            {
                cbStadiumFloor.Items.Add(FloorType);
            }

            if(cbStadiumFloor.Items.Count > 0) cbStadiumFloor.SelectedIndex = 0;
        }


        private void FillUIInAddMode()
        {
            txtStadiumName.Text = string.Empty;
            FillSoprtType();
            FillFloorType();
            NUP_Length.Minimum = 70;
            NUP_Length.Value = NUP_Length.Minimum;

            NUP_width.Minimum = 40;
            NUP_width.Value = NUP_width.Minimum;
            NUP_width.Value = NUP_width.Minimum;

            Nup_Capacity.Value = 0;
            txtPricePerHour.Text = "0";

            rbAvailableYes.Checked = true;
            rbAvailableNo.Checked = false;
            rbLightingYes.Checked = false;
            rbLightingNo.Checked = true;
            rbConveredHallYes.Checked = false;
            rbConveredHallNo.Checked = true;
        }


        private void LoadStadiumImages()
        {
            _CurrentimagePaths.Clear();

            if(_stadium.StadiumImages != null && _stadium.StadiumImages.Count > 0)
                _CurrentimagePaths = new List<string>(_stadium.StadiumImages);

            _currentImageIndex = 0;
            DisplayCurrentImage();
        }

        // ====== Image Display ======
        private void DisplayCurrentImage()
        {
            if(_CurrentimagePaths.Count == 0)
            {
                pbStadiumImage.Image = Properties.Resources.no_image; ;
                return;
            }

            try
            {
                pbStadiumImage.Image = Image.FromFile(_CurrentimagePaths[_currentImageIndex]);
            }
            catch
            {
                pbStadiumImage.Image = null;
            }
        }

        // ====== Image Navigation ======
        private void NavigateNextImage()
        {
            if(_CurrentimagePaths.Count == 0) return;
            _currentImageIndex = ( _currentImageIndex + 1 ) % _CurrentimagePaths.Count;
            DisplayCurrentImage();
        }

        private void NavigatePreviousImage()
        {
            if(_CurrentimagePaths.Count == 0) return;
            _currentImageIndex = ( _currentImageIndex - 1 + _CurrentimagePaths.Count ) % _CurrentimagePaths.Count;
            DisplayCurrentImage();
        }

        // ====== Image Management ======
        private void AddImage()
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg;*.bmp";
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = ofd.FileName;

                    if(ClsUtilB.CopyImageToProjectImagesFolder(ref fileName, _stadiumImagesFolder))
                    {
                        _CurrentimagePaths.Add(fileName);
                        _currentImageIndex = _CurrentimagePaths.Count - 1;
                        DisplayCurrentImage();

                    }
                }
            }
        }

        private void DeleteCurrentImage()
        {
            if(_CurrentimagePaths.Count == 0) return;

            string imgToDelete = _CurrentimagePaths[_currentImageIndex];
            _CurrentimagePaths.RemoveAt(_currentImageIndex);

            if(_CurrentimagePaths.Count == 0)
            {
                pbStadiumImage.Image = Properties.Resources.no_image;
                _currentImageIndex = 0;
            }
            else
            {
                if(_currentImageIndex >= _CurrentimagePaths.Count) _currentImageIndex = 0;
                DisplayCurrentImage();
            }

            try { File.Delete(imgToDelete); } catch { }
        }

        // ====== Save _Stadium ======
        private void CollectUIDataToStadiumObject()
        {
            _stadium.StadiumName = txtStadiumName.Text.Trim();
            _stadium.SportType = cbSportType.SelectedItem.ToString().Trim();
            _stadium.FloorType = cbStadiumFloor.SelectedItem.ToString().Trim();
            _stadium.Length = (float)NUP_Length.Value;
            _stadium.Width = (float)NUP_width.Value;
            _stadium.Capacity = (short)Nup_Capacity.Value;
            _stadium.RentalPricePerHour = decimal.Parse(txtPricePerHour.Text);
            _stadium.Available = rbAvailableYes.Checked;
            _stadium.Lighting = rbLightingYes.Checked;
            _stadium.ConvertedHall = rbConveredHallYes.Checked;
            _stadium.Year = DateTime.Now;
        }


        private void callOnSavedSucessfully()
        {
            if(OnStadiumSavedSuccessfully != null)
                StadiumSavedSuccessfully(this._stadium);

        }

        private void callOnSavedFailed()
        {
            if(OnSavedFailed != null)
                SavingFailed();

        }

        private void SaveStadium()
        {
            if(!this.ValidateChildren()) return;

            CollectUIDataToStadiumObject();

            bool success = false;


            success = _stadium.save(ClsGlobal.CurrentUser.UserID, _CurrentimagePaths);


            if(success)
            {
                GlobalMessages.ShowSavingSuccess();

                callOnSavedSucessfully();
            }
            else
            {
                DeleteImages(_CurrentimagePaths);

                GlobalMessages.ShowSavingFailed();

                callOnSavedFailed();
            }
        }

        public static void DeleteImages(List<string> imagePaths)
        {
            foreach(string path in imagePaths)
            {
                try
                {
                    if(File.Exists(path))
                    {
                        File.Delete(path);
                    }
                }
                catch
                {
                    //Console.WriteLine($"Error deleting file '{path}': {ex.Message}");
                }
            }
        }

        private void UpdateTitle()
        {
            if(_stadium.Mode == ClsStadium.enMode.Add)
            {
                lblTittle.Text = "Add Mode";

            }
            else
            {
                lblTittle.Text = "Update Mode";
            }


            lblTittle.Left = ShowAllStadiums_ControlLibrary.Global_Util_Class.Cls_UI_Utility.CenterLabel(lblTittle.Width, this.Width);
        }

        private void UC_SaveStadium_Load(object sender, EventArgs e)
        {

        }
    }
}

