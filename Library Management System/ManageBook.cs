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

namespace Library_Management_System
{
    public partial class ManageBook : MetroFramework.Forms.MetroForm
    {
        public Information info = new Information();
        public Operations opr = new Operations();
        public Dbconnection con = new Dbconnection();

        private string userId;
        string imgLocation = "";

        public ManageBook(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            labelUserID.Text = userId;

        }

        #region menu panel

        private void mDashboardBtn_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel(userId);
            this.Hide();
            adminPanel.Show();

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

        private void authornameTF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void quantityTF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void mImageBrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgLocation = ofd.FileName.ToString();
                uploadBookPic.ImageLocation = imgLocation;
            }
        }

        private void mSaveBookBtn_Click(object sender, EventArgs e)
        {
            // Declaring the picture box in byte type.
            byte[] uploadBookpic = null;

            // check for input integer value.
            int result = 0;
            if (int.TryParse(booknameTF.Text, out result) || int.TryParse(authornameTF.Text, out result))
            {
                MessageBox.Show("Enter Valid Name.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                try
                {
                    // field empty check
                    if (bookidTF2.Text.Length == 0 || booknameTF.Text.Length == 0 || authornameTF.Text.Length == 0 || yearComboBox.Text.Length == 0 || quantityTF.Text.Length == 0 || uploadBookPic.Image == null)
                    {
                        MessageBox.Show("opps! Something Went Wrong.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    else
                    {
                        // converting img in binary value.
                        FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        uploadBookpic = br.ReadBytes((int)fs.Length);

                        //BAL and BEL Layer execution.
                        info.bookId = bookidTF.Text + bookidTF2.Text;
                        info.bookName = booknameTF.Text;
                        info.authorName = authornameTF.Text;
                        info.publicationYear = Convert.ToInt32(yearComboBox.Text);
                        info.quantity = Convert.ToInt32(quantityTF.Text);
                        info.images = uploadBookpic;

                        opr.insertBook(info);

                        MessageBox.Show("Information Saved successfully.", "Success", MessageBoxButtons.OK);
                        bookidTF2.Text = "";
                        booknameTF.Text = "";
                        authornameTF.Text = "";
                        yearComboBox.Text = "";
                        quantityTF.Text = "";
                        this.uploadBookPic.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Already exist!");
                    bookidTF2.Text = "";
                    booknameTF.Text = "";
                    authornameTF.Text = "";
                    yearComboBox.Text = "";
                    quantityTF.Text = "";
                    this.uploadBookPic.Image = null;
                }
            }
        }

        private void mViewBookBtn_Click(object sender, EventArgs e)
        {
            ViewBook viewBook = new ViewBook(userId);
            this.Hide();
            viewBook.panel1.Visible = true;
            viewBook.Show();
        }

        private void mLibrarianViewBookAddBtn_Click(object sender, EventArgs e)
        {
            ViewBook viewBook = new ViewBook(userId);
            this.Hide();
            viewBook.panel1.Visible = false;
            viewBook.panel2.Visible = false;
            viewBook.panel3.Visible = true;
            viewBook.metroButton3.Visible = true;
            viewBook.Show();
        }
    }
}
