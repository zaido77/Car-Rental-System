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
    public partial class frmAddEditMaintenance : FormWithTitle
    {
        enum enMode : byte { AddNew, Update, SendToMaintenance }
        private enMode _Mode;

        string _PlateNumber = "";
        clsMaintenance Maintenance;

        public frmAddEditMaintenance()
        {
            InitializeComponent();

            Maintenance = new clsMaintenance();
            _Mode = enMode.AddNew;
        }

        public frmAddEditMaintenance(int MaintenanceID)
        {
            InitializeComponent();

            Maintenance = clsMaintenance.Find(MaintenanceID);
            _Mode = enMode.Update;
        }

        public frmAddEditMaintenance(string PlateNumber)
        {
            InitializeComponent();

            _PlateNumber = PlateNumber;
            Maintenance = new clsMaintenance();
            _Mode = enMode.SendToMaintenance;
        }

        private string _GetTodayDateString()
        {
            return DateTime.Now.Date.ToString("MM/dd/yyyy");
        }

        void _LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                Title = "New Maintenance";
                lblMaintenanceDate.Text = _GetTodayDateString();
            }
            else if (_Mode == enMode.Update)
            {
                Title = "Update Maintenance";

                ucFilterVehicle1.FillDetails(Maintenance.VehicleID);

                lblMaintenanceID.Text = Maintenance.ID.ToString();
                lblMaintenanceDate.Text = Maintenance.MaintenanceDate.ToString("MM/dd/yyyy");
                txtDescription.Text = Maintenance.Description;
                nudCost.Value = Maintenance.Cost;
            }
            else if (_Mode == enMode.SendToMaintenance)
            {
                Title = "Send To Maintenance";
                lblMaintenanceDate.Text = _GetTodayDateString();

                ucFilterVehicle1.FillDetails(_PlateNumber);
            }
        }

        private void frmAddEditMaintenance_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ucFilterVehicle1.VehicleID != -1)
            {
                tabControl1.SelectTab("tabMaintenanceInfo");
                btnSave.Enabled = true;
            }
            else
            {
                clsMessageBoxUtil.ShowWarning("Please Choose the Vehicle First!", MessageBoxButtons.OK);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ucFilterVehicle1.VehicleID == -1)
            {
                clsMessageBoxUtil.ShowWarning("Please Choose the Vehicle First!");
                return;
            }

            Maintenance.VehicleID = ucFilterVehicle1.VehicleID;
            Maintenance.Description = txtDescription.Text;
            Maintenance.Cost = nudCost.Value;

            if (Maintenance.Save())
            {
                clsMessageBoxUtil.ShowSuccesMessage("Data saved succesfully!");

                _Mode = enMode.Update;
                Title = "Update Maintenance";
                lblMaintenanceID.Text = Maintenance.ID.ToString();

                ucFilterVehicle1.Lock();
            }
            else
            {
                clsMessageBoxUtil.ShowError("Failed to Save Maintenance Data");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabVehicleInfo");
        }
    }
}
