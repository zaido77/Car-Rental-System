using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalPresentationLayer
{
    public partial class ManageForm : BaseForm
    {
        private DataView _RecordsDataView;

        protected string Title
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                lblTitle.Text = value;
            }
        }

        protected DataView DataSource
        {
            set
            {
                _LoadData(value);
            }
        }

        public ManageForm()
        {
            InitializeComponent();
            
            lblTitle.ForeColor = clsColorsSettings.MainColor;
            cbFilters.SelectedItem = "None";
        }

        private void _FillFilterComboBox()
        {
            foreach (DataGridViewColumn Column in dgvAllRecords.Columns)
            {
                if (Column.Visible)
                    cbFilters.Items.Add(Column.Name);
            }
        }

        private void _UpdateDataGridView(DataView RecordsDataView)
        {
            dgvAllRecords.DataSource = RecordsDataView;
            lblNumberOfRecords.Text = dgvAllRecords.RowCount.ToString();
        }

        private void _LoadData(DataView RecordsDataView)
        {
            _RecordsDataView = RecordsDataView;
            _UpdateDataGridView(RecordsDataView);
        }

        private void _ApplyFilterToRecordsList()
        {
            if (!string.IsNullOrWhiteSpace(txtFilter.Text) && cbFilters.Text != "None")
            {
                string Column = cbFilters.Text;
                _RecordsDataView.RowFilter = $"CONVERT({Column}, 'System.String') LIKE '%{txtFilter.Text}%'";

            }
            else
                _RecordsDataView.RowFilter = "";

            _UpdateDataGridView(_RecordsDataView);
        }

        protected object GetSelectedColumn(string ColumnName)
        {
            return dgvAllRecords.CurrentRow.Cells[ColumnName].Value;
        }

        protected void RefreshRecordsList(DataView AllRecordsDataView)
        {
            _RecordsDataView = AllRecordsDataView;
            _UpdateDataGridView(AllRecordsDataView);
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.SelectedItem.ToString() != "None")
                txtFilter.Visible = true;
            else
            {
                txtFilter.Clear();
                txtFilter.Visible = false;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilterToRecordsList();
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            _FillFilterComboBox();
        }
    }
}
