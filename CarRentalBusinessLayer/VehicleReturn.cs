using CarRentalDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalBusinessLayer
{
    public class clsVehicleReturn
    {
        public enum enMode : byte { AddNew = 0, Update = 1 };
        public enMode Mode { get; private set; }

        private int PrevMileage { get; set; }
        private decimal RentalPricePerDay { get; set; }


        public int ID {  get; private set; }
        public int TransactionID {  get; set; }
        public DateTime ActualReturnDate { get; private set; }
        public byte ActualRentalDays { get; private set; }
        public int Mileage { get; set; }
        public short ConsumedMileage { get; private set; }
        public string FinalCheckNotes { get; set; }
        public decimal AdditionalCharges { get; set; }
        public decimal ActualTotalDueAmount { get; private set; }

        public clsVehicleReturn(int TransactionID)
        {
            clsRentalTransaction Transaction = clsRentalTransaction.Find(TransactionID);
            clsRentalBooking Booking = clsRentalBooking.Find(Transaction.BookingID);

            this.ID = -1;
            this.TransactionID = TransactionID;
            this.ActualReturnDate = DateTime.Today;
            this.ActualRentalDays = (byte)(this.ActualReturnDate - Booking.StartDate).TotalDays;
            this.PrevMileage = clsVehicle.Find(Booking.VehicleID).Mileage;
            this.Mileage = this.PrevMileage;
            this.FinalCheckNotes = "";
            this.AdditionalCharges = 0;
            this.RentalPricePerDay = Booking.RentalPricePerDay;
            this.ActualTotalDueAmount = this.ActualRentalDays * Booking.RentalPricePerDay;

            Mode = enMode.AddNew;
        }

        private clsVehicleReturn(int ID, int TransactionID, DateTime ActualReturnDate, byte ActualRentalDays, 
            int Mileage, short ConsumedMileage, string FinalCheckNotes, decimal AdditionalCharges,
            decimal ActualTotalDueAmount)
        {
            this.ID = ID;
            this.TransactionID = TransactionID;
            this.ActualReturnDate = ActualReturnDate;
            this.ActualRentalDays = ActualRentalDays;
            this.Mileage = Mileage;
            this.ConsumedMileage = ConsumedMileage;
            this.FinalCheckNotes = FinalCheckNotes;
            this.AdditionalCharges = AdditionalCharges;
            this.ActualTotalDueAmount = ActualTotalDueAmount;

            Mode = enMode.Update;
        }

        private bool _AddNewVehicleReturn()
        {
            this.ID = clsVehicleReturnDataAccess.AddNewVehicleReturn(TransactionID, ActualReturnDate, ActualRentalDays,
                Mileage, ConsumedMileage, FinalCheckNotes, AdditionalCharges, ActualTotalDueAmount);

            return this.ID != -1;
        }

        private bool _UpdateVehicleReturn()
        {
            return clsVehicleReturnDataAccess.UpdateVehicleReturn(ID, TransactionID, ActualReturnDate, ActualRentalDays,
                Mileage, ConsumedMileage, FinalCheckNotes, AdditionalCharges, ActualTotalDueAmount);
        }

        public static clsVehicleReturn Find(int ReturnID)
        {
            int TransactionID = -1;
            DateTime ActualReturnDate = DateTime.MinValue;
            byte ActualRentalDays = 0;
            int Mileage = 0;
            short ConsumedMileage = 0;
            string FinalCheckNotes = "";
            decimal AdditionalCharges = 0;
            decimal ActualTotalDueAmount = 0;

            if (clsVehicleReturnDataAccess.GetVehicleReturnInfoByID(ReturnID, ref TransactionID, 
                ref ActualReturnDate, ref ActualRentalDays, ref Mileage, ref ConsumedMileage, 
                ref FinalCheckNotes, ref AdditionalCharges, ref ActualTotalDueAmount))

                return new clsVehicleReturn(ReturnID, TransactionID, ActualReturnDate, ActualRentalDays,
                Mileage, ConsumedMileage, FinalCheckNotes, AdditionalCharges, ActualTotalDueAmount);
            
            else

                return null;
        }

        public static DataView GetAllVehicleReturns()
        {
            return clsVehicleReturnDataAccess.GetAllVehicleReturns().DefaultView;
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    this.ConsumedMileage = Convert.ToInt16(this.Mileage - this.PrevMileage);

                    if (_AddNewVehicleReturn())
                    {
                        clsRentalBooking Booking = clsRentalBooking.Find(
                            clsRentalTransaction.Find(TransactionID).BookingID
                            );

                        Booking.ReturnVehicle(this.Mileage);

                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateVehicleReturn();

                default: return false;
            }
        }

        public static bool DeleteVehicleReturn(int ReturnID)
        {
            return clsVehicleReturnDataAccess.DeleteVehicleReturn(ReturnID);
        }

        public void CalculateTotalAmount()
        {
            this.ActualTotalDueAmount = (this.RentalPricePerDay * this.ActualRentalDays) + this.AdditionalCharges;
        }

    }
}
