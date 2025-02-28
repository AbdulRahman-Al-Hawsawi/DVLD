namespace DVLD_First.Applications
{
    partial class frmTestAppointment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestAppointment));
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAppointmentsTable = new System.Windows.Forms.DataGridView();
            this.cmsAppointment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddAppointment = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnClose = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pbTestImage = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrTestAppointment1 = new DVLD_First.Controls.ctrTestAppointment();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsTable)).BeginInit();
            this.cmsAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(0, 636);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(94, 18);
            this.lblRecordCount.TabIndex = 116;
            this.lblRecordCount.Text = "# Records: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 115;
            this.label3.Text = "Appointments:";
            // 
            // dgvAppointmentsTable
            // 
            this.dgvAppointmentsTable.AllowUserToAddRows = false;
            this.dgvAppointmentsTable.AllowUserToDeleteRows = false;
            this.dgvAppointmentsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointmentsTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAppointmentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmentsTable.ContextMenuStrip = this.cmsAppointment;
            this.dgvAppointmentsTable.Location = new System.Drawing.Point(0, 482);
            this.dgvAppointmentsTable.Name = "dgvAppointmentsTable";
            this.dgvAppointmentsTable.ReadOnly = true;
            this.dgvAppointmentsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointmentsTable.Size = new System.Drawing.Size(803, 150);
            this.dgvAppointmentsTable.TabIndex = 114;
            // 
            // cmsAppointment
            // 
            this.cmsAppointment.BackColor = System.Drawing.SystemColors.Control;
            this.cmsAppointment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsAppointment.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.cmsAppointment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsAppointment.Name = "cmsPeople";
            this.cmsAppointment.Size = new System.Drawing.Size(237, 108);
            this.cmsAppointment.Opening += new System.ComponentModel.CancelEventHandler(this.cmsAppointment_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.editToolStripMenuItem.Image = global::DVLD_First.Properties.Resources.calendar_month;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(236, 52);
            this.editToolStripMenuItem.Text = "Edit Appointment ";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.deleteToolStripMenuItem.Image = global::DVLD_First.Properties.Resources.test_config;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(236, 52);
            this.deleteToolStripMenuItem.Text = "Take Test";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.AnimationHoverSpeed = 0.07F;
            this.btnAddAppointment.AnimationSpeed = 0.03F;
            this.btnAddAppointment.BackgroundImage = global::DVLD_First.Properties.Resources.calendar_month_add;
            this.btnAddAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAppointment.BaseColor = System.Drawing.Color.Transparent;
            this.btnAddAppointment.BorderColor = System.Drawing.Color.Black;
            this.btnAddAppointment.BorderSize = 1;
            this.btnAddAppointment.CheckedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddAppointment.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddAppointment.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddAppointment.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAddAppointment.CheckedImage")));
            this.btnAddAppointment.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddAppointment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddAppointment.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddAppointment.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAppointment.ForeColor = System.Drawing.Color.Black;
            this.btnAddAppointment.Image = null;
            this.btnAddAppointment.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddAppointment.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddAppointment.Location = new System.Drawing.Point(749, 434);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnAddAppointment.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddAppointment.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAddAppointment.OnHoverImage = null;
            this.btnAddAppointment.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAddAppointment.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddAppointment.Size = new System.Drawing.Size(54, 42);
            this.btnAddAppointment.TabIndex = 118;
            this.btnAddAppointment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
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
            this.btnClose.Location = new System.Drawing.Point(717, 636);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(86, 31);
            this.btnClose.TabIndex = 117;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbTestImage
            // 
            this.pbTestImage.Image = global::DVLD_First.Properties.Resources.hand;
            this.pbTestImage.Location = new System.Drawing.Point(301, 12);
            this.pbTestImage.Name = "pbTestImage";
            this.pbTestImage.Size = new System.Drawing.Size(195, 102);
            this.pbTestImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTestImage.TabIndex = 120;
            this.pbTestImage.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(237, 117);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(84, 33);
            this.lblTitle.TabIndex = 119;
            this.lblTitle.Text = "[???]";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrTestAppointment1
            // 
            this.ctrTestAppointment1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrTestAppointment1.Location = new System.Drawing.Point(0, 141);
            this.ctrTestAppointment1.Name = "ctrTestAppointment1";
            this.ctrTestAppointment1.Size = new System.Drawing.Size(812, 287);
            this.ctrTestAppointment1.TabIndex = 121;
            // 
            // frmTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(814, 671);
            this.Controls.Add(this.pbTestImage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAppointmentsTable);
            this.Controls.Add(this.ctrTestAppointment1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTestAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Test Appointment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTestAppointment_FormClosing);
            this.Load += new System.EventHandler(this.frmTestAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsTable)).EndInit();
            this.cmsAppointment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btnAddAppointment;
        private Guna.UI.WinForms.GunaAdvenceButton btnClose;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAppointmentsTable;
        private System.Windows.Forms.ContextMenuStrip cmsAppointment;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbTestImage;
        private System.Windows.Forms.Label lblTitle;
        private Controls.ctrTestAppointment ctrTestAppointment1;
    }
}