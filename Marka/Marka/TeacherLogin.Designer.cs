namespace Marka
{
    partial class TeacherLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherLogin));
            continueBtn = new PictureBox();
            backBtn = new PictureBox();
            pictureBox3 = new PictureBox();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            eyeIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)continueBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeIcon).BeginInit();
            SuspendLayout();
            // 
            // continueBtn
            // 
            continueBtn.BackColor = Color.Transparent;
            continueBtn.Image = (Image)resources.GetObject("continueBtn.Image");
            continueBtn.Location = new Point(18, 730);
            continueBtn.Name = "continueBtn";
            continueBtn.Size = new Size(335, 65);
            continueBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            continueBtn.TabIndex = 7;
            continueBtn.TabStop = false;
            continueBtn.Click += continueBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(25, 66);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(24, 24);
            backBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            backBtn.TabIndex = 8;
            backBtn.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-12, 778);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(400, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(72, 214);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(256, 20);
            tbEmail.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(72, 291);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(235, 20);
            tbPassword.TabIndex = 3;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // eyeIcon
            // 
            eyeIcon.BackColor = Color.White;
            eyeIcon.Image = (Image)resources.GetObject("eyeIcon.Image");
            eyeIcon.Location = new Point(316, 291);
            eyeIcon.Name = "eyeIcon";
            eyeIcon.Size = new Size(20, 20);
            eyeIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            eyeIcon.TabIndex = 4;
            eyeIcon.TabStop = false;
            eyeIcon.Click += pictureBox3_Click;
            // 
            // TeacherLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(375, 812);
            Controls.Add(tbEmail);
            Controls.Add(eyeIcon);
            Controls.Add(tbPassword);
            Controls.Add(backBtn);
            Controls.Add(continueBtn);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TeacherLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherLogin";
            ((System.ComponentModel.ISupportInitialize)continueBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyeIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox continueBtn;
        private PictureBox backBtn;
        private PictureBox pictureBox3;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private PictureBox eyeIcon;
    }
}