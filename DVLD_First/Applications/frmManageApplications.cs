using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DVLD_First.Applications;
using DVLD_First.Licecses;
using DVLD_Business;


using DVLD_Business;
using DVLD_Business;




namespace DVLD_First.Applications
{
    public partial class frmManageApplications : Form
    {
        public frmManageApplications(clsUser CurrentUser)
        {
            InitializeComponent();
            _CurrentUser = CurrentUser;
        }
        clsUser _CurrentUser;
        int SelectedLocalDrivingLicenseApplicationID =-1;
        DataTable _CurrentLocalDriverLicenseApplications;

        void CheckPassedTests()
        {

            switch ((int)dgvLocalDrivingLicenseApplications.SelectedRows[0].Cells["Passed Tests"].Value)
            {

                case 0:
                    visionTestToolStripMenuItem.Enabled = true;
                    WritingTestToolStripMenuItem.Enabled = false;
                    streatTestToolStripMenuItem.Enabled = false;
                    break;
                case 1:
                    visionTestToolStripMenuItem.Enabled = false;
                    WritingTestToolStripMenuItem.Enabled = true;
                    streatTestToolStripMenuItem.Enabled = false;
                    break;
                case 2:
                    visionTestToolStripMenuItem.Enabled = false;
                    WritingTestToolStripMenuItem.Enabled = false;
                    streatTestToolStripMenuItem.Enabled = true;
                    break;
                case 3:
                    ScheduleTestToolStripMenuItem.Enabled = false;
                   break;

            }
        }

        void ApplicationOptions()
        {
            if (dgvLocalDrivingLicenseApplications.SelectedRows[0].Cells["Status"].Value.ToString() == "Cancelled")
            {
                showdetailsToolStripMenuItem.Enabled = false;
                EditApplicationToolStripMenuItem.Enabled = false;
                DeleteApplicationToolStripMenuItem.Enabled = false;
                CancelApplicationToolStripMenuItem.Enabled = false;
                ScheduleTestToolStripMenuItem.Enabled = false;
                IssueDrivingLicenseToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;
                showPersonLicenseHistoryToolStripMenuItem.Enabled = false;
                return;
            }


            if (dgvLocalDrivingLicenseApplications.SelectedRows[0].Cells["Status"].Value.ToString() == "Complated")
            {
                EditApplicationToolStripMenuItem.Enabled = false;
                DeleteApplicationToolStripMenuItem.Enabled = false;
                CancelApplicationToolStripMenuItem.Enabled = false;
                ScheduleTestToolStripMenuItem.Enabled = false;
                IssueDrivingLicenseToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = true;
                showdetailsToolStripMenuItem.Enabled = true;
                showPersonLicenseHistoryToolStripMenuItem.Enabled = true;
                return;
            }
            else
            {
                
                    EditApplicationToolStripMenuItem.Enabled = true;
                    DeleteApplicationToolStripMenuItem.Enabled = true;
                    CancelApplicationToolStripMenuItem.Enabled = true;
                    ScheduleTestToolStripMenuItem.Enabled = true;
                    showLicenseToolStripMenuItem.Enabled = false;
                    IssueDrivingLicenseToolStripMenuItem.Enabled = false;

                if ((int)dgvLocalDrivingLicenseApplications.SelectedRows[0].Cells["Passed Tests"].Value == 3)
                {
                    IssueDrivingLicenseToolStripMenuItem.Enabled = true;
                    ScheduleTestToolStripMenuItem.Enabled = false;
                    return;
                }

            }
           
        }

        void FiltringByLDLApplicationID()
        {
            string rowFilter = string.Format("convert([{0}],'System.String') like '{1}%'", "L.D.L.AppID", Convert.ToInt32(tbSearchedText.Text));
            (dgvLocalDrivingLicenseApplications.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringByName()
        {
            string rowFilter = string.Format("[{0}] like '{1}%'", "Full Name", tbSearchedText.Text);
            (dgvLocalDrivingLicenseApplications.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringByNationalNo()
        {
            string rowFilter = string.Format("[{0}] like '{1}%'", "National No.", tbSearchedText.Text);
            (dgvLocalDrivingLicenseApplications.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringByApplicationDate()
        {
            string rowFilter = string.Format("convert([{0}],'System.String') like '{1}%' ", "Application Date", tbSearchedText.Text);
            (dgvLocalDrivingLicenseApplications.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringByPassedTests()
        {
            string rowFilter = string.Format("convert([{0}],'System.String') like '{1}%' ", "Passed Tests", tbSearchedText.Text);
            (dgvLocalDrivingLicenseApplications.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringByStatus()
        {
            string rowFilter = string.Format("convert([{0}],'System.String') like '{1}%' ", "Status", cbStatusToFiltering.SelectedItem);
            (dgvLocalDrivingLicenseApplications.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void Filtring()
        {
            if (cbFiltering.SelectedText == "None" || string.IsNullOrWhiteSpace(tbSearchedText.Text))
            {
                (dgvLocalDrivingLicenseApplications.DataSource as DataTable).DefaultView.RowFilter = "";
                return;
            }

            switch (cbFiltering.SelectedItem.ToString())
            {
                case "L.D.L. App. ID":
                    FiltringByLDLApplicationID();
                    break;
                case "Name":
                    FiltringByName();
                    break;
                case "National No.":
                    FiltringByNationalNo();
                    break;
                case "Application Date":
                    FiltringByApplicationDate();
                    break;
                case "Passed Tests":
                    FiltringByPassedTests();
                    break;
                //case "Status":
                //    FiltringByStatus();
                //    break;
                

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadAllLocalDrivingLicenseApplications()
        {
            _CurrentLocalDriverLicenseApplications = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
            dgvLocalDrivingLicenseApplications.DataSource = _CurrentLocalDriverLicenseApplications;
            lblRecordCount.Text = "# Record " + dgvLocalDrivingLicenseApplications.RowCount;

        }

        bool DeleteApplication(int LocalDrivingLicenseApplicationID)
        {
            
            clsLocalDrivingLicenseApplication _LocalLicense = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID);
            clsApplication _Application = clsApplication.Find(_LocalLicense.ApplicationID);
            DataTable AllApplicationAppointments = clsTestAppointment.GetAllApplicationAppointmentsByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID); //clsTestAppointment.GetAllApplicationAppointmentsByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);

            foreach (DataRow row in AllApplicationAppointments.Rows)
            {
                /// delete all tests
                clsTests.DeleteTestByTestAppointmentID((int)row["Appointment ID"]);
            }

            foreach (DataRow row in AllApplicationAppointments.Rows)
            {
                /// delete all appointments
                clsTestAppointment.DeleteAppointment((int)row["Appointment ID"]);
            }

            /// delete all retake tests if there is 
            clsRetakeTest.DeleteRetakeTestByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);

            if (clsLocalDrivingLicenseApplication.DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID))
            {
                if (clsApplication.DeleteApplication(_Application.ApplicationID))
                {
                    LoadAllLocalDrivingLicenseApplications();
                    return true;
                }
            }
            return false;

        }

        bool CancelApplication(int LocalDrivingLicenseApplicationID)
        {
            clsLocalDrivingLicenseApplication _LocalLicense = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID);
            clsApplication _Application = clsApplication.Find(_LocalLicense.ApplicationID);
            _Application.ApplicationStatusID = 2;// that mean is cancelled

            if (_Application.Save())
            {
                LoadAllLocalDrivingLicenseApplications();
                return true;
            }

            return false;
        }

        private void frmManageApplications_Load(object sender, EventArgs e)
        {
            LoadAllLocalDrivingLicenseApplications();
        }

        private void ScheduleTestToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            CheckPassedTests();
        }

        private void visionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestAppointment VisionTestScreen = new frmTestAppointment(SelectedLocalDrivingLicenseApplicationID);
            VisionTestScreen.MdiParent = this.ParentForm;
            VisionTestScreen.RefreshTable += LoadAllLocalDrivingLicenseApplications;
            VisionTestScreen.Show();
        }

        private void WritingTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestAppointment WrittingTestScreen = new frmTestAppointment(SelectedLocalDrivingLicenseApplicationID, "Writting");
            WrittingTestScreen.MdiParent = this.ParentForm;
            WrittingTestScreen.RefreshTable += LoadAllLocalDrivingLicenseApplications;
            WrittingTestScreen.Show();
        }

        private void streatTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestAppointment StreeatTestScreen = new frmTestAppointment(SelectedLocalDrivingLicenseApplicationID, "Streeat");
            StreeatTestScreen.MdiParent = this.ParentForm;
            StreeatTestScreen.RefreshTable += LoadAllLocalDrivingLicenseApplications;
            StreeatTestScreen.Show();
        }

        private void dgvLocalDrivingLicenseApplications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddNewLocalDriverLicenseApplication_Click(object sender, EventArgs e)
        {
            frmAddNewApplication AddLicense = new frmAddNewApplication(_CurrentUser);
            AddLicense.MdiParent = this.ParentForm;
            AddLicense.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmsPeople_Opening(object sender, CancelEventArgs e)
        {
            SelectedLocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.SelectedRows[0].Cells[0].Value;
            ApplicationOptions();
        }

        private void IssueDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueLicenseFirstTime IssueLicense = new frmIssueLicenseFirstTime(SelectedLocalDrivingLicenseApplicationID, _CurrentUser);
            IssueLicense.MdiParent = this.ParentForm;
            IssueLicense.Show();
        }

        private void ScheduleTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showLicenseToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            
          
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.Find(SelectedLocalDrivingLicenseApplicationID);
            
            frmLicenseInfo ShowLicenseInfo = new frmLicenseInfo(clsLicense.Find(_LocalDrivingLicenseApplication.ApplicationID,true).LicenseID);
            ShowLicenseInfo.MdiParent = this.ParentForm;
            ShowLicenseInfo.Show();
        }

        private void DeleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wanna delete this application", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.OK)
            {
                if (DeleteApplication(SelectedLocalDrivingLicenseApplicationID))
                {
                    MessageBox.Show("Delete Application Successfully", "Delete Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void CancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wanna cancel this application", "Confirm cancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.OK)
            {
                if (CancelApplication(SelectedLocalDrivingLicenseApplicationID))
                    MessageBox.Show("Cancel Application Successfully", "Cancel Application", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLicenseHistory LicenseHistory = new frmLicenseHistory(clsDriver.Find(clsPerson.Find(dgvLocalDrivingLicenseApplications.SelectedRows[0].Cells["National No."].Value.ToString()).ID,true).DriverID);
            LicenseHistory.MdiParent = this.ParentForm;
            LicenseHistory.Show();
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
            
            if (cbFiltering.SelectedItem == "Status" )
            {
                cbStatusToFiltering.Visible= true;
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
                (dgvLocalDrivingLicenseApplications.DataSource as DataTable).DefaultView.RowFilter = "";
                return;
            }
            FiltringByStatus();
        }

        private void tbSearchedText_TextChanged(object sender, EventArgs e)
        {
            Filtring();
        }

        private void tbSearchedText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFiltering.SelectedItem == "L.D.L. App. ID"  || cbFiltering.SelectedItem == "Passed Tests")
            {
                e.Handled = (char.IsLetter(e.KeyChar) ? true : (char.IsPunctuation(e.KeyChar) ? true : (char.IsSymbol(e.KeyChar) ? true:false)));
                return;
            }

            if (cbFiltering.SelectedItem == "Application Date")
            {
                e.Handled = (char.IsLetter(e.KeyChar) ? true : (char.IsSymbol(e.KeyChar) ? true: false));
            }
        }
    }
}
