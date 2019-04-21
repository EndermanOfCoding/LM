namespace Library_Management_System
{
    partial class IssueBook
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
            this.mManageStudetnBtn = new MetroFramework.Controls.MetroButton();
            this.mLogoutBtn = new MetroFramework.Controls.MetroButton();
            this.mChangePasswordBtn = new MetroFramework.Controls.MetroButton();
            this.pictureBoxAdmin = new System.Windows.Forms.PictureBox();
            this.mUserID = new System.Windows.Forms.Label();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mPayFineBtn = new MetroFramework.Controls.MetroButton();
            this.mReturnBookBtn = new MetroFramework.Controls.MetroButton();
            this.mIssueBookBtn = new MetroFramework.Controls.MetroButton();
            this.mDashboardBtn = new MetroFramework.Controls.MetroButton();
            this.mStudentTextField = new MetroFramework.Controls.MetroTextBox();
            this.mBookTextField = new MetroFramework.Controls.MetroTextBox();
            this.mLoadStudentBtn = new MetroFramework.Controls.MetroButton();
            this.mLoadBookBtn = new MetroFramework.Controls.MetroButton();
            this.feesTF = new MetroFramework.Controls.MetroTextBox();
            this.phoneTF = new MetroFramework.Controls.MetroTextBox();
            this.emailTF = new MetroFramework.Controls.MetroTextBox();
            this.addressTF = new System.Windows.Forms.RichTextBox();
            this.dobTF = new MetroFramework.Controls.MetroTextBox();
            this.genderTF = new MetroFramework.Controls.MetroTextBox();
            this.fullnameTF = new MetroFramework.Controls.MetroTextBox();
            this.feesLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.dateofbirthLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.publicationYear = new System.Windows.Forms.Label();
            this.authorName = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.Label();
            this.booknameTF = new MetroFramework.Controls.MetroTextBox();
            this.authornameTF = new MetroFramework.Controls.MetroTextBox();
            this.publicationyearTF = new MetroFramework.Controls.MetroTextBox();
            this.quantityTF = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.brwLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.brwTxt1 = new MetroFramework.Controls.MetroTextBox();
            this.brwTxt2 = new MetroFramework.Controls.MetroTextBox();
            this.mReturnDateBtn = new MetroFramework.Controls.MetroDateTime();
            this.mBorrowDateBtn = new MetroFramework.Controls.MetroDateTime();
            this.label2 = new System.Windows.Forms.Label();
            this.mIssueBookBtn2 = new MetroFramework.Controls.MetroButton();
            this.mClearBtn = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.mManageStudetnBtn);
            this.panel1.Controls.Add(this.mLogoutBtn);
            this.panel1.Controls.Add(this.mChangePasswordBtn);
            this.panel1.Controls.Add(this.pictureBoxAdmin);
            this.panel1.Controls.Add(this.mUserID);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.mPayFineBtn);
            this.panel1.Controls.Add(this.mReturnBookBtn);
            this.panel1.Controls.Add(this.mIssueBookBtn);
            this.panel1.Controls.Add(this.mDashboardBtn);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 541);
            this.panel1.TabIndex = 56;
            // 
            // mManageStudetnBtn
            // 
            this.mManageStudetnBtn.Location = new System.Drawing.Point(-1, 385);
            this.mManageStudetnBtn.Name = "mManageStudetnBtn";
            this.mManageStudetnBtn.Size = new System.Drawing.Size(200, 37);
            this.mManageStudetnBtn.TabIndex = 56;
            this.mManageStudetnBtn.Text = "Manage Student";
            this.mManageStudetnBtn.UseSelectable = true;
            this.mManageStudetnBtn.Click += new System.EventHandler(this.mManageStudetnBtn_Click);
            // 
            // mLogoutBtn
            // 
            this.mLogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mLogoutBtn.Location = new System.Drawing.Point(-1, 499);
            this.mLogoutBtn.Name = "mLogoutBtn";
            this.mLogoutBtn.Size = new System.Drawing.Size(200, 37);
            this.mLogoutBtn.TabIndex = 10;
            this.mLogoutBtn.Text = "Logout";
            this.mLogoutBtn.UseSelectable = true;
            this.mLogoutBtn.Click += new System.EventHandler(this.mLogoutBtn_Click);
            // 
            // mChangePasswordBtn
            // 
            this.mChangePasswordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mChangePasswordBtn.Location = new System.Drawing.Point(-1, 442);
            this.mChangePasswordBtn.Name = "mChangePasswordBtn";
            this.mChangePasswordBtn.Size = new System.Drawing.Size(200, 37);
            this.mChangePasswordBtn.TabIndex = 9;
            this.mChangePasswordBtn.Text = "Change Password";
            this.mChangePasswordBtn.UseSelectable = true;
            this.mChangePasswordBtn.Click += new System.EventHandler(this.mChangePasswordBtn_Click);
            // 
            // pictureBoxAdmin
            // 
            this.pictureBoxAdmin.Location = new System.Drawing.Point(0, 30);
            this.pictureBoxAdmin.Name = "pictureBoxAdmin";
            this.pictureBoxAdmin.Size = new System.Drawing.Size(200, 97);
            this.pictureBoxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdmin.TabIndex = 8;
            this.pictureBoxAdmin.TabStop = false;
            // 
            // mUserID
            // 
            this.mUserID.AutoSize = true;
            this.mUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mUserID.Location = new System.Drawing.Point(3, 130);
            this.mUserID.Name = "mUserID";
            this.mUserID.Size = new System.Drawing.Size(43, 20);
            this.mUserID.TabIndex = 6;
            this.mUserID.Text = "User";
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
            // mPayFineBtn
            // 
            this.mPayFineBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mPayFineBtn.Location = new System.Drawing.Point(-1, 328);
            this.mPayFineBtn.Name = "mPayFineBtn";
            this.mPayFineBtn.Size = new System.Drawing.Size(200, 37);
            this.mPayFineBtn.TabIndex = 3;
            this.mPayFineBtn.Text = "Pay Fine";
            this.mPayFineBtn.UseSelectable = true;
            this.mPayFineBtn.Click += new System.EventHandler(this.mPayFineBtn_Click);
            // 
            // mReturnBookBtn
            // 
            this.mReturnBookBtn.Location = new System.Drawing.Point(-1, 271);
            this.mReturnBookBtn.Name = "mReturnBookBtn";
            this.mReturnBookBtn.Size = new System.Drawing.Size(200, 37);
            this.mReturnBookBtn.TabIndex = 2;
            this.mReturnBookBtn.Text = "Return Book";
            this.mReturnBookBtn.UseSelectable = true;
            this.mReturnBookBtn.Click += new System.EventHandler(this.mReturnBookBtn_Click);
            // 
            // mIssueBookBtn
            // 
            this.mIssueBookBtn.Location = new System.Drawing.Point(-1, 214);
            this.mIssueBookBtn.Name = "mIssueBookBtn";
            this.mIssueBookBtn.Size = new System.Drawing.Size(200, 37);
            this.mIssueBookBtn.TabIndex = 1;
            this.mIssueBookBtn.Text = "Issue Book";
            this.mIssueBookBtn.UseSelectable = true;
          
            // 
            // mDashboardBtn
            // 
            this.mDashboardBtn.Location = new System.Drawing.Point(-1, 157);
            this.mDashboardBtn.Name = "mDashboardBtn";
            this.mDashboardBtn.Size = new System.Drawing.Size(200, 37);
            this.mDashboardBtn.TabIndex = 0;
            this.mDashboardBtn.Text = "Dashboard";
            this.mDashboardBtn.UseSelectable = true;
            this.mDashboardBtn.Click += new System.EventHandler(this.mDashboardBtn_Click);
            // 
            // mStudentTextField
            // 
            // 
            // 
            // 
            this.mStudentTextField.CustomButton.Image = null;
            this.mStudentTextField.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.mStudentTextField.CustomButton.Name = "";
            this.mStudentTextField.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mStudentTextField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mStudentTextField.CustomButton.TabIndex = 1;
            this.mStudentTextField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mStudentTextField.CustomButton.UseSelectable = true;
            this.mStudentTextField.CustomButton.Visible = false;
            this.mStudentTextField.Lines = new string[0];
            this.mStudentTextField.Location = new System.Drawing.Point(221, 63);
            this.mStudentTextField.MaxLength = 32767;
            this.mStudentTextField.Name = "mStudentTextField";
            this.mStudentTextField.PasswordChar = '\0';
            this.mStudentTextField.PromptText = "Student ID";
            this.mStudentTextField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mStudentTextField.SelectedText = "";
            this.mStudentTextField.SelectionLength = 0;
            this.mStudentTextField.SelectionStart = 0;
            this.mStudentTextField.ShortcutsEnabled = true;
            this.mStudentTextField.Size = new System.Drawing.Size(222, 23);
            this.mStudentTextField.TabIndex = 59;
            this.mStudentTextField.UseSelectable = true;
            this.mStudentTextField.WaterMark = "Student ID";
            this.mStudentTextField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mStudentTextField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mBookTextField
            // 
            // 
            // 
            // 
            this.mBookTextField.CustomButton.Image = null;
            this.mBookTextField.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.mBookTextField.CustomButton.Name = "";
            this.mBookTextField.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mBookTextField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mBookTextField.CustomButton.TabIndex = 1;
            this.mBookTextField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mBookTextField.CustomButton.UseSelectable = true;
            this.mBookTextField.CustomButton.Visible = false;
            this.mBookTextField.Lines = new string[0];
            this.mBookTextField.Location = new System.Drawing.Point(526, 63);
            this.mBookTextField.MaxLength = 32767;
            this.mBookTextField.Name = "mBookTextField";
            this.mBookTextField.PasswordChar = '\0';
            this.mBookTextField.PromptText = "Book ID";
            this.mBookTextField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mBookTextField.SelectedText = "";
            this.mBookTextField.SelectionLength = 0;
            this.mBookTextField.SelectionStart = 0;
            this.mBookTextField.ShortcutsEnabled = true;
            this.mBookTextField.Size = new System.Drawing.Size(222, 23);
            this.mBookTextField.TabIndex = 60;
            this.mBookTextField.UseSelectable = true;
            this.mBookTextField.WaterMark = "Book ID";
            this.mBookTextField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mBookTextField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLoadStudentBtn
            // 
            this.mLoadStudentBtn.Location = new System.Drawing.Point(351, 102);
            this.mLoadStudentBtn.Name = "mLoadStudentBtn";
            this.mLoadStudentBtn.Size = new System.Drawing.Size(92, 33);
            this.mLoadStudentBtn.TabIndex = 61;
            this.mLoadStudentBtn.Text = "Load Student";
            this.mLoadStudentBtn.UseSelectable = true;
            this.mLoadStudentBtn.Click += new System.EventHandler(this.mLoadStudentBtn_Click);
            // 
            // mLoadBookBtn
            // 
            this.mLoadBookBtn.Location = new System.Drawing.Point(656, 102);
            this.mLoadBookBtn.Name = "mLoadBookBtn";
            this.mLoadBookBtn.Size = new System.Drawing.Size(92, 33);
            this.mLoadBookBtn.TabIndex = 62;
            this.mLoadBookBtn.Text = "Load Book";
            this.mLoadBookBtn.UseSelectable = true;
            this.mLoadBookBtn.Click += new System.EventHandler(this.mLoadBookBtn_Click);
            // 
            // feesTF
            // 
            // 
            // 
            // 
            this.feesTF.CustomButton.Image = null;
            this.feesTF.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.feesTF.CustomButton.Name = "";
            this.feesTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.feesTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.feesTF.CustomButton.TabIndex = 1;
            this.feesTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.feesTF.CustomButton.UseSelectable = true;
            this.feesTF.CustomButton.Visible = false;
            this.feesTF.Lines = new string[] {
        "0.0"};
            this.feesTF.Location = new System.Drawing.Point(307, 502);
            this.feesTF.MaxLength = 32767;
            this.feesTF.Name = "feesTF";
            this.feesTF.PasswordChar = '\0';
            this.feesTF.ReadOnly = true;
            this.feesTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.feesTF.SelectedText = "";
            this.feesTF.SelectionLength = 0;
            this.feesTF.SelectionStart = 0;
            this.feesTF.ShortcutsEnabled = true;
            this.feesTF.Size = new System.Drawing.Size(211, 23);
            this.feesTF.TabIndex = 90;
            this.feesTF.Text = "0.0";
            this.feesTF.UseSelectable = true;
            this.feesTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.feesTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // phoneTF
            // 
            // 
            // 
            // 
            this.phoneTF.CustomButton.Image = null;
            this.phoneTF.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.phoneTF.CustomButton.Name = "";
            this.phoneTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.phoneTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.phoneTF.CustomButton.TabIndex = 1;
            this.phoneTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.phoneTF.CustomButton.UseSelectable = true;
            this.phoneTF.CustomButton.Visible = false;
            this.phoneTF.Lines = new string[0];
            this.phoneTF.Location = new System.Drawing.Point(307, 455);
            this.phoneTF.MaxLength = 32767;
            this.phoneTF.Name = "phoneTF";
            this.phoneTF.PasswordChar = '\0';
            this.phoneTF.ReadOnly = true;
            this.phoneTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phoneTF.SelectedText = "";
            this.phoneTF.SelectionLength = 0;
            this.phoneTF.SelectionStart = 0;
            this.phoneTF.ShortcutsEnabled = true;
            this.phoneTF.Size = new System.Drawing.Size(211, 23);
            this.phoneTF.TabIndex = 89;
            this.phoneTF.UseSelectable = true;
            this.phoneTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.phoneTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // emailTF
            // 
            // 
            // 
            // 
            this.emailTF.CustomButton.Image = null;
            this.emailTF.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.emailTF.CustomButton.Name = "";
            this.emailTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emailTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailTF.CustomButton.TabIndex = 1;
            this.emailTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailTF.CustomButton.UseSelectable = true;
            this.emailTF.CustomButton.Visible = false;
            this.emailTF.Lines = new string[0];
            this.emailTF.Location = new System.Drawing.Point(307, 411);
            this.emailTF.MaxLength = 32767;
            this.emailTF.Name = "emailTF";
            this.emailTF.PasswordChar = '\0';
            this.emailTF.ReadOnly = true;
            this.emailTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTF.SelectedText = "";
            this.emailTF.SelectionLength = 0;
            this.emailTF.SelectionStart = 0;
            this.emailTF.ShortcutsEnabled = true;
            this.emailTF.Size = new System.Drawing.Size(211, 23);
            this.emailTF.TabIndex = 88;
            this.emailTF.UseSelectable = true;
            this.emailTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addressTF
            // 
            this.addressTF.Location = new System.Drawing.Point(307, 312);
            this.addressTF.Name = "addressTF";
            this.addressTF.ReadOnly = true;
            this.addressTF.Size = new System.Drawing.Size(211, 91);
            this.addressTF.TabIndex = 87;
            this.addressTF.Text = "";
            // 
            // dobTF
            // 
            // 
            // 
            // 
            this.dobTF.CustomButton.Image = null;
            this.dobTF.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.dobTF.CustomButton.Name = "";
            this.dobTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dobTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dobTF.CustomButton.TabIndex = 1;
            this.dobTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dobTF.CustomButton.UseSelectable = true;
            this.dobTF.CustomButton.Visible = false;
            this.dobTF.Lines = new string[0];
            this.dobTF.Location = new System.Drawing.Point(307, 269);
            this.dobTF.MaxLength = 32767;
            this.dobTF.Name = "dobTF";
            this.dobTF.PasswordChar = '\0';
            this.dobTF.ReadOnly = true;
            this.dobTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dobTF.SelectedText = "";
            this.dobTF.SelectionLength = 0;
            this.dobTF.SelectionStart = 0;
            this.dobTF.ShortcutsEnabled = true;
            this.dobTF.Size = new System.Drawing.Size(211, 23);
            this.dobTF.TabIndex = 86;
            this.dobTF.UseSelectable = true;
            this.dobTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dobTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // genderTF
            // 
            // 
            // 
            // 
            this.genderTF.CustomButton.Image = null;
            this.genderTF.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.genderTF.CustomButton.Name = "";
            this.genderTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.genderTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.genderTF.CustomButton.TabIndex = 1;
            this.genderTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.genderTF.CustomButton.UseSelectable = true;
            this.genderTF.CustomButton.Visible = false;
            this.genderTF.Lines = new string[0];
            this.genderTF.Location = new System.Drawing.Point(305, 227);
            this.genderTF.MaxLength = 32767;
            this.genderTF.Name = "genderTF";
            this.genderTF.PasswordChar = '\0';
            this.genderTF.ReadOnly = true;
            this.genderTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.genderTF.SelectedText = "";
            this.genderTF.SelectionLength = 0;
            this.genderTF.SelectionStart = 0;
            this.genderTF.ShortcutsEnabled = true;
            this.genderTF.Size = new System.Drawing.Size(213, 23);
            this.genderTF.TabIndex = 85;
            this.genderTF.UseSelectable = true;
            this.genderTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.genderTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // fullnameTF
            // 
            // 
            // 
            // 
            this.fullnameTF.CustomButton.Image = null;
            this.fullnameTF.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.fullnameTF.CustomButton.Name = "";
            this.fullnameTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fullnameTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fullnameTF.CustomButton.TabIndex = 1;
            this.fullnameTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fullnameTF.CustomButton.UseSelectable = true;
            this.fullnameTF.CustomButton.Visible = false;
            this.fullnameTF.Lines = new string[0];
            this.fullnameTF.Location = new System.Drawing.Point(304, 190);
            this.fullnameTF.MaxLength = 32767;
            this.fullnameTF.Name = "fullnameTF";
            this.fullnameTF.PasswordChar = '\0';
            this.fullnameTF.ReadOnly = true;
            this.fullnameTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fullnameTF.SelectedText = "";
            this.fullnameTF.SelectionLength = 0;
            this.fullnameTF.SelectionStart = 0;
            this.fullnameTF.ShortcutsEnabled = true;
            this.fullnameTF.Size = new System.Drawing.Size(214, 23);
            this.fullnameTF.TabIndex = 84;
            this.fullnameTF.UseSelectable = true;
            this.fullnameTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fullnameTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // feesLabel
            // 
            this.feesLabel.AutoSize = true;
            this.feesLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesLabel.Location = new System.Drawing.Point(258, 503);
            this.feesLabel.Name = "feesLabel";
            this.feesLabel.Size = new System.Drawing.Size(43, 17);
            this.feesLabel.TabIndex = 83;
            this.feesLabel.Text = "Fees :";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(221, 457);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(80, 17);
            this.phoneLabel.TabIndex = 82;
            this.phoneLabel.Text = "Phone No :";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(250, 419);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(51, 17);
            this.emailLabel.TabIndex = 81;
            this.emailLabel.Text = "Email :";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(236, 313);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(65, 17);
            this.addressLabel.TabIndex = 80;
            this.addressLabel.Text = "Address :";
            // 
            // dateofbirthLabel
            // 
            this.dateofbirthLabel.AutoSize = true;
            this.dateofbirthLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofbirthLabel.Location = new System.Drawing.Point(205, 264);
            this.dateofbirthLabel.Name = "dateofbirthLabel";
            this.dateofbirthLabel.Size = new System.Drawing.Size(96, 17);
            this.dateofbirthLabel.TabIndex = 79;
            this.dateofbirthLabel.Text = "Date of Birth :";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(237, 228);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(64, 17);
            this.genderLabel.TabIndex = 78;
            this.genderLabel.Text = "Gender :";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(221, 191);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(80, 17);
            this.nameLabel.TabIndex = 77;
            this.nameLabel.Text = "Full Name :";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(584, 299);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(71, 17);
            this.quantity.TabIndex = 94;
            this.quantity.Text = "Quantity :";
            // 
            // publicationYear
            // 
            this.publicationYear.AutoSize = true;
            this.publicationYear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicationYear.Location = new System.Drawing.Point(534, 262);
            this.publicationYear.Name = "publicationYear";
            this.publicationYear.Size = new System.Drawing.Size(121, 17);
            this.publicationYear.TabIndex = 93;
            this.publicationYear.Text = "Publication Year :";
            // 
            // authorName
            // 
            this.authorName.AutoSize = true;
            this.authorName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorName.Location = new System.Drawing.Point(552, 223);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(103, 17);
            this.authorName.TabIndex = 92;
            this.authorName.Text = "Author Name :";
            // 
            // bookName
            // 
            this.bookName.AutoSize = true;
            this.bookName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookName.Location = new System.Drawing.Point(563, 190);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(92, 17);
            this.bookName.TabIndex = 91;
            this.bookName.Text = "Book Name :";
            // 
            // booknameTF
            // 
            // 
            // 
            // 
            this.booknameTF.CustomButton.Image = null;
            this.booknameTF.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.booknameTF.CustomButton.Name = "";
            this.booknameTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.booknameTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.booknameTF.CustomButton.TabIndex = 1;
            this.booknameTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.booknameTF.CustomButton.UseSelectable = true;
            this.booknameTF.CustomButton.Visible = false;
            this.booknameTF.Lines = new string[0];
            this.booknameTF.Location = new System.Drawing.Point(656, 190);
            this.booknameTF.MaxLength = 32767;
            this.booknameTF.Name = "booknameTF";
            this.booknameTF.PasswordChar = '\0';
            this.booknameTF.ReadOnly = true;
            this.booknameTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.booknameTF.SelectedText = "";
            this.booknameTF.SelectionLength = 0;
            this.booknameTF.SelectionStart = 0;
            this.booknameTF.ShortcutsEnabled = true;
            this.booknameTF.Size = new System.Drawing.Size(189, 23);
            this.booknameTF.TabIndex = 95;
            this.booknameTF.UseSelectable = true;
            this.booknameTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.booknameTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // authornameTF
            // 
            // 
            // 
            // 
            this.authornameTF.CustomButton.Image = null;
            this.authornameTF.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.authornameTF.CustomButton.Name = "";
            this.authornameTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.authornameTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.authornameTF.CustomButton.TabIndex = 1;
            this.authornameTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.authornameTF.CustomButton.UseSelectable = true;
            this.authornameTF.CustomButton.Visible = false;
            this.authornameTF.Lines = new string[0];
            this.authornameTF.Location = new System.Drawing.Point(656, 227);
            this.authornameTF.MaxLength = 32767;
            this.authornameTF.Name = "authornameTF";
            this.authornameTF.PasswordChar = '\0';
            this.authornameTF.ReadOnly = true;
            this.authornameTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.authornameTF.SelectedText = "";
            this.authornameTF.SelectionLength = 0;
            this.authornameTF.SelectionStart = 0;
            this.authornameTF.ShortcutsEnabled = true;
            this.authornameTF.Size = new System.Drawing.Size(189, 23);
            this.authornameTF.TabIndex = 96;
            this.authornameTF.UseSelectable = true;
            this.authornameTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.authornameTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // publicationyearTF
            // 
            // 
            // 
            // 
            this.publicationyearTF.CustomButton.Image = null;
            this.publicationyearTF.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.publicationyearTF.CustomButton.Name = "";
            this.publicationyearTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.publicationyearTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.publicationyearTF.CustomButton.TabIndex = 1;
            this.publicationyearTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.publicationyearTF.CustomButton.UseSelectable = true;
            this.publicationyearTF.CustomButton.Visible = false;
            this.publicationyearTF.Lines = new string[0];
            this.publicationyearTF.Location = new System.Drawing.Point(656, 264);
            this.publicationyearTF.MaxLength = 32767;
            this.publicationyearTF.Name = "publicationyearTF";
            this.publicationyearTF.PasswordChar = '\0';
            this.publicationyearTF.ReadOnly = true;
            this.publicationyearTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.publicationyearTF.SelectedText = "";
            this.publicationyearTF.SelectionLength = 0;
            this.publicationyearTF.SelectionStart = 0;
            this.publicationyearTF.ShortcutsEnabled = true;
            this.publicationyearTF.Size = new System.Drawing.Size(189, 23);
            this.publicationyearTF.TabIndex = 97;
            this.publicationyearTF.UseSelectable = true;
            this.publicationyearTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.publicationyearTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // quantityTF
            // 
            // 
            // 
            // 
            this.quantityTF.CustomButton.Image = null;
            this.quantityTF.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.quantityTF.CustomButton.Name = "";
            this.quantityTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.quantityTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.quantityTF.CustomButton.TabIndex = 1;
            this.quantityTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.quantityTF.CustomButton.UseSelectable = true;
            this.quantityTF.CustomButton.Visible = false;
            this.quantityTF.Lines = new string[0];
            this.quantityTF.Location = new System.Drawing.Point(656, 299);
            this.quantityTF.MaxLength = 32767;
            this.quantityTF.Name = "quantityTF";
            this.quantityTF.PasswordChar = '\0';
            this.quantityTF.ReadOnly = true;
            this.quantityTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.quantityTF.SelectedText = "";
            this.quantityTF.SelectionLength = 0;
            this.quantityTF.SelectionStart = 0;
            this.quantityTF.ShortcutsEnabled = true;
            this.quantityTF.Size = new System.Drawing.Size(189, 23);
            this.quantityTF.TabIndex = 98;
            this.quantityTF.UseSelectable = true;
            this.quantityTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.quantityTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 101;
            this.label3.Text = "Return Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 99;
            this.label1.Text = "Borrow Date :";
            // 
            // brwLabel
            // 
            this.brwLabel.AutoSize = true;
            this.brwLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.brwLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brwLabel.Location = new System.Drawing.Point(41, 43);
            this.brwLabel.Name = "brwLabel";
            this.brwLabel.Size = new System.Drawing.Size(77, 17);
            this.brwLabel.TabIndex = 100;
            this.brwLabel.Text = "Borrow Id :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.brwTxt1);
            this.panel2.Controls.Add(this.brwTxt2);
            this.panel2.Controls.Add(this.mReturnDateBtn);
            this.panel2.Controls.Add(this.mBorrowDateBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.brwLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(537, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 176);
            this.panel2.TabIndex = 102;
            // 
            // brwTxt1
            // 
            // 
            // 
            // 
            this.brwTxt1.CustomButton.Image = null;
            this.brwTxt1.CustomButton.Location = new System.Drawing.Point(11, 1);
            this.brwTxt1.CustomButton.Name = "";
            this.brwTxt1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.brwTxt1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.brwTxt1.CustomButton.TabIndex = 1;
            this.brwTxt1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.brwTxt1.CustomButton.UseSelectable = true;
            this.brwTxt1.CustomButton.Visible = false;
            this.brwTxt1.Lines = new string[] {
        "BR#"};
            this.brwTxt1.Location = new System.Drawing.Point(119, 42);
            this.brwTxt1.MaxLength = 32767;
            this.brwTxt1.Name = "brwTxt1";
            this.brwTxt1.PasswordChar = '\0';
            this.brwTxt1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.brwTxt1.SelectedText = "";
            this.brwTxt1.SelectionLength = 0;
            this.brwTxt1.SelectionStart = 0;
            this.brwTxt1.ShortcutsEnabled = true;
            this.brwTxt1.Size = new System.Drawing.Size(33, 23);
            this.brwTxt1.TabIndex = 107;
            this.brwTxt1.Text = "BR#";
            this.brwTxt1.UseSelectable = true;
            this.brwTxt1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.brwTxt1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // brwTxt2
            // 
            // 
            // 
            // 
            this.brwTxt2.CustomButton.Image = null;
            this.brwTxt2.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.brwTxt2.CustomButton.Name = "";
            this.brwTxt2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.brwTxt2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.brwTxt2.CustomButton.TabIndex = 1;
            this.brwTxt2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.brwTxt2.CustomButton.UseSelectable = true;
            this.brwTxt2.CustomButton.Visible = false;
            this.brwTxt2.Lines = new string[0];
            this.brwTxt2.Location = new System.Drawing.Point(151, 42);
            this.brwTxt2.MaxLength = 32767;
            this.brwTxt2.Name = "brwTxt2";
            this.brwTxt2.PasswordChar = '\0';
            this.brwTxt2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.brwTxt2.SelectedText = "";
            this.brwTxt2.SelectionLength = 0;
            this.brwTxt2.SelectionStart = 0;
            this.brwTxt2.ShortcutsEnabled = true;
            this.brwTxt2.Size = new System.Drawing.Size(144, 23);
            this.brwTxt2.TabIndex = 106;
            this.brwTxt2.UseSelectable = true;
            this.brwTxt2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.brwTxt2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mReturnDateBtn
            // 
            this.mReturnDateBtn.Location = new System.Drawing.Point(120, 129);
            this.mReturnDateBtn.MinimumSize = new System.Drawing.Size(0, 29);
            this.mReturnDateBtn.Name = "mReturnDateBtn";
            this.mReturnDateBtn.Size = new System.Drawing.Size(171, 29);
            this.mReturnDateBtn.TabIndex = 105;
            // 
            // mBorrowDateBtn
            // 
            this.mBorrowDateBtn.Location = new System.Drawing.Point(119, 86);
            this.mBorrowDateBtn.MinimumSize = new System.Drawing.Size(0, 29);
            this.mBorrowDateBtn.Name = "mBorrowDateBtn";
            this.mBorrowDateBtn.Size = new System.Drawing.Size(171, 29);
            this.mBorrowDateBtn.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 102;
            this.label2.Text = "Fill This For Book Issue";
            // 
            // mIssueBookBtn2
            // 
            this.mIssueBookBtn2.Location = new System.Drawing.Point(380, 539);
            this.mIssueBookBtn2.Name = "mIssueBookBtn2";
            this.mIssueBookBtn2.Size = new System.Drawing.Size(96, 46);
            this.mIssueBookBtn2.TabIndex = 103;
            this.mIssueBookBtn2.Text = "Issue Book";
            this.mIssueBookBtn2.UseSelectable = true;
            this.mIssueBookBtn2.Click += new System.EventHandler(this.mIssueBookBtn2_Click);
            // 
            // mClearBtn
            // 
            this.mClearBtn.Location = new System.Drawing.Point(562, 539);
            this.mClearBtn.Name = "mClearBtn";
            this.mClearBtn.Size = new System.Drawing.Size(96, 46);
            this.mClearBtn.TabIndex = 104;
            this.mClearBtn.Text = "Clear";
            this.mClearBtn.UseSelectable = true;
            this.mClearBtn.Click += new System.EventHandler(this.mClearBtn_Click);
            // 
            // IssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 603);
            this.Controls.Add(this.mClearBtn);
            this.Controls.Add(this.mIssueBookBtn2);
            this.Controls.Add(this.quantityTF);
            this.Controls.Add(this.publicationyearTF);
            this.Controls.Add(this.authornameTF);
            this.Controls.Add(this.booknameTF);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.publicationYear);
            this.Controls.Add(this.authorName);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.feesTF);
            this.Controls.Add(this.phoneTF);
            this.Controls.Add(this.emailTF);
            this.Controls.Add(this.addressTF);
            this.Controls.Add(this.dobTF);
            this.Controls.Add(this.genderTF);
            this.Controls.Add(this.fullnameTF);
            this.Controls.Add(this.feesLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.dateofbirthLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.mLoadBookBtn);
            this.Controls.Add(this.mLoadStudentBtn);
            this.Controls.Add(this.mBookTextField);
            this.Controls.Add(this.mStudentTextField);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "IssueBook";
            this.Text = "Issue Book";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton mManageStudetnBtn;
        private MetroFramework.Controls.MetroButton mLogoutBtn;
        private MetroFramework.Controls.MetroButton mChangePasswordBtn;
        private System.Windows.Forms.PictureBox pictureBoxAdmin;
        private System.Windows.Forms.Label mUserID;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton mPayFineBtn;
        private MetroFramework.Controls.MetroButton mReturnBookBtn;
        private MetroFramework.Controls.MetroButton mIssueBookBtn;
        private MetroFramework.Controls.MetroButton mDashboardBtn;
        private MetroFramework.Controls.MetroTextBox mStudentTextField;
        private MetroFramework.Controls.MetroTextBox mBookTextField;
        private MetroFramework.Controls.MetroButton mLoadStudentBtn;
        private MetroFramework.Controls.MetroButton mLoadBookBtn;
        private MetroFramework.Controls.MetroTextBox feesTF;
        private MetroFramework.Controls.MetroTextBox phoneTF;
        private MetroFramework.Controls.MetroTextBox emailTF;
        private System.Windows.Forms.RichTextBox addressTF;
        private MetroFramework.Controls.MetroTextBox dobTF;
        private MetroFramework.Controls.MetroTextBox genderTF;
        private MetroFramework.Controls.MetroTextBox fullnameTF;
        private System.Windows.Forms.Label feesLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label dateofbirthLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label publicationYear;
        private System.Windows.Forms.Label authorName;
        private System.Windows.Forms.Label bookName;
        private MetroFramework.Controls.MetroTextBox booknameTF;
        private MetroFramework.Controls.MetroTextBox authornameTF;
        private MetroFramework.Controls.MetroTextBox publicationyearTF;
        private MetroFramework.Controls.MetroTextBox quantityTF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label brwLabel;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroDateTime mReturnDateBtn;
        private MetroFramework.Controls.MetroDateTime mBorrowDateBtn;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton mIssueBookBtn2;
        private MetroFramework.Controls.MetroButton mClearBtn;
        private MetroFramework.Controls.MetroTextBox brwTxt1;
        private MetroFramework.Controls.MetroTextBox brwTxt2;
    }
}