using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DVLD_First.Licecses
{
    public partial class frmShowInternationalDrivingLicense : Form
    {
        public frmShowInternationalDrivingLicense(int DriverID)
        {
            InitializeComponent();
            _DriverID = DriverID;
        }
        int _DriverID;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowInternationalDrivingLicense_Load(object sender, EventArgs e)
        {
            ctrShowInternationalLicensecs1.FillInfo(_DriverID);
        }
    }
}
