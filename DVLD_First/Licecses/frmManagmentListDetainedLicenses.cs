using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DVLD_Business;
using DVLD_First.People;
using DVLD_First.Licecses;




namespace DVLD_First.Licecses
{
    public partial class frmManagmentListDetainedLicenses : Form
    {
        public frmManagmentListDetainedLicenses()
        {
            InitializeComponent();
        }

        int _SelectedLicenseID = -1;

        void LoadAllDetains()
        {
            dgvListDetaindLicenses.DataSource = clsDetain.GetAllDetains();
            lblRecordCount.Text = "# Records " + dgvListDetaindLicenses.RowCount;
        }

        void FiltringByDetainID()
        {
            string rowFilter = string.Format("convert([{0}],'System.String') like '{1}%'", "D.ID", Convert.ToInt32(tbSearchedText.Text));
            (dgvListDetaindLicenses.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringByReleaseApplicationID()
        {
            string rowFilter = string.Format("convert([{0}],'System.String') like '{1}%'", "Release App.ID", Convert.ToInt32(tbSearchedText.Text));
            (dgvListDetaindLicenses.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringByLicenseID()
        {
            string rowFilter = string.Format("convert([{0}],'System.String') like '{1}%'", "L.ID", Convert.ToInt32(tbSearchedText.Text));
            (dgvListDetaindLicenses.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
       

        void FiltringByNationalNo()
        {
            string rowFilter = string.Format("[{0}] like '{1}%'", "N.No", tbSearchedText.Text);
            (dgvListDetaindLicenses.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringByDetainDate()
        {
            string rowFilter = string.Format("convert([{0}],'System.String') like '{1}%' ", "Detain Date", tbSearchedText.Text);
            (dgvListDetaindLicenses.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringByReleasedDate()
        {
            string rowFilter = string.Format("convert([{0}],'System.String') like '{1}%' ", "Release Date", tbSearchedText.Text);
            (dgvListDetaindLicenses.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringByFineFees()
        {
            string rowFilter = string.Format("convert([{0}],'System.String') like '{1}%' ", "Fine Fees", tbSearchedText.Text);
            (dgvListDetaindLicenses.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringReleased()
        {
            string rowFilter = string.Format("{0} = {1}", "Is Released", 1);
            (dgvListDetaindLicenses.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
        void FiltringUnreleased()
        {
            string rowFilter = string.Format("{0} = {1}", "Is Released", 0);
            (dgvListDetaindLicenses.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }


        void FiltringByName()
        {
            string rowFilter = string.Format("[{0}] like '{1}%' ", "Full Name",tbSearchedText.Text);
            (dgvListDetaindLicenses.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void Filtring()
        {
            if (cbFiltering.SelectedText == "None" || string.IsNullOrWhiteSpace(tbSearchedText.Text))
            {
                (dgvListDetaindLicenses.DataSource as DataTable).DefaultView.RowFilter = "";
                return;
            }

            switch (cbFiltering.SelectedItem.ToString())
            {
                case "Detain ID":
                    FiltringByDetainID();
                    break;
                case "License ID":
                    FiltringByLicenseID();
                    break;
                case "National No.":
                    FiltringByNationalNo();
                    break;
                case "Detain Date":
                    FiltringByDetainDate();
                    break;
                case "Fine Fees":
                    FiltringByFineFees();
                    break;
                case "Name":
                    FiltringByName();
                    break;
                case "Release Application ID":
                    FiltringByReleaseApplicationID();
                    break;
                case "Release Date":
                    FiltringByReleasedDate();
                    break;
                //case "Status":
                //    FiltringByStatus();
                //    break;


            }
        }


        private void btnAddNewDetained_Click(object sender, EventArgs e)
        {
            frmDetainLicense DetainLicense = new frmDetainLicense(_SelectedLicenseID);
            DetainLicense.MdiParent = this.MdiParent;
            DetainLicense.Show();
            LoadAllDetains();
        }

        private void btnReleasedDetain_Click(object sender, EventArgs e)
        {
            frmReleaseLicense ReleaseLicense = new frmReleaseLicense(_SelectedLicenseID);
            ReleaseLicense.MdiParent = this.MdiParent;
            ReleaseLicense.Show();
        }

        private void frmManagmentListDetainedLicenses_Load(object sender, EventArgs e)
        {
            LoadAllDetains();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showdetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonDetails ShowPersonDetails = new frmShowPersonDetails(clsDriver.Find(clsLicense.Find(_SelectedLicenseID).DriverID).PersonID);
            ShowPersonDetails.MdiParent = this.MdiParent;
            ShowPersonDetails.Show();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseInfo ShowLicenseInfo = new frmLicenseInfo(_SelectedLicenseID);
            ShowLicenseInfo.MdiParent = this.MdiParent;
            ShowLicenseInfo.Show();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseHistory LicenseHistory = new frmLicenseHistory(clsLicense.Find(_SelectedLicenseID).DriverID);
            LicenseHistory.MdiParent = this.ParentForm;
            LicenseHistory.Show();
        }

        private void ReleaseDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseLicense ReleaseLicense = new frmReleaseLicense(_SelectedLicenseID);
            ReleaseLicense.MdiParent = this.MdiParent;
            ReleaseLicense.Show();
        }

        private void cmsLicenseOptions_Opening(object sender, CancelEventArgs e)
        {
            _SelectedLicenseID = Convert.ToInt32(dgvListDetaindLicenses.SelectedRows[0].Cells[1].Value);
        }

        private void tbSearchedText_TextChanged(object sender, EventArgs e)
        {
            Filtring();
        }

        private void cbFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltering.SelectedIndex == 0)
            {
                tbSearchedText.Visible = false;
                cbStatusToFiltering.Visible = false;
                cbStatusToFiltering.SelectedIndex = 0;
                tbSearchedText.Clear();
                return;

            }


            tbSearchedText.Visible = true;
            tbSearchedText.Focus();

        }

        



    }
}
