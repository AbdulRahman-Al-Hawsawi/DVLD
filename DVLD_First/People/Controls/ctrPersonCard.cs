using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DVLD_First.Properties;
using DVLD_Business;
using DVLD_First.Global_Classes;


namespace DVLD_First.Controls
{
    public partial class ctrPersonCard1 : UserControl
    {
        enum enMode { Add, Update };
        enMode _Mode;
        int _PersonID = -1;
        clsPerson _Person;

        public ctrPersonCard1()
        {
            InitializeComponent();

        }

        public void SetPersonID(int PersonID)
        {
            _PersonID = PersonID;
            if (_PersonID == -1)
            {
                _Mode = enMode.Add;
            }
            else
                _Mode = enMode.Update;
            _LoadData();
        }

        void _LoadData()
        {
            _LoadCountries();

            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New Person";
                _Person = new clsPerson();
                DateTime MaximumDate = DateTime.Now;
               dtpDateOfBirth.MaxDate = MaximumDate.AddYears(-18);
                return;
            }

            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("This form will be closed because the Person is not exists");
                /// make delegate to close the form
            }

            lblTitle.Text = "Edit Person";
            lblID.Text = _Person.ID.ToString();
            tbNationalNo.Text = _Person.NationalNo;
            tbFirstName.Text = _Person.FirstName;
            tbSecondName.Text = _Person.SecondName;
            tbThirdName.Text = _Person.ThirdName;
            tbLastName.Text = _Person.LastName;
            tbAddress.Text = _Person.Address;
            tbPhone.Text = _Person.Phone;
            tbEmail.Text = _Person.Email;
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            cbCountry.SelectedItem = clsCountry.GetCountry(_Person.CountryID).ToString();

            if (_Person.Gender == "Male")
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            if (_Person.ImagePath != "" )
            {
                pbPersonImage.Load(_Person.ImagePath );
            }

            LlblRemoveImage.Visible = (_Person.ImagePath != "" && (pbPersonImage.Image != Resources.UnknwonPerson_girl || pbPersonImage.Image != Resources.Unknwonperson_man));

        }

         string GetNewImagePath(string SourcePath, string DestinationPath)
        {
            
            string ImageName = Guid.NewGuid().ToString()+ ".jpg";
            File.SetAttributes(DestinationPath, FileAttributes.Normal);
            string destFile = Path.Combine(DestinationPath, ImageName );
            File.Copy(SourcePath, destFile, true);
            return DestinationPath + "\\" + ImageName;
        }

        public void Save()
        {
            if (!CheckIsValidInputs())
                return;

            _Person.NationalNo = tbNationalNo.Text;
            _Person.FirstName = tbFirstName.Text;
            _Person.SecondName = tbSecondName.Text;
            _Person.ThirdName = tbThirdName.Text;
            _Person.LastName = tbLastName.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Email = tbEmail.Text;
            _Person.Phone = tbPhone.Text;
            _Person.Address = tbAddress.Text;
            _Person.CountryID = clsCountry.GetCountryID(cbCountry.SelectedItem.ToString());
                

            if (rbMale.Checked)
                _Person.Gender = "Male";
            else
                _Person.Gender = "Female";

            if (pbPersonImage.ImageLocation != null && (pbPersonImage.Image != Resources.Unknwonperson_man || pbPersonImage.Image != Resources.UnknwonPerson_girl))
            {
                if (_Person.ImagePath != pbPersonImage.ImageLocation && !string.IsNullOrWhiteSpace(_Person.ImagePath))
                {
                    DeleteImageFromFolder();
                }
                if (!File.Exists(_Person.ImagePath))
                    _Person.ImagePath = GetNewImagePath(pbPersonImage.ImageLocation, @"C:\DVLD_Person_Images");
            }
            else
                _Person.ImagePath = "";


            if (_Person.Save())
            {
                if (_Mode == enMode.Add)
                {
                    MessageBox.Show("Add New Person Successfully");
                    lblID.Text = _Person.ID.ToString();
                    lblTitle.Text = "Edit Person";
                    return;
                }
            }
            else
            {
                MessageBox.Show("Add Or Update Person faild");
            }

            this._Mode = enMode.Update;
            MessageBox.Show("Update Person Successfully");

            //if (clsUtil.SendEmail(tbEmail.Text.Trim(), "AbdulrahmanHawsawi75@gmail.com", "Add To System", "Add Successfully"))
            //    MessageBox.Show("Send Email Successfully");
            //else
            //        MessageBox.Show("Send Email Faild");
                    
                    

        }

        bool CheckIsValidInputs()
        {
            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                errorValidatingInputs.SetError(tbFirstName, "Invalid Value");
                tbFirstName.Focus();
                return false;
            }

            if ( string.IsNullOrWhiteSpace(tbSecondName.Text ))
            {
                errorValidatingInputs.SetError(tbSecondName, "Invalid Value");
                tbSecondName.Focus();
                return false;
            }

            if ( string.IsNullOrWhiteSpace(tbThirdName.Text))
            {
                errorValidatingInputs.SetError(tbThirdName, "Invalid Value");
                tbThirdName.Focus();
                return false;
            }

            if ( string.IsNullOrWhiteSpace(tbNationalNo.Text))
            {
                errorValidatingInputs.SetError(tbNationalNo, "Invalid Value");
                tbNationalNo.Focus();
                return false;
            }

            if ( string.IsNullOrWhiteSpace(tbPhone.Text) )
            {
                errorValidatingInputs.SetError(tbPhone, "Invalid Value");
                tbPhone.Focus();
                return false;
        
            }

            if ( string.IsNullOrWhiteSpace(tbAddress.Text))
            {
                errorValidatingInputs.SetError(tbAddress, "Invalid Value");
                tbAddress.Focus();
                return false;
            }

            if (!isValidEmail())
            {
                errorValidatingInputs.SetError(tbEmail, "Invalid Value");
                tbEmail.Focus();
                return false;
            }

            return true;

        }

        void _LoadCountries()
        {
            DataTable Countries = clsCountry.GetAllCountries();

            foreach(DataRow row in Countries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"].ToString());
            }
            if(_Mode == enMode.Add)
            cbCountry.SelectedItem = "Saudi Arabia";

        }

        void ValidatingNationalNo()
        {
            if (_Mode == enMode.Add)
            {
                if (clsPerson.isPersonExist(tbNationalNo.Text.ToString()))
                {

                    errorValidatingInputs.SetError(tbNationalNo, "The National No is Used By Other Person");
                    tbNationalNo.Focus();
                  
                    return;
                }
            }
            

        }

        bool isValidEmail()
        {
            if (tbEmail.Text.Length < 13)
            {
                errorValidatingInputs.SetError(tbEmail, "Invalid Input");
                return false;
            }

            int TextLength = tbEmail.Text.Length;
            int EamilSempol = tbEmail.Text.IndexOf("@gmail.com", TextLength - 10);

            if (EamilSempol > 0 )
                return true;
            else
                errorValidatingInputs.SetError(tbEmail, "Invalid Input");
            return false;
            
        }

        void ChoseGenderImage()
        {
            if (_Person.ImagePath == null)
                if (rbFemale.Checked)
                    pbPersonImage.Image = Resources.UnknwonPerson_girl;
                else
                    pbPersonImage.Image = Resources.Unknwonperson_man;
        }

        void DeleteImageFromFolder()
        {
            pbPersonImage.Dispose();
            File.Delete(_Person.ImagePath);
            _Person.ImagePath = null;
            pbPersonImage.Refresh();
            ChoseGenderImage();
           
        }

        private void LlblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofdSetImage.Title = "Set Person Image";
            ofdSetImage.DefaultExt = "C:\\Users\\AD\\PictureFileForVs\\";
           
            if (ofdSetImage.ShowDialog() == DialogResult.OK)
            {
               

                pbPersonImage.ImageLocation = ofdSetImage.FileName;
                LlblRemoveImage.Visible = true;
            }
           
        }

        private void LlblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeleteImageFromFolder();           
        }

        private void ctrPersonCard_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void ChoseGenderImageCheckedChanged(object sender, EventArgs e)
        {
            ChoseGenderImage();
        }

        private void tbNationalNo_TextChanged(object sender, EventArgs e)
        {
            if(_Mode == enMode.Add)
            if (clsPerson.isPersonExist(tbNationalNo.Text.ToString()))
                errorValidatingInputs.SetError(tbNationalNo, "The National No is Used By Other Person");

        }

        private void tbNationalNo_Validating(object sender, CancelEventArgs e)
        {
           // if (_Mode == enMode.Add)
            {
                if (clsPerson.isPersonExist(tbNationalNo.Text.ToString()) && _Person.NationalNo != tbNationalNo.Text)
                {
                    e.Cancel = true;
                    tbNationalNo.Focus();
                    errorValidatingInputs.SetError(tbNationalNo, "The National No is Used By Other Person");
                    return;
                }
            }

            e.Cancel = false;
        }


        public int PersonID
        {
            get {return _Person.ID;}
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        
        //public void LoadUserInfo(int ID)
        //{
        //    clsPerson _Person = clsPerson.Find(ID);

        //    if (_Person != null)
        //    {
        //          lblID.Text = _Person.ID.ToString();
        //        //lblNationalNo.Text = _Person.NationalNo;
        //        //lblFirstName.Text = _Person.FirstName;
        //        //lblSecondName.Text = _Person.SecondName;
        //        //lblThirdName.Text = _Person.ThirdName;
        //        //lblLastName.Text = _Person.LastName;
        //        //lblAddress.Text = _Person.Address;
        //        //lblPhone.Text = _Person.Phone;
        //        //lblEmail.Text = _Person.Email;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Not found");

        //    }

        //}

       
    }
}
