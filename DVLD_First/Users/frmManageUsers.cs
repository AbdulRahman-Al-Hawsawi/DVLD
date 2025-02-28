using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DVLD_Business;
using DVLD_First.Users;

namespace DVLD_First.Users
{
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }

        void LoadUsers()
        {
            dgvUsersTable.DataSource = clsUser.GetAllUsers();
            lblRecordCount.Text = "# Records: " + dgvUsersTable.RowCount.ToString();
        }

        void FiltringByUsername()
        {
            string rowFilter = string.Format("[{0}] like '{1}%'", "Username", tbSearchedText.Text);
            (dgvUsersTable.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringActiveUsers()
        {
            string rowFilter = string.Format("[{0}] = {1}", "isActive", 1);
            (dgvUsersTable.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringUnActiveUsers()
        {
            string rowFilter = string.Format("[{0}] = {1}", "isActive", 0);
            (dgvUsersTable.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringByTheActivity()
        {
              switch (cbTypeOfStatus.SelectedItem.ToString())
            {
                case "All":
                    dgvUsersTable.DataSource = clsUser.GetAllUsers();
                    break;
                case "Yes":
                    FiltringActiveUsers();
                    break;
                case "No":
                    FiltringUnActiveUsers();
                    break;
              }
                
        }

        void FiltringByUserID()
        {
            string rowFilter = string.Format("convert([{0}],'System.String') like '{1}%'", "LicenseClassID", Convert.ToInt32(tbSearchedText.Text));
            (dgvUsersTable.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void FiltringByPersonID()
        {
            string rowFilter = string.Format("convert([{0}],'System.String') like '{1}%'", "ClassName", Convert.ToInt32(tbSearchedText.Text));
            (dgvUsersTable.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        void Filtring()
        {
            if (cbFiltering.SelectedText == "None" || string.IsNullOrWhiteSpace(tbSearchedText.Text))
                return;

            switch (cbFiltering.SelectedItem.ToString())
            {
                case "User ID":
                    FiltringByUserID();
                    break;
                case "Person ID":
                    FiltringByPersonID();
                    break;
                case "Username":
                    FiltringByUsername();
                    break;
            }
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser AddNewUser = new frmAddEditUser(-1);
            AddNewUser.MdiParent = this.MdiParent;
            AddNewUser.RefreshTable += LoadUsers;
            AddNewUser.Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserDetails UserDetails = new frmShowUserDetails(Convert.ToInt32(dgvUsersTable.SelectedRows[0].Cells[0].Value));
            UserDetails.MdiParent = this.MdiParent;
            UserDetails.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword ChangePassword = new frmChangePassword(Convert.ToInt32(dgvUsersTable.SelectedRows[0].Cells[0].Value));
            ChangePassword.MdiParent = this.MdiParent;
            ChangePassword.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsUser.DeleteUser(Convert.ToInt32(dgvUsersTable.SelectedRows[0].Cells[0].Value)))
            {
                LoadUsers();
                MessageBox.Show("Delete User Successfully");
            }
           
        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser AddNewUser = new frmAddEditUser(-1);
            AddNewUser.MdiParent = this.MdiParent;
            AddNewUser.RefreshTable += LoadUsers;
            AddNewUser.Show();
           
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser UpdateUser = new frmAddEditUser(Convert.ToInt32(dgvUsersTable.SelectedRows[0].Cells[0].Value));
            UpdateUser.MdiParent = this.MdiParent;
            UpdateUser.RefreshTable += LoadUsers;
            UpdateUser.Show();
        }

        private void cbFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltering.SelectedIndex == 0)
            {
                dgvUsersTable.DataSource = clsUser.GetAllUsers();
                tbSearchedText.Visible = false;
                tbSearchedText.Clear();
                cbTypeOfStatus.Visible = false;
                cbTypeOfStatus.SelectedIndex = 0;
                return;
            }

            if (cbFiltering.SelectedItem.ToString() == "is Active")
            {
                cbTypeOfStatus.Visible = true;
                tbSearchedText.Visible = false;
                return;
            }
            tbSearchedText.Visible = true;
            tbSearchedText.Focus();
            cbTypeOfStatus.Visible = false;
        }

        private void cbTypeOfStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltringByTheActivity();
        }

        private void tbSearchedText_TextChanged(object sender, EventArgs e)
        {
            Filtring();
        }

       
    }
}
