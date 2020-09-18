namespace MyPasswords.WebFormsUI
{
    partial class MyPasswords
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
            this.gbxLogIn = new System.Windows.Forms.GroupBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnDeleteEmail = new System.Windows.Forms.Button();
            this.btnDeletePassword = new System.Windows.Forms.Button();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.btnAddPassword = new System.Windows.Forms.Button();
            this.btnAddEmail = new System.Windows.Forms.Button();
            this.lblSitePassword = new System.Windows.Forms.Label();
            this.lblSiteUserName = new System.Windows.Forms.Label();
            this.lblSiteName = new System.Windows.Forms.Label();
            this.tbxSitePassword = new System.Windows.Forms.TextBox();
            this.tbxSiteUserName = new System.Windows.Forms.TextBox();
            this.tbxSiteName = new System.Windows.Forms.TextBox();
            this.lblEmails = new System.Windows.Forms.Label();
            this.cbxEmails = new System.Windows.Forms.ComboBox();
            this.lblAddEmail = new System.Windows.Forms.Label();
            this.tbxEditEmail = new System.Windows.Forms.TextBox();
            this.dgwMyPasswords = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.gbxEmails = new System.Windows.Forms.GroupBox();
            this.gbxSites = new System.Windows.Forms.GroupBox();
            this.gbxLogIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMyPasswords)).BeginInit();
            this.gbxEmails.SuspendLayout();
            this.gbxSites.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLogIn
            // 
            this.gbxLogIn.BackColor = System.Drawing.SystemColors.Window;
            this.gbxLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbxLogIn.Controls.Add(this.btnLogIn);
            this.gbxLogIn.Controls.Add(this.btnSignUp);
            this.gbxLogIn.Controls.Add(this.tbxPassword);
            this.gbxLogIn.Controls.Add(this.tbxUserName);
            this.gbxLogIn.Controls.Add(this.lblPassword);
            this.gbxLogIn.Controls.Add(this.lblUserName);
            this.gbxLogIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxLogIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbxLogIn.Location = new System.Drawing.Point(407, 222);
            this.gbxLogIn.Name = "gbxLogIn";
            this.gbxLogIn.Size = new System.Drawing.Size(302, 193);
            this.gbxLogIn.TabIndex = 0;
            this.gbxLogIn.TabStop = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(175, 129);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 29);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "LogIn";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(65, 129);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 29);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "SignUp";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(140, 101);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(121, 22);
            this.tbxPassword.TabIndex = 3;
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(140, 68);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(121, 22);
            this.tbxUserName.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(48, 101);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(48, 68);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(73, 17);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Username";
            // 
            // btnDeleteEmail
            // 
            this.btnDeleteEmail.Location = new System.Drawing.Point(178, 48);
            this.btnDeleteEmail.Name = "btnDeleteEmail";
            this.btnDeleteEmail.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEmail.TabIndex = 20;
            this.btnDeleteEmail.Text = "Delete";
            this.btnDeleteEmail.UseVisualStyleBackColor = true;
            this.btnDeleteEmail.Click += new System.EventHandler(this.btnDeleteEmail_Click);
            // 
            // btnDeletePassword
            // 
            this.btnDeletePassword.Location = new System.Drawing.Point(679, 97);
            this.btnDeletePassword.Name = "btnDeletePassword";
            this.btnDeletePassword.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePassword.TabIndex = 19;
            this.btnDeletePassword.Text = "Delete";
            this.btnDeletePassword.UseVisualStyleBackColor = true;
            this.btnDeletePassword.Click += new System.EventHandler(this.btnDeletePassword_Click);
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Location = new System.Drawing.Point(679, 68);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePassword.TabIndex = 18;
            this.btnUpdatePassword.Text = "Update";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // btnAddPassword
            // 
            this.btnAddPassword.Location = new System.Drawing.Point(679, 37);
            this.btnAddPassword.Name = "btnAddPassword";
            this.btnAddPassword.Size = new System.Drawing.Size(75, 23);
            this.btnAddPassword.TabIndex = 17;
            this.btnAddPassword.Text = "Add";
            this.btnAddPassword.UseVisualStyleBackColor = true;
            this.btnAddPassword.Click += new System.EventHandler(this.btnAddPassword_Click);
            // 
            // btnAddEmail
            // 
            this.btnAddEmail.Location = new System.Drawing.Point(85, 48);
            this.btnAddEmail.Name = "btnAddEmail";
            this.btnAddEmail.Size = new System.Drawing.Size(75, 23);
            this.btnAddEmail.TabIndex = 16;
            this.btnAddEmail.Text = "Add";
            this.btnAddEmail.UseVisualStyleBackColor = true;
            this.btnAddEmail.Click += new System.EventHandler(this.btnAddEmail_Click);
            // 
            // lblSitePassword
            // 
            this.lblSitePassword.AutoSize = true;
            this.lblSitePassword.Location = new System.Drawing.Point(431, 76);
            this.lblSitePassword.Name = "lblSitePassword";
            this.lblSitePassword.Size = new System.Drawing.Size(37, 17);
            this.lblSitePassword.TabIndex = 15;
            this.lblSitePassword.Text = "Şifre";
            // 
            // lblSiteUserName
            // 
            this.lblSiteUserName.AutoSize = true;
            this.lblSiteUserName.Location = new System.Drawing.Point(79, 77);
            this.lblSiteUserName.Name = "lblSiteUserName";
            this.lblSiteUserName.Size = new System.Drawing.Size(84, 17);
            this.lblSiteUserName.TabIndex = 14;
            this.lblSiteUserName.Text = "Kullanıcı Adı";
            // 
            // lblSiteName
            // 
            this.lblSiteName.AutoSize = true;
            this.lblSiteName.Location = new System.Drawing.Point(20, 37);
            this.lblSiteName.Name = "lblSiteName";
            this.lblSiteName.Size = new System.Drawing.Size(56, 17);
            this.lblSiteName.TabIndex = 13;
            this.lblSiteName.Text = "Site Adı";
            // 
            // tbxSitePassword
            // 
            this.tbxSitePassword.Location = new System.Drawing.Point(431, 96);
            this.tbxSitePassword.Name = "tbxSitePassword";
            this.tbxSitePassword.Size = new System.Drawing.Size(233, 22);
            this.tbxSitePassword.TabIndex = 12;
            // 
            // tbxSiteUserName
            // 
            this.tbxSiteUserName.Location = new System.Drawing.Point(82, 97);
            this.tbxSiteUserName.Name = "tbxSiteUserName";
            this.tbxSiteUserName.Size = new System.Drawing.Size(343, 22);
            this.tbxSiteUserName.TabIndex = 11;
            // 
            // tbxSiteName
            // 
            this.tbxSiteName.Location = new System.Drawing.Point(82, 37);
            this.tbxSiteName.Name = "tbxSiteName";
            this.tbxSiteName.Size = new System.Drawing.Size(582, 22);
            this.tbxSiteName.TabIndex = 10;
            // 
            // lblEmails
            // 
            this.lblEmails.AutoSize = true;
            this.lblEmails.Location = new System.Drawing.Point(30, 105);
            this.lblEmails.Name = "lblEmails";
            this.lblEmails.Size = new System.Drawing.Size(49, 17);
            this.lblEmails.TabIndex = 9;
            this.lblEmails.Text = "Emails";
            // 
            // cbxEmails
            // 
            this.cbxEmails.FormattingEnabled = true;
            this.cbxEmails.Location = new System.Drawing.Point(85, 102);
            this.cbxEmails.Name = "cbxEmails";
            this.cbxEmails.Size = new System.Drawing.Size(168, 24);
            this.cbxEmails.TabIndex = 8;
            this.cbxEmails.SelectedIndexChanged += new System.EventHandler(this.cbxEmails_SelectedIndexChanged);
            // 
            // lblAddEmail
            // 
            this.lblAddEmail.AutoSize = true;
            this.lblAddEmail.Location = new System.Drawing.Point(9, 23);
            this.lblAddEmail.Name = "lblAddEmail";
            this.lblAddEmail.Size = new System.Drawing.Size(70, 17);
            this.lblAddEmail.TabIndex = 7;
            this.lblAddEmail.Text = "Edit Email";
            // 
            // tbxEditEmail
            // 
            this.tbxEditEmail.Location = new System.Drawing.Point(85, 20);
            this.tbxEditEmail.Name = "tbxEditEmail";
            this.tbxEditEmail.Size = new System.Drawing.Size(168, 22);
            this.tbxEditEmail.TabIndex = 6;
            // 
            // dgwMyPasswords
            // 
            this.dgwMyPasswords.AllowUserToOrderColumns = true;
            this.dgwMyPasswords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMyPasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMyPasswords.Location = new System.Drawing.Point(28, 167);
            this.dgwMyPasswords.Name = "dgwMyPasswords";
            this.dgwMyPasswords.RowHeadersWidth = 51;
            this.dgwMyPasswords.RowTemplate.Height = 24;
            this.dgwMyPasswords.Size = new System.Drawing.Size(1122, 456);
            this.dgwMyPasswords.TabIndex = 1;
            this.dgwMyPasswords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMyPasswords_CellClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1059, 638);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(91, 35);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // gbxEmails
            // 
            this.gbxEmails.Controls.Add(this.btnDeleteEmail);
            this.gbxEmails.Controls.Add(this.lblEmails);
            this.gbxEmails.Controls.Add(this.cbxEmails);
            this.gbxEmails.Controls.Add(this.lblAddEmail);
            this.gbxEmails.Controls.Add(this.tbxEditEmail);
            this.gbxEmails.Controls.Add(this.btnAddEmail);
            this.gbxEmails.Location = new System.Drawing.Point(28, 12);
            this.gbxEmails.Name = "gbxEmails";
            this.gbxEmails.Size = new System.Drawing.Size(269, 137);
            this.gbxEmails.TabIndex = 21;
            this.gbxEmails.TabStop = false;
            // 
            // gbxSites
            // 
            this.gbxSites.Controls.Add(this.btnDeletePassword);
            this.gbxSites.Controls.Add(this.tbxSiteName);
            this.gbxSites.Controls.Add(this.tbxSiteUserName);
            this.gbxSites.Controls.Add(this.btnUpdatePassword);
            this.gbxSites.Controls.Add(this.tbxSitePassword);
            this.gbxSites.Controls.Add(this.btnAddPassword);
            this.gbxSites.Controls.Add(this.lblSiteName);
            this.gbxSites.Controls.Add(this.lblSiteUserName);
            this.gbxSites.Controls.Add(this.lblSitePassword);
            this.gbxSites.Location = new System.Drawing.Point(303, 12);
            this.gbxSites.Name = "gbxSites";
            this.gbxSites.Size = new System.Drawing.Size(847, 137);
            this.gbxSites.TabIndex = 22;
            this.gbxSites.TabStop = false;
            // 
            // MyPasswords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1162, 685);
            this.Controls.Add(this.gbxSites);
            this.Controls.Add(this.gbxEmails);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.gbxLogIn);
            this.Controls.Add(this.dgwMyPasswords);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MyPasswords";
            this.Text = "MyPasswords";
            this.Load += new System.EventHandler(this.MyPasswords_Load);
            this.gbxLogIn.ResumeLayout(false);
            this.gbxLogIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMyPasswords)).EndInit();
            this.gbxEmails.ResumeLayout(false);
            this.gbxEmails.PerformLayout();
            this.gbxSites.ResumeLayout(false);
            this.gbxSites.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogIn;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblEmails;
        private System.Windows.Forms.ComboBox cbxEmails;
        private System.Windows.Forms.Label lblAddEmail;
        private System.Windows.Forms.TextBox tbxEditEmail;
        private System.Windows.Forms.Button btnDeletePassword;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Button btnAddPassword;
        private System.Windows.Forms.Button btnAddEmail;
        private System.Windows.Forms.Label lblSitePassword;
        private System.Windows.Forms.Label lblSiteUserName;
        private System.Windows.Forms.Label lblSiteName;
        private System.Windows.Forms.TextBox tbxSitePassword;
        private System.Windows.Forms.TextBox tbxSiteUserName;
        private System.Windows.Forms.TextBox tbxSiteName;
        private System.Windows.Forms.DataGridView dgwMyPasswords;
        private System.Windows.Forms.Button btnDeleteEmail;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox gbxEmails;
        private System.Windows.Forms.GroupBox gbxSites;
    }
}

