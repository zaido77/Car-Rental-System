using CarRentalBusinessLayer;
using CarRentalPresentationLayer.Utils;
using CarRentalPresentationLayer.Vehicles;
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
    public partial class ucVehicleInfo : UserControl
    {
        clsVehicle VehicleInfo;

        public int VehicleID
        {
            get
            {
                return VehicleInfo.ID;
            }
        }

        public decimal RentalPricePerDay
        {
            get
            {
                return VehicleInfo.RentalPricePerDay;
            }
        }

        public bool IsAvailable
        {
            get
            {
                return VehicleInfo.IsAvailableForRent;
            }
        }

        public ucVehicleInfo()
        {
            InitializeComponent();

            lblVehicleName.ForeColor = clsColorsSettings.MainColor;
        }

        void _LoadVehicleData()
        {
            lblVehicleID.Text = VehicleInfo.ID.ToString();
            lblVehicleName.Text = VehicleInfo.Name;
            lblCategory.Text = clsVehicleCategory.Find(VehicleInfo.CategoryID).CategoryName;
            lblYear.Text = VehicleInfo.Year.ToString();
            lblPlateNumber.Text = VehicleInfo.PlateNumber;
            lblFuelType.Text = clsFuelType.Find(VehicleInfo.FuelTypeID).FuelTypeName;
            lblMileage.Text = VehicleInfo.Mileage.ToString() + " KM";
            lblRentalPricePerDay.Text = VehicleInfo.RentalPricePerDay.ToString("F2") + " AED";

            if (!string.IsNullOrEmpty(VehicleInfo.ImagePath))
                pbImage.Load(VehicleInfo.ImagePath);
            else
                pbImage.Image = Properties.Resources.NullVehicleImage;

            if (VehicleInfo.IsAvailableForRent)
            {
                lblAvailablity.Text = "Available";
                lblAvailablity.ForeColor = Color.Green;
            }
            else
            {
                lblAvailablity.Text = "Not Available";
                lblAvailablity.ForeColor = Color.Red;
            }

            llEditVehicleInfo.Enabled = true;
        }

        void _ClearData()
        {
            lblVehicleID.Text = "[????]";
            lblVehicleName.Text = "[????]";
            lblCategory.Text = "[????]";
            lblYear.Text = "[????]";
            lblPlateNumber.Text = "[????]";
            lblFuelType.Text = "[????]";
            lblMileage.Text = "[????]";
            lblRentalPricePerDay.Text = "[????]";

            pbImage.Image = Properties.Resources.NullVehicleImage;
            pbImage.ImageLocation = "";

            lblAvailablity.Text = "[????]";
            lblAvailablity.ForeColor = Color.Black;

            llEditVehicleInfo.Enabled = false;
        }

        public void Clear()
        {
            VehicleInfo = null;
            _ClearData();
        }

        void _ShowNotFoundMessage()
        {
            clsMessageBoxUtil.ShowError("Not Found!");
        }

        public bool FillDetails(int VehicleID)
        {
            VehicleInfo = clsVehicle.Find(VehicleID);

            if (VehicleInfo == null)
            {
                _ClearData();
                _ShowNotFoundMessage();
                return false; 
            }

            _LoadVehicleData();

            return true;
        }

        public bool FillDetails(string PlateNumber)
        {
            VehicleInfo = clsVehicle.Find(PlateNumber);

            if (VehicleInfo == null)
            {
                _ClearData();
                _ShowNotFoundMessage();
                return false; 
            }

            _LoadVehicleData();

            return true;
        }

        private void ucVehicleInfo_Load(object sender, EventArgs e)
        {
            if (VehicleInfo == null)
            {
                llEditVehicleInfo.Enabled = false;
            }
        }

        private void llEditVehicleInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmAddEditVehicle(VehicleInfo.ID);
            frm.ShowDialog();
        }

    }
}
