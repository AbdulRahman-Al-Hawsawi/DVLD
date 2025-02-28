using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DVLD_First.People
{
    public partial class frmAddAndUpdatePerson : Form
    {
        int _PersonID = -1;
        
        public frmAddAndUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        public delegate void DataBackEventHandler();
        public event DataBackEventHandler Refresh;
        public delegate void DataBack(int PersonID);
        public event DataBack ReturnPersonID;
       





        private void frmAddPerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            
             Refresh.Invoke();
            if (_PersonID == -1)
            {
            if( ctrPersonCard11.PersonID != -1)
                ReturnPersonID.Invoke(ctrPersonCard11.PersonID);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ctrPersonCard11.Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddPerson_Load(object sender, EventArgs e)
        {
            ctrPersonCard11.SetPersonID(_PersonID);
        }

        private void ctrPersonCard11_Load(object sender, EventArgs e)
        {

        }

        

       
    }
}
