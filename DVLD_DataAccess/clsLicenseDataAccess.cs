using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DVLD_DataAccess
{
    public class clsLicenseDataAccess
    {

        public static bool GetLicenseInfoByID(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClassID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref double PaidFees, ref bool IsActive, ref int IssueReasonID, ref int CreatedByUserID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from Licenses where LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ApplicationID = Convert.ToInt32(reader["ApplicationID"]);
                    DriverID = Convert.ToInt32(reader["DriverID"]);
                    LicenseClassID = Convert.ToInt32(reader["LicenseClassID"]);
                    IssueDate = Convert.ToDateTime(reader["IssueDate"]);
                    ExpirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                    Notes = Convert.ToString(reader["Notes"]);
                    PaidFees = Convert.ToDouble(reader["PaidFees"]);
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
                    IssueReasonID = Convert.ToInt32(reader["IssueReasonID"]);
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


        public static bool GetLicenseInfoByApplicationID(int ApplicationID , ref int LicenseID, ref int DriverID, ref int LicenseClassID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref double PaidFees, ref bool IsActive, ref int IssueReasonID, ref int CreatedByUserID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from Licenses where ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    LicenseID = Convert.ToInt32(reader["LicenseID"]);
                    DriverID = Convert.ToInt32(reader["DriverID"]);
                    LicenseClassID = Convert.ToInt32(reader["LicenseClassID"]);
                    IssueDate = Convert.ToDateTime(reader["IssueDate"]);
                    ExpirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                    Notes = Convert.ToString(reader["Notes"]);
                    PaidFees = Convert.ToDouble(reader["PaidFees"]);
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
                    IssueReasonID = Convert.ToInt32(reader["IssueReasonID"]);
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
            string query = "Select * from People where ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", NationalNo);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    PersonID = Convert.ToInt32(reader["LicenseID"]);
                    FirstName = Convert.ToString(reader["IssueDate"]);
                    SecondName = Convert.ToString(reader["DriverID"]);
                    ThirdName = Convert.ToString(reader["LicenseClassID"]);
                    LastName = Convert.ToString(reader["ExpirationDate"]);
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

        public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate,string Notes, double PaidFees,bool IsActive,int IssueReasonID, int CreatedByUserID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO [dbo].[Licenses]([ApplicationID],[DriverID],[LicenseClassID],[IssueDate],[ExpirationDate],[Notes],[PaidFees],[IsActive],[IssueReasonID],[CreatedByUserID])VALUES(@ApplicantPersonID,@DriverID,@LicenseClassID,@IssueDate,@ExpirationDate,@Notes,@PaidFees,@IsActive,@IssueReasonID,@CreatedByUserID);SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReasonID", IssueReasonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            if(string.IsNullOrWhiteSpace(Notes))
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
             else
                command.Parameters.AddWithValue("@Notes", Notes);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                int InsertedID;

                if (result != null && int.TryParse(result.ToString(), out  InsertedID))
                {
                    LicenseID = InsertedID;
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

            return LicenseID;

        }

        public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime ExpirationDate,string Notes, double PaidFees,bool IsActive,int IssueReasonID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Update[dbo].[Licenses] set ApplicationID =@ApplicationID,DriverID =@DriverID, LicenseClassID =@LicenseClassID,[ExpirationDate] =@ExpirationDate,[PaidFees] =@PaidFees,Notes =@Notes, IssueReasonID = @IssueReasonID, IsActive = @IsActive Where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReasonID", IssueReasonID);


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

        public static bool DeleteLicense(int LicenseID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Delete [dbo].[Licenses] where LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

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

        public static DataTable GetAllLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select * from Licenses";
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

        public static DataTable GetAllDriverLicenses(int DriverID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select [Lic.ID],[App.ID],[Class Name],[Issue Date],[Expiration Date],[Is Active] from AllDriverLocalLicenses where DriverID =@DriverID order by [Lic.ID] desc";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

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


        public static bool isLicenseExist(int LicenseID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select Found =1 from [Licenses] where LicenseID = @LicenseID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

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


        public static bool isLicenseExistByDriverIdAndClassID(int DriverID,int LicenseClassID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select Found =1 from [Licenses] where DriverID = @DriverID and LicenseClassID = @LicenseClassID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
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










        //public static bool isPersonExist(string PersonID)
        //{
        //    bool isFound = false;
        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string query = "Select Found =1 from [Licenses] where ApplicationID = @ApplicationID ";

        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@ApplicationID", PersonID);

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

        //public static string GetLicenseClassID(int LicenseClassID)
        //{
        //    string StatusTitle = "";
        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
        //    string query = "Select Status from LicenseClassID where LicenseClassID = @LicenseClassID";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

        //    try
        //    {
        //        connection.Open();

        //        object result = command.ExecuteScalar();


        //        if (result != null)
        //        {
        //            StatusTitle = result.ToString();
        //        }



        //    }
        //    catch (Exception e)
        //    {
        //        clsDataAccessSettings.SaveToEventLog(e.Message, EventLogEntryType.Error);

        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return StatusTitle;

        //}

    }
}
