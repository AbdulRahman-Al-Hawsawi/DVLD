using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsLicense
    {
         private enum _enMode { Add, Update };
        _enMode Mode ;


        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public clsApplication ApplicationInfo;
        public int DriverID { get; set; }
        public clsDriver DriverInfo;
        public int LicenseClassID { get; set; }
        public clsLicenseClass LicenseClassInfo;
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public double PaidFees { get; set; }
        public bool IsActive { get; set; }
        public int IssueReasonID { get; set; }
        public int CreatedByUserID { get; set; }

        public string IssueReasonText { get { return GetIssueReason(this.IssueReasonID); } }


       public clsLicense()
        {
            this.LicenseID = - 1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClassID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = false;
            this.IssueReasonID = -1;
            this.CreatedByUserID = -1;
            this.Mode = _enMode.Add;

        }


       private clsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate,string Notes, double PaidFees,bool IsActive, int IssueReasonID, int CreatedByUserID)
       {
           this.LicenseID = LicenseID;
           this.ApplicationID = ApplicationID;
           this.ApplicationInfo = clsApplication.Find(ApplicationID);
           this.DriverID = DriverID;
           this.DriverInfo = clsDriver.Find(DriverID);
           this.LicenseClassID = LicenseClassID;
           this.LicenseClassInfo = clsLicenseClass.Find(LicenseClassID);
           this.IssueDate =IssueDate;
           this.ExpirationDate = ExpirationDate;
           this.Notes = Notes;
           this.PaidFees = PaidFees;
           this.IsActive = IsActive;
           this.IssueReasonID = IssueReasonID;
           this.CreatedByUserID = CreatedByUserID;
           Mode = _enMode.Update;
       }


         string GetIssueReason(int IssueReasonID)
        {
            switch (IssueReasonID)
            {
                case 1:
                    return "First Time";
                case 2:
                    return "Renew";
                case 3:
                    return "Replacement for a Lost";
                case 4:
                    return "Replacement for a Damaged";
                case 5:
                    return "Release Detained";
                case 6:
                    return "New International License";
                case 7 :
                    return "Retake Test";

            }
            return "";
        }

        private bool _AddNewLicense()
        {
            this.LicenseID = clsLicenseDataAccess.AddNewLicense(this.ApplicationID, this.DriverID, this.LicenseClassID, this.IssueDate, this.ExpirationDate,this.Notes, this.PaidFees,this.IsActive,this.IssueReasonID, this.CreatedByUserID);
            return (this.LicenseID != -1);
        }

       
        private bool _UpdateLicense()
        {
            return clsLicenseDataAccess.UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClassID, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReasonID);
        }

        public static bool DeleteLicense(int LicenseID)
        {
            return clsLicenseDataAccess.DeleteLicense(LicenseID);
        }

        public static bool isLicenseExist(int LicenseID)
        {
            return clsLicenseDataAccess.isLicenseExist(LicenseID);
        }

        public static bool isLicenseExist(int DriverID,int LicenseClassID)
        {
            return clsLicenseDataAccess.isLicenseExistByDriverIdAndClassID(DriverID,LicenseClassID);
        }

        public static bool isLicenseExistByApplicationID(int ApplicationID)
        {
            return clsLicenseDataAccess.isLicenseExist(ApplicationID);
        }

        public static clsLicense Find(int LicenseID)
        {
            int ApplicationID = -1, DriverID = -1, LicenseClassID = -1,IssueReasonID =-1, CreatedByUserID = -1;
            double PaidFees = -1;
            string Notes = "";
            bool IsActive = false;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;


            if (clsLicenseDataAccess.GetLicenseInfoByID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClassID, ref IssueDate, ref  ExpirationDate,ref Notes, ref PaidFees,ref IsActive,ref IssueReasonID, ref CreatedByUserID))
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate,Notes, PaidFees,IsActive,IssueReasonID, CreatedByUserID);
            else
                return null;

        }

        public static clsLicense Find(int ApplicationID, bool FindByApplicationID = false)
        {
            int LicenseID = -1, DriverID = -1, LicenseClassID = -1, IssueReasonID = -1, CreatedByUserID = -1;
            double PaidFees = -1;
            string Notes = "";
            bool IsActive = false;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;

            if (clsLicenseDataAccess.GetLicenseInfoByApplicationID(ApplicationID, ref LicenseID, ref DriverID, ref LicenseClassID, ref IssueDate, ref  ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReasonID, ref CreatedByUserID))
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReasonID, CreatedByUserID);
            else
                return null;

        }


        public bool Save()
        {
            bool IsSaved = false;
            switch (Mode)
            {
                case _enMode.Add:
                    {
                        if (_AddNewLicense())
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
                        IsSaved = _UpdateLicense();
                        break;
                    }

            }

            return IsSaved;
        }

        public static DataTable GetAllLicenses()
        {
            return clsLicenseDataAccess.GetAllLicenses();
        }

        public static DataTable GetAllDriverLicenses(int DriverID)
        {
            return clsLicenseDataAccess.GetAllDriverLicenses(DriverID);
        }

    }
}
