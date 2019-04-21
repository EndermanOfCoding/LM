namespace Library_Management_System
{
    partial class ChangePassword
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
            this.pictureBoxAdmin = new System.Windows.Forms.PictureBox();
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
            this.oldTF = new MetroFramework.Controls.MetroTextBox();
            this.newTF = new MetroFramework.Controls.MetroTextBox();
            this.conTF = new MetroFramework.Controls.MetroTextBox();
            this.mConfirmBtn = new MetroFramework.Controls.MetroButton();
            this.mCancelBtn = new MetroFramework.Controls.MetroButton();
            this.mLibCancelBtn = new MetroFramework.Controls.MetroButton();
            this.mBackToDashboardBtn = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 578);
            this.panel1.TabIndex = 55;
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
            // mChangePasswordBtn
            // 
            this.mChangePasswordBtn.Location = new System.Drawing.Point(0, 443);
            this.mChangePasswordBtn.Name = "mChangePasswordBtn";
            this.mChangePasswordBtn.Size = new System.Drawing.Size(200, 52);
            this.mChangePasswordBtn.TabIndex = 7;
            this.mChangePasswordBtn.Text = "Change Password";
            this.mChangePasswordBtn.UseSelectable = true;
            // 
            // mUserID
            // 
            this.mUserID.AutoSize = true;
            this.mUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mUserID.Location = new System.Drawing.Point(69, 130);
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
            this.mMyInformationBtn.Click += new System.EventHandler(this.mMyInformationBtn_Click);
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
            this.metroLabel1.Location = new System.Drawing.Point(340, 198);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 19);
            this.metroLabel1.TabIndex = 56;
            this.metroLabel1.Text = "Old Password : ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(340, 255);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 19);
            this.metroLabel2.TabIndex = 57;
            this.metroLabel2.Text = "New Password :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(318, 308);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(122, 19);
            this.metroLabel3.TabIndex = 58;
            this.metroLabel3.Text = "Confirm Password :";
            // 
            // oldTF
            // 
            // 
            // 
            // 
            this.oldTF.CustomButton.Image = null;
            this.oldTF.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.oldTF.CustomButton.Name = "";
            this.oldTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.oldTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.oldTF.CustomButton.TabIndex = 1;
            this.oldTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.oldTF.CustomButton.UseSelectable = true;
            this.oldTF.CustomButton.Visible = false;
            this.oldTF.Lines = new string[0];
            this.oldTF.Location = new System.Drawing.Point(460, 196);
            this.oldTF.MaxLength = 32767;
            this.oldTF.Name = "oldTF";
            this.oldTF.PasswordChar = '\0';
            this.oldTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.oldTF.SelectedText = "";
            this.oldTF.SelectionLength = 0;
            this.oldTF.SelectionStart = 0;
            this.oldTF.ShortcutsEnabled = true;
            this.oldTF.Size = new System.Drawing.Size(201, 23);
            this.oldTF.TabIndex = 61;
            this.oldTF.UseSelectable = true;
            this.oldTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.oldTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // newTF
            // 
            // 
            // 
            // 
            this.newTF.CustomButton.Image = null;
            this.newTF.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.newTF.CustomButton.Name = "";
            this.newTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.newTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.newTF.CustomButton.TabIndex = 1;
            this.newTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.newTF.CustomButton.UseSelectable = true;
            this.newTF.CustomButton.Visible = false;
            this.newTF.Lines = new string[0];
            this.newTF.Location = new System.Drawing.Point(460, 253);
            this.newTF.MaxLength = 32767;
            this.newTF.Name = "newTF";
            this.newTF.PasswordChar = '\0';
            this.newTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.newTF.SelectedText = "";
            this.newTF.SelectionLength = 0;
            this.newTF.SelectionStart = 0;
            this.newTF.ShortcutsEnabled = true;
            this.newTF.Size = new System.Drawing.Size(201, 23);
            this.newTF.TabIndex = 62;
            this.newTF.UseSelectable = true;
            this.newTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.newTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // conTF
            // 
            // 
            // 
            // 
            this.conTF.CustomButton.Image = null;
            this.conTF.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.conTF.CustomButton.Name = "";
            this.conTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.conTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.conTF.CustomButton.TabIndex = 1;
            this.conTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.conTF.CustomButton.UseSelectable = true;
            this.conTF.CustomButton.Visible = false;
            this.conTF.Lines = new string[0];
            this.conTF.Location = new System.Drawing.Point(460, 306);
            this.conTF.MaxLength = 32767;
            this.conTF.Name = "conTF";
            this.conTF.PasswordChar = '\0';
            this.conTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.conTF.SelectedText = "";
            this.conTF.SelectionLength = 0;
            this.conTF.SelectionStart = 0;
            this.conTF.ShortcutsEnabled = true;
            this.conTF.Size = new System.Drawing.Size(201, 23);
            this.conTF.TabIndex = 63;
            this.conTF.UseSelectable = true;
            this.conTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.conTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mConfirmBtn
            // 
            this.mConfirmBtn.Location = new System.Drawing.Point(381, 384);
            this.mConfirmBtn.Name = "mConfirmBtn";
            this.mConfirmBtn.Size = new System.Drawing.Size(102, 39);
            this.mConfirmBtn.TabIndex = 64;
            this.mConfirmBtn.Text = "Confirm";
            this.mConfirmBtn.UseSelectable = true;
            this.mConfirmBtn.Click += new System.EventHandler(this.mConfirmBtn_Click);
            // 
            // mCancelBtn
            // 
            this.mCancelBtn.Location = new System.Drawing.Point(537, 384);
            this.mCancelBtn.Name = "mCancelBtn";
            this.mCancelBtn.Size = new System.Drawing.Size(102, 39);
            this.mCancelBtn.TabIndex = 65;
            this.mCancelBtn.Text = "Cancel";
            this.mCancelBtn.UseSelectable = true;
            this.mCancelBtn.Click += new System.EventHandler(this.mCancelBtn_Click);
            // 
            // mLibCancelBtn
            // 
            this.mLibCancelBtn.Location = new System.Drawing.Point(645, 384);
            this.mLibCancelBtn.Name = "mLibCancelBtn";
            this.mLibCancelBtn.Size = new System.Drawing.Size(102, 39);
            this.mLibCancelBtn.TabIndex = 66;
            this.mLibCancelBtn.Text = "Cancel";
            this.mLibCancelBtn.UseSelectable = true;
            this.mLibCancelBtn.Visible = false;
            this.mLibCancelBtn.Click += new System.EventHandler(this.mLibCancelBtn_Click);
            // 
            // mBackToDashboardBtn
            // 
            this.mBackToDashboardBtn.Location = new System.Drawing.Point(381, 63);
            this.mBackToDashboardBtn.Name = "mBackToDashboardBtn";
            this.mBackToDashboardBtn.Size = new System.Drawing.Size(222, 78);
            this.mBackToDashboardBtn.TabIndex = 67;
            this.mBackToDashboardBtn.Text = "Back to Dashboard";
            this.mBackToDashboardBtn.UseSelectable = true;
            this.mBackToDashboardBtn.Visible = false;
            this.mBackToDashboardBtn.Click += new System.EventHandler(this.mBackToDashboardBtn_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 631);
            this.Controls.Add(this.mBackToDashboardBtn);
            this.Controls.Add(this.mLibCancelBtn);
            this.Controls.Add(this.mCancelBtn);
            this.Controls.Add(this.mConfirmBtn);
            this.Controls.Add(this.conTF);
            this.Controls.Add(this.newTF);
            this.Controls.Add(this.oldTF);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel1);
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxAdmin;
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
        private MetroFramework.Controls.MetroTextBox oldTF;
        private MetroFramework.Controls.MetroTextBox newTF;
        private MetroFramework.Controls.MetroTextBox conTF;
        public MetroFramework.Controls.MetroButton mConfirmBtn;
        public MetroFramework.Controls.MetroButton mCancelBtn;
        public MetroFramework.Controls.MetroButton mLibCancelBtn;
        public MetroFramework.Controls.MetroButton mBackToDashboardBtn;
    }
}