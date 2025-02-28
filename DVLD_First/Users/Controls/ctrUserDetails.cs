using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DVLD_Business;

namespace DVLD_First.Controls
{
    public partial class ctrUserDetails : UserControl
    {
        public ctrUserDetails()
        {
            InitializeComponent();
        }

        public void FillUserInfo(int UserID)
        {
            clsUser User = clsUser.Find(UserID);
            lblUserID.Text = User.UserID.ToString();
            lblUsername.Text = User.UserName;
            lblisActive.Text = (User.isActive ? "Yes" : "NO");

            ctrPersonDetails21.FillPersonInfo(User.PersonID);
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
