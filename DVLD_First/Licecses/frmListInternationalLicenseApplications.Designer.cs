namespace DVLD_First.Licecses
{
    partial class frmListInternationalLicenseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListInternationalLicenseApplications));
            this.cbStatusToFiltering = new System.Windows.Forms.ComboBox();
            this.gunaImageRadioButton11 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAddNewInternationalLicenseApplication = new Guna.UI.WinForms.GunaButton();
            this.tbSearchedText = new System.Windows.Forms.TextBox();
            this.cbFiltering = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvInternationalLicenseApplications = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmsLicenseOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showdetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenseApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsLicenseOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbStatusToFiltering
            // 
            this.cbStatusToFiltering.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusToFiltering.FormattingEnabled = true;
            this.cbStatusToFiltering.Items.AddRange(new object[] {
            "All ",
            "Active",
            "UnActive"});
            this.cbStatusToFiltering.Location = new System.Drawing.Point(228, 112);
            this.cbStatusToFiltering.Name = "cbStatusToFiltering";
            this.cbStatusToFiltering.Size = new System.Drawing.Size(120, 26);
            this.cbStatusToFiltering.TabIndex = 114;
            this.cbStatusToFiltering.Text = "All";
            this.cbStatusToFiltering.Visible = false;
            this.cbStatusToFiltering.SelectedIndexChanged += new System.EventHandler(this.cbStatusToFiltering_SelectedIndexChanged);
            // 
            // gunaImageRadioButton11
            // 
            this.gunaImageRadioButton11.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageRadioButton11.BackgroundImage = global::DVLD_First.Properties.Resources.world;
            this.gunaImageRadioButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageRadioButton11.ImageCheckedOff = null;
            this.gunaImageRadioButton11.ImageCheckedOn = null;
            this.gunaImageRadioButton11.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageRadioButton11.Location = new System.Drawing.Point(499, 72);
            this.gunaImageRadioButton11.Name = "gunaImageRadioButton11";
            this.gunaImageRadioButton11.Size = new System.Drawing.Size(33, 34);
            this.gunaImageRadioButton11.TabIndex = 113;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(10, 451);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(94, 18);
            this.lblRecordCount.TabIndex = 112;
            this.lblRecordCount.Text = "# Records: ";
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
            this.btnClose.Location = new System.Drawing.Point(853, 444);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(82, 33);
            this.btnClose.TabIndex = 111;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewInternationalLicenseApplication
            // 
            this.btnAddNewInternationalLicenseApplication.AnimationHoverSpeed = 0.07F;
            this.btnAddNewInternationalLicenseApplication.AnimationSpeed = 0.03F;
            this.btnAddNewInternationalLicenseApplication.BackgroundImage = global::DVLD_First.Properties.Resources.public_document;
            this.btnAddNewInternationalLicenseApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNewInternationalLicenseApplication.BaseColor = System.Drawing.Color.Transparent;
            this.btnAddNewInternationalLicenseApplication.BorderColor = System.Drawing.Color.Maroon;
            this.btnAddNewInternationalLicenseApplication.BorderSize = 2;
            this.btnAddNewInternationalLicenseApplication.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewInternationalLicenseApplication.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNewInternationalLicenseApplication.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewInternationalLicenseApplication.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddNewInternationalLicenseApplication.Image = null;
            this.btnAddNewInternationalLicenseApplication.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddNewInternationalLicenseApplication.Location = new System.Drawing.Point(868, 88);
            this.btnAddNewInternationalLicenseApplication.Name = "btnAddNewInternationalLicenseApplication";
            this.btnAddNewInternationalLicenseApplication.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddNewInternationalLicenseApplication.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNewInternationalLicenseApplication.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddNewInternationalLicenseApplication.OnHoverImage = global::DVLD_First.Properties.Resources.public_document;
            this.btnAddNewInternationalLicenseApplication.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddNewInternationalLicenseApplication.Size = new System.Drawing.Size(67, 49);
            this.btnAddNewInternationalLicenseApplication.TabIndex = 110;
            this.btnAddNewInternationalLicenseApplication.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddNewInternationalLicenseApplication.Click += new System.EventHandler(this.btnAddNewInternationalLicenseApplication_Click);
            // 
            // tbSearchedText
            // 
            this.tbSearchedText.Location = new System.Drawing.Point(228, 111);
            this.tbSearchedText.Multiline = true;
            this.tbSearchedText.Name = "tbSearchedText";
            this.tbSearchedText.Size = new System.Drawing.Size(135, 26);
            this.tbSearchedText.TabIndex = 109;
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
            "Int. License ID",
            "Application ID",
            "Driver ID",
            "L.License ID",
            "Issue Date",
            "Expiration Date",
            "Status"});
            this.cbFiltering.Location = new System.Drawing.Point(79, 111);
            this.cbFiltering.Name = "cbFiltering";
            this.cbFiltering.Size = new System.Drawing.Size(143, 26);
            this.cbFiltering.TabIndex = 108;
            this.cbFiltering.Text = "None";
            this.cbFiltering.SelectedIndexChanged += new System.EventHandler(this.cbFiltering_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 107;
            this.label2.Text = "Filter By";
            // 
            // dgvInternationalLicenseApplications
            // 
            this.dgvInternationalLicenseApplications.AllowUserToAddRows = false;
            this.dgvInternationalLicenseApplications.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenseApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInternationalLicenseApplications.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInternationalLicenseApplications.ColumnHeadersHeight = 30;
            this.dgvInternationalLicenseApplications.ContextMenuStrip = this.cmsLicenseOptions;
            this.dgvInternationalLicenseApplications.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvInternationalLicenseApplications.Location = new System.Drawing.Point(0, 142);
            this.dgvInternationalLicenseApplications.Name = "dgvInternationalLicenseApplications";
            this.dgvInternationalLicenseApplications.ReadOnly = true;
            this.dgvInternationalLicenseApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternationalLicenseApplications.Size = new System.Drawing.Size(935, 296);
            this.dgvInternationalLicenseApplications.TabIndex = 106;
            this.dgvInternationalLicenseApplications.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(369, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 25);
            this.label1.TabIndex = 105;
            this.label1.Text = "International License Application";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DVLD_First.Properties.Resources.documents;
            this.pictureBox1.Location = new System.Drawing.Point(499, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            // 
            // cmsLicenseOptions
            // 
            this.cmsLicenseOptions.BackColor = System.Drawing.Color.Linen;
            this.cmsLicenseOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmsLicenseOptions.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsLicenseOptions.ImageScalingSize = new System.Drawing.Size(45, 45);
            this.cmsLicenseOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showdetailsToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmsLicenseOptions.Name = "cmsPeople";
            this.cmsLicenseOptions.Size = new System.Drawing.Size(308, 160);
            // 
            // showdetailsToolStripMenuItem
            // 
            this.showdetailsToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.showdetailsToolStripMenuItem.Image = global::DVLD_First.Properties.Resources.paste;
            this.showdetailsToolStripMenuItem.Name = "showdetailsToolStripMenuItem";
            this.showdetailsToolStripMenuItem.Size = new System.Drawing.Size(307, 52);
            this.showdetailsToolStripMenuItem.Text = "Show Person Details";
            this.showdetailsToolStripMenuItem.Click += new System.EventHandler(this.showdetailsToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.showLicenseToolStripMenuItem.Image = global::DVLD_First.Properties.Resources.id__1_;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(307, 52);
            this.showLicenseToolStripMenuItem.Text = "Show License Details";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD_First.Properties.Resources.PersonHistory;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(307, 52);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // frmListInternationalLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 478);
            this.Controls.Add(this.cbStatusToFiltering);
            this.Controls.Add(this.gunaImageRadioButton11);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddNewInternationalLicenseApplication);
            this.Controls.Add(this.tbSearchedText);
            this.Controls.Add(this.cbFiltering);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvInternationalLicenseApplications);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListInternationalLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List International License Applications";
            this.Load += new System.EventHandler(this.frmListInternationalLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenseApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsLicenseOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStatusToFiltering;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton11;
        private System.Windows.Forms.Label lblRecordCount;
        private Guna.UI.WinForms.GunaAdvenceButton btnClose;
        private Guna.UI.WinForms.GunaButton btnAddNewInternationalLicenseApplication;
        private System.Windows.Forms.TextBox tbSearchedText;
        private System.Windows.Forms.ComboBox cbFiltering;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvInternationalLicenseApplications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmsLicenseOptions;
        private System.Windows.Forms.ToolStripMenuItem showdetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}