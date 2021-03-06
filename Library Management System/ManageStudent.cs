﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BEL;
using BAL;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class ManageStudent : MetroFramework.Forms.MetroForm
    {

        public Information info = new Information();
        public Operations opr = new Operations();
        public Dbconnection con = new Dbconnection();

        private string userId;
        string imgLocation = "";
        public ManageStudent(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            labelUserID.Text = userId;
            SetName();
        }

        private void SetName()
        {
            con.getcon();
            string query1 = "select * from librarian where librarianId = '" + userId + "'";
            SqlCommand cmdd = new SqlCommand(query1, con.getcon());
            SqlDataReader sd = cmdd.ExecuteReader();
            if (sd.Read())
            {
                mUserID.Text = (sd["librarianName"].ToString());
                byte[] pic = (byte[])sd["librarianImage"];
                MemoryStream ms = new MemoryStream(pic);
                ms.Seek(0, SeekOrigin.Begin);

                pictureBoxAdmin.Image = Image.FromStream(ms);

            }
            con.getcon().Close();
        }

        #region menu panel
        private void mDashboardBtn_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel(userId);
            this.Hide();
            adminPanel.Show();
        }

        private void mManageBookBtn_Click(object sender, EventArgs e)
        {
            ManageBook manageBook = new ManageBook(userId);
            this.Hide();
            manageBook.Show();

        }

        private void mLibarianBtn_Click(object sender, EventArgs e)
        {
            ManageLibarian manageLibarian = new ManageLibarian(userId);
            this.Hide();
            manageLibarian.Show();
        }


        private void mLogoutBtn_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            this.Hide();
            login.Show();
        }


        private void mViewStudentBtn_Click(object sender, EventArgs e)
        {
            ViewStudent viewStudent = new ViewStudent(userId);
            this.Hide();
            viewStudent.Show();
        }


        #endregion menu panel

        private void mStudentImageUploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgLocation = ofd.FileName.ToString();
                uploadStudentPic.ImageLocation = imgLocation;
            }
        }

        private void mAddStudentBtn_Click(object sender, EventArgs e)
        {
            // Declaring the picture box in byte type.
            byte[] uploadStudentpic = null;

            // check for input integer value.
            int result = 0;
            if (int.TryParse(fullnameTF.Text, out result) || int.TryParse(addressTF.Text, out result) || int.TryParse(emailTF.Text, out result))
            {
                MessageBox.Show("Enter Valid Name.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                int rlt = 0;

                // field empty check
                if (studentidTF.Text.Length == 0 || passwordTF.Text.Length == 0 || fullnameTF.Text.Length == 0 || genderBox.Text.Length == 0 || datepickTF.Text.Length == 0 || addressTF.Text.Length == 0 || emailTF.Text.Length == 0 || phoneTF2.Text.Length == 0 || uploadStudentPic.Image == null)
                {
                    MessageBox.Show("opps! Something Went Wrong.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // insert into Student
                else
                {
                    // converting img in binary value.
                    FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    uploadStudentpic = br.ReadBytes((int)fs.Length);

                    //Check mobile number

                    if (phoneTF2.Text.Length > 10 || phoneTF2.Text.Length < 10)
                    {
                        MessageBox.Show("Enter Valid Mobile number.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // BAL & BEL Operation
                    else if (int.TryParse(phoneTF2.Text, out rlt))
                    {
                        info.studentId = studentidTF.Text + studentidTF2.Text;
                        info.password = passwordTF.Text;
                        info.studentName = fullnameTF.Text;
                        info.studentGender = genderBox.Text;
                        info.studentDOB = datepickTF.Text;
                        info.studentAddress = addressTF.Text;
                        info.studentEmail = emailTF.Text;
                        info.studentPhone = Convert.ToInt64(phoneTF.Text + phoneTF2.Text);
                        info.studentImage = uploadStudentpic;
                        info.stat = 2;

                        try
                        {
                            opr.insertStudent(info);
                            opr.insertIntoStudentLogin(info);

                            MessageBox.Show("Information Saved successfully.", "Success", MessageBoxButtons.OK);
                            // clear field
                            clearStudentField();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Already exist User.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Valid Mobile number.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void clearStudentField()
        {
            studentidTF2.Text = "";
            passwordTF.Text = "";
            fullnameTF.Text = "";
            genderBox.Text = "";
            datepickTF.Text = "";
            addressTF.Text = "";
            emailTF.Text = "";
            phoneTF2.Text = "";
            uploadStudentPic.Image = null;
        }

        private void passwordAutoGen_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            passwordTF.Text = (rnd.Next(89999999) + 10000000 + "");
            passwordAutoGen.Enabled = false;
        }

        #region field validation
        private void fullnameTF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void phoneTF2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion field validation 

        #region additional menu panel
        private void mLibViewBtn_Click(object sender, EventArgs e)
        {
            ViewStudent viewStudent = new ViewStudent(userId);
            this.Hide();
            viewStudent.panel1.Visible = false;
            viewStudent.mLibAddStdBtn.Visible = true;
            viewStudent.mLibViewStdBtn.Visible = true;
            viewStudent.mAddStudentBtn.Visible = false;
            viewStudent.mLibViewStdBtn.Visible = false;
            viewStudent.mBackToDashBoard.Visible = true;

            viewStudent.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            LibrarianPanel librarianPanel = new LibrarianPanel(userId);
            this.Hide();
            librarianPanel.Show();
        }

        private void mIssueBookBtn_Click(object sender, EventArgs e)
        {
            IssueBook issueBook = new IssueBook(userId);
            this.Hide();
            issueBook.Show();
        }

        private void mReturnBookBtn_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook(userId);
            this.Hide();
            returnBook.Show();
        }

        private void mPayFineBtn_Click(object sender, EventArgs e)
        {
            PayFine payFee = new PayFine(userId);
            this.Hide();
            payFee.Show();
        }

        private void mChangePasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(userId);
            this.Hide();
            changePassword.mDashboardBtn.Visible = false;
            changePassword.mViewBookBtn.Visible = false;
            changePassword.mCurrentBorrowBtn.Visible = false;
            changePassword.mMyInformationBtn.Visible = false;
            changePassword.mChangePasswordBtn.Visible = false;
            changePassword.mLogoutBtn.Visible = false;
            changePassword.panel1.Visible = false;

            changePassword.mCancelBtn.Visible = false;
            changePassword.mLibCancelBtn.Visible = true;


            changePassword.mBackToDashboardBtn.Visible = true;

            changePassword.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
        #endregion additional menu panel

    }
}
