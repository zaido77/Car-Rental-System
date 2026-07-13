using CarRentalBusinessLayer;
using CarRentalPresentationLayer.Utils;
using CarRentalPresentationLayer.WindowsFormUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalPresentationLayer.FuelTypes
{
    public partial class frmManageFuelTypes : ManageFormWithCRUDContextMenu
    {
        public frmManageFuelTypes()
        {
            InitializeComponent();
            
            Title = "Manage Fuel Types";
            DataSource = clsFuelType.GetAllFuelTypes();
        }

        int _GetSelectedFuelTypeID()
        {
            return (int)GetSelectedColumn("FuelTypeID");
        }

        void _RefreshFuelTypesList()
        {
            RefreshRecordsList(clsFuelType.GetAllFuelTypes());
        }


        override protected void ShowRecordDetails()
        {
            Form frm = new frmFuelTypeDetails(_GetSelectedFuelTypeID());
            frm.ShowDialog();
            _RefreshFuelTypesList();
        }

        override protected void AddNewRecord()
        {
            Form frm = new frmAddEditFuelType();
            frm.ShowDialog();
            _RefreshFuelTypesList();
        }

        override protected void EditRecord()
        {
            Form frm = new frmAddEditFuelType(_GetSelectedFuelTypeID());
            frm.ShowDialog();
            _RefreshFuelTypesList();
        }

        override protected void DeleteRecord()
        {
            int FuelTypeID = _GetSelectedFuelTypeID();

            if (clsMessageBoxUtil.ShowWarning($"Are you sure you want to delete " +
                $"Fuel Type ID = {FuelTypeID}") == DialogResult.OK)
            {
                if (clsFuelType.DeleteFuelType(FuelTypeID))
                {
                    clsMessageBoxUtil.ShowSuccesMessage("Fuel Type deleted successfully");
                }
                else
                {
                    clsMessageBoxUtil.ShowError("Failed to delete fuel type");
                }
            }

            _RefreshFuelTypesList();
        }

    }
}
