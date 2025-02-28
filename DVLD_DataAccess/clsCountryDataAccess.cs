using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_DataAccess
{
    public class clsCountryDataAccess
    {

        public static string GetCountryName(int CountryID)
    {

        string CountryName = "";
        SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
        string query = " Select CountryName from Countries where CountryID =@CountryID";
        SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.AddWithValue("@CountryID", CountryID);

        try
        {
            connection.Open();
            object result = command.ExecuteScalar();
            CountryName = result.ToString();

        }
        catch (Exception e)
        {
            /// 
            string o = e.Message;
        }
        finally
        {
            connection.Close();
        }
        return CountryName ;
    }

        public static int GetCountryID(string CountryName)
        {
            int CountryID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = " Select CountryID from Countries where CountryName =@CountryName";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                int ID;
                if (int.TryParse(result.ToString(), out ID))
                    CountryID = ID;
                
            }
            catch (Exception e)
            {
                ///
            }
            finally
            {
                connection.Close();
            }
            return CountryID;
        }

        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = " Select * from Countries";
            SqlCommand command = new SqlCommand(query,connection);


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
            catch(Exception e)
            {
                ///
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
    }
}
