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
using BAL;
using BEL;
using System.IO;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class ViewStudent : MetroFramework.Forms.MetroForm
    {

        public Information info = new Information();
        public Operations opr = new Operations();
        public Dbconnection con = new Dbconnection();

        private string userId;
        string imgLocation = "";

        public ViewStudent(String userId)
        {
            InitializeComponent();
            this.userId = userId;
            labelUserID.Text = userId;
            dgvUpdate();
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

        private void mAddStudentBtn_Click(object sender, EventArgs e)
        {
            ManageStudent manageStudent = new ManageStudent(userId);
            this.Hide();
            manageStudent.Show();
        }

        private void mManageStudentBtn_Click(object sender, EventArgs e)
        {
            ManageStudent manageStudent = new ManageStudent(userId);
            this.Hide();
            manageStudent.Show();
        }

        #endregion menu panel


        // update the shown dataTable always.
        public void dgvUpdate()
        {
            DataTable dt = new DataTable();
            dt = opr.ViewStudent(info); //need to change.
            dgbStudent.DataSource = dt;
        }


        private void clean()
        {
            studentIdTF2.Text = "";
            fullnameTF.Text = "";
            genderTF.Text = "";
            dobTF.Text = "";
            addressTF.Text = "";
            emailTF.Text = "";
            phoneTF.Text = "";
            this.uploadStudentPic.Image = null;
        }

        private void mClearBtn_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void mUpdateImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgLocation = ofd.FileName.ToString();
                uploadStudentPic.ImageLocation = imgLocation;
            }
            updateImage();
        }

        private void updateImage()
        {
            try
            {
                byte[] uploadStudentPic = null;
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                uploadStudentPic = br.ReadBytes((int)fs.Length);
                info.studentImage = uploadStudentPic;
                info.studentId = studentIdTF2.Text;

                opr.updateStudentPictures(info);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            // update grid view
            dgvUpdate();
        }

        private void mDeleteBtn_Click(object sender, EventArgs e)
        {
            if (studentIdTF2.Text.Length != 0)
            {
                info.studentId = studentIdTF2.Text;
                DialogResult dr = MessageBox.Show("Are you sure? This might Delete the all information about the selected Librarian", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        opr.deleteStudent(info);
                        opr.deleteStudentLogin(info);
                        MessageBox.Show("Information Deleted successfully.", "Success", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("You Can not do this right now because this Student is currently borrowed book", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    clean();
                    dgvUpdate();

                }
                else { }
            }
            else
            {
                MessageBox.Show("opps! Nothing is selected", "Error", MessageBoxButtons.OK);
            }
        }

        private void mTextSearch_TextChanged(object sender, EventArgs e)
        {
            con.getcon();
            string query = "select * from student where studentName like '%" + mTextSearch.Text + "%' or studentId like '%" + mTextSearch.Text + "%'";

            SqlCommand cmd = new SqlCommand(query, con.getcon());

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgbStudent.DataSource = dt;

            con.getcon().Close();
        }

        private void dgbStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgbStudent.Rows[e.RowIndex];
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol = (DataGridViewImageColumn)dgbStudent.Columns[7];

                studentIdTF2.Text = row.Cells["studentId"].Value.ToString();
                fullnameTF.Text = row.Cells["studentName"].Value.ToString();
                genderTF.Text = row.Cells["studentGender"].Value.ToString();
                dobTF.Text = row.Cells["studentDOB"].Value.ToString();
                addressTF.Text = row.Cells["studentAddress"].Value.ToString();
                emailTF.Text = row.Cells["studentEmail"].Value.ToString();
                phoneTF.Text = row.Cells["studentPhone"].Value.ToString();


                //Retriving the images from data Grid View.
                var data = (Byte[])(row.Cells["studentImage"].Value);
                var stream = new MemoryStream(data);
                uploadStudentPic.Image = Image.FromStream(stream);
            }
            else { }
        }

        private void mUpdateDataBtn_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (int.TryParse(fullnameTF.Text, out result) || int.TryParse(addressTF.Text, out result) || int.TryParse(emailTF.Text, out result))
            {
                MessageBox.Show("Enter Valid Name or Address.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                // field empty check
                if (fullnameTF.Text.Length == 0 || genderTF.Text.Length == 0 || dobTF.Text.Length == 0 || addressTF.Text.Length == 0 || emailTF.Text.Length == 0 || phoneTF.Text.Length == 0)
                {
                    MessageBox.Show("opps! Something Went Wrong.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (phoneTF.Text.Length > 13 || phoneTF.Text.Length < 13)
                    {
                        MessageBox.Show("Enter Valid Mobile number.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {

                        try
                        {
                            info.studentId = studentIdTF2.Text;

                            info.studentName = fullnameTF.Text;
                            info.studentGender = genderTF.Text;
                            info.studentDOB = dobTF.Text;
                            info.studentAddress = addressTF.Text;
                            info.studentEmail = emailTF.Text;
                            info.studentPhone = Convert.ToInt64(phoneTF.Text);


                            opr.updateStudent(info);


                            MessageBox.Show("Information Updated successfully.", "Success", MessageBoxButtons.OK);
                            // update grid view
                            dgvUpdate();

                            clean();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("opps!", "Error", MessageBoxButtons.OK);
                        }

                    }
                }
            }
        }

        private void fullnameTF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void genderTF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void phoneTF_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void studentIdTF2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void mBackToDashBoard_Click(object sender, EventArgs e)
        {
            LibrarianPanel librarianPanel = new LibrarianPanel(userId);
            this.Hide();
            librarianPanel.Show();
        }

        private void mLibAddStdBtn_Click(object sender, EventArgs e)
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
    }
}
