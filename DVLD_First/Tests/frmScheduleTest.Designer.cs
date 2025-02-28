namespace DVLD_First.Applications
{
    partial class frmScheduleTest
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
            this.ctrScheduleTest1 = new DVLD_First.Controls.ctrScheduleTest();
            this.SuspendLayout();
            // 
            // ctrScheduleTest1
            // 
            this.ctrScheduleTest1.apointmentid = false;
            this.ctrScheduleTest1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrScheduleTest1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrScheduleTest1.Location = new System.Drawing.Point(0, 0);
            this.ctrScheduleTest1.Name = "ctrScheduleTest1";
            this.ctrScheduleTest1.Size = new System.Drawing.Size(429, 578);
            this.ctrScheduleTest1.TabIndex = 0;
            this.ctrScheduleTest1.Load += new System.EventHandler(this.ctrScheduleTest1_Load);
            // 
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(429, 578);
            this.Controls.Add(this.ctrScheduleTest1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmScheduleTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmScheduleTest_FormClosing);
            this.Load += new System.EventHandler(this.frmScheduleTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrScheduleTest ctrScheduleTest1;
    }
}