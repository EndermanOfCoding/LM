namespace Library_Management_System
{
    partial class StudentPanel
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
            this.labelBooksCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelFees = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 578);
            this.panel1.TabIndex = 54;
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
            this.mChangePasswordBtn.Click += new System.EventHandler(this.mChangePasswordBtn_Click);
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
            
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(14, 32);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 50);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "TOTAL\r\nBOOK";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // labelBooksCount
            // 
            this.labelBooksCount.AutoSize = true;
            this.labelBooksCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBooksCount.Location = new System.Drawing.Point(20, 32);
            this.labelBooksCount.Name = "labelBooksCount";
            this.labelBooksCount.Size = new System.Drawing.Size(57, 63);
            this.labelBooksCount.TabIndex = 1;
            this.labelBooksCount.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.labelBooksCount);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(361, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 122);
            this.panel2.TabIndex = 56;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel6.Controls.Add(this.metroLabel1);
            this.panel6.Location = new System.Drawing.Point(107, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(93, 124);
            this.panel6.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.labelFees);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(361, 354);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 122);
            this.panel3.TabIndex = 57;
            // 
            // labelFees
            // 
            this.labelFees.AutoSize = true;
            this.labelFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFees.Location = new System.Drawing.Point(20, 32);
            this.labelFees.Name = "labelFees";
            this.labelFees.Size = new System.Drawing.Size(57, 63);
            this.labelFees.TabIndex = 1;
            this.labelFees.Text = "0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.metroLabel2);
            this.panel4.Location = new System.Drawing.Point(107, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(93, 124);
            this.panel4.TabIndex = 0;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(21, 51);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 25);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "FEES";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // StudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 629);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentPanel";
            this.Text = "Student Panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label labelBooksCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBoxAdmin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelFees;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}