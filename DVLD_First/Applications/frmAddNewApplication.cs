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
    public partial class frmAddNewApplication : Form
    {
        clsUser _CurrentUser;
        public frmAddNewApplication(clsUser CurrentUser)
        {
            InitializeComponent();
            _CurrentUser = CurrentUser;
        }

        private void frmAddNewLicense_Load(object sender, EventArgs e)
        {
            ctrAddNewLicense1.LoadApplicationInfo(_CurrentUser.UserName);
        }

        private void ctrAddNewLicense1_Load(object sender, EventArgs e)
        {

        }

    }
}
