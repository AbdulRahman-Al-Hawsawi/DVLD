using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsDetain
    {

           private enum _enMode { Add, Update };
           _enMode Mode ;


        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public int FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public  DateTime ReleaseDate { get; set; }
        public int ReleaseByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }
       

       public clsDetain()
        {
            this.DetainID = - 1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = -1;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.Now;
            this.ReleaseByUserID = -1;
            this.ReleaseApplicationID = -1;
            this.Mode = _enMode.Add;

        }


       private clsDetain(int DetainID, int LicenseID, DateTime DetainDate, int FineFees, int CreatedByUserID, bool IsReleased,DateTime ReleaseDate, int ReleaseByUserID,int ReleaseApplicationID)
       {
           this.DetainID = DetainID;
           this.LicenseID = LicenseID;
           this.DetainDate = DetainDate;
           this.FineFees = FineFees;
           this.CreatedByUserID =CreatedByUserID;
           this.IsReleased = IsReleased;
           this.ReleaseDate = ReleaseDate;
           this.ReleaseByUserID = ReleaseByUserID;
           this.ReleaseApplicationID = ReleaseApplicationID;
          Mode = _enMode.Update;
       }

        private bool _AddNewDetain()
        {
            this.DetainID = clsDetainLicenseDataAccess.AddNewDetain(this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID,this.IsReleased);
            return (this.DetainID != -1);
        }

       
        private bool _UpdateDetain()
        {
            return clsDetainLicenseDataAccess.UpdateDetain(this.DetainID, this.IsReleased, this.ReleaseDate, this.ReleaseByUserID, this.ReleaseApplicationID);
        }

        public static bool DeleteDetain(int DetainID)
        {
            return clsDetainLicenseDataAccess.DeleteDetain(DetainID);
        }

        public static bool isDetainExist(int DetainID)
        {
            return clsDetainLicenseDataAccess.isDetainExist(DetainID);
        }

        public static bool isDetainExistByLicenseID(int LicenseID)
        {
            return clsDetainLicenseDataAccess.isDetainExistByLicenseID(LicenseID);
        }

        public static clsDetain Find(int DetainID)
        {
            int LicenseID = -1, CreatedByUserID = -1, FineFees = -1,IssueReasonID =-1, ReleaseApplicationID = -1 , ReleaseByUserID=-1;
            bool  IsReleased= false;
            DateTime    DetainDate= DateTime.Now,  ReleaseDate= DateTime.Now;


            if (clsDetainLicenseDataAccess.GetDetainInfoByID(DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref  IsReleased,ref ReleaseDate, ref ReleaseByUserID,ref ReleaseApplicationID))
                return new clsDetain(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased,ReleaseDate, ReleaseByUserID,ReleaseApplicationID);
            else
                return null;

        }

        public static clsDetain Find(int LicenseID,bool FindByLicenseID =false)
        {
            int DetainID = -1, CreatedByUserID = -1, FineFees = -1, ReleaseApplicationID = -1 , ReleaseByUserID=-1;
            bool  IsReleased= false;
            DateTime    DetainDate= DateTime.Now,  ReleaseDate= DateTime.Now;


            if (clsDetainLicenseDataAccess.GetDetainInfoByLicenseID(LicenseID, ref DetainID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref  IsReleased,ref ReleaseDate, ref ReleaseByUserID,ref ReleaseApplicationID))
                return new clsDetain(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased,ReleaseDate, ReleaseByUserID,ReleaseApplicationID);
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
                        if (_AddNewDetain())
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
                        IsSaved = _UpdateDetain();
                        break;
                    }

            }

            return IsSaved;
        }

        public static DataTable GetAllDetains()
        {
            return clsDetainLicenseDataAccess.GetAllDetains();
        }

        //public static DataTable GetAllDriverDetains(int DetainDate)
        //{
        //    return clsDetainDataAccess.GetAllDriverDetains(DetainDate);
        //}

    }
    }

