using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DVLD_Business;
using System.IO;
using DVLD_First.People;


namespace DVLD_First.Licecses
{
    public partial class frmListInternationalLicenseApplications : Form
    {
        public frmListInternationalLicenseApplications()
        {
            InitializeComponent();
        }

        void FiltringByIntLicenesID()
        {
            string rowFilter = string.Format("convert([{0}],'System.String') like '{1}%'", "Int.License ID", Convert.ToInt32(tbSearchedText.Text));
            (dgvInternationalLicenseApplications.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringByApplicationID()
        {
            string rowFilter = string.Format("convert([{0}],'System.String') like '{1}%'", "Application ID", Convert.ToInt32(tbSearchedText.Text));
            (dgvInternationalLicenseApplications.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringByDriverID()
        {
            string rowFilter = string.Format("convert([{0}],'System.String') like '{1}%'", "Driver ID", Convert.ToInt32(tbSearchedText.Text));
            (dgvInternationalLicenseApplications.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringByLocalLicenseID()
        {
            string rowFilter = string.Format("convert([{0}],'System.String') like '{1}%'", "L.License ID", Convert.ToInt32(tbSearchedText.Text));
            (dgvInternationalLicenseApplications.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringByIssueDate()
        {
            string rowFilter = string.Format("convert([{0}],'System.String') like '{1}%' ", "Issue Date", tbSearchedText.Text);
            (dgvInternationalLicenseApplications.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringByExpirationeDate()
        {
            string rowFilter = string.Format("convert([{0}],'System.String') like '{1}%' ", "Expiration Date", tbSearchedText.Text);
            (dgvInternationalLicenseApplications.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringActiveLicenses()
        {
            string rowFilter = string.Format("[{0}] = {1}", "Is Active", 1);
            (dgvInternationalLicenseApplications.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringUnActiveLicenses()
        {
            string rowFilter = string.Format("[{0}] = {1}", "Is Active", 0);
            (dgvInternationalLicenseApplications.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringByTheActivity()
        {
            switch (cbStatusToFiltering.SelectedItem.ToString())
            {
              
                case "Active":
                    FiltringActiveLicenses();
                    break;
                case "UnActive":
                    FiltringUnActiveLicenses();
                    break;
            }

        }

        void Filtring()
        {
            if (cbFiltering.SelectedText == "None" || string.IsNullOrWhiteSpace(tbSearchedText.Text))
            {
                (dgvInternationalLicenseApplications.DataSource as DataTable).DefaultView.RowFilter = "";
                return;
            }

            switch (cbFiltering.SelectedItem.ToString())
            {
             
                case "Int. License ID":
                    FiltringByIntLicenesID();
                    break;
                case "Application ID":
                    FiltringByApplicationID();
                    break;
                case "Driver ID":
                    FiltringByDriverID();
                    break;
                case "L.License ID":
                    FiltringByLocalLicenseID();
                    break;
                case "Issue Date":
                    FiltringByIssueDate();
                    break;
                case "Expiration Date":
                    FiltringByExpirationeDate();
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadAllInternationalLicenseApplications()
        {
            dgvInternationalLicenseApplications.DataSource = clsInternationalLicense.GetAllInternationalLicenses();
            lblRecordCount.Text = "# Records: " + dgvInternationalLicenseApplications.RowCount;
        }

        private void frmListInternationalLicenseApplications_Load(object sender, EventArgs e)
        {
            LoadAllInternationalLicenseApplications();
        }

        private void btnAddNewInternationalLicenseApplication_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicenseApplication NewInternationalApplication = new frmNewInternationalLicenseApplication(clsUser.Find(Convert.ToInt32(File.ReadAllText("LoginUserID"))));
            NewInternationalApplication.MdiParent = this.ParentForm;
            NewInternationalApplication.Show();
        }

        private void cbFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltering.SelectedItem == "None")
            {
                tbSearchedText.Clear();
                tbSearchedText.Visible = false;
                cbStatusToFiltering.Visible = false;
                cbStatusToFiltering.SelectedIndex = 0;
                return;
            }

            if (cbFiltering.SelectedItem == "Status")
            {
                cbStatusToFiltering.Visible = true;
                tbSearchedText.Clear();
                tbSearchedText.Visible = false;
                return;
            }

            cbStatusToFiltering.Visible = false;
            cbStatusToFiltering.SelectedIndex = 0;
            tbSearchedText.Visible = true;
            tbSearchedText.Focus();

        }

        private void cbStatusToFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatusToFiltering.SelectedIndex == 0)
            {
                (dgvInternationalLicenseApplications.DataSource as DataTable).DefaultView.RowFilter = null;
                return;
            }
            FiltringByTheActivity();
        }

        private void tbSearchedText_TextChanged(object sender, EventArgs e)
        {
            Filtring();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseHistory LicenseHistory = new frmLicenseHistory(Convert.ToInt32(dgvInternationalLicenseApplications.SelectedRows[0].Cells["Driver ID"].Value));
            LicenseHistory.MdiParent = this.ParentForm;
            LicenseHistory.Show();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowInternationalDrivingLicense ShowLicenseDetails = new frmShowInternationalDrivingLicense(Convert.ToInt32(dgvInternationalLicenseApplications.SelectedRows[0].Cells[2].Value));
            ShowLicenseDetails.MdiParent = this.ParentForm;
            ShowLicenseDetails.Show();
        }

        private void showdetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonDetails ShowPersonDetails = new frmShowPersonDetails(clsDriver.Find(Convert.ToInt32(dgvInternationalLicenseApplications.SelectedRows[0].Cells[2].Value)).PersonID);
            ShowPersonDetails.MdiParent = this.ParentForm;
            ShowPersonDetails.Show();
        }

        private void tbSearchedText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFiltering.SelectedItem != "Expiration Date" && cbFiltering.SelectedItem != "Issue Date")
                e.Handled = (!char.IsNumber(e.KeyChar) ? true : false);
            else
                e.Handled = (char.IsLetter(e.KeyChar)? true : false);
        }
    }
}
