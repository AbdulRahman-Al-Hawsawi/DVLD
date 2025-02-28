namespace DVLD_First.People
{
    partial class frmUpdatePerson
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
            this.ctrPersonCard1 = new DVLD_First.Controls.ctrPersonCard1();
            this.SuspendLayout();
            // 
            // ctrPersonCard1
            // 
            this.ctrPersonCard1.BackColor = System.Drawing.Color.White;
            this.ctrPersonCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrPersonCard1.Location = new System.Drawing.Point(0, 0);
            this.ctrPersonCard1.Name = "ctrPersonCard1";
            this.ctrPersonCard1.Size = new System.Drawing.Size(791, 378);
            this.ctrPersonCard1.TabIndex = 0;
            // 
            // frmUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 378);
            this.Controls.Add(this.ctrPersonCard1);
            this.Name = "frmUpdatePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Person";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUpdatePerson_FormClosed);
            this.Load += new System.EventHandler(this.frmUpdatePerson_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrPersonCard1 ctrPersonCard1;



    }
}