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
    public partial class StudentPanel : MetroFramework.Forms.MetroForm
    {
        private string userId;
        public Information info = new Information();
        public Operations opr = new Operations();
        public Dbconnection con = new Dbconnection();

        

        public StudentPanel(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            BookCount();
            SetName();
            ShowFee();
        }

        private void SetName()
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
            viewBook.SetName();
            viewBook.Show();
            
        }

        private void mCurrentBorrowBtn_Click(object sender, EventArgs e)
        {
            CurrentBorrow currentBorrow = new CurrentBorrow(userId);
            this.Hide();
            currentBorrow.Show();
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

        private void BookCount()
        {
            con.getcon();
            SqlCommand cmd = new SqlCommand("SELECT sum (quantity) FROM books", con.getcon());

            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                labelBooksCount.Text = Convert.ToString(count.ToString());
            }
            else
            {
                labelBooksCount.Text = "0";
            }
            con.getcon().Close();
        }
        private void ShowFee()
        {

            con.getcon();
            string query = "select * from feesTable where studentId = '" + userId + "'";
            SqlCommand cmd = new SqlCommand(query, con.getcon());
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                labelFees.Text = (sdr["fees"].ToString());

            }
            con.getcon().Close();
        }
    }
}
