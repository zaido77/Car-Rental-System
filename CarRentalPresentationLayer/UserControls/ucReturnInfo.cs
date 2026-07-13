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

namespace CarRentalPresentationLayer.UserControls
{
    public partial class ucReturnInfo : UserControl
    {
        clsVehicleReturn Return;

        public ucReturnInfo()
        {
            InitializeComponent();

            lblAdditionalCharges.ForeColor = clsColorsSettings.MainColor;
            lblTotalDue.ForeColor = clsColorsSettings.MainColor;
        }

        public bool Fill(int ReturnID)
        {
            Return = clsVehicleReturn.Find(ReturnID);

            if (Return == null )
                return false;

            lblReturnID.Text = Return.ID.ToString();
            lblReturnDate.Text = Return.ActualReturnDate.ToShortDateString();
            lblRentalDays.Text = Return.ActualRentalDays.ToString() + " Days";
            lblAdditionalCharges.Text = clsString.PriceToString(Return.AdditionalCharges);
            lblTransactionID.Text = Return.TransactionID.ToString();
            lblMileage.Text = Return.Mileage.ToString() + " KM";
            lblConsumed.Text = Return.ConsumedMileage.ToString() + " KM";
            lblTotalDue.Text = clsString.PriceToString(Return.ActualTotalDueAmount);
            lblFinalCheckNotes.Text = Return.FinalCheckNotes;

            return true;
        }
    }
}
