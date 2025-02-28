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
    public partial class frmReleaseLicense : Form
    {
        public frmReleaseLicense(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }
        int _LicenseID =-1;

        private void frmReleaseLicense_Load(object sender, EventArgs e)
        {
            if(_LicenseID != -1)
            ctrReleaseDetainedLicense1.FillInfo(_LicenseID,true);
        }
    }
}
