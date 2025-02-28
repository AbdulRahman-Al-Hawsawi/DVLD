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
    public partial class frmUpdatePerson : Form
    {
        int _PersonID = -1;
        public frmUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        public delegate void DataBackEventHandler(int PersonID);
        public event DataBackEventHandler DataBack;
       
        private void frmUpdatePerson_Load(object sender, EventArgs e)
        {
            ctrPersonCard1.SetPersonID(_PersonID);
        }

        private void frmUpdatePerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBack.Invoke(_PersonID);
        }

    }
}
