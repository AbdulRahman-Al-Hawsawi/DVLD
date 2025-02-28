using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DVLD_DataAccess;
using System.Data;

namespace DVLD_Business
{
    public class clsApplicationType
    {

        public int ApplicationTypeID { get; set; }
        public string Title { get; set; }
        public double Fees { get; set; }

        clsApplicationType(int ApplicationTypeID,string Title,double Fees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.Title = Title;
            this.Fees = Fees;
        }

        public static clsApplicationType Find(int ApplicationTypeID)
        {
            string Title = "";
           double Fees =0;
            
            
            if ( clsApplicationTypesDataAccess.GetApplicationTypeInfoByID(ApplicationTypeID,ref Title, ref Fees))
                return new clsApplicationType(ApplicationTypeID,Title,Fees);
            else
                return null;

        }

        public bool save()
        {
            return clsApplicationTypesDataAccess.UpdateApplicationType(this.ApplicationTypeID,Title,Fees);
        }


        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypesDataAccess.GetAllApplicationTypes();
        }

    }
}
