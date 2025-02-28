using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DVLD_DataAccess;
using System.Data;

namespace DVLD_Business
{
    public class clsTestType
    {
         public int TestID { get; set;}
         public string Title { get; set; }
         public string Descreption { get; set; }
         public double Fees { get; set; }

        clsTestType(int TestID,string Title,string Descreption,double Fees)
        {
            this.TestID = TestID;
            this.Title = Title;
            this.Descreption = Descreption;
            this.Fees = Fees;
        }

        public static clsTestType Find(int TestID)
        {
            string Title = "";
            string Descreption = "";
            double Fees = 0;


            if (clsTestTypesDataAccess.GetTestTypeInfoByID(TestID,ref Title,ref Descreption, ref Fees))
                return new clsTestType(TestID,Title,Descreption,Fees);
            else
                return null;

        }

        public bool save()
        {
            return clsTestTypesDataAccess.UpdateTest(this.TestID,Title,Descreption,Fees);
        }


        public static DataTable GetAllTestTayes()
        {
            return clsTestTypesDataAccess.GetAllTestTypes();
        }
    }
}
