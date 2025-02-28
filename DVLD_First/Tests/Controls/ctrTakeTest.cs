using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DVLD_Business;
using DVLD_Business;


using DVLD_Business;

using DVLD_First.Properties;


namespace DVLD_First.Controls
{
    public partial class ctrTakeTest : UserControl
    {
        public ctrTakeTest()
        {
            InitializeComponent();
        }

        clsApplication _Application;
        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        clsTestType _TestType;
        clsTestAppointment _Appointment;
        clsTests _Test;

        public void FillInfo(int LocalDrivingLicenseApplicationID,int AppointmentID, string Title = "Vision")
        {
            _Test = clsTests.Find(AppointmentID, true);
            _Appointment = clsTestAppointment.Find(AppointmentID);
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID);
            _Application = clsApplication.Find(_LocalDrivingLicenseApplication.ApplicationID);

            switch (Title)
            {
                case "Vision":
                    pbTestImage.Image = Resources.eye_Large;
                    _TestType = clsTestType.Find(1);
                    break;
                case "Writting":
                    pbTestImage.Image = Resources.exam;
                    _TestType = clsTestType.Find(2);
                    break;
                case "Streeat":
                    pbTestImage.Image = Resources.CarLarge;
                    _TestType = clsTestType.Find(3);
                    break;


            }

            lblDate.Text = _Appointment.AppointmentDate.ToShortDateString();
            lblTrial.Text = (clsTestAppointment.GetAllApplicationAppointmentsByLocalDrivingLicenseApplicationIdAndTestTypeID(LocalDrivingLicenseApplicationID, clsLocalDrivingLicenseApplication.GetPassedTestNumberForLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID) + 1).Rows.Count - 1).ToString();
            lblDLAppID.Text = LocalDrivingLicenseApplicationID.ToString();
            lblDClassName.Text = clsLicenseClass.Find(_LocalDrivingLicenseApplication.LicenseClassID).ClassName;
            lblName.Text = clsPerson.Find(_Application.ApplicantPersonID).FullName;
            lblFees.Text = _TestType.Fees.ToString();

        }

        void Save()
        {

            _Test.TestResult = (rbPass.Checked ? true : false);
            _Test.Notes = (string.IsNullOrWhiteSpace(tbNotes.Text) ? "" : tbNotes.Text);

            if (_Test.Save())
            {
                _Appointment.isLocked = true;
                if(_Appointment.Save())
                MessageBox.Show("Enter Test Result is Done ");
            }
            else
                MessageBox.Show("Enter Test Result is Faild ");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
