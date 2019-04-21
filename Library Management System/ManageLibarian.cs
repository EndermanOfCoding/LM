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
    public partial class ManageLibarian : MetroFramework.Forms.MetroForm
    {
        public Information info = new Information();
        public Operations opr = new Operations();
        public Dbconnection con = new Dbconnection();

        private string userId;
        string imgLocation = "";

        public ManageLibarian(string userId)
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

        private void mManageStudentBtn_Click(object sender, EventArgs e)
        {

            ManageStudent manageStudent = new ManageStudent(userId);
            this.Hide();
            manageStudent.Show();

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

        private void mLibarianImageUploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgLocation = ofd.FileName.ToString();
                uploadLibrarianPic.ImageLocation = imgLocation;
            }
        }

        private void mAddLibarianBtn_Click(object sender, EventArgs e)
        {
            // Declaring the picture box in byte type.
            byte[] uploadLibrarianpic = null;

            // check for input integer value.
            int result = 0;
            if (int.TryParse(fullnameTF.Text, out result) || int.TryParse(addressTF.Text, out result) || int.TryParse(emailTF.Text, out result))
            {
                MessageBox.Show("Enter Valid Name.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                int rlt = 0;

                // field empty check
                if (librarianidTF2.Text.Length == 0 || passwordTF.Text.Length == 0 || fullnameTF.Text.Length == 0 || genderBox.Text.Length == 0 || datepickTF.Text.Length == 0 || addressTF.Text.Length == 0 || emailTF.Text.Length == 0 || phoneTF2.Text.Length == 0 || salaryTF.Text.Length == 0 || uploadLibrarianPic.Image == null)
                {
                    MessageBox.Show("opps! Something Went Wrong.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Insert into librarian.
                else
                {
                    // converting img in binary value.
                    FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    uploadLibrarianpic = br.ReadBytes((int)fs.Length);

                    //BAL and BEL Layer execution.

                    if (phoneTF2.Text.Length > 10 || phoneTF2.Text.Length < 10)
                    {
                        MessageBox.Show("Enter Valid Mobile number.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (int.TryParse(phoneTF2.Text, out rlt))
                    {
                        info.librarianId = librarianidTF.Text + librarianidTF2.Text;
                        info.password = passwordTF.Text;
                        info.librarianName = fullnameTF.Text;
                        info.librarianGender = genderBox.Text;
                        info.librarianDOB = datepickTF.Text;
                        info.librarianAddress = addressTF.Text;
                        info.librarianEmail = emailTF.Text;
                        info.librarianPhone = Convert.ToInt64(phoneTF.Text + phoneTF2.Text);
                        info.librarianSalary = Convert.ToDouble(salaryTF.Text);
                        info.librarianImage = uploadLibrarianpic;
                        info.stat = 1;

                        try
                        {
                            opr.inserLibrarian(info);
                            opr.insertIntoLogin(info);

                            MessageBox.Show("Information Saved successfully.", "Success", MessageBoxButtons.OK);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Already exist user.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        // clear field
                        clearField();
                    }
                    else
                    {
                        MessageBox.Show("Enter Valid Mobile number.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void clearField()
        {
            librarianidTF2.Text = "";
            passwordTF.Text = "";
            fullnameTF.Text = "";
            genderBox.Text = "";
            datepickTF.Text = "";
            addressTF.Text = "";
            emailTF.Text = "";
            phoneTF2.Text = "";
            salaryTF.Text = "";
            passwordAutoGen.Enabled = true;
            uploadLibrarianPic.Image = null;
        }

        private void fullnameTF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void passwordAutoGen_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            passwordTF.Text = (rnd.Next(89999999) + 10000000 + "");
            passwordAutoGen.Enabled = false;
        }


        private void mViewStudentBtn_Click(object sender, EventArgs e)
        {
            ViewLibarian viewLibarian = new ViewLibarian(userId);
            this.Hide();
            viewLibarian.Show();
        }

        private void phoneTF2_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void salaryTF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        
    }
}
