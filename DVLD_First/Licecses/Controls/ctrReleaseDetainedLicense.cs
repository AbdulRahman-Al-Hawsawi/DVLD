using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DVLD_Business;
using DVLD_First.Licecses;
using System.IO;






namespace DVLD_First.Controls
{
    public partial class ctrReleaseDetainedLicense : UserControl
    {
        public ctrReleaseDetainedLicense()
        {
            InitializeComponent();
        }

        clsLicense _DetainedLicense;
        clsUser _CurrentUser;
        clsDetain _DetainedInfo;
        clsApplicationType _ApplicationType;

        public void FillInfo(int LocalLicenseID,bool DisapledFilter = false)
        {
            if (DisapledFilter)
            {
                gbFilter.Enabled = false;
                tbLicenseID.Text = LocalLicenseID.ToString();
            }

            _DetainedLicense = clsLicense.Find(LocalLicenseID);
            _CurrentUser = clsUser.Find(Convert.ToInt32(File.ReadAllText("LoginUserID")));
            _ApplicationType = clsApplicationType.Find(5); // Release ID = 5
            ctrDriverLicenseInfo1.FillInfo(LocalLicenseID);

            if (!clsDetain.isDetainExistByLicenseID(LocalLicenseID))
            {
                MessageBox.Show("This is a License are not detained \nEnter Detained License: " , "Release Detain", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnRelease.Enabled = false;
                return;
            }
            _DetainedInfo = clsDetain.Find(LocalLicenseID, true);

            lblDetainDate.Text = _DetainedInfo.DetainDate.ToShortDateString();
            lblDetainID.Text = _DetainedInfo.DetainID.ToString();
            lblApplicationFees.Text = _ApplicationType.Fees.ToString();
            lblFineFees.Text = _DetainedInfo.FineFees.ToString();
            lblTotalFees.Text = (_DetainedInfo.FineFees + _ApplicationType.Fees).ToString();
            lblCreatedBy.Text = _CurrentUser.UserName;
            lblLicenseID.Text = LocalLicenseID.ToString();
        }

        void Save()
        {
            clsApplication ReleasedLicenseApplication = new clsApplication();

            ReleasedLicenseApplication.ApplicantPersonID = clsDriver.Find(_DetainedLicense.DriverID).PersonID;
            ReleasedLicenseApplication.ApplicationDate = DateTime.Now;
            ReleasedLicenseApplication.LastStatusDate = DateTime.Now;
            ReleasedLicenseApplication.ApplicationTypeID = _ApplicationType.ApplicationTypeID; 
            ReleasedLicenseApplication.ApplicationStatusID = 3; /// Complate status have ID : 3
            ReleasedLicenseApplication.CreatedByUserID = _CurrentUser.UserID;
            ReleasedLicenseApplication.PaidFees = _ApplicationType.Fees;

            if (ReleasedLicenseApplication.Save())
            {
                lblApplicationID.Text = ReleasedLicenseApplication.ApplicationID.ToString();
                _DetainedInfo.IsReleased = true;
                _DetainedInfo.ReleaseDate = DateTime.Now;
                _DetainedInfo.ReleaseByUserID = _CurrentUser.UserID;
                _DetainedInfo.ReleaseApplicationID = ReleasedLicenseApplication.ApplicationID;
               
                if (_DetainedInfo.Save())
                {
                    _DetainedLicense.IssueReasonID = _ApplicationType.ApplicationTypeID;
                    
                    if (_DetainedLicense.Save())
                        MessageBox.Show("Released Detained License Successfully With ID: " + _DetainedLicense.LicenseID, "Release Detain", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRelease.Enabled = false;
                    LlblShowReleasedLicensesInfo.Enabled = true;
                    gbFilter.Enabled = false;
                }
            }
        }


        private void zzzzzzzz_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchLicense_Click(object sender, EventArgs e)
        {
            if (!clsLicense.isLicenseExist(Convert.ToInt32(tbLicenseID.Text)))
                return;
            
            LlblShowLicensesHistory.Enabled = true;
            btnRelease.Enabled = true;
            this.FillInfo(Convert.ToInt32(tbLicenseID.Text));
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void LlblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory ShowLicensesHistory = new frmLicenseHistory(_DetainedLicense.DriverID);
            ShowLicensesHistory.MdiParent = this.ParentForm.MdiParent;
            ShowLicensesHistory.Show();
        }

        private void LlblShowReleasedLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo ShowReleasedLicenseInfo = new frmLicenseInfo(Convert.ToInt32(lblLicenseID.Text));
            ShowReleasedLicenseInfo.MdiParent = this.ParentForm.MdiParent;
            ShowReleasedLicenseInfo.Show();
        }
    }
}
