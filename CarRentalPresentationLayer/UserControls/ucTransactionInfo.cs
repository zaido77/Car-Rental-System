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

namespace CarRentalPresentationLayer.Transactions
{
    public partial class ucTransactionInfo : UserControl
    {
        clsRentalTransaction Transaction;

        public ucTransactionInfo()
        {
            InitializeComponent();

            lblPaymentMethod.ForeColor = clsColorsSettings.MainColor;
        }

        public bool Fill(int TransactionID)
        {
            Transaction = clsRentalTransaction.Find(TransactionID);

            if (Transaction == null)
                return false;

            lblTransactionID.Text = Transaction.ID.ToString();
            lblTransactionDate.Text = Transaction.TransactionDate.ToString();
            
            if (Transaction.UpdatedTransactionDate != DateTime.MinValue)
                lblLastUpdated.Text = Transaction.UpdatedTransactionDate.ToString();
            else
                lblLastUpdated.Text = "-----";

            lblPaymentMethod.Text = Transaction.PaymentMethod;
            lblPaidAmount.Text = clsString.PriceToString(Transaction.PaidInitialTotalDueAmount);
            lblActualAmount.Text = clsString.PriceToString(Transaction.ActualTotalDueAmount);
            lblRemaining.Text = clsString.PriceToString(Transaction.TotalRemaining);
            lblRefund.Text = clsString.PriceToString(Transaction.TotalRefundedAmount);

            return true;
        }

    }
}
