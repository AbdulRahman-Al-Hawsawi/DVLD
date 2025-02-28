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
    public partial class frmNewInternationalLicenseApplication : Form
    {
        public frmNewInternationalLicenseApplication(clsUser CurrentUser)
        {
            InitializeComponent();
            _CurrentUser = CurrentUser;
        }

       public clsUser _CurrentUser;

       private void ctrNewInternationalLicenseApplication1_Load(object sender, EventArgs e)
       {
           ctrNewInternationalLicenseApplication1.FillInfo(_CurrentUser);
       }
    }
}
