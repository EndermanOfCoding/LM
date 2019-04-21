namespace Library_Management_System
{
    partial class PayFine
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
            this.mPayFineBtn = new MetroFramework.Controls.MetroButton();
            this.mReturnBookBtn = new MetroFramework.Controls.MetroButton();
            this.mIssueBookBtn = new MetroFramework.Controls.MetroButton();
            this.mDashboardBtn = new MetroFramework.Controls.MetroButton();
            this.pictureBoxAdmin = new System.Windows.Forms.PictureBox();
            this.mUserID = new System.Windows.Forms.Label();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mStudentTextField = new MetroFramework.Controls.MetroTextBox();
            this.feesTF = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.fullnameTF = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.mSTID = new MetroFramework.Controls.MetroTextBox();
            this.mPayFeeBtn = new MetroFramework.Controls.MetroButton();
            this.mClearBtn = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.mManageStudetnBtn);
            this.panel1.Controls.Add(this.mLogoutBtn);
            this.panel1.Controls.Add(this.mChangePasswordBtn);
            this.panel1.Controls.Add(this.mPayFineBtn);
            this.panel1.Controls.Add(this.mReturnBookBtn);
            this.panel1.Controls.Add(this.mIssueBookBtn);
            this.panel1.Controls.Add(this.mDashboardBtn);
            this.panel1.Controls.Add(this.pictureBoxAdmin);
            this.panel1.Controls.Add(this.mUserID);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 541);
            this.panel1.TabIndex = 56;
            // 
            // mManageStudetnBtn
            // 
            this.mManageStudetnBtn.Location = new System.Drawing.Point(0, 385);
            this.mManageStudetnBtn.Name = "mManageStudetnBtn";
            this.mManageStudetnBtn.Size = new System.Drawing.Size(200, 37);
            this.mManageStudetnBtn.TabIndex = 63;
            this.mManageStudetnBtn.Text = "Manage Student";
            this.mManageStudetnBtn.UseSelectable = true;
            this.mManageStudetnBtn.Click += new System.EventHandler(this.mManageStudetnBtn_Click);
            // 
            // mLogoutBtn
            // 
            this.mLogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mLogoutBtn.Location = new System.Drawing.Point(0, 499);
            this.mLogoutBtn.Name = "mLogoutBtn";
            this.mLogoutBtn.Size = new System.Drawing.Size(200, 37);
            this.mLogoutBtn.TabIndex = 62;
            this.mLogoutBtn.Text = "Logout";
            this.mLogoutBtn.UseSelectable = true;
            this.mLogoutBtn.Click += new System.EventHandler(this.mLogoutBtn_Click);
            // 
            // mChangePasswordBtn
            // 
            this.mChangePasswordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mChangePasswordBtn.Location = new System.Drawing.Point(0, 442);
            this.mChangePasswordBtn.Name = "mChangePasswordBtn";
            this.mChangePasswordBtn.Size = new System.Drawing.Size(200, 37);
            this.mChangePasswordBtn.TabIndex = 61;
            this.mChangePasswordBtn.Text = "Change Password";
            this.mChangePasswordBtn.UseSelectable = true;
            this.mChangePasswordBtn.Click += new System.EventHandler(this.mChangePasswordBtn_Click);
            // 
            // mPayFineBtn
            // 
            this.mPayFineBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mPayFineBtn.Location = new System.Drawing.Point(0, 328);
            this.mPayFineBtn.Name = "mPayFineBtn";
            this.mPayFineBtn.Size = new System.Drawing.Size(200, 37);
            this.mPayFineBtn.TabIndex = 60;
            this.mPayFineBtn.Text = "Pay Fine";
            this.mPayFineBtn.UseSelectable = true;
            // 
            // mReturnBookBtn
            // 
            this.mReturnBookBtn.Location = new System.Drawing.Point(0, 271);
            this.mReturnBookBtn.Name = "mReturnBookBtn";
            this.mReturnBookBtn.Size = new System.Drawing.Size(200, 37);
            this.mReturnBookBtn.TabIndex = 59;
            this.mReturnBookBtn.Text = "Return Book";
            this.mReturnBookBtn.UseSelectable = true;
            this.mReturnBookBtn.Click += new System.EventHandler(this.mReturnBookBtn_Click);
            // 
            // mIssueBookBtn
            // 
            this.mIssueBookBtn.Location = new System.Drawing.Point(0, 214);
            this.mIssueBookBtn.Name = "mIssueBookBtn";
            this.mIssueBookBtn.Size = new System.Drawing.Size(200, 37);
            this.mIssueBookBtn.TabIndex = 58;
            this.mIssueBookBtn.Text = "Issue Book";
            this.mIssueBookBtn.UseSelectable = true;
            this.mIssueBookBtn.Click += new System.EventHandler(this.mIssueBookBtn_Click);
            // 
            // mDashboardBtn
            // 
            this.mDashboardBtn.Location = new System.Drawing.Point(0, 157);
            this.mDashboardBtn.Name = "mDashboardBtn";
            this.mDashboardBtn.Size = new System.Drawing.Size(200, 37);
            this.mDashboardBtn.TabIndex = 57;
            this.mDashboardBtn.Text = "Dashboard";
            this.mDashboardBtn.UseSelectable = true;
            this.mDashboardBtn.Click += new System.EventHandler(this.mDashboardBtn_Click);
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(363, 170);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 57;
            this.metroLabel1.Text = "Student ID :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(402, 277);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 58;
            this.metroLabel2.Text = "Fee :";
            // 
            // mStudentTextField
            // 
            // 
            // 
            // 
            this.mStudentTextField.CustomButton.Image = null;
            this.mStudentTextField.CustomButton.Location = new System.Drawing.Point(101, 1);
            this.mStudentTextField.CustomButton.Name = "";
            this.mStudentTextField.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mStudentTextField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mStudentTextField.CustomButton.TabIndex = 1;
            this.mStudentTextField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mStudentTextField.CustomButton.UseSelectable = true;
            this.mStudentTextField.CustomButton.Visible = false;
            this.mStudentTextField.Lines = new string[0];
            this.mStudentTextField.Location = new System.Drawing.Point(479, 167);
            this.mStudentTextField.MaxLength = 32767;
            this.mStudentTextField.Name = "mStudentTextField";
            this.mStudentTextField.PasswordChar = '\0';
            this.mStudentTextField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mStudentTextField.SelectedText = "";
            this.mStudentTextField.SelectionLength = 0;
            this.mStudentTextField.SelectionStart = 0;
            this.mStudentTextField.ShortcutsEnabled = true;
            this.mStudentTextField.Size = new System.Drawing.Size(123, 23);
            this.mStudentTextField.TabIndex = 61;
            this.mStudentTextField.UseSelectable = true;
            this.mStudentTextField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mStudentTextField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // feesTF
            // 
            // 
            // 
            // 
            this.feesTF.CustomButton.Image = null;
            this.feesTF.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.feesTF.CustomButton.Name = "";
            this.feesTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.feesTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.feesTF.CustomButton.TabIndex = 1;
            this.feesTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.feesTF.CustomButton.UseSelectable = true;
            this.feesTF.CustomButton.Visible = false;
            this.feesTF.Lines = new string[0];
            this.feesTF.Location = new System.Drawing.Point(445, 277);
            this.feesTF.MaxLength = 32767;
            this.feesTF.Name = "feesTF";
            this.feesTF.PasswordChar = '\0';
            this.feesTF.ReadOnly = true;
            this.feesTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.feesTF.SelectedText = "";
            this.feesTF.SelectionLength = 0;
            this.feesTF.SelectionStart = 0;
            this.feesTF.ShortcutsEnabled = true;
            this.feesTF.Size = new System.Drawing.Size(157, 23);
            this.feesTF.TabIndex = 62;
            this.feesTF.UseSelectable = true;
            this.feesTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.feesTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(339, 220);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(100, 19);
            this.metroLabel4.TabIndex = 64;
            this.metroLabel4.Text = "Student Name :";
            // 
            // fullnameTF
            // 
            // 
            // 
            // 
            this.fullnameTF.CustomButton.Image = null;
            this.fullnameTF.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.fullnameTF.CustomButton.Name = "";
            this.fullnameTF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fullnameTF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fullnameTF.CustomButton.TabIndex = 1;
            this.fullnameTF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fullnameTF.CustomButton.UseSelectable = true;
            this.fullnameTF.CustomButton.Visible = false;
            this.fullnameTF.Lines = new string[0];
            this.fullnameTF.Location = new System.Drawing.Point(445, 215);
            this.fullnameTF.MaxLength = 32767;
            this.fullnameTF.Name = "fullnameTF";
            this.fullnameTF.PasswordChar = '\0';
            this.fullnameTF.ReadOnly = true;
            this.fullnameTF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fullnameTF.SelectedText = "";
            this.fullnameTF.SelectionLength = 0;
            this.fullnameTF.SelectionStart = 0;
            this.fullnameTF.ShortcutsEnabled = true;
            this.fullnameTF.Size = new System.Drawing.Size(157, 23);
            this.fullnameTF.TabIndex = 65;
            this.fullnameTF.UseSelectable = true;
            this.fullnameTF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fullnameTF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(639, 162);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(94, 36);
            this.metroButton1.TabIndex = 66;
            this.metroButton1.Text = "Load Student";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // mSTID
            // 
            // 
            // 
            // 
            this.mSTID.CustomButton.Image = null;
            this.mSTID.CustomButton.Location = new System.Drawing.Point(6, 1);
            this.mSTID.CustomButton.Name = "";
            this.mSTID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mSTID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mSTID.CustomButton.TabIndex = 1;
            this.mSTID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mSTID.CustomButton.UseSelectable = true;
            this.mSTID.CustomButton.Visible = false;
            this.mSTID.Lines = new string[] {
        "ST#"};
            this.mSTID.Location = new System.Drawing.Point(445, 167);
            this.mSTID.MaxLength = 32767;
            this.mSTID.Name = "mSTID";
            this.mSTID.PasswordChar = '\0';
            this.mSTID.ReadOnly = true;
            this.mSTID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mSTID.SelectedText = "";
            this.mSTID.SelectionLength = 0;
            this.mSTID.SelectionStart = 0;
            this.mSTID.ShortcutsEnabled = true;
            this.mSTID.Size = new System.Drawing.Size(28, 23);
            this.mSTID.TabIndex = 60;
            this.mSTID.Text = "ST#";
            this.mSTID.UseSelectable = true;
            this.mSTID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mSTID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mPayFeeBtn
            // 
            this.mPayFeeBtn.Location = new System.Drawing.Point(347, 332);
            this.mPayFeeBtn.Name = "mPayFeeBtn";
            this.mPayFeeBtn.Size = new System.Drawing.Size(126, 54);
            this.mPayFeeBtn.TabIndex = 67;
            this.mPayFeeBtn.Text = "Pay Fine";
            this.mPayFeeBtn.UseSelectable = true;
            this.mPayFeeBtn.Click += new System.EventHandler(this.mPayFeeBtn_Click);
            // 
            // mClearBtn
            // 
            this.mClearBtn.Location = new System.Drawing.Point(528, 332);
            this.mClearBtn.Name = "mClearBtn";
            this.mClearBtn.Size = new System.Drawing.Size(126, 54);
            this.mClearBtn.TabIndex = 68;
            this.mClearBtn.Text = "Clear";
            this.mClearBtn.UseSelectable = true;
            this.mClearBtn.Click += new System.EventHandler(this.mClearBtn_Click);
            // 
            // PayFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.mClearBtn);
            this.Controls.Add(this.mPayFeeBtn);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.fullnameTF);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.feesTF);
            this.Controls.Add(this.mStudentTextField);
            this.Controls.Add(this.mSTID);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel1);
            this.Name = "PayFine";
            this.Text = "Pay Fine";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxAdmin;
        private System.Windows.Forms.Label mUserID;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mStudentTextField;
        private MetroFramework.Controls.MetroTextBox feesTF;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox fullnameTF;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox mSTID;
        private MetroFramework.Controls.MetroButton mPayFeeBtn;
        private MetroFramework.Controls.MetroButton mClearBtn;
        private MetroFramework.Controls.MetroButton mManageStudetnBtn;
        private MetroFramework.Controls.MetroButton mLogoutBtn;
        private MetroFramework.Controls.MetroButton mChangePasswordBtn;
        private MetroFramework.Controls.MetroButton mPayFineBtn;
        private MetroFramework.Controls.MetroButton mReturnBookBtn;
        private MetroFramework.Controls.MetroButton mIssueBookBtn;
        private MetroFramework.Controls.MetroButton mDashboardBtn;
    }
}