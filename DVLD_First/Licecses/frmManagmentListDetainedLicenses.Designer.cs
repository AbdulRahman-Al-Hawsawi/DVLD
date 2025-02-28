namespace DVLD_First.Licecses
{
    partial class frmManagmentListDetainedLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagmentListDetainedLicenses));
            this.cbStatusToFiltering = new System.Windows.Forms.ComboBox();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.tbSearchedText = new System.Windows.Forms.TextBox();
            this.cbFiltering = new System.Windows.Forms.ComboBox();
            this.dgvListDetaindLicenses = new System.Windows.Forms.DataGridView();
            this.cmsLicenseOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showdetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReleaseDetainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAddNewDetained = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReleasedDetain = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDetaindLicenses)).BeginInit();
            this.cmsLicenseOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStatusToFiltering
            // 
            this.cbStatusToFiltering.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusToFiltering.FormattingEnabled = true;
            this.cbStatusToFiltering.Items.AddRange(new object[] {
            "All ",
            "Detained",
            "Released"});
            this.cbStatusToFiltering.Location = new System.Drawing.Point(225, 103);
            this.cbStatusToFiltering.Name = "cbStatusToFiltering";
            this.cbStatusToFiltering.Size = new System.Drawing.Size(120, 26);
            this.cbStatusToFiltering.TabIndex = 113;
            this.cbStatusToFiltering.Text = "All";
            this.cbStatusToFiltering.Visible = false;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(7, 442);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(94, 18);
            this.lblRecordCount.TabIndex = 111;
            this.lblRecordCount.Text = "# Records: ";
            // 
            // tbSearchedText
            // 
            this.tbSearchedText.Location = new System.Drawing.Point(225, 102);
            this.tbSearchedText.Multiline = true;
            this.tbSearchedText.Name = "tbSearchedText";
            this.tbSearchedText.Size = new System.Drawing.Size(135, 26);
            this.tbSearchedText.TabIndex = 108;
            this.tbSearchedText.Visible = false;
            this.tbSearchedText.TextChanged += new System.EventHandler(this.tbSearchedText_TextChanged);
            // 
            // cbFiltering
            // 
            this.cbFiltering.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltering.FormattingEnabled = true;
            this.cbFiltering.Items.AddRange(new object[] {
            "None",
            "Detain ID",
            "License ID",
            "Detain Date",
            "Fine Fees",
            "Release Date ",
            "National No.",
            "Name",
            "Release Application ID",
            "Detain Status"});
            this.cbFiltering.Location = new System.Drawing.Point(76, 102);
            this.cbFiltering.Name = "cbFiltering";
            this.cbFiltering.Size = new System.Drawing.Size(143, 26);
            this.cbFiltering.TabIndex = 107;
            this.cbFiltering.Text = "None";
            this.cbFiltering.SelectedIndexChanged += new System.EventHandler(this.cbFiltering_SelectedIndexChanged);
            // 
            // dgvListDetaindLicenses
            // 
            this.dgvListDetaindLicenses.AllowUserToAddRows = false;
            this.dgvListDetaindLicenses.AllowUserToDeleteRows = false;
            this.dgvListDetaindLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListDetaindLicenses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListDetaindLicenses.ColumnHeadersHeight = 30;
            this.dgvListDetaindLicenses.ContextMenuStrip = this.cmsLicenseOptions;
            this.dgvListDetaindLicenses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvListDetaindLicenses.Location = new System.Drawing.Point(-3, 133);
            this.dgvListDetaindLicenses.Name = "dgvListDetaindLicenses";
            this.dgvListDetaindLicenses.ReadOnly = true;
            this.dgvListDetaindLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListDetaindLicenses.Size = new System.Drawing.Size(935, 296);
            this.dgvListDetaindLicenses.TabIndex = 106;
            this.dgvListDetaindLicenses.Tag = "";
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
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.ReleaseDetainLicenseToolStripMenuItem});
            this.cmsLicenseOptions.Name = "cmsPeople";
            this.cmsLicenseOptions.Size = new System.Drawing.Size(308, 212);
            this.cmsLicenseOptions.Opening += new System.ComponentModel.CancelEventHandler(this.cmsLicenseOptions_Opening);
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
            // ReleaseDetainLicenseToolStripMenuItem
            // 
            this.ReleaseDetainLicenseToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.ReleaseDetainLicenseToolStripMenuItem.Image = global::DVLD_First.Properties.Resources.delete;
            this.ReleaseDetainLicenseToolStripMenuItem.Name = "ReleaseDetainLicenseToolStripMenuItem";
            this.ReleaseDetainLicenseToolStripMenuItem.Size = new System.Drawing.Size(307, 52);
            this.ReleaseDetainLicenseToolStripMenuItem.Text = "Release Detained License";
            this.ReleaseDetainLicenseToolStripMenuItem.Click += new System.EventHandler(this.ReleaseDetainLicenseToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(436, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 105;
            this.label1.Text = "List Detained Licenses";
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
            this.btnClose.Location = new System.Drawing.Point(850, 435);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(82, 33);
            this.btnClose.TabIndex = 110;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewDetained
            // 
            this.btnAddNewDetained.AnimationHoverSpeed = 0.07F;
            this.btnAddNewDetained.AnimationSpeed = 0.03F;
            this.btnAddNewDetained.BackgroundImage = global::DVLD_First.Properties.Resources.hand;
            this.btnAddNewDetained.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNewDetained.BaseColor = System.Drawing.Color.Transparent;
            this.btnAddNewDetained.BorderColor = System.Drawing.Color.Maroon;
            this.btnAddNewDetained.BorderSize = 2;
            this.btnAddNewDetained.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewDetained.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNewDetained.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewDetained.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddNewDetained.Image = null;
            this.btnAddNewDetained.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddNewDetained.Location = new System.Drawing.Point(865, 79);
            this.btnAddNewDetained.Name = "btnAddNewDetained";
            this.btnAddNewDetained.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddNewDetained.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNewDetained.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddNewDetained.OnHoverImage = global::DVLD_First.Properties.Resources.public_document;
            this.btnAddNewDetained.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddNewDetained.Size = new System.Drawing.Size(67, 49);
            this.btnAddNewDetained.TabIndex = 109;
            this.btnAddNewDetained.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddNewDetained.Click += new System.EventHandler(this.btnAddNewDetained_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DVLD_First.Properties.Resources.hand;
            this.pictureBox1.Location = new System.Drawing.Point(499, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 114;
            this.label2.Text = "Filter By";
            // 
            // btnReleasedDetain
            // 
            this.btnReleasedDetain.AnimationHoverSpeed = 0.07F;
            this.btnReleasedDetain.AnimationSpeed = 0.03F;
            this.btnReleasedDetain.BackgroundImage = global::DVLD_First.Properties.Resources.public_document;
            this.btnReleasedDetain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReleasedDetain.BaseColor = System.Drawing.Color.Transparent;
            this.btnReleasedDetain.BorderColor = System.Drawing.Color.Maroon;
            this.btnReleasedDetain.BorderSize = 2;
            this.btnReleasedDetain.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReleasedDetain.FocusedColor = System.Drawing.Color.Empty;
            this.btnReleasedDetain.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReleasedDetain.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReleasedDetain.Image = null;
            this.btnReleasedDetain.ImageSize = new System.Drawing.Size(35, 35);
            this.btnReleasedDetain.Location = new System.Drawing.Point(792, 80);
            this.btnReleasedDetain.Name = "btnReleasedDetain";
            this.btnReleasedDetain.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnReleasedDetain.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReleasedDetain.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReleasedDetain.OnHoverImage = global::DVLD_First.Properties.Resources.public_document;
            this.btnReleasedDetain.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReleasedDetain.Size = new System.Drawing.Size(67, 49);
            this.btnReleasedDetain.TabIndex = 115;
            this.btnReleasedDetain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnReleasedDetain.Click += new System.EventHandler(this.btnReleasedDetain_Click);
            // 
            // frmManagmentListDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(934, 472);
            this.Controls.Add(this.btnReleasedDetain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbStatusToFiltering);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddNewDetained);
            this.Controls.Add(this.tbSearchedText);
            this.Controls.Add(this.cbFiltering);
            this.Controls.Add(this.dgvListDetaindLicenses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManagmentListDetainedLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Detained Licenses";
            this.Load += new System.EventHandler(this.frmManagmentListDetainedLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDetaindLicenses)).EndInit();
            this.cmsLicenseOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStatusToFiltering;
        private System.Windows.Forms.Label lblRecordCount;
        private Guna.UI.WinForms.GunaAdvenceButton btnClose;
        private Guna.UI.WinForms.GunaButton btnAddNewDetained;
        private System.Windows.Forms.TextBox tbSearchedText;
        private System.Windows.Forms.ComboBox cbFiltering;
        private System.Windows.Forms.DataGridView dgvListDetaindLicenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btnReleasedDetain;
        private System.Windows.Forms.ContextMenuStrip cmsLicenseOptions;
        private System.Windows.Forms.ToolStripMenuItem showdetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReleaseDetainLicenseToolStripMenuItem;
    }
}