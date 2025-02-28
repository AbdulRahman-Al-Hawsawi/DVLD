using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DVLD_DataAccess;
using System.Data;


namespace DVLD_Business
{
    public class clsUser
    {
        private enum _enMode { Add, Update };
        _enMode Mode = _enMode.Add;

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }
        public clsPerson PersonInfo;


        public clsUser()
        {

            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.isActive = false;

            this.Mode = _enMode.Add;
        }

        private clsUser(int UserID, int PersonID, string UserName, string Password, bool isActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(PersonID);
            this.UserName = UserName;
            this.Password = Password;
            this.isActive = isActive;
            this.Mode = _enMode.Update;

        }

        private bool _AddNewUser()
        {
            this.UserID = clsUserDataAccess.AddNewUser(this.PersonID, this.UserName, this.Password, this.isActive);
            return (this.UserID != -1);
        }


        private bool _UpdateUser()
        {
            return clsUserDataAccess.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.isActive);
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserDataAccess.DeleteUser(UserID);
        }

        public static bool isUserExist(int UserID)
        {
            return clsUserDataAccess.isUserExist(UserID);
        }

        public static bool isPersonExistInUsers(int PersonID)
        {
            return clsUserDataAccess.isPersonExistInUsers(PersonID);
        }

        public static bool isUserExist(string UserName)
        {
            return clsUserDataAccess.isUserExist(UserName);
        }

        public static clsUser Find(int UserID)
        {
            string UserName = "", Password = "";
            bool isActive = false;
            int PersonID = -1;


            if (clsUserDataAccess.GetUserInfoByID(UserID, ref PersonID, ref UserName, ref Password, ref isActive))
                return new clsUser(UserID, PersonID, UserName, Password, isActive);
            else
                return null;

        }


        public static clsUser Find(string Username)
        {
            string  Password = "";
            bool isActive = false;
            int PersonID = -1, UserID = -1;


            if (clsUserDataAccess.GetUserInfoByUsername(Username, ref UserID, ref PersonID, ref Password, ref isActive))
                return new clsUser(UserID, PersonID, Username, Password, isActive);
            else
                return null;

        }


        public static clsUser FindByUsernameAndPassword(string UserName, string Password)
        {
            int UserID = -1;
            int PersonID = -1;

            bool IsActive = false;

            bool IsFound = clsUserDataAccess.GetUserInfoByUsernameAndPassword
                                (UserName, Password, ref UserID, ref PersonID, ref IsActive);

            if (IsFound)
                //we return new object of that User with the right data
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
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
                        if (_AddNewUser())
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
                        IsSaved = _UpdateUser();
                        break;
                    }

            }


            return IsSaved;

        }

        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }
    }
}
