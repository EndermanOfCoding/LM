namespace Library_Management_System
{
    partial class MyInformation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mChangePasswordBtn = new MetroFramework.Controls.MetroButton();
            this.mUserID = new System.Windows.Forms.Label();
            this.mViewBookBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mLogoutBtn = new MetroFramework.Controls.MetroButton();
            this.mMyInformationBtn = new MetroFramework.Controls.MetroButton();
            this.mCurrentBorrowBtn = new MetroFramework.Controls.MetroButton();
            this.mDashboardBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.fullnameTF = new MetroFramework.Controls.MetroTextBox();
            this.genderTF = new MetroFramework.Controls.MetroTextBox();
            this.dobTF = new MetroFramework.Controls.MetroTextBox();
            this.emailTF = new MetroFramework.Controls.MetroTextBox();
            this.phoneTF = new MetroFramework.Controls.MetroTextBox();
            this.addressTF = new System.Windows.Forms.RichTextBox();
            this.uploadStudentPic = new System.Windows.Forms.PictureBox();
            this.pictureBoxAdmin = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadStudentPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBoxAdmin);
            this.panel1.Controls.Add(this.mChangePasswordBtn);
            this.panel1.Controls.Add(this.mUserID);
            this.panel1.Controls.Add(this.mViewBookBtn);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.mLogoutBtn);
            this.panel1.Controls.Add(this.mMyInformationBtn);
            this.panel1.Controls.Add(this.mCurrentBorrowBtn);
            this.panel1.Controls.Add(this.mDashboardBtn);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 578);
            this.panel1.TabIndex = 55;
            // 
            // mChangePasswordBtn
            // 
            this.mChangePasswordBtn.Location = new System.Drawing.Point(0, 443);
            this.mChangePasswordBtn.Name = "mChangePasswordBtn";
            this.mChangePasswordBtn.Size = new System.Drawing.Size(200, 52);
            this.mChangePasswordBtn.TabIndex = 7;
            this.mChangePasswordBtn.Text = "Change Password";
            this.mChangePasswordBtn.UseSelectable = true;
            this.mChangePasswordBtn.Click += new System.EventHandler(this.mChangePasswordBtn_Click);
            // 
            // mUserID
            // 
            this.mUserID.AutoSize = true;
            this.mUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mUserID.Location = new System.Drawing.Point(69, 136);
            this.mUserID.Name = "mUserID";
            this.mUserID.Size = new System.Drawing.Size(49, 24);
            this.mUserID.TabIndex = 6;
            this.mUserID.Text = "User";
            // 
            // mViewBookBtn
            // 
            this.mViewBookBtn.Location = new System.Drawing.Point(0, 233);
            this.mViewBookBtn.Name = "mViewBookBtn";
            this.mViewBookBtn.Size = new System.Drawing.Size(200, 52);
            this.mViewBookBtn.TabIndex = 4;
            this.mViewBookBtn.Text = "View Book";
            this.mViewBookBtn.UseSelectable = true;
            this.mViewBookBtn.Click += new System.EventHandler(this.mViewBookBtn_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(58, 8);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(77, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "WELCOME";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // mLogoutBtn
            // 
            this.mLogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mLogoutBtn.Location = new System.Drawing.Point(0, 513);
            this.mLogoutBtn.Name = "mLogoutBtn";
            this.mLogoutBtn.Size = new System.Drawing.Size(200, 52);
            this.mLogoutBtn.TabIndex = 3;
            this.mLogoutBtn.Text = "Logout";
            this.mLogoutBtn.UseSelectable = true;
            this.mLogoutBtn.Click += new System.EventHandler(this.mLogoutBtn_Click);
            // 
            // mMyInformationBtn
            // 
            this.mMyInformationBtn.Location = new System.Drawing.Point(0, 373);
            this.mMyInformationBtn.Name = "mMyInformationBtn";
            this.mMyInformationBtn.Size = new System.Drawing.Size(200, 52);
            this.mMyInformationBtn.TabIndex = 2;
            this.mMyInformationBtn.Text = "My Information";
            this.mMyInformationBtn.UseSelectable = true;
            // 
            // mCurrentBorrowBtn
            // 
            this.mCurrentBorrowBtn.Location = new System.Drawing.Point(0, 303);
            this.mCurrentBorrowBtn.Name = "mCurrentBorrowBtn";
            this.mCurrentBorrowBtn.Size = new System.Drawing.Size(200, 52);
            this.mCurrentBorrowBtn.TabIndex = 1;
            this.mCurrentBorrowBtn.Text = "Current Borrow";
            this.mCurrentBorrowBtn.UseSelectable = true;
            this.mCurrentBorrowBtn.Click += new System.EventHandler(this.mCurrentBorrowBtn_Click);
            // 
            // mDashboardBtn
            // 
            this.mDashboardBtn.Location = new System.Drawing.Point(0, 163);
            this.mDashboardBtn.Name = "mDashboardBtn";
            this.mDashboardBtn.Size = new System.Drawing.Size(200, 52);
            this.mDashboardBtn.TabIndex = 0;
            this.mDashboardBtn.Text = "Dashboard";
            this.mDashboardBtn.UseSelectable = true;
            this.mDashboardBtn.Click += new System.EventHandler(this.mDashboardBtn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(241, 194);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 56;
            this.metroLabel1.Text = "Gender :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(209, 284);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(91, 19);
            this.metroLabel2.TabIndex = 57;
            this.metroLabel2.Text = "Date of Birth :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(237, 374);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 58;
            this.metroLabel3.Text = "Address :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(252, 464);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 19);
            this.metroLabel4.TabIndex = 59;
            this.metroLabel4.Text = "Email :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(247, 554);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(53, 19);
            this.metroLabel6.TabIndex = 60;
            this.metroLabel6.Text = "Phone :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(224, 104);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(76, 19);
            this.metroLabel7.TabIndex = 61;
            this.metroLabel7.Text = "Full Name :";
            // 
            // fullnameTF
            // 
            // 
            // 
            // 
            this.fullnameTF.CustomButton.Image = null;
            this.fullnameTF.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.fullnameTF.CustomButton.Name = "";
            this.fullnameTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fullnameTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fullnameTF.CustomButton.TabIndex = 1;
            this.fullnameTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fullnameTF.CustomButton.UseSelectable = true;
            this.fullnameTF.CustomButton.Visible = false;
            this.fullnameTF.Lines = new string[0];
            this.fullnameTF.Location = new System.Drawing.Point(306, 100);
            this.fullnameTF.MaxLength = 32767;
            this.fullnameTF.Name = "fullnameTF";
            this.fullnameTF.PasswordChar = '\0';
            this.fullnameTF.ReadOnly = true;
            this.fullnameTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fullnameTF.SelectedText = "";
            this.fullnameTF.SelectionLength = 0;
            this.fullnameTF.SelectionStart = 0;
            this.fullnameTF.ShortcutsEnabled = true;
            this.fullnameTF.Size = new System.Drawing.Size(209, 23);
            this.fullnameTF.TabIndex = 62;
            this.fullnameTF.UseSelectable = true;
            this.fullnameTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fullnameTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // genderTF
            // 
            // 
            // 
            // 
            this.genderTF.CustomButton.Image = null;
            this.genderTF.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.genderTF.CustomButton.Name = "";
            this.genderTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.genderTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.genderTF.CustomButton.TabIndex = 1;
            this.genderTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.genderTF.CustomButton.UseSelectable = true;
            this.genderTF.CustomButton.Visible = false;
            this.genderTF.Lines = new string[0];
            this.genderTF.Location = new System.Drawing.Point(306, 194);
            this.genderTF.MaxLength = 32767;
            this.genderTF.Name = "genderTF";
            this.genderTF.PasswordChar = '\0';
            this.genderTF.ReadOnly = true;
            this.genderTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.genderTF.SelectedText = "";
            this.genderTF.SelectionLength = 0;
            this.genderTF.SelectionStart = 0;
            this.genderTF.ShortcutsEnabled = true;
            this.genderTF.Size = new System.Drawing.Size(209, 23);
            this.genderTF.TabIndex = 63;
            this.genderTF.UseSelectable = true;
            this.genderTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.genderTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dobTF
            // 
            // 
            // 
            // 
            this.dobTF.CustomButton.Image = null;
            this.dobTF.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.dobTF.CustomButton.Name = "";
            this.dobTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dobTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dobTF.CustomButton.TabIndex = 1;
            this.dobTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dobTF.CustomButton.UseSelectable = true;
            this.dobTF.CustomButton.Visible = false;
            this.dobTF.Lines = new string[0];
            this.dobTF.Location = new System.Drawing.Point(306, 280);
            this.dobTF.MaxLength = 32767;
            this.dobTF.Name = "dobTF";
            this.dobTF.PasswordChar = '\0';
            this.dobTF.ReadOnly = true;
            this.dobTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dobTF.SelectedText = "";
            this.dobTF.SelectionLength = 0;
            this.dobTF.SelectionStart = 0;
            this.dobTF.ShortcutsEnabled = true;
            this.dobTF.Size = new System.Drawing.Size(209, 23);
            this.dobTF.TabIndex = 64;
            this.dobTF.UseSelectable = true;
            this.dobTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dobTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // emailTF
            // 
            // 
            // 
            // 
            this.emailTF.CustomButton.Image = null;
            this.emailTF.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.emailTF.CustomButton.Name = "";
            this.emailTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emailTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailTF.CustomButton.TabIndex = 1;
            this.emailTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailTF.CustomButton.UseSelectable = true;
            this.emailTF.CustomButton.Visible = false;
            this.emailTF.Lines = new string[0];
            this.emailTF.Location = new System.Drawing.Point(306, 466);
            this.emailTF.MaxLength = 32767;
            this.emailTF.Name = "emailTF";
            this.emailTF.PasswordChar = '\0';
            this.emailTF.ReadOnly = true;
            this.emailTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTF.SelectedText = "";
            this.emailTF.SelectionLength = 0;
            this.emailTF.SelectionStart = 0;
            this.emailTF.ShortcutsEnabled = true;
            this.emailTF.Size = new System.Drawing.Size(209, 23);
            this.emailTF.TabIndex = 65;
            this.emailTF.UseSelectable = true;
            this.emailTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // phoneTF
            // 
            // 
            // 
            // 
            this.phoneTF.CustomButton.Image = null;
            this.phoneTF.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.phoneTF.CustomButton.Name = "";
            this.phoneTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.phoneTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.phoneTF.CustomButton.TabIndex = 1;
            this.phoneTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.phoneTF.CustomButton.UseSelectable = true;
            this.phoneTF.CustomButton.Visible = false;
            this.phoneTF.Lines = new string[0];
            this.phoneTF.Location = new System.Drawing.Point(306, 554);
            this.phoneTF.MaxLength = 32767;
            this.phoneTF.Name = "phoneTF";
            this.phoneTF.PasswordChar = '\0';
            this.phoneTF.ReadOnly = true;
            this.phoneTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phoneTF.SelectedText = "";
            this.phoneTF.SelectionLength = 0;
            this.phoneTF.SelectionStart = 0;
            this.phoneTF.ShortcutsEnabled = true;
            this.phoneTF.Size = new System.Drawing.Size(209, 23);
            this.phoneTF.TabIndex = 66;
            this.phoneTF.UseSelectable = true;
            this.phoneTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.phoneTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addressTF
            // 
            this.addressTF.Location = new System.Drawing.Point(306, 332);
            this.addressTF.Name = "addressTF";
            this.addressTF.ReadOnly = true;
            this.addressTF.Size = new System.Drawing.Size(209, 96);
            this.addressTF.TabIndex = 67;
            this.addressTF.Text = "";
            // 
            // uploadStudentPic
            // 
            this.uploadStudentPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uploadStudentPic.Location = new System.Drawing.Point(533, 100);
            this.uploadStudentPic.Name = "uploadStudentPic";
            this.uploadStudentPic.Size = new System.Drawing.Size(156, 117);
            this.uploadStudentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uploadStudentPic.TabIndex = 68;
            this.uploadStudentPic.TabStop = false;
            // 
            // pictureBoxAdmin
            // 
            this.pictureBoxAdmin.Location = new System.Drawing.Point(0, 30);
            this.pictureBoxAdmin.Name = "pictureBoxAdmin";
            this.pictureBoxAdmin.Size = new System.Drawing.Size(200, 103);
            this.pictureBoxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdmin.TabIndex = 8;
            this.pictureBoxAdmin.TabStop = false;
            // 
            // MyInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 642);
            this.Controls.Add(this.uploadStudentPic);
            this.Controls.Add(this.addressTF);
            this.Controls.Add(this.phoneTF);
            this.Controls.Add(this.emailTF);
            this.Controls.Add(this.dobTF);
            this.Controls.Add(this.genderTF);
            this.Controls.Add(this.fullnameTF);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel1);
            this.Name = "MyInformation";
            this.Text = "My Information";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadStudentPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton mChangePasswordBtn;
        private System.Windows.Forms.Label mUserID;
        private MetroFramework.Controls.MetroButton mViewBookBtn;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton mLogoutBtn;
        private MetroFramework.Controls.MetroButton mMyInformationBtn;
        private MetroFramework.Controls.MetroButton mCurrentBorrowBtn;
        private MetroFramework.Controls.MetroButton mDashboardBtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox fullnameTF;
        private MetroFramework.Controls.MetroTextBox genderTF;
        private MetroFramework.Controls.MetroTextBox dobTF;
        private MetroFramework.Controls.MetroTextBox emailTF;
        private MetroFramework.Controls.MetroTextBox phoneTF;
        private System.Windows.Forms.RichTextBox addressTF;
        private System.Windows.Forms.PictureBox uploadStudentPic;
        private System.Windows.Forms.PictureBox pictureBoxAdmin;
    }
}