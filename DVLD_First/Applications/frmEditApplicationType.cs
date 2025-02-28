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
    public partial class frmEditApplicationType : Form
    {
        int _ApplicationTypeID = -1;
        clsApplicationType _ApplicationType;

        public frmEditApplicationType(int ApplicationID)
        {
            InitializeComponent();
            _ApplicationTypeID = ApplicationID;
        }

        public delegate void DataBackEventHandler();
        public event DataBackEventHandler RefreshTable;

        void LoadApplication()
        {
            _ApplicationType = clsApplicationType.Find(_ApplicationTypeID);

            lblID.Text = _ApplicationType.ApplicationTypeID.ToString();
            tbTitle.Text = _ApplicationType.Title;
            tbFees.Text = _ApplicationType.Fees.ToString();
        }

        void Save()
        {
            _ApplicationType.Title = tbTitle.Text;
            _ApplicationType.Fees = Convert.ToDouble(tbFees.Text);

            if (_ApplicationType.save())
            {
                MessageBox.Show("Update Application Successfully");
                RefreshTable.Invoke();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            LoadApplication();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFees_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = !char.IsDigit(e.KeyChar);
        }
    }
}
