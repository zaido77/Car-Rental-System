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
    public partial class ucFilterVehicle : UserControl
    {
        enum enFindBy { VehicleID, PlateNumber }

        public int VehicleID { get; private set; } = -1;

        public decimal RentalPricePerDay
        {
            get
            {
                return ucVehicleInfo1.RentalPricePerDay;
            }
        }

        public ucFilterVehicle()
        {
            InitializeComponent();
        }

        public bool FillDetails(int VehicleID)
        {
            if (ucVehicleInfo1.FillDetails(VehicleID))
            {
                this.VehicleID = VehicleID;
                _LockFilter(VehicleID);
                return true;
            }

            return false;
        }

        public bool FillDetails(string PlateNumber)
        {
            if (ucVehicleInfo1.FillDetails(PlateNumber))
            {
                this.VehicleID = ucVehicleInfo1.VehicleID;
                _LockFilter(PlateNumber);
                return true;
            }

            return false;
        }

        private void _LockFilter(int VehicleID)
        {
            cbFilter.SelectedItem = enFindBy.VehicleID;
            txtFilter.Text = VehicleID.ToString();
            gbFilter.Enabled = false;
        }

        private void _LockFilter(string PlateNumber)
        {
            cbFilter.SelectedItem = enFindBy.PlateNumber;
            txtFilter.Text = PlateNumber.ToString();
            gbFilter.Enabled = false;
        }

        public void Lock()
        {
            gbFilter.Enabled = false; 
        }

        private void ucFilterVehicle_Load(object sender, EventArgs e)
        {
            cbFilter.Items.Add(enFindBy.VehicleID);
            cbFilter.Items.Add(enFindBy.PlateNumber);
            cbFilter.SelectedItem = enFindBy.PlateNumber;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditVehicle();
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool IsFound = false;
            string FilterText = txtFilter.Text.Trim();

            switch ((enFindBy)cbFilter.SelectedItem)
            {
                case enFindBy.VehicleID:
                    IsFound = ucVehicleInfo1.FillDetails(Convert.ToInt32(FilterText));
                    break;

                case enFindBy.PlateNumber:
                    IsFound = ucVehicleInfo1.FillDetails(FilterText);
                    break;
            }

            if (IsFound)
            {
                if (ucVehicleInfo1.IsAvailable)
                    this.VehicleID = ucVehicleInfo1.VehicleID;
                else
                {
                    ucVehicleInfo1.Clear();
                    clsMessageBoxUtil.ShowError("Vehicle is Not Available");
                }
            }
        }
        
    }
}
