using CarRentalDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalBusinessLayer
{
    public class clsMaintenance
    {
        public enum enMode : byte { AddNew = 0, Update = 1 };
        public enMode Mode { get; private set; }

        public int ID { get; private set; }
        public int VehicleID { get; set; }
        public string Description { get; set; }
        public DateTime MaintenanceDate { get; private set; }
        public decimal Cost { get; set; }
        public bool IsCompleted { get; private set; }

        public clsMaintenance()
        {
            ID = -1;
            VehicleID = -1;
            Description = "";
            MaintenanceDate = DateTime.Now;
            Cost = -1;
            IsCompleted = false;

            Mode = enMode.AddNew;
        }

        private clsMaintenance(int MaintenanceID, int VehicleID, string Description,
            DateTime MaintenanceDate, decimal Cost, bool IsCompleted)
        {
            this.ID = MaintenanceID;
            this.VehicleID = VehicleID;
            this.Description = Description;
            this.MaintenanceDate = MaintenanceDate;
            this.Cost = Cost;
            this.IsCompleted = IsCompleted;

            Mode = enMode.Update;
        }

        private bool _AddNewMaintenance()
        {
            this.ID = clsMaintenanceDataAccess.AddNewMaintenance(VehicleID, Description, 
                MaintenanceDate, Cost, IsCompleted);

            return this.ID != -1;
        }

        private bool _UpdateMaintenance()
        {
            return clsMaintenanceDataAccess.UpdateMaintenance(ID, VehicleID, Description, Cost, IsCompleted);
        }

        public static clsMaintenance Find(int MaintenanceID)
        {
            int VehicleID = -1;
            string Description = "";
            DateTime MaintenanceDate = DateTime.Now;
            decimal Cost = -1;
            bool IsCompleted = false;

            if (clsMaintenanceDataAccess.GetMaintenanceInfoByID(MaintenanceID, ref VehicleID, ref Description, 
                ref MaintenanceDate, ref Cost, ref IsCompleted))

                return new clsMaintenance(MaintenanceID, VehicleID, Description,
                    MaintenanceDate, Cost, IsCompleted);
            else
                return null;
        }

        public static DataView GetAllMaintenances()
        {
            return clsMaintenanceDataAccess.GetAllMaintenances();
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMaintenance())
                    {
                        clsVehicle.SetAvailability(this.VehicleID, false);
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateMaintenance();

                default: return false;
            }
        }

        public static bool DeleteMaintenance(int MaintenanceID)
        {
            return clsMaintenanceDataAccess.DeleteMaintenance(MaintenanceID);
        }

        public static bool CompleteMaintenance(int MaintenanceID)
        {
            clsMaintenance Maintenance = clsMaintenance.Find(MaintenanceID);

            if (Maintenance == null)
                return false;

            return clsMaintenanceDataAccess.CompleteMaintenance(Maintenance.ID) &&
                clsVehicle.SetAvailability(Maintenance.VehicleID, true);
        }

    }
}
