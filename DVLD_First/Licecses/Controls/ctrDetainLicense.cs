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
    public partial class ctrDetainLicense : UserControl
    {
        public ctrDetainLicense()
        {
            InitializeComponent();
        }

        clsLicense _LicenseToDetain;
        clsUser _CurrentUser;

        public void FillInfo(int LocalLicenseID, bool DisapledFilter = false)
        {

            if (DisapledFilter)
            {
                gbFilter.Enabled = false;
                tbLicenseID.Text = LocalLicenseID.ToString();
            }

            _LicenseToDetain = clsLicense.Find(LocalLicenseID);
           _CurrentUser = clsUser.Find(Convert.ToInt32(File.ReadAllText("LoginUserID")));

            ctrDriverLicenseInfo1.FillInfo(LocalLicenseID);

            lblDetainDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedBy.Text = _CurrentUser.UserName;
            lblLicenseID.Text = LocalLicenseID.ToString();

            if (clsDetain.isDetainExistByLicenseID(_LicenseToDetain.LicenseID))
            {
                if (!clsDetain.Find(_LicenseToDetain.LicenseID, true).IsReleased)
                    MessageBox.Show("you can't Detain this  License because it already Deatained.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnDetain.Enabled = false;
                return;
            }
        }

        void Save()
        {
            clsDetain DetainLicense = new clsDetain();
            DetainLicense.LicenseID = _LicenseToDetain.LicenseID;
            DetainLicense.DetainDate = DateTime.Now;
            DetainLicense.FineFees = Convert.ToInt32(tbFineFees.Text);
            DetainLicense.IsReleased = false;
            DetainLicense.CreatedByUserID = _CurrentUser.UserID;

            if (DetainLicense.Save())
            {
                _LicenseToDetain.IsActive = false;
                if(_LicenseToDetain.Save())
                    MessageBox.Show("Detain License Successfully With ID: " + DetainLicense.LicenseID, "Detain License", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblDetainID.Text = DetainLicense.DetainID.ToString();
                btnDetain.Enabled = false;
                LlblShowDetainedLicensesInfo.Enabled = true;
                gbFilter.Enabled = false;
            }
                
            
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void btnSearchLicense_Click(object sender, EventArgs e)
        {
            if (!clsLicense.isLicenseExist(Convert.ToInt32(tbLicenseID.Text)))
                return;

            
            LlblShowLicensesHistory.Enabled = true;
            this.FillInfo(Convert.ToInt32(tbLicenseID.Text));

           
          
            btnDetain.Enabled = true;
        }

        private void LlblShowDetainedLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInfo ShowNewLicenseInfo = new frmLicenseInfo(Convert.ToInt32(lblLicenseID.Text));
            ShowNewLicenseInfo.MdiParent = this.ParentForm.MdiParent;
            ShowNewLicenseInfo.Show();
        }

        private void LlblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory ShowLicensesHistory = new frmLicenseHistory(_LicenseToDetain.DriverID);
            ShowLicensesHistory.MdiParent = this.ParentForm.MdiParent;
            ShowLicensesHistory.Show();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
