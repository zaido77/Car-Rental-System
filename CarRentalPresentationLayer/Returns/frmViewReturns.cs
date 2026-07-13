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

namespace CarRentalPresentationLayer.Returns
{
    public partial class frmViewReturns : ViewForm
    {
        public frmViewReturns()
        {
            InitializeComponent();

            Title = "View Bookings Returns";

            DataView dvAllReturnsList = clsVehicleReturn.GetAllVehicleReturns();

            if (dvAllReturnsList.Count > 0)
            {
                DataSource = dvAllReturnsList;
                dgvAllRecords.Columns["TransactionID"].Visible = false;
                dgvAllRecords.ContextMenuStrip = cmsRecord;
            }
        }

        private void showBookingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmBookingDetails((int)GetSelectedColumn("BookingID"));
            frm.ShowDialog();
        }

        private void showReturnDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmReturnDetails((int)GetSelectedColumn("ReturnID"));
            frm.ShowDialog();
        }
    }
}
