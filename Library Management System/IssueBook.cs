using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BEL;
using BAL;
using System.Data.SqlClient;
using System.IO;

namespace Library_Management_System
{
    public partial class IssueBook : MetroFramework.Forms.MetroForm
    {
        private string userId;
        public Information info = new Information();
        public Operations opr = new Operations();
        public Dbconnection con = new Dbconnection();
        public IssueBook(string userId)
        {
            InitializeComponent();
            this.userId = userId;
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


        private void mLoadStudentBtn_Click(object sender, EventArgs e)
        {
            con.getcon();
            string query = "select * from student where studentId = '" + mStudentTextField.Text + "'";
            string query1 = "select * from feesTable where studentId = '" + mStudentTextField.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con.getcon());
            SqlCommand cmdd = new SqlCommand(query1, con.getcon());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlDataAdapter sdaa = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            sda.Fill(dt);
            sdaa.Fill(dt1);
            int i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("No Record Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    fullnameTF.Text = dr["studentName"].ToString();
                    genderTF.Text = dr["studentGender"].ToString();
                    dobTF.Text = dr["studentDOB"].ToString();
                    addressTF.Text = dr["studentAddress"].ToString();
                    emailTF.Text = dr["studentEmail"].ToString();
                    phoneTF.Text = dr["studentPhone"].ToString();


                    mStudentTextField.Enabled = false;
                }
                con.getcon().Close();
            }

            int j = Convert.ToInt32(dt1.Rows.Count.ToString());
            if (j > 0)
            {
                foreach (DataRow dr1 in dt1.Rows)
                {
                    feesTF.Text = dr1["fees"].ToString();
                }
            }
        }

        private void mClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void mLoadBookBtn_Click(object sender, EventArgs e)
        {
            con.getcon();
            string query = "select * from books where bookId = '" + mBookTextField.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con.getcon());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("No Record Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    booknameTF.Text = dr["bookName"].ToString();
                    authornameTF.Text = dr["authorName"].ToString();
                    publicationyearTF.Text = dr["publicationYear"].ToString();
                    quantityTF.Text = dr["quantity"].ToString();

                    mBookTextField.Enabled = false;
                }

                con.getcon().Close();
            }
        }

        private void mIssueBookBtn2_Click(object sender, EventArgs e)
        {
            info.borrowId = brwTxt1.Text + brwTxt2.Text;
            info.studentId = mStudentTextField.Text;
            info.bookId = mBookTextField.Text;
            info.borrowDate = mBorrowDateBtn.Text;
            info.returnDate = mReturnDateBtn.Text;
            //MessageBox.Show(mReturnDateBtn.Text);
            info.qty = 1;
            double x = Convert.ToDouble(feesTF.Text);


            try
            {
                if (brwTxt2.Text.Length == 0 || mBookTextField.Text.Length == 0 || mStudentTextField.Text.Length == 0)
                {
                    MessageBox.Show("opps! Something Went Wrong.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (x > 0.00)
                {
                    MessageBox.Show("Please pay the fees to Borrow book again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else
                {
                    opr.insertIntoBorrowInfo(info);
                    opr.updateBookBorrow(info);
                    MessageBox.Show("Information Saved successfully.", "Success", MessageBoxButtons.OK);
                    Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("opps! Something Went Wrong.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Clear()
        {
            fullnameTF.Text = "";
            genderTF.Text = "";
            dobTF.Text = "";
            addressTF.Text = "";
            emailTF.Text = "";
            phoneTF.Text = "";
            mBookTextField.Enabled = true;
            mStudentTextField.Enabled = true;
            mBookTextField.Text = "";
            mStudentTextField.Text = "";
            booknameTF.Text = "";
            authornameTF.Text = "";
            publicationyearTF.Text = "";
            quantityTF.Text = "";
            brwTxt2.Text = "";
            feesTF.Text = "0.00";
        }

        #region menu panel
        private void mDashboardBtn_Click(object sender, EventArgs e)
        {
            LibrarianPanel librarianPanel = new LibrarianPanel(userId);
            this.Hide();
            librarianPanel.Show();
        }

        private void mManageStudetnBtn_Click(object sender, EventArgs e)
        {
            ManageStudent manageStudent = new ManageStudent(userId);
            this.Hide();
            manageStudent.panel1.Visible = false;
            manageStudent.panel2.Visible = true;
            manageStudent.mViewStudentBtn.Visible = false;
            manageStudent.mAddStdBtn.Visible = false;
            manageStudent.mLibAddBtn.Visible = true;
            manageStudent.mLibViewBtn.Visible = true;
            manageStudent.Show();
        }


        private void mReturnBookBtn_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook(userId);
            this.Hide();
            returnBook.Show();
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


        private void mLogoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
        private void mPayFineBtn_Click(object sender, EventArgs e)
        {
            PayFine payFee = new PayFine(userId);
            this.Hide();
            payFee.Show();
        }
        #endregion menu panel
    }
}

