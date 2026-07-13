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
    public partial class frmFuelTypeDetails : FormWithTitle
    {
        clsFuelType FuelType;

        public frmFuelTypeDetails(int FuelTypeID)
        {
            InitializeComponent();

            Title = "Fuel Type Details";

            FuelType = clsFuelType.Find(FuelTypeID);
            lblFuelTypeName.ForeColor = clsColorsSettings.MainColor;
        }

        private void frmFuelTypeDetails_Load(object sender, EventArgs e)
        {
            if (FuelType != null)
            {
                lblFuelTypeID.Text = FuelType.FuelTypeID.ToString();
                lblFuelTypeName.Text = FuelType.FuelTypeName;
            }
            else
            {
                clsMessageBoxUtil.ShowError("Could not load Fuel Type Details");
            }
        }
    }
}
