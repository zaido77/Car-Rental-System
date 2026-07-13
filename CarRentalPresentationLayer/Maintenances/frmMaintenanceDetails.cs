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

namespace CarRentalPresentationLayer.Maintenances
{
    public partial class frmMaintenanceDetails : BaseForm
    {
        clsMaintenance MaintenanceInfo;

        public frmMaintenanceDetails(int MaintenanceID)
        {
            InitializeComponent();

            MaintenanceInfo = clsMaintenance.Find(MaintenanceID);
        }

        void _LoadData()
        {
            if (MaintenanceInfo != null)
            {
                lblMaintenanceID.Text = MaintenanceInfo.ID.ToString();
                lblMaintenanceDate.Text = MaintenanceInfo.MaintenanceDate.ToString("MM/dd/yyyy");
                lblCost.Text = MaintenanceInfo.Cost.ToString() + " AED";
                lblDescription.Text = MaintenanceInfo.Description;

                ucVehicleInfo1.FillDetails(MaintenanceInfo.VehicleID);
            }
            else
            {
                clsMessageBoxUtil.ShowError("Could not load Maintenance Details");
            }
        }

        private void frmMaintenanceDetails_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
