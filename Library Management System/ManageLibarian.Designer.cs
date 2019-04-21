namespace Library_Management_System
{
    partial class ManageLibarian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLibarian));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUserID = new System.Windows.Forms.Label();
            this.mManageStudentBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mLogoutBtn = new MetroFramework.Controls.MetroButton();
            this.mManageBookBtn = new MetroFramework.Controls.MetroButton();
            this.mLibarianBtn = new MetroFramework.Controls.MetroButton();
            this.mDashboardBtn = new MetroFramework.Controls.MetroButton();
            this.passwordAutoGen = new System.Windows.Forms.PictureBox();
            this.mViewStudentBtn = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.phoneTF = new MetroFramework.Controls.MetroTextBox();
            this.librarianidTF = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mAddLibarianBtn = new MetroFramework.Controls.MetroButton();
            this.mLibarianImageUploadBtn = new MetroFramework.Controls.MetroButton();
            this.uploadLibrarianPic = new System.Windows.Forms.PictureBox();
            this.phoneTF2 = new MetroFramework.Controls.MetroTextBox();
            this.addressTF = new System.Windows.Forms.RichTextBox();
            this.emailTF = new MetroFramework.Controls.MetroTextBox();
            this.datepickTF = new MetroFramework.Controls.MetroDateTime();
            this.genderBox = new MetroFramework.Controls.MetroComboBox();
            this.fullnameTF = new MetroFramework.Controls.MetroTextBox();
            this.passwordTF = new MetroFramework.Controls.MetroTextBox();
            this.librarianidTF2 = new MetroFramework.Controls.MetroTextBox();
            this.salaryTF = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordAutoGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uploadLibrarianPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.labelUserID);
            this.panel1.Controls.Add(this.mManageStudentBtn);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.mLogoutBtn);
            this.panel1.Controls.Add(this.mManageBookBtn);
            this.panel1.Controls.Add(this.mLibarianBtn);
            this.panel1.Controls.Add(this.mDashboardBtn);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 479);
            this.panel1.TabIndex = 1;
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.Location = new System.Drawing.Point(72, 58);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(49, 24);
            this.labelUserID.TabIndex = 6;
            this.labelUserID.Text = "User";
            // 
            // mManageStudentBtn
            // 
            this.mManageStudentBtn.Location = new System.Drawing.Point(0, 173);
            this.mManageStudentBtn.Name = "mManageStudentBtn";
            this.mManageStudentBtn.Size = new System.Drawing.Size(200, 52);
            this.mManageStudentBtn.TabIndex = 4;
            this.mManageStudentBtn.Text = "Manage Student";
            this.mManageStudentBtn.UseSelectable = true;
            this.mManageStudentBtn.Click += new System.EventHandler(this.mManageStudentBtn_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(58, 23);
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
            this.mLogoutBtn.Location = new System.Drawing.Point(0, 404);
            this.mLogoutBtn.Name = "mLogoutBtn";
            this.mLogoutBtn.Size = new System.Drawing.Size(200, 52);
            this.mLogoutBtn.TabIndex = 3;
            this.mLogoutBtn.Text = "Logout";
            this.mLogoutBtn.UseSelectable = true;
            this.mLogoutBtn.Click += new System.EventHandler(this.mLogoutBtn_Click);
            // 
            // mManageBookBtn
            // 
            this.mManageBookBtn.Location = new System.Drawing.Point(0, 327);
            this.mManageBookBtn.Name = "mManageBookBtn";
            this.mManageBookBtn.Size = new System.Drawing.Size(200, 52);
            this.mManageBookBtn.TabIndex = 2;
            this.mManageBookBtn.Text = "Manage Books";
            this.mManageBookBtn.UseSelectable = true;
            this.mManageBookBtn.Click += new System.EventHandler(this.mManageBookBtn_Click);
            // 
            // mLibarianBtn
            // 
            this.mLibarianBtn.Location = new System.Drawing.Point(0, 250);
            this.mLibarianBtn.Name = "mLibarianBtn";
            this.mLibarianBtn.Size = new System.Drawing.Size(200, 52);
            this.mLibarianBtn.TabIndex = 1;
            this.mLibarianBtn.Text = "Manage Librarian";
            this.mLibarianBtn.UseSelectable = true;
            // 
            // mDashboardBtn
            // 
            this.mDashboardBtn.Location = new System.Drawing.Point(0, 96);
            this.mDashboardBtn.Name = "mDashboardBtn";
            this.mDashboardBtn.Size = new System.Drawing.Size(200, 52);
            this.mDashboardBtn.TabIndex = 0;
            this.mDashboardBtn.Text = "Dashboard";
            this.mDashboardBtn.UseSelectable = true;
            this.mDashboardBtn.Click += new System.EventHandler(this.mDashboardBtn_Click);
            // 
            // passwordAutoGen
            // 
            this.passwordAutoGen.Image = ((System.Drawing.Image)(resources.GetObject("passwordAutoGen.Image")));
            this.passwordAutoGen.Location = new System.Drawing.Point(525, 173);
            this.passwordAutoGen.Name = "passwordAutoGen";
            this.passwordAutoGen.Size = new System.Drawing.Size(22, 23);
            this.passwordAutoGen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordAutoGen.TabIndex = 78;
            this.passwordAutoGen.TabStop = false;
            this.passwordAutoGen.Click += new System.EventHandler(this.passwordAutoGen_Click);
            // 
            // mViewStudentBtn
            // 
            this.mViewStudentBtn.Location = new System.Drawing.Point(544, 63);
            this.mViewStudentBtn.Name = "mViewStudentBtn";
            this.mViewStudentBtn.Size = new System.Drawing.Size(100, 45);
            this.mViewStudentBtn.TabIndex = 77;
            this.mViewStudentBtn.Text = "View Libarian";
            this.mViewStudentBtn.UseSelectable = true;
            this.mViewStudentBtn.Click += new System.EventHandler(this.mViewStudentBtn_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(412, 63);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(100, 45);
            this.metroButton1.TabIndex = 76;
            this.metroButton1.Text = "Add Libarian";
            this.metroButton1.UseSelectable = true;
            // 
            // phoneTF
            // 
            // 
            // 
            // 
            this.phoneTF.CustomButton.Image = null;
            this.phoneTF.CustomButton.Location = new System.Drawing.Point(20, 1);
            this.phoneTF.CustomButton.Name = "";
            this.phoneTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.phoneTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.phoneTF.CustomButton.TabIndex = 1;
            this.phoneTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.phoneTF.CustomButton.UseSelectable = true;
            this.phoneTF.CustomButton.Visible = false;
            this.phoneTF.Lines = new string[] {
        "880"};
            this.phoneTF.Location = new System.Drawing.Point(320, 402);
            this.phoneTF.MaxLength = 32767;
            this.phoneTF.Name = "phoneTF";
            this.phoneTF.PasswordChar = '\0';
            this.phoneTF.ReadOnly = true;
            this.phoneTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phoneTF.SelectedText = "";
            this.phoneTF.SelectionLength = 0;
            this.phoneTF.SelectionStart = 0;
            this.phoneTF.ShortcutsEnabled = true;
            this.phoneTF.Size = new System.Drawing.Size(42, 23);
            this.phoneTF.TabIndex = 75;
            this.phoneTF.Text = "880";
            this.phoneTF.UseSelectable = true;
            this.phoneTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.phoneTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // librarianidTF
            // 
            // 
            // 
            // 
            this.librarianidTF.CustomButton.Image = null;
            this.librarianidTF.CustomButton.Location = new System.Drawing.Point(7, 1);
            this.librarianidTF.CustomButton.Name = "";
            this.librarianidTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.librarianidTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.librarianidTF.CustomButton.TabIndex = 1;
            this.librarianidTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.librarianidTF.CustomButton.UseSelectable = true;
            this.librarianidTF.CustomButton.Visible = false;
            this.librarianidTF.Lines = new string[] {
        "LB#"};
            this.librarianidTF.Location = new System.Drawing.Point(319, 135);
            this.librarianidTF.MaxLength = 32767;
            this.librarianidTF.Name = "librarianidTF";
            this.librarianidTF.PasswordChar = '\0';
            this.librarianidTF.ReadOnly = true;
            this.librarianidTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.librarianidTF.SelectedText = "";
            this.librarianidTF.SelectionLength = 0;
            this.librarianidTF.SelectionStart = 0;
            this.librarianidTF.ShortcutsEnabled = true;
            this.librarianidTF.Size = new System.Drawing.Size(29, 23);
            this.librarianidTF.TabIndex = 74;
            this.librarianidTF.Text = "LB#";
            this.librarianidTF.UseSelectable = true;
            this.librarianidTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.librarianidTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(544, 285);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(53, 19);
            this.metroLabel10.TabIndex = 73;
            this.metroLabel10.Text = "Image :";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(534, 133);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(63, 19);
            this.metroLabel9.TabIndex = 72;
            this.metroLabel9.Text = "Address :";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(257, 402);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(53, 19);
            this.metroLabel8.TabIndex = 71;
            this.metroLabel8.Text = "Phone :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(263, 363);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(48, 19);
            this.metroLabel7.TabIndex = 70;
            this.metroLabel7.Text = "Email :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(220, 315);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(91, 19);
            this.metroLabel6.TabIndex = 69;
            this.metroLabel6.Text = "Date of Birth :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(252, 263);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 68;
            this.metroLabel4.Text = "Gender :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(235, 213);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 19);
            this.metroLabel3.TabIndex = 67;
            this.metroLabel3.Text = "Full Name :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(241, 176);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 66;
            this.metroLabel2.Text = "Password :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(235, 137);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 65;
            this.metroLabel1.Text = "Librarian ID :";
            // 
            // mAddLibarianBtn
            // 
            this.mAddLibarianBtn.Location = new System.Drawing.Point(462, 490);
            this.mAddLibarianBtn.Name = "mAddLibarianBtn";
            this.mAddLibarianBtn.Size = new System.Drawing.Size(94, 43);
            this.mAddLibarianBtn.TabIndex = 64;
            this.mAddLibarianBtn.Text = "Save";
            this.mAddLibarianBtn.UseSelectable = true;
            this.mAddLibarianBtn.Click += new System.EventHandler(this.mAddLibarianBtn_Click);
            // 
            // mLibarianImageUploadBtn
            // 
            this.mLibarianImageUploadBtn.Location = new System.Drawing.Point(657, 422);
            this.mLibarianImageUploadBtn.Name = "mLibarianImageUploadBtn";
            this.mLibarianImageUploadBtn.Size = new System.Drawing.Size(81, 34);
            this.mLibarianImageUploadBtn.TabIndex = 63;
            this.mLibarianImageUploadBtn.Text = "Browse";
            this.mLibarianImageUploadBtn.UseSelectable = true;
            this.mLibarianImageUploadBtn.Click += new System.EventHandler(this.mLibarianImageUploadBtn_Click);
            // 
            // uploadLibrarianPic
            // 
            this.uploadLibrarianPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uploadLibrarianPic.Location = new System.Drawing.Point(608, 284);
            this.uploadLibrarianPic.Name = "uploadLibrarianPic";
            this.uploadLibrarianPic.Size = new System.Drawing.Size(179, 123);
            this.uploadLibrarianPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uploadLibrarianPic.TabIndex = 62;
            this.uploadLibrarianPic.TabStop = false;
            // 
            // phoneTF2
            // 
            // 
            // 
            // 
            this.phoneTF2.CustomButton.Image = null;
            this.phoneTF2.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.phoneTF2.CustomButton.Name = "";
            this.phoneTF2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.phoneTF2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.phoneTF2.CustomButton.TabIndex = 1;
            this.phoneTF2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.phoneTF2.CustomButton.UseSelectable = true;
            this.phoneTF2.CustomButton.Visible = false;
            this.phoneTF2.Lines = new string[0];
            this.phoneTF2.Location = new System.Drawing.Point(361, 402);
            this.phoneTF2.MaxLength = 32767;
            this.phoneTF2.Name = "phoneTF2";
            this.phoneTF2.PasswordChar = '\0';
            this.phoneTF2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phoneTF2.SelectedText = "";
            this.phoneTF2.SelectionLength = 0;
            this.phoneTF2.SelectionStart = 0;
            this.phoneTF2.ShortcutsEnabled = true;
            this.phoneTF2.Size = new System.Drawing.Size(158, 23);
            this.phoneTF2.TabIndex = 61;
            this.phoneTF2.UseSelectable = true;
            this.phoneTF2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.phoneTF2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.phoneTF2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTF2_KeyPress);
            // 
            // addressTF
            // 
            this.addressTF.Location = new System.Drawing.Point(608, 132);
            this.addressTF.Name = "addressTF";
            this.addressTF.Size = new System.Drawing.Size(179, 123);
            this.addressTF.TabIndex = 60;
            this.addressTF.Text = "";
            // 
            // emailTF
            // 
            // 
            // 
            // 
            this.emailTF.CustomButton.Image = null;
            this.emailTF.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.emailTF.CustomButton.Name = "";
            this.emailTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emailTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailTF.CustomButton.TabIndex = 1;
            this.emailTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailTF.CustomButton.UseSelectable = true;
            this.emailTF.CustomButton.Visible = false;
            this.emailTF.Lines = new string[0];
            this.emailTF.Location = new System.Drawing.Point(319, 361);
            this.emailTF.MaxLength = 32767;
            this.emailTF.Name = "emailTF";
            this.emailTF.PasswordChar = '\0';
            this.emailTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTF.SelectedText = "";
            this.emailTF.SelectionLength = 0;
            this.emailTF.SelectionStart = 0;
            this.emailTF.ShortcutsEnabled = true;
            this.emailTF.Size = new System.Drawing.Size(200, 23);
            this.emailTF.TabIndex = 59;
            this.emailTF.UseSelectable = true;
            this.emailTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // datepickTF
            // 
            this.datepickTF.Location = new System.Drawing.Point(319, 310);
            this.datepickTF.MinimumSize = new System.Drawing.Size(0, 29);
            this.datepickTF.Name = "datepickTF";
            this.datepickTF.Size = new System.Drawing.Size(200, 29);
            this.datepickTF.TabIndex = 58;
            // 
            // genderBox
            // 
            this.genderBox.FormattingEnabled = true;
            this.genderBox.ItemHeight = 23;
            this.genderBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.genderBox.Location = new System.Drawing.Point(319, 258);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(200, 29);
            this.genderBox.TabIndex = 57;
            this.genderBox.UseSelectable = true;
            // 
            // fullnameTF
            // 
            // 
            // 
            // 
            this.fullnameTF.CustomButton.Image = null;
            this.fullnameTF.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.fullnameTF.CustomButton.Name = "";
            this.fullnameTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fullnameTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fullnameTF.CustomButton.TabIndex = 1;
            this.fullnameTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fullnameTF.CustomButton.UseSelectable = true;
            this.fullnameTF.CustomButton.Visible = false;
            this.fullnameTF.Lines = new string[0];
            this.fullnameTF.Location = new System.Drawing.Point(319, 211);
            this.fullnameTF.MaxLength = 32767;
            this.fullnameTF.Name = "fullnameTF";
            this.fullnameTF.PasswordChar = '\0';
            this.fullnameTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fullnameTF.SelectedText = "";
            this.fullnameTF.SelectionLength = 0;
            this.fullnameTF.SelectionStart = 0;
            this.fullnameTF.ShortcutsEnabled = true;
            this.fullnameTF.Size = new System.Drawing.Size(200, 23);
            this.fullnameTF.TabIndex = 56;
            this.fullnameTF.UseSelectable = true;
            this.fullnameTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fullnameTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.fullnameTF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fullnameTF_KeyPress);
            // 
            // passwordTF
            // 
            // 
            // 
            // 
            this.passwordTF.CustomButton.Image = null;
            this.passwordTF.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.passwordTF.CustomButton.Name = "";
            this.passwordTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTF.CustomButton.TabIndex = 1;
            this.passwordTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTF.CustomButton.UseSelectable = true;
            this.passwordTF.CustomButton.Visible = false;
            this.passwordTF.Lines = new string[0];
            this.passwordTF.Location = new System.Drawing.Point(319, 173);
            this.passwordTF.MaxLength = 32767;
            this.passwordTF.Name = "passwordTF";
            this.passwordTF.PasswordChar = '\0';
            this.passwordTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTF.SelectedText = "";
            this.passwordTF.SelectionLength = 0;
            this.passwordTF.SelectionStart = 0;
            this.passwordTF.ShortcutsEnabled = true;
            this.passwordTF.Size = new System.Drawing.Size(200, 23);
            this.passwordTF.TabIndex = 55;
            this.passwordTF.UseSelectable = true;
            this.passwordTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // librarianidTF2
            // 
            // 
            // 
            // 
            this.librarianidTF2.CustomButton.Image = null;
            this.librarianidTF2.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.librarianidTF2.CustomButton.Name = "";
            this.librarianidTF2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.librarianidTF2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.librarianidTF2.CustomButton.TabIndex = 1;
            this.librarianidTF2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.librarianidTF2.CustomButton.UseSelectable = true;
            this.librarianidTF2.CustomButton.Visible = false;
            this.librarianidTF2.Lines = new string[0];
            this.librarianidTF2.Location = new System.Drawing.Point(346, 135);
            this.librarianidTF2.MaxLength = 32767;
            this.librarianidTF2.Name = "librarianidTF2";
            this.librarianidTF2.PasswordChar = '\0';
            this.librarianidTF2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.librarianidTF2.SelectedText = "";
            this.librarianidTF2.SelectionLength = 0;
            this.librarianidTF2.SelectionStart = 0;
            this.librarianidTF2.ShortcutsEnabled = true;
            this.librarianidTF2.Size = new System.Drawing.Size(173, 23);
            this.librarianidTF2.TabIndex = 54;
            this.librarianidTF2.UseSelectable = true;
            this.librarianidTF2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.librarianidTF2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // salaryTF
            // 
            // 
            // 
            // 
            this.salaryTF.CustomButton.Image = null;
            this.salaryTF.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.salaryTF.CustomButton.Name = "";
            this.salaryTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.salaryTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.salaryTF.CustomButton.TabIndex = 1;
            this.salaryTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.salaryTF.CustomButton.UseSelectable = true;
            this.salaryTF.CustomButton.Visible = false;
            this.salaryTF.Lines = new string[0];
            this.salaryTF.Location = new System.Drawing.Point(320, 448);
            this.salaryTF.MaxLength = 32767;
            this.salaryTF.Name = "salaryTF";
            this.salaryTF.PasswordChar = '\0';
            this.salaryTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.salaryTF.SelectedText = "";
            this.salaryTF.SelectionLength = 0;
            this.salaryTF.SelectionStart = 0;
            this.salaryTF.ShortcutsEnabled = true;
            this.salaryTF.Size = new System.Drawing.Size(199, 23);
            this.salaryTF.TabIndex = 79;
            this.salaryTF.UseSelectable = true;
            this.salaryTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.salaryTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.salaryTF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salaryTF_KeyPress);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(258, 450);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(52, 19);
            this.metroLabel11.TabIndex = 80;
            this.metroLabel11.Text = "Salary :";
            // 
            // ManageLibarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 543);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.salaryTF);
            this.Controls.Add(this.passwordAutoGen);
            this.Controls.Add(this.mViewStudentBtn);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.phoneTF);
            this.Controls.Add(this.librarianidTF);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mAddLibarianBtn);
            this.Controls.Add(this.mLibarianImageUploadBtn);
            this.Controls.Add(this.uploadLibrarianPic);
            this.Controls.Add(this.phoneTF2);
            this.Controls.Add(this.addressTF);
            this.Controls.Add(this.emailTF);
            this.Controls.Add(this.datepickTF);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.fullnameTF);
            this.Controls.Add(this.passwordTF);
            this.Controls.Add(this.librarianidTF2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageLibarian";
            this.Text = "Manage Libarian";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordAutoGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uploadLibrarianPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUserID;
        private MetroFramework.Controls.MetroButton mManageStudentBtn;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton mLogoutBtn;
        private MetroFramework.Controls.MetroButton mManageBookBtn;
        private MetroFramework.Controls.MetroButton mLibarianBtn;
        private MetroFramework.Controls.MetroButton mDashboardBtn;
        private System.Windows.Forms.PictureBox passwordAutoGen;
        private MetroFramework.Controls.MetroButton mViewStudentBtn;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox phoneTF;
        private MetroFramework.Controls.MetroTextBox librarianidTF;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton mAddLibarianBtn;
        private MetroFramework.Controls.MetroButton mLibarianImageUploadBtn;
        private System.Windows.Forms.PictureBox uploadLibrarianPic;
        private MetroFramework.Controls.MetroTextBox phoneTF2;
        private System.Windows.Forms.RichTextBox addressTF;
        private MetroFramework.Controls.MetroTextBox emailTF;
        private MetroFramework.Controls.MetroDateTime datepickTF;
        private MetroFramework.Controls.MetroComboBox genderBox;
        private MetroFramework.Controls.MetroTextBox fullnameTF;
        private MetroFramework.Controls.MetroTextBox passwordTF;
        private MetroFramework.Controls.MetroTextBox librarianidTF2;
        private MetroFramework.Controls.MetroTextBox salaryTF;
        private MetroFramework.Controls.MetroLabel metroLabel11;
    }
}