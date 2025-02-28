namespace DVLD_First.Applications
{
    partial class frmManageApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageApplications));
            this.tbSearchedText = new System.Windows.Forms.TextBox();
            this.cbFiltering = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLocalDrivingLicenseApplications = new System.Windows.Forms.DataGridView();
            this.cmsLicenseOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showdetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WritingTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streatTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IssueDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.gunaImageRadioButton11 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.btnClose = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAddNewLocalDriverLicenseApplication = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbStatusToFiltering = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenseApplications)).BeginInit();
            this.cmsLicenseOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearchedText
            // 
            this.tbSearchedText.Location = new System.Drawing.Point(228, 110);
            this.tbSearchedText.Multiline = true;
            this.tbSearchedText.Name = "tbSearchedText";
            this.tbSearchedText.Size = new System.Drawing.Size(135, 26);
            this.tbSearchedText.TabIndex = 50;
            this.tbSearchedText.Visible = false;
            this.tbSearchedText.TextChanged += new System.EventHandler(this.tbSearchedText_TextChanged);
            this.tbSearchedText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchedText_KeyPress);
            // 
            // cbFiltering
            // 
            this.cbFiltering.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltering.FormattingEnabled = true;
            this.cbFiltering.Items.AddRange(new object[] {
            "None",
            "L.D.L. App. ID",
            "National No.",
            "Name",
            "Application Date",
            "Passed Tests",
            "Status"});
            this.cbFiltering.Location = new System.Drawing.Point(79, 110);
            this.cbFiltering.Name = "cbFiltering";
            this.cbFiltering.Size = new System.Drawing.Size(143, 26);
            this.cbFiltering.TabIndex = 49;
            this.cbFiltering.Text = "None";
            this.cbFiltering.SelectedIndexChanged += new System.EventHandler(this.cbFiltering_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "Filter By";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvLocalDrivingLicenseApplications
            // 
            this.dgvLocalDrivingLicenseApplications.AllowUserToAddRows = false;
            this.dgvLocalDrivingLicenseApplications.AllowUserToDeleteRows = false;
            this.dgvLocalDrivingLicenseApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLocalDrivingLicenseApplications.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLocalDrivingLicenseApplications.ColumnHeadersHeight = 30;
            this.dgvLocalDrivingLicenseApplications.ContextMenuStrip = this.cmsLicenseOptions;
            this.dgvLocalDrivingLicenseApplications.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvLocalDrivingLicenseApplications.Location = new System.Drawing.Point(0, 141);
            this.dgvLocalDrivingLicenseApplications.Name = "dgvLocalDrivingLicenseApplications";
            this.dgvLocalDrivingLicenseApplications.ReadOnly = true;
            this.dgvLocalDrivingLicenseApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalDrivingLicenseApplications.Size = new System.Drawing.Size(935, 296);
            this.dgvLocalDrivingLicenseApplications.TabIndex = 47;
            this.dgvLocalDrivingLicenseApplications.Tag = "";
            this.dgvLocalDrivingLicenseApplications.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocalDrivingLicenseApplications_CellContentClick);
            // 
            // cmsLicenseOptions
            // 
            this.cmsLicenseOptions.BackColor = System.Drawing.Color.Linen;
            this.cmsLicenseOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmsLicenseOptions.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsLicenseOptions.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.cmsLicenseOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showdetailsToolStripMenuItem,
            this.EditApplicationToolStripMenuItem,
            this.DeleteApplicationToolStripMenuItem,
            this.CancelApplicationToolStripMenuItem,
            this.ScheduleTestToolStripMenuItem,
            this.IssueDrivingLicenseToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmsLicenseOptions.Name = "cmsPeople";
            this.cmsLicenseOptions.Size = new System.Drawing.Size(340, 442);
            this.cmsLicenseOptions.Opening += new System.ComponentModel.CancelEventHandler(this.cmsPeople_Opening);
            // 
            // showdetailsToolStripMenuItem
            // 
            this.showdetailsToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.showdetailsToolStripMenuItem.Image = global::DVLD_First.Properties.Resources.paste;
            this.showdetailsToolStripMenuItem.Name = "showdetailsToolStripMenuItem";
            this.showdetailsToolStripMenuItem.Size = new System.Drawing.Size(339, 52);
            this.showdetailsToolStripMenuItem.Text = "Show details";
            // 
            // EditApplicationToolStripMenuItem
            // 
            this.EditApplicationToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.EditApplicationToolStripMenuItem.Image = global::DVLD_First.Properties.Resources.edit;
            this.EditApplicationToolStripMenuItem.Name = "EditApplicationToolStripMenuItem";
            this.EditApplicationToolStripMenuItem.Size = new System.Drawing.Size(339, 52);
            this.EditApplicationToolStripMenuItem.Text = "Edit Application";
            // 
            // DeleteApplicationToolStripMenuItem
            // 
            this.DeleteApplicationToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.DeleteApplicationToolStripMenuItem.Image = global::DVLD_First.Properties.Resources.delete_row;
            this.DeleteApplicationToolStripMenuItem.Name = "DeleteApplicationToolStripMenuItem";
            this.DeleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(339, 52);
            this.DeleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.DeleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.DeleteApplicationToolStripMenuItem_Click);
            // 
            // CancelApplicationToolStripMenuItem
            // 
            this.CancelApplicationToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.CancelApplicationToolStripMenuItem.Image = global::DVLD_First.Properties.Resources.delete;
            this.CancelApplicationToolStripMenuItem.Name = "CancelApplicationToolStripMenuItem";
            this.CancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(339, 52);
            this.CancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.CancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.CancelApplicationToolStripMenuItem_Click);
            // 
            // ScheduleTestToolStripMenuItem
            // 
            this.ScheduleTestToolStripMenuItem.BackColor = System.Drawing.Color.LightSalmon;
            this.ScheduleTestToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ScheduleTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionTestToolStripMenuItem,
            this.WritingTestToolStripMenuItem,
            this.streatTestToolStripMenuItem});
            this.ScheduleTestToolStripMenuItem.Image = global::DVLD_First.Properties.Resources.test_config;
            this.ScheduleTestToolStripMenuItem.Name = "ScheduleTestToolStripMenuItem";
            this.ScheduleTestToolStripMenuItem.Size = new System.Drawing.Size(339, 52);
            this.ScheduleTestToolStripMenuItem.Text = "Schedule Test";
            this.ScheduleTestToolStripMenuItem.Click += new System.EventHandler(this.ScheduleTestToolStripMenuItem_Click);
            this.ScheduleTestToolStripMenuItem.MouseEnter += new System.EventHandler(this.ScheduleTestToolStripMenuItem_MouseEnter);
            // 
            // visionTestToolStripMenuItem
            // 
            this.visionTestToolStripMenuItem.Image = global::DVLD_First.Properties.Resources.eye_Small;
            this.visionTestToolStripMenuItem.Name = "visionTestToolStripMenuItem";
            this.visionTestToolStripMenuItem.Size = new System.Drawing.Size(270, 52);
            this.visionTestToolStripMenuItem.Text = "Schedule Vision Test";
            this.visionTestToolStripMenuItem.Click += new System.EventHandler(this.visionTestToolStripMenuItem_Click);
            // 
            // WritingTestToolStripMenuItem
            // 
            this.WritingTestToolStripMenuItem.Image = global::DVLD_First.Properties.Resources.exam;
            this.WritingTestToolStripMenuItem.Name = "WritingTestToolStripMenuItem";
            this.WritingTestToolStripMenuItem.Size = new System.Drawing.Size(270, 52);
            this.WritingTestToolStripMenuItem.Text = " Schedule Writting Test";
            this.WritingTestToolStripMenuItem.Click += new System.EventHandler(this.WritingTestToolStripMenuItem_Click);
            // 
            // streatTestToolStripMenuItem
            // 
            this.streatTestToolStripMenuItem.Image = global::DVLD_First.Properties.Resources.CarSmall;
            this.streatTestToolStripMenuItem.Name = "streatTestToolStripMenuItem";
            this.streatTestToolStripMenuItem.Size = new System.Drawing.Size(270, 52);
            this.streatTestToolStripMenuItem.Text = "Schedule Street Test";
            this.streatTestToolStripMenuItem.Click += new System.EventHandler(this.streatTestToolStripMenuItem_Click);
            // 
            // IssueDrivingLicenseToolStripMenuItem
            // 
            this.IssueDrivingLicenseToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.IssueDrivingLicenseToolStripMenuItem.Image = global::DVLD_First.Properties.Resources.IssueDrivingLicense;
            this.IssueDrivingLicenseToolStripMenuItem.Name = "IssueDrivingLicenseToolStripMenuItem";
            this.IssueDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(339, 52);
            this.IssueDrivingLicenseToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.IssueDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.IssueDrivingLicenseToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.showLicenseToolStripMenuItem.Image = global::DVLD_First.Properties.Resources.id__1_;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(339, 52);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.DropDownOpening += new System.EventHandler(this.showLicenseToolStripMenuItem_DropDownOpening);
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD_First.Properties.Resources.PersonHistory;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(339, 52);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(369, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Local Driving License Application";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(10, 450);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(94, 18);
            this.lblRecordCount.TabIndex = 53;
            this.lblRecordCount.Text = "# Records: ";
            // 
            // gunaImageRadioButton11
            // 
            this.gunaImageRadioButton11.BackgroundImage = global::DVLD_First.Properties.Resources.local_network;
            this.gunaImageRadioButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageRadioButton11.ImageCheckedOff = null;
            this.gunaImageRadioButton11.ImageCheckedOn = null;
            this.gunaImageRadioButton11.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageRadioButton11.Location = new System.Drawing.Point(610, 55);
            this.gunaImageRadioButton11.Name = "gunaImageRadioButton11";
            this.gunaImageRadioButton11.Size = new System.Drawing.Size(28, 27);
            this.gunaImageRadioButton11.TabIndex = 102;
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
            this.btnClose.Location = new System.Drawing.Point(853, 443);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(82, 33);
            this.btnClose.TabIndex = 52;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewLocalDriverLicenseApplication
            // 
            this.btnAddNewLocalDriverLicenseApplication.AnimationHoverSpeed = 0.07F;
            this.btnAddNewLocalDriverLicenseApplication.AnimationSpeed = 0.03F;
            this.btnAddNewLocalDriverLicenseApplication.BackgroundImage = global::DVLD_First.Properties.Resources.public_document;
            this.btnAddNewLocalDriverLicenseApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNewLocalDriverLicenseApplication.BaseColor = System.Drawing.Color.Transparent;
            this.btnAddNewLocalDriverLicenseApplication.BorderColor = System.Drawing.Color.Maroon;
            this.btnAddNewLocalDriverLicenseApplication.BorderSize = 2;
            this.btnAddNewLocalDriverLicenseApplication.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewLocalDriverLicenseApplication.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNewLocalDriverLicenseApplication.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewLocalDriverLicenseApplication.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddNewLocalDriverLicenseApplication.Image = null;
            this.btnAddNewLocalDriverLicenseApplication.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddNewLocalDriverLicenseApplication.Location = new System.Drawing.Point(868, 87);
            this.btnAddNewLocalDriverLicenseApplication.Name = "btnAddNewLocalDriverLicenseApplication";
            this.btnAddNewLocalDriverLicenseApplication.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddNewLocalDriverLicenseApplication.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNewLocalDriverLicenseApplication.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddNewLocalDriverLicenseApplication.OnHoverImage = global::DVLD_First.Properties.Resources.public_document;
            this.btnAddNewLocalDriverLicenseApplication.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddNewLocalDriverLicenseApplication.Size = new System.Drawing.Size(67, 49);
            this.btnAddNewLocalDriverLicenseApplication.TabIndex = 51;
            this.btnAddNewLocalDriverLicenseApplication.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddNewLocalDriverLicenseApplication.Click += new System.EventHandler(this.btnAddNewLocalDriverLicenseApplication_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DVLD_First.Properties.Resources.documents;
            this.pictureBox1.Location = new System.Drawing.Point(502, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // cbStatusToFiltering
            // 
            this.cbStatusToFiltering.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusToFiltering.FormattingEnabled = true;
            this.cbStatusToFiltering.Items.AddRange(new object[] {
            "All ",
            "New",
            "Cancelled",
            "Complated"});
            this.cbStatusToFiltering.Location = new System.Drawing.Point(228, 111);
            this.cbStatusToFiltering.Name = "cbStatusToFiltering";
            this.cbStatusToFiltering.Size = new System.Drawing.Size(120, 26);
            this.cbStatusToFiltering.TabIndex = 103;
            this.cbStatusToFiltering.Text = "All";
            this.cbStatusToFiltering.Visible = false;
            this.cbStatusToFiltering.SelectedIndexChanged += new System.EventHandler(this.cbStatusToFiltering_SelectedIndexChanged);
            // 
            // frmManageApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(938, 477);
            this.ContextMenuStrip = this.cmsLicenseOptions;
            this.Controls.Add(this.cbStatusToFiltering);
            this.Controls.Add(this.gunaImageRadioButton11);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddNewLocalDriverLicenseApplication);
            this.Controls.Add(this.tbSearchedText);
            this.Controls.Add(this.cbFiltering);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLocalDrivingLicenseApplications);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Applications";
            this.Load += new System.EventHandler(this.frmManageApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenseApplications)).EndInit();
            this.cmsLicenseOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btnClose;
        private Guna.UI.WinForms.GunaButton btnAddNewLocalDriverLicenseApplication;
        private System.Windows.Forms.TextBox tbSearchedText;
        private System.Windows.Forms.ComboBox cbFiltering;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLocalDrivingLicenseApplications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.ContextMenuStrip cmsLicenseOptions;
        private System.Windows.Forms.ToolStripMenuItem showdetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ScheduleTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IssueDrivingLicenseToolStripMenuItem;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton11;
        private System.Windows.Forms.ToolStripMenuItem visionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WritingTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streatTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbStatusToFiltering;
    }
}