using CarRentalDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalBusinessLayer
{
    public class clsCustomer
    {
        public enum enMode : byte { AddNew, Update }
        public enMode Mode { get; private set; } = enMode.AddNew;

        public int ID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string DriverLicenseNumber { get; set; }
        public string ImagePath { get; set; }

        public clsCustomer()
        {
            this.ID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.DriverLicenseNumber = "";
            this.ImagePath = "";

            this.Mode = enMode.AddNew;
        }

        private clsCustomer(int ID, string FirstName, string LastName,
            string Email, string Phone, string DriverLicenseNumber, string ImagePath)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.DriverLicenseNumber = DriverLicenseNumber;
            this.ImagePath = ImagePath;

            this.Mode = enMode.Update;
        }

        private bool _AddNewCustomer()
        {
            this.ID = clsCustomerDataAccess.AddNewCustomer(this.FirstName, this.LastName, this.Email,
                this.Phone, this.DriverLicenseNumber, this.ImagePath);

            return this.ID != -1;
        }

        private bool _UpdateCustomer()
        {
            return clsCustomerDataAccess.UpdateCustomer(this.ID, this.FirstName, this.LastName, this.Email,
                this.Phone, this.DriverLicenseNumber, this.ImagePath);
        }

        public static clsCustomer Find(int CustomerID)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "", DriverLicenseNumber = "",
                ImagePath = "";

            if (clsCustomerDataAccess.GetCustomerInfoByID(CustomerID, ref FirstName, ref LastName,
                ref Email, ref Phone, ref DriverLicenseNumber, ref ImagePath))

                return new clsCustomer(CustomerID, FirstName, LastName, Email, Phone, 
                    DriverLicenseNumber, ImagePath);

            else

                return null;
        }

        public static clsCustomer Find(string Email)
        {
            int CustomerID = -1;
            string FirstName = "", LastName = "", Phone = "", DriverLicenseNumber = "",
                ImagePath = "";

            if (clsCustomerDataAccess.GetCustomerInfoByEmail(Email, ref CustomerID, ref FirstName, ref LastName, 
                ref Phone, ref DriverLicenseNumber, ref ImagePath))

                return new clsCustomer(CustomerID, FirstName, LastName, Email, Phone,
                    DriverLicenseNumber, ImagePath);

            else

                return null;
        }

        public static clsCustomer FindByPhone(string Phone)
        {
            int CustomerID = -1;
            string FirstName = "", LastName = "", Email = "", DriverLicenseNumber = "",
                ImagePath = "";

            if (clsCustomerDataAccess.GetCustomerInfoByPhone(Phone, ref CustomerID, ref FirstName, ref LastName,
                ref Phone, ref DriverLicenseNumber, ref ImagePath))

                return new clsCustomer(CustomerID, FirstName, LastName, Email, Phone,
                    DriverLicenseNumber, ImagePath);

            else

                return null;
        }

        public static DataView GetAllCustomers()
        {
            return clsCustomerDataAccess.GetAllCustomers().DefaultView;
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCustomer())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                    
                case enMode.Update:
                    return _UpdateCustomer();

                default: return false;
            }
        }

        public static bool DeleteCustomer(int CustomerID)
        {
            return clsCustomerDataAccess.DeleteCustomer(CustomerID);
        }

    }
}
