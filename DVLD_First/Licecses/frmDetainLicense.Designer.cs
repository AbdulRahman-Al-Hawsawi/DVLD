﻿namespace DVLD_First.Licecses
{
    partial class frmDetainLicense
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
            this.ctrDetainLicense1 = new DVLD_First.Controls.ctrDetainLicense();
            this.SuspendLayout();
            // 
            // ctrDetainLicense1
            // 
            this.ctrDetainLicense1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrDetainLicense1.Location = new System.Drawing.Point(3, 3);
            this.ctrDetainLicense1.Name = "ctrDetainLicense1";
            this.ctrDetainLicense1.Size = new System.Drawing.Size(800, 595);
            this.ctrDetainLicense1.TabIndex = 0;
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(804, 598);
            this.Controls.Add(this.ctrDetainLicense1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDetainLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detain License";
            this.Load += new System.EventHandler(this.frmDetainLicense_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrDetainLicense ctrDetainLicense1;
    }
}