using CarRentalBusinessLayer;
using CarRentalPresentationLayer.Utils;
using CarRentalPresentationLayer.Vehicles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalPresentationLayer.Maintenances
{
    public partial class frmManageMaintenances : ManageForm
    {
        public frmManageMaintenances()
        {
            InitializeComponent();

            DataView dvAllMaintenancesList = clsMaintenance.GetAllMaintenances();

            if (dvAllMaintenancesList.Count > 0)
            {
                DataSource = dvAllMaintenancesList;
                dgvAllRecords.Columns["VehicleID"].Visible = false;
                dgvAllRecords.ContextMenuStrip = cmsRecord;
            }

            Title = "Manage Maintenances";
        }

        void _RefreshMaintenancesList()
        {
            RefreshRecordsList(clsMaintenance.GetAllMaintenances());
        }

        int _GetSelectedMaintenanceID()
        {
            return (int)GetSelectedColumn("MaintenanceID");
        }

        void _AddNewMaintenance()
        {
            Form frm = new frmAddEditMaintenance();
            frm.ShowDialog();
            _RefreshMaintenancesList();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            _AddNewMaintenance();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MaintenanceID = _GetSelectedMaintenanceID();

            if (clsMessageBoxUtil.ShowWarning("Are you sure you want to delete " +
                $"Maintenance with ID = [{MaintenanceID}]") == DialogResult.OK)
            {
                if (clsMaintenance.DeleteMaintenance(MaintenanceID))
                {
                    clsMessageBoxUtil.ShowSuccesMessage("Maintenance deleted successfully!");
                }
                else
                {
                    clsMessageBoxUtil.ShowError("Failed to delete Maintenance");
                }
            }

            _RefreshMaintenancesList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditMaintenance(_GetSelectedMaintenanceID());
            frm.ShowDialog();
            _RefreshMaintenancesList();
        }

        private void cmsRecord_Opening(object sender, CancelEventArgs e)
        {
            bool IsMaintenanceCompleted = (bool)GetSelectedColumn("IsCompleted");

            editToolStripMenuItem.Enabled = !IsMaintenanceCompleted;
            deleteToolStripMenuItem.Enabled = !IsMaintenanceCompleted;
            completeMaintenanceToolStripMenuItem.Enabled = !IsMaintenanceCompleted;
        }

        private void completeMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Vehicle = $"{GetSelectedColumn("Vehicle")} ({GetSelectedColumn("PlateNumber")})";

            if (clsMessageBoxUtil.ShowWarning("Are you sure you want to compelete " +
                $"Maintenance for {Vehicle}?") == DialogResult.OK)
            {
                if (clsMaintenance.CompleteMaintenance(_GetSelectedMaintenanceID()))
                {
                    clsMessageBoxUtil.ShowSuccesMessage("Mainenance Completed!");
                }
                else
                {
                    clsMessageBoxUtil.ShowError("Failed to complete!");
                }
            }

            _RefreshMaintenancesList();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmMaintenanceDetails(_GetSelectedMaintenanceID());
            frm.ShowDialog();
        }

        private void showVehicleDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmVehicleDetails((int)GetSelectedColumn("VehicleID"));
            frm.ShowDialog();
        }
    }
}