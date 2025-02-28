using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using DVLD_Business;

namespace DVLD_First.People
{
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
        }

       

        //private static DataTable _dtAllPeople = clsPerson.GetAllPeople();

        //DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
        //                                               "FirstName", "SecondName", "ThirdName", "LastName",
        //                                               "Gender", "DateOfBirth", "CountryName",
        //                                               "Phone", "Email");

        //void RefreshPeopleList()
        //{
        // DataTable _dtAllPeople = clsPerson.GetAllPeople();

        // DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
        //                                               "FirstName", "SecondName", "ThirdName", "LastName",
        //                                               "Gender", "DateOfBirth", "CountryName",
        //                                               "Phone", "Email");

        //dgvPeopleTable.DataSource = _dtPeople;
        //lblRecordCount.Text = dgvPeopleTable.RowCount.ToString();

        //}

        DataTable PeopleInSystem;
        int SelectedRowPersonID;

        void RefreshTable()
        {
            PeopleInSystem = clsPerson.GetAllPeople();
            dgvPeopleTable.DataSource = PeopleInSystem;
            GetCountOfRecords();
        }

        void RefreshTable2(int personID)
        {
            PeopleInSystem = clsPerson.GetAllPeople();
            dgvPeopleTable.DataSource = PeopleInSystem;
            GetCountOfRecords();
        }

        void DeleteImageFromFolder(string ImagePath)
        {
            if(!string.IsNullOrWhiteSpace(ImagePath))
            File.Delete(ImagePath);
        }

        //void FiltringByID()
        //{
        //    string rowFilter = string.Format("convert([{0}],'System.String') like '{1}%'", "ClassName", Convert.ToInt32(tbSearchedText.Text));
        //    (dgvPeopleTable.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        // }

        //void FiltringByFirstName()
        //{
        //        string rowFilter = string.Format("[{0}] like '{1}%'", "FirstName", tbSearchedText.Text);
        //        (dgvPeopleTable.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        //}

        //void FiltringBySecondName()
        //{
        //    string rowFilter = string.Format("[{0}] like '{1}%'", "SecondName", tbSearchedText.Text);
        //    (dgvPeopleTable.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        //}

        //void FiltringByThirdName()
        //{
        //    string rowFilter = string.Format("[{0}] like '{1}%'", "ThirdName", tbSearchedText.Text);
        //    (dgvPeopleTable.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        //}

        //void FiltringByLastName()
        //{
        //    string rowFilter = string.Format("[{0}] like '{1}%'", "LastName", tbSearchedText.Text);
        //    (dgvPeopleTable.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        //}

        //void FiltringByNationalNo()
        //{
        //    string rowFilter = string.Format("[{0}] like '{1}%'", "NationalNo", tbSearchedText.Text);
        //    (dgvPeopleTable.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        //}

        //void FiltringByGender()
        //{
        //    string rowFilter = string.Format("[{0}] like '{1}%'", "Gender", tbSearchedText.Text);
        //    (dgvPeopleTable.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        //}

        //void FiltringByEmail()
        //{
        //    string rowFilter = string.Format("[{0}] like '{1}%'", "Email", tbSearchedText.Text);
        //    (dgvPeopleTable.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        //}

        //void FiltringByDateOfBirth()
        //{
        //    string rowFilter = string.Format("convert([{0}],'System.String') like '{1}%' ", "DateOfBirth", tbSearchedText.Text);
        //    (dgvPeopleTable.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        //}

        //void FiltringByPhone()
        //{
        //    string rowFilter = string.Format("[{0}] like '{1}%'", "Phone", tbSearchedText.Text);
        //    (dgvPeopleTable.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        //}

        //void FiltringByAddress()
        //{
        //    string rowFilter = string.Format("[{0}] like '{1}%'", "Address", tbSearchedText.Text);
        //    (dgvPeopleTable.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        //}

        //void FiltringByNationality()
        //{
        //    string rowFilter = string.Format("[{0}] like '{1}%'", "Nationality", tbSearchedText.Text);
        //    (dgvPeopleTable.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        //}


        //void Filtring()
        //{
        //    if (cbFiltering.SelectedText == "None" || string.IsNullOrWhiteSpace(tbSearchedText.Text))
        //        return;

        //    switch (cbFiltering.SelectedItem.ToString())
        //    {
        //        case " Person ID":
        //            FiltringByID();
        //            break;
        //        case "First Name":
        //            FiltringByFirstName();
        //            break;
        //        case "Second Name":
        //            FiltringBySecondName();
        //            break;
        //        case "Third Name":
        //            FiltringByThirdName();
        //            break;
        //        case "Last Name":
        //            FiltringByLastName();
        //            break;
        //        case "NationalNo":
        //            FiltringByNationalNo();
        //            break;
        //        case "Gender":
        //            FiltringByGender();
        //            break;
        //        case "Email":
        //            FiltringByEmail();
        //            break;
        //        case "Date Of Birth":
        //            FiltringByDateOfBirth();
        //            break;
        //        case "Phone":
        //            FiltringByPhone();
        //            break;
        //        case "Address":
        //            FiltringByAddress();
        //            break;
        //        case "Nationality":
        //            FiltringByNationality();
        //            break;
              
        //    }
        //}

        void GetCountOfRecords()
        {
            lblRecordCount.Text = "# Records: " + (dgvPeopleTable.RowCount );
        }

        void LoadDataToTable()
        {
            DataTable dt = new DataTable();
            foreach (DataRow row in clsPerson.GetAllPeople().Rows)
            {
                
               
            } 
            dgvPeopleTable.DataSource = dt;
        }

        public static string GenerateGUID()
        {

            // Generate a new GUID
            Guid newGuid = Guid.NewGuid();

            // convert the GUID to a string
            return newGuid.ToString();

        }



        private void frmManagePeople_Load(object sender, EventArgs e)
        {
           
           
            dgvPeopleTable.DataSource = clsPerson.GetAllPeople();
            GetCountOfRecords();
            cbFiltering.SelectedIndex = 0;
            
            if (dgvPeopleTable.RowCount > 0)
            {

                dgvPeopleTable.Columns[0].HeaderText = "Person ID";
                dgvPeopleTable.Columns[1].HeaderText = "National No.";
                dgvPeopleTable.Columns[2].HeaderText = "First Name";
                dgvPeopleTable.Columns[3].HeaderText = "Second Name";
                dgvPeopleTable.Columns[4].HeaderText = "Third Name";
                dgvPeopleTable.Columns[5].HeaderText = "Last Name";
                dgvPeopleTable.Columns[6].HeaderText = "Date Of Birth";
               
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            frmAddAndUpdatePerson AddScreen = new frmAddAndUpdatePerson(-1);
            AddScreen.MdiParent = this.MdiParent;
            AddScreen.Refresh += RefreshTable;
            AddScreen.Show();
        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddAndUpdatePerson AddScreen = new frmAddAndUpdatePerson(-1);
            AddScreen.MdiParent = this.MdiParent;
            AddScreen.Refresh += RefreshTable;
            AddScreen.Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmShowPersonDetails ShowPersonDetails = new People.frmShowPersonDetails(SelectedRowPersonID);
            ShowPersonDetails.MdiParent = this.MdiParent;
            ShowPersonDetails.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdatePerson UpdatePerson = new frmUpdatePerson(SelectedRowPersonID);
            UpdatePerson.MdiParent = this.MdiParent;
            UpdatePerson.DataBack += RefreshTable2;
            UpdatePerson.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this person ", "Confirm Delete Person", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (clsPerson.DeletePerson(SelectedRowPersonID))
                {
                    DeleteImageFromFolder(dgvPeopleTable.SelectedRows[0].Cells["ImagePath"].Value.ToString());
                    RefreshTable();
                    MessageBox.Show("Delete Person Successfully", "Delete Person", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("You can't delete this Person because he has relationship in the system", "Delete Person", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Option is not available now ");
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Option is not available now ");
        }

        private void tbSearchedText_TextChanged(object sender, EventArgs e)
        {
            string FilterColum = "";
            switch (cbFiltering.SelectedItem.ToString())
            {
                case "Person ID":
                    FilterColum = "PersonID";
                    break;
                case "First Name":
                    FilterColum = "FirstName";
                    break;
                case "Second Name":
                    FilterColum = "SecondName";
                    break;
                case "Third Name":
                    FilterColum = "ThirdName";
                    break;
                case "Last Name":
                    FilterColum = "LastName";
                    break;
                case "NationalNo":
                    FilterColum = "NationalNo";
                    break;
                case "Gender":
                    FilterColum = "Gender";
                    break;
                case "Email":
                    FilterColum = "Email";
                    break;
                case "Date Of Birth":
                    FilterColum = "DateOfBirth";
                    break;
                case "Phone":
                    FilterColum = "Phone";
                    break;
                case "Address":
                    FilterColum = "Address";
                    break;
                case "Nationality":
                    FilterColum = "Nationality";
                    break;
                default:
                    FilterColum = "None";
                    break;

            }

            if (tbSearchedText.Text == "" || FilterColum == "None")
            {
               (dgvPeopleTable.DataSource as DataTable).DefaultView.RowFilter = "";
               return;
            }

           
            if (FilterColum == "PersonID")
                (dgvPeopleTable.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColum, tbSearchedText.Text);
            else
                (dgvPeopleTable.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColum, tbSearchedText.Text);

            //Filtring();
        }

        private void cbFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {

            tbSearchedText.Visible = (cbFiltering.Text != "None");

            if (tbSearchedText.Visible)
            {
                tbSearchedText.Text = "";
                tbSearchedText.Focus();
            }


            //if (cbFiltering.SelectedIndex == 0)
            //{
            //    dgvPeopleTable.DataSource = clsPerson.GetAllPeople();
            //    tbSearchedText.Clear();
            //    tbSearchedText.Visible = false;
            //    return;
            //}
            //tbSearchedText.Visible = true;
            //tbSearchedText.Focus();
        }

        private void dgvPeopleTable_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            GetCountOfRecords();
        }

        private void tbSearchedText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if he search by date of birth
            if (cbFiltering.SelectedIndex == 12)
            {
                e.Handled = char.IsLetter(e.KeyChar);
                return;
            }
            // Id or phone or NationalNo
            if (cbFiltering.SelectedIndex == 1 || cbFiltering.SelectedIndex == 2 || cbFiltering.SelectedIndex == 10)
            {
                e.Handled = char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar);
                return;
            }

           if (cbFiltering.SelectedIndex != 9 && cbFiltering.SelectedIndex != 11)
            {
                e.Handled = char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar);
                return;
            }

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPeopleTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = (int) dgvPeopleTable.CurrentRow.Cells[0].Value;
            frmShowPersonDetails ShowPersonDetails = new People.frmShowPersonDetails(ID);
            ShowPersonDetails.ShowDialog();
        }

        private void cmsPeople_Opening(object sender, CancelEventArgs e)
        {
           SelectedRowPersonID = (int)dgvPeopleTable.CurrentRow.Cells[0].Value; 
        }

       

        
        


       
      
    }
}
