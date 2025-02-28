using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DVLD_DataAccess;



namespace DVLD_Business
{
    public class clsLicenseClass
    {

        private enum _enMode { Add, Update };
        _enMode Mode = _enMode.Add;

        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public int MinimumAllowedAge { get; set; }
        public int DefaultValidityLength { get; set; }
        public double ClassFees { get; set; }

        public clsLicenseClass()
        {
            this.LicenseClassID = -1;
            this.ClassName = "";
            this.ClassDescription ="";
            this.MinimumAllowedAge = -1;
            this.DefaultValidityLength = -1;
            this.ClassFees = -1;
            Mode = _enMode.Add;
        }

        private clsLicenseClass(int LicenseClassID, string ClassName, string ClassDescription, int MinimumAllowedAge, int DefaultValidityLength, double ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
            Mode = _enMode.Update;

        }

        public static DataTable GetAllLicenseClasses()
        {
            return clsLicenseClassDataAccess.GetAllLicenseClasses();
           
        }


        public static clsLicenseClass Find(string ClassName)
        {
            string ClassDescription = "";
            double ClassFees = -1;
            int  LicenseClassID = -1, DefaultValidityLength = -1, MinimumAllowedAge =-1;


            if (clsLicenseClassDataAccess.GetLicenseClassInfoByClassName(ClassName, ref LicenseClassID, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength,ref ClassFees))
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength,ClassFees);
            else
                return null;

        }


        public static clsLicenseClass Find(int LicenseClassID)
        {
            string ClassDescription = "",ClassName ="";
            double ClassFees = -1;
            int  DefaultValidityLength = -1, MinimumAllowedAge = -1;


            if (clsLicenseClassDataAccess.GetLicenseClassInfoByID(LicenseClassID, ref ClassName , ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;

        }
    }
}
