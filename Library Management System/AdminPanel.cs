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

namespace Library_Management_System
{
    public partial class AdminPanel : MetroFramework.Forms.MetroForm
    {
        public Information Information = new Information();
        public Operations operations = new Operations();
        public Dbconnection dbconnection = new Dbconnection();

        private string userId;


        public AdminPanel(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            labelUserID.Text = userId;
            ShowCountBooks();
            ShowCountLibrarian();
            ShowCountStudent();
            ShowCountIssue();
            
        }

        //counting books and showing in dashboard

        #region show number of book in dashboard
        private void ShowCountBooks()
        {
            Int32 count = operations.BookCount();

            if (count > 0)
            {
                labelTotalBook.Text = Convert.ToString(count.ToString());
            }
            else
            {
                labelTotalBook.Text = "0";
            }
            
        }
        #endregion

        private void ShowCountLibrarian()
        {
            Int32 count = operations.LibrarianCount();
            if (count > 0)
            {
                labelTotalLibarian.Text = Convert.ToString(count.ToString());
            }
            else
            {
                labelTotalLibarian.Text = "0";

            }
        }
        private void ShowCountStudent()
        {
            Int32 count = operations.StudentCount();

            if (count > 0)
            {
                labelTotalStudent.Text = Convert.ToString(count.ToString());
            }
            else
            {
                labelTotalStudent.Text = "0";

            }
            dbconnection.getcon().Close();

        }

        private void ShowCountIssue()
        {
            
            Int32 count = operations.IssueCount();
            if (count > 0)
            {
                labelBookIssued.Text = Convert.ToString(count.ToString());
            }
            else
            {
                labelBookIssued.Text = "0";
            }
           
        }

        #region menu panel
        
        private void mManageStudentBtn_Click(object sender, EventArgs e)
        {
            ManageStudent manageStudent = new ManageStudent(userId);
            this.Hide();
            manageStudent.Show();
        }

        private void mLibarianBtn_Click(object sender, EventArgs e)
        {
            ManageLibarian manageLibarian = new ManageLibarian(userId);
            this.Hide();
            manageLibarian.Show();
        }

        private void mManageBookBtn_Click(object sender, EventArgs e)
        {
            ManageBook manageBook = new ManageBook(userId);
            this.Hide();
            manageBook.Show();

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

