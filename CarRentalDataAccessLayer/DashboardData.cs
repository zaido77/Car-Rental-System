using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalDataAccessLayer
{
    public static class clsDashboardDataAccess
    {
        public static bool GetDashboardData(ref int AvailableVehicles, ref int TotalVehicles, 
            ref int CurrentRentalsCount, ref decimal CurrentMonthRevenue, ref decimal LastMonthRevenue,
            ref DataTable dtPendingReturns, ref DataTable dtRecentBookings)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT
	                         AvailableVehicles = (SELECT COUNT(*) FROM Vehicles WHERE IsAvailableForRent = 1),
	                         TotalVehicles = (SELECT COUNT(*) FROM Vehicles),
	                         CurrentRentalsCount = (SELECT COUNT(*) FROM RentalBookings WHERE BookingStatus = 1),
	                         CurrentMonthRevenue = (SELECT ISNULL(SUM(ActualTotalDueAmount), 0) FROM RentalTransactions
                                                   WHERE MONTH(TransactionDate) = MONTH(GETDATE()) 
                                                   AND YEAR(TransactionDate) = YEAR(GETDATE())),
                             LastMonthRevenue = (SELECT ISNULL(SUM(ActualTotalDueAmount), 0) FROM RentalTransactions
                                        WHERE MONTH(TransactionDate) = MONTH(DATEADD(month, -1, GETDATE())) 
                                        AND YEAR(TransactionDate) = YEAR(DATEADD(month, -1, GETDATE())));

                             SELECT * FROM vwPendingReturns

                             SELECT * FROM vwRecentBookings";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    AvailableVehicles = (int)reader["AvailableVehicles"];
                    TotalVehicles = (int)reader["TotalVehicles"];
                    CurrentRentalsCount = (int)reader["CurrentRentalsCount"];
                    CurrentMonthRevenue = (decimal)reader["CurrentMonthRevenue"];
                    LastMonthRevenue = (decimal)reader["LastMonthRevenue"];
                }

                if (reader.NextResult())
                {
                    dtPendingReturns.Load(reader);
                }

                dtRecentBookings.Load(reader);

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
    }
}
