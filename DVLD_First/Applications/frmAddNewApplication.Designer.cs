namespace DVLD_First.Licecses
{
    partial class frmAddNewApplication
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
            this.ctrAddNewLicense1 = new DVLD_First.Controls.ctrAddNewApplication();
            this.SuspendLayout();
            // 
            // ctrAddNewLicense1
            // 
            this.ctrAddNewLicense1.Location = new System.Drawing.Point(2, 2);
            this.ctrAddNewLicense1.Name = "ctrAddNewLicense1";
            this.ctrAddNewLicense1.Size = new System.Drawing.Size(918, 585);
            this.ctrAddNewLicense1.TabIndex = 0;
            this.ctrAddNewLicense1.Load += new System.EventHandler(this.ctrAddNewLicense1_Load);
            // 
            // frmAddNewApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 510);
            this.Controls.Add(this.ctrAddNewLicense1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddNewApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Application";
            this.Load += new System.EventHandler(this.frmAddNewLicense_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrAddNewApplication ctrAddNewLicense1;

    }
}