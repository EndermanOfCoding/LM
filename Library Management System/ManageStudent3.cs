using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BEL;
using BAL;


namespace Library_Management_System
{
    public partial class ManageStudent3 : MetroFramework.Forms.MetroForm
    {

        public Information info = new Information();
        public Operations opr = new Operations();
        public Dbconnection con = new Dbconnection();

        private string userId;
        string imgLocation = "";
        public ManageStudent3(string userId)
        {
            InitializeComponent();
            this.userId = userId;
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


        #endregion menu panel


        private void mStudentImageUploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgLocation = ofd.FileName.ToString();
                uploadStudentPic.ImageLocation = imgLocation;
            }
        }

        private void mAddStudentBtn_Click(object sender, EventArgs e)
        {
            // Declaring the picture box in byte type.
            byte[] uploadStudentpic = null;

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
                if (studentidTF.Text.Length == 0 || passwordTF.Text.Length == 0 || fullnameTF.Text.Length == 0 || genderBox.Text.Length == 0 || datepickTF.Text.Length == 0 || addressTF.Text.Length == 0 || emailTF.Text.Length == 0 || phoneTF2.Text.Length == 0 || uploadStudentPic.Image == null)
                {
                    MessageBox.Show("opps! Something Went Wrong.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // insert into Student
                else
                {
                    // converting img in binary value.
                    FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    uploadStudentpic = br.ReadBytes((int)fs.Length);

                    //Check mobile number

                    if (phoneTF2.Text.Length > 10 || phoneTF2.Text.Length < 10)
                    {
                        MessageBox.Show("Enter Valid Mobile number.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // BAL & BEL Operation
                    else if (int.TryParse(phoneTF2.Text, out rlt))
                    {
                        info.studentId = studentidTF.Text + studentidTF2.Text;
                        info.password = passwordTF.Text;
                        info.studentName = fullnameTF.Text;
                        info.studentGender = genderBox.Text;
                        info.studentDOB = datepickTF.Text;
                        info.studentAddress = addressTF.Text;
                        info.studentEmail = emailTF.Text;
                        info.studentPhone = Convert.ToInt64(phoneTF.Text + phoneTF2.Text);
                        info.studentImage = uploadStudentpic;
                        info.stat = 2;

                        try
                        {
                            opr.insertStudent(info);
                            opr.insertIntoStudentLogin(info);

                            MessageBox.Show("Information Saved successfully.", "Success", MessageBoxButtons.OK);
                            // clear field
                            //clearStudentField();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Already exist User.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Valid Mobile number.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

    }
}
