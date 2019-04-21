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
    public partial class CurrentBorrow : MetroFramework.Forms.MetroForm
    {
        private string userId;
        public Information info = new Information();
        public Operations opr = new Operations();
        public Dbconnection con = new Dbconnection();
        public CurrentBorrow(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            SetName();
            BorrowInfo();


        }

        private void BorrowInfo()
        {
            con.getcon();
            string query = "select * from borrowInfo where studentId = '" + userId + "'";
            SqlCommand cmd = new SqlCommand(query, con.getcon());
            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {
                brwTF.Text = (sdr["borrowId"].ToString());
                bookidTF.Text = (sdr["bookId"].ToString());
                brwDateTF.Text = (sdr["borrowDate"].ToString());
                returnDateTF.Text = (sdr["returnDate"].ToString());
                /*d.addressTF.Text = (sdr["studentAddress"].ToString());
                d.emailTF.Text = (sdr["studentEmail"].ToString());
                d.phoneTF2.Text = (sdr["studentPhone"].ToString());*/
                // d.salaryTF.Text = (sdr["librarianSalary"].ToString());

            }
            con.getcon().Close();

            con.getcon();
            string query1 = "select * from books where bookId = '" + bookidTF.Text + "'";
            SqlCommand cmdd = new SqlCommand(query1, con.getcon());
            SqlDataReader sd = cmdd.ExecuteReader();
            if (sd.Read())
            {
                bookTF.Text = (sd["bookName"].ToString());
               authorTF.Text = (sd["authorName"].ToString());

            }
            con.getcon().Close();
        }

        public void SetName()
        {

            con.getcon();
            string query1 = "select * from student where studentId = '" + userId + "'";
            SqlCommand cmdd = new SqlCommand(query1, con.getcon());
            SqlDataReader sd = cmdd.ExecuteReader();
            if (sd.Read())
            {
                mUserID.Text = (sd["studentName"].ToString());
                byte[] pic = (byte[])sd["studentImage"];
                MemoryStream ms = new MemoryStream(pic);
                ms.Seek(0, SeekOrigin.Begin);

                pictureBoxAdmin.Image = Image.FromStream(ms);

            }
            con.getcon().Close();
        }

        #region menu panel
        private void mDashboardBtn_Click(object sender, EventArgs e)
        {
            StudentPanel studentPanel = new StudentPanel(userId);
            this.Hide();
            studentPanel.Show();
        }

        private void mViewBookBtn_Click(object sender, EventArgs e)
        {
            ViewBook viewBook = new ViewBook(userId);
            this.Hide();

            viewBook.BringToFront();
            //panelControl.Controls.Remove(vb);
            viewBook.mAddStudentBtn.Visible = false;
            viewBook.mViewStudentBtn.Visible = false;
            viewBook.panel1.Visible = false;
            viewBook.panel2.Visible = true;
            viewBook.mUpdateDataBtn.Visible = false;
            viewBook.mDeleteBtn.Visible = false;
            viewBook.mClearBtn.Visible = false;
            viewBook.mUpdateImageBtn.Visible = false;
            viewBook.bookidTF.ReadOnly = true;
            viewBook.booknameTF.ReadOnly = true;
            viewBook.authornameTF.ReadOnly = true;
            viewBook.quantityTF.ReadOnly = true;
            viewBook.publicationyearTF.ReadOnly = true;

            viewBook.Show();
        }
       
        private void mMyInformationBtn_Click(object sender, EventArgs e)
        {
            MyInformation myInformation = new MyInformation(userId);
            this.Hide();
            myInformation.Show();
        }

        private void mChangePasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(userId);
            this.Hide();
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
