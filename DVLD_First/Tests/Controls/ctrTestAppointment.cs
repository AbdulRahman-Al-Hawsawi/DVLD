using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DVLD_Business;
using DVLD_First.Properties;
using DVLD_First.People;


namespace DVLD_First.Controls
{
    public partial class ctrTestAppointment : UserControl
    {
        int _LocalDrivingLicenseApplicationID;
        string _Title;
        clsPerson _Person;
        public ctrTestAppointment()
        {
            InitializeComponent();
        }

         public void FillInfo(int LocalDrivingLicenseApplicationID,string Title = "Vision")
        {
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _Title = Title;
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =  clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID);
            clsApplication Application = clsApplication.Find(LocalDrivingLicenseApplication.ApplicationID);

         
            _Person = clsPerson.Find(Application.ApplicantPersonID);
            lblApplicatinID.Text = Application.ApplicationID.ToString();
            lblApplicant.Text = _Person.FullName;
            lblApplicationDate.Text = Application.ApplicationDate.ToShortDateString();
            lblApplicationFees.Text = Application.PaidFees.ToString();
            lblApplicationType.Text = clsApplicationType.Find(Application.ApplicationTypeID).Title;
            lblStatus.Text = "New";
            lblStatusDate.Text = Application.LastStatusDate.ToShortDateString();
            lblCreatedUsername.Text = clsUser.Find(Application.CreatedByUserID).UserName;

            lblDLAppID.Text = LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblClassaName.Text = clsLicenseClass.Find(LocalDrivingLicenseApplication.LicenseClassID).ClassName;
            lblPassedTests.Text = LocalDrivingLicenseApplication.PassedTests().ToString() + "/3";
           


        }


         void AddAppointment()
         {
             Applications.frmScheduleTest dd = new Applications.frmScheduleTest(_LocalDrivingLicenseApplicationID,_Title);
             dd.MdiParent = this.ParentForm.ParentForm;
             dd.Show();

         }

        private void lblRAppFees_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            AddAppointment();
        }
        
        private void ctrTestAppointment_Load(object sender, EventArgs e)
        {

        }

        private void LlblViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonDetails PersonInfo = new frmShowPersonDetails(_Person.ID);
            PersonInfo.MdiParent = this.ParentForm.ParentForm;
            PersonInfo.Show();
        }
    }
}
