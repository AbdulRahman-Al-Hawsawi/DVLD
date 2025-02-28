using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DVLD_Business;
using DVLD_First.Global_Classes;


namespace DVLD_First.Controls
{
    public partial class ctrChangePassword : UserControl
    {
        public ctrChangePassword()
        {
            InitializeComponent();
        }
        int _UserID = -1;
        public void FillUserInfo(int UserID)
        {
            _UserID = UserID;
            ctrUserDetails1.FillUserInfo(UserID);

        }

        public void Save()
        {
           
            clsUser User = clsUser.Find(_UserID);

            if (clsValidation.ComputeHase(tbCurrentPassword.Text.Trim()) == User.Password)
            {
                if (tbNewPassword.Text != tbConfirmPassword.Text)
                {
                    errorProvider1.SetError(tbConfirmPassword, "The Password is not Match");
                    return;
                }

            }
            else
            {
                errorProvider1.SetError(tbCurrentPassword, "Wrong Password");
                return;
            }

            User.Password =clsValidation.ComputeHase(tbNewPassword.Text.Trim());

            if (User.Save())
            {
                MessageBox.Show("Change Password Successfully");
            }


        }
    }
}
