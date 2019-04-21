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
    public partial class ChangePassword : MetroFramework.Forms.MetroForm
    {
        private string userId;
        private string password;

        public Information info = new Information();
        public Operations opr = new Operations();
        public Dbconnection con = new Dbconnection();

        public ChangePassword(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            FetchPassword();
            SetName();
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


        private void mLogoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
        #endregion menu panel

        private void mCancelBtn_Click(object sender, EventArgs e)
        {
            StudentPanel studentPanel = new StudentPanel(userId);
            this.Hide();
            studentPanel.Show();
            
        }

        private void FetchPassword()
        {
            con.getcon();
            string query = "select * from login where userId = '" + userId + "'";
            SqlCommand cmd = new SqlCommand(query, con.getcon());
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                password = (sdr["password"].ToString());
            
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

        private void mConfirmBtn_Click(object sender, EventArgs e)
        {
            info.userId = userId;
            info.password = newTF.Text;

            try
            {


                if (password == oldTF.Text && newTF.Text == conTF.Text)
                {
                    if (newTF.Text.Length < 4)
                    {
                        MessageBox.Show("Choose atleast 4 Length password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {

                        opr.updateInLogin(info);

                        MessageBox.Show("Successfully Changed", "Success", MessageBoxButtons.OK);
                        oldTF.Text = "";
                        newTF.Text = "";
                        conTF.Text = "";
                        MessageBox.Show("Session Expired! Login Again.", "Success", MessageBoxButtons.OK);
                        // Application.Exit();
                        Login fl = new Login();
                        fl.Show();
                        this.Close();
                    }


                }
                else
                {
                    MessageBox.Show("Password didn't match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    oldTF.Text = "";
                    newTF.Text = "";
                    conTF.Text = "";
                }
            }
            catch (Exception ex)
            {


            }
        }

        private void mLibCancelBtn_Click(object sender, EventArgs e)
        {
            LibrarianPanel librarianPanel = new LibrarianPanel(userId);
            this.Hide();
            librarianPanel.Show();
        }

        private void mBackToDashboardBtn_Click(object sender, EventArgs e)
        {
            LibrarianPanel librarianPanel = new LibrarianPanel(userId);
            this.Hide();
            librarianPanel.Show();
        }
    }
}
