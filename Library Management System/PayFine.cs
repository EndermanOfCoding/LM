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
    public partial class PayFine : MetroFramework.Forms.MetroForm
    {
        private string userId;

        public Information info = new Information();
        public Operations opr = new Operations();
        public Dbconnection con = new Dbconnection();

        public PayFine(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            SetName();
            mPayFeeBtn.Enabled = false;
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            con.getcon();
            string query = "select * from student where studentId = '" +mSTID.Text+mStudentTextField.Text + "'";
           
            string query1 = "select * from feesTable where studentId = '" + mSTID.Text + mStudentTextField.Text + "'";
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
            mPayFeeBtn.Enabled = true;
        }

        private void mPayFeeBtn_Click(object sender, EventArgs e)
        {
            if (mStudentTextField.Text == "")
            {
                MessageBox.Show("Enter Student ID");
            }
            else
            {
                info.userId = mSTID.Text + mStudentTextField.Text;
                opr.deleteFromFees(info);
                mStudentTextField.Enabled = true;
                clear();
            }

        }

        private void clear()
        {
            fullnameTF.Text = "";
            feesTF.Text = "";
            mStudentTextField.Text = "";
        }

        private void mClearBtn_Click(object sender, EventArgs e)
        {
            clear();
            mStudentTextField.Enabled = true;
        }

        #region menu panel
        private void mDashboardBtn_Click(object sender, EventArgs e)
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

        #endregion menu panel
    }
}
