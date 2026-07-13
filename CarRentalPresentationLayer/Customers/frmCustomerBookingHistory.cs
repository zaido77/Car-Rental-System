using CarRentalBusinessLayer;
using CarRentalPresentationLayer.RentalBookings;
using CarRentalPresentationLayer.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalPresentationLayer.Customers
{
    public partial class frmCustomerBookingHistory : FormWithTitle
    {
        public frmCustomerBookingHistory(int CustomerID)
        {
            InitializeComponent();

            Title = "Booking History";

            ucCustomerInfo1.FillDetails(CustomerID);

            DataView dvCustomerBookings = clsRentalBooking.GetCustomerBookingsHistory(CustomerID);

            if (dvCustomerBookings.Count > 0)
            {
                dgvAllCustomerBookings.DataSource = dvCustomerBookings;

                dgvAllCustomerBookings.Columns["CustomerID"].Visible = false;
                dgvAllCustomerBookings.Columns["VehicleID"].Visible = false;
                dgvAllCustomerBookings.Columns["BookingStatus"].Visible = false;
            }
        }

        int _GetSelectedBookingID()
        {
            return (int)dgvAllCustomerBookings.CurrentRow.Cells["BookingID"].Value;
        }

        private void showBookingInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmBookingDetails(_GetSelectedBookingID());
            frm.ShowDialog();
        }
    }
}
