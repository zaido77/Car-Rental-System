using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRentalDataAccessLayer
{
    public class clsMaintenanceDataAccess
    {
        public static bool GetMaintenanceInfoByID(int ID, ref int VehicleID, ref string Description,
            ref DateTime MaintenanceDate, ref decimal Cost, ref bool IsCompleted)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Maintenances WHERE MaintenanceID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    VehicleID = (int)reader["VehicleID"];
                    Description = (string)reader["Description"];
                    MaintenanceDate = (DateTime)reader["MaintenanceDate"];
                    Cost = (decimal)reader["Cost"];
                    IsCompleted = (bool)reader["IsCompleted"];   
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

        public static int AddNewMaintenance(int VehicleID, string Description,
            DateTime MaintenanceDate, decimal Cost, bool IsCompleted)
        {
            int MaintenanceID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Maintenances (VehicleID, Description,
                     MaintenanceDate, Cost, IsCompleted)
                     VALUES
                     (@VehicleID, @Description,
                     @MaintenanceDate, @Cost, @IsCompleted);

                     SELECT CAST(SCOPE_IDENTITY() AS INT);";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@MaintenanceDate", MaintenanceDate);
            command.Parameters.AddWithValue("@Cost", Cost);
            command.Parameters.AddWithValue("@IsCompleted", IsCompleted);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    MaintenanceID = (int)result;

            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return MaintenanceID;
        }

        public static bool UpdateMaintenance(int ID, int VehicleID, string Description,
            decimal Cost, bool IsCompleted)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Maintenances
                         SET VehicleID = @VehicleID,
                             Description = @Description,
                             Cost = @Cost,
                             IsCompleted = @IsCompleted
                         WHERE MaintenanceID = @MaintenanceID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MaintenanceID", ID);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Cost", Cost);
            command.Parameters.AddWithValue("@IsCompleted", IsCompleted);

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

        public static bool DeleteMaintenance(int MaintenanceID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM Maintenances WHERE MaintenanceID = @MaintenanceID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaintenanceID", MaintenanceID);

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

        public static bool CompleteMaintenance(int MaintenanceID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Maintenances
                             SET IsCompleted = 1
                             WHERE MaintenanceID = @MaintenanceID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaintenanceID", MaintenanceID);

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

        public static DataTable GetAllMaintenances()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM vwMaintenancesList";

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
