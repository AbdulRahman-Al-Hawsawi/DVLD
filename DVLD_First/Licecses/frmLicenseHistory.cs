using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DVLD_Business;


namespace DVLD_First.Licecses
{
    public partial class frmLicenseHistory : Form
    {
        public frmLicenseHistory(int DriverID)
        {
            InitializeComponent();
           _DriverID =  DriverID;
        }
        int _DriverID;

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
           ctrPersonDetails21.FillPersonInfo(clsDriver.Find(_DriverID).PersonID);
           ctrDriverLicenses1.FillInfo(_DriverID);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrDriverLicenses1_Load(object sender, EventArgs e)
        {

        }
    }
}
