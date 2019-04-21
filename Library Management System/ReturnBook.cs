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
    public partial class ReturnBook : MetroFramework.Forms.MetroForm
    {
        private string userId;
        public Information info = new Information();
        public Operations opr = new Operations();
        public Dbconnection con = new Dbconnection();
        public ReturnBook(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            dgvUpdate();
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

        private void mLoadBorrowBookBtn_Click(object sender, EventArgs e)
        {
            con.getcon();

            string query = "select * from borrowInfo where borrowId = '" + brwidTF1.Text + brwidTF2.Text + "'";
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
                    stdTF.Text = dr["studentId"].ToString();
                    bookidTF.Text = dr["bookId"].ToString();

                    brwTF.Text = dr["borrowDate"].ToString();
                    rtnTF.Text = dr["returnDate"].ToString();
                    

                    brwidTF2.Enabled = false;
                    bookidTF.Enabled = false;
                    brwTF.Enabled = false;
                    rtnTF.Enabled = false;
                }
            }
        }

        private void dgvUpdate()
        {
            DataTable dt = new DataTable();
            dt = opr.ViewBorrow(info);
            dgvBorrow.DataSource = dt;

            dgvBorrow.Columns[0].HeaderCell.Value = "Borrow Id";
            dgvBorrow.Columns[1].HeaderCell.Value = "Student Id";
            dgvBorrow.Columns[2].HeaderCell.Value = "Book Id";
            dgvBorrow.Columns[3].HeaderCell.Value = "Borrow Date";
            dgvBorrow.Columns[4].HeaderCell.Value = "Return Date";
        }

        private void dgvBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBorrow.Rows[e.RowIndex];


                brwidTF2.Text = row.Cells["borrowId"].Value.ToString().Substring(3);
                stdTF.Text = row.Cells["studentId"].Value.ToString();
                bookidTF.Text = row.Cells["bookId"].Value.ToString();
                brwTF.Text = row.Cells["borrowDate"].Value.ToString();
                rtnTF.Text = row.Cells["returnDate"].Value.ToString();

                brwidTF2.Enabled = false;
                bookidTF.Enabled = false;
                brwTF.Enabled = false;
                rtnTF.Enabled = false;

            }
            else { }
        }

        private void mReturnBookBtn2_Click(object sender, EventArgs e)
        {
            info.borrowId = brwidTF1.Text + brwidTF2.Text;
            info.studentId = stdTF.Text;
            info.bookId = bookidTF.Text;
            info.borrowDate = brwTF.Text;
            info.returnDate = rtnTF.Text;
            info.qty = 1;

            info.orginalReturnDate = oDateTF.Text;
            if (brwidTF2.Text.Length == 0)
            {
                MessageBox.Show("Enter Borrow Id ", "Alert", MessageBoxButtons.OK);

            }
            else
            {
                try
                {
                    opr.deleteFromBorrowInfo(info);
                    opr.updateBookReturn(info);
                    DateTime sdt = brwTF.Value.Date;
                    DateTime edt = oDateTF.Value.Date;

                    TimeSpan ts = edt - sdt;
                    int days = ts.Days;
                    //label1.Text = days.ToString() + "days";
                    double fine = 0;

                    if (days <= 7)
                    {
                        fine = 0;
                        MessageBox.Show("Timely Returned Fees = '" + fine + "'", "Success", MessageBoxButtons.OK);
                    }
                    else if (days > 7 && days <= 10)
                    {
                        fine = (days - 7) * 10;
                        MessageBox.Show("Returned After '" + days + "' days. Fees = '" + fine + "' Tk", "Success", MessageBoxButtons.OK);
                        info.fees = fine;
                        opr.InsertintoFees(info);

                    }
                    else if (days > 10 && days <= 30)
                    {
                        fine = 3 * 10 + (days - 10) * 15;
                        MessageBox.Show("Returned After '" + days + "' days. Fees = '" + fine + "' Tk", "Success", MessageBoxButtons.OK);
                        info.fees = fine;
                        opr.InsertintoFees(info);
                    }
                    else
                    {
                        fine = 3 * 10 + 20 * 15 + 20;
                        MessageBox.Show("Returned After '" + days + "' days. Fees = '" + fine + "' Tk, Your MemberShip Cancel Please Contact Librarian ", "Success", MessageBoxButtons.OK);
                        info.fees = fine;
                        opr.InsertintoFees(info);
                        opr.updateLogin(info);
                    }

                    // MessageBox.Show("Book Return Successfully !", "Success", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Went Wrong ", "Alert", MessageBoxButtons.OK);
                }
            }


            clean();
            dgvUpdate();
        }

        private void clean()
        {
            brwidTF2.Text = "";
            stdTF.Text = "";
            bookidTF.Text = "";
            brwTF.Text = "";
            rtnTF.Text = "";
        }

        private void mCancelBtn_Click(object sender, EventArgs e)
        {
            clean();
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

        private void mPayFineBtn_Click(object sender, EventArgs e)
        {
            PayFine payFee = new PayFine(userId);
            this.Hide();
            payFee.Show();
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
