namespace Library_Management_System
{
    partial class ViewBook
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
            this.quantityTF = new MetroFramework.Controls.MetroTextBox();
            this.mManageStudentBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mLogoutBtn = new MetroFramework.Controls.MetroButton();
            this.mManageBookBtn = new MetroFramework.Controls.MetroButton();
            this.mLibarianBtn = new MetroFramework.Controls.MetroButton();
            this.mDashboardBtn = new MetroFramework.Controls.MetroButton();
            this.viewBookPic = new System.Windows.Forms.PictureBox();
            this.mViewStudentBtn = new MetroFramework.Controls.MetroButton();
            this.mAddStudentBtn = new MetroFramework.Controls.MetroButton();
            this.mClearBtn = new MetroFramework.Controls.MetroButton();
            this.mDeleteBtn = new MetroFramework.Controls.MetroButton();
            this.mUpdateDataBtn = new MetroFramework.Controls.MetroButton();
            this.dgbBook = new System.Windows.Forms.DataGridView();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.mUpdateImageBtn = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUserID = new System.Windows.Forms.Label();
            this.mTextSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.authornameTF = new MetroFramework.Controls.MetroTextBox();
            this.booknameTF = new MetroFramework.Controls.MetroTextBox();
            this.bookidTF = new MetroFramework.Controls.MetroTextBox();
            this.publicationyearTF = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxAdmin = new System.Windows.Forms.PictureBox();
            this.mSPChangePasswordBtn = new MetroFramework.Controls.MetroButton();
            this.mUserID = new System.Windows.Forms.Label();
            this.mSPViewBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mSPLogoutBtn = new MetroFramework.Controls.MetroButton();
            this.mSPMyInformationBtn = new MetroFramework.Controls.MetroButton();
            this.mSPCurrentBorrowBtn = new MetroFramework.Controls.MetroButton();
            this.mSPDashboardBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.viewBookPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbBook)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // quantityTF
            // 
            // 
            // 
            // 
            this.quantityTF.CustomButton.Image = null;
            this.quantityTF.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.quantityTF.CustomButton.Name = "";
            this.quantityTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.quantityTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.quantityTF.CustomButton.TabIndex = 1;
            this.quantityTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.quantityTF.CustomButton.UseSelectable = true;
            this.quantityTF.CustomButton.Visible = false;
            this.quantityTF.Lines = new string[0];
            this.quantityTF.Location = new System.Drawing.Point(315, 279);
            this.quantityTF.MaxLength = 32767;
            this.quantityTF.Name = "quantityTF";
            this.quantityTF.PasswordChar = '\0';
            this.quantityTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.quantityTF.SelectedText = "";
            this.quantityTF.SelectionLength = 0;
            this.quantityTF.SelectionStart = 0;
            this.quantityTF.ShortcutsEnabled = true;
            this.quantityTF.Size = new System.Drawing.Size(222, 23);
            this.quantityTF.TabIndex = 75;
            this.quantityTF.UseSelectable = true;
            this.quantityTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.quantityTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.quantityTF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.genderTF_KeyPress);
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
            this.mLogoutBtn.Location = new System.Drawing.Point(0, 432);
            this.mLogoutBtn.Name = "mLogoutBtn";
            this.mLogoutBtn.Size = new System.Drawing.Size(200, 52);
            this.mLogoutBtn.TabIndex = 3;
            this.mLogoutBtn.Text = "Logout";
            this.mLogoutBtn.UseSelectable = true;
            this.mLogoutBtn.Click += new System.EventHandler(this.mLogoutBtn_Click);
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
            // viewBookPic
            // 
            this.viewBookPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viewBookPic.Location = new System.Drawing.Point(570, 145);
            this.viewBookPic.Name = "viewBookPic";
            this.viewBookPic.Size = new System.Drawing.Size(221, 161);
            this.viewBookPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viewBookPic.TabIndex = 74;
            this.viewBookPic.TabStop = false;
            // 
            // mViewStudentBtn
            // 
            this.mViewStudentBtn.Location = new System.Drawing.Point(504, 53);
            this.mViewStudentBtn.Name = "mViewStudentBtn";
            this.mViewStudentBtn.Size = new System.Drawing.Size(100, 45);
            this.mViewStudentBtn.TabIndex = 73;
            this.mViewStudentBtn.Text = "View Book";
            this.mViewStudentBtn.UseSelectable = true;
            this.mViewStudentBtn.Click += new System.EventHandler(this.mViewStudentBtn_Click);
            // 
            // mAddStudentBtn
            // 
            this.mAddStudentBtn.Location = new System.Drawing.Point(372, 53);
            this.mAddStudentBtn.Name = "mAddStudentBtn";
            this.mAddStudentBtn.Size = new System.Drawing.Size(100, 45);
            this.mAddStudentBtn.TabIndex = 72;
            this.mAddStudentBtn.Text = "Add Book";
            this.mAddStudentBtn.UseSelectable = true;
            this.mAddStudentBtn.Click += new System.EventHandler(this.mAddStudentBtn_Click);
            // 
            // mClearBtn
            // 
            this.mClearBtn.Location = new System.Drawing.Point(570, 363);
            this.mClearBtn.Name = "mClearBtn";
            this.mClearBtn.Size = new System.Drawing.Size(90, 44);
            this.mClearBtn.TabIndex = 70;
            this.mClearBtn.Text = "Clear Fields";
            this.mClearBtn.UseSelectable = true;
            this.mClearBtn.Click += new System.EventHandler(this.mClearBtn_Click);
            // 
            // mDeleteBtn
            // 
            this.mDeleteBtn.Location = new System.Drawing.Point(456, 363);
            this.mDeleteBtn.Name = "mDeleteBtn";
            this.mDeleteBtn.Size = new System.Drawing.Size(90, 44);
            this.mDeleteBtn.TabIndex = 69;
            this.mDeleteBtn.Text = "Delete";
            this.mDeleteBtn.UseSelectable = true;
            this.mDeleteBtn.Click += new System.EventHandler(this.mDeleteBtn_Click);
            // 
            // mUpdateDataBtn
            // 
            this.mUpdateDataBtn.Location = new System.Drawing.Point(338, 363);
            this.mUpdateDataBtn.Name = "mUpdateDataBtn";
            this.mUpdateDataBtn.Size = new System.Drawing.Size(90, 44);
            this.mUpdateDataBtn.TabIndex = 68;
            this.mUpdateDataBtn.Text = "Update";
            this.mUpdateDataBtn.UseSelectable = true;
            this.mUpdateDataBtn.Click += new System.EventHandler(this.mUpdateDataBtn_Click);
            // 
            // dgbBook
            // 
            this.dgbBook.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgbBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbBook.Location = new System.Drawing.Point(212, 419);
            this.dgbBook.Name = "dgbBook";
            this.dgbBook.Size = new System.Drawing.Size(579, 164);
            this.dgbBook.TabIndex = 67;
            this.dgbBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbBook_CellContentClick);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(205, 237);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(96, 19);
            this.metroLabel16.TabIndex = 62;
            this.metroLabel16.Text = "Author Name :";
            // 
            // mUpdateImageBtn
            // 
            this.mUpdateImageBtn.Location = new System.Drawing.Point(637, 314);
            this.mUpdateImageBtn.Name = "mUpdateImageBtn";
            this.mUpdateImageBtn.Size = new System.Drawing.Size(87, 31);
            this.mUpdateImageBtn.TabIndex = 66;
            this.mUpdateImageBtn.Text = "Update Image";
            this.mUpdateImageBtn.UseSelectable = true;
            this.mUpdateImageBtn.Click += new System.EventHandler(this.mUpdateImageBtn_Click);
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
            this.panel1.Location = new System.Drawing.Point(3, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 541);
            this.panel1.TabIndex = 53;
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
            this.mTextSearch.TabIndex = 71;
            this.mTextSearch.UseSelectable = true;
            this.mTextSearch.WaterMark = "Search By Name or ID";
            this.mTextSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTextSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mTextSearch.TextChanged += new System.EventHandler(this.mTextSearch_TextChanged);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(207, 328);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(94, 19);
            this.metroLabel14.TabIndex = 60;
            this.metroLabel14.Text = "Pulication Year";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(236, 279);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(65, 19);
            this.metroLabel13.TabIndex = 59;
            this.metroLabel13.Text = "Quantity :";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(215, 193);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(86, 19);
            this.metroLabel12.TabIndex = 58;
            this.metroLabel12.Text = "Book Name :";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(239, 145);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(62, 19);
            this.metroLabel11.TabIndex = 57;
            this.metroLabel11.Text = "Book ID :";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // authornameTF
            // 
            // 
            // 
            // 
            this.authornameTF.CustomButton.Image = null;
            this.authornameTF.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.authornameTF.CustomButton.Name = "";
            this.authornameTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.authornameTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.authornameTF.CustomButton.TabIndex = 1;
            this.authornameTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.authornameTF.CustomButton.UseSelectable = true;
            this.authornameTF.CustomButton.Visible = false;
            this.authornameTF.Lines = new string[0];
            this.authornameTF.Location = new System.Drawing.Point(315, 233);
            this.authornameTF.MaxLength = 32767;
            this.authornameTF.Name = "authornameTF";
            this.authornameTF.PasswordChar = '\0';
            this.authornameTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.authornameTF.SelectedText = "";
            this.authornameTF.SelectionLength = 0;
            this.authornameTF.SelectionStart = 0;
            this.authornameTF.ShortcutsEnabled = true;
            this.authornameTF.Size = new System.Drawing.Size(222, 23);
            this.authornameTF.TabIndex = 55;
            this.authornameTF.UseSelectable = true;
            this.authornameTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.authornameTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.authornameTF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.authornameTF_KeyPress);
            // 
            // booknameTF
            // 
            // 
            // 
            // 
            this.booknameTF.CustomButton.Image = null;
            this.booknameTF.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.booknameTF.CustomButton.Name = "";
            this.booknameTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.booknameTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.booknameTF.CustomButton.TabIndex = 1;
            this.booknameTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.booknameTF.CustomButton.UseSelectable = true;
            this.booknameTF.CustomButton.Visible = false;
            this.booknameTF.Lines = new string[0];
            this.booknameTF.Location = new System.Drawing.Point(315, 189);
            this.booknameTF.MaxLength = 32767;
            this.booknameTF.Name = "booknameTF";
            this.booknameTF.PasswordChar = '\0';
            this.booknameTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.booknameTF.SelectedText = "";
            this.booknameTF.SelectionLength = 0;
            this.booknameTF.SelectionStart = 0;
            this.booknameTF.ShortcutsEnabled = true;
            this.booknameTF.Size = new System.Drawing.Size(222, 23);
            this.booknameTF.TabIndex = 54;
            this.booknameTF.UseSelectable = true;
            this.booknameTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.booknameTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bookidTF
            // 
            // 
            // 
            // 
            this.bookidTF.CustomButton.Image = null;
            this.bookidTF.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.bookidTF.CustomButton.Name = "";
            this.bookidTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.bookidTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bookidTF.CustomButton.TabIndex = 1;
            this.bookidTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bookidTF.CustomButton.UseSelectable = true;
            this.bookidTF.CustomButton.Visible = false;
            this.bookidTF.Lines = new string[0];
            this.bookidTF.Location = new System.Drawing.Point(315, 145);
            this.bookidTF.MaxLength = 32767;
            this.bookidTF.Name = "bookidTF";
            this.bookidTF.PasswordChar = '\0';
            this.bookidTF.ReadOnly = true;
            this.bookidTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bookidTF.SelectedText = "";
            this.bookidTF.SelectionLength = 0;
            this.bookidTF.SelectionStart = 0;
            this.bookidTF.ShortcutsEnabled = true;
            this.bookidTF.Size = new System.Drawing.Size(222, 23);
            this.bookidTF.TabIndex = 52;
            this.bookidTF.UseSelectable = true;
            this.bookidTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bookidTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // publicationyearTF
            // 
            // 
            // 
            // 
            this.publicationyearTF.CustomButton.Image = null;
            this.publicationyearTF.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.publicationyearTF.CustomButton.Name = "";
            this.publicationyearTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.publicationyearTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.publicationyearTF.CustomButton.TabIndex = 1;
            this.publicationyearTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.publicationyearTF.CustomButton.UseSelectable = true;
            this.publicationyearTF.CustomButton.Visible = false;
            this.publicationyearTF.Lines = new string[0];
            this.publicationyearTF.Location = new System.Drawing.Point(315, 322);
            this.publicationyearTF.MaxLength = 32767;
            this.publicationyearTF.Name = "publicationyearTF";
            this.publicationyearTF.PasswordChar = '\0';
            this.publicationyearTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.publicationyearTF.SelectedText = "";
            this.publicationyearTF.SelectionLength = 0;
            this.publicationyearTF.SelectionStart = 0;
            this.publicationyearTF.ShortcutsEnabled = true;
            this.publicationyearTF.Size = new System.Drawing.Size(222, 23);
            this.publicationyearTF.TabIndex = 76;
            this.publicationyearTF.UseSelectable = true;
            this.publicationyearTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.publicationyearTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.publicationyearTF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.publicationyearTF_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.pictureBoxAdmin);
            this.panel2.Controls.Add(this.mSPChangePasswordBtn);
            this.panel2.Controls.Add(this.mUserID);
            this.panel2.Controls.Add(this.mSPViewBtn);
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Controls.Add(this.mSPLogoutBtn);
            this.panel2.Controls.Add(this.mSPMyInformationBtn);
            this.panel2.Controls.Add(this.mSPCurrentBorrowBtn);
            this.panel2.Controls.Add(this.mSPDashboardBtn);
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 541);
            this.panel2.TabIndex = 55;
            this.panel2.Visible = false;
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
            // mSPChangePasswordBtn
            // 
            this.mSPChangePasswordBtn.Location = new System.Drawing.Point(0, 407);
            this.mSPChangePasswordBtn.Name = "mSPChangePasswordBtn";
            this.mSPChangePasswordBtn.Size = new System.Drawing.Size(200, 52);
            this.mSPChangePasswordBtn.TabIndex = 7;
            this.mSPChangePasswordBtn.Text = "Change Password";
            this.mSPChangePasswordBtn.UseSelectable = true;
            this.mSPChangePasswordBtn.Click += new System.EventHandler(this.mSPChangePasswordBtn_Click);
            // 
            // mUserID
            // 
            this.mUserID.AutoSize = true;
            this.mUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mUserID.Location = new System.Drawing.Point(54, 130);
            this.mUserID.Name = "mUserID";
            this.mUserID.Size = new System.Drawing.Size(49, 24);
            this.mUserID.TabIndex = 6;
            this.mUserID.Text = "User";
            // 
            // mSPViewBtn
            // 
            this.mSPViewBtn.Location = new System.Drawing.Point(0, 224);
            this.mSPViewBtn.Name = "mSPViewBtn";
            this.mSPViewBtn.Size = new System.Drawing.Size(200, 52);
            this.mSPViewBtn.TabIndex = 4;
            this.mSPViewBtn.Text = "View Book";
            this.mSPViewBtn.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(58, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "WELCOME";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // mSPLogoutBtn
            // 
            this.mSPLogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mSPLogoutBtn.Location = new System.Drawing.Point(-1, 468);
            this.mSPLogoutBtn.Name = "mSPLogoutBtn";
            this.mSPLogoutBtn.Size = new System.Drawing.Size(200, 52);
            this.mSPLogoutBtn.TabIndex = 3;
            this.mSPLogoutBtn.Text = "Logout";
            this.mSPLogoutBtn.UseSelectable = true;
            this.mSPLogoutBtn.Click += new System.EventHandler(this.mSPLogoutBtn_Click);
            // 
            // mSPMyInformationBtn
            // 
            this.mSPMyInformationBtn.Location = new System.Drawing.Point(-1, 346);
            this.mSPMyInformationBtn.Name = "mSPMyInformationBtn";
            this.mSPMyInformationBtn.Size = new System.Drawing.Size(200, 52);
            this.mSPMyInformationBtn.TabIndex = 2;
            this.mSPMyInformationBtn.Text = "My Information";
            this.mSPMyInformationBtn.UseSelectable = true;
            this.mSPMyInformationBtn.Click += new System.EventHandler(this.mSPMyInformationBtn_Click);
            // 
            // mSPCurrentBorrowBtn
            // 
            this.mSPCurrentBorrowBtn.Location = new System.Drawing.Point(0, 285);
            this.mSPCurrentBorrowBtn.Name = "mSPCurrentBorrowBtn";
            this.mSPCurrentBorrowBtn.Size = new System.Drawing.Size(200, 52);
            this.mSPCurrentBorrowBtn.TabIndex = 1;
            this.mSPCurrentBorrowBtn.Text = "Current Borrow";
            this.mSPCurrentBorrowBtn.UseSelectable = true;
            this.mSPCurrentBorrowBtn.Click += new System.EventHandler(this.mSPCurrentBorrowBtn_Click);
            // 
            // mSPDashboardBtn
            // 
            this.mSPDashboardBtn.Location = new System.Drawing.Point(0, 163);
            this.mSPDashboardBtn.Name = "mSPDashboardBtn";
            this.mSPDashboardBtn.Size = new System.Drawing.Size(200, 52);
            this.mSPDashboardBtn.TabIndex = 0;
            this.mSPDashboardBtn.Text = "Dashboard";
            this.mSPDashboardBtn.UseSelectable = true;
            this.mSPDashboardBtn.Click += new System.EventHandler(this.mSPDashboardBtn_Click);
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.publicationyearTF);
            this.Controls.Add(this.quantityTF);
            this.Controls.Add(this.viewBookPic);
            this.Controls.Add(this.mViewStudentBtn);
            this.Controls.Add(this.mAddStudentBtn);
            this.Controls.Add(this.mClearBtn);
            this.Controls.Add(this.mDeleteBtn);
            this.Controls.Add(this.mUpdateDataBtn);
            this.Controls.Add(this.dgbBook);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.mUpdateImageBtn);
            this.Controls.Add(this.mTextSearch);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.authornameTF);
            this.Controls.Add(this.booknameTF);
            this.Controls.Add(this.bookidTF);
            this.Controls.Add(this.panel2);
            this.Name = "ViewBook";
            this.Text = "View Book";
            ((System.ComponentModel.ISupportInitialize)(this.viewBookPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbBook)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroTextBox quantityTF;
        public MetroFramework.Controls.MetroButton mManageStudentBtn;
        public MetroFramework.Controls.MetroLabel metroLabel5;
        public MetroFramework.Controls.MetroButton mLogoutBtn;
        public MetroFramework.Controls.MetroButton mManageBookBtn;
        public MetroFramework.Controls.MetroButton mLibarianBtn;
        public MetroFramework.Controls.MetroButton mDashboardBtn;
        public System.Windows.Forms.PictureBox viewBookPic;
        public MetroFramework.Controls.MetroButton mViewStudentBtn;
        public MetroFramework.Controls.MetroButton mAddStudentBtn;
        public MetroFramework.Controls.MetroButton mClearBtn;
        public MetroFramework.Controls.MetroButton mDeleteBtn;
        public MetroFramework.Controls.MetroButton mUpdateDataBtn;
        public System.Windows.Forms.DataGridView dgbBook;
        public MetroFramework.Controls.MetroLabel metroLabel16;
        public MetroFramework.Controls.MetroButton mUpdateImageBtn;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label labelUserID;
        public MetroFramework.Controls.MetroTextBox mTextSearch;
        public MetroFramework.Controls.MetroLabel metroLabel14;
        public MetroFramework.Controls.MetroLabel metroLabel13;
        public MetroFramework.Controls.MetroLabel metroLabel12;
        public MetroFramework.Controls.MetroLabel metroLabel11;
        public MetroFramework.Controls.MetroTextBox authornameTF;
        public MetroFramework.Controls.MetroTextBox booknameTF;
        public MetroFramework.Controls.MetroTextBox bookidTF;
        public MetroFramework.Controls.MetroTextBox publicationyearTF;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxAdmin;
        private MetroFramework.Controls.MetroButton mSPChangePasswordBtn;
        private System.Windows.Forms.Label mUserID;
        private MetroFramework.Controls.MetroButton mSPViewBtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton mSPLogoutBtn;
        private MetroFramework.Controls.MetroButton mSPMyInformationBtn;
        private MetroFramework.Controls.MetroButton mSPCurrentBorrowBtn;
        private MetroFramework.Controls.MetroButton mSPDashboardBtn;
    }
}