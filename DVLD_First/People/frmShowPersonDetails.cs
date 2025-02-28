using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DVLD_First.People
{
    public partial class frmShowPersonDetails : Form
    {
        int _PersonID = -1;
        public frmShowPersonDetails(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void ShowPersonDetails_Load(object sender, EventArgs e)
        {
            ctrPersonDetails21.FillPersonInfo(_PersonID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
