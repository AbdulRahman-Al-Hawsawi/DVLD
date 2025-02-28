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
    public partial class frmTakeTest : Form
    {
      
        public frmTakeTest(int LocalDrivingLicenseApplication, string Title,int AppointmentID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplication = LocalDrivingLicenseApplication;
            _Title = Title;
            _AppointmentID = AppointmentID;
        }
        
        int _LocalDrivingLicenseApplication;
        int _AppointmentID;
        string _Title;

        public delegate void DataBackEventHandler();
        public event DataBackEventHandler RefreshTable;


        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctrTakeTest1.FillInfo(_LocalDrivingLicenseApplication,_AppointmentID,_Title);
        }

        private void frmTakeTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshTable.Invoke();
        }
    }
}
