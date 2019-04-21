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
    public partial class LibrarianPanel : MetroFramework.Forms.MetroForm
    {
        private string userId;
        public Information Information = new Information();
        public Operations operations = new Operations();
        public Dbconnection dbconnection = new Dbconnection();

        public LibrarianPanel(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            ShowBookCount();
            ShowStudentCount();
            ShowIssueCount();

            SetName();
        }

        private void SetName()
        {
            dbconnection.getcon();
            string query1 = "select * from librarian where librarianId = '" + userId + "'";
            SqlCommand cmdd = new SqlCommand(query1, dbconnection.getcon());
            SqlDataReader sd = cmdd.ExecuteReader();
            if (sd.Read())
            {
                mUserID.Text = (sd["librarianName"].ToString());
                byte[] pic = (byte[])sd["librarianImage"];
                MemoryStream ms = new MemoryStream(pic);
                ms.Seek(0, SeekOrigin.Begin);

                pictureBoxAdmin.Image = Image.FromStream(ms);

            }
            dbconnection.getcon().Close();
        }

        private void ShowBookCount()
        {


            dbconnection.getcon();

            SqlCommand cmd = new SqlCommand("SELECT sum (quantity) FROM books", dbconnection.getcon());

            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                labelBooksCount.Text = Convert.ToString(count.ToString());
            }
            else
            {
                labelBooksCount.Text = "0";
            }
            dbconnection.getcon().Close();
        }
        private void ShowStudentCount()
        {
            dbconnection.getcon();
            SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM Student", dbconnection.getcon());
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                labelStudentCount.Text = Convert.ToString(count.ToString());
            }
            else
            {
                labelStudentCount.Text = "0";

            }
            dbconnection.getcon().Close();

        }

        private void ShowIssueCount()
        {
            dbconnection.getcon();
            SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM borrowInfo", dbconnection.getcon());
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                labelBookIssued.Text = Convert.ToString(count.ToString());
            }
            else
            {
                labelBookIssued.Text = "0";

            }
            dbconnection.getcon().Close();


        }

        #region menu panel
        private void mDashboardBtn_Click(object sender, EventArgs e)
        {
            LibrarianPanel librarianPanel = new LibrarianPanel(userId);
            this.Hide();
            librarianPanel.Show();
        }
        
        private void mManageBookBtn_Click(object sender, EventArgs e)
        {
            ManageBook manageBook = new ManageBook(userId);
            this.Hide();
            manageBook.panel1.Visible = false;
            manageBook.panel22.Visible = true;
            manageBook.mLibrarianBookAddBtn.Visible = true;
            manageBook.mLibrarianViewBookAddBtn.Visible = true;
            manageBook.mViewBookBtn.Visible = false;
            manageBook.mAddBtn.Visible = false;



            manageBook.Show();
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

        private void mMyInformationBtn_Click(object sender, EventArgs e)
        {

        }

        private void mChangePasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(userId);
            this.Hide();
            changePassword.panel1.Visible = false;
            changePassword.mCancelBtn.Visible = false;
            changePassword.mLibCancelBtn.Visible = true;
            changePassword.mBackToDashboardBtn.Visible = true;
            
            changePassword.Show();
        }

        private void mActiveInactiveUserBtn_Click(object sender, EventArgs e)
        {

        }

        private void mLogoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        #endregion menu panel
    }
}
