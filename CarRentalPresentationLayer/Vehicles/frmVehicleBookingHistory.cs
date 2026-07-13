using CarRentalBusinessLayer;
using CarRentalPresentationLayer.RentalBookings;
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
    public partial class frmVehicleBookingHistory : FormWithTitle
    {
        public frmVehicleBookingHistory(int VehicleID)
        {
            InitializeComponent();

            Title = "Booking History";

            ucVehicleInfo1.FillDetails(VehicleID);

            DataView dvVehicleBooknings = clsRentalBooking.GetVehicleBookingsHistory(VehicleID);

            if (dvVehicleBooknings.Count > 0)
            {
                dgvAllVehicleBookings.DataSource = dvVehicleBooknings;

                dgvAllVehicleBookings.Columns["CustomerID"].Visible = false;
                dgvAllVehicleBookings.Columns["VehicleID"].Visible = false;
                dgvAllVehicleBookings.Columns["BookingStatus"].Visible = false;
            }
        }

        int _GetSelectedBookingID()
        {
            return (int)dgvAllVehicleBookings.CurrentRow.Cells["BookingID"].Value;
        }

        private void showBookingInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmBookingDetails(_GetSelectedBookingID());
            frm.ShowDialog();
        }

    }
}
