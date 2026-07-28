using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRentalDataAccessLayer
{
    public class clsRentalTransactionDataAccess
    {
        public static bool GetRentalTransactionInfoByID(int ID, ref int BookingID, 
            ref string PaymentMethod, ref decimal PaidInitialTotalDueAmount,
            ref decimal ActualTotalDueAmount, ref decimal TotalRemaining, ref decimal TotalRefundedAmount,
            ref DateTime TransactionDate, ref DateTime UpdatedTransactionDate)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM RentalTransactions WHERE TransactionID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    BookingID = (int)reader["BookingID"];
                    PaymentMethod = (string)reader["PaymentMethod"];
                    PaidInitialTotalDueAmount = (decimal)reader["PaidInitialTotalDueAmount"];
                    ActualTotalDueAmount = (decimal)reader["ActualTotalDueAmount"];
                    TotalRemaining = (decimal)reader["TotalRemaining"];
                    TotalRefundedAmount = (decimal)reader["TotalRefundedAmount"];
                    TransactionDate = (DateTime)reader["TransactionDate"];

                    if (reader["UpdatedTransactionDate"] != DBNull.Value)
                        UpdatedTransactionDate = (DateTime)reader["UpdatedTransactionDate"];
                    else
                        UpdatedTransactionDate = DateTime.MinValue;
                }
                else
                {
                    IsFound = false;
                }

                reader.Close();
            }
            catch (Exception)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }


        public static int AddNewRentalTransaction(int BookingID, string PaymentMethod, 
            decimal PaidInitialTotalDueAmount, decimal ActualTotalDueAmount, decimal TotalRemaining, 
            decimal TotalRefundedAmount, DateTime TransactionDate, DateTime UpdatedTransactionDate)
        {
            int RentalTransactionID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO RentalTransactions
                 (
                     BookingID,
                     PaymentMethod,
                     PaidInitialTotalDueAmount,
                     ActualTotalDueAmount,
                     TotalRemaining,
                     TotalRefundedAmount,
                     TransactionDate,
                     UpdatedTransactionDate
                 )
                 VALUES
                 (
                     @BookingID,
                     @PaymentMethod,
                     @PaidInitialTotalDueAmount,
                     @ActualTotalDueAmount,
                     @TotalRemaining,
                     @TotalRefundedAmount,
                     @TransactionDate,
                     @UpdatedTransactionDate
                 );

                 SELECT CAST(SCOPE_IDENTITY() AS INT);";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookingID", BookingID);
            command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
            command.Parameters.AddWithValue("@PaidInitialTotalDueAmount", PaidInitialTotalDueAmount);
            command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);
            command.Parameters.AddWithValue("@TotalRemaining", TotalRemaining);
            command.Parameters.AddWithValue("@TotalRefundedAmount", TotalRefundedAmount);
            command.Parameters.AddWithValue("@TransactionDate", TransactionDate);

            if (UpdatedTransactionDate == DateTime.MinValue)
                command.Parameters.AddWithValue("@UpdatedTransactionDate", DBNull.Value);
            else
                command.Parameters.AddWithValue("@UpdatedTransactionDate", UpdatedTransactionDate);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    RentalTransactionID = (int)result;

            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return RentalTransactionID;
        }


        public static bool UpdateRentalTransaction(int ID, int BookingID, 
            string PaymentMethod, decimal PaidInitialTotalDueAmount, decimal ActualTotalDueAmount, 
            decimal TotalRemaining, decimal TotalRefundedAmount, DateTime TransactionDate, 
            DateTime UpdatedTransactionDate)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE RentalTransactions
                             SET BookingID = @BookingID,
                                 PaymentMethod = @PaymentMethod,
                                 PaidInitialTotalDueAmount = @PaidInitialTotalDueAmount,
                                 ActualTotalDueAmount = @ActualTotalDueAmount,
                                 TotalRemaining = @TotalRemaining,
                                 TotalRefundedAmount = @TotalRefundedAmount,
                                 TransactionDate = @TransactionDate,
                                 UpdatedTransactionDate = @UpdatedTransactionDate
                             WHERE TransactionID = @TransactionID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TransactionID", ID);
            command.Parameters.AddWithValue("@BookingID", BookingID);
            command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
            command.Parameters.AddWithValue("@PaidInitialTotalDueAmount", PaidInitialTotalDueAmount);
            command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);
            command.Parameters.AddWithValue("@TotalRemaining", TotalRemaining);
            command.Parameters.AddWithValue("@TotalRefundedAmount", TotalRefundedAmount);
            command.Parameters.AddWithValue("@TransactionDate", TransactionDate);

            if (UpdatedTransactionDate == DateTime.MinValue)
                command.Parameters.AddWithValue("@UpdatedTransactionDate", DBNull.Value);
            else
                command.Parameters.AddWithValue("@UpdatedTransactionDate", UpdatedTransactionDate);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


        public static bool DeleteRentalTransaction(int TransactionID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM RentalTransactions WHERE TransactionID = @TransactionID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransactionID", TransactionID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


        public static DataTable GetAllRentalTransactions()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM vwTransactionsList";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dataTable.Load(reader);

                reader.Close();

            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }

    }
}
