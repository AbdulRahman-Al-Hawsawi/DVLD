using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsRetakeTest
    {
          private enum _enMode { Add, Update };
        _enMode Mode = _enMode.Add;

        public int RetakeTestApplicationID { get; set; }
        public int LocalDrivingApplicationID { get; set; }
        public double RetakeTestFees { get; set; }
        public double RetakeTestTotalFees { get; set; }
       

        public clsRetakeTest()
        {
            this.RetakeTestApplicationID = -1;
            this.LocalDrivingApplicationID = -1;
            this.RetakeTestFees = 5;
            this.RetakeTestTotalFees = -1;
            this.Mode = _enMode.Add;
        }

        private clsRetakeTest(int RetakeTestApplicationID, int LocalDrivingApplicationID, double RetakeTestFees, double RetakeTestTotalFees )
        {
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            this.LocalDrivingApplicationID = LocalDrivingApplicationID;
            this.RetakeTestFees = RetakeTestFees;
            this.RetakeTestTotalFees = RetakeTestTotalFees;
            this.Mode = _enMode.Update;

        }

        private bool _AddNewRetakeTest()
        {
            this.RetakeTestApplicationID = clsRetakeTestDataAccess.AddNewRetakeTest(this.LocalDrivingApplicationID, this.RetakeTestFees, this.RetakeTestTotalFees);
            return (this.RetakeTestApplicationID != -1);
        }


        //private bool _UpdateRetakeTest()
        //{
        //    return clsRetakeTestDataAccess.UpdateRetakeTest(this.RetakeTestApplicationID, this.LocalDrivingApplicationID, this.RetakeTestFees, this.RetakeTestTotalFees, this.);
        //}

        public static bool DeleteRetakeTestByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            return clsRetakeTestDataAccess.DeleteRetakeTestByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);
        }

       
        public static clsRetakeTest Find(int RetakeTestApplicationID)
        {
            double RetakeTestFees = -1, RetakeTestTotalFees = -1;
            int LocalDrivingApplicationID = -1;


            if (clsRetakeTestDataAccess.GetRetakeTestInfoByID(RetakeTestApplicationID, ref LocalDrivingApplicationID, ref RetakeTestFees, ref RetakeTestTotalFees ))
                return new clsRetakeTest(RetakeTestApplicationID, LocalDrivingApplicationID, RetakeTestFees, RetakeTestTotalFees );
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
                        if (_AddNewRetakeTest())
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
                 //       IsSaved = _UpdateRetakeTest();
                        break;
                    }

            }


            return IsSaved;

        }

        public static DataTable GetAllRetakeTests()
        {
            return clsRetakeTestDataAccess.GetAllRetakeTests();
        }
    }
}
