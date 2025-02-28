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
    public partial class frmReplacementLicense : Form
    {
        public frmReplacementLicense()
        {
            InitializeComponent();
            ctrReplaceLicense1.ReplacementTitle += SetTitle;
        }

        public void SetTitle(string Title)
        {
            this.Text = Title;
        }

        private void frmReplacementLicense_Load(object sender, EventArgs e)
        {
            ctrReplaceLicense1.tbLicenseIDFocus();
        }

        private void frmReplacementLicense_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                ctrReplaceLicense1.btnSearchLicenseClick();
        }

        private void ctrReplaceLicense1_Load(object sender, EventArgs e)
        {
            ctrReplaceLicense1.tbLicenseIDFocus();
        }
    }
}
