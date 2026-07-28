using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRentalDataAccessLayer
{
    public class clsRentalBookingDataAccess
    {
        public static bool GetRentalBookingInfoByID(int ID, ref int CustomerID, ref int VehicleID,
            ref DateTime StartDate, ref DateTime EndDate, ref string PickupLocation,
            ref string DropoffLocation, ref byte InitialRentalDays, ref decimal RentalPricePerDay,
            ref string InitialCheckNotes, ref byte BookingStatus, ref DateTime CreatedDate)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM RentalBookings WHERE BookingID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    CustomerID = (int)reader["CustomerID"];
                    VehicleID = (int)reader["VehicleID"];
                    StartDate = (DateTime)reader["StartDate"];
                    EndDate = (DateTime)reader["EndDate"];
                    PickupLocation = (string)reader["PickupLocation"];
                    DropoffLocation = (string)reader["DropoffLocation"];
                    InitialRentalDays = (byte)reader["InitialRentalDays"];
                    RentalPricePerDay = (decimal)reader["RentalPricePerDay"];
                    BookingStatus = (byte)reader["BookingStatus"];
                    CreatedDate = (DateTime)reader["CreatedDate"];

                    if (reader["InitialCheckNotes"] != DBNull.Value)
                        InitialCheckNotes = (string)reader["InitialCheckNotes"];
                    else
                        InitialCheckNotes = "";
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


        public static int AddNewRentalBooking(int CustomerID, int VehicleID,
            DateTime StartDate, DateTime EndDate, string PickupLocation,
            string DropoffLocation, byte InitialRentalDays, decimal RentalPricePerDay,
            decimal InitialTotalDueAmount, string InitialCheckNotes, byte BookingStatus, DateTime CreatedDate)
        {
            int RentalBookingID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO RentalBookings (
                     CustomerID,
                     VehicleID,
                     StartDate,
                     EndDate,
                     PickupLocation,
                     DropoffLocation,
                     InitialRentalDays,
                     RentalPricePerDay,
                     InitialTotalDueAmount,
                     InitialCheckNotes,
                     BookingStatus,
                     CreatedDate)
                 VALUES
                     (@CustomerID,
                     @VehicleID,
                     @StartDate,
                     @EndDate,
                     @PickupLocation,
                     @DropoffLocation,
                     @InitialRentalDays,
                     @RentalPricePerDay,
                     @InitialTotalDueAmount,
                     @InitialCheckNotes,
                     @BookingStatus,
                     @CreatedDate);

                 SELECT CAST(SCOPE_IDENTITY() AS INT);";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            command.Parameters.AddWithValue("@StartDate", StartDate);
            command.Parameters.AddWithValue("@EndDate", EndDate);
            command.Parameters.AddWithValue("@PickupLocation", PickupLocation);
            command.Parameters.AddWithValue("@DropoffLocation", DropoffLocation);
            command.Parameters.AddWithValue("@InitialRentalDays", InitialRentalDays);
            command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
            command.Parameters.AddWithValue("@InitialTotalDueAmount", InitialTotalDueAmount);
            command.Parameters.AddWithValue("@BookingStatus", BookingStatus);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            
            if (!string.IsNullOrEmpty(InitialCheckNotes))
                command.Parameters.AddWithValue("@InitialCheckNotes", InitialCheckNotes);
            else
                command.Parameters.AddWithValue("@InitialCheckNotes", DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    RentalBookingID = (int)result;

            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return RentalBookingID;
        }


        public static bool UpdateRentalBooking(int ID, int CustomerID, int VehicleID,
            DateTime StartDate, DateTime EndDate, string PickupLocation,
            string DropoffLocation, byte InitialRentalDays, decimal RentalPricePerDay,
            decimal InitialTotalDueAmount, string InitialCheckNotes, byte BookingStatus)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE RentalBookings
                             SET CustomerID = @CustomerID,
                                 VehicleID = @VehicleID,
                                 StartDate = @StartDate,
                                 EndDate = @EndDate,
                                 PickupLocation = @PickupLocation,
                                 DropoffLocation = @DropoffLocation,
                                 InitialRentalDays = @InitialRentalDays,
                                 RentalPricePerDay = @RentalPricePerDay,
                                 InitialTotalDueAmount = @InitialTotalDueAmount,
                                 InitialCheckNotes = @InitialCheckNotes,
                                 BookingStatus = @BookingStatus
                             WHERE BookingID = @BookingID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookingID", ID);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            command.Parameters.AddWithValue("@StartDate", StartDate);
            command.Parameters.AddWithValue("@EndDate", EndDate);
            command.Parameters.AddWithValue("@PickupLocation", PickupLocation);
            command.Parameters.AddWithValue("@DropoffLocation", DropoffLocation);
            command.Parameters.AddWithValue("@InitialRentalDays", InitialRentalDays);
            command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
            command.Parameters.AddWithValue("@InitialTotalDueAmount", InitialTotalDueAmount);
            command.Parameters.AddWithValue("@BookingStatus", BookingStatus);

            if (!string.IsNullOrEmpty(InitialCheckNotes))
                command.Parameters.AddWithValue("@InitialCheckNotes", InitialCheckNotes);
            else
                command.Parameters.AddWithValue("@InitialCheckNotes", DBNull.Value);

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

        public static bool DeleteRentalBooking(int BookingID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM RentalBookings WHERE BookingID = @BookingID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookingID", BookingID);

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

        public static DataTable GetAllRentalBookings()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM vwRentalBookingsList";

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

        public static bool SetBookingStatus(int BookingID, byte BookingStatus)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE RentalBookings
                             SET BookingStatus = @BookingStatus
                             WHERE BookingID = @BookingID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookingID", BookingID);
            command.Parameters.AddWithValue("@BookingStatus", BookingStatus);

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

        public static DataTable GetVehicleBookingsHistory(int VehicleID)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM vwRentalBookingsList WHERE VehicleID = @VehicleID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);

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

        public static DataTable GetCustomerBookingsHistory(int CustomerID)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM vwRentalBookingsList WHERE CustomerID = @CustomerID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);

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

        public static int GetAllBookingsCount()
        {
            int Count = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT COUNT(*) AS BookingsCount FROM RentalBookings";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    Count = (int)result;

            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return Count;
        }

        public static int GetBookingsCount(byte BookingStatus)
        {
            int Count = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT COUNT(*) AS BookingsCount FROM RentalBookings
                             WHERE BookingStatus = @BookingStatus";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookingStatus", BookingStatus);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    Count = (int)result;
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return Count;
        }

    }
}
