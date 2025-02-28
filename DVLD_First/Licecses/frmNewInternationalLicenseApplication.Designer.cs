namespace DVLD_First.Licecses
{
    partial class frmNewInternationalLicenseApplication
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
            this.ctrNewInternationalLicenseApplication1 = new DVLD_First.Controls.ctrNewInternationalLicenseApplication();
            this.SuspendLayout();
            // 
            // ctrNewInternationalLicenseApplication1
            // 
            this.ctrNewInternationalLicenseApplication1.Location = new System.Drawing.Point(2, 1);
            this.ctrNewInternationalLicenseApplication1.Name = "ctrNewInternationalLicenseApplication1";
            this.ctrNewInternationalLicenseApplication1.Size = new System.Drawing.Size(793, 579);
            this.ctrNewInternationalLicenseApplication1.TabIndex = 0;
            this.ctrNewInternationalLicenseApplication1.Load += new System.EventHandler(this.ctrNewInternationalLicenseApplication1_Load);
            // 
            // frmNewInternationalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 580);
            this.Controls.Add(this.ctrNewInternationalLicenseApplication1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewInternationalLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New International License Application";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrNewInternationalLicenseApplication ctrNewInternationalLicenseApplication1;
    }
}