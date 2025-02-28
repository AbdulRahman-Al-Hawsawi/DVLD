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
    public partial class frmManageTestTypes : Form
    {
        
        
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadTestTypes()
        {
            dgvTestTypesTable.DataSource = clsTestType.GetAllTestTayes();
            lblRecordCount.Text = "# Record " + dgvTestTypesTable.RowCount;
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            LoadTestTypes();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTestTypes UpdateTestType = new frmEditTestTypes(Convert.ToInt32(dgvTestTypesTable.SelectedRows[0].Cells[0].Value));
            UpdateTestType.MdiParent = this.MdiParent;
            UpdateTestType.RefreshTable += LoadTestTypes;
            UpdateTestType.Show();
        }

    }
}
