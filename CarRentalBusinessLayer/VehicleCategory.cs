using CarRentalDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalBusinessLayer
{
    public class clsVehicleCategory
    {
        public enum enMode : byte { AddNew = 0, Update = 1 };
        public enMode Mode { get; private set; }

        public int CategoryID { get; private set; }
        public string CategoryName { get; set; }

        public clsVehicleCategory()
        {
            CategoryID = -1;
            CategoryName = "";

            Mode = enMode.AddNew;
        }

        private clsVehicleCategory(int CategoryID, string CategoryName)
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;

            Mode = enMode.Update;
        }

        private bool _AddNewVehicleCategory()
        {
            this.CategoryID = clsVehicleCategoryDataAccess.AddNewVehicleCategory(this.CategoryName);

            return this.CategoryID != -1;
        }

        private bool _UpdateVehicleCategory()
        {
            return clsVehicleCategoryDataAccess.UpdateVehicleCategory(this.CategoryID, this.CategoryName);
        }

        public static clsVehicleCategory Find(int CategoryID)
        {
            string CategoryName = "";

            if (clsVehicleCategoryDataAccess.GetVehicleCategoryInfoByID(CategoryID, ref CategoryName))
                return new clsVehicleCategory(CategoryID, CategoryName);
            else
                return null;
        }

        public static DataView GetAllVehicleCategories()
        {
            return clsVehicleCategoryDataAccess.GetAllVehicleCategories();
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewVehicleCategory())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateVehicleCategory();

                default: return false;
            }
        }

        public static bool DeleteVehicleCategory(int CategoryID)
        {
            return clsVehicleCategoryDataAccess.DeleteVehicleCategory(CategoryID);
        }

    }
}