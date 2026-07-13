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
using System.Windows.Forms.VisualStyles;

namespace CarRentalPresentationLayer.VehicleCategories
{
    public partial class frmVehicleCategoryDetails : FormWithTitle
    {
        clsVehicleCategory VehicleCategory;

        public frmVehicleCategoryDetails(int CategoryID)
        {
            InitializeComponent();

            Title = "Vehicle Category Details";

            VehicleCategory = clsVehicleCategory.Find(CategoryID);
            lblCategoryName.ForeColor = clsColorsSettings.MainColor;
        }

        private void frmVehicleCategoryDetails_Load(object sender, EventArgs e)
        {
            if (VehicleCategory != null)
            {
                lblCategoryID.Text = VehicleCategory.CategoryID.ToString();
                lblCategoryName.Text = VehicleCategory.CategoryName;
            }
            else
            {
                clsMessageBoxUtil.ShowError("Could not load Vehicle Category Details");
            }
        }

    }
}
