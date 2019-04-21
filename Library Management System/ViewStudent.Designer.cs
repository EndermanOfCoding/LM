namespace Library_Management_System
{
    partial class ViewStudent
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
            this.mClearBtn = new MetroFramework.Controls.MetroButton();
            this.mDeleteBtn = new MetroFramework.Controls.MetroButton();
            this.mUpdateDataBtn = new MetroFramework.Controls.MetroButton();
            this.dgbStudent = new System.Windows.Forms.DataGridView();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.labelUserID = new System.Windows.Forms.Label();
            this.mUpdateImageBtn = new MetroFramework.Controls.MetroButton();
            this.mManageStudentBtn = new MetroFramework.Controls.MetroButton();
            this.mManageBookBtn = new MetroFramework.Controls.MetroButton();
            this.addressTF = new System.Windows.Forms.RichTextBox();
            this.dobTF = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mLibarianBtn = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mLogoutBtn = new MetroFramework.Controls.MetroButton();
            this.mDashboardBtn = new MetroFramework.Controls.MetroButton();
            this.mTextSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.emailTF = new MetroFramework.Controls.MetroTextBox();
            this.fullnameTF = new MetroFramework.Controls.MetroTextBox();
            this.studentIdTF2 = new MetroFramework.Controls.MetroTextBox();
            this.phoneTF = new MetroFramework.Controls.MetroTextBox();
            this.mAddStudentBtn = new MetroFramework.Controls.MetroButton();
            this.mViewStudentBtn = new MetroFramework.Controls.MetroButton();
            this.uploadStudentPic = new System.Windows.Forms.PictureBox();
            this.genderTF = new MetroFramework.Controls.MetroTextBox();
            this.mLibViewStdBtn = new MetroFramework.Controls.MetroButton();
            this.mLibAddStdBtn = new MetroFramework.Controls.MetroButton();
            this.mBackToDashBoard = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgbStudent)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadStudentPic)).BeginInit();
            this.SuspendLayout();
            // 
            // mClearBtn
            // 
            this.mClearBtn.Location = new System.Drawing.Point(570, 363);
            this.mClearBtn.Name = "mClearBtn";
            this.mClearBtn.Size = new System.Drawing.Size(90, 44);
            this.mClearBtn.TabIndex = 46;
            this.mClearBtn.Text = "Clear Fields";
            this.mClearBtn.UseSelectable = true;
            this.mClearBtn.Click += new System.EventHandler(this.mClearBtn_Click);
            // 
            // mDeleteBtn
            // 
            this.mDeleteBtn.Location = new System.Drawing.Point(456, 363);
            this.mDeleteBtn.Name = "mDeleteBtn";
            this.mDeleteBtn.Size = new System.Drawing.Size(90, 44);
            this.mDeleteBtn.TabIndex = 45;
            this.mDeleteBtn.Text = "Delete";
            this.mDeleteBtn.UseSelectable = true;
            this.mDeleteBtn.Click += new System.EventHandler(this.mDeleteBtn_Click);
            // 
            // mUpdateDataBtn
            // 
            this.mUpdateDataBtn.Location = new System.Drawing.Point(338, 363);
            this.mUpdateDataBtn.Name = "mUpdateDataBtn";
            this.mUpdateDataBtn.Size = new System.Drawing.Size(90, 44);
            this.mUpdateDataBtn.TabIndex = 44;
            this.mUpdateDataBtn.Text = "Update";
            this.mUpdateDataBtn.UseSelectable = true;
            this.mUpdateDataBtn.Click += new System.EventHandler(this.mUpdateDataBtn_Click);
            // 
            // dgbStudent
            // 
            this.dgbStudent.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgbStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbStudent.Location = new System.Drawing.Point(212, 419);
            this.dgbStudent.Name = "dgbStudent";
            this.dgbStudent.Size = new System.Drawing.Size(579, 164);
            this.dgbStudent.TabIndex = 43;
            this.dgbStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbStudent_CellContentClick);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(256, 321);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(53, 19);
            this.metroLabel17.TabIndex = 37;
            this.metroLabel17.Text = "Phone :";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(261, 286);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(48, 19);
            this.metroLabel16.TabIndex = 36;
            this.metroLabel16.Text = "Email :";
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
            // mUpdateImageBtn
            // 
            this.mUpdateImageBtn.Location = new System.Drawing.Point(637, 314);
            this.mUpdateImageBtn.Name = "mUpdateImageBtn";
            this.mUpdateImageBtn.Size = new System.Drawing.Size(87, 31);
            this.mUpdateImageBtn.TabIndex = 42;
            this.mUpdateImageBtn.Text = "Update Image";
            this.mUpdateImageBtn.UseSelectable = true;
            this.mUpdateImageBtn.Click += new System.EventHandler(this.mUpdateImageBtn_Click);
            // 
            // mManageStudentBtn
            // 
            this.mManageStudentBtn.Location = new System.Drawing.Point(0, 201);
            this.mManageStudentBtn.Name = "mManageStudentBtn";
            this.mManageStudentBtn.Size = new System.Drawing.Size(200, 52);
            this.mManageStudentBtn.TabIndex = 4;
            this.mManageStudentBtn.Text = "Manage Student";
            this.mManageStudentBtn.UseSelectable = true;
            this.mManageStudentBtn.Click += new System.EventHandler(this.mManageStudentBtn_Click);
            // 
            // mManageBookBtn
            // 
            this.mManageBookBtn.Location = new System.Drawing.Point(0, 355);
            this.mManageBookBtn.Name = "mManageBookBtn";
            this.mManageBookBtn.Size = new System.Drawing.Size(200, 52);
            this.mManageBookBtn.TabIndex = 2;
            this.mManageBookBtn.Text = "Manage Books";
            this.mManageBookBtn.UseSelectable = true;
            this.mManageBookBtn.Click += new System.EventHandler(this.mManageBookBtn_Click);
            // 
            // addressTF
            // 
            this.addressTF.Location = new System.Drawing.Point(315, 211);
            this.addressTF.Name = "addressTF";
            this.addressTF.Size = new System.Drawing.Size(151, 51);
            this.addressTF.TabIndex = 40;
            this.addressTF.Text = "";
            // 
            // dobTF
            // 
            this.dobTF.Location = new System.Drawing.Point(570, 176);
            this.dobTF.MinimumSize = new System.Drawing.Size(0, 29);
            this.dobTF.Name = "dobTF";
            this.dobTF.Size = new System.Drawing.Size(221, 29);
            this.dobTF.TabIndex = 39;
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
            // mLibarianBtn
            // 
            this.mLibarianBtn.Location = new System.Drawing.Point(0, 278);
            this.mLibarianBtn.Name = "mLibarianBtn";
            this.mLibarianBtn.Size = new System.Drawing.Size(200, 52);
            this.mLibarianBtn.TabIndex = 1;
            this.mLibarianBtn.Text = "Manage Librarian";
            this.mLibarianBtn.UseSelectable = true;
            this.mLibarianBtn.Click += new System.EventHandler(this.mLibarianBtn_Click);
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
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 562);
            this.panel1.TabIndex = 27;
            // 
            // mLogoutBtn
            // 
            this.mLogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mLogoutBtn.Location = new System.Drawing.Point(0, 432);
            this.mLogoutBtn.Name = "mLogoutBtn";
            this.mLogoutBtn.Size = new System.Drawing.Size(200, 52);
            this.mLogoutBtn.TabIndex = 3;
            this.mLogoutBtn.Text = "Logout";
            this.mLogoutBtn.UseSelectable = true;
            this.mLogoutBtn.Click += new System.EventHandler(this.mLogoutBtn_Click);
            // 
            // mDashboardBtn
            // 
            this.mDashboardBtn.Location = new System.Drawing.Point(0, 124);
            this.mDashboardBtn.Name = "mDashboardBtn";
            this.mDashboardBtn.Size = new System.Drawing.Size(200, 52);
            this.mDashboardBtn.TabIndex = 0;
            this.mDashboardBtn.Text = "Dashboard";
            this.mDashboardBtn.UseSelectable = true;
            this.mDashboardBtn.Click += new System.EventHandler(this.mDashboardBtn_Click);
            // 
            // mTextSearch
            // 
            // 
            // 
            // 
            this.mTextSearch.CustomButton.Image = null;
            this.mTextSearch.CustomButton.Location = new System.Drawing.Point(554, 1);
            this.mTextSearch.CustomButton.Name = "";
            this.mTextSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTextSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTextSearch.CustomButton.TabIndex = 1;
            this.mTextSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTextSearch.CustomButton.UseSelectable = true;
            this.mTextSearch.CustomButton.Visible = false;
            this.mTextSearch.Lines = new string[0];
            this.mTextSearch.Location = new System.Drawing.Point(215, 115);
            this.mTextSearch.MaxLength = 32767;
            this.mTextSearch.Name = "mTextSearch";
            this.mTextSearch.PasswordChar = '\0';
            this.mTextSearch.PromptText = "Search By Name or ID";
            this.mTextSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTextSearch.SelectedText = "";
            this.mTextSearch.SelectionLength = 0;
            this.mTextSearch.SelectionStart = 0;
            this.mTextSearch.ShortcutsEnabled = true;
            this.mTextSearch.Size = new System.Drawing.Size(576, 23);
            this.mTextSearch.TabIndex = 47;
            this.mTextSearch.UseSelectable = true;
            this.mTextSearch.WaterMark = "Search By Name or ID";
            this.mTextSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mTextSearch.TextChanged += new System.EventHandler(this.mTextSearch_TextChanged);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(246, 227);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(63, 19);
            this.metroLabel15.TabIndex = 35;
            this.metroLabel15.Text = "Address :";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(473, 180);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(91, 19);
            this.metroLabel14.TabIndex = 34;
            this.metroLabel14.Text = "Date of Birth :";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(504, 140);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(59, 19);
            this.metroLabel13.TabIndex = 33;
            this.metroLabel13.Text = "Gender :";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(233, 180);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(76, 19);
            this.metroLabel12.TabIndex = 32;
            this.metroLabel12.Text = "Full Name :";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(233, 141);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(76, 19);
            this.metroLabel11.TabIndex = 31;
            this.metroLabel11.Text = "Student ID :";
            // 
            // emailTF
            // 
            // 
            // 
            // 
            this.emailTF.CustomButton.Image = null;
            this.emailTF.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.emailTF.CustomButton.Name = "";
            this.emailTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emailTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailTF.CustomButton.TabIndex = 1;
            this.emailTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailTF.CustomButton.UseSelectable = true;
            this.emailTF.CustomButton.Visible = false;
            this.emailTF.Lines = new string[0];
            this.emailTF.Location = new System.Drawing.Point(315, 282);
            this.emailTF.MaxLength = 32767;
            this.emailTF.Name = "emailTF";
            this.emailTF.PasswordChar = '\0';
            this.emailTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTF.SelectedText = "";
            this.emailTF.SelectionLength = 0;
            this.emailTF.SelectionStart = 0;
            this.emailTF.ShortcutsEnabled = true;
            this.emailTF.Size = new System.Drawing.Size(151, 23);
            this.emailTF.TabIndex = 29;
            this.emailTF.UseSelectable = true;
            this.emailTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // fullnameTF
            // 
            // 
            // 
            // 
            this.fullnameTF.CustomButton.Image = null;
            this.fullnameTF.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.fullnameTF.CustomButton.Name = "";
            this.fullnameTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fullnameTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fullnameTF.CustomButton.TabIndex = 1;
            this.fullnameTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fullnameTF.CustomButton.UseSelectable = true;
            this.fullnameTF.CustomButton.Visible = false;
            this.fullnameTF.Lines = new string[0];
            this.fullnameTF.Location = new System.Drawing.Point(315, 176);
            this.fullnameTF.MaxLength = 32767;
            this.fullnameTF.Name = "fullnameTF";
            this.fullnameTF.PasswordChar = '\0';
            this.fullnameTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fullnameTF.SelectedText = "";
            this.fullnameTF.SelectionLength = 0;
            this.fullnameTF.SelectionStart = 0;
            this.fullnameTF.ShortcutsEnabled = true;
            this.fullnameTF.Size = new System.Drawing.Size(151, 23);
            this.fullnameTF.TabIndex = 28;
            this.fullnameTF.UseSelectable = true;
            this.fullnameTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fullnameTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.fullnameTF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fullnameTF_KeyPress);
            // 
            // studentIdTF2
            // 
            // 
            // 
            // 
            this.studentIdTF2.CustomButton.Image = null;
            this.studentIdTF2.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.studentIdTF2.CustomButton.Name = "";
            this.studentIdTF2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.studentIdTF2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.studentIdTF2.CustomButton.TabIndex = 1;
            this.studentIdTF2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.studentIdTF2.CustomButton.UseSelectable = true;
            this.studentIdTF2.CustomButton.Visible = false;
            this.studentIdTF2.Lines = new string[0];
            this.studentIdTF2.Location = new System.Drawing.Point(315, 141);
            this.studentIdTF2.MaxLength = 32767;
            this.studentIdTF2.Name = "studentIdTF2";
            this.studentIdTF2.PasswordChar = '\0';
            this.studentIdTF2.ReadOnly = true;
            this.studentIdTF2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.studentIdTF2.SelectedText = "";
            this.studentIdTF2.SelectionLength = 0;
            this.studentIdTF2.SelectionStart = 0;
            this.studentIdTF2.ShortcutsEnabled = true;
            this.studentIdTF2.Size = new System.Drawing.Size(151, 23);
            this.studentIdTF2.TabIndex = 26;
            this.studentIdTF2.UseSelectable = true;
            this.studentIdTF2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.studentIdTF2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.studentIdTF2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.studentIdTF2_KeyPress);
            // 
            // phoneTF
            // 
            // 
            // 
            // 
            this.phoneTF.CustomButton.Image = null;
            this.phoneTF.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.phoneTF.CustomButton.Name = "";
            this.phoneTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.phoneTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.phoneTF.CustomButton.TabIndex = 1;
            this.phoneTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.phoneTF.CustomButton.UseSelectable = true;
            this.phoneTF.CustomButton.Visible = false;
            this.phoneTF.Lines = new string[0];
            this.phoneTF.Location = new System.Drawing.Point(315, 321);
            this.phoneTF.MaxLength = 32767;
            this.phoneTF.Name = "phoneTF";
            this.phoneTF.PasswordChar = '\0';
            this.phoneTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phoneTF.SelectedText = "";
            this.phoneTF.SelectionLength = 0;
            this.phoneTF.SelectionStart = 0;
            this.phoneTF.ShortcutsEnabled = true;
            this.phoneTF.Size = new System.Drawing.Size(151, 23);
            this.phoneTF.TabIndex = 30;
            this.phoneTF.UseSelectable = true;
            this.phoneTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.phoneTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.phoneTF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTF_KeyPress);
            // 
            // mAddStudentBtn
            // 
            this.mAddStudentBtn.Location = new System.Drawing.Point(388, 53);
            this.mAddStudentBtn.Name = "mAddStudentBtn";
            this.mAddStudentBtn.Size = new System.Drawing.Size(95, 45);
            this.mAddStudentBtn.TabIndex = 48;
            this.mAddStudentBtn.Text = "Add Student";
            this.mAddStudentBtn.UseSelectable = true;
            this.mAddStudentBtn.Click += new System.EventHandler(this.mAddStudentBtn_Click);
            // 
            // mViewStudentBtn
            // 
            this.mViewStudentBtn.Location = new System.Drawing.Point(504, 53);
            this.mViewStudentBtn.Name = "mViewStudentBtn";
            this.mViewStudentBtn.Size = new System.Drawing.Size(90, 45);
            this.mViewStudentBtn.TabIndex = 49;
            this.mViewStudentBtn.Text = "View Student";
            this.mViewStudentBtn.UseSelectable = true;
            // 
            // uploadStudentPic
            // 
            this.uploadStudentPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uploadStudentPic.Location = new System.Drawing.Point(570, 211);
            this.uploadStudentPic.Name = "uploadStudentPic";
            this.uploadStudentPic.Size = new System.Drawing.Size(221, 96);
            this.uploadStudentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uploadStudentPic.TabIndex = 50;
            this.uploadStudentPic.TabStop = false;
            // 
            // genderTF
            // 
            // 
            // 
            // 
            this.genderTF.CustomButton.Image = null;
            this.genderTF.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.genderTF.CustomButton.Name = "";
            this.genderTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.genderTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.genderTF.CustomButton.TabIndex = 1;
            this.genderTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.genderTF.CustomButton.UseSelectable = true;
            this.genderTF.CustomButton.Visible = false;
            this.genderTF.Lines = new string[0];
            this.genderTF.Location = new System.Drawing.Point(569, 140);
            this.genderTF.MaxLength = 32767;
            this.genderTF.Name = "genderTF";
            this.genderTF.PasswordChar = '\0';
            this.genderTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.genderTF.SelectedText = "";
            this.genderTF.SelectionLength = 0;
            this.genderTF.SelectionStart = 0;
            this.genderTF.ShortcutsEnabled = true;
            this.genderTF.Size = new System.Drawing.Size(222, 23);
            this.genderTF.TabIndex = 51;
            this.genderTF.UseSelectable = true;
            this.genderTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.genderTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.genderTF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.genderTF_KeyPress);
            // 
            // mLibViewStdBtn
            // 
            this.mLibViewStdBtn.Location = new System.Drawing.Point(700, 53);
            this.mLibViewStdBtn.Name = "mLibViewStdBtn";
            this.mLibViewStdBtn.Size = new System.Drawing.Size(91, 45);
            this.mLibViewStdBtn.TabIndex = 53;
            this.mLibViewStdBtn.Text = "View Student";
            this.mLibViewStdBtn.UseSelectable = true;
            this.mLibViewStdBtn.Visible = false;
            // 
            // mLibAddStdBtn
            // 
            this.mLibAddStdBtn.Location = new System.Drawing.Point(603, 53);
            this.mLibAddStdBtn.Name = "mLibAddStdBtn";
            this.mLibAddStdBtn.Size = new System.Drawing.Size(91, 45);
            this.mLibAddStdBtn.TabIndex = 52;
            this.mLibAddStdBtn.Text = "Add Student";
            this.mLibAddStdBtn.UseSelectable = true;
            this.mLibAddStdBtn.Visible = false;
            this.mLibAddStdBtn.Click += new System.EventHandler(this.mLibAddStdBtn_Click);
            // 
            // mBackToDashBoard
            // 
            this.mBackToDashBoard.Location = new System.Drawing.Point(273, 53);
            this.mBackToDashBoard.Name = "mBackToDashBoard";
            this.mBackToDashBoard.Size = new System.Drawing.Size(95, 45);
            this.mBackToDashBoard.TabIndex = 54;
            this.mBackToDashBoard.Text = "Back To Dashboard";
            this.mBackToDashBoard.UseSelectable = true;
            this.mBackToDashBoard.Visible = false;
            this.mBackToDashBoard.Click += new System.EventHandler(this.mBackToDashBoard_Click);
            // 
            // ViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 607);
            this.Controls.Add(this.mBackToDashBoard);
            this.Controls.Add(this.mLibViewStdBtn);
            this.Controls.Add(this.mLibAddStdBtn);
            this.Controls.Add(this.genderTF);
            this.Controls.Add(this.uploadStudentPic);
            this.Controls.Add(this.mViewStudentBtn);
            this.Controls.Add(this.mAddStudentBtn);
            this.Controls.Add(this.mClearBtn);
            this.Controls.Add(this.mDeleteBtn);
            this.Controls.Add(this.mUpdateDataBtn);
            this.Controls.Add(this.dgbStudent);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.mUpdateImageBtn);
            this.Controls.Add(this.addressTF);
            this.Controls.Add(this.dobTF);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mTextSearch);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.emailTF);
            this.Controls.Add(this.fullnameTF);
            this.Controls.Add(this.studentIdTF2);
            this.Controls.Add(this.phoneTF);
            this.Name = "ViewStudent";
            this.Text = "View Student";
            ((System.ComponentModel.ISupportInitialize)(this.dgbStudent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadStudentPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mClearBtn;
        private MetroFramework.Controls.MetroButton mDeleteBtn;
        private MetroFramework.Controls.MetroButton mUpdateDataBtn;
        private System.Windows.Forms.DataGridView dgbStudent;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private System.Windows.Forms.Label labelUserID;
        private MetroFramework.Controls.MetroButton mUpdateImageBtn;
        private MetroFramework.Controls.MetroButton mManageStudentBtn;
        private MetroFramework.Controls.MetroButton mManageBookBtn;
        private System.Windows.Forms.RichTextBox addressTF;
        private MetroFramework.Controls.MetroDateTime dobTF;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton mLibarianBtn;
        public System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton mLogoutBtn;
        private MetroFramework.Controls.MetroButton mDashboardBtn;
        private MetroFramework.Controls.MetroTextBox mTextSearch;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox emailTF;
        private MetroFramework.Controls.MetroTextBox fullnameTF;
        private MetroFramework.Controls.MetroTextBox studentIdTF2;
        private MetroFramework.Controls.MetroTextBox phoneTF;
        public MetroFramework.Controls.MetroButton mAddStudentBtn;
        public MetroFramework.Controls.MetroButton mViewStudentBtn;
        private System.Windows.Forms.PictureBox uploadStudentPic;
        private MetroFramework.Controls.MetroTextBox genderTF;
        public MetroFramework.Controls.MetroButton mLibViewStdBtn;
        public MetroFramework.Controls.MetroButton mLibAddStdBtn;
        public MetroFramework.Controls.MetroButton mBackToDashBoard;
    }
}