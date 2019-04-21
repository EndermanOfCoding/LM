namespace Library_Management_System
{
    partial class AdminPanel
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
            this.labelUserID = new System.Windows.Forms.Label();
            this.mManageStudentBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mLogoutBtn = new MetroFramework.Controls.MetroButton();
            this.mManageBookBtn = new MetroFramework.Controls.MetroButton();
            this.mLibarianBtn = new MetroFramework.Controls.MetroButton();
            this.mDashboardBtn = new MetroFramework.Controls.MetroButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelTotalLibarian = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.labelTotalBook = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.labelBookIssued = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTotalStudent = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 479);
            this.panel1.TabIndex = 0;
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
            this.mLibarianBtn.Click += new System.EventHandler(this.mLibarianBtn_Click);
            // 
            // mDashboardBtn
            // 
            this.mDashboardBtn.Location = new System.Drawing.Point(0, 96);
            this.mDashboardBtn.Name = "mDashboardBtn";
            this.mDashboardBtn.Size = new System.Drawing.Size(200, 52);
            this.mDashboardBtn.TabIndex = 0;
            this.mDashboardBtn.Text = "Dashboard";
            this.mDashboardBtn.UseSelectable = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.labelTotalLibarian);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Location = new System.Drawing.Point(492, 281);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 124);
            this.panel5.TabIndex = 4;
            // 
            // labelTotalLibarian
            // 
            this.labelTotalLibarian.AutoSize = true;
            this.labelTotalLibarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalLibarian.Location = new System.Drawing.Point(25, 42);
            this.labelTotalLibarian.Name = "labelTotalLibarian";
            this.labelTotalLibarian.Size = new System.Drawing.Size(57, 63);
            this.labelTotalLibarian.TabIndex = 1;
            this.labelTotalLibarian.Text = "0";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel9.Controls.Add(this.metroLabel4);
            this.panel9.Location = new System.Drawing.Point(107, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(93, 124);
            this.panel9.TabIndex = 0;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(1, 42);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(97, 50);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "TOTAL \r\nLIBARIAN";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
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
            // labelTotalBook
            // 
            this.labelTotalBook.AutoSize = true;
            this.labelTotalBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBook.Location = new System.Drawing.Point(20, 32);
            this.labelTotalBook.Name = "labelTotalBook";
            this.labelTotalBook.Size = new System.Drawing.Size(57, 63);
            this.labelTotalBook.TabIndex = 1;
            this.labelTotalBook.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.labelTotalBook);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(258, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 124);
            this.panel2.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel8.Controls.Add(this.metroLabel2);
            this.panel8.Location = new System.Drawing.Point(107, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(93, 124);
            this.panel8.TabIndex = 0;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(10, 42);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 50);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "BOOK \r\nISSUED";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // labelBookIssued
            // 
            this.labelBookIssued.AutoSize = true;
            this.labelBookIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookIssued.Location = new System.Drawing.Point(20, 42);
            this.labelBookIssued.Name = "labelBookIssued";
            this.labelBookIssued.Size = new System.Drawing.Size(57, 63);
            this.labelBookIssued.TabIndex = 1;
            this.labelBookIssued.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.labelBookIssued);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Location = new System.Drawing.Point(258, 281);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 124);
            this.panel3.TabIndex = 2;
            // 
            // labelTotalStudent
            // 
            this.labelTotalStudent.AutoSize = true;
            this.labelTotalStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalStudent.Location = new System.Drawing.Point(25, 32);
            this.labelTotalStudent.Name = "labelTotalStudent";
            this.labelTotalStudent.Size = new System.Drawing.Size(57, 63);
            this.labelTotalStudent.TabIndex = 0;
            this.labelTotalStudent.Text = "0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.labelTotalStudent);
            this.panel4.Location = new System.Drawing.Point(492, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 124);
            this.panel4.TabIndex = 3;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(1, 32);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 50);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "TOTAL\r\nSTUDENT";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel7.Controls.Add(this.metroLabel3);
            this.panel7.Location = new System.Drawing.Point(599, 97);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(93, 124);
            this.panel7.TabIndex = 0;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 533);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.Text = "Admin Panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton mLogoutBtn;
        private MetroFramework.Controls.MetroButton mManageBookBtn;
        private MetroFramework.Controls.MetroButton mLibarianBtn;
        private MetroFramework.Controls.MetroButton mDashboardBtn;
        private MetroFramework.Controls.MetroButton mManageStudentBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Label labelTotalLibarian;
        private System.Windows.Forms.Label labelUserID;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Panel panel6;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label labelTotalBook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Label labelBookIssued;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTotalStudent;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Panel panel7;
    }
}