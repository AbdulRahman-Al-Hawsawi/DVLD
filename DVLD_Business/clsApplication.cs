using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DVLD_DataAccess;
using System.Data;


namespace DVLD_Business
{
    public class clsApplication
    {


         
        private enum _enMode { Add, Update };
        _enMode Mode = _enMode.Add;

        public enum enApplicationType
        {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };

        public enum enApplicationStatus { New = 1, Cancelled = 2, Complated = 3 };

        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public clsPerson PersonInfo;
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public clsApplicationType ApplicationTypeInfo;
        public int ApplicationStatusID { get; set; }
        public DateTime LastStatusDate { get; set; }
        public double PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser CreatedByUserInfo;


       public clsApplication()
        {
            this.ApplicationID = - 1;
            this.ApplicantPersonID = -1;
            this.ApplicationStatusID = -1;
            this.ApplicationTypeID = -1;
            this.CreatedByUserID = -2;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = -1;
            this.ApplicationDate = DateTime.Now;
            Mode = _enMode.Add;
        }


       private clsApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, int ApplicationStatusID, DateTime LastStatusDate, double PaidFees,int CreatedByUserID)
       {
           this.ApplicationID = ApplicationID;
           this.ApplicantPersonID = ApplicantPersonID;
           this.PersonInfo = clsPerson.Find(ApplicantPersonID);
           this.ApplicationStatusID = ApplicationStatusID;
           this.ApplicationTypeID = ApplicationTypeID;
           this.ApplicationTypeInfo = clsApplicationType.Find(ApplicationTypeID);
           this.CreatedByUserID = CreatedByUserID;
           this.CreatedByUserInfo = clsUser.Find(CreatedByUserID);
           this.LastStatusDate = LastStatusDate;
           this.PaidFees = PaidFees;
           this.ApplicationDate =ApplicationDate;
           Mode = _enMode.Update;
       }

        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationDataAccess.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID,this.ApplicationStatusID, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

            return (this.ApplicationID != -1);
        }


        private bool _UpdateApplication()
        {
            return clsApplicationDataAccess.UpdateApplication(this.ApplicationID, this.ApplicantPersonID, this.ApplicationTypeID, this.ApplicationStatusID, this.LastStatusDate, this.PaidFees);
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            return clsApplicationDataAccess.DeleteApplication(ApplicationID);
        }

        //public static bool isApplicationExist(int ApplicationID)
        //{
        //    return clsApplicationDataAccess.isApplicationExist(ApplicationID);
        //}

        //public static bool isApplicationExist(string ApplicantPersonID)
        //{
        //    return clsApplicationDataAccess.isApplicationExist(ApplicantPersonID);
        //}

        public static clsApplication Find(int ApplicationID)
        {
            int ApplicantPersonID = -1, ApplicationTypeID = -1, ApplicationStatusID = -1, CreatedByUserID = -1;
            double PaidFees = -1;
            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;


            if (clsApplicationDataAccess.GetApplicationInfoByID(ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatusID, ref  LastStatusDate, ref PaidFees, ref CreatedByUserID))
                return new clsApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatusID, LastStatusDate, PaidFees, CreatedByUserID);
            else
                return null;

        }

        //public static clsApplication Find(string ApplicantPersonID)
        //{
        //    string ApplicationDate = "", ApplicationTypeID = "", ApplicationStatusID = "", LastStatusDate = "", PaidFees = "", CreatedByUserID = "", Address = "", ImagePath = "",
        //        Gender = "";
        //    DateTime DateOfBirth = DateTime.Now;

        //    int CountryID = -1, ID = -1;


        //    if (clsApplicationDataAccess.GetApplicationInfoByApplicantPersonID(ApplicantPersonID, ref ID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatusID, ref  LastStatusDate, ref  DateOfBirth, ref Gender, ref Address, ref PaidFees, ref CreatedByUserID, ref CountryID, ref ImagePath))
        //        return new clsApplication(ID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatusID, LastStatusDate, DateOfBirth, Gender, Address, PaidFees, CreatedByUserID, CountryID, ImagePath);
        //    else
        //        return null;

        //}

        public bool Save()
        {
            bool IsSaved = false;
            switch (Mode)
            {
                case _enMode.Add:
                    {
                        if (_AddNewApplication())
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
                        IsSaved = _UpdateApplication();
                        break;
                    }

            }

            return IsSaved;
        }

        public static DataTable GetAllApplications()
        {
            return clsApplicationDataAccess.GetAllApplications();
        }

    }
}
