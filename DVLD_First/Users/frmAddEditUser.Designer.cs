namespace DVLD_First.Users
{
    partial class frmAddEditUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrAddUpdateUser1 = new DVLD_First.Controls.ctrAddUpdateUser();
            this.SuspendLayout();
            // 
            // ctrAddUpdateUser1
            // 
            this.ctrAddUpdateUser1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrAddUpdateUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrAddUpdateUser1.Location = new System.Drawing.Point(0, 0);
            this.ctrAddUpdateUser1.Name = "ctrAddUpdateUser1";
            this.ctrAddUpdateUser1.Size = new System.Drawing.Size(913, 530);
            this.ctrAddUpdateUser1.TabIndex = 0;
            this.ctrAddUpdateUser1.Load += new System.EventHandler(this.ctrAddUpdateUser1_Load);
            // 
            // frmAddEditUser
            // 
            this.ClientSize = new System.Drawing.Size(913, 530);
            this.Controls.Add(this.ctrAddUpdateUser1);
            this.Name = "frmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add & Edit User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditUser_FormClosing);
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

       // private Controls.ctrAddUpdateUser ctrAddUser1;
        private Controls.ctrAddUpdateUser ctrAddUpdateUser1;
    }
}