using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsCountry
    {
        public static DataTable GetAllCountries()
        {
            return clsCountryDataAccess.GetAllCountries();
        }

        public static string GetCountry(int CountryID)
        {
            return clsCountryDataAccess.GetCountryName(CountryID);
        }

        public static int GetCountryID(string CountryName)
        {
           return clsCountryDataAccess.GetCountryID(CountryName);
        }
    }
}
