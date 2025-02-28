using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;





namespace DVLD_First.Applications
{
    
    public partial class frmScheduleTest : Form
    {
        public frmScheduleTest( int LocalDrivingLicenseApplication, string Title,int AppointmentID = 0)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplication = LocalDrivingLicenseApplication;
             _AppointmentID = AppointmentID;
            _Title = Title;

        } 
        
        int _LocalDrivingLicenseApplication =-1;
        string _Title = "";
        int _AppointmentID = 0;

        public delegate void DataBackEventHandler();
        public event DataBackEventHandler RefreshTable;

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            ctrScheduleTest1.FillInfo(_LocalDrivingLicenseApplication, _Title);
            if (_AppointmentID != 0)
                ctrScheduleTest1.FillAppointmentInfoToUpdate(_AppointmentID);
        }

        private void frmScheduleTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshTable.Invoke();
        }

        private void ctrScheduleTest1_Load(object sender, EventArgs e)
        {

        }
    }
}
