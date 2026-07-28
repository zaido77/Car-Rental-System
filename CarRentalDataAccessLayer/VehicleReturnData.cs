using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Lifetime;

namespace CarRentalDataAccessLayer
{
    public static class clsVehicleReturnDataAccess
    {
        public static bool GetVehicleReturnInfoByID(int ID, ref int TransactionID, ref DateTime ActualReturnDate,
                ref byte ActualRentalDays, ref int Mileage, ref short ConsumedMileage,
                ref string FinalCheckNotes, ref decimal AdditionalCharges, ref decimal ActualTotalDueAmount)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM VehicleReturns WHERE ReturnID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    TransactionID = (int)reader["TransactionID"];
                    ActualReturnDate = (DateTime)reader["ActualReturnDate"];
                    ActualRentalDays = (byte)reader["ActualRentalDays"];
                    Mileage = (int)reader["Mileage"];
                    ConsumedMileage = (short)reader["ConsumedMileage"];
                    FinalCheckNotes = (string)reader["FinalCheckNotes"];
                    AdditionalCharges = (decimal)reader["AdditionalCharges"];
                    ActualTotalDueAmount = (decimal)reader["ActualTotalDueAmount"];
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


        public static int AddNewVehicleReturn(int TransactionID, DateTime ActualReturnDate, byte ActualRentalDays, 
            int Mileage, short ConsumedMileage, string FinalCheckNotes, decimal AdditionalCharges,
            decimal ActualTotalDueAmount)
        {
            int VehicleReturnID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO VehicleReturns
                    (
                        TransactionID,
                        ActualReturnDate,
                        ActualRentalDays,
                        Mileage,
                        ConsumedMileage,
                        FinalCheckNotes,
                        AdditionalCharges,
                        ActualTotalDueAmount
                    )
                    VALUES
                    (
                        @TransactionID,
                        @ActualReturnDate,
                        @ActualRentalDays,
                        @Mileage,
                        @ConsumedMileage,
                        @FinalCheckNotes,
                        @AdditionalCharges,
                        @ActualTotalDueAmount
                    );

                    SELECT CAST(SCOPE_IDENTITY() AS INT);";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TransactionID", TransactionID);
            command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
            command.Parameters.AddWithValue("@ActualRentalDays", ActualRentalDays);
            command.Parameters.AddWithValue("@Mileage", Mileage);
            command.Parameters.AddWithValue("@ConsumedMileage", ConsumedMileage);
            command.Parameters.AddWithValue("@FinalCheckNotes", FinalCheckNotes);
            command.Parameters.AddWithValue("@AdditionalCharges", AdditionalCharges);
            command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    VehicleReturnID = (int)result;

            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return VehicleReturnID;
        }


        public static bool UpdateVehicleReturn(int ID, int TransactionID, DateTime ActualReturnDate, byte ActualRentalDays, 
            int Mileage, short ConsumedMileage, string FinalCheckNotes, decimal AdditionalCharges,
            decimal ActualTotalDueAmount)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE VehicleReturns
                             SET ActualReturnDate = @ActualReturnDate,
                                 ActualRentalDays = @ActualRentalDays,
                                 Mileage = @Mileage,
                                 ConsumedMileage = @ConsumedMileage,
                                 FinalCheckNotes = @FinalCheckNotes,
                                 AdditionalCharges = @AdditionalCharges,
                                 ActualTotalDueAmount = @ActualTotalDueAmount
                             WHERE ReturnID = @ReturnID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReturnID", ID);
            command.Parameters.AddWithValue("@TransactionID", TransactionID);
            command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
            command.Parameters.AddWithValue("@ActualRentalDays", ActualRentalDays);
            command.Parameters.AddWithValue("@Mileage", Mileage);
            command.Parameters.AddWithValue("@ConsumedMileage", ConsumedMileage);
            command.Parameters.AddWithValue("@FinalCheckNotes", FinalCheckNotes);
            command.Parameters.AddWithValue("@AdditionalCharges", AdditionalCharges);
            command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);


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


        public static bool DeleteVehicleReturn(int ReturnID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM VehicleReturns WHERE ReturnID = @ReturnID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ReturnID", ReturnID);

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


        public static DataTable GetAllVehicleReturns()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM vwReturnsList";

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
