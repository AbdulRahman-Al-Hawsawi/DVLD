using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DVLD_Business;
using DVLD_First.Properties;

namespace DVLD_First.Controls
{
    public partial class ctrScheduleTest : UserControl
    {
        public ctrScheduleTest()
        {
            InitializeComponent();
        }
        

        enum enMode { Add, Update };
        enMode _Mode;

        clsApplication _Application;
        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        clsTestType _Test;
        clsTestAppointment _Appointment;
        clsRetakeTest _RetakeTest ;


        public void FillAppointmentInfoToUpdate(int AppointmentID)
        {
          _Appointment = clsTestAppointment.Find(AppointmentID);
          dtpDate.MinDate = _Appointment.AppointmentDate; 
          dtpDate.Value = _Appointment.AppointmentDate;
           
            _Mode = enMode.Update;

        }

        void RetakeTest()
        {
            
           
        }

        //enum enType { Vision = 1, Writin, Streat };

        //public enType Type { get { return (enType)1; }

        //    set
        //    {
        //        Type = value;

        //        switch (value)
        //        {
        //            case enType.Vision:
        //                pbTestImage.Image = Resources.test_check;
        //                break;
        //            case enType.Streat:
                       

        //                pbTestImage.Image = Resources.test_close;
        //                break;
        //            case enType.Writin:
        //                pbTestImage.Image = Resources.test_config;
        //                break;
        //        }
        //    }
        
        //}


        public void FillInfo(int LocalDrivingLicenseApplicationID, string Title = "Vision")
        {

                dtpDate.MinDate = DateTime.Now.AddDays(1);
                dtpDate.MaxDate = DateTime.Now.AddDays(31);

                gbScheduleTest.Text = Title + " Test";
              lblTitle.Text = "Schedule " + Title + " Test";
             _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID);
             _Application = clsApplication.Find(_LocalDrivingLicenseApplication.ApplicationID);

             switch (Title)
             {
                 case "Vision":
                     pbTestImage.Image = Resources.eye_Large;
                     _Test = clsTestType.Find(1);
                     break;
                 case "Writting":
                     pbTestImage.Image = Resources.exam;
                     _Test = clsTestType.Find(2);
                     break;
                 case "Streeat":
                     pbTestImage.Image = Resources.CarLarge;
                     _Test = clsTestType.Find(3);
                     break;


             }

            int TrialNumber =  (clsTestAppointment.GetAllApplicationAppointmentsByLocalDrivingLicenseApplicationIdAndTestTypeID(LocalDrivingLicenseApplicationID, clsLocalDrivingLicenseApplication.GetPassedTestNumberForLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID) + 1).Rows.Count );

            if (TrialNumber > 0)
            {
                gbRetakeTest.Visible = true;
                lblTitle.Text = "Schedule Retake Test";
                _RetakeTest = new clsRetakeTest();
                _RetakeTest.LocalDrivingApplicationID = LocalDrivingLicenseApplicationID;
                _RetakeTest.RetakeTestTotalFees = _RetakeTest.RetakeTestFees + _Test.Fees;
                lblRAppFees.Text = _RetakeTest.RetakeTestFees.ToString();
                lblTotalFees.Text = _RetakeTest.RetakeTestTotalFees.ToString(); 
                
            }

           lblTrial.Text = TrialNumber.ToString();
           lblDLAppID.Text = LocalDrivingLicenseApplicationID.ToString();
           lblDClassName.Text = clsLicenseClass.Find(_LocalDrivingLicenseApplication.LicenseClassID).ClassName;
           lblName.Text = clsPerson.Find(_Application.ApplicantPersonID).FullName;
           lblFees.Text = _Test.Fees.ToString();

        }


        void Save()
        {
            if (_Mode == enMode.Update)
            {
                
                _Appointment.AppointmentDate = dtpDate.Value;

                if (_Appointment.Save())
                {
                    MessageBox.Show("Update Appointment Successfully New Date : " + _Appointment.AppointmentDate);
                    
                }
                else
                MessageBox.Show("Error: Update Appointment Faild");

                return;
            }



            _Appointment = new clsTestAppointment();

            if (_RetakeTest != null)
            {
                if (_RetakeTest.Save())
                {
                    lblRTestAppID.Text = _RetakeTest.RetakeTestApplicationID.ToString();
                    _Appointment.RetakeTestApplicationID = _RetakeTest.RetakeTestApplicationID;

                }
               
            }  

            _Appointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID;
            _Appointment.TestTypeID = _Test.TestID;
            _Appointment.AppointmentDate = dtpDate.Value;
            _Appointment.PaidFees = _Test.Fees;
            _Appointment.CreatedByUserID = _Application.CreatedByUserID;
            _Appointment.isLocked = false;
           
            if (_Appointment.Save())
            {
                clsTests AddNewTest = new clsTests();
                AddNewTest.TestAppointmentID = _Appointment.AppointmentID;
                AddNewTest.CreatedByUserID = _Appointment.CreatedByUserID;
                AddNewTest.TestResult = false;
                AddNewTest.Notes = "";
                if (AddNewTest.Save())
                {
                    MessageBox.Show("Add New Appointment Successfully Appointment ID : " + _Appointment.AppointmentID);

                }

            }
            else
                MessageBox.Show("Error: Add New Appointment Faild");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        public bool apointmentid { get; set; }

        private void gbScheduleTest_Enter(object sender, EventArgs e)
        {

        }
    }
}
