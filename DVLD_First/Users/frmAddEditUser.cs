using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DVLD_Business;

namespace DVLD_First.Users
{
    public partial class frmAddEditUser : Form
    {
        int _UserID = -1;
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        public delegate void DataBackEventHandler();
        public event DataBackEventHandler RefreshTable;

        private void ctrAddUser1_Load(object sender, EventArgs e)
        {

        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            ctrAddUpdateUser1.LoadUserInfo(_UserID);
        }

        private void frmAddEditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshTable.Invoke();
        }

        private void ctrAddUpdateUser1_Load(object sender, EventArgs e)
        {

        }
    }
}
