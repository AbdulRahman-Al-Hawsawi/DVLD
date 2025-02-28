namespace DVLD_First.Licecses
{
    partial class frmIssueLicenseFirstTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueLicenseFirstTime));
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.btnClose = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnIssueLicense = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaImageRadioButton6 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.ctrTestAppointment1 = new DVLD_First.Controls.ctrTestAppointment();
            this.SuspendLayout();
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(92, 296);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(726, 150);
            this.tbNotes.TabIndex = 1;
            this.tbNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BaseColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.btnClose.BorderSize = 1;
            this.btnClose.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnClose.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnClose.CheckedForeColor = System.Drawing.Color.White;
            this.btnClose.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnClose.CheckedImage")));
            this.btnClose.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::DVLD_First.Properties.Resources.CloseIcon;
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnClose.Location = new System.Drawing.Point(640, 452);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(86, 31);
            this.btnClose.TabIndex = 118;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssueLicense
            // 
            this.btnIssueLicense.AnimationHoverSpeed = 0.07F;
            this.btnIssueLicense.AnimationSpeed = 0.03F;
            this.btnIssueLicense.BaseColor = System.Drawing.Color.Transparent;
            this.btnIssueLicense.BorderColor = System.Drawing.Color.Black;
            this.btnIssueLicense.BorderSize = 1;
            this.btnIssueLicense.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnIssueLicense.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnIssueLicense.CheckedForeColor = System.Drawing.Color.White;
            this.btnIssueLicense.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnIssueLicense.CheckedImage")));
            this.btnIssueLicense.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnIssueLicense.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIssueLicense.FocusedColor = System.Drawing.Color.Empty;
            this.btnIssueLicense.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueLicense.ForeColor = System.Drawing.Color.Black;
            this.btnIssueLicense.Image = global::DVLD_First.Properties.Resources.IssueDrivingLicense;
            this.btnIssueLicense.ImageSize = new System.Drawing.Size(30, 30);
            this.btnIssueLicense.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnIssueLicense.Location = new System.Drawing.Point(732, 452);
            this.btnIssueLicense.Name = "btnIssueLicense";
            this.btnIssueLicense.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnIssueLicense.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIssueLicense.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnIssueLicense.OnHoverImage = null;
            this.btnIssueLicense.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnIssueLicense.OnPressedColor = System.Drawing.Color.Black;
            this.btnIssueLicense.Size = new System.Drawing.Size(86, 31);
            this.btnIssueLicense.TabIndex = 119;
            this.btnIssueLicense.Text = "Issue";
            this.btnIssueLicense.Click += new System.EventHandler(this.btnIssueLicense_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 120;
            this.label3.Text = "Notes:";
            // 
            // gunaImageRadioButton6
            // 
            this.gunaImageRadioButton6.BackgroundImage = global::DVLD_First.Properties.Resources.document_orientation_potrait;
            this.gunaImageRadioButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageRadioButton6.ImageCheckedOff = null;
            this.gunaImageRadioButton6.ImageCheckedOn = null;
            this.gunaImageRadioButton6.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageRadioButton6.Location = new System.Drawing.Point(62, 296);
            this.gunaImageRadioButton6.Name = "gunaImageRadioButton6";
            this.gunaImageRadioButton6.Size = new System.Drawing.Size(24, 24);
            this.gunaImageRadioButton6.TabIndex = 127;
            // 
            // ctrTestAppointment1
            // 
            this.ctrTestAppointment1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrTestAppointment1.Location = new System.Drawing.Point(5, 0);
            this.ctrTestAppointment1.Name = "ctrTestAppointment1";
            this.ctrTestAppointment1.Size = new System.Drawing.Size(813, 290);
            this.ctrTestAppointment1.TabIndex = 0;
            // 
            // frmIssueLicenseFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(830, 488);
            this.Controls.Add(this.gunaImageRadioButton6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIssueLicense);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.ctrTestAppointment1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIssueLicenseFirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Driver License First Time";
            this.Load += new System.EventHandler(this.frmIssueLicenseFirstTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrTestAppointment ctrTestAppointment1;
        private System.Windows.Forms.TextBox tbNotes;
        private Guna.UI.WinForms.GunaAdvenceButton btnClose;
        private Guna.UI.WinForms.GunaAdvenceButton btnIssueLicense;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton6;
    }
}