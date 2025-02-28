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
    public partial class frmDetainLicense : Form
    {
        public frmDetainLicense(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }
        int _LicenseID = -1;
        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            if(_LicenseID != -1)
            ctrDetainLicense1.FillInfo(_LicenseID, true);
        }
    }
}
