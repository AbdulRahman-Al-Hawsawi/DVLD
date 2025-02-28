using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DVLD_First
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new DVLD_First.Applications.frmManageApplications());
            Application.Run(new frmLogin());
          //  Application.Run(new MainForm(1,true));
            //Application.Run(new frmTest());
        }
    }
}
