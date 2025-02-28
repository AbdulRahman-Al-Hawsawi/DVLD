namespace DVLD_First.Users
{
    partial class frmShowUserDetails
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
            this.ctrUserDetails1 = new DVLD_First.Controls.ctrUserDetails();
            this.SuspendLayout();
            // 
            // ctrUserDetails1
            // 
            this.ctrUserDetails1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrUserDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrUserDetails1.Location = new System.Drawing.Point(0, 0);
            this.ctrUserDetails1.Name = "ctrUserDetails1";
            this.ctrUserDetails1.Size = new System.Drawing.Size(757, 399);
            this.ctrUserDetails1.TabIndex = 0;
            // 
            // frmShowUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 399);
            this.Controls.Add(this.ctrUserDetails1);
            this.Name = "frmShowUserDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowUserDetails";
            this.Load += new System.EventHandler(this.frmShowUserDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrUserDetails ctrUserDetails1;
    }
}