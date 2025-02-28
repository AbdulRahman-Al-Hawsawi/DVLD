using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mime;
using DVLD_First.Global_Classes;
using DVLD_First.Properties;

namespace DVLD_First
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clsUtil.SendEmail("Abdu75p@gmail.com", "AbdulrahmanHawsawi75@gmail.com", "Add To System", "Add Successfully"))
                MessageBox.Show("Send Email Successfully");
            else
               MessageBox.Show("Send Email Faild");
        }

        private void frmTest_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GroupBox Panel;
            Panel = new System.Windows.Forms.GroupBox();
            Panel.Name = "Book";
            Panel.Text = "Avialable";
            Panel.BackColor = Color.White;
            Panel.Size = new Size(125, 205);
            Panel.Margin = new System.Windows.Forms.Padding(10);
            Panel.DoubleClick += button1_Click;
            
            PictureBox picbox = new PictureBox();
            picbox.Name = "Book";
            picbox.Size = new System.Drawing.Size(100, 148);
            picbox.Location = new Point(12, 13);
            picbox.SizeMode = PictureBoxSizeMode.Zoom;
            picbox.Image = Resources.edit;
            picbox.BackColor = Color.Black;

            Label LabelTitle = new Label();
            LabelTitle.Name = "lblTitle";
            LabelTitle.Text = "Power of now";
            LabelTitle.Location = new Point(12, 165);
            LabelTitle.ForeColor = Color.Black;
            LabelTitle.Font = new System.Drawing.Font(this.Font.FontFamily, 9.5f, FontStyle.Regular);
            LabelTitle.AutoSize = true;


            Label LabelYearTitle = new Label();
            LabelYearTitle.Name = "lblYearTitle";
            LabelYearTitle.Text = DateTime.Now.ToShortDateString();
            LabelYearTitle.Location = new Point(12, 185);
            LabelYearTitle.ForeColor = Color.Black;
            LabelYearTitle.Font = new System.Drawing.Font(this.Font.FontFamily, 9.5f, FontStyle.Regular);
            LabelYearTitle.AutoSize = true;


            Panel.Controls.Add(picbox);
            Panel.Controls.Add(LabelTitle);
            Panel.Controls.Add(LabelYearTitle);

            
        }

        private void create_Click(object sender, EventArgs e)
        {
            tbHashedPassword.Text = clsValidation.ComputeHase(tbPassword.Text.Trim());
        }
    }
}
