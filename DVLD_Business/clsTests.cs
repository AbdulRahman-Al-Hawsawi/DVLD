using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DVLD_DataAccess;
using System.Data;

namespace DVLD_Business
{
    public class clsTests
    {

         private enum _enMode { Add, Update };
        _enMode Mode = _enMode.Add;

        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }


        public clsTests()
        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.TestResult = false;
            this.Notes = "";
            this.CreatedByUserID = -1;
            this.Mode = _enMode.Add;
        }

        private clsTests(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
            this.Mode = _enMode.Update;

        }
       

        private bool _AddNewTest()
        {
            this.TestID = clsTestsDataAccess.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
            return (this.TestID != -1);
        }


        private bool _UpdateTest()
        {
            return clsTestsDataAccess.UpdateTest(this.TestID, this.TestResult, this.Notes);
        }

        public static bool DeleteTest(int TestID)
        {
            return clsTestsDataAccess.DeleteTest(TestID);
        }

        public static bool DeleteTestByTestAppointmentID(int TestAppointmentID)
        {
            return clsTestsDataAccess.DeleteTestByTestAppointmentID(TestAppointmentID);
        }

        public static clsTests Find(int TestID)
        {
            string Notes = "";
            bool TestResult = false;
            int TestAppointmentID = -1, CreatedByUserID = -1;


            if (clsTestsDataAccess.GetTestInfoByID(TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
                return new clsTests(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            else
                return null;

        }


        public static clsTests Find(int TestAppointmentID, bool FindByTestAppointmentID = false)
        {
            string Notes = "";
            bool TestResult = false;
            int TestID = -1, CreatedByUserID = -1;


            if (clsTestsDataAccess.GetTestInfoByTestAppointmentID(TestAppointmentID, ref TestID, ref TestResult, ref Notes, ref CreatedByUserID))
                return new clsTests(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
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
                        if (_AddNewTest())
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
                        IsSaved = _UpdateTest();
                        break;
                    }

            }


            return IsSaved;

        }

        public static DataTable GetAllTests()
        {
            return clsTestsDataAccess.GetAllTests();
        }


    }
}
