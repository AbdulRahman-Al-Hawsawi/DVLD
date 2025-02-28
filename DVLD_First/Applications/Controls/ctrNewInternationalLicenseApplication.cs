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



namespace DVLD_First.Controls
{
    public partial class ctrNewInternationalLicenseApplication : UserControl
    {
        public ctrNewInternationalLicenseApplication()
        {
            InitializeComponent();
        }
        clsApplicationType _ApplicationType = clsApplicationType.Find(6);
        clsUser _CurrentUser;
         clsLicense _License ;
         clsLocalDrivingLicenseApplication _LocalDrivingLicense;
         clsApplication _LocalDrivingLicenseApplication;
         clsInternationalLicense NewInternationalLicense;

        public void FillInfo(clsUser CurrentUser)
        {
            _CurrentUser = CurrentUser;
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
            lblFees.Text = _ApplicationType.Fees.ToString();
            lblCreatedBy.Text = _CurrentUser.UserName;
            
        }

        bool isHaveLicenseFromClass3()
        {
            return (clsLicense.Find(Convert.ToInt32(tbLicenseID.Text)).LicenseClassID == 3 ? true : false);
        }

        void Save()
        {

            clsInternationalLicense International = clsInternationalLicense.Find(_License.DriverID,true);
            if (International != null && International.ExpirationDate != DateTime.Now)
            {
                
                MessageBox.Show("You can't add new international license because this driver already have one. ", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnIssue.Enabled = false;
                return;
            }

            if (!_License.IsActive)
            {
                
                MessageBox.Show("You can't add new international license because this license is not Active. ", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnIssue.Enabled = false;
                return;
            }


            clsApplication NewInternationalLicenseApplication = new clsApplication();

            NewInternationalLicenseApplication.ApplicantPersonID = _LocalDrivingLicenseApplication.ApplicantPersonID;
            NewInternationalLicenseApplication.ApplicationDate = DateTime.Now;
            NewInternationalLicenseApplication.LastStatusDate = DateTime.Now;
            NewInternationalLicenseApplication.ApplicationTypeID = 6; /// International License have ID : 6
            NewInternationalLicenseApplication.ApplicationStatusID = 1; /// New status have ID : 1
            NewInternationalLicenseApplication.CreatedByUserID = _CurrentUser.UserID;
            NewInternationalLicenseApplication.PaidFees = clsLicenseClass.Find(6).ClassFees;

            if (NewInternationalLicenseApplication.Save())
            {
                 NewInternationalLicense = new clsInternationalLicense();
                NewInternationalLicense.ApplicationID = NewInternationalLicenseApplication.ApplicationID;
                NewInternationalLicense.DriverID = _License.DriverID;
                NewInternationalLicense.IssuedUsingLocalLicenseID = _License.LicenseID;
                NewInternationalLicense.IssueDate = DateTime.Now;
                NewInternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
                NewInternationalLicense.IsActive = true;
                NewInternationalLicense.CreatedByUserID = _CurrentUser.UserID;

                if (NewInternationalLicense.Save())
                {
                    MessageBox.Show("Add New International License Successfully With ID: " + NewInternationalLicense.InternationalLicenseID, "Add International License", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblInternationalLicenesAppID.Text = NewInternationalLicense.ApplicationID.ToString();
                    lblInternationalLocalLicenseID.Text = NewInternationalLicense.InternationalLicenseID.ToString();
                }
           
            }
                                 
        }

        private void ctrNewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearchLicense_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLicenseID.Text))
                return;

            btnIssue.Enabled = true;

            if (!clsLicense.isLicenseExist(Convert.ToInt32(tbLicenseID.Text)))
            {
                MessageBox.Show("There no License with this ID");
                return;
            }

            if (!isHaveLicenseFromClass3())
            {
                MessageBox.Show("This license not allowed,\nThe license must be from Class 3 - Ordinary driving license", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;                
            }

             _License = clsLicense.Find(Convert.ToInt32(tbLicenseID.Text));
             _LocalDrivingLicense = clsLocalDrivingLicenseApplication.Find(_License.ApplicationID,true);
             _LocalDrivingLicenseApplication = clsApplication.Find(_LocalDrivingLicense.ApplicationID);
            ctrDriverLicenseInfo1.FillInfo(_LocalDrivingLicense.LocalDrivingLicenseApplicationID);
            LlblShowLicensesHistory.Enabled = true;
            LlblShowLicensesInfo.Enabled = true;
            lblLocalLicenseID.Text = tbLicenseID.Text;
        }

        private void tbLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsNumber(e.KeyChar) ? true : false);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void LlblShowLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationalDrivingLicense ShowLicenseInfo = new frmShowInternationalDrivingLicense(Convert.ToInt32(lblLocalLicenseID.Text));
            ShowLicenseInfo.MdiParent = this.ParentForm.MdiParent;
            ShowLicenseInfo.Show();
        }

        private void LlblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory ShowLicenseHistory = new frmLicenseHistory(_LocalDrivingLicense.LocalDrivingLicenseApplicationID);
            ShowLicenseHistory.MdiParent = this.ParentForm.MdiParent;
            ShowLicenseHistory.Show();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
