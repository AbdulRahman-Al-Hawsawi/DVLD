using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using DVLD_Business;







namespace DVLD_First.Licecses
{
    public partial class frmIssueLicenseFirstTime : Form
    {
        public frmIssueLicenseFirstTime(int LocalDrivingLicenseID, clsUser CurrentUser)
        {
            InitializeComponent();
            _LocalDrivingLicenseID = LocalDrivingLicenseID;
            _CurrentUser = CurrentUser;
        }

        int _LocalDrivingLicenseID;
        clsApplication _Application;
        clsLicenseClass _LicenseClass;
        clsUser _CurrentUser;
        clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication;
        clsDriver _Driver;
        clsApplicationType _ApplicationType;
       
        void  IssueDriverLicense()
        {
            
            LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(_LocalDrivingLicenseID);
            _Application = clsApplication.Find(LocalDrivingLicenseApplication.ApplicationID);
            _LicenseClass = clsLicenseClass.Find(LocalDrivingLicenseApplication.LicenseClassID);
            _ApplicationType = clsApplicationType.Find(_Application.ApplicationTypeID);

            clsLicense NewLicense = new clsLicense();
            NewLicense.ApplicationID = _Application.ApplicationID;
            NewLicense.LicenseClassID = LocalDrivingLicenseApplication.LicenseClassID;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = DateTime.Now.AddYears(_LicenseClass.DefaultValidityLength);
            NewLicense.Notes = tbNotes.Text;
            NewLicense.PaidFees = _ApplicationType.Fees;
            NewLicense.IsActive = true;
            NewLicense.CreatedByUserID = _CurrentUser.UserID;
            NewLicense.IssueReasonID = _ApplicationType.ApplicationTypeID;

            _Driver = clsDriver.Find(_Application.ApplicantPersonID, true);
            if (_Driver == null)
            {
                _Driver = new clsDriver();
                _Driver.PersonID = _Application.ApplicantPersonID;
                _Driver.CreatedByUserID = _CurrentUser.UserID;
                _Driver.CreatedDate = DateTime.Now;
                if (_Driver.Save())
                {
                    NewLicense.DriverID = _Driver.DriverID;
                }

            }
            else
                NewLicense.DriverID = _Driver.DriverID;


            if (NewLicense.Save())
            {
                _Application.ApplicationStatusID = 3; /// that mean is complated
                _Application.LastStatusDate = DateTime.Now;
                if (_Application.Save())
                {
                    MessageBox.Show("Issue Driver License (First Time) Successfully with ID: "+NewLicense.LicenseID);
                }
            }
            else
                MessageBox.Show("Error: faild Issue Driver License (First Time) ");


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIssueLicenseFirstTime_Load(object sender, EventArgs e)
        {
            ctrTestAppointment1.FillInfo(_LocalDrivingLicenseID);
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            IssueDriverLicense();
        }
    }
}
