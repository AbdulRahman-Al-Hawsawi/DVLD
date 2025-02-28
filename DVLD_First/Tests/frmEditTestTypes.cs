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
    public partial class frmEditTestTypes : Form
    {
        int _TestID = -1;
        clsTestType _Test;

        public frmEditTestTypes(int TestID)
        {
            InitializeComponent();
            _TestID = TestID;
        }

        public delegate void DataBackEventHandler();
        public event DataBackEventHandler RefreshTable;

        void LoadTest()
        {
            _Test = clsTestType.Find(_TestID);

            lblID.Text = _Test.TestID.ToString();
            tbTitle.Text = _Test.Title;
            tbDescription.Text = _Test.Descreption;
            tbFees.Text = _Test.Fees.ToString();
        }

        void Save()
        {
            _Test.Title = tbTitle.Text;
            _Test.Descreption = tbDescription.Text;
            _Test.Fees = Convert.ToDouble(tbFees.Text);

            if (_Test.save())
            {
                MessageBox.Show("Update Test Successfully");
                RefreshTable.Invoke();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            LoadTest();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void tbFees_KeyPress_1(object sender, KeyPressEventArgs e)
        {
           e.Handled = !char.IsDigit(e.KeyChar);
        }

       
    }
}
