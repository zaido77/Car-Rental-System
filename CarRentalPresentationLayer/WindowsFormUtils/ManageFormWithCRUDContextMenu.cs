using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalPresentationLayer.WindowsFormUtils
{
    public partial class ManageFormWithCRUDContextMenu : ManageForm
    {
        public ManageFormWithCRUDContextMenu()
        {
            InitializeComponent();

            dgvAllRecords.ContextMenuStrip = cmsRecord;
        }

        virtual protected void ShowRecordDetails() { }
        virtual protected void AddNewRecord() { }
        virtual protected void EditRecord() { }
        virtual protected void DeleteRecord() { }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRecordDetails();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewRecord();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRecord();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNewRecord();
        }

    }
}
