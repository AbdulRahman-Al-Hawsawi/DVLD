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
    public partial class ctrDriverLicenseInfo : UserControl
    {
        public ctrDriverLicenseInfo()
        {
            InitializeComponent();
        }

        //string GetIssueReason(int IssueReasonID)
        //{
        //    switch (IssueReasonID)
        //    {
        //        case 1:
        //            return "First Time";
        //        case 2:
        //            return "Renew";
        //        case 3:
        //            return "Replacement for a Lost";
        //        case 4:
        //            return "Replacement for a Damaged";
        //        case 5:
        //            return "Release Detained";
        //        case 6:
        //            return "New International License";
        //        case 7 :
        //            return "Retake Test";

        //    }
        //    return "";
        //}

        public clsLicense SelectedLicenseInfo;

        public void FillInfo(int LicenseID)
        {
            clsLicense _License = clsLicense.Find(LicenseID);
            SelectedLicenseInfo = _License;
            lblName.Text = _License.DriverInfo.PersonInfo.FullName;
            lblNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;
            lblGender.Text = _License.DriverInfo.PersonInfo.Gender;
            lblDateOfBirth.Text = _License.DriverInfo.PersonInfo.DateOfBirth.ToShortDateString();

            lblClassName.Text = clsLicenseClass.Find(_License.LicenseClassID).ClassName;
            lblLicenseID.Text = _License.LicenseID.ToString();
            lblDriverID.Text = _License.DriverInfo.DriverID.ToString();
            lblIsActive.Text = (_License.IsActive ? "Yes" : "No");
            lblIssueDate.Text = _License.IssueDate.ToShortDateString();
            lblIssueReason.Text = _License.IssueReasonText;
            lblNotes.Text = (string.IsNullOrWhiteSpace(_License.Notes) ? "No Notes" : _License.Notes);
            lblIsDetained.Text = (clsDetain.isDetainExistByLicenseID(_License.LicenseID) ? "Yes" : "No");
            lblExpirationDate.Text = _License.ExpirationDate.ToShortDateString();
            pbDriverImage.ImageLocation = _License.DriverInfo.PersonInfo.ImagePath;
            toolTip1.SetToolTip(lblNotes, lblNotes.Text);
            toolTip1.ToolTipTitle = "Notes";
        }


        private void gbPersonInfo_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

       
    }
}
