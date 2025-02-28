namespace DVLD_First.Applications
{
    partial class frmTakeTest
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
            this.ctrTakeTest1 = new DVLD_First.Controls.ctrTakeTest();
            this.SuspendLayout();
            // 
            // ctrTakeTest1
            // 
            this.ctrTakeTest1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrTakeTest1.Location = new System.Drawing.Point(0, 0);
            this.ctrTakeTest1.Name = "ctrTakeTest1";
            this.ctrTakeTest1.Size = new System.Drawing.Size(438, 538);
            this.ctrTakeTest1.TabIndex = 0;
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 538);
            this.Controls.Add(this.ctrTakeTest1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTakeTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTakeTest_FormClosing);
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrTakeTest ctrTakeTest1;
    }
}