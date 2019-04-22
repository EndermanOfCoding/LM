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
using System.IO;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class ViewBook : MetroFramework.Forms.MetroForm
    {
        public Information info = new Information();
        public Operations opr = new Operations();
        public Dbconnection con = new Dbconnection();

        private string userId;
        string imgLocation = "";

        public ViewBook(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            labelUserID.Text = userId;
            dgvUpdate();
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

        private void genderTF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void authornameTF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void mUpdateImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgLocation = ofd.FileName.ToString();
                viewBookPic.ImageLocation = imgLocation;
            }

            updateImage();
        }

        private void updateImage()
        {
            try
            {
                byte[] viewBookPic = null;
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                viewBookPic = br.ReadBytes((int)fs.Length);
                info.images = viewBookPic;
                info.bookId = bookidTF.Text;

                opr.updatePictures(info);
            }
            catch (Exception ex)
            { }
            // update grid view
            dgvUpdate();
        }

        private void dgvUpdate()
        {
            DataTable dt = new DataTable();
            dt = opr.ViewBooks(info);
            dgbBook.DataSource = dt;
        }

        private void dgbBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgbBook.Rows[e.RowIndex];
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol = (DataGridViewImageColumn)dgbBook.Columns[5];

                bookidTF.Text = row.Cells["bookId"].Value.ToString();
                booknameTF.Text = row.Cells["bookName"].Value.ToString();
                authornameTF.Text = row.Cells["authorName"].Value.ToString();
                publicationyearTF.Text = row.Cells["publicationYear"].Value.ToString();
                quantityTF.Text = row.Cells["quantity"].Value.ToString();

                //Retriving the images from data Grid View.
                var data = (Byte[])(row.Cells["bookImage"].Value);
                var stream = new MemoryStream(data);
                viewBookPic.Image = Image.FromStream(stream);
            }
            else { }
        }

        private void mTextSearch_TextChanged(object sender, EventArgs e)
        {

            con.getcon();
            string query = "select * from books where bookName like '%" + mTextSearch.Text + "%' or bookId like '%" + mTextSearch.Text + "%'";
            //string query1 = "select * from books where bookId like '%" + txtSearch.Text + "%'";
            SqlCommand cmd = new SqlCommand(query, con.getcon());
            //SqlCommand cmdd = new SqlCommand(query1,con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //SqlDataAdapter sdaa = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            //sdaa.Fill(dataTable);
            sda.Fill(dt);
            dgbBook.DataSource = dt;
            con.getcon().Close();
        }

        private void mClearBtn_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void clearField()
        {
            bookidTF.Text = "";
            booknameTF.Text = "";
            authornameTF.Text = "";
            publicationyearTF.Text = "";
            quantityTF.Text = "";
            this.viewBookPic.Image = null;
        }

        private void mDeleteBtn_Click(object sender, EventArgs e)
        {
            if (bookidTF.Text.Length != 0)
            {
                info.bookId = bookidTF.Text;
                DialogResult dr = MessageBox.Show("Are you sure? This might Delete the all information about the selected item", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        opr.deleteBook(info);
                        MessageBox.Show("Information Deleted successfully.", "Success", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("You Can not do this right now because this book is currently issued", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    bookidTF.Text = "";
                    booknameTF.Text = "";
                    authornameTF.Text = "";
                    publicationyearTF.Text = "";
                    quantityTF.Text = "";
                    this.viewBookPic.Image = null;

                    dgvUpdate();
                }
                else { }
            }
            else
            {
                MessageBox.Show("opps! Nothing is selected", "Error", MessageBoxButtons.OK);
            }
        }

        private void mUpdateDataBtn_Click(object sender, EventArgs e)
        {
            // Declaring the picture box in byte type.

            /* */
            // check for input integer value.
            int result = 0;
            if (int.TryParse(booknameTF.Text, out result) || int.TryParse(authornameTF.Text, out result))
            {
                MessageBox.Show("Enter Valid Name.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // field empty check
                if (booknameTF.Text.Length == 0 || authornameTF.Text.Length == 0 || publicationyearTF.Text.Length == 0 || quantityTF.Text.Length == 0)
                {
                    MessageBox.Show("opps! Something Went Wrong.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {

                        info.bookId = bookidTF.Text;
                        info.bookName = booknameTF.Text;
                        info.authorName = authornameTF.Text;
                        info.publicationYear = Convert.ToInt32(publicationyearTF.Text);
                        info.quantity = Convert.ToInt32(quantityTF.Text);


                        opr.updateBook(info);


                        MessageBox.Show("Information Updated successfully.", "Success", MessageBoxButtons.OK);
                        // update grid view
                        

                        bookidTF.Text = "";
                        booknameTF.Text = "";
                        authornameTF.Text = "";
                        publicationyearTF.Text = "";
                        quantityTF.Text = "";
                        this.viewBookPic.Image = null;
                        dgvUpdate();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("opps!", "Error", MessageBoxButtons.OK);
                        Console.WriteLine(ex);
                    }
                }
            }
        }

        private void publicationyearTF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void mAddStudentBtn_Click(object sender, EventArgs e)
        {
            ManageBook manageBook = new ManageBook(userId);
            this.Hide();
            manageBook.Show();
            
        }

        #region menu panel
        private void mManageBookBtn_Click(object sender, EventArgs e)
        {
            ManageBook manageBook = new ManageBook(userId);
            this.Hide();
            manageBook.Show();

        }

        private void mLibarianBtn_Click(object sender, EventArgs e)
        {
            ManageLibarian manageLibarian = new ManageLibarian(userId);
            this.Hide();
            manageLibarian.Show();
        }


        private void mLogoutBtn_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void mDashboardBtn_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel(userId);
            this.Hide();
            adminPanel.Show();
        }

        private void mManageStudentBtn_Click(object sender, EventArgs e)
        {
            ManageStudent manageStudent = new ManageStudent(userId);
            this.Hide();
            manageStudent.Show();
        }


        #endregion menu panel

        private void mSPDashboardBtn_Click(object sender, EventArgs e)
        {
            StudentPanel studentPanel = new StudentPanel(userId);
            this.Hide();
            studentPanel.Show();
        }

        private void mSPCurrentBorrowBtn_Click(object sender, EventArgs e)
        {
            CurrentBorrow currentBorrow = new CurrentBorrow(userId);
            this.Hide();
            currentBorrow.Show();
        }

        private void mSPMyInformationBtn_Click(object sender, EventArgs e)
        {
            MyInformation myInformation = new MyInformation(userId);
            this.Hide();
            myInformation.Show();
        }

        private void mSPChangePasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(userId);
            this.Hide();
            changePassword.Show();
        }

        private void mSPLogoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void mViewStudentBtn_Click(object sender, EventArgs e)
        {
            ViewBook viewBook = new ViewBook(userId);
            this.Hide();
            viewBook.panel1.Visible = true;
            viewBook.Show();
        }
    }
}
