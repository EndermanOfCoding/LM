using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using DAL;
using BEL;
using BAL;
using System.Data.SqlClient;
using System.IO;

namespace Library_Management_System
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        private int status;

        public Information information = new Information();
        public Operations operations = new Operations();

        //public Dbconnection connection = new Dbconnection();
        
        DataTable dataTable = new DataTable();

        public Login()
        {
            InitializeComponent();
        }

        private void mLoginBtn_Click(object sender, EventArgs e)
        {
            information.userId = mUserID.Text;
            information.password = mPassword.Text;

            dataTable = operations.FormLogin(information);

            if (dataTable.Rows.Count > 0)
            {

                status = Convert.ToInt32(dataTable.Rows[0][2].ToString());

                if (status == 0)
                {
                    AdminPanel adminPanel = new AdminPanel(mUserID.Text);
                    this.Hide();
                    adminPanel.Show();
                }
                else if (status == 1)
                {
                    LibrarianPanel librarianPanel = new LibrarianPanel(mUserID.Text);
                    this.Hide();
                    librarianPanel.Show();

                }
                else if (status == 2)
                {
                    StudentPanel studentPanel = new StudentPanel(mUserID.Text);
                    studentPanel.Show();
                    this.Hide();

                }

                else if (status == 3)
                {
                    MessageBox.Show("oops! You are Currently Inactive For Access Please Contact Librarian", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //txtUsername.Text = @"Username";
                    //txtPassword.Text = @"Password";

                }

            }

            else
            {
                MessageBox.Show("username and password does not match.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
