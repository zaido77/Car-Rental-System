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
    public partial class frmVehicleDetails : FormWithTitle
    {
        public frmVehicleDetails(int VehicleID)
        {
            InitializeComponent();

            Title = "Vehicle Details";

            ucVehicleInfo1.FillDetails(VehicleID);
        }

    }
}
