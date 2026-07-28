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
    public partial class frmAddEditRentalBooking : FormWithTitle
    {
        enum enMode { AddNew, Update, BookVehicle }
        enMode _Mode;

        string _PlateNumber;

        clsRentalBooking Booking;

        public frmAddEditRentalBooking()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
            Booking = new clsRentalBooking();
            
            _PrepareControls();
        }

        public frmAddEditRentalBooking(int BookingID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            Booking = clsRentalBooking.Find(BookingID);

            _PrepareControls();
        }

        public frmAddEditRentalBooking(string VehiclePlateNumber)
        {
            InitializeComponent();

            _PlateNumber = VehiclePlateNumber;
            _Mode = enMode.BookVehicle;
            Booking = new clsRentalBooking();
            
            _PrepareControls();
        }

        void _UpdateEndDateConstraints()
        {
            dtpEndDate.MinDate = dtpStartDate.Value.Date.AddDays(1);
            dtpEndDate.MaxDate = dtpStartDate.Value.Date.AddMonths(2);

            if (dtpEndDate.Value.Date < dtpEndDate.MinDate.Date)
                dtpEndDate.Value = dtpEndDate.MinDate.Date;

            if (dtpEndDate.Value.Date > dtpEndDate.MaxDate.Date)
                dtpEndDate.Value = dtpEndDate.MaxDate.Date;
        }

        void _PrepareControls()
        {
            if (_Mode == enMode.AddNew || _Mode == enMode.BookVehicle)
            {
                dtpStartDate.MinDate = DateTime.Today;
            }
            else if (_Mode == enMode.Update)
            {
                tabControl1.SelectTab("tabBookingInfo");
                btnSave.Enabled = true;

                if (Booking.BookingStatus == clsRentalBooking.enBookingStatus.Active)
                {
                    if (DateTime.Today < Booking.StartDate.Date)
                        dtpStartDate.MinDate = DateTime.Today;
                    else
                        dtpStartDate.MinDate = Booking.StartDate.Date;
                }
                else if (Booking.BookingStatus == clsRentalBooking.enBookingStatus.PickedUp)
                {
                    dtpStartDate.Enabled = false;
                    dtpEndDate.Enabled = false;
                    txtPickupLocation.Enabled = false;
                }
            }

            _UpdateEndDateConstraints();
        }

        byte _CalculateRentalDays()
        {
            return (byte)(dtpEndDate.Value.Date - dtpStartDate.Value.Date).TotalDays;
        }

        void _LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                Title = "New Booking";
            }
            else if (_Mode == enMode.Update)
            {
                Title = "Update Booking";

                ucFilterCustomer1.FillDetails(Booking.CustomerID);
                ucFilterVehicle1.FillDetails(Booking.VehicleID);

                lblBookingID.Text = Booking.ID.ToString();
                dtpStartDate.Value = Booking.StartDate.Date;
                dtpEndDate.Value = Booking.EndDate.Date;
                txtPickupLocation.Text = Booking.PickupLocation;
                txtDropoffLocation.Text = Booking.DropoffLocation;

                lblRentalDays.Text = Booking.InitialRentalDays.ToString() + " Days";
                lblRentalPricePerDay.Text = clsString.PriceToString(Booking.RentalPricePerDay);
                lblTotalDueAmount.Text = clsString.PriceToString(Booking.InitialTotalDueAmount);

                txtCheckNotes.Text = Booking.InitialCheckNotes;
            }
            else if (_Mode == enMode.BookVehicle)
            {
                Title = "New Booking";

                ucFilterVehicle1.FillDetails(_PlateNumber);
                lblRentalPricePerDay.Text = clsString.PriceToString(ucFilterVehicle1.RentalPricePerDay);
            }
        }

        void _RecalculateBookingValues()
        {
            byte RentalDays = _CalculateRentalDays();
            
            Booking.InitialRentalDays = RentalDays;
            
            lblRentalDays.Text = RentalDays.ToString() + " Days";
            lblTotalDueAmount.Text = clsString.PriceToString(Booking.InitialTotalDueAmount);
        }

        private void btnCustomerNext_Click(object sender, EventArgs e)
        {
            if (ucFilterCustomer1.CustomerID == -1)
            {
                clsMessageBoxUtil.ShowWarning("Please Choose the Customer First!", MessageBoxButtons.OK);
                return;
            }

            Booking.CustomerID = ucFilterCustomer1.CustomerID;
            tabControl1.SelectTab("tabVehicleInfo");
        }

        private void btnVehicleNext_Click(object sender, EventArgs e)
        {
            if (ucFilterVehicle1.VehicleID == -1)
            {
                clsMessageBoxUtil.ShowWarning("Please Choose the Vehicle First!", MessageBoxButtons.OK);
                return;
            }

            Booking.VehicleID = ucFilterVehicle1.VehicleID;
            Booking.RentalPricePerDay = ucFilterVehicle1.RentalPricePerDay;

            lblRentalPricePerDay.Text = clsString.PriceToString(Booking.RentalPricePerDay);
            dtpStartDate.Value = dtpStartDate.MinDate;

            tabControl1.SelectTab("tabBookingInfo");
            btnSave.Enabled = true;
        }

        private void frmAddEditRentalBooking_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnVehicleBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabCustomerInfo");
        }

        private void btnBookingBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabVehicleInfo");
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            _UpdateEndDateConstraints();

            _RecalculateBookingValues();
        }
       
        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            _RecalculateBookingValues();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Booking.CustomerID = ucFilterCustomer1.CustomerID;
            Booking.VehicleID = ucFilterVehicle1.VehicleID;
            Booking.StartDate = dtpStartDate.Value.Date;
            Booking.EndDate = dtpEndDate.Value.Date;
            Booking.PickupLocation = txtPickupLocation.Text;
            Booking.DropoffLocation = txtDropoffLocation.Text;
            Booking.InitialRentalDays = _CalculateRentalDays();
            Booking.RentalPricePerDay = ucFilterVehicle1.RentalPricePerDay;
            Booking.InitialCheckNotes = txtCheckNotes.Text;

            if (Booking.Save())
            {
                clsMessageBoxUtil.ShowSuccesMessage("Booking Saved Successfully!");

                _Mode = enMode.Update;
                lblBookingID.Text = Booking.ID.ToString();

                Title = "Update Booking";

                ucFilterVehicle1.Lock();
                ucFilterCustomer1.Lock();
            }
        }

    }
}
