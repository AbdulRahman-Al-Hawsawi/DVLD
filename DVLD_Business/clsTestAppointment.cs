using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DVLD_DataAccess;


namespace DVLD_Business
{
    public class clsTestAppointment
    {
         private enum _enMode { Add, Update };
        _enMode Mode = _enMode.Add;

        public int AppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public double PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public int RetakeTestApplicationID { get; set; }
        public bool isLocked { get; set; }


        public clsTestAppointment()
        {

            this.AppointmentID = -1;
            this.TestTypeID = -1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = -1;
            this.CreatedByUserID =-1;
            this.isLocked = false;
            this.RetakeTestApplicationID =-1;;
            this.Mode = _enMode.Add;

        }

        private clsTestAppointment(int AppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate,double PaidFees,int CreatedByUserID, bool isLocked,int RetakeTestApplicationID)
        {
            this.AppointmentID = AppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.isLocked = isLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            this.Mode = _enMode.Update;

        }

        private bool _AddNewAppointment()
        {
            this.AppointmentID = clsTestAppointmentDataAccess.AddNewAppointment(this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate,this.PaidFees,this.CreatedByUserID, this.isLocked,this.RetakeTestApplicationID);
            return (this.AppointmentID != -1);
        }


        private bool _UpdateAppointment()
        {
            return clsTestAppointmentDataAccess.UpdateAppointment(this.AppointmentID, this.AppointmentDate, this.isLocked,this.RetakeTestApplicationID);
        }

        public static bool DeleteAppointment(int AppointmentID)
        {
            return clsTestAppointmentDataAccess.DeleteAppointment(AppointmentID);
        }


        public static clsTestAppointment Find(int AppointmentID)
        {
           
            bool isLocked = false;
            int TestTypeID = -1, LocalDrivingLicenseApplicationID =-1,CreatedByUserID =-1,RetakeTestApplicationID =-1;
            double PaidFees = -1;
             DateTime AppointmentDate = DateTime.Now;

            if (clsTestAppointmentDataAccess.GetAppointmentInfoByID(AppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees ,ref CreatedByUserID,ref isLocked, ref RetakeTestApplicationID))
                return new clsTestAppointment(AppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate,PaidFees,CreatedByUserID, isLocked,RetakeTestApplicationID);
            else
                return null;

        }


        //public static clsAppointment Find(string LocalDrivingLicenseApplicationID)
        //{
        //    string  AppointmentDate = "";
        //    bool isLocked = false;
        //    int TestTypeID = -1, AppointmentID = -1;


        //    if (clsAppointmentDataAccess.GetAppointmentInfoByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID, ref AppointmentID, ref TestTypeID, ref AppointmentDate, ref isLocked))
        //        return new clsAppointment(AppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, isLocked);
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
                        if (_AddNewAppointment())
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
                        IsSaved = _UpdateAppointment();
                        break;
                    }

            }

            return IsSaved;

        }

        public static DataTable GetAllApplicationAppointmentsByLocalDrivingLicenseApplicationIdAndTestTypeID(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsTestAppointmentDataAccess.GetAllApplicationAppointmentsByLocalDrivingLicenseApplicationIdAndTestTypeID(LocalDrivingLicenseApplicationID,TestTypeID);
        }


        public static DataTable GetAllApplicationAppointmentsByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            return clsTestAppointmentDataAccess.GetAllApplicationAppointmentsByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);
        }
    }
}
