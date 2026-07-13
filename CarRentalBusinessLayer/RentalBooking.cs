using CarRentalDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalBusinessLayer
{
    public class clsRentalBooking
    {
        public enum enMode : byte { AddNew, Update }
        public enMode Mode { get; private set; } = enMode.AddNew;

        public enum enBookingStatus
        {
            Active = 0,
            PickedUp = 1,
            Completed = 2,
            Cancelled = 3
        }

        public int ID { get; private set; }
        public int CustomerID { get; set; }
        public int VehicleID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PickupLocation { get; set; }
        public string DropoffLocation { get; set; }
        public byte InitialRentalDays { get; set; }
        public decimal RentalPricePerDay { get; set; }
        public decimal InitialTotalDueAmount
        {
            get
            {
                return InitialRentalDays * RentalPricePerDay;
            }
        }
        public string InitialCheckNotes { get; set; }
        public enBookingStatus BookingStatus { get; private set; }

        public clsRentalBooking()
        {
            this.ID = -1;
            this.CustomerID = -1;
            this.VehicleID = -1;
            this.StartDate = DateTime.MinValue.Date;
            this.EndDate = DateTime.MinValue.Date;
            this.PickupLocation = "";
            this.DropoffLocation = "";
            this.InitialRentalDays = 0;
            this.RentalPricePerDay = -1;
            this.InitialCheckNotes = "";
            this.BookingStatus = enBookingStatus.Active;

            this.Mode = enMode.AddNew;
        }

        private clsRentalBooking(int ID, int CustomerID, int VehicleID,
            DateTime StartDate, DateTime EndDate, string PickupLocation,
            string DropoffLocation, byte InitialRentalDays, decimal RentalPricePerDay,
            string InitialCheckNotes, enBookingStatus BookingStatus)
        {
            this.ID = ID;
            this.CustomerID = CustomerID;
            this.VehicleID = VehicleID;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.PickupLocation = PickupLocation;
            this.DropoffLocation = DropoffLocation;
            this.InitialRentalDays = InitialRentalDays;
            this.RentalPricePerDay = RentalPricePerDay;
            this.InitialCheckNotes = InitialCheckNotes;
            this.BookingStatus = BookingStatus;

            this.Mode = enMode.Update;
        }

        private bool _AddNewRentalBooking()
        {
            this.ID = clsRentalBookingDataAccess.AddNewRentalBooking(CustomerID, VehicleID,
                StartDate, EndDate, PickupLocation, DropoffLocation, InitialRentalDays, RentalPricePerDay,
                InitialTotalDueAmount, InitialCheckNotes, (byte)BookingStatus);

            return this.ID != -1;
        }

        private bool _UpdateRentalBooking()
        {
            return clsRentalBookingDataAccess.UpdateRentalBooking(ID, CustomerID, VehicleID,
                StartDate, EndDate, PickupLocation, DropoffLocation, InitialRentalDays, RentalPricePerDay,
                InitialTotalDueAmount, InitialCheckNotes, (byte)BookingStatus);
        }

        public static clsRentalBooking Find(int BookingID)
        {
            int CustomerID = -1;
            int VehicleID = -1;
            DateTime StartDate = DateTime.MinValue;
            DateTime EndDate = DateTime.MinValue;
            string PickupLocation = "";
            string DropoffLocation = "";
            byte InitialRentalDays = 0;
            decimal RentalPricePerDay = -1;
            string InitialCheckNotes = "";
            byte BookingStatus = (byte)enBookingStatus.Active;

            if (clsRentalBookingDataAccess.GetRentalBookingInfoByID(BookingID, ref CustomerID,
                ref VehicleID, ref StartDate, ref EndDate, ref PickupLocation, ref DropoffLocation, 
                ref InitialRentalDays, ref RentalPricePerDay, 
                ref InitialCheckNotes, ref BookingStatus))

                return new clsRentalBooking(BookingID, CustomerID, VehicleID, StartDate, EndDate,
                    PickupLocation, DropoffLocation, InitialRentalDays, RentalPricePerDay, 
                    InitialCheckNotes, (enBookingStatus)BookingStatus);

            else

                return null;
        }

        public static DataView GetAllRentalBookings()
        {
            return clsRentalBookingDataAccess.GetAllRentalBookings();
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRentalBooking())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateRentalBooking();

                default: return false;
            }
        }

        public static bool DeleteRentalBooking(int BookingID)
        {
            return clsRentalBookingDataAccess.DeleteRentalBooking(BookingID);
        }

        public static bool CancelBooking(int BookingID)
        {
            return clsRentalBookingDataAccess.SetBookingStatus(BookingID, (byte)enBookingStatus.Cancelled);
        }

        public bool PickupVehicle()
        {
            return clsRentalBookingDataAccess.SetBookingStatus(this.ID, (byte)enBookingStatus.PickedUp) &&
                clsVehicle.SetAvailability(this.VehicleID, false);
        }

        public bool ReturnVehicle(int NewMileage)
        {
            clsVehicle Vehicle = clsVehicle.Find(this.VehicleID);

            if (clsRentalBookingDataAccess.SetBookingStatus(this.ID, (byte)enBookingStatus.Completed))
            {
                Vehicle.IsAvailableForRent = true;
                Vehicle.Mileage = NewMileage;
                Vehicle.Save();

                return true;
            }

            return false;
        }

        public static DataView GetVehicleBookingsHistory(int VehicleID)
        {
            return clsRentalBookingDataAccess.GetVehicleBookingsHistory(VehicleID);
        }

        public static DataView GetCustomerBookingsHistory(int CustomerID)
        {
            return clsRentalBookingDataAccess.GetCustomerBookingsHistory(CustomerID);
        }

    }
}
