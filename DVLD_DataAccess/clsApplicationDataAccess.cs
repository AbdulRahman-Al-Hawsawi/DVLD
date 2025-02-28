using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DVLD_DataAccess
{
    public class clsApplicationDataAccess
    {

        public static bool GetApplicationInfoByID(int ApplicationID, ref int ApplicationPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID, ref int ApplicationStatus, ref DateTime LastStatusDate, ref double PaidFees, ref int CreatedByUserID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from Applications where ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ApplicationPersonID = Convert.ToInt32(reader["ApplicantPersonID"]);
                    ApplicationDate = Convert.ToDateTime(reader["ApplicationDate"]);
                    ApplicationTypeID = Convert.ToInt32(reader["ApplicationTypeID"]);
                    ApplicationStatus = Convert.ToInt32(reader["ApplicationStatusID"]);
                    LastStatusDate = Convert.ToDateTime(reader["LastStatusDate"]);
                    PaidFees = Convert.ToDouble(reader["PaidFees"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    
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

        public static bool GetPersonInfoByNationalNO(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref string Gender, ref string Address, ref string Email, ref string Phone, ref int CountryID, ref string ImagePath)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from People where ApplicationPersonID = @ApplicationPersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationPersonID", NationalNo);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    PersonID = Convert.ToInt32(reader["ApplicationID"]);
                    FirstName = Convert.ToString(reader["ApplicationDate"]);
                    SecondName = Convert.ToString(reader["ApplicationTypeID"]);
                    ThirdName = Convert.ToString(reader["ApplicationStatus"]);
                    LastName = Convert.ToString(reader["LastStatusDate"]);
                    DateOfBirth = Convert.ToDateTime(reader["PaidFees"]);
                    Gender = Convert.ToString(reader["CreatedByUserID"]);
                    Address = Convert.ToString(reader["Address"]);
                    Email = Convert.ToString(reader["Email"]);
                    Phone = Convert.ToString(reader["Phone"]);
                    CountryID = Convert.ToInt32(reader["NationalityCountryID"]);
                    ImagePath = Convert.ToString(reader["ImagePath"].ToString());

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

        public static int AddNewApplication(int ApplicationPersonID,  DateTime ApplicationDate,  int ApplicationTypeID,  int ApplicationStatusID,  DateTime LastStatusDate,  double PaidFees,  int CreatedByUserID)
        {
            int ApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO [dbo].[Applications]([ApplicantPersonID],[ApplicationDate],[ApplicationTypeID],[ApplicationStatusID],[LastStatusDate],[PaidFees],[CreatedByUserID])VALUES(@ApplicantPersonID,@ApplicationDate,@ApplicationTypeID,@ApplicationStatusID,@LastStatusDate,@PaidFees,@CreatedByUserID);SELECT SCOPE_IDENTITY();";
                   

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicationPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatusID", ApplicationStatusID);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
           
           
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                int InsertedID;

                if (result != null && int.TryParse(result.ToString(), out  InsertedID))
                {
                    ApplicationID = InsertedID;
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

            return ApplicationID;

        }

        public static bool UpdateApplication(int ApplicationID, int ApplicationPersonID, int ApplicationTypeID, int ApplicationStatusID, DateTime LastStatusDate, double PaidFees)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Update[dbo].[Applications] set ApplicantPersonID =@ApplicantPersonID,ApplicationTypeID =@ApplicationTypeID, ApplicationStatusID =@ApplicationStatusID,[LastStatusDate] =@LastStatusDate,[PaidFees] =@PaidFees Where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicationPersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatusID", ApplicationStatusID);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);

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

        public static bool DeleteApplication(int ApplicationID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Delete [dbo].[Applications] where ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Handle the error later");
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);

        }

        public static DataTable GetAllApplications()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select * from LocalDrivingLicenseApplications_View";
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

        public static bool isApplicationExist(int ApplicationID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select Found =1 from [Applications] where ApplicationID = @ApplicationID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

        public static bool isPersonExist(string PersonID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select Found =1 from [Applications] where ApplicationPersonID = @ApplicationPersonID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationPersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception e)
            {
                string M = e.Message;
                //Console.WriteLine("Handle the error later");
            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        public static string GetApplicationStatus(int ApplicationStatusID)
        
        {
            string StatusTitle = "";
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select Status from ApplicationStatus where ApplicationStatusID = @ApplicationStatusID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationStatusID", ApplicationStatusID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
               

                if (result != null   )
                {
                   StatusTitle = result.ToString();
                }


                
            }
            catch (Exception e)
            {
                clsDataAccessSettings.SaveToEventLog(e.Message, EventLogEntryType.Error);
                
            }
            finally
            {
                connection.Close();
            }

            return StatusTitle;

        }

    }
}
