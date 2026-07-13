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

namespace CarRentalPresentationLayer.FuelTypes
{
    public partial class frmAddEditFuelType : FormWithTitle
    {
        clsFuelType FuelType;

        public frmAddEditFuelType()
        {
            InitializeComponent();

            FuelType = new clsFuelType();
        }
        public frmAddEditFuelType(int FuelTypeID)
        {
            InitializeComponent();

            FuelType = clsFuelType.Find(FuelTypeID);
        }

        private void _LoadFuelTypeData()
        {
            if (FuelType.Mode == clsFuelType.enMode.AddNew)
            {
                Title = "Add New Fuel Type";
                lblFuelTypeID.Text = "N/A";
            }
            else if (FuelType.Mode == clsFuelType.enMode.Update)
            {
                Title = "Update Fuel Type";

                lblFuelTypeID.Text = FuelType.FuelTypeID.ToString();
                txtFuelTypeName.Text = FuelType.FuelTypeName;
            }
        }

        private void frmAddEditFuelType_Load(object sender, EventArgs e)
        {
            _LoadFuelTypeData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFuelTypeName.Text))
            {
                FuelType.FuelTypeName = txtFuelTypeName.Text;

                if (FuelType.Save())
                {
                    clsMessageBoxUtil.ShowSuccesMessage("Fuel Type saved successfully");

                    Title = "Update Fuel Type";
                    lblFuelTypeID.Text = FuelType.FuelTypeID.ToString();
                }
                else
                {
                    clsMessageBoxUtil.ShowError("Failed to save data");
                }
            }
            else
            {
                clsMessageBoxUtil.ShowError("Fuel Type Name must be filled");
            }
        }

    }
}
