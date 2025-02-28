namespace DVLD_First.Controls
{
    partial class ctrDetainLicense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrDetainLicense));
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnSearchLicense = new Guna.UI.WinForms.GunaButton();
            this.tbLicenseID = new System.Windows.Forms.TextBox();
            this.gunaImageRadioButton10 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.LlblShowDetainedLicensesInfo = new System.Windows.Forms.LinkLabel();
            this.LlblShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbFineFees = new System.Windows.Forms.TextBox();
            this.gunaImageRadioButton1 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.gunaImageRadioButton5 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaImageRadioButton8 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gunaImageRadioButton7 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gunaImageRadioButton4 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ctrDriverLicenseInfo1 = new DVLD_First.Controls.ctrDriverLicenseInfo();
            this.btnDetain = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnClose = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gbFilter.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(315, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(164, 25);
            this.lblTitle.TabIndex = 88;
            this.lblTitle.Text = "Detain License";
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbFilter.Controls.Add(this.btnSearchLicense);
            this.gbFilter.Controls.Add(this.tbLicenseID);
            this.gbFilter.Controls.Add(this.gunaImageRadioButton10);
            this.gbFilter.Controls.Add(this.label8);
            this.gbFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(3, 28);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(490, 72);
            this.gbFilter.TabIndex = 87;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnSearchLicense
            // 
            this.btnSearchLicense.AnimationHoverSpeed = 0.07F;
            this.btnSearchLicense.AnimationSpeed = 0.03F;
            this.btnSearchLicense.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchLicense.BackgroundImage = global::DVLD_First.Properties.Resources.id;
            this.btnSearchLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchLicense.BaseColor = System.Drawing.Color.Transparent;
            this.btnSearchLicense.BorderColor = System.Drawing.Color.Black;
            this.btnSearchLicense.BorderSize = 1;
            this.btnSearchLicense.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearchLicense.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearchLicense.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchLicense.ForeColor = System.Drawing.Color.White;
            this.btnSearchLicense.Image = null;
            this.btnSearchLicense.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSearchLicense.Location = new System.Drawing.Point(401, 17);
            this.btnSearchLicense.Name = "btnSearchLicense";
            this.btnSearchLicense.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnSearchLicense.OnHoverBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSearchLicense.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearchLicense.OnHoverImage = null;
            this.btnSearchLicense.OnPressedColor = System.Drawing.Color.Snow;
            this.btnSearchLicense.Size = new System.Drawing.Size(64, 42);
            this.btnSearchLicense.TabIndex = 1;
            this.btnSearchLicense.Click += new System.EventHandler(this.btnSearchLicense_Click);
            // 
            // tbLicenseID
            // 
            this.tbLicenseID.Location = new System.Drawing.Point(174, 27);
            this.tbLicenseID.Name = "tbLicenseID";
            this.tbLicenseID.Size = new System.Drawing.Size(189, 23);
            this.tbLicenseID.TabIndex = 0;
            // 
            // gunaImageRadioButton10
            // 
            this.gunaImageRadioButton10.BackgroundImage = global::DVLD_First.Properties.Resources.field_number;
            this.gunaImageRadioButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageRadioButton10.ImageCheckedOff = null;
            this.gunaImageRadioButton10.ImageCheckedOn = null;
            this.gunaImageRadioButton10.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageRadioButton10.Location = new System.Drawing.Point(126, 26);
            this.gunaImageRadioButton10.Name = "gunaImageRadioButton10";
            this.gunaImageRadioButton10.Size = new System.Drawing.Size(24, 24);
            this.gunaImageRadioButton10.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 19);
            this.label8.TabIndex = 82;
            this.label8.Text = "License ID :";
            // 
            // LlblShowDetainedLicensesInfo
            // 
            this.LlblShowDetainedLicensesInfo.AutoSize = true;
            this.LlblShowDetainedLicensesInfo.Enabled = false;
            this.LlblShowDetainedLicensesInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlblShowDetainedLicensesInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LlblShowDetainedLicensesInfo.Location = new System.Drawing.Point(499, 47);
            this.LlblShowDetainedLicensesInfo.Name = "LlblShowDetainedLicensesInfo";
            this.LlblShowDetainedLicensesInfo.Size = new System.Drawing.Size(243, 19);
            this.LlblShowDetainedLicensesInfo.TabIndex = 4;
            this.LlblShowDetainedLicensesInfo.TabStop = true;
            this.LlblShowDetainedLicensesInfo.Text = "Show Detained Licenses Info";
            this.LlblShowDetainedLicensesInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlblShowDetainedLicensesInfo_LinkClicked);
            // 
            // LlblShowLicensesHistory
            // 
            this.LlblShowLicensesHistory.AutoSize = true;
            this.LlblShowLicensesHistory.Enabled = false;
            this.LlblShowLicensesHistory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlblShowLicensesHistory.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LlblShowLicensesHistory.Location = new System.Drawing.Point(499, 28);
            this.LlblShowLicensesHistory.Name = "LlblShowLicensesHistory";
            this.LlblShowLicensesHistory.Size = new System.Drawing.Size(189, 19);
            this.LlblShowLicensesHistory.TabIndex = 5;
            this.LlblShowLicensesHistory.TabStop = true;
            this.LlblShowLicensesHistory.Text = "Show Licenses History";
            this.LlblShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlblShowLicensesHistory_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.tbFineFees);
            this.groupBox3.Controls.Add(this.gunaImageRadioButton1);
            this.groupBox3.Controls.Add(this.gunaImageRadioButton5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.gunaImageRadioButton8);
            this.groupBox3.Controls.Add(this.lblDetainDate);
            this.groupBox3.Controls.Add(this.lblDetainID);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.gunaImageRadioButton7);
            this.groupBox3.Controls.Add(this.lblCreatedBy);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.gunaImageRadioButton4);
            this.groupBox3.Controls.Add(this.lblLicenseID);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 465);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(789, 125);
            this.groupBox3.TabIndex = 115;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detain Info";
            // 
            // tbFineFees
            // 
            this.tbFineFees.Location = new System.Drawing.Point(263, 85);
            this.tbFineFees.Multiline = true;
            this.tbFineFees.Name = "tbFineFees";
            this.tbFineFees.Size = new System.Drawing.Size(122, 29);
            this.tbFineFees.TabIndex = 2;
            // 
            // gunaImageRadioButton1
            // 
            this.gunaImageRadioButton1.BackgroundImage = global::DVLD_First.Properties.Resources.money;
            this.gunaImageRadioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageRadioButton1.ImageCheckedOff = null;
            this.gunaImageRadioButton1.ImageCheckedOn = null;
            this.gunaImageRadioButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageRadioButton1.Location = new System.Drawing.Point(219, 87);
            this.gunaImageRadioButton1.Name = "gunaImageRadioButton1";
            this.gunaImageRadioButton1.Size = new System.Drawing.Size(24, 24);
            this.gunaImageRadioButton1.TabIndex = 100;
            // 
            // gunaImageRadioButton5
            // 
            this.gunaImageRadioButton5.BackgroundImage = global::DVLD_First.Properties.Resources.field_number;
            this.gunaImageRadioButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageRadioButton5.ImageCheckedOff = null;
            this.gunaImageRadioButton5.ImageCheckedOn = null;
            this.gunaImageRadioButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageRadioButton5.Location = new System.Drawing.Point(219, 18);
            this.gunaImageRadioButton5.Name = "gunaImageRadioButton5";
            this.gunaImageRadioButton5.Size = new System.Drawing.Size(24, 24);
            this.gunaImageRadioButton5.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 96;
            this.label2.Text = "Fine Fees:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 95;
            this.label3.Text = "Detain Date";
            // 
            // gunaImageRadioButton8
            // 
            this.gunaImageRadioButton8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaImageRadioButton8.BackgroundImage")));
            this.gunaImageRadioButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageRadioButton8.ImageCheckedOff = null;
            this.gunaImageRadioButton8.ImageCheckedOn = null;
            this.gunaImageRadioButton8.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageRadioButton8.Location = new System.Drawing.Point(219, 54);
            this.gunaImageRadioButton8.Name = "gunaImageRadioButton8";
            this.gunaImageRadioButton8.Size = new System.Drawing.Size(24, 24);
            this.gunaImageRadioButton8.TabIndex = 93;
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.Location = new System.Drawing.Point(254, 57);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(36, 19);
            this.lblDetainDate.TabIndex = 94;
            this.lblDetainDate.Text = "???";
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainID.Location = new System.Drawing.Point(254, 21);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(36, 19);
            this.lblDetainID.TabIndex = 91;
            this.lblDetainID.Text = "???";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 19);
            this.label13.TabIndex = 89;
            this.label13.Text = "Detain ID:";
            // 
            // gunaImageRadioButton7
            // 
            this.gunaImageRadioButton7.BackgroundImage = global::DVLD_First.Properties.Resources.user__1_;
            this.gunaImageRadioButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageRadioButton7.ImageCheckedOff = null;
            this.gunaImageRadioButton7.ImageCheckedOn = null;
            this.gunaImageRadioButton7.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageRadioButton7.Location = new System.Drawing.Point(587, 50);
            this.gunaImageRadioButton7.Name = "gunaImageRadioButton7";
            this.gunaImageRadioButton7.Size = new System.Drawing.Size(24, 24);
            this.gunaImageRadioButton7.TabIndex = 88;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(622, 53);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(36, 19);
            this.lblCreatedBy.TabIndex = 85;
            this.lblCreatedBy.Text = "???";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(408, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 19);
            this.label11.TabIndex = 83;
            this.label11.Text = "License ID:";
            // 
            // gunaImageRadioButton4
            // 
            this.gunaImageRadioButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaImageRadioButton4.BackgroundImage")));
            this.gunaImageRadioButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageRadioButton4.ImageCheckedOff = null;
            this.gunaImageRadioButton4.ImageCheckedOn = null;
            this.gunaImageRadioButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageRadioButton4.Location = new System.Drawing.Point(587, 19);
            this.gunaImageRadioButton4.Name = "gunaImageRadioButton4";
            this.gunaImageRadioButton4.Size = new System.Drawing.Size(24, 24);
            this.gunaImageRadioButton4.TabIndex = 81;
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.Location = new System.Drawing.Point(622, 22);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(36, 19);
            this.lblLicenseID.TabIndex = 82;
            this.lblLicenseID.Text = "???";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(408, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 19);
            this.label9.TabIndex = 78;
            this.label9.Text = "Created By:";
            // 
            // ctrDriverLicenseInfo1
            // 
            this.ctrDriverLicenseInfo1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrDriverLicenseInfo1.Location = new System.Drawing.Point(3, 106);
            this.ctrDriverLicenseInfo1.Name = "ctrDriverLicenseInfo1";
            this.ctrDriverLicenseInfo1.Size = new System.Drawing.Size(789, 353);
            this.ctrDriverLicenseInfo1.TabIndex = 86;
            // 
            // btnDetain
            // 
            this.btnDetain.AnimationHoverSpeed = 0.07F;
            this.btnDetain.AnimationSpeed = 0.03F;
            this.btnDetain.BaseColor = System.Drawing.Color.Transparent;
            this.btnDetain.BorderColor = System.Drawing.Color.Black;
            this.btnDetain.BorderSize = 1;
            this.btnDetain.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDetain.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDetain.CheckedForeColor = System.Drawing.Color.White;
            this.btnDetain.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDetain.CheckedImage")));
            this.btnDetain.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDetain.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDetain.FocusedColor = System.Drawing.Color.Empty;
            this.btnDetain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetain.ForeColor = System.Drawing.Color.Black;
            this.btnDetain.Image = global::DVLD_First.Properties.Resources.hand;
            this.btnDetain.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDetain.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDetain.Location = new System.Drawing.Point(591, 69);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDetain.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDetain.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnDetain.OnHoverImage = null;
            this.btnDetain.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDetain.OnPressedColor = System.Drawing.Color.Black;
            this.btnDetain.Size = new System.Drawing.Size(97, 31);
            this.btnDetain.TabIndex = 3;
            this.btnDetain.Text = "Detain";
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
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
            this.btnClose.ImageSize = new System.Drawing.Size(23, 23);
            this.btnClose.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(86, 25);
            this.btnClose.TabIndex = 118;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.LlblShowDetainedLicensesInfo);
            this.Controls.Add(this.LlblShowLicensesHistory);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrDriverLicenseInfo1);
            this.Name = "ctrDetainLicense";
            this.Size = new System.Drawing.Size(800, 595);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbFilter;
        private Guna.UI.WinForms.GunaButton btnSearchLicense;
        private System.Windows.Forms.TextBox tbLicenseID;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton10;
        private System.Windows.Forms.Label label8;
        private ctrDriverLicenseInfo ctrDriverLicenseInfo1;
        private Guna.UI.WinForms.GunaAdvenceButton btnDetain;
        private Guna.UI.WinForms.GunaAdvenceButton btnClose;
        private System.Windows.Forms.LinkLabel LlblShowDetainedLicensesInfo;
        private System.Windows.Forms.LinkLabel LlblShowLicensesHistory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbFineFees;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton1;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton8;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.Label label13;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton7;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton4;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label label9;
    }
}
