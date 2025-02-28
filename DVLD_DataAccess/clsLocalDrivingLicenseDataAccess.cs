using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace DVLD_DataAccess 
{
    public class clsLocalDrivingLicenseDataAccess
    {

        public static bool GetLocalDrivingLicenseInfoByID(int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    ApplicationID = Convert.ToInt32(reader["ApplicationID"]);
                    LicenseClassID = Convert.ToInt32(reader["LicenseClassID"]);
                  

                }
                else
                {
                    IsFound = false;
                }

                reader.Close();
            }
            catch (Exception e)
            {
                //clsDataAccessSettings.SaveToEventLog(e.Message, EventLogEntryType.Error);
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;

        }

        public static bool GetLocalDrivingLicenseInfoByApplicationID(int ApplicationID, ref int LocalDrivingLicenseApplicationID, ref int LicenseClassID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from LocalDrivingLicenseApplications where ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    LocalDrivingLicenseApplicationID = Convert.ToInt32(reader["LocalDrivingLicenseApplicationID"]);
                    LicenseClassID = Convert.ToInt32(reader["LicenseClassID"]);


                }
                else
                {
                    IsFound = false;
                }

                reader.Close();
            }
            catch (Exception e)
            {
                //clsDataAccessSettings.SaveToEventLog(e.Message, EventLogEntryType.Error);
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;

        }


        public static bool AddNewLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID)
        {
            int rowAffect = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO [dbo].[LocalDrivingLicenseApplications]([ApplicationID],[LicenseClassID]) VALUES(@ApplicationID,@LicenseClassID)";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                rowAffect = command.ExecuteNonQuery();

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

            return (rowAffect != -1);

        }

        //public static bool UpdateLocalDrivingLicense(int LocalDrivingLicenseApplicationID, int ApplicationID, string LicenseClassID, string Password, bool isActive)
        //{
        //    int rowsAffected = 0;

        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string query = "Update[dbo].[LocalDrivingLicenses] set ApplicationID =@ApplicationID,[LicenseClassID] =@LicenseClassID,Password =@Password, isActive =@isActive where LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID;";
        //    SqlCommand command = new SqlCommand(query, connection);

        //    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
        //    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
        //    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
        //    command.Parameters.AddWithValue("@Password", Password);
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

        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Delete [dbo].[LocalDrivingLicenseApplications] where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                string error = e.Message;
                //Console.WriteLine("Handle the error later");
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);

        }


        public static DataTable GetAllLocalDrivingLicenseApplication()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select distinct *  from GetLocalDrivingLicenseApplicationUsingUnion_View";
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

       
        public static bool isHaveComplatedOrNewApplicationInTheSelectedLicenseClass(int ApplicantID,int LicenseClassID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select Found = 1 from NewAndComplatedApplications_View where ApplicantID = @ApplicantID and LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicantID", ApplicantID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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

        public static int GetPassedTestsNumberForLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            int PassedTests = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select [Passed Tests]  from GetLocalDrivingLicenseApplicationUsingUnion_View where [L.D.L.AppID] = @LocalDrivingLicenseApplicationID ";
           
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out  PassedTests))
                {
                    ///
                }

            }
            catch (Exception e)
            {
                //Console.WriteLine("Handle the error later");

            }
            finally
            {
                connection.Close();
            }

            return PassedTests;
        }

        //public static bool isApplicationExistInLocalDrivingLicenses(int ApplicationID)
        //{
        //    bool isFound = false;
        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string query = "Select Found =1 from [LocalDrivingLicenses] where ApplicationID = @ApplicationID ";

        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

        //    try
        //    {
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();

        //        isFound = reader.HasRows;
        //        reader.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        //Console.WriteLine("Handle the error later");

        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return isFound;

        //}

        //public static bool isLocalDrivingLicenseExist(string LicenseClassID)
        //{
        //    bool isFound = false;
        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string query = "Select Found =1 from [LocalDrivingLicenses] where LicenseClassID = @LicenseClassID ";

        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

        //    try
        //    {
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();

        //        isFound = reader.HasRows;
        //        reader.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        string M = e.Message;
        //        //Console.WriteLine("Handle the error later");
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return isFound;

        //}
    }
}
