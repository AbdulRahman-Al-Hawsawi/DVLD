namespace DVLD_First.Controls
{
    partial class ctrReleaseDetainedLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrReleaseDetainedLicense));
            this.LlblShowReleasedLicensesInfo = new System.Windows.Forms.LinkLabel();
            this.LlblShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnSearchLicense = new Guna.UI.WinForms.GunaButton();
            this.tbLicenseID = new System.Windows.Forms.TextBox();
            this.gunaImageRadioButton10 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRelease = new Guna.UI.WinForms.GunaAdvenceButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gunaImageRadioButton2 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gunaImageRadioButton6 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gunaImageRadioButton3 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaImageRadioButton1 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.gunaImageRadioButton5 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.lblApplicationFees = new System.Windows.Forms.Label();
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
            this.btnClose = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ctrDriverLicenseInfo1 = new DVLD_First.Controls.ctrDriverLicenseInfo();
            this.gbFilter.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LlblShowReleasedLicensesInfo
            // 
            this.LlblShowReleasedLicensesInfo.AutoSize = true;
            this.LlblShowReleasedLicensesInfo.Enabled = false;
            this.LlblShowReleasedLicensesInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlblShowReleasedLicensesInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LlblShowReleasedLicensesInfo.Location = new System.Drawing.Point(499, 51);
            this.LlblShowReleasedLicensesInfo.Name = "LlblShowReleasedLicensesInfo";
            this.LlblShowReleasedLicensesInfo.Size = new System.Drawing.Size(244, 19);
            this.LlblShowReleasedLicensesInfo.TabIndex = 90;
            this.LlblShowReleasedLicensesInfo.TabStop = true;
            this.LlblShowReleasedLicensesInfo.Text = "Show Released Licenses Info";
            this.LlblShowReleasedLicensesInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlblShowReleasedLicensesInfo_LinkClicked);
            // 
            // LlblShowLicensesHistory
            // 
            this.LlblShowLicensesHistory.AutoSize = true;
            this.LlblShowLicensesHistory.Enabled = false;
            this.LlblShowLicensesHistory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlblShowLicensesHistory.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LlblShowLicensesHistory.Location = new System.Drawing.Point(499, 32);
            this.LlblShowLicensesHistory.Name = "LlblShowLicensesHistory";
            this.LlblShowLicensesHistory.Size = new System.Drawing.Size(189, 19);
            this.LlblShowLicensesHistory.TabIndex = 91;
            this.LlblShowLicensesHistory.TabStop = true;
            this.LlblShowLicensesHistory.Text = "Show Licenses History";
            this.LlblShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlblShowLicensesHistory_LinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(259, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(276, 25);
            this.lblTitle.TabIndex = 94;
            this.lblTitle.Text = "Release Detained License";
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbFilter.Controls.Add(this.btnSearchLicense);
            this.gbFilter.Controls.Add(this.tbLicenseID);
            this.gbFilter.Controls.Add(this.gunaImageRadioButton10);
            this.gbFilter.Controls.Add(this.label8);
            this.gbFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(3, 32);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(490, 72);
            this.gbFilter.TabIndex = 93;
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
            // btnRelease
            // 
            this.btnRelease.AnimationHoverSpeed = 0.07F;
            this.btnRelease.AnimationSpeed = 0.03F;
            this.btnRelease.BaseColor = System.Drawing.Color.Transparent;
            this.btnRelease.BorderColor = System.Drawing.Color.Black;
            this.btnRelease.BorderSize = 1;
            this.btnRelease.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnRelease.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnRelease.CheckedForeColor = System.Drawing.Color.White;
            this.btnRelease.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnRelease.CheckedImage")));
            this.btnRelease.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnRelease.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRelease.FocusedColor = System.Drawing.Color.Empty;
            this.btnRelease.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelease.ForeColor = System.Drawing.Color.Black;
            this.btnRelease.Image = global::DVLD_First.Properties.Resources.hand;
            this.btnRelease.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRelease.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnRelease.Location = new System.Drawing.Point(589, 73);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRelease.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRelease.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnRelease.OnHoverImage = null;
            this.btnRelease.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnRelease.OnPressedColor = System.Drawing.Color.Black;
            this.btnRelease.Size = new System.Drawing.Size(97, 31);
            this.btnRelease.TabIndex = 89;
            this.btnRelease.Text = "Release";
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.gunaImageRadioButton2);
            this.groupBox3.Controls.Add(this.lblApplicationID);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.gunaImageRadioButton6);
            this.groupBox3.Controls.Add(this.lblFineFees);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.gunaImageRadioButton3);
            this.groupBox3.Controls.Add(this.lblTotalFees);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.gunaImageRadioButton1);
            this.groupBox3.Controls.Add(this.gunaImageRadioButton5);
            this.groupBox3.Controls.Add(this.lblApplicationFees);
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
            this.groupBox3.Location = new System.Drawing.Point(3, 469);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(789, 149);
            this.groupBox3.TabIndex = 95;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detain Info";
            // 
            // gunaImageRadioButton2
            // 
            this.gunaImageRadioButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaImageRadioButton2.BackgroundImage")));
            this.gunaImageRadioButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageRadioButton2.ImageCheckedOff = null;
            this.gunaImageRadioButton2.ImageCheckedOn = null;
            this.gunaImageRadioButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageRadioButton2.Location = new System.Drawing.Point(586, 113);
            this.gunaImageRadioButton2.Name = "gunaImageRadioButton2";
            this.gunaImageRadioButton2.Size = new System.Drawing.Size(24, 24);
            this.gunaImageRadioButton2.TabIndex = 109;
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.Location = new System.Drawing.Point(621, 116);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(36, 19);
            this.lblApplicationID.TabIndex = 108;
            this.lblApplicationID.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 19);
            this.label5.TabIndex = 107;
            this.label5.Text = "Application ID:";
            // 
            // gunaImageRadioButton6
            // 
            this.gunaImageRadioButton6.BackgroundImage = global::DVLD_First.Properties.Resources.money;
            this.gunaImageRadioButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageRadioButton6.ImageCheckedOff = null;
            this.gunaImageRadioButton6.ImageCheckedOn = null;
            this.gunaImageRadioButton6.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageRadioButton6.Location = new System.Drawing.Point(586, 81);
            this.gunaImageRadioButton6.Name = "gunaImageRadioButton6";
            this.gunaImageRadioButton6.Size = new System.Drawing.Size(24, 24);
            this.gunaImageRadioButton6.TabIndex = 106;
            // 
            // lblFineFees
            // 
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineFees.Location = new System.Drawing.Point(621, 84);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(36, 19);
            this.lblFineFees.TabIndex = 105;
            this.lblFineFees.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 19);
            this.label6.TabIndex = 104;
            this.label6.Text = "Fine Fees:";
            // 
            // gunaImageRadioButton3
            // 
            this.gunaImageRadioButton3.BackgroundImage = global::DVLD_First.Properties.Resources.money;
            this.gunaImageRadioButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageRadioButton3.ImageCheckedOff = null;
            this.gunaImageRadioButton3.ImageCheckedOn = null;
            this.gunaImageRadioButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageRadioButton3.Location = new System.Drawing.Point(219, 116);
            this.gunaImageRadioButton3.Name = "gunaImageRadioButton3";
            this.gunaImageRadioButton3.Size = new System.Drawing.Size(24, 24);
            this.gunaImageRadioButton3.TabIndex = 103;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.Location = new System.Drawing.Point(254, 119);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(36, 19);
            this.lblTotalFees.TabIndex = 102;
            this.lblTotalFees.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 101;
            this.label4.Text = "Total Fees:";
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
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.Location = new System.Drawing.Point(254, 90);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(36, 19);
            this.lblApplicationFees.TabIndex = 97;
            this.lblApplicationFees.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 96;
            this.label2.Text = "Application Fees:";
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
            this.gunaImageRadioButton7.Location = new System.Drawing.Point(586, 50);
            this.gunaImageRadioButton7.Name = "gunaImageRadioButton7";
            this.gunaImageRadioButton7.Size = new System.Drawing.Size(24, 24);
            this.gunaImageRadioButton7.TabIndex = 88;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(621, 53);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(36, 19);
            this.lblCreatedBy.TabIndex = 85;
            this.lblCreatedBy.Text = "???";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(407, 21);
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
            this.gunaImageRadioButton4.Location = new System.Drawing.Point(586, 19);
            this.gunaImageRadioButton4.Name = "gunaImageRadioButton4";
            this.gunaImageRadioButton4.Size = new System.Drawing.Size(24, 24);
            this.gunaImageRadioButton4.TabIndex = 81;
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.Location = new System.Drawing.Point(621, 22);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(36, 19);
            this.lblLicenseID.TabIndex = 82;
            this.lblLicenseID.Text = "???";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(407, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 19);
            this.label9.TabIndex = 78;
            this.label9.Text = "Created By:";
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
            this.btnClose.Location = new System.Drawing.Point(3, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(83, 31);
            this.btnClose.TabIndex = 121;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrDriverLicenseInfo1
            // 
            this.ctrDriverLicenseInfo1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrDriverLicenseInfo1.Location = new System.Drawing.Point(3, 110);
            this.ctrDriverLicenseInfo1.Name = "ctrDriverLicenseInfo1";
            this.ctrDriverLicenseInfo1.Size = new System.Drawing.Size(789, 353);
            this.ctrDriverLicenseInfo1.TabIndex = 92;
            this.ctrDriverLicenseInfo1.Load += new System.EventHandler(this.zzzzzzzz_Load);
            // 
            // ctrReleaseDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.LlblShowReleasedLicensesInfo);
            this.Controls.Add(this.LlblShowLicensesHistory);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrDriverLicenseInfo1);
            this.Name = "ctrReleaseDetainedLicense";
            this.Size = new System.Drawing.Size(796, 618);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btnRelease;
        private System.Windows.Forms.LinkLabel LlblShowReleasedLicensesInfo;
        private System.Windows.Forms.LinkLabel LlblShowLicensesHistory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbFilter;
        private Guna.UI.WinForms.GunaButton btnSearchLicense;
        private System.Windows.Forms.TextBox tbLicenseID;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton10;
        private System.Windows.Forms.Label label8;
        private ctrDriverLicenseInfo ctrDriverLicenseInfo1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton1;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton5;
        private System.Windows.Forms.Label lblApplicationFees;
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
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton6;
        private System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton3;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton2;
        private Guna.UI.WinForms.GunaAdvenceButton btnClose;
    }
}
