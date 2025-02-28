using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DVLD_Business;
using DVLD_First.Global_Classes;
using System.IO;
using System.Diagnostics;


namespace DVLD_First
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        clsUser CurrentUser;

        void LoadLoginInfo()
        {
            string Username = "", Password = "";

            if (clsGlobal.GetStoredCredintial(ref Username, ref Password))
            {
                tbUsername.Text = Username;
                tbPassword.Text = Password;
                chkRemeberMe.Checked = true;
            }
            else
                chkRemeberMe.Checked = false;

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //ClearLoginInfo();
        }

        bool isRightLoginInfo()
        {
             CurrentUser = clsUser.Find(tbUsername.Text);

            if(CurrentUser != null && CurrentUser.isActive == true)
            {
                if (tbPassword.Text != CurrentUser.Password || string.IsNullOrWhiteSpace(tbUsername.Text))
                {
                    errorProvider1.SetError(tbUsername, "Invalid value");
                    errorProvider1.SetError(tbPassword, "Wrong Password");
                }
                else
                   return true;
            
            }
            else
                errorProvider1.SetError(tbUsername, "This user in not in the system or is not Active");

            return false;
        }

        void ClearLoginInfo()
        {
            tbUsername.Clear();
            tbPassword.Clear();
            chkRemeberMe.Checked = false;
            tbUsername.Focus();
        }

        void CloseLoginScreen()
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser User = clsUser.FindByUsernameAndPassword(tbUsername.Text.Trim(),clsValidation.ComputeHase(tbPassword.Text.Trim()));

            if (User != null)
            {

                if (chkRemeberMe.Checked)
                {
                    //store username and password
                    clsGlobal.RememberUsernameAndPassword(tbUsername.Text.Trim(), tbPassword.Text.Trim());
                }
                else
                {
                    //store empty username and password
                    clsGlobal.RememberUsernameAndPassword("", "");
                }

                if (!User.isActive)
                {
                    tbUsername.Focus();
                    errorProvider1.SetError(tbUsername, "Your account is not Active");
                    MessageBox.Show("Your account is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    clsGlobal.CurrentUser = User;
                    clsGlobal.SaveToEventLog("User Login to System User ID:" + User.UserID + " Username: " + User.UserName, EventLogEntryType.Information);
                    MainForm MainScreen = new MainForm(this);
                    this.Hide();
                    MainScreen.Show();
                    ClearLoginInfo();
                }



            }
            else
            {
                tbUsername.Focus();
                errorProvider1.SetError(tbUsername, " ");
                errorProvider1.SetError(tbPassword, " ");
                MessageBox.Show("Invalid Username/Password.", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            clsGlobal.RememberUsernameAndPassword("", "");
            this.Close();
        }

        private void btnLogin_VisibleChanged(object sender, EventArgs e)
        {
            LoadLoginInfo();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void btnPasswordVisible_CheckedChanged(object sender, EventArgs e)
        {
            //if (tbPassword.PasswordChar.ToString() == "")
            //    tbPassword.PasswordChar = '*';
            //else
            //    tbPassword.PasswordChar =;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
          //  clsGlobal.RememberUsernameAndPassword("", "");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
          //  clsGlobal.RememberUsernameAndPassword("", "");

        }
    }
}
