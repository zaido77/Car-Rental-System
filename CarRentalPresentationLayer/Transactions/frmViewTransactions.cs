using CarRentalBusinessLayer;
using CarRentalPresentationLayer.RentalBookings;
using CarRentalPresentationLayer.WindowsFormUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalPresentationLayer.Transactions
{
    public partial class frmViewTransactions : ViewForm
    {
        public frmViewTransactions()
        {
            InitializeComponent();

            Title = "View Transactions";

            DataView dvAllTransactionsList = clsRentalTransaction.GetAllRentalTransactions();

            if (dvAllTransactionsList.Count > 0)
            {
                DataSource = dvAllTransactionsList;
                dgvAllRecords.ContextMenuStrip = cmsRecord;
            }
        }

        private void showTransactionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmTransactionDetails((int)GetSelectedColumn("TransactionID"));
            frm.ShowDialog();
        }
    }
}
