using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DVLD_First.Properties;
using DVLD_First.People;
using DVLD_First.Users;
using DVLD_First.Applications;
using DVLD_First.Licecses;
using DVLD_First.Drivers;
using DVLD_Business;
using DVLD_First.Global_Classes;
using System.IO;

namespace DVLD_First
{
    public partial class MainForm : Form
    {
        int _UserID= 1 ;
        bool _RememberMeLoginScreen = false;
        bool _CloseLoginScreen = true;
        public clsUser _CurrentUser;
        frmLogin _frmLogin;
        public MainForm( frmLogin frm = null)
        {
            InitializeComponent();
            _UserID = clsGlobal.CurrentUser.UserID;
            _CurrentUser = clsGlobal.CurrentUser;
           // _RememberMeLoginScreen = RememberMeLoginScreen;
            _frmLogin = frm;
           // File.Create("LoginUserID");
          //  File.WriteAllText("LoginUserID", UserID.ToString());

        }

        public delegate void DataBackEventHandler();
        public event DataBackEventHandler RememberMe;
        public event DataBackEventHandler CloseLoginScreen;

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmManagePeople ManagmentScreen = new frmManagePeople();
            ManagmentScreen.MdiParent = this;
            ManagmentScreen.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmManageUsers UsersScreen = new frmManageUsers();
            UsersScreen.MdiParent = this;
            UsersScreen.Show();
        }

        private void currentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmShowUserDetails UserInfo = new frmShowUserDetails(clsGlobal.CurrentUser.UserID);
            UserInfo.MdiParent = this;
            UserInfo.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword ChangePassword = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            ChangePassword.MdiParent = this;
            ChangePassword.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CloseLoginScreen = false;
            if (_RememberMeLoginScreen != true)
                //RememberMe.Invoke();

             clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
            //frmLogin LoginScreen = new frmLogin();
            //LoginScreen.Show();
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_CloseLoginScreen)
            CloseLoginScreen.Invoke();

           
        }

        private void manageApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestTypes ManageTestScreen = new frmManageTestTypes();
            ManageTestScreen.MdiParent = this;
            ManageTestScreen.Show();
        }

        private void manageTestTypesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmManageTestTypes ManageTestScreen = new frmManageTestTypes();
            ManageTestScreen.MdiParent = this;
            ManageTestScreen.Show();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes ApplicationTypesScreen = new frmManageApplicationTypes();
            ApplicationTypesScreen.MdiParent = this;
            ApplicationTypesScreen.Show();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewApplication AddLicense = new frmAddNewApplication(_CurrentUser);
            AddLicense.MdiParent = this;
            AddLicense.Show();

        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmManageApplications ApplicationsScreen = new frmManageApplications(_CurrentUser);
            ApplicationsScreen.MdiParent = this;
            ApplicationsScreen.Show();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDrivers DriversScreen = new frmManageDrivers();
            DriversScreen.MdiParent = this;
            DriversScreen.Show();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicenseApplication NewInternationalLicenseApplication = new frmNewInternationalLicenseApplication(_CurrentUser);
            NewInternationalLicenseApplication.MdiParent = this;
            NewInternationalLicenseApplication.Show();
        }

        private void internationalDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListInternationalLicenseApplications InternationalLicenseApplications = new frmListInternationalLicenseApplications();
            InternationalLicenseApplications.MdiParent = this;
            InternationalLicenseApplications.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void renewDrivingLicecseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLocalDrivingLicense RenewLocalLicense = new frmRenewLocalDrivingLicense();
            RenewLocalLicense.MdiParent = this;
            RenewLocalLicense.Show();
        }

        private void replaceDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplacementLicense ReplacementLicense = new frmReplacementLicense();
            ReplacementLicense.MdiParent = this;
            ReplacementLicense.Show();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicense DetainLicense = new frmDetainLicense(-1);
            DetainLicense.MdiParent = this;
            DetainLicense.Show();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseLicense ReleaseLicense = new frmReleaseLicense(-1);
            ReleaseLicense.MdiParent = this;
            ReleaseLicense.Show();

        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagmentListDetainedLicenses ManagementDetainedLicenses = new frmManagmentListDetainedLicenses();
            ManagementDetainedLicenses.MdiParent = this;
            ManagementDetainedLicenses.Show();
        }

        private void detainLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

       
    }
}
