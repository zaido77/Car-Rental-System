using CarRentalBusinessLayer;
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
    public partial class frmTransactionDetails : FormWithTitle
    {
        clsRentalTransaction Transaction;

        public frmTransactionDetails(int TransactionID)
        {
            InitializeComponent();

            Title = "Transaction Details";

            Transaction = clsRentalTransaction.Find(TransactionID);

            if (Transaction != null)
            {
                ucBookingInfo1.FillDetails(Transaction.BookingID);
                ucTransactionInfo1.Fill(Transaction.ID);
            }
        }
    }
}
