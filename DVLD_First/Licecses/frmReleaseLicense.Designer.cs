﻿namespace DVLD_First.Licecses
{
    partial class frmReleaseLicense
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
            this.ctrReleaseDetainedLicense1 = new DVLD_First.Controls.ctrReleaseDetainedLicense();
            this.SuspendLayout();
            // 
            // ctrReleaseDetainedLicense1
            // 
            this.ctrReleaseDetainedLicense1.Location = new System.Drawing.Point(1, 2);
            this.ctrReleaseDetainedLicense1.Name = "ctrReleaseDetainedLicense1";
            this.ctrReleaseDetainedLicense1.Size = new System.Drawing.Size(830, 619);
            this.ctrReleaseDetainedLicense1.TabIndex = 0;
            // 
            // frmReleaseLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(796, 619);
            this.Controls.Add(this.ctrReleaseDetainedLicense1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReleaseLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Release License";
            this.Load += new System.EventHandler(this.frmReleaseLicense_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrReleaseDetainedLicense ctrReleaseDetainedLicense1;
    }
}