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

namespace CarRentalPresentationLayer.Vehicles
{
    public partial class frmAddEditVehicle : FormWithTitle
    {
        clsVehicle Vehicle;

        public frmAddEditVehicle()
        {
            InitializeComponent();
            _PrepareControls();

            Vehicle = new clsVehicle();
        }

        public frmAddEditVehicle(int VehicleID)
        {
            InitializeComponent();
            _PrepareControls();

            Vehicle = clsVehicle.Find(VehicleID);
        }

        bool _AreAllInputsValidated()
        {
            foreach (Control control in this.Controls)
            {
                TextBox txt = control as TextBox;

                if (txt != null)
                {
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        void _PrepareControls()
        {
            // ==== nudYear ====
            nudYear.Minimum = 1900;
            nudYear.Maximum = DateTime.Now.Year + 1;
            nudYear.Value = DateTime.Now.Year;

            // ==== nudMileage ====
            nudMileage.Minimum = 0;
            nudMileage.Maximum = 1000000;
            nudMileage.Increment = 1000;
            nudMileage.ThousandsSeparator = true;

            // ==== nudRentalPricePerDay ====
            nudRentalPricePerDay.Minimum = 0;
            nudRentalPricePerDay.Maximum = 10000;
            nudRentalPricePerDay.Increment = 5;
            nudRentalPricePerDay.DecimalPlaces = 2;
            nudRentalPricePerDay.ThousandsSeparator = true;

            // ==== cbFuelType ====
            cbFuelType.DataSource = clsFuelType.GetAllFuelTypes();
            cbFuelType.DisplayMember = "FuelTypeName";
            cbFuelType.ValueMember = "FuelTypeID";
            cbFuelType.Text = "Diesel";
            
            // ==== cbCategory ====
            cbCategory.DataSource = clsVehicleCategory.GetAllVehicleCategories();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
            cbCategory.Text = "Sedan";

            // ==== panel ====
            panel.BackColor = clsColorsSettings.MainColor;
        }

        void _ShowVehicleAvailability()
        {
            lblAvailability.Visible = true;
            lblAvailablityValue.Visible = true;

            if (Vehicle.IsAvailableForRent)
            {
                lblAvailablityValue.Text = "Available";
                lblAvailablityValue.ForeColor = Color.Green;
            }
            else
            {
                lblAvailablityValue.Text = "Not Available";
                lblAvailablityValue.ForeColor = Color.Red;
            }
        }

        void _LoadVehicleData()
        {
            if (Vehicle.Mode == clsVehicle.enMode.AddNew)
            {
                Title = "Add New Vehicle";

                lblVehicleID.Text = "N/A";
                lblAvailability.Visible = false;
                lblAvailablityValue.Visible = false;                
            }
            else if (Vehicle.Mode == clsVehicle.enMode.Update)
            {
                Title = "Update Vehicle";

                lblVehicleID.Text = Vehicle.ID.ToString();

                txtMake.Text = Vehicle.Make.ToString();
                txtModel.Text = Vehicle.Model.ToString();
                nudYear.Value = Vehicle.Year;
                nudMileage.Value = Vehicle.Mileage;
                txtPlateNumber.Text = Vehicle.PlateNumber;
                cbFuelType.SelectedValue = Vehicle.FuelTypeID;
                cbCategory.SelectedValue = Vehicle.CategoryID;
                nudRentalPricePerDay.Value = Vehicle.RentalPricePerDay;

                if (!string.IsNullOrEmpty(Vehicle.ImagePath))
                {
                    pbImage.Load(Vehicle.ImagePath);
                    llRemoveImage.Visible = true;
                }

                _ShowVehicleAvailability();
            }
        }

        private void frmAddEditVehicle_Load(object sender, EventArgs e)
        {
            _LoadVehicleData();
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Title = "Set Image";
            openFileDialog1.Filter = "Image Files|*.png;*.jpg;*.jpeg";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbImage.Load(openFileDialog1.FileName);
                llRemoveImage.Visible = true;
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.Image = Properties.Resources.NullVehicleImage;
            pbImage.ImageLocation = "";
            llRemoveImage.Visible = false;
        }

        private void txtInputs_Validating(object sender, CancelEventArgs e)
        {
            TextBox txtInput = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                e.Cancel = true;
                txtInput.Focus();
                errorProvider1.SetError(txtInput, $"{txtInput.Tag.ToString()} should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtInput, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_AreAllInputsValidated())
            {
                Vehicle.Make = txtMake.Text;
                Vehicle.Model = txtModel.Text;
                Vehicle.Year = (short)nudYear.Value;
                Vehicle.Mileage = (int)nudMileage.Value;
                Vehicle.PlateNumber = txtPlateNumber.Text;
                Vehicle.FuelTypeID = (int)cbFuelType.SelectedValue;
                Vehicle.CategoryID = (int)cbCategory.SelectedValue;
                Vehicle.RentalPricePerDay = nudRentalPricePerDay.Value;

                if (!string.IsNullOrEmpty(pbImage.ImageLocation))
                    Vehicle.ImagePath = pbImage.ImageLocation;
                else
                    Vehicle.ImagePath = "";

                if (Vehicle.Save())
                {
                    clsMessageBoxUtil.ShowSuccesMessage("Data saved succesfully");

                    Title = "Update Vehicle";
                    lblVehicleID.Text = Vehicle.ID.ToString();

                    _ShowVehicleAvailability();
                }
                else
                {
                    clsMessageBoxUtil.ShowError("Failed to save data");
                }
            }
            else
            {
                clsMessageBoxUtil.ShowError("Some fields are not validated");
            }
        }

    }
}
