using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsInternationalLicense
    {

           private enum _enMode { Add, Update };
        _enMode Mode ;


        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }


       public clsInternationalLicense()
        {
            this.InternationalLicenseID = - 1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = false;
            this.CreatedByUserID = -1;
            this.Mode = _enMode.Add;

        }


       private clsInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate,bool IsActive, int CreatedByUserID)
       {
           this.InternationalLicenseID = InternationalLicenseID;
           this.ApplicationID = ApplicationID;
           this.DriverID = DriverID;
           this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
           this.IssueDate =IssueDate;
           this.ExpirationDate = ExpirationDate;
           this.IsActive = IsActive;
           this.CreatedByUserID = CreatedByUserID;
           Mode = _enMode.Update;
       }

        private bool _AddNewInternationalLicense()
        {
            this.InternationalLicenseID = clsInternationalLicenseDataAccess.AddNewInternationalLicense(this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate,this.IsActive, this.CreatedByUserID);
            return (this.InternationalLicenseID != -1);
        }

       
        private bool _UpdateInternationalLicense()
        {
            return clsInternationalLicenseDataAccess.UpdateInternationalLicense(this.InternationalLicenseID, this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.ExpirationDate, this.IsActive);
        }

        public static bool DeleteInternationalLicense(int InternationalLicenseID)
        {
            return clsInternationalLicenseDataAccess.DeleteInternationalLicense(InternationalLicenseID);
        }

        public static bool isInternationalLicenseExist(int InternationalLicenseID)
        {
            return clsInternationalLicenseDataAccess.isInternationalLicenseExist(InternationalLicenseID);
        }

        public static bool isInternationalLicenseExist(int DriverID,int IssuedUsingLocalLicenseID)
        {
            return clsInternationalLicenseDataAccess.isInternationalLicenseExistByDriverIdAndClassID(DriverID,IssuedUsingLocalLicenseID);
        }

        public static bool isInternationalLicenseExistByApplicationID(int ApplicationID)
        {
            return clsInternationalLicenseDataAccess.isInternationalLicenseExist(ApplicationID);
        }

        public static clsInternationalLicense Find(int InternationalLicenseID)
        {
            int ApplicationID = -1, DriverID = -1, IssuedUsingLocalLicenseID = -1,IssueReasonID =-1, CreatedByUserID = -1;
            bool IsActive = false;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;


            if (clsInternationalLicenseDataAccess.GetInternationalLicenseInfoByID(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref  ExpirationDate,ref IsActive, ref CreatedByUserID))
                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate,IsActive, CreatedByUserID);
            else
                return null;

        }

        public static clsInternationalLicense Find(int DriverID , bool FindByDriverID = false)
        {
            int InternationalLicenseID = -1,  ApplicationID= -1, IssuedUsingLocalLicenseID = -1, CreatedByUserID = -1;
           bool IsActive = false;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;

            if (clsInternationalLicenseDataAccess.GetInternationalLicenseInfoByDriverID(DriverID, ref InternationalLicenseID, ref ApplicationID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref  ExpirationDate, ref IsActive, ref CreatedByUserID))
                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
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
                        if (_AddNewInternationalLicense())
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
                        IsSaved = _UpdateInternationalLicense();
                        break;
                    }

            }

            return IsSaved;
        }

        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicenseDataAccess.GetAllInternationalLicenses();
        }

        public static DataTable GetAllDriverInternationalLicenses(int DriverID)
        {
            return clsInternationalLicenseDataAccess.GetAllDriverInternationalLicenses(DriverID);
        }

    }

    }

