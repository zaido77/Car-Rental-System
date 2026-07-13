using CarRentalBusinessLayer;
using CarRentalPresentationLayer.Customers;
using CarRentalPresentationLayer.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalPresentationLayer
{
    public partial class frmManageCustomers : ManageForm
    {
        public frmManageCustomers()
        {
            InitializeComponent();

            Title = "Manage Customers";
            dgvAllRecords.ContextMenuStrip = cmsRecord;
            DataSource = clsCustomer.GetAllCustomers();
        }

        int _GetSelectedCustomerID()
        {
            return (int)GetSelectedColumn("CustomerID");
        }

        void _RefreshCustomersList()
        {
            RefreshRecordsList(clsCustomer.GetAllCustomers());
        }

        void _AddNewCustomer()
        {
            Form frm = new frmAddEditCustomer();
            frm.ShowDialog();
            _RefreshCustomersList();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            _AddNewCustomer();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _AddNewCustomer();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CustomerID = _GetSelectedCustomerID();

            Form frm = new frmAddEditCustomer(CustomerID);
            frm.ShowDialog();
            _RefreshCustomersList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CustomerID = _GetSelectedCustomerID();

            if (clsMessageBoxUtil.ShowWarning($"Are you sure you want to delete " +
                $"Customer with ID = [{CustomerID}]?") == DialogResult.OK)
            {
                if (clsCustomer.DeleteCustomer(CustomerID))
                {
                    clsMessageBoxUtil.ShowSuccesMessage("Customer deleted successfully!");
                }
                else
                {
                    clsMessageBoxUtil.ShowError("Failed to delete customer");
                }
            }

            _RefreshCustomersList();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmCustomerDetails(_GetSelectedCustomerID());
            frm.ShowDialog();
            _RefreshCustomersList();
        }

        private void showBookingHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmCustomerBookingHistory(_GetSelectedCustomerID());
            frm.ShowDialog();
        }
    }
}
