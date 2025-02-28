namespace DVLD_First.Controls
{
    partial class ctrAddNewApplication
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrAddNewApplication));
            this.tabAddNewLicense = new System.Windows.Forms.TabControl();
            this.PersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI.WinForms.GunaButton();
            this.gbSearchAdd = new System.Windows.Forms.GroupBox();
            this.btnSearch = new Guna.UI.WinForms.GunaButton();
            this.btnAddNewUser = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearchedText = new System.Windows.Forms.TextBox();
            this.cbFiltering = new System.Windows.Forms.ComboBox();
            this.ApplicationInfo = new System.Windows.Forms.TabPage();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.cbLicenseClasses = new System.Windows.Forms.ComboBox();
            this.gunaImageRadioButton5 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.gunaImageRadioButton2 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblD_L_ApplicationID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gunaImageRadioButton1 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.gunaImageRadioButton4 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.gunaImageRadioButton3 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.btnClose = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrPersonDetails21 = new DVLD_First.Controls.ctrPersonDetails2();
            this.tabAddNewLicense.SuspendLayout();
            this.PersonInfo.SuspendLayout();
            this.gbSearchAdd.SuspendLayout();
            this.ApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAddNewLicense
            // 
            this.tabAddNewLicense.Controls.Add(this.PersonInfo);
            this.tabAddNewLicense.Controls.Add(this.ApplicationInfo);
            this.tabAddNewLicense.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAddNewLicense.Location = new System.Drawing.Point(3, 3);
            this.tabAddNewLicense.Name = "tabAddNewLicense";
            this.tabAddNewLicense.SelectedIndex = 0;
            this.tabAddNewLicense.Size = new System.Drawing.Size(908, 461);
            this.tabAddNewLicense.TabIndex = 1;
            this.tabAddNewLicense.SelectedIndexChanged += new System.EventHandler(this.tabAddNewLicense_SelectedIndexChanged);
            // 
            // PersonInfo
            // 
            this.PersonInfo.Controls.Add(this.ctrPersonDetails21);
            this.PersonInfo.Controls.Add(this.btnNext);
            this.PersonInfo.Controls.Add(this.gbSearchAdd);
            this.PersonInfo.Location = new System.Drawing.Point(4, 23);
            this.PersonInfo.Name = "PersonInfo";
            this.PersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.PersonInfo.Size = new System.Drawing.Size(900, 434);
            this.PersonInfo.TabIndex = 0;
            this.PersonInfo.Text = "Peroson Info";
            this.PersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.AnimationHoverSpeed = 0.07F;
            this.btnNext.AnimationSpeed = 0.03F;
            this.btnNext.BaseColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderColor = System.Drawing.Color.Maroon;
            this.btnNext.BorderSize = 2;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.FocusedColor = System.Drawing.Color.Empty;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Image = null;
            this.btnNext.ImageSize = new System.Drawing.Size(35, 35);
            this.btnNext.Location = new System.Drawing.Point(810, 396);
            this.btnNext.Name = "btnNext";
            this.btnNext.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnNext.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNext.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNext.OnHoverImage = null;
            this.btnNext.OnPressedColor = System.Drawing.Color.Black;
            this.btnNext.Size = new System.Drawing.Size(75, 34);
            this.btnNext.TabIndex = 57;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // gbSearchAdd
            // 
            this.gbSearchAdd.Controls.Add(this.btnSearch);
            this.gbSearchAdd.Controls.Add(this.btnAddNewUser);
            this.gbSearchAdd.Controls.Add(this.label2);
            this.gbSearchAdd.Controls.Add(this.tbSearchedText);
            this.gbSearchAdd.Controls.Add(this.cbFiltering);
            this.gbSearchAdd.Location = new System.Drawing.Point(6, 6);
            this.gbSearchAdd.Name = "gbSearchAdd";
            this.gbSearchAdd.Size = new System.Drawing.Size(847, 69);
            this.gbSearchAdd.TabIndex = 1;
            this.gbSearchAdd.TabStop = false;
            this.gbSearchAdd.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BaseColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.Maroon;
            this.btnSearch.BorderSize = 2;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.Image = global::DVLD_First.Properties.Resources.user_zoom;
            this.btnSearch.ImageSize = new System.Drawing.Size(45, 45);
            this.btnSearch.Location = new System.Drawing.Point(485, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Size = new System.Drawing.Size(60, 49);
            this.btnSearch.TabIndex = 57;
            this.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.AnimationHoverSpeed = 0.07F;
            this.btnAddNewUser.AnimationSpeed = 0.03F;
            this.btnAddNewUser.BaseColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.BorderColor = System.Drawing.Color.Maroon;
            this.btnAddNewUser.BorderSize = 2;
            this.btnAddNewUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddNewUser.Image = global::DVLD_First.Properties.Resources.user_add;
            this.btnAddNewUser.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAddNewUser.Location = new System.Drawing.Point(553, 14);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnAddNewUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNewUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.OnHoverImage = null;
            this.btnAddNewUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddNewUser.Size = new System.Drawing.Size(60, 49);
            this.btnAddNewUser.TabIndex = 56;
            this.btnAddNewUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "Filter By";
            // 
            // tbSearchedText
            // 
            this.tbSearchedText.Location = new System.Drawing.Point(255, 21);
            this.tbSearchedText.Multiline = true;
            this.tbSearchedText.Name = "tbSearchedText";
            this.tbSearchedText.Size = new System.Drawing.Size(183, 26);
            this.tbSearchedText.TabIndex = 54;
            // 
            // cbFiltering
            // 
            this.cbFiltering.Enabled = false;
            this.cbFiltering.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltering.FormattingEnabled = true;
            this.cbFiltering.Items.AddRange(new object[] {
            "NationalNo"});
            this.cbFiltering.Location = new System.Drawing.Point(79, 21);
            this.cbFiltering.Name = "cbFiltering";
            this.cbFiltering.Size = new System.Drawing.Size(170, 26);
            this.cbFiltering.TabIndex = 53;
            this.cbFiltering.Text = "National No";
            // 
            // ApplicationInfo
            // 
            this.ApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.ApplicationInfo.Controls.Add(this.lblApplicationFees);
            this.ApplicationInfo.Controls.Add(this.lblUsername);
            this.ApplicationInfo.Controls.Add(this.cbLicenseClasses);
            this.ApplicationInfo.Controls.Add(this.gunaImageRadioButton5);
            this.ApplicationInfo.Controls.Add(this.gunaImageRadioButton2);
            this.ApplicationInfo.Controls.Add(this.label3);
            this.ApplicationInfo.Controls.Add(this.label1);
            this.ApplicationInfo.Controls.Add(this.label10);
            this.ApplicationInfo.Controls.Add(this.lblD_L_ApplicationID);
            this.ApplicationInfo.Controls.Add(this.label9);
            this.ApplicationInfo.Controls.Add(this.label8);
            this.ApplicationInfo.Controls.Add(this.gunaImageRadioButton1);
            this.ApplicationInfo.Controls.Add(this.gunaImageRadioButton4);
            this.ApplicationInfo.Controls.Add(this.gunaImageRadioButton3);
            this.ApplicationInfo.Location = new System.Drawing.Point(4, 23);
            this.ApplicationInfo.Name = "ApplicationInfo";
            this.ApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.ApplicationInfo.Size = new System.Drawing.Size(900, 434);
            this.ApplicationInfo.TabIndex = 1;
            this.ApplicationInfo.Text = "Application Info";
            this.ApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.Location = new System.Drawing.Point(306, 126);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(36, 19);
            this.lblApplicationDate.TabIndex = 73;
            this.lblApplicationDate.Text = "???";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.Location = new System.Drawing.Point(306, 196);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(36, 19);
            this.lblApplicationFees.TabIndex = 72;
            this.lblApplicationFees.Text = "???";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(306, 231);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(36, 19);
            this.lblUsername.TabIndex = 71;
            this.lblUsername.Text = "???";
            // 
            // cbLicenseClasses
            // 
            this.cbLicenseClasses.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLicenseClasses.FormattingEnabled = true;
            this.cbLicenseClasses.Location = new System.Drawing.Point(310, 157);
            this.cbLicenseClasses.Name = "cbLicenseClasses";
            this.cbLicenseClasses.Size = new System.Drawing.Size(314, 26);
            this.cbLicenseClasses.TabIndex = 70;
            this.cbLicenseClasses.SelectedIndexChanged += new System.EventHandler(this.cbLicenseClasses_SelectedIndexChanged);
            // 
            // gunaImageRadioButton5
            // 
            this.gunaImageRadioButton5.BackgroundImage = global::DVLD_First.Properties.Resources.money;
            this.gunaImageRadioButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageRadioButton5.ImageCheckedOff = null;
            this.gunaImageRadioButton5.ImageCheckedOn = null;
            this.gunaImageRadioButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageRadioButton5.Location = new System.Drawing.Point(262, 193);
            this.gunaImageRadioButton5.Name = "gunaImageRadioButton5";
            this.gunaImageRadioButton5.Size = new System.Drawing.Size(24, 24);
            this.gunaImageRadioButton5.TabIndex = 69;
            // 
            // gunaImageRadioButton2
            // 
            this.gunaImageRadioButton2.BackgroundImage = global::DVLD_First.Properties.Resources.user__1_;
            this.gunaImageRadioButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageRadioButton2.ImageCheckedOff = null;
            this.gunaImageRadioButton2.ImageCheckedOn = null;
            this.gunaImageRadioButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageRadioButton2.Location = new System.Drawing.Point(262, 228);
            this.gunaImageRadioButton2.Name = "gunaImageRadioButton2";
            this.gunaImageRadioButton2.Size = new System.Drawing.Size(24, 24);
            this.gunaImageRadioButton2.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 67;
            this.label3.Text = "Created By:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 62;
            this.label1.Text = "Application Fees:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(73, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 19);
            this.label10.TabIndex = 57;
            this.label10.Text = "Application Date:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblD_L_ApplicationID
            // 
            this.lblD_L_ApplicationID.AutoSize = true;
            this.lblD_L_ApplicationID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD_L_ApplicationID.Location = new System.Drawing.Point(306, 91);
            this.lblD_L_ApplicationID.Name = "lblD_L_ApplicationID";
            this.lblD_L_ApplicationID.Size = new System.Drawing.Size(36, 19);
            this.lblD_L_ApplicationID.TabIndex = 55;
            this.lblD_L_ApplicationID.Text = "???";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(73, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 19);
            this.label9.TabIndex = 54;
            this.label9.Text = "License Class:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(73, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 19);
            this.label8.TabIndex = 53;
            this.label8.Text = "D.L.Application ID :";
            // 
            // gunaImageRadioButton1
            // 
            this.gunaImageRadioButton1.BackgroundImage = global::DVLD_First.Properties.Resources.id__1_;
            this.gunaImageRadioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageRadioButton1.ImageCheckedOff = null;
            this.gunaImageRadioButton1.ImageCheckedOn = null;
            this.gunaImageRadioButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageRadioButton1.Location = new System.Drawing.Point(262, 158);
            this.gunaImageRadioButton1.Name = "gunaImageRadioButton1";
            this.gunaImageRadioButton1.Size = new System.Drawing.Size(24, 24);
            this.gunaImageRadioButton1.TabIndex = 64;
            // 
            // gunaImageRadioButton4
            // 
            this.gunaImageRadioButton4.BackgroundImage = global::DVLD_First.Properties.Resources.field_date;
            this.gunaImageRadioButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageRadioButton4.ImageCheckedOff = null;
            this.gunaImageRadioButton4.ImageCheckedOn = null;
            this.gunaImageRadioButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageRadioButton4.Location = new System.Drawing.Point(262, 123);
            this.gunaImageRadioButton4.Name = "gunaImageRadioButton4";
            this.gunaImageRadioButton4.Size = new System.Drawing.Size(24, 24);
            this.gunaImageRadioButton4.TabIndex = 60;
            // 
            // gunaImageRadioButton3
            // 
            this.gunaImageRadioButton3.BackgroundImage = global::DVLD_First.Properties.Resources.field_number;
            this.gunaImageRadioButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageRadioButton3.ImageCheckedOff = null;
            this.gunaImageRadioButton3.ImageCheckedOn = null;
            this.gunaImageRadioButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageRadioButton3.Location = new System.Drawing.Point(262, 88);
            this.gunaImageRadioButton3.Name = "gunaImageRadioButton3";
            this.gunaImageRadioButton3.Size = new System.Drawing.Size(24, 24);
            this.gunaImageRadioButton3.TabIndex = 59;
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
            this.btnClose.Location = new System.Drawing.Point(733, 470);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(86, 31);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BaseColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.BorderSize = 1;
            this.btnSave.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSave.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSave.CheckedForeColor = System.Drawing.Color.White;
            this.btnSave.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSave.CheckedImage")));
            this.btnSave.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::DVLD_First.Properties.Resources.diskette;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSave.Location = new System.Drawing.Point(825, 470);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrPersonDetails21
            // 
            this.ctrPersonDetails21.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrPersonDetails21.Location = new System.Drawing.Point(6, 81);
            this.ctrPersonDetails21.Name = "ctrPersonDetails21";
            this.ctrPersonDetails21.Size = new System.Drawing.Size(879, 318);
            this.ctrPersonDetails21.TabIndex = 58;
            // 
            // ctrAddNewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabAddNewLicense);
            this.Name = "ctrAddNewLicense";
            this.Size = new System.Drawing.Size(918, 503);
            this.Load += new System.EventHandler(this.ctrAddNewLicense_Load);
            this.tabAddNewLicense.ResumeLayout(false);
            this.PersonInfo.ResumeLayout(false);
            this.gbSearchAdd.ResumeLayout(false);
            this.gbSearchAdd.PerformLayout();
            this.ApplicationInfo.ResumeLayout(false);
            this.ApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAddNewLicense;
        private System.Windows.Forms.TabPage PersonInfo;
        private ctrPersonDetails2 ctrPersonDetails21;
        private Guna.UI.WinForms.GunaButton btnNext;
        private System.Windows.Forms.GroupBox gbSearchAdd;
        private Guna.UI.WinForms.GunaButton btnSearch;
        private Guna.UI.WinForms.GunaButton btnAddNewUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearchedText;
        private System.Windows.Forms.ComboBox cbFiltering;
        private System.Windows.Forms.TabPage ApplicationInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblD_L_ApplicationID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton1;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton4;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton3;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton5;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox cbLicenseClasses;
        private Guna.UI.WinForms.GunaAdvenceButton btnClose;
        private Guna.UI.WinForms.GunaAdvenceButton btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
