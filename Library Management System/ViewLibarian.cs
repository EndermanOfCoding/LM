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
    public partial class ViewLibarian : MetroFramework.Forms.MetroForm
    {
        public Information info = new Information();
        public Operations opr = new Operations();
        public Dbconnection con = new Dbconnection();

        private string userId;
        string imgLocation = "";

        public ViewLibarian(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            labelUserID.Text = userId;
            dgvUpdate();
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

        private void mUpdateImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgLocation = ofd.FileName.ToString();
                uploadLibrarianPic.ImageLocation = imgLocation;
            }

            updateImage();
        }
        //image update 
        private void updateImage()
        {
            try
            {
                byte[] uploadLibrarianPic = null;
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                uploadLibrarianPic = br.ReadBytes((int)fs.Length);
                info.librarianImage = uploadLibrarianPic;
                info.librarianId = librarianidTF2.Text;

                opr.updateLibrarianPictures(info);
            }
            catch (Exception ex)
            { }
            // update grid view
            dgvUpdate();

        }

        private void dgvUpdate()
        {

            DataTable dt = new DataTable();
            dt = opr.ViewLibrarian(info);
            dgbLibrarian.DataSource = dt;

        }

        private void mTextSearch_TextChanged(object sender, EventArgs e)
        {

            con.getcon();
            string query = "select * from librarian where librarianName like '%" + mTextSearch.Text + "%'or librarianId like '%" + mTextSearch.Text + "%'";

            SqlCommand cmd = new SqlCommand(query, con.getcon());

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgbLibrarian.DataSource = dt;

            con.getcon().Close();

        }

        private void dgbLibrarian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgbLibrarian.Rows[e.RowIndex];
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol = (DataGridViewImageColumn)dgbLibrarian.Columns[8];

                librarianidTF2.Text = row.Cells["librarianId"].Value.ToString();
                fullnameTF.Text = row.Cells["librarianName"].Value.ToString();
                genderTF.Text = row.Cells["librarianGender"].Value.ToString();
                dobTF.Text = row.Cells["librarianDOB"].Value.ToString();
                addressTF.Text = row.Cells["librarianAddress"].Value.ToString();
                emailTF.Text = row.Cells["librarianEmail"].Value.ToString();
                phoneTF.Text = row.Cells["librarianPhone"].Value.ToString();
                salaryTF.Text = row.Cells["librarianSalary"].Value.ToString();

                //Retriving the images from data Grid View.
                var data = (Byte[])(row.Cells["librarianImage"].Value);
                var stream = new MemoryStream(data);
                uploadLibrarianPic.Image = Image.FromStream(stream);
            }
            else { }

        }

        private void mClearBtn_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void clearField()
        {
            librarianidTF2.Text = "";
            fullnameTF.Text = "";
            genderTF.Text = "";
            dobTF.Text = "";
            addressTF.Text = "";
            emailTF.Text = "";
            phoneTF.Text = "";
            salaryTF.Text = "";
            this.uploadLibrarianPic.Image = null;
        }

        private void mDeleteBtn_Click(object sender, EventArgs e)
        {
            if (librarianidTF2.Text.Length != 0)
            {
                info.librarianId = librarianidTF2.Text;
                DialogResult dr = MessageBox.Show("Are you sure? This might Delete the all information about the selected Librarian", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    opr.deleteLibrarian(info);
                    opr.deleteFromLogin(info);
                    MessageBox.Show("Information Deleted successfully.", "Success", MessageBoxButtons.OK);
                    clearField();
                    dgvUpdate();
                }
                else { }
            }
            else
            {
                MessageBox.Show("opps! Nothing is selected", "Error", MessageBoxButtons.OK);
            }
            dgvUpdate();
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
                if (fullnameTF.Text.Length == 0 || genderTF.Text.Length == 0 || dobTF.Text.Length == 0 || addressTF.Text.Length == 0 || emailTF.Text.Length == 0 || phoneTF.Text.Length == 0 || salaryTF.Text.Length == 0)
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
                            info.librarianId = librarianidTF2.Text;

                            info.librarianName = fullnameTF.Text;
                            info.librarianGender = genderTF.Text;
                            info.librarianDOB = dobTF.Text;
                            info.librarianAddress = addressTF.Text;
                            info.librarianEmail = emailTF.Text;
                            info.librarianPhone = Convert.ToInt64(phoneTF.Text);
                            info.librarianSalary = Convert.ToDouble(salaryTF.Text);

                            opr.updateLibrarian(info);


                            MessageBox.Show("Information Updated successfully.", "Success", MessageBoxButtons.OK);
                            // update grid view
                            dgvUpdate();

                            clearField();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("opps!", "Error", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            dgvUpdate();
        }

        private void mAddStudentBtn_Click(object sender, EventArgs e)
        {
            ManageLibarian manageLibarian = new ManageLibarian(userId);
            this.Hide();
            manageLibarian.Show();

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

        private void salaryTF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
