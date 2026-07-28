using CarRentalDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalBusinessLayer
{
    public class clsFuelType
    {
        public enum enMode : byte { AddNew = 0, Update = 1 };
        public enMode Mode { get; private set; }

        public int FuelTypeID { get; private set; }
        public string FuelTypeName { get; set; }

        public clsFuelType()
        {
            FuelTypeID = -1;
            FuelTypeName = "";

            Mode = enMode.AddNew;
        }

        private clsFuelType(int FuelTypeID, string FuelTypeName)
        {
            this.FuelTypeID = FuelTypeID;
            this.FuelTypeName = FuelTypeName;

            Mode = enMode.Update;
        }

        private bool _AddNewFuelType()
        {
            this.FuelTypeID = clsFuelTypeDataAccess.AddNewFuelType(this.FuelTypeName);

            return this.FuelTypeID != -1;
        }

        private bool _UpdateFuelType()
        {
            return clsFuelTypeDataAccess.UpdateFuelType(this.FuelTypeID, this.FuelTypeName);
        }

        public static clsFuelType Find(int FuelTypeID)
        {
            string FuelTypeName = "";

            if (clsFuelTypeDataAccess.GetFuelTypeInfoByID(FuelTypeID, ref FuelTypeName))
                return new clsFuelType(FuelTypeID, FuelTypeName);
            else
                return null;
        }

        public static DataView GetAllFuelTypes()
        {
            return clsFuelTypeDataAccess.GetAllFuelTypes().DefaultView;
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewFuelType())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateFuelType();

                default: return false;
            }
        }

        public static bool DeleteFuelType(int FuelTypeID)
        {
            return clsFuelTypeDataAccess.DeleteFuelType(FuelTypeID);
        }
    }
}
