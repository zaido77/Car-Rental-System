using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;

namespace CarRentalDataAccessLayer
{
    public class clsVehicleDataAccess
    {
        public static bool GetVehicleInfoByID(int ID, ref string Make, ref string Model, ref short Year, 
            ref int Mileage, ref int FuelTypeID, ref string PlateNumber, ref int CategoryID,
            ref decimal RentalPricePerDay, ref bool IsAvailableForRent, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Vehicles WHERE VehicleID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    Make = (string)reader["Make"];
                    Model = (string)reader["Model"];
                    Year = (short)reader["Year"];
                    Mileage = (int)reader["Mileage"];
                    FuelTypeID = (int)reader["FuelTypeID"];
                    PlateNumber = (string)reader["PlateNumber"];
                    CategoryID = (int)reader["CategoryID"];
                    RentalPricePerDay = (decimal)reader["RentalPricePerDay"];
                    IsAvailableForRent = (bool)reader["IsAvailableForRent"];

                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";

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

        public static bool GetVehicleInfoByPlateNumber(string PlateNumber, ref int VehicleID, ref string Make, 
            ref string Model, ref short Year, ref int Mileage, ref int FuelTypeID, ref int CategoryID,
            ref decimal RentalPricePerDay, ref bool IsAvailableForRent, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Vehicles WHERE PlateNumber = @PlateNumber";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PlateNumber", PlateNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    VehicleID = (int)reader["VehicleID"];
                    Make = (string)reader["Make"];
                    Model = (string)reader["Model"];
                    Year = (short)reader["Year"];
                    Mileage = (int)reader["Mileage"];
                    FuelTypeID = (int)reader["FuelTypeID"];
                    PlateNumber = (string)reader["PlateNumber"];
                    CategoryID = (int)reader["CategoryID"];
                    RentalPricePerDay = (decimal)reader["RentalPricePerDay"];
                    IsAvailableForRent = (bool)reader["IsAvailableForRent"];

                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";

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

        public static int AddNewVehicle(string Make, string Model, short Year,
            int Mileage, int FuelTypeID, string PlateNumber, int CategoryID,
            decimal RentalPricePerDay, bool IsAvailableForRent, string ImagePath)
        {
            int VehicleID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Vehicles
                             (
                                 Make,
                                 Model,
                                 Year,
                                 Mileage,
                                 FuelTypeID,
                                 PlateNumber,
                                 CategoryID,
                                 RentalPricePerDay,
                                 IsAvailableForRent,
                                 ImagePath
                             )
                             VALUES
                             (
                                 @Make,
                                 @Model,
                                 @Year,
                                 @Mileage,
                                 @FuelTypeID,
                                 @PlateNumber,
                                 @CategoryID,
                                 @RentalPricePerDay,
                                 @IsAvailableForRent,
                                 @ImagePath
                             );
                             
                             SELECT CAST(SCOPE_IDENTITY() AS INT);";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Make", Make);
            command.Parameters.AddWithValue("@Model", Model);
            command.Parameters.AddWithValue("@Year", Year);
            command.Parameters.AddWithValue("@Mileage", Mileage);
            command.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);
            command.Parameters.AddWithValue("@PlateNumber", PlateNumber);
            command.Parameters.AddWithValue("@CategoryID", CategoryID);
            command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
            command.Parameters.AddWithValue("@IsAvailableForRent", IsAvailableForRent);

            if (!string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    VehicleID = (int)result;

            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return VehicleID;
        }

        public static bool UpdateVehicle(int ID, string Make, string Model, short Year,
            int Mileage, int FuelTypeID, string PlateNumber, int CategoryID,
            decimal RentalPricePerDay, bool IsAvailableForRent, string ImagePath)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Vehicles
                             SET Make = @Make,
                                 Model = @Model,
                                 Year = @Year,
                                 Mileage = @Mileage,
                                 FuelTypeID = @FuelTypeID,
                                 PlateNumber = @PlateNumber,
                                 CategoryID = @CategoryID,
                                 RentalPricePerDay = @RentalPricePerDay,
                                 IsAvailableForRent = @IsAvailableForRent,
                                 ImagePath = @ImagePath
                             WHERE VehicleID = @VehicleID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@VehicleID", ID);
            command.Parameters.AddWithValue("@Make", Make);
            command.Parameters.AddWithValue("@Model", Model);
            command.Parameters.AddWithValue("@Year", Year);
            command.Parameters.AddWithValue("@Mileage", Mileage);
            command.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);
            command.Parameters.AddWithValue("@PlateNumber", PlateNumber);
            command.Parameters.AddWithValue("@CategoryID", CategoryID);
            command.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
            command.Parameters.AddWithValue("@IsAvailableForRent", IsAvailableForRent);

            if (!string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

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

        public static bool DeleteVehicle(int VehicleID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM Vehicles WHERE VehicleID = @VehicleID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);

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

        public static bool SetAvailability(int VehicleID, bool IsAvailableForRent)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Vehicles
                             SET IsAvailableForRent = @IsAvailableForRent
                             WHERE VehicleID = @VehicleID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@VehicleID", VehicleID);
            command.Parameters.AddWithValue("@IsAvailableForRent", IsAvailableForRent);

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

        public static DataView GetAllVehicles()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM vwVehiclesList";

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

            return dataTable.DefaultView;
        }

    }
}
