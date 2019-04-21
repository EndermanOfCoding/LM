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
        public Information info = new Information();
        public Operations opr = new Operations();
        public Dbconnection con = new Dbconnection();
        int status;

        DataTable dt = new DataTable();

        public Login()
        {
            InitializeComponent();
        }

        private void mLoginBtn_Click(object sender, EventArgs e)
        {
            info.userId = mUserID.Text;
            info.password = mPassword.Text;

            dt = opr.FormLogin(info);

            if (dt.Rows.Count > 0)
            {

                status = Convert.ToInt32(dt.Rows[0][2].ToString());

                if (status == 0)
                {
                    AdminPanel ap = new AdminPanel(mUserID.Text);
                    this.Hide();
                    ap.Show();
                }
                else if (status == 1)
                {
                    LibrarianPanel lp = new LibrarianPanel(mUserID.Text);
                    this.Hide();
                    lp.Show();

                    //con.getcon().Close();
                    //string query = "select * from librarian where librarianId = '" + txtUsername.Text + "'";
                    //SqlCommand cmd = new SqlCommand(query, con.getcon());
                    //SqlDataReader sdr = cmd.ExecuteReader();


                    //if (sdr.Read())
                    //{
                    //    lp.labelUsername.Text = (sdr["librarianName"].ToString());
                    //    byte[] pic = (byte[])sdr["librarianImage"];
                    //    MemoryStream ms = new MemoryStream(pic);
                    //    ms.Seek(0, SeekOrigin.Begin);

                    //    lp.pictureBoxAdmin.Image = Image.FromStream(ms);

                    //}
                    //con.getcon().Close();
                }
                else if (status == 2)
                {
                    StudentPanel sp = new StudentPanel(mUserID.Text);
                    sp.Show();
                    this.Hide();

                }
                else if (status == 3)
                {
                    //MessageBox.Show("oops! You are Currently Inactive For Access Please Contact Librarian", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
