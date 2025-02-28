using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DVLD_DataAccess
{
    public class clsRetakeTestDataAccess
    {


        public static bool GetRetakeTestInfoByID(int RetakeTestApplicationID, ref int LocalDrivingLicenseApplicationID, ref double RetakeTestFees, ref double RetakeTestTotalFees)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from RetakeTests where RetakeTestApplicationID = @RetakeTestApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    LocalDrivingLicenseApplicationID = Convert.ToInt32(reader["LocalDrivingLicenseApplicationID"]);
                    RetakeTestFees = Convert.ToDouble(reader["RetakeTestFees"]);
                    RetakeTestTotalFees = Convert.ToDouble(reader["RetakeTestTotalFees"]);
                    
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

        public static int AddNewRetakeTest(int LocalDrivingLicenseApplicationID, double RetakeTestFees, double RetakeTestTotalFees)
        {
            int RetakeTestApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO [dbo].[RetakeTests]([LocalDrivingLicenseApplicationID],[RetakeTestFees],[RetakeTestTotalFees]) Values(@LocalDrivingLicenseApplicationID,@RetakeTestFees,@RetakeTestTotalFees); Select Scope_Identity();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@RetakeTestFees", RetakeTestFees);
            command.Parameters.AddWithValue("@RetakeTestTotalFees", RetakeTestTotalFees);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                int InsertedID;

                if (result != null && int.TryParse(result.ToString(), out  InsertedID))
                {
                    RetakeTestApplicationID = InsertedID;
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

            return RetakeTestApplicationID;

        }

        public static DataTable GetAllRetakeTests()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select * from RetakeTests";
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

        public static bool DeleteRetakeTestByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Delete [dbo].[RetakeTests] where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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


        //public static bool UpdateRetakeTest(int RetakeTestApplicationID, int LocalDrivingLicenseApplicationID, double RetakeTestFees, string RetakeTestTotalFees, bool isActive)
        //{
        //    int rowsAffected = 0;

        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string query = "Update[dbo].[RetakeTests] set LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID,[RetakeTestFees] =@RetakeTestFees,RetakeTestTotalFees =@RetakeTestTotalFees, isActive =@isActive where RetakeTestApplicationID =@RetakeTestApplicationID;";
        //    SqlCommand command = new SqlCommand(query, connection);

        //    command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
        //    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
        //    command.Parameters.AddWithValue("@RetakeTestFees", RetakeTestFees);
        //    command.Parameters.AddWithValue("@RetakeTestTotalFees", RetakeTestTotalFees);
        //    command.Parameters.AddWithValue("@isActive", isActive);


        //    try
        //    {
        //        connection.Open();
        //        rowsAffected = command.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //        string errormessage = e.Message;

        //        //Console.WriteLine("Handle the error later");
        //        return false;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return (rowsAffected > 0);

        //}

        //public static bool DeleteRetakeTest(int RetakeTestApplicationID)
        //{
        //    int rowsAffected = 0;
        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string query = "Delete [dbo].[RetakeTests] where RetakeTestApplicationID = @RetakeTestApplicationID";
        //    SqlCommand command = new SqlCommand(query, connection);

        //    command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);

        //    try
        //    {
        //        connection.Open();
        //        rowsAffected = command.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //        //Console.WriteLine("Handle the error later");
        //        return false;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return (rowsAffected > 0);

        //}




    }
}
