using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DVLD_Business;

namespace DVLD_First.Applications
{
    public partial class frmManageApplicationTypes : Form
    {
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadApplicationTypes()
        {
            dgvApplicationTypesTable.DataSource = clsApplicationType.GetAllApplicationTypes();
            lblRecordCount.Text = "# Record " + dgvApplicationTypesTable.RowCount;
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            LoadApplicationTypes();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditApplicationType UpdateApplicationType = new frmEditApplicationType(Convert.ToInt32(dgvApplicationTypesTable.SelectedRows[0].Cells[0].Value));
            UpdateApplicationType.MdiParent = this.MdiParent;
            UpdateApplicationType.RefreshTable += LoadApplicationTypes;
            UpdateApplicationType.Show();
        }
    }
}
