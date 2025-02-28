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
    public partial class ctrDriverLicenses : UserControl
    {
        public ctrDriverLicenses()
        {
            InitializeComponent();
        }

        public void FillInfo(int DriverID)
        {
            
            dgvLocalLicensesHistory.DataSource = clsLicense.GetAllDriverLicenses(DriverID);
            lblRecordCount.Text = "# Records: " + dgvLocalLicensesHistory.RowCount;
            dgvInternationalLicensesHistory.DataSource = clsInternationalLicense.GetAllDriverInternationalLicenses(DriverID);
           
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                lblRecordCount.Text = "# Records: " + dgvLocalLicensesHistory.RowCount;
            else
                lblRecordCount.Text = "# Records: " + dgvInternationalLicensesHistory.RowCount;

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                frmLicenseInfo ShowNewLicenseInfo = new frmLicenseInfo(Convert.ToInt32(dgvLocalLicensesHistory.SelectedRows[0].Cells[0].Value));
                ShowNewLicenseInfo.MdiParent = this.ParentForm.MdiParent;
                ShowNewLicenseInfo.Show();
            }
            //else
            //{
            //    frmShowInternationalDrivingLicense ShowInternationalLicenseInfo = new frmShowInternationalDrivingLicense(
            //}

        }

    }
}
