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
    public partial class ctrAddNewApplication : UserControl
    {
        public ctrAddNewApplication()
        {
            InitializeComponent();
        }

        string _Username ="";
        public void LoadAllClasses()
        {
           
            foreach (DataRow row in clsLicenseClass.GetAllLicenseClasses().Rows)
            {
                cbLicenseClasses.Items.Add(row["ClassName"].ToString());
            }
            cbLicenseClasses.SelectedIndex = 1;
     
        }

        bool isHaveComplatedApplicationInThisClass()
        {
           clsDriver _Driver = clsDriver.Find(ctrPersonDetails21.PersonID(),true);
            if(_Driver != null)
            {
                return clsLicense.isLicenseExist(_Driver.DriverID, clsLicenseClass.Find(cbLicenseClasses.SelectedItem.ToString()).LicenseClassID);
            }
            return false;
        }

        bool isHaveActiveApplicationInThisClass()
        {
           return clsLocalDrivingLicenseApplication.isHaveComplatedOrNewApplicationInTheSelectedLicenseClass(ctrPersonDetails21.PersonID(),
               clsLicenseClass.Find(cbLicenseClasses.SelectedItem.ToString()).LicenseClassID);
        }

        private void ctrAddNewLicense_Load(object sender, EventArgs e)
        {
            LoadAllClasses();
            
        }


      public  void LoadApplicationInfo(string Username)
        {
            _Username = Username;
            lblUsername.Text = Username;
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblApplicationFees.Text = "15";
        }


        void Save()
        {

           
            clsApplication NewApplication = new clsApplication();
            NewApplication.ApplicationDate = DateTime.Now;
            NewApplication.ApplicantPersonID = ctrPersonDetails21.PersonID();
            NewApplication.CreatedByUserID = clsUser.Find(_Username).UserID;
            NewApplication.LastStatusDate = DateTime.Now;
            NewApplication.PaidFees = 15;
            NewApplication.ApplicationTypeID = 1;
            NewApplication.ApplicationStatusID = 1;
           
            

            if (NewApplication.Save())
            {
                
                
                 clsLocalDrivingLicenseApplication NewLocalDrivingApplication = new clsLocalDrivingLicenseApplication();
                 NewLocalDrivingApplication.ApplicationID = NewApplication.ApplicationID;
                 NewLocalDrivingApplication.LicenseClassID = clsLicenseClass.Find(cbLicenseClasses.SelectedItem.ToString()).LicenseClassID;
                 if (NewLocalDrivingApplication.Save())
                 {
                    MessageBox.Show("Add Application Successfully");
                 }
                lblD_L_ApplicationID.Text = NewApplication.ApplicationID.ToString();

                btnSave.Enabled = false;
            }
            else
                MessageBox.Show("There is Wrong in Add or Update Application");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clsPerson person = clsPerson.Find(tbSearchedText.Text);

            if (person != null)
                ctrPersonDetails21.FillPersonInfo(person.ID);
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            People.frmAddAndUpdatePerson AddNewPerson = new People.frmAddAndUpdatePerson(-1);
            AddNewPerson.MdiParent = this.ParentForm.MdiParent;
            AddNewPerson.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if(isHaveActiveApplicationInThisClass())
           {
                MessageBox.Show("You can't add new application, because this person have active application in this license class", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Save();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrPersonDetails21.PersonID() == -1)
            {
                errorProvider1.SetError(tbSearchedText, "Add the Person Firstly");
                return;
            }
            tabAddNewLicense.SelectedIndex = 1;
        }

        private void tabAddNewLicense_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctrPersonDetails21.PersonID() == -1)
                tabAddNewLicense.SelectedIndex = 0;
        }

        private void cbLicenseClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isHaveComplatedApplicationInThisClass())
            {
                MessageBox.Show("This Person already have license in this class","Not Allowed",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                btnSave.Enabled = false;
                return;
            }
            btnSave.Enabled = true;

            //MessageBox.Show(cbLicenseClasses.SelectedItem.ToString() + 2);
            //MessageBox.Show(cbLicenseClasses.Text.ToString() + 3);
        }

        

        //private void btnNext_Click(object sender, EventArgs e)
        //{
        //    if (clsUser.isPersonExistInUsers(ctrPersonDetails21.ClassName()))
        //    {
        //       
        //        //MessageBox.Show("This Person is Already a User");
        //        return;
        //    }
        //    tabAddNewUser.SelectedIndex = 1;
        //}

        

        //bool InvalidInputs()
        //{
        //    if (string.IsNullOrWhiteSpace(tbUserName.Text))
        //        return true;
        //    if (tbPassword.Text != tbConfirmPassword.Text)
        //        return true;

        //    return false;
        //}

        


        //private void btnAddNewUser_Click(object sender, EventArgs e)
        //{
        //    People.frmAddAndUpdatePerson AddNewPerson = new People.frmAddAndUpdatePerson(-1);
        //    AddNewPerson.MdiParent = this.ParentForm.MdiParent;
        //    AddNewPerson.ReturnPersonID += LoadUserInfo;
        //    AddNewPerson.Show();
        //}


        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    Save();
        //}

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    clsPerson person = clsPerson.Find(tbSearchedText.Text);

        //    if (person != null)
        //        ctrPersonDetails21.FillPersonInfo(person.ID);
        //    else
        //        errorProvider1.SetError(tbSearchedText, "There is no Person With The Same National No.");
        //    // MessageBox.Show("There is no Person With The Same National No."); 
        //}

        //private void btnClose_Click(object sender, EventArgs e)
        //{
        //    this.ParentForm.Close();
        //}

        //private void tbSearchedText_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        //{
        //    if (tbConfirmPassword.Text != tbPassword.Text)
        //        errorProvider1.SetError(tbConfirmPassword, "Password Confimation does not match Password!");
        //}

        //private void tbUserName_Validating(object sender, CancelEventArgs e)
        //{
        //    if (clsUser.isUserExist(tbUserName.Text))
        //    {
        //        errorProvider1.SetError(tbUserName, "This Username is Used by Another Person");
        //        e.Cancel = true;
        //        tbUserName.Focus();

        //    }
        //}

        //private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        //{
        //    if (tbConfirmPassword.Text != tbPassword.Text)
        //        errorProvider1.SetError(tbConfirmPassword, "Password Confimation does not match Password!");

        //}
    }
}
