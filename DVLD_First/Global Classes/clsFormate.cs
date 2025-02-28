using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DVLD_First.Global_Classes
{
    class clsFormate
    {
        public static string DateToShort(DateTime Dt1)
        {

            return Dt1.ToString("dd/MMM/yyyy");
        } 
    }
}
