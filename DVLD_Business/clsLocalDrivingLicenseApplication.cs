using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DVLD_DataAccess;
using System.Data;

namespace DVLD_Business
{
    public class clsLocalDrivingLicenseApplication
    {
        private enum _enMode { Add, Update };
        _enMode Mode = _enMode.Add;

        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }
      

        public clsLocalDrivingLicenseApplication()
        {

            this.LocalDrivingLicenseApplicationID = -1;
            this.ApplicationID = -1;
            this.LicenseClassID = -1;
            Mode = _enMode.Add;
           
        }

        private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
            
        }

        private bool _AddNewLocalDrivingLicenseApplication()
        {
            return clsLocalDrivingLicenseDataAccess.AddNewLocalDrivingLicenseApplication(this.ApplicationID, this.LicenseClassID);
        }

        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseID)
        {
            return clsLocalDrivingLicenseDataAccess.DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseID);
        }

        public static clsLocalDrivingLicenseApplication Find(int LDLID)
        {
            int ApplicationID =-1,LicenseClassID=-1;
            if (clsLocalDrivingLicenseDataAccess.GetLocalDrivingLicenseInfoByID(LDLID, ref ApplicationID, ref LicenseClassID))
                return new clsLocalDrivingLicenseApplication(LDLID, ApplicationID, LicenseClassID);
            else
                return null;
        }

        public static clsLocalDrivingLicenseApplication Find(int ApplicationID, bool FindByApplicationID = false)
        {
            int LDLID = -1, LicenseClassID = -1;
            if (clsLocalDrivingLicenseDataAccess.GetLocalDrivingLicenseInfoByApplicationID(ApplicationID, ref LDLID, ref LicenseClassID))
                return new clsLocalDrivingLicenseApplication(LDLID, ApplicationID, LicenseClassID);
            else
                return null;
        }


        public int PassedTests()
        {
            return clsLocalDrivingLicenseDataAccess.GetPassedTestsNumberForLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID);
        }

          public bool Save()
        {
            bool IsSaved = false;
            switch (Mode)
            {
                case _enMode.Add:
                    {
                        if (_AddNewLocalDrivingLicenseApplication())
                        {
                            Mode = _enMode.Update;
                            IsSaved = true;
                        }
                        else
                        {
                            IsSaved = false;
                        }
                        break;
                    }
                case _enMode.Update:
                    {
                     //   IsSaved = _UpdateLocalDrivingLicenseApplication();
                        break;
                    }

            }


            return IsSaved;

        }


          public static DataTable GetAllLocalDrivingLicenseApplications()
          {
              return clsLocalDrivingLicenseDataAccess.GetAllLocalDrivingLicenseApplication();
          }

          public static bool isHaveComplatedOrNewApplicationInTheSelectedLicenseClass(int ApplicantID, int LicenseClassID)
          {
             return clsLocalDrivingLicenseDataAccess.isHaveComplatedOrNewApplicationInTheSelectedLicenseClass(ApplicantID, LicenseClassID);
          }

          public static int GetPassedTestNumberForLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
          {
              return clsLocalDrivingLicenseDataAccess.GetPassedTestsNumberForLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID);
          }



    
    }
}
