using CarRentalBusinessLayer;
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

namespace CarRentalPresentationLayer.RentalBookings
{
    public partial class frmPickupPayment : FormWithTitle
    {
        clsRentalBooking Booking;
        clsRentalTransaction Transaction;

        public frmPickupPayment(int BookingID)
        {
            InitializeComponent();

            Booking = clsRentalBooking.Find(BookingID);

            cbPaymentMethod.Text = "Cash";
            Title = "Pickup Payment";
        }

        void _LoadData()
        {
            ucBookingInfo1.FillDetails(Booking.ID);

            lblAmountToPay.Text = ucBookingInfo1.TotalDueAmount.ToString("F2") + " AED";
            lblTransactionOn.Text = DateTime.Now.ToString();
        }

        private void btnComfirmPickup_Click(object sender, EventArgs e)
        {
            Transaction = new clsRentalTransaction(Booking.ID, cbPaymentMethod.Text, ucBookingInfo1.TotalDueAmount);

            if (Transaction.Save())
            {
                if (Booking.PickupVehicle())
                {
                    clsMessageBoxUtil.ShowSuccesMessage("Pickup Completed Successfully");
                    this.Close();
                }
                else
                {
                    clsMessageBoxUtil.ShowError("Payment saved but failed to complete pickup");
                }
            }
            else
            {
                clsMessageBoxUtil.ShowError("Failed to Complete Payment");
            }
        }

        private void frmBookingPayment_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
