using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;




using DVLD_Business;

using System.IO;

using DVLD_First.Licecses;

namespace DVLD_First.Controls
{
    public partial class ctrApplicationNewLicenseInfo : UserControl
    {
        public ctrApplicationNewLicenseInfo()
        {
            InitializeComponent();
        }
        clsLicense _OldLicense;
        clsApplicationType _ApplicationType;
        clsLicenseClass _LicenseClass;
        clsUser _CurrentUser;

        void Save()
        {
            if (!_OldLicense.IsActive)
            {
                 MessageBox.Show("You can't Renew this license because it's not Active. ", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                btnRenew.Enabled = false;
                btnRenew.OnHoverBaseColor = Color.Transparent;
                 return;
            }

           

            clsApplication RenewLicenseApplication = new clsApplication();

            RenewLicenseApplication.ApplicantPersonID = clsDriver.Find(_OldLicense.DriverID).PersonID;
            RenewLicenseApplication.ApplicationDate = DateTime.Now;
            RenewLicenseApplication.LastStatusDate = DateTime.Now;
            RenewLicenseApplication.ApplicationTypeID = _ApplicationType.ApplicationTypeID; /// International License have ID : 6
            RenewLicenseApplication.ApplicationStatusID = 3; /// Complate status have ID : 3
            RenewLicenseApplication.CreatedByUserID = _CurrentUser.UserID;
            RenewLicenseApplication.PaidFees = _ApplicationType.Fees;

            if (RenewLicenseApplication.Save())
            {
                lblRenewLicenesAppID.Text = RenewLicenseApplication.ApplicationID.ToString();
                clsLicense NewLicense = new clsLicense();
               
                NewLicense.ApplicationID = RenewLicenseApplication.ApplicationID;
                NewLicense.DriverID = _OldLicense.DriverID;
                NewLicense.LicenseClassID = _LicenseClass.LicenseClassID;
                NewLicense.IssueDate = DateTime.Now;
                NewLicense.ExpirationDate = DateTime.Now.AddYears(_LicenseClass.DefaultValidityLength);
                NewLicense.Notes = (string.IsNullOrWhiteSpace(tbNotes.Text) ? "" : tbNotes.Text);
                NewLicense.PaidFees = _LicenseClass.ClassFees;
                NewLicense.IsActive = true;
                NewLicense.IssueReasonID = 2; // that mean is Renew
                NewLicense.CreatedByUserID = _CurrentUser.UserID;

                if (NewLicense.Save())
                { 
                    _OldLicense.IsActive = false;
                    if(_OldLicense.Save())
                    MessageBox.Show("Renew Local License Successfully With ID: " + NewLicense.LicenseID, "Renew Local License", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblRenewedLocalLicenseID.Text = NewLicense.LicenseID.ToString();
                    btnRenew.Enabled = false;
                    LlblNewShowLicensesInfo.Enabled = true;
                    gbFilter.Enabled = false;
                }
            }
        }

        public void FillInfo(int LocalLicenseID)
        {
             _OldLicense = clsLicense.Find(LocalLicenseID);
             _LicenseClass = clsLicenseClass.Find(_OldLicense.LicenseClassID);
             _ApplicationType = clsApplicationType.Find(2);
            _CurrentUser = clsUser.Find(Convert.ToInt32(File.ReadAllText("LoginUserID")));
            ctrDriverLicenseInfo1.FillInfo(LocalLicenseID);

            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblApplicationFees.Text = _ApplicationType.Fees.ToString();
            lblLicenseFees.Text = _LicenseClass.ClassFees.ToString();
            lblTotalFees.Text = (_ApplicationType.Fees + _LicenseClass.ClassFees).ToString();
            lblCreatedBy.Text = _CurrentUser.UserName;
            lblExpirationDate.Text = DateTime.Now.AddYears(_LicenseClass.DefaultValidityLength).ToShortDateString();
            lblOldLocalLicenseID.Text = LocalLicenseID.ToString();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Renew this license", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Save();
            }
           
        }

        private void btnSearchLicense_Click(object sender, EventArgs e)
        {
            btnRenew.Enabled = true;
            btnRenew.OnHoverBaseColor = Color.Transparent;
           
            if (!clsLicense.isLicenseExist(Convert.ToInt32(tbLicenseID.Text)))
                return;

            LlblShowLicensesHistory.Enabled = true;
            this.FillInfo(Convert.ToInt32(tbLicenseID.Text));

            if (_OldLicense.ExpirationDate > DateTime.Today)
            {
                MessageBox.Show("You can't renew this license because it expiration date is: " + _OldLicense.ExpirationDate.ToShortDateString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                btnRenew.Enabled = false;
                btnRenew.OnHoverBaseColor = Color.Transparent;
                return;
            }
         
        }

        private void LlblNewShowLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo ShowNewLicenseInfo = new frmLicenseInfo(Convert.ToInt32(lblRenewedLocalLicenseID.Text));
            ShowNewLicenseInfo.MdiParent = this.ParentForm.MdiParent;
            ShowNewLicenseInfo.Show();
        }

        private void LlblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory ShowLicensesHistory = new frmLicenseHistory(_OldLicense.DriverID);
            ShowLicensesHistory.MdiParent = this.ParentForm.MdiParent;
            ShowLicensesHistory.Show();
        }
    }
}
