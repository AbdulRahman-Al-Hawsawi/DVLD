using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace DVLD_DataAccess
{
    public class clsDriverDataAccess
    {
        public static bool GetDriverInfoByID(int DriverID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from Drivers where DriverID = @DriverID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = Convert.ToInt32(reader["PersonID"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);

                }
                else
                {
                    IsFound = false;
                }

                reader.Close();
            }
            catch (Exception e)
            {
                clsDataAccessSettings.SaveToEventLog(e.Message, EventLogEntryType.Error);
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;

        }

        public static bool GetDriverInfoByPersonID(int PersonID, ref int DriverID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from Drivers where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    DriverID = Convert.ToInt32(reader["DriverID"]);
                    CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                   
                }
                else
                {
                    IsFound = false;
                }

                reader.Close();
            }
            catch (Exception e)
            {
                clsDataAccessSettings.SaveToEventLog(e.Message, EventLogEntryType.Error);
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;

        }

        public static int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            int DriverID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO [dbo].[Drivers]([PersonID],[CreatedByUserID],[CreatedDate]) Values(@PersonID,@CreatedByUserID,@CreatedDate); Select Scope_Identity();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
           

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                int InsertedID;

                if (result != null && int.TryParse(result.ToString(), out  InsertedID))
                {
                    DriverID = InsertedID;
                }

            }
            catch (Exception e)
            {
                string error = e.Message;
                clsDataAccessSettings.SaveToEventLog(e.Message, EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }

            return DriverID;

        }

        public static bool UpdateDriver(int DriverID, int PersonID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Update[dbo].[Drivers] set PersonID =@PersonID where DriverID =@DriverID;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                string errormessage = e.Message;

                //Console.WriteLine("Handle the error later");
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);

        }

        public static bool DeleteDriver(int DriverID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Delete [dbo].[Drivers] where DriverID = @DriverID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //Console.WriteLine("Handle the error later");
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);

        }

        public static DataTable GetAllDrivers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select  distinct * from GetAllDrivers";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                //Console.WriteLine("Handle the error later");

            }
            finally
            {
                connection.Close();
            }

            return dt;


        }

        public static bool isDriverExist(int DriverID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select Found =1 from [Drivers] where DriverID = @DriverID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception e)
            {
                //Console.WriteLine("Handle the error later");

            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        public static bool isPersonExistInDrivers(int PersonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select Found =1 from [Drivers] where PersonID = @PersonID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception e)
            {
                //Console.WriteLine("Handle the error later");

            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

       
    }
}
