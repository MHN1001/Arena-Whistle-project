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
namespace Arana_Whistle_Presentation_Layer.Forms.StadiumMenu
{
    public partial class ShowAllStadiumsAsTableForm : Form
    {
        public ShowAllStadiumsAsTableForm(DataView Stadiums, string Title)
        {
            InitializeComponent();

            this._Stadiums = Stadiums;
            this._title = Title;
        }

        DataView _Stadiums;
        string _title;

        private void ShowAllStadiumsAsTableForm_Load(object sender, EventArgs e)
        {
            DisableStadiumID();
            uC_DGV1.ExecuteData(_Stadiums);
            uC_DGV1.ControlContextMenuStripItemsVisibility(false, false, false, false, false, false);
            uC_DGV1.SetTitle(_title ?? "Stadiums");
        }



        private void DisableStadiumID()
        {
            if(_Stadiums != null &&
                _Stadiums.Table != null &&
                _Stadiums.Table.Columns.Contains("StadiumID"))
            {
                _Stadiums.Table.Columns.Remove("StadiumID");
            }
        }

        private void uC_DGV1_OnCloseButtonClicked()
        {
            this.Close();
        }

    }
}
