using CarRentalBusinessLayer;
using CarRentalPresentationLayer.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalPresentationLayer.Returns
{
    public partial class frmReturnDetails : FormWithTitle
    {
        clsVehicleReturn Return;

        public frmReturnDetails(int ReturnID)
        {
            InitializeComponent();

            Return = clsVehicleReturn.Find(ReturnID);

            Title = "Return Details";
            ucReturnInfo1.Fill(Return.ID);
            ucTransactionInfo1.Fill(Return.TransactionID);
        }
    }
}
