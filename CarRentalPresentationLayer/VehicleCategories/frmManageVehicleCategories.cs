using CarRentalBusinessLayer;
using CarRentalPresentationLayer.Utils;
using CarRentalPresentationLayer.WindowsFormUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalPresentationLayer.VehicleCategories
{
    public partial class frmManageVehicleCategories : ManageFormWithCRUDContextMenu
    {
        public frmManageVehicleCategories()
        {
            InitializeComponent();

            Title = "Manage Vehicle Categories";
            DataSource = clsVehicleCategory.GetAllVehicleCategories();
        }

        int _GetSelectedCategoryID()
        {
            return (int)GetSelectedColumn("CategoryID");
        }

        void _RefreshVehicleCatgoriesList()
        {
            RefreshRecordsList(clsVehicleCategory.GetAllVehicleCategories());
        }

        protected override void ShowRecordDetails()
        {
            Form frm = new frmVehicleCategoryDetails(_GetSelectedCategoryID());
            frm.ShowDialog();
            _RefreshVehicleCatgoriesList();
        }

        protected override void AddNewRecord()
        {
            Form frm = new frmAddEditVehicleCategory();
            frm.ShowDialog();
            _RefreshVehicleCatgoriesList();
        }

        protected override void EditRecord()
        {
            Form frm = new frmAddEditVehicleCategory(_GetSelectedCategoryID());
            frm.ShowDialog();
            _RefreshVehicleCatgoriesList();
        }

        protected override void DeleteRecord()
        {
            int CategoryID = _GetSelectedCategoryID();

            if (clsMessageBoxUtil.ShowWarning($"Are you sure you want to delete " +
                $"Category ID = {CategoryID}") == DialogResult.OK)
            {
                if (clsVehicleCategory.DeleteVehicleCategory(CategoryID))
                {
                    clsMessageBoxUtil.ShowSuccesMessage("Vehicle Category deleted successfully");
                }
                else
                {
                    clsMessageBoxUtil.ShowError("Failed to delete fuel type");
                }
            }

            _RefreshVehicleCatgoriesList();
        }

    }
}
