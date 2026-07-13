using CarRentalPresentationLayer.FuelTypes;
using CarRentalPresentationLayer.Utils;
using CarRentalPresentationLayer.Vehicles;
using CarRentalPresentationLayer.VehicleCategories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalPresentationLayer.Maintenances;
using CarRentalPresentationLayer.RentalBookings;
using CarRentalPresentationLayer.Transactions;
using CarRentalPresentationLayer.Returns;

namespace CarRentalPresentationLayer
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        void _ShowStub()
        {
            MessageBox.Show("This feature is not implemented yet.", "Warning!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageCustomers();
            frm.ShowDialog();
        }

        private void fuelTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageFuelTypes();
            frm.ShowDialog();
        }

        private void vehicleCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageVehicleCategories();
            frm.ShowDialog();
        }

        private void maintenancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageMaintenances();
            frm.ShowDialog();
        }

        private void manageVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageVehicles();
            frm.ShowDialog();
        }

        private void bookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageRentalBookings();
            frm.ShowDialog();
        }

        private void returnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmViewReturns();
            frm.ShowDialog();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmViewTransactions();
            frm.ShowDialog();
        }

    }
}
