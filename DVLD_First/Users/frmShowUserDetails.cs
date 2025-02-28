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
    public partial class frmShowUserDetails : Form
    {
        int _UserID =-1;
        public frmShowUserDetails(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

       

        private void frmShowUserDetails_Load(object sender, EventArgs e)
        {
            ctrUserDetails1.FillUserInfo(_UserID);
        }
    }
}
