using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DVLD_Business;



namespace DVLD_First.Controls
{
    public partial class ctrShowInternationalLicensecs : UserControl
    {
        public ctrShowInternationalLicensecs()
        {
            InitializeComponent();
        }

        public void FillInfo(int DriverID)
        {
            clsInternationalLicense _InternationalLicense = clsInternationalLicense.Find(DriverID,true);

            lblInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lblLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblIssueDate.Text = _InternationalLicense.IssueDate.ToShortDateString();
            lblExpirationDate.Text = _InternationalLicense.ExpirationDate.ToShortDateString();
            lblDriverID.Text = _InternationalLicense.DriverID.ToString();
            lblApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
            lblIsActive.Text = (_InternationalLicense.IsActive ? "Yes" : "No");

            clsDriver _Driver = clsDriver.Find(_InternationalLicense.DriverID);
            clsPerson _Person = clsPerson.Find(_Driver.PersonID);

            lblName.Text = _Person.FullName;
            lblNationalNo.Text = _Person.NationalNo;
            lblGender.Text = _Person.Gender;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            pbDriverImage.ImageLocation = _Person.ImagePath;


        }
    }
}
