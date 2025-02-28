using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsDriver
    {
         private enum _enMode { Add, Update };
        _enMode Mode = _enMode.Add;

        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo;
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }
        
        public clsDriver()
        {

            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.Now ;
            this.Mode = _enMode.Add;
        }

        private clsDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(PersonID);
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
            this.Mode = _enMode.Update;

        }

        private bool _AddNewDriver()
        {
            this.DriverID = clsDriverDataAccess.AddNewDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate);
            return (this.DriverID != -1);
        }


        private bool _UpdateDriver()
        {
            return clsDriverDataAccess.UpdateDriver(this.DriverID, this.PersonID);
        }

        public static bool DeleteDriver(int DriverID)
        {
            return clsDriverDataAccess.DeleteDriver(DriverID);
        }

        public static bool isDriverExist(int DriverID)
        {
            return clsDriverDataAccess.isDriverExist(DriverID);
        }

        public static bool isPersonExistInDrivers(int PersonID)
        {
            return clsDriverDataAccess.isPersonExistInDrivers(PersonID);
        }

       

        public static clsDriver Find(int DriverID)
        {

            DateTime CreatedDate = DateTime.Now;
            int PersonID = -1,CreatedByUserID =-1;


            if (clsDriverDataAccess.GetDriverInfoByID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;

        }


        public static clsDriver Find(int PersonID,bool FindByPersonID = false)
        {
            DateTime CreatedDate = DateTime.Now;
            int CreatedByUserID = -1, DriverID = -1;

            if (clsDriverDataAccess.GetDriverInfoByPersonID(PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate))
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
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
                        if (_AddNewDriver())
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
                        IsSaved = _UpdateDriver();
                        break;
                    }

            }


            return IsSaved;

        }

        public static DataTable GetAllDrivers()
        {
            return clsDriverDataAccess.GetAllDrivers();
        }
    }
}
