namespace Library_Management_System
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.mLoginBtn = new MetroFramework.Controls.MetroButton();
            this.mUserID = new MetroFramework.Controls.MetroTextBox();
            this.mPassword = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mLoginBtn
            // 
            this.mLoginBtn.Location = new System.Drawing.Point(189, 347);
            this.mLoginBtn.Name = "mLoginBtn";
            this.mLoginBtn.Size = new System.Drawing.Size(141, 50);
            this.mLoginBtn.TabIndex = 0;
            this.mLoginBtn.Text = "LOGIN";
            this.mLoginBtn.UseSelectable = true;
            this.mLoginBtn.Click += new System.EventHandler(this.mLoginBtn_Click);
            // 
            // mUserID
            // 
            // 
            // 
            // 
            this.mUserID.CustomButton.Image = null;
            this.mUserID.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.mUserID.CustomButton.Name = "";
            this.mUserID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mUserID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mUserID.CustomButton.TabIndex = 1;
            this.mUserID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mUserID.CustomButton.UseSelectable = true;
            this.mUserID.CustomButton.Visible = false;
            this.mUserID.Lines = new string[0];
            this.mUserID.Location = new System.Drawing.Point(155, 235);
            this.mUserID.MaxLength = 32767;
            this.mUserID.Name = "mUserID";
            this.mUserID.PasswordChar = '\0';
            //this.mUserID.PromptText = "USER ID";
            this.mUserID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mUserID.SelectedText = "";
            this.mUserID.SelectionLength = 0;
            this.mUserID.SelectionStart = 0;
            this.mUserID.ShortcutsEnabled = true;
            this.mUserID.Size = new System.Drawing.Size(208, 23);
            this.mUserID.TabIndex = 1;
            this.mUserID.UseSelectable = true;
            this.mUserID.WaterMark = "USER ID";
            this.mUserID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mUserID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mPassword
            // 
            // 
            // 
            // 
            this.mPassword.CustomButton.Image = null;
            this.mPassword.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.mPassword.CustomButton.Name = "";
            this.mPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mPassword.CustomButton.TabIndex = 1;
            this.mPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mPassword.CustomButton.UseSelectable = true;
            this.mPassword.CustomButton.Visible = false;
            this.mPassword.Lines = new string[0];
            this.mPassword.Location = new System.Drawing.Point(155, 291);
            this.mPassword.MaxLength = 32767;
            this.mPassword.Name = "mPassword";
            this.mPassword.PasswordChar = '*';
            //this.mPassword.PromptText = "PASSWORD";
            this.mPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mPassword.SelectedText = "";
            this.mPassword.SelectionLength = 0;
            this.mPassword.SelectionStart = 0;
            this.mPassword.ShortcutsEnabled = true;
            this.mPassword.Size = new System.Drawing.Size(208, 23);
            this.mPassword.TabIndex = 2;
            this.mPassword.UseSelectable = true;
            this.mPassword.WaterMark = "PASSWORD";
            this.mPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(189, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 457);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.mPassword);
            this.Controls.Add(this.mUserID);
            this.Controls.Add(this.mLoginBtn);
            this.Name = "Login";
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton mLoginBtn;
        private MetroFramework.Controls.MetroTextBox mUserID;
        private MetroFramework.Controls.MetroTextBox mPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

