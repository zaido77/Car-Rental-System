using CarRentalDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalBusinessLayer
{
    public class clsVehicle
    {
        public enum enMode : byte { AddNew, Update }
        public enMode Mode { get; private set; } = enMode.AddNew;

        public int ID { get; private set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public string Name 
        {
            get 
            {
                return Make + " " + Model;
            }
        }

        public short Year { get; set; }
        public int Mileage { get; set; }
        public int FuelTypeID { get; set; }
        public string PlateNumber { get; set; }
        public int CategoryID { get; set; }
        public decimal RentalPricePerDay { get; set; }
        public bool IsAvailableForRent { get; set; }
        public string ImagePath { get; set; }

        public clsVehicle()
        {
            this.ID = -1;
            this.Make = "";
            this.Model = "";
            this.Year = -1;
            this.Mileage = -1;
            this.FuelTypeID = -1;
            this.PlateNumber = "";
            this.CategoryID = -1;
            this.RentalPricePerDay = -1;
            this.IsAvailableForRent = true;
            this.ImagePath = "";

            this.Mode = enMode.AddNew;
        }

        private clsVehicle(int ID, string Make, string Model, short Year,
            int Mileage, int FuelTypeID, string PlateNumber, int CategoryID,
            decimal RentalPricePerDay, bool IsAvailableForRent, string ImagePath)
        {
            this.ID = ID;
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Mileage = Mileage;
            this.FuelTypeID = FuelTypeID;
            this.PlateNumber = PlateNumber;
            this.CategoryID = CategoryID;
            this.RentalPricePerDay = RentalPricePerDay;
            this.IsAvailableForRent = IsAvailableForRent;
            this.ImagePath = ImagePath;

            this.Mode = enMode.Update;
        }

        private bool _AddNewVehicle()
        {
            this.ID = clsVehicleDataAccess.AddNewVehicle(Make, Model, Year, Mileage, FuelTypeID, 
                PlateNumber, CategoryID, RentalPricePerDay, IsAvailableForRent, ImagePath);

            return this.ID != -1;
        }

        private bool _UpdateVehicle()
        {
            return clsVehicleDataAccess.UpdateVehicle(ID, Make, Model, Year, Mileage, FuelTypeID,
                PlateNumber, CategoryID, RentalPricePerDay, IsAvailableForRent, ImagePath);
        }

        public static clsVehicle Find(int VehicleID)
        {
            string Make = "", Model = "", PlateNumber = "", ImagePath = "";
            short Year = -1;
            int Mileage = -1, FuelTypeID = -1, CategoryID = -1;
            decimal RentalPricePerDay = -1;
            bool IsAvailableForRent = false;

            if (clsVehicleDataAccess.GetVehicleInfoByID(VehicleID, ref Make, ref Model, ref Year,
                ref Mileage, ref FuelTypeID, ref PlateNumber, ref CategoryID, ref RentalPricePerDay,
                ref IsAvailableForRent, ref ImagePath))

                return new clsVehicle(VehicleID, Make, Model, Year, Mileage, FuelTypeID,
                    PlateNumber, CategoryID, RentalPricePerDay, IsAvailableForRent, ImagePath);

            else

                return null;
        }

        public static clsVehicle Find(string PlateNumber)
        {
            int VehicleID = -1;
            string Make = "", Model = "", ImagePath = "";
            short Year = -1;
            int Mileage = -1, FuelTypeID = -1, CategoryID = -1;
            decimal RentalPricePerDay = -1;
            bool IsAvailableForRent = false;

            if (clsVehicleDataAccess.GetVehicleInfoByPlateNumber(PlateNumber, ref VehicleID, ref Make, ref Model, ref Year,
                ref Mileage, ref FuelTypeID, ref CategoryID, ref RentalPricePerDay,
                ref IsAvailableForRent, ref ImagePath))

                return new clsVehicle(VehicleID, Make, Model, Year, Mileage, FuelTypeID,
                    PlateNumber, CategoryID, RentalPricePerDay, IsAvailableForRent, ImagePath);

            else

                return null;
        }

        public static DataView GetAllVehicles()
        {
            return clsVehicleDataAccess.GetAllVehicles();
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewVehicle())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateVehicle();

                default: return false;
            }
        }

        public static bool DeleteVehicle(int VehicleID)
        {
            return clsVehicleDataAccess.DeleteVehicle(VehicleID);
        }

        public static bool SetAvailability(int VehicleID, bool IsAvailableForRent)
        {
            return clsVehicleDataAccess.SetAvailability(VehicleID, IsAvailableForRent);
        }

    }
}
