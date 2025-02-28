using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


using DVLD_Business;



using DVLD_First.Licecses;

namespace DVLD_First.Controls
{
    public partial class ctrReplaceLicense : UserControl
    {
        public ctrReplaceLicense()
        {
            InitializeComponent();
        }

        public delegate void DataBackEventHandler(string Title);
        public event DataBackEventHandler ReplacementTitle;

        clsLicense _OldLicense;
        clsApplicationType _ApplicationType;
        clsLicenseClass _LicenseClass;
        clsUser _CurrentUser;

        void Save()
        {
            clsApplication ReplacementLicenseApplication = new clsApplication();

            ReplacementLicenseApplication.ApplicantPersonID = clsDriver.Find(_OldLicense.DriverID).PersonID;
            ReplacementLicenseApplication.ApplicationDate = DateTime.Now;
            ReplacementLicenseApplication.LastStatusDate = DateTime.Now;
            ReplacementLicenseApplication.ApplicationTypeID = _ApplicationType.ApplicationTypeID; /// International License have ID : 6
            ReplacementLicenseApplication.ApplicationStatusID = 3; /// Complate status have ID : 3
            ReplacementLicenseApplication.CreatedByUserID = _CurrentUser.UserID;
            ReplacementLicenseApplication.PaidFees = _ApplicationType.Fees;

            if (ReplacementLicenseApplication.Save())
            {
                lblLicenesReplacedAppID.Text = ReplacementLicenseApplication.ApplicationID.ToString();
                clsLicense NewLicense = new clsLicense();
               
                NewLicense.ApplicationID = ReplacementLicenseApplication.ApplicationID;
                NewLicense.DriverID = _OldLicense.DriverID;
                NewLicense.LicenseClassID = _LicenseClass.LicenseClassID;
                NewLicense.IssueDate = _OldLicense.IssueDate;
                NewLicense.ExpirationDate = _OldLicense.ExpirationDate;
                NewLicense.Notes = _OldLicense.Notes;
                NewLicense.PaidFees = _LicenseClass.ClassFees;
                NewLicense.IsActive = true; 
                NewLicense.IssueReasonID = (rbLostLicense.Checked ? 3 : 4); 
                NewLicense.CreatedByUserID = _CurrentUser.UserID;

                if (NewLicense.Save())
                { 
                    _OldLicense.IsActive = false;
                    if(_OldLicense.Save())
                    MessageBox.Show("License Replaced Successfully With ID: " + NewLicense.LicenseID, "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblReplacedLicenseID.Text = NewLicense.LicenseID.ToString();
                    btnIssueReplacement.Enabled = false;
                    LlblNewShowLicensesInfo.Enabled = true;
                    gbFilter.Enabled = false;
                }
            }
        }

        public void tbLicenseIDFocus()
        {
            tbLicenseID.Focus();
        }

        public void btnSearchLicenseClick()
        {
            btnSearchLicense.PerformClick();
        }

        public void FillInfo(int LocalLicenseID)
        {
            _OldLicense = clsLicense.Find(LocalLicenseID);
            _LicenseClass = clsLicenseClass.Find(_OldLicense.LicenseClassID);
            _ApplicationType = clsApplicationType.Find((rbLostLicense.Checked? 3:4));
            _CurrentUser = clsUser.Find(Convert.ToInt32(File.ReadAllText("LoginUserID")));

            ctrDriverLicenseInfo1.FillInfo(LocalLicenseID);

            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblApplicationFees.Text = _ApplicationType.Fees.ToString();
            lblCreatedBy.Text = _CurrentUser.UserName;
            lblOldLicenseID.Text = LocalLicenseID.ToString();
        }

        private void Title_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = (rbDamagedLicense.Checked ? "Replacement for Damaged License" : "Replacement for Lost License");
            _ApplicationType = clsApplicationType.Find((rbLostLicense.Checked ? 3 : 4));
            lblApplicationFees.Text = _ApplicationType.Fees.ToString();
            ReplacementTitle.Invoke((rbDamagedLicense.Checked ? "Replacement for Damaged License" : "Replacement for Lost License"));
        }

        private void btnSearchLicense_Click(object sender, EventArgs e)
        {
            if (!clsLicense.isLicenseExist(Convert.ToInt32(tbLicenseID.Text)))
                return;
             LlblShowLicensesHistory.Enabled = true;
            this.FillInfo(Convert.ToInt32(tbLicenseID.Text));

            if (!_OldLicense.IsActive)
            {
                MessageBox.Show("You can't Replace this license because it's not Active. ", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnIssueReplacement.Enabled = false;
                btnIssueReplacement.OnHoverBaseColor = Color.Transparent;
                return;
            }

            if (_OldLicense.ExpirationDate < DateTime.Today)
            {
                MessageBox.Show("You can't Replace this license because it's Expire. ", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnIssueReplacement.Enabled = false;
                btnIssueReplacement.OnHoverBaseColor = Color.Transparent;
                return;
            }
            btnIssueReplacement.OnHoverBaseColor = Color.FromArgb(151, 143, 255);
            btnIssueReplacement.Enabled = true;
                
        }

        private void LlblNewShowLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo ShowNewLicenseInfo = new frmLicenseInfo(Convert.ToInt32(lblReplacedLicenseID.Text));
            ShowNewLicenseInfo.MdiParent = this.ParentForm.MdiParent;
            ShowNewLicenseInfo.Show();
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void LlblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory ShowLicensesHistory = new frmLicenseHistory(_OldLicense.DriverID);
            ShowLicensesHistory.MdiParent = this.ParentForm.MdiParent;
            ShowLicensesHistory.Show();
        }


        
    }
}
