using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlLibrary.Helpers;

namespace ShowAllStadiums_ControlLibrary.Global__User_Controls
{
    public partial class UC_DGV : UserControl
    {
        public event Action<DataGridViewRow> OnShowTSMIclicked;
        protected virtual void ShowTSMIclicked(DataGridViewRow DGVR)
        {
            Action<DataGridViewRow> Handler = OnShowTSMIclicked;
            if(Handler != null)
            {
                Handler(DGVR);
            }
        }


        public event Action<DataGridViewRow> OnShowAsSummaryTSMIclicked;
        protected virtual void ShowAsSummaryTSMIclicked(DataGridViewRow DGVR)
        {
            Action<DataGridViewRow> Handler = OnShowAsSummaryTSMIclicked;
            if(Handler != null)
            {
                Handler(DGVR);
            }
        }

        public event Action OnAddTSMIclicked;
        protected virtual void AddTSMIclicked()
        {
            Action Handler = OnAddTSMIclicked;
            if(Handler != null)
            {
                Handler();
            }
        }


        public event Action<DataGridViewRow> OnCancelTSMIclicked;
        protected virtual void CancelTSMIclicked(DataGridViewRow DGVR)
        {
            Action<DataGridViewRow> Handler = OnCancelTSMIclicked;
            if(Handler != null)
            {
                Handler(DGVR);
            }
        }


        public event Action<DataGridViewRow> OnUpdateTSMIclicked;
        protected virtual void UpdateTSMIclicked(DataGridViewRow DGVR)
        {
            Action<DataGridViewRow> Handler = OnUpdateTSMIclicked;
            if(Handler != null)
            {
                Handler(DGVR);
            }
        }

        public event Action<DataGridViewRow> OnDeleteTSMIclicked;
        protected virtual void DeleteTSMIclicked(DataGridViewRow DGVR)
        {
            Action<DataGridViewRow> Handler = OnDeleteTSMIclicked;
            if(Handler != null)
            {
                Handler(DGVR);
            }
        }


        public event Action OnDGV_IsEmpty;
        protected virtual void DGV_IsEmpty()
        {
            Action Handler = OnDGV_IsEmpty;
            if(Handler != null)
            {
                Handler();
            }
        }


        public event Action OnCloseButtonClicked;
        protected virtual void CloseButtonClicked()
        {
            Action Handler = OnCloseButtonClicked;
            if(Handler != null)
            {
                Handler();
            }
        }




        public UC_DGV()
        {
            InitializeComponent();
        }


        private void UC_DGV_Load(object sender, EventArgs e)
        {

        }

        private void TSMI_Show_Click(object sender, EventArgs e)
        {
            if(OnShowTSMIclicked != null)
                ShowTSMIclicked(DGV.CurrentRow);
        }

        private void TSMI_showAsSummary_Click(object sender, EventArgs e)
        {
            if(OnShowAsSummaryTSMIclicked != null)
                ShowAsSummaryTSMIclicked(DGV.CurrentRow);
        }

        private void TSMI_Add_Click(object sender, EventArgs e)
        {
            if(OnAddTSMIclicked != null)
                AddTSMIclicked();
        }

        private void TSMI_Update_Click(object sender, EventArgs e)
        {
            if(OnUpdateTSMIclicked != null)
                UpdateTSMIclicked(DGV.CurrentRow);
        }
        private void TSMI_Delete_Click(object sender, EventArgs e)
        {
            if(GlobalMessages.Confirm("Are you sure you want to Delete", "CONFIRM"))
                if(OnDeleteTSMIclicked != null)
                    DeleteTSMIclicked(DGV.CurrentRow);
        }
        private void TSMI_Cancel_Click(object sender, EventArgs e)
        {
            if(GlobalMessages.Confirm("Are you sure you want to Cancel", "CONFIRM"))
                if(OnCancelTSMIclicked != null)
                    CancelTSMIclicked(DGV.CurrentRow);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if(OnCloseButtonClicked != null)
                CloseButtonClicked();
        }







        public void SetTitle(string title)
        {
            gbDGV.Text = title;
        }
        public void ExecuteData(DataView Data)
        {
            PrepareDGV();

            DGV.DataSource = Data;

            if(DGV.Rows.Count <= 0 || DGV == null)
            {
                if(OnDGV_IsEmpty != null)
                    DGV_IsEmpty();

                ControlContextMenuStripItemsVisibility(false, false, false, false, false, false);

                GlobalMessages.NoData();

                return;
            }

        }
        private void PrepareDGV()
        {

            DGV.Font = new Font("Calibri", 9F, FontStyle.Regular);

            DGV.RowsDefaultCellStyle.Font = new Font("Calibri", 9F, FontStyle.Regular);

            DGV.AlternatingRowsDefaultCellStyle.Font = new Font("Calibri", 9F, FontStyle.Regular);

            DGV.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11F, FontStyle.Bold);

            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
        public void ControlContextMenuStripItemsVisibility(bool Show_TSMI, bool ShowAsSumamry_TSMI, bool Add_TSMI, bool Update_TSMI, bool Delete_TSMI, bool Cancel_TSMI)
        {
            TSMI_Show.Visible = Show_TSMI;
            TSMI_showAsSummary.Visible = ShowAsSumamry_TSMI;
            TSMI_Add.Visible = Add_TSMI;
            TSMI_Update.Visible = Update_TSMI;
            TSMI_Delete.Visible = Delete_TSMI;
            TSMI_Cancel.Visible = Cancel_TSMI;
        }

        /// <summary>
        /// Deletes the first row from the DataGridView where the specified column contains the given value.
        /// </summary>
        /// <typeparam name="T">The type of the value to match (e.g., int, string, DateTime).</typeparam>
        /// <param name="columnName">The name of the column to check for the value.</param>
        /// <param name="value">The value to match in the specified column.</param>
        /// <remarks>
        /// The method safely checks that the column exists and ignores the "new row" placeholder.
        /// Only the first matching row is removed. Returns true if a row was deleted; otherwise false.
        /// </remarks>
        public bool DeleteTheTargetRow<T>(string columnName, T value)
        {
            // Check column exists
            if(!DGV.Columns.Contains(columnName))
                return false;

            // Find the row (first match)
            var row = DGV.Rows.Cast<DataGridViewRow>().FirstOrDefault(r =>
                r.Cells[columnName].Value is T cellValue &&
                EqualityComparer<T>.Default.Equals(cellValue, value));

            // Remove it
            if(row != null && !row.IsNewRow)
            {
                DGV.Rows.Remove(row);
                return true; // Row deleted
            }

            return false; // No matching row found
        }
    }
}
