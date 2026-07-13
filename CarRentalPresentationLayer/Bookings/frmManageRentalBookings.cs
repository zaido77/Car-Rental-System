using CarRentalBusinessLayer;
using CarRentalPresentationLayer.Bookings;
using CarRentalPresentationLayer.Customers;
using CarRentalPresentationLayer.Utils;
using CarRentalPresentationLayer.Vehicles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalPresentationLayer.RentalBookings
{
    public partial class frmManageRentalBookings : ManageForm
    {
        public frmManageRentalBookings()
        {
            InitializeComponent();

            DataView dvAllBookingsList = clsRentalBooking.GetAllRentalBookings();

            if (dvAllBookingsList.Count > 0)
            {
                DataSource = dvAllBookingsList;
                dgvAllRecords.Columns["TransactionID"].Visible = false;
                dgvAllRecords.Columns["CustomerID"].Visible = false;
                dgvAllRecords.Columns["VehicleID"].Visible = false;
                dgvAllRecords.Columns["BookingStatus"].Visible = false;
                dgvAllRecords.ContextMenuStrip = cmsRecord;
            }

            Title = "Manage Bookings";
        }

        int _GetSelectedBookingID()
        {
            return (int)GetSelectedColumn("BookingID");
        }

        clsRentalBooking.enBookingStatus _GetSelectedBookingStatus()
        {
            return (clsRentalBooking.enBookingStatus)(byte)GetSelectedColumn("BookingStatus");
        }

        void _RefreshRentalBookingsList()
        {
            RefreshRecordsList(clsRentalBooking.GetAllRentalBookings());
        }

        private void cmsRecord_Opening(object sender, CancelEventArgs e)
        {
            clsRentalBooking.enBookingStatus Status = _GetSelectedBookingStatus();

            switch (Status)
            {
                case clsRentalBooking.enBookingStatus.Active:
                    editToolStripMenuItem.Enabled = true;

                    if (((DateTime)GetSelectedColumn("StartDate")).Date <= DateTime.Today)
                    {
                        pickupVehicleToolStripMenuItem.Enabled = true;
                        deleteToolStripMenuItem.Enabled = false;
                        cancelBookingToolStripMenuItem.Enabled = false;
                    }
                    else
                    {
                        pickupVehicleToolStripMenuItem.Enabled = false;
                        deleteToolStripMenuItem.Enabled = true;
                        cancelBookingToolStripMenuItem.Enabled = true;
                    }

                    returnVehicleToolStripMenuItem.Enabled = false;

                    break;

                case clsRentalBooking.enBookingStatus.PickedUp:
                    editToolStripMenuItem.Enabled = true;
                    deleteToolStripMenuItem.Enabled = false;
                    cancelBookingToolStripMenuItem.Enabled = false;
                    pickupVehicleToolStripMenuItem.Enabled = false;
                    returnVehicleToolStripMenuItem.Enabled = true;
                    break;

                case clsRentalBooking.enBookingStatus.Completed:
                    editToolStripMenuItem.Enabled = false;
                    deleteToolStripMenuItem.Enabled = false;
                    cancelBookingToolStripMenuItem.Enabled = false;
                    pickupVehicleToolStripMenuItem.Enabled = false;
                    returnVehicleToolStripMenuItem.Enabled = false;
                    break;

                case clsRentalBooking.enBookingStatus.Cancelled:
                    editToolStripMenuItem.Enabled = false;
                    deleteToolStripMenuItem.Enabled = false;
                    cancelBookingToolStripMenuItem.Enabled = false;
                    pickupVehicleToolStripMenuItem.Enabled = false;
                    returnVehicleToolStripMenuItem.Enabled = false;
                    break;
            }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmCustomerDetails((int)GetSelectedColumn("CustomerID"));
            frm.ShowDialog();
        }

        private void vehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmVehicleDetails((int)GetSelectedColumn("VehicleID"));
            frm.ShowDialog();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditRentalBooking();
            frm.ShowDialog();
            _RefreshRentalBookingsList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditRentalBooking(_GetSelectedBookingID());
            frm.ShowDialog();
            _RefreshRentalBookingsList();
        }

        private void cancelBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BookingID = _GetSelectedBookingID();

            if (clsMessageBoxUtil.ShowWarning("Are you sure you want to " +
                $"cancel booking with ID = {BookingID}") == DialogResult.OK)
            {
                if (clsRentalBooking.CancelBooking(BookingID))
                {
                    clsMessageBoxUtil.ShowSuccesMessage("Booking cancelled succesfully");
                }
                else
                {
                    clsMessageBoxUtil.ShowError("Failed to cancel booking");
                }
            }

            _RefreshRentalBookingsList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BookingID = _GetSelectedBookingID();

            if (clsMessageBoxUtil.ShowWarning("Are you sure you want to " +
                $"delete booking with ID = {BookingID}") == DialogResult.OK)
            {
                if (clsRentalBooking.DeleteRentalBooking(BookingID))
                {
                    clsMessageBoxUtil.ShowSuccesMessage("Booking delete succesfully");
                }
                else
                {
                    clsMessageBoxUtil.ShowError("Failed to delete booking");
                }
            }

            _RefreshRentalBookingsList();
        }

        private void pickupVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPickupPayment frm = new frmPickupPayment(_GetSelectedBookingID());
            frm.ShowDialog();
            _RefreshRentalBookingsList();
        }

        private void showBookingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmBookingDetails(_GetSelectedBookingID());
            frm.ShowDialog();
        }

        private void returnVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmReturnVehicle((int)GetSelectedColumn("TransactionID"));
            frm.ShowDialog();
            _RefreshRentalBookingsList();
        }
    }
}
