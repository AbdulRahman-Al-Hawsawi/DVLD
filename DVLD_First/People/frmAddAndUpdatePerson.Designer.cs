namespace DVLD_First.People
{
    partial class frmAddAndUpdatePerson
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
            this.ctrPersonCard11 = new DVLD_First.Controls.ctrPersonCard1();
            this.SuspendLayout();
            // 
            // ctrPersonCard11
            // 
            this.ctrPersonCard11.BackColor = System.Drawing.Color.White;
            this.ctrPersonCard11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrPersonCard11.Location = new System.Drawing.Point(0, 0);
            this.ctrPersonCard11.Name = "ctrPersonCard11";
            this.ctrPersonCard11.Size = new System.Drawing.Size(781, 370);
            this.ctrPersonCard11.TabIndex = 0;
            this.ctrPersonCard11.Load += new System.EventHandler(this.ctrPersonCard11_Load);
            // 
            // frmAddAndUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(781, 370);
            this.Controls.Add(this.ctrPersonCard11);
            this.Name = "frmAddAndUpdatePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Person";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddPerson_FormClosed);
            this.Load += new System.EventHandler(this.frmAddPerson_Load);
            this.ResumeLayout(false);

        }

        #endregion

        //private DVLD_First.Controls.ctrPersonCard1 ctrPersonCard1;
        private Controls.ctrPersonCard1 ctrPersonCard11;
    }
}