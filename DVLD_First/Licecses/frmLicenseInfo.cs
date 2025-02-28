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
    public partial class frmLicenseInfo : Form
    {
        public frmLicenseInfo(int LocalLicenseID)
        {
            InitializeComponent();
            _LicenseID = LocalLicenseID;
        }
        int _LicenseID = -1;

        private void frmLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrDriverLicenseInfo1.FillInfo(_LicenseID);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
