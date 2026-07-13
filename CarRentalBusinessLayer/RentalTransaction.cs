using CarRentalDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalBusinessLayer
{
    public class clsRentalTransaction
    {
        public enum enMode : byte { AddNew, Update }
        public enMode Mode { get; private set; } = enMode.AddNew;

        public int ID { get; private set; }
        public int BookingID { get; private set; }
        public string PaymentMethod { get; set; }
        public decimal PaidInitialTotalDueAmount { get; set; }
        public decimal ActualTotalDueAmount { get; set; }
        public decimal TotalRemaining { get; set; }
        public decimal TotalRefundedAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime UpdatedTransactionDate { get; set; }

        public clsRentalTransaction(int BookingID, string PaymentMethod, decimal InitialTotalDueAmount)
        {
            this.ID = -1;
            this.BookingID = BookingID;
            this.PaymentMethod = PaymentMethod;
            this.PaidInitialTotalDueAmount = InitialTotalDueAmount;
            this.ActualTotalDueAmount = InitialTotalDueAmount;
            this.TotalRemaining = 0;
            this.TotalRefundedAmount = 0;
            this.TransactionDate = DateTime.Now;
            this.UpdatedTransactionDate = DateTime.MinValue;

            this.Mode = enMode.AddNew;
        }

        private clsRentalTransaction(int ID, int BookingID, string PaymentMethod, 
            decimal PaidInitialTotalDueAmount, decimal ActualTotalDueAmount,
            decimal TotalRemaining, decimal TotalRefundedAmount,
            DateTime TransactionDate, DateTime UpdatedTransactionDate)
        {
            this.ID = ID;
            this.BookingID = BookingID;
            this.PaymentMethod = PaymentMethod;
            this.PaidInitialTotalDueAmount = PaidInitialTotalDueAmount;
            this.ActualTotalDueAmount = ActualTotalDueAmount;
            this.TotalRemaining = TotalRemaining;
            this.TotalRefundedAmount = TotalRefundedAmount;
            this.TransactionDate = TransactionDate;
            this.UpdatedTransactionDate = UpdatedTransactionDate;

            this.Mode = enMode.Update;
        }

        private bool _AddNewRentalTransaction()
        {
            this.ID = clsRentalTransactionDataAccess.AddNewRentalTransaction(BookingID, 
                PaymentMethod, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRemaining, 
                TotalRefundedAmount, TransactionDate, UpdatedTransactionDate);

            return this.ID != -1;
        }

        private bool _UpdateRentalTransaction()
        {
            return clsRentalTransactionDataAccess.UpdateRentalTransaction(ID, BookingID,
                PaymentMethod, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRemaining,
                TotalRefundedAmount, TransactionDate, UpdatedTransactionDate);
        }

        public static clsRentalTransaction Find(int TransactionID)
        {
            int BookingID = -1;
            string PaymentMethod = "";
            decimal PaidInitialTotalDueAmount = 0;
            decimal ActualTotalDueAmount = 0;
            decimal TotalRemaining = 0;
            decimal TotalRefundedAmount = 0;
            DateTime TransactionDate = DateTime.MinValue;
            DateTime UpdatedTransactionDate = DateTime.MinValue;
            
            if (clsRentalTransactionDataAccess.GetRentalTransactionInfoByID(TransactionID, 
                ref BookingID, ref PaymentMethod, ref PaidInitialTotalDueAmount,
                ref ActualTotalDueAmount, ref TotalRemaining, ref TotalRefundedAmount, 
                ref TransactionDate, ref UpdatedTransactionDate))

                return new clsRentalTransaction(TransactionID, BookingID, 
                    PaymentMethod, PaidInitialTotalDueAmount, ActualTotalDueAmount, 
                    TotalRemaining, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate);

            else

                return null;
        }

        public static DataView GetAllRentalTransactions()
        {
            return clsRentalTransactionDataAccess.GetAllRentalTransactions();
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRentalTransaction())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateRentalTransaction();

                default: return false;
            }
        }

        public static bool DeleteRentalTransaction(int TransactionID)
        {
            return clsRentalTransactionDataAccess.DeleteRentalTransaction(TransactionID);
        }

        public void UpdateValues(clsVehicleReturn Return)
        {
            decimal TotalAmountDifference = Return.ActualTotalDueAmount - this.PaidInitialTotalDueAmount;

            if (TotalAmountDifference > 0)
            {
                this.TotalRemaining = TotalAmountDifference;
            }
            else if (TotalAmountDifference < 0)
            {
                this.TotalRefundedAmount = -TotalAmountDifference; 
            }

            this.ActualTotalDueAmount = Return.ActualTotalDueAmount;
            
            this.UpdatedTransactionDate = DateTime.Now;
        }

    }
}
