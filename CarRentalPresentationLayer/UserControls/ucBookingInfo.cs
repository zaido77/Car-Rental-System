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

namespace CarRentalPresentationLayer.UserControls
{
    public partial class ucBookingInfo : UserControl
    {
        clsRentalBooking Booking;

        public decimal TotalDueAmount
        {
            get
            {
                return Booking.InitialTotalDueAmount;
            }
        }

        public ucBookingInfo()
        {
            InitializeComponent();

            lblCustomer.ForeColor = clsColorsSettings.MainColor;
            lblTotalDue.ForeColor = clsColorsSettings.MainColor;
            lblVehicle.ForeColor = clsColorsSettings.MainColor;
        }

        public bool FillDetails(int BookingID)
        {
            Booking = clsRentalBooking.Find(BookingID);

            if (Booking == null)
                return false;

            clsVehicle Vehicle = clsVehicle.Find(Booking.VehicleID);

            lblBookingID.Text = Booking.ID.ToString();
            lblCustomer.Text = clsCustomer.Find(Booking.CustomerID).FullName;
            lblPlateNumeber.Text = Vehicle.PlateNumber;
            lblStartDate.Text = Booking.StartDate.ToShortDateString();
            lblRentalPricePerDay.Text = Booking.RentalPricePerDay.ToString("F2") + " AED";

            lblStatus.Text = Booking.BookingStatus.ToString();
            lblVehicle.Text = Vehicle.Name;
            lblRentalDays.Text = Booking.InitialRentalDays.ToString() + " Days";
            lblEndDate.Text = Booking.EndDate.ToShortDateString();
            lblTotalDue.Text = Booking.InitialTotalDueAmount.ToString("F2") + " AED";
            lblCreatedAt.Text = Booking.CreatedDate.ToString();

            return true;
        }

    }
}
