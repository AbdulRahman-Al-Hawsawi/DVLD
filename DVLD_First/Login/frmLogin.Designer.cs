namespace DVLD_First
{
    partial class frmLogin
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkRemeberMe = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.gunaImageRadioButton1 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.gunaImageRadioButton4 = new Guna.UI.WinForms.GunaImageRadioButton();
            this.btnPasswordVisible = new Guna.UI.WinForms.GunaImageRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(639, 152);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(238, 26);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Text = "2222";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(480, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 26);
            this.label9.TabIndex = 61;
            this.label9.Text = "Password:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(639, 110);
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(238, 26);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.Text = "user2";
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 64;
            this.label1.Text = "Username:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkRemeberMe
            // 
            this.chkRemeberMe.AutoSize = true;
            this.chkRemeberMe.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRemeberMe.Location = new System.Drawing.Point(639, 184);
            this.chkRemeberMe.Name = "chkRemeberMe";
            this.chkRemeberMe.Size = new System.Drawing.Size(166, 27);
            this.chkRemeberMe.TabIndex = 2;
            this.chkRemeberMe.Text = "Remember Me";
            this.chkRemeberMe.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(559, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 23);
            this.label2.TabIndex = 67;
            this.label2.Text = "Login to yuor account";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.AnimationHoverSpeed = 0.07F;
            this.btnLogin.AnimationSpeed = 0.03F;
            this.btnLogin.BaseColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderColor = System.Drawing.Color.Maroon;
            this.btnLogin.BorderSize = 2;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Image = global::DVLD_First.Properties.Resources.login;
            this.btnLogin.ImageSize = new System.Drawing.Size(45, 45);
            this.btnLogin.Location = new System.Drawing.Point(735, 237);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogin.OnHoverImage = null;
            this.btnLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogin.Size = new System.Drawing.Size(142, 44);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLogin.VisibleChanged += new System.EventHandler(this.btnLogin_VisibleChanged);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLD_First.Properties.Resources.LoginScreenImage;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-15, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 467);
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BackgroundImage = global::DVLD_First.Properties.Resources.closeBlack;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BaseColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.Maroon;
            this.btnClose.BorderSize = 2;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = null;
            this.btnClose.ImageSize = new System.Drawing.Size(45, 45);
            this.btnClose.Location = new System.Drawing.Point(884, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(42, 42);
            this.btnClose.TabIndex = 68;
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gunaImageRadioButton1
            // 
            this.gunaImageRadioButton1.BackgroundImage = global::DVLD_First.Properties.Resources.UserBlack;
            this.gunaImageRadioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageRadioButton1.ImageCheckedOff = null;
            this.gunaImageRadioButton1.ImageCheckedOn = null;
            this.gunaImageRadioButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaImageRadioButton1.Location = new System.Drawing.Point(589, 110);
            this.gunaImageRadioButton1.Name = "gunaImageRadioButton1";
            this.gunaImageRadioButton1.Size = new System.Drawing.Size(41, 24);
            this.gunaImageRadioButton1.TabIndex = 66;
            // 
            // gunaImageRadioButton4
            // 
            this.gunaImageRadioButton4.BackgroundImage = global::DVLD_First.Properties.Resources.password__1_;
            this.gunaImageRadioButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageRadioButton4.ImageCheckedOff = null;
            this.gunaImageRadioButton4.ImageCheckedOn = null;
            this.gunaImageRadioButton4.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaImageRadioButton4.Location = new System.Drawing.Point(589, 152);
            this.gunaImageRadioButton4.Name = "gunaImageRadioButton4";
            this.gunaImageRadioButton4.Size = new System.Drawing.Size(41, 24);
            this.gunaImageRadioButton4.TabIndex = 63;
            // 
            // btnPasswordVisible
            // 
            this.btnPasswordVisible.BackgroundImage = global::DVLD_First.Properties.Resources.UserBlack;
            this.btnPasswordVisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPasswordVisible.ImageCheckedOff = null;
            this.btnPasswordVisible.ImageCheckedOn = null;
            this.btnPasswordVisible.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPasswordVisible.Location = new System.Drawing.Point(836, 154);
            this.btnPasswordVisible.Name = "btnPasswordVisible";
            this.btnPasswordVisible.Size = new System.Drawing.Size(41, 24);
            this.btnPasswordVisible.TabIndex = 70;
            this.btnPasswordVisible.Visible = false;
            this.btnPasswordVisible.CheckedChanged += new System.EventHandler(this.btnPasswordVisible_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(928, 453);
            this.Controls.Add(this.btnPasswordVisible);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chkRemeberMe);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaImageRadioButton1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gunaImageRadioButton4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton4;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaImageRadioButton gunaImageRadioButton1;
        private System.Windows.Forms.CheckBox chkRemeberMe;
        private Guna.UI.WinForms.GunaButton btnLogin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI.WinForms.GunaButton btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaImageRadioButton btnPasswordVisible;
    }
}