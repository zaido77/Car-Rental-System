using CarRentalBusinessLayer;
using CarRentalPresentationLayer.Utils;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalPresentationLayer.Bookings
{
    public partial class frmReturnVehicle : FormWithTitle
    {
        clsVehicleReturn Return;
        clsRentalTransaction Transaction;

        public frmReturnVehicle(int TransactionID)
        {
            InitializeComponent();

            Transaction = clsRentalTransaction.Find(TransactionID);
            Return = new clsVehicleReturn(TransactionID);

            _PrepareControls();

            Title = "Return Vehicle";
        }

        void _PrepareControls()
        {
            // ==== nudCurrentMileage ====
            nudCurrentMileage.Minimum = Return.Mileage;
            nudCurrentMileage.Maximum = 1000000;
            nudCurrentMileage.Increment = 1000;
            nudCurrentMileage.ThousandsSeparator = true;

            // ==== lblActualReturnDate ====
            lblActualReturnDate.Text = DateTime.Today.ToShortDateString();
        }

        void _SetPaymentSummaryValues()
        {
            lblInitialPaid.Text = clsString.PriceToString(Transaction.PaidInitialTotalDueAmount);
            lblActualTotal.Text = clsString.PriceToString(Return.ActualTotalDueAmount);
            lblRemaining.Text = clsString.PriceToString(Transaction.TotalRemaining);
            lblRefund.Text = clsString.PriceToString(Transaction.TotalRefundedAmount);

            lblActualRentalDays.Text = Return.ActualRentalDays.ToString() + " Days";
        }

        void _SetReturnObjectValues()
        {
            Return.Mileage = (int)nudCurrentMileage.Value;
            Return.FinalCheckNotes = txtFinalCheckNotes.Text;
            Return.AdditionalCharges = nudAdditionalCharges.Value;
            Return.CalculateTotalAmount();
        }

        short _CalculateConsumedMileage()
        {
            return (short)(nudCurrentMileage.Value - nudCurrentMileage.Minimum);
        }

        private void frmReturnVehicle_Load(object sender, EventArgs e)
        {
            ucBookingInfo1.FillDetails(Transaction.BookingID);
        }

        private void nudCurrentMileage_ValueChanged(object sender, EventArgs e)
        {
            lblConsumedMileage.Text = _CalculateConsumedMileage().ToString() + " KM";
        }

        private void btnCustomerNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPaymentSummary");
            btnCompleteReturn.Enabled = true;

            _SetReturnObjectValues();

            Transaction.UpdateValues(Return);
            _SetPaymentSummaryValues();
        }

        private void btnVehicleBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabReturnInfo");
        }

        private void btnCompleteReturn_Click(object sender, EventArgs e)
        {
            _SetReturnObjectValues();

            if (Return.Save())
            {
                if (Transaction.Save())
                {
                    clsMessageBoxUtil.ShowSuccesMessage("Return Completed Succesfully!");
                    this.Close();
                }
                else
                {
                    clsMessageBoxUtil.ShowError("Return completed but failed to Update Transaction Info");
                }
            }
            else
            {
                clsMessageBoxUtil.ShowError("Failed to complete return");
            }
        }

    }
}