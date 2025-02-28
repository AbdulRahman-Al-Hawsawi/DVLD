namespace DVLD_First.Licecses
{
    partial class frmRenewLocalDrivingLicense
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
            this.ctrApplicationNewLicenseInfo1 = new DVLD_First.Controls.ctrApplicationNewLicenseInfo();
            this.SuspendLayout();
            // 
            // ctrApplicationNewLicenseInfo1
            // 
            this.ctrApplicationNewLicenseInfo1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrApplicationNewLicenseInfo1.Location = new System.Drawing.Point(1, 3);
            this.ctrApplicationNewLicenseInfo1.Name = "ctrApplicationNewLicenseInfo1";
            this.ctrApplicationNewLicenseInfo1.Size = new System.Drawing.Size(793, 634);
            this.ctrApplicationNewLicenseInfo1.TabIndex = 1;
            // 
            // frmRenewLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 637);
            this.Controls.Add(this.ctrApplicationNewLicenseInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRenewLocalDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renew Local Driving License";
            this.Load += new System.EventHandler(this.frmRenewLocalDrivingLicense_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrApplicationNewLicenseInfo ctrApplicationNewLicenseInfo1;

    }
}