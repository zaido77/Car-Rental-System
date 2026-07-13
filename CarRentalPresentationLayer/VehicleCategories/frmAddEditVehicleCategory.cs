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
    public partial class frmAddEditVehicleCategory : FormWithTitle
    {
        clsVehicleCategory VehicleCategory;

        public frmAddEditVehicleCategory()
        {
            InitializeComponent();

            VehicleCategory = new clsVehicleCategory();
        }
        
        public frmAddEditVehicleCategory(int CategoryID)
        {
            InitializeComponent();

            VehicleCategory = clsVehicleCategory.Find(CategoryID);
        }

        private void _LoadVehicleCategoryData()
        {
            if (VehicleCategory.Mode == clsVehicleCategory.enMode.AddNew)
            {
                Title = "Add New Vehicle Category";
                lblCategoryID.Text = "N/A";
            }
            else if (VehicleCategory.Mode == clsVehicleCategory.enMode.Update)
            {
                Title = "Update Vehicle Category";

                lblCategoryID.Text = VehicleCategory.CategoryID.ToString();
                txtCategoryName.Text = VehicleCategory.CategoryName;
            }
        }

        private void frmAddEditVehicleCategory_Load(object sender, EventArgs e)
        {
            _LoadVehicleCategoryData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                VehicleCategory.CategoryName = txtCategoryName.Text;

                if (VehicleCategory.Save())
                {
                    clsMessageBoxUtil.ShowSuccesMessage("Vehicle Category saved successfully");

                    Title = "Update Vehicle Category";
                    lblCategoryID.Text = VehicleCategory.CategoryID.ToString();
                }
                else
                {
                    clsMessageBoxUtil.ShowError("Failed to save data");
                }
            }
            else
            {
                clsMessageBoxUtil.ShowError("Vehicle Category Name must be filled");
            }
        }
    }
}
