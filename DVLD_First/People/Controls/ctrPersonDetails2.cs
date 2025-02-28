using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DVLD_First.Properties;
using DVLD_First.People;
using DVLD_Business;

namespace DVLD_First.Controls
{
    public partial class ctrPersonDetails2 : UserControl
    {
        public ctrPersonDetails2()
        {
            InitializeComponent();
        }

        int _PersonID = -1;

        void ChoseGenderImage(string Gender)
        {
            
                if (Gender == "Female")
                    pbPersonImage.Image = Resources.UnknwonPerson_girl;
                else
                    pbPersonImage.Image = Resources.Unknwonperson_man;
        }

        void RefreshPersonInfo()
        {
            FillPersonInfo(_PersonID);
        }

        public int PersonID()
        {
            return _PersonID;
        }

        public void FillPersonInfo(int ID)
        {
            clsPerson Person = clsPerson.Find(ID);
            _PersonID = ID;
            lblPersonID.Text = ID.ToString();
            lblNationalNo.Text = Person.NationalNo;
            lblName.Text = Person.FullName;
            lblGender.Text = Person.Gender;
            lblDateOfBirth.Text = Person.DateOfBirth.ToShortDateString();
            lblEmail.Text = Person.Email;
            lblPhone.Text = Person.Phone;
            lblAddress.Text = Person.Address;
            lblCountry.Text = clsCountry.GetCountry(Person.CountryID);
            
            if (Person.ImagePath != "")
                pbPersonImage.ImageLocation = Person.ImagePath;
            else
                ChoseGenderImage(Person.Gender);


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddAndUpdatePerson UpdatePerson = new People.frmAddAndUpdatePerson(Convert.ToInt32(lblPersonID.Text));
            UpdatePerson.Refresh += RefreshPersonInfo;
            UpdatePerson.Show();
            
        }

        private void gbPersonInfo_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

       
    }
}
