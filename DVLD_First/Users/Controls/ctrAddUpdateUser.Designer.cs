namespace DVLD_First.Controls
{
    partial class ctrAddUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrAddUpdateUser));
            this.tabAddNewUser = new System.Windows.Forms.TabControl();
            this.PersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI.WinForms.GunaButton();
            this.gbSearchAdd = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearchedText = new System.Windows.Forms.TextBox();
            this.cbFiltering = new System.Windows.Forms.ComboBox();
            this.LoginInfo = new System.Windows.Forms.TabPage();
            this.chIsActive = new System.Windows.Forms.CheckBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrPersonDetails21 = new DVLD_First.Controls.ctrPersonDetails2();
            this.btnClose = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSearch = new Guna.UI.WinForms.GunaButton();
            this.btnAddNewUser = new Guna.UI.WinForms.GunaButton();
            this.btnGenerateUserName = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaImageRadioButton1 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.gunaImageRadioButton4 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.gunaImageRadioButton3 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.tabAddNewUser.SuspendLayout();
            this.PersonInfo.SuspendLayout();
            this.gbSearchAdd.SuspendLayout();
            this.LoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAddNewUser
            // 
            this.tabAddNewUser.Controls.Add(this.PersonInfo);
            this.tabAddNewUser.Controls.Add(this.LoginInfo);
            this.tabAddNewUser.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAddNewUser.Location = new System.Drawing.Point(4, 32);
            this.tabAddNewUser.Name = "tabAddNewUser";
            this.tabAddNewUser.SelectedIndex = 0;
            this.tabAddNewUser.Size = new System.Drawing.Size(908, 461);
            this.tabAddNewUser.TabIndex = 0;
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
            this.tbSearchedText.TextChanged += new System.EventHandler(this.tbSearchedText_TextChanged);
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
            // LoginInfo
            // 
            this.LoginInfo.Controls.Add(this.btnGenerateUserName);
            this.LoginInfo.Controls.Add(this.chIsActive);
            this.LoginInfo.Controls.Add(this.tbConfirmPassword);
            this.LoginInfo.Controls.Add(this.label1);
            this.LoginInfo.Controls.Add(this.tbPassword);
            this.LoginInfo.Controls.Add(this.label10);
            this.LoginInfo.Controls.Add(this.tbUserName);
            this.LoginInfo.Controls.Add(this.lblUserID);
            this.LoginInfo.Controls.Add(this.label9);
            this.LoginInfo.Controls.Add(this.label8);
            this.LoginInfo.Controls.Add(this.gunaImageRadioButton1);
            this.LoginInfo.Controls.Add(this.gunaImageRadioButton4);
            this.LoginInfo.Controls.Add(this.gunaImageRadioButton3);
            this.LoginInfo.Location = new System.Drawing.Point(4, 23);
            this.LoginInfo.Name = "LoginInfo";
            this.LoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.LoginInfo.Size = new System.Drawing.Size(900, 434);
            this.LoginInfo.TabIndex = 1;
            this.LoginInfo.Text = "Login Info";
            this.LoginInfo.UseVisualStyleBackColor = true;
            // 
            // chIsActive
            // 
            this.chIsActive.AutoSize = true;
            this.chIsActive.Location = new System.Drawing.Point(246, 250);
            this.chIsActive.Name = "chIsActive";
            this.chIsActive.Size = new System.Drawing.Size(77, 18);
            this.chIsActive.TabIndex = 66;
            this.chIsActive.Text = "is Active";
            this.chIsActive.UseVisualStyleBackColor = true;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmPassword.Location = new System.Drawing.Point(246, 205);
            this.tbConfirmPassword.Multiline = true;
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(120, 26);
            this.tbConfirmPassword.TabIndex = 63;
            this.tbConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbConfirmPassword.TextChanged += new System.EventHandler(this.tbConfirmPassword_TextChanged);
            this.tbConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbConfirmPassword_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 62;
            this.label1.Text = "Confirm Password:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(246, 167);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(120, 26);
            this.tbPassword.TabIndex = 58;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(94, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 19);
            this.label10.TabIndex = 57;
            this.label10.Text = "Username:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(246, 125);
            this.tbUserName.Multiline = true;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(120, 26);
            this.tbUserName.TabIndex = 56;
            this.tbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUserName.Validating += new System.ComponentModel.CancelEventHandler(this.tbUserName_Validating);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(246, 88);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(36, 19);
            this.lblUserID.TabIndex = 55;
            this.lblUserID.Text = "???";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(84, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 26);
            this.label9.TabIndex = 54;
            this.label9.Text = "Password:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(112, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 53;
            this.label8.Text = "User ID :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(418, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 25);
            this.lblTitle.TabIndex = 56;
            this.lblTitle.Text = "[????]";
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
            this.btnClose.Location = new System.Drawing.Point(730, 495);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(86, 31);
            this.btnClose.TabIndex = 45;
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
            this.btnSave.Location = new System.Drawing.Point(822, 495);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // btnGenerateUserName
            // 
            this.btnGenerateUserName.AnimationHoverSpeed = 0.07F;
            this.btnGenerateUserName.AnimationSpeed = 0.03F;
            this.btnGenerateUserName.BaseColor = System.Drawing.Color.Transparent;
            this.btnGenerateUserName.BorderColor = System.Drawing.Color.Black;
            this.btnGenerateUserName.BorderSize = 1;
            this.btnGenerateUserName.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnGenerateUserName.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnGenerateUserName.CheckedForeColor = System.Drawing.Color.White;
            this.btnGenerateUserName.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnGenerateUserName.CheckedImage")));
            this.btnGenerateUserName.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnGenerateUserName.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGenerateUserName.FocusedColor = System.Drawing.Color.Empty;
            this.btnGenerateUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateUserName.ForeColor = System.Drawing.Color.Black;
            this.btnGenerateUserName.Image = global::DVLD_First.Properties.Resources.gear;
            this.btnGenerateUserName.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGenerateUserName.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnGenerateUserName.Location = new System.Drawing.Point(404, 125);
            this.btnGenerateUserName.Name = "btnGenerateUserName";
            this.btnGenerateUserName.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnGenerateUserName.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGenerateUserName.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnGenerateUserName.OnHoverImage = null;
            this.btnGenerateUserName.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnGenerateUserName.OnPressedColor = System.Drawing.Color.Black;
            this.btnGenerateUserName.Size = new System.Drawing.Size(160, 26);
            this.btnGenerateUserName.TabIndex = 57;
            this.btnGenerateUserName.Text = "Generate Username";
            this.btnGenerateUserName.Click += new System.EventHandler(this.btnGenerateUserName_Click);
            // 
            // gunaImageRadioButton1
            // 
            this.gunaImageRadioButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaImageRadioButton1.BackgroundImage")));
            this.gunaImageRadioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageRadioButton1.ImageCheckedOff = null;
            this.gunaImageRadioButton1.ImageCheckedOn = null;
            this.gunaImageRadioButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageRadioButton1.Location = new System.Drawing.Point(216, 206);
            this.gunaImageRadioButton1.Name = "gunaImageRadioButton1";
            this.gunaImageRadioButton1.Size = new System.Drawing.Size(24, 24);
            this.gunaImageRadioButton1.TabIndex = 64;
            // 
            // gunaImageRadioButton4
            // 
            this.gunaImageRadioButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaImageRadioButton4.BackgroundImage")));
            this.gunaImageRadioButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageRadioButton4.ImageCheckedOff = null;
            this.gunaImageRadioButton4.ImageCheckedOn = null;
            this.gunaImageRadioButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageRadioButton4.Location = new System.Drawing.Point(216, 168);
            this.gunaImageRadioButton4.Name = "gunaImageRadioButton4";
            this.gunaImageRadioButton4.Size = new System.Drawing.Size(24, 24);
            this.gunaImageRadioButton4.TabIndex = 60;
            // 
            // gunaImageRadioButton3
            // 
            this.gunaImageRadioButton3.BackgroundImage = global::DVLD_First.Properties.Resources.UserGray;
            this.gunaImageRadioButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageRadioButton3.ImageCheckedOff = null;
            this.gunaImageRadioButton3.ImageCheckedOn = null;
            this.gunaImageRadioButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageRadioButton3.Location = new System.Drawing.Point(216, 126);
            this.gunaImageRadioButton3.Name = "gunaImageRadioButton3";
            this.gunaImageRadioButton3.Size = new System.Drawing.Size(24, 24);
            this.gunaImageRadioButton3.TabIndex = 59;
            // 
            // ctrAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabAddNewUser);
            this.Name = "ctrAddUpdateUser";
            this.Size = new System.Drawing.Size(914, 529);
            this.tabAddNewUser.ResumeLayout(false);
            this.PersonInfo.ResumeLayout(false);
            this.gbSearchAdd.ResumeLayout(false);
            this.gbSearchAdd.PerformLayout();
            this.LoginInfo.ResumeLayout(false);
            this.LoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabAddNewUser;
        private System.Windows.Forms.TabPage PersonInfo;
        private System.Windows.Forms.TabPage LoginInfo;
        private System.Windows.Forms.GroupBox gbSearchAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearchedText;
        private System.Windows.Forms.ComboBox cbFiltering;
        private Guna.UI.WinForms.GunaButton btnNext;
        private Guna.UI.WinForms.GunaButton btnSearch;
        private Guna.UI.WinForms.GunaButton btnAddNewUser;
        private ctrPersonDetails2 ctrPersonDetails21;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton1;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton4;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chIsActive;
        private Guna.UI.WinForms.GunaAdvenceButton btnClose;
        private Guna.UI.WinForms.GunaAdvenceButton btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI.WinForms.GunaAdvenceButton btnGenerateUserName;
    }
}
