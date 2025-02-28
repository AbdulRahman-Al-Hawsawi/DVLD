using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DVLD_First.Applications;
using DVLD_Business;
using DVLD_Business;


using DVLD_First.Properties;

namespace DVLD_First.Applications
{
    public partial class frmTestAppointment : Form
    {
       
        
        public frmTestAppointment(int LDLAppID, string TestTitle = "Vision")
        {
            InitializeComponent();
            this.Text = TestTitle + " Test Appointments";
            _TestTitle = TestTitle;
            _LDLAppID = LDLAppID;
        }
       
        int _LDLAppID = -1;
        string _TestTitle = "";


        public delegate void DataBackEventHandler();
        public event DataBackEventHandler RefreshTable;

       
        bool IsHaveActiveAppointmentOrHeIsPassedTest()
        {
            bool Result = false;
            foreach (DataRow row in clsTestAppointment.GetAllApplicationAppointmentsByLocalDrivingLicenseApplicationIdAndTestTypeID(_LDLAppID,clsLocalDrivingLicenseApplication.GetPassedTestNumberForLocalDrivingLicenseApplication(_LDLAppID) +1).Rows)
            {
                
                if ((bool)row["Is Locked"] == false)
                {
                    MessageBox.Show("Is have an active appointment, you can add appointment when the appointments are locked  ", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return  true;
                   
                }

            }
           
            int PassedTests = 0;

            PassedTests = clsLocalDrivingLicenseApplication.GetPassedTestNumberForLocalDrivingLicenseApplication(_LDLAppID);
           
            switch (_TestTitle)
            {
                case "Vision":
                    Result = (PassedTests == 1 ? true : false);
                    break;
                case "Writting":
                    Result = (PassedTests == 2 ? true : false);
                    break;
                case "Streeat":
                    Result = (PassedTests == 3 ? true : false);
                    break;


            }

            if(Result == true)
                MessageBox.Show("This person already passed this test before, you can only retake faild test","Not Allowed",MessageBoxButtons.OK,MessageBoxIcon.Error );


            return Result;


        }

        void LoadCurrentAppointments()
        {
            ctrTestAppointment1.FillInfo(_LDLAppID, _TestTitle);
            int TestTypeID = 0;
            switch (_TestTitle)
            {
                case "Vision":
                   TestTypeID = 1 ;
                    break;
                case "Writting":
                    TestTypeID = 2;
                    break;
                case "Streeat":
                    TestTypeID = 3;
                    break;


            }

            dgvAppointmentsTable.DataSource = clsTestAppointment.GetAllApplicationAppointmentsByLocalDrivingLicenseApplicationIdAndTestTypeID(_LDLAppID,TestTypeID); 
          
            lblRecordCount.Text = "# Record: " + dgvAppointmentsTable.RowCount;
           

        }

        void LoadAllAppointments()
        {
           
            dgvAppointmentsTable.DataSource = clsTestAppointment.GetAllApplicationAppointmentsByLocalDrivingLicenseApplicationIdAndTestTypeID(_LDLAppID,
            clsLocalDrivingLicenseApplication.GetPassedTestNumberForLocalDrivingLicenseApplication(_LDLAppID) + 1); /// add one because we need next text appointment if he passed from any test

            lblRecordCount.Text = "# Record: " + dgvAppointmentsTable.RowCount;
        }

        private void frmTestAppointment_Load(object sender, EventArgs e)
        {
            lblTitle.Text = _TestTitle + " Test Appoinments";
            switch (_TestTitle)
            {
                case "Vision":
                    pbTestImage.Image = Resources.eye_Large;
                    break;
                case "Writting":
                    pbTestImage.Image = Resources.exam;
                    break;
                case "Streeat":
                    pbTestImage.Image = Resources.CarLarge;
                    break;


            }
            LoadAllAppointments();
            ctrTestAppointment1.FillInfo(_LDLAppID,_TestTitle);
        }

     
        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if (IsHaveActiveAppointmentOrHeIsPassedTest())
                return;
            
            frmScheduleTest NewTest = new  frmScheduleTest(_LDLAppID,_TestTitle);
            NewTest.MdiParent = this.ParentForm;
            NewTest.RefreshTable += LoadAllAppointments;
            NewTest.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScheduleTest NewTest = new frmScheduleTest(_LDLAppID, _TestTitle,Convert.ToInt32(dgvAppointmentsTable.SelectedRows[0].Cells[0].Value));
            NewTest.MdiParent = this.ParentForm;
            NewTest.RefreshTable += LoadAllAppointments;
            NewTest.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTakeTest TakeTest = new frmTakeTest(_LDLAppID,_TestTitle,Convert.ToInt32(dgvAppointmentsTable.SelectedRows[0].Cells[0].Value));
            TakeTest.MdiParent = this.ParentForm;
            TakeTest.RefreshTable += LoadCurrentAppointments;
            TakeTest.Show();
        }

        private void frmTestAppointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshTable.Invoke();
        }

        private void cmsAppointment_Opening(object sender, CancelEventArgs e)
        {
            if ((bool)dgvAppointmentsTable.SelectedRows[0].Cells["Is Locked"].Value == true)
                cmsAppointment.Enabled = false;
            else
                cmsAppointment.Enabled = true;
        }

        private void ctrTestAppointment1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
