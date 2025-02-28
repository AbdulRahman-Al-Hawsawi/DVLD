using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
   
        public class clsPerson
        {
            private enum _enMode { Add, Update };
            _enMode Mode = _enMode.Add;

            public int ID { get; set; }
            public string NationalNo { get; set; }
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public string ThirdName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public DateTime DateOfBirth { get; set; }
            public int CountryID { get; set; }
            public string ImagePath { get; set; }
            public string Gender { get; set; }

            public string FullName
            {
                get { return this.FirstName + " " + this.SecondName + " " + this.ThirdName + " " + this.LastName; }
            }

            public clsPerson()
            {

                this.ID = -1;
                this.NationalNo = "";
                this.FirstName = "";
                this.SecondName = "";
                this.ThirdName = "";
                this.LastName = "";
                this.DateOfBirth = DateTime.Now;
                this.Email = "";
                this.Phone = "";
                this.Address = "";
                this.CountryID = -1;
                this.ImagePath = "";
                this.Gender ="";
                this.Mode = _enMode.Add;
            }

            private clsPerson(int ID,string NationalNo,string FirstName, string SecondName, string ThirdName, string  LastName, DateTime  DateOfBirth, string Gender, string Address, string Email, string Phone, int CountryID, string ImagePath)
             {
                this.ID = ID;
                this.NationalNo = NationalNo;
                this.FirstName = FirstName;
                this.SecondName = SecondName;
                this.ThirdName = ThirdName;
                this.LastName = LastName;
                this.Email = Email;
                this.Phone = Phone;
                this.Address = Address;
                this.DateOfBirth = DateOfBirth;
                this.CountryID = CountryID;
                this.ImagePath = ImagePath;
                this.Gender = Gender;
                this.Mode = _enMode.Update;

            }

            private bool _AddNewPerson()
            {
                this.ID = clsPersonDataAccess.AddNewPerson(this.NationalNo,this.FirstName,this.SecondName,this.ThirdName,this.LastName,this.DateOfBirth,this.Gender,this.Address,this.Email,this.Phone,this.CountryID,this.ImagePath);

                return (this.ID != -1);
            }

          

            private bool _UpdatePerson()
            {
                return clsPersonDataAccess.UpdatePerson(this.ID,this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Email, this.Phone, this.CountryID, this.ImagePath);
            }

            public static bool DeletePerson(int PersonID)
            {
                return clsPersonDataAccess.DeletePerson(PersonID);
            }

            public static bool isPersonExist(int PersonID)
            {
                return clsPersonDataAccess.isPersonExist(PersonID);
            }

            public static bool isPersonExist(string NationalNo)
            {
                return clsPersonDataAccess.isPersonExist(NationalNo);
            }

            public static clsPerson Find(int ID)
            {
                string NationalNo = "", FirstName = "", SecondName = "",ThirdName = "",LastName = "", Email = "", Phone = "", Address = "", ImagePath = "",
                    Gender ="";
                DateTime DateOfBirth = DateTime.Now;
               
                int CountryID = -1;


                if (clsPersonDataAccess.GetPersonInfoByID(ID,ref NationalNo,ref FirstName, ref SecondName, ref ThirdName, ref  LastName, ref  DateOfBirth, ref Gender, ref Address, ref Email, ref Phone, ref CountryID, ref ImagePath))
                    return new clsPerson(ID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth,  Gender, Address, Email, Phone, CountryID, ImagePath);
                else
                    return null;

            }

            public static clsPerson Find(string NationalNo)
            {
                string  FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "",
                    Gender = "";
                DateTime DateOfBirth = DateTime.Now;
               
                int CountryID = -1, ID =-1;


                if (clsPersonDataAccess.GetPersonInfoByNationalNO(NationalNo, ref ID, ref FirstName, ref SecondName, ref ThirdName, ref  LastName, ref  DateOfBirth, ref Gender, ref Address, ref Email, ref Phone, ref CountryID, ref ImagePath))
                    return new clsPerson(ID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Email, Phone, CountryID, ImagePath);
                else
                    return null;

            }

            public bool Save()
            {
                bool IsSaved = false;
                switch (Mode)
                {
                    case _enMode.Add:
                        {
                            if (_AddNewPerson())
                            {
                                Mode = _enMode.Update;
                                IsSaved = true;
                            }
                            else
                            {
                                IsSaved = false;
                            }
                            break;
                        }
                    case _enMode.Update:
                        {
                            IsSaved = _UpdatePerson();
                            break;
                        }

                }


                return IsSaved;

            }

            public static DataTable GetAllPeople()
            {
               return clsPersonDataAccess.GetAllPeople();
            }

           

        }
    }

