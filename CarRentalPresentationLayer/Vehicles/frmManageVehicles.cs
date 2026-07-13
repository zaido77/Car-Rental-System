using CarRentalBusinessLayer;
using CarRentalPresentationLayer.Maintenances;
using CarRentalPresentationLayer.RentalBookings;
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

namespace CarRentalPresentationLayer.Vehicles
{
    public partial class frmManageVehicles : ManageForm
    {
        public frmManageVehicles()
        {
            InitializeComponent();

            Title = "Manage Vehicles";
            dgvAllRecords.ContextMenuStrip = cmsRecord;
            DataSource = clsVehicle.GetAllVehicles();
        }

        int _GetSelectedVehicleID()
        {
            return (int)GetSelectedColumn("VehicleID");
        }

        void _RefreshVehiclesList()
        {
            RefreshRecordsList(clsVehicle.GetAllVehicles());
        }

        void _AddNewVehicle()
        {
            Form frm = new frmAddEditVehicle();
            frm.ShowDialog();
            _RefreshVehiclesList();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            _AddNewVehicle();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditVehicle(_GetSelectedVehicleID());
            frm.ShowDialog();
            _RefreshVehiclesList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Vehicle = $"{GetSelectedColumn("Make")} {GetSelectedColumn("Model")}" +
                $" ({GetSelectedColumn("PlateNumber")})";

            if (clsMessageBoxUtil.ShowWarning("Are you sure you want to delete " +
                $"{Vehicle}") == DialogResult.OK)
            {
                if (clsVehicle.DeleteVehicle(_GetSelectedVehicleID()))
                {
                    clsMessageBoxUtil.ShowSuccesMessage("Vehicle deleted successfully!");
                }
                else
                {
                    clsMessageBoxUtil.ShowError("Failed to delete Vehicle");
                }
            }

            _RefreshVehiclesList();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmVehicleDetails(_GetSelectedVehicleID());
            frm.ShowDialog();
        }

        private void sendToMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditMaintenance((string)GetSelectedColumn("PlateNumber"));
            frm.ShowDialog();
            _RefreshVehiclesList();
        }

        private void cmsRecord_Opening(object sender, CancelEventArgs e)
        {
            bool IsAvailable = (bool)GetSelectedColumn("IsAvailableForRent");

            sendToMaintenanceToolStripMenuItem.Enabled = IsAvailable;
            bookVehicleToolStripMenuItem.Enabled = IsAvailable;
        }

        private void bookVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditRentalBooking((string)GetSelectedColumn("PlateNumber"));
            frm.ShowDialog();
            _RefreshVehiclesList();
        }

        private void showBookingHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmVehicleBookingHistory(_GetSelectedVehicleID());
            frm.ShowDialog();
        }
    }
}
