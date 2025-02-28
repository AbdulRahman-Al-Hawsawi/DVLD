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
    public partial class ctrAddUpdateUser : UserControl
    {
        public ctrAddUpdateUser()
        {
            InitializeComponent();
        }

        enum enMode { Add, Update };
        enMode _Mode;
      //  int _UserID = -1;
        clsUser _User;

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (clsUser.isPersonExistInUsers(ctrPersonDetails21.PersonID()))
            {
                errorProvider1.SetError(tbSearchedText, "This Person is Already a User");
                //MessageBox.Show("This Person is Already a User");
                return;
            }
            tabAddNewUser.SelectedIndex = 1;
        }

        public void LoadUserInfo(int UserID)
        {
            if (UserID == -1)
            {
                _Mode = enMode.Add;
                _User = new clsUser();
                lblTitle.Text = "Add New User";

                return;

            }

            _Mode = enMode.Update;
             _User = clsUser.Find(UserID);
             lblTitle.Text = "Edit User";
             gbSearchAdd.Enabled = false;
            ctrPersonDetails21.FillPersonInfo(_User.PersonID);

            lblUserID.Text = _User.UserID.ToString();
            tbUserName.Text = _User.UserName;
            tbPassword.Text = _User.Password;
            tbConfirmPassword.Text = _User.Password;
            chIsActive.Checked = _User.isActive;
            
        }

        bool InvalidInputs()
        {
            if (string.IsNullOrWhiteSpace(tbUserName.Text))
                return true ;
            if (tbPassword.Text != tbConfirmPassword.Text)
                return true;

            return false;
        }

        void Save()
        {
            if (InvalidInputs())
                return;

            _User.PersonID = ctrPersonDetails21.PersonID();
            _User.UserName = tbUserName.Text;
            _User.Password =clsValidation.ComputeHase(tbPassword.Text.Trim());
            _User.isActive = chIsActive.Checked;

            if (_User.Save())
            {
                if (_Mode == enMode.Add)
                {
                    lblUserID.Text = _User.UserID.ToString();
                    MessageBox.Show("Add User Successfully");
                    lblTitle.Text = "Edit User";
                    return;
                }
                MessageBox.Show("Update User Successfully");
            }
            else
                MessageBox.Show("There is Wrong in Add or Update User");

        }

        
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            People.frmAddAndUpdatePerson AddNewPerson = new People.frmAddAndUpdatePerson(-1);
            AddNewPerson.MdiParent = this.ParentForm.MdiParent;
            AddNewPerson.ReturnPersonID += LoadUserInfo;
            AddNewPerson.Show();
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clsPerson person = clsPerson.Find(tbSearchedText.Text);

            if (person != null)
                ctrPersonDetails21.FillPersonInfo(person.ID);
            else
                errorProvider1.SetError(tbSearchedText, "There is no Person With The Same National No.");
               // MessageBox.Show("There is no Person With The Same National No."); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void tbSearchedText_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbConfirmPassword.Text != tbPassword.Text)
                errorProvider1.SetError(tbConfirmPassword, "Password Confimation does not match Password!");
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (clsUser.isUserExist(tbUserName.Text))
            {
                errorProvider1.SetError(tbUserName, "This Username is Used by Another Person");
                e.Cancel = true;
                tbUserName.Focus();

            }
        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbConfirmPassword.Text != tbPassword.Text)
                errorProvider1.SetError(tbConfirmPassword, "Password Confimation does not match Password!");
        
        }

        private void btnGenerateUserName_Click(object sender, EventArgs e)
        {
           // tbUserName.Text = "Aotu";
        }

       
    }
}
