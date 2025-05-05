namespace Marka
{
    partial class StudentLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentLogin));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            backBtn = new PictureBox();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            eyeIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyeIcon).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 730);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-12, 778);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(400, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
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
            backBtn.Click += backBtn_Click;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(71, 212);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(253, 20);
            tbEmail.TabIndex = 9;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(71, 290);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(232, 18);
            tbPassword.TabIndex = 10;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // eyeIcon
            // 
            eyeIcon.BackColor = Color.White;
            eyeIcon.Image = (Image)resources.GetObject("eyeIcon.Image");
            eyeIcon.Location = new Point(313, 288);
            eyeIcon.Name = "eyeIcon";
            eyeIcon.Size = new Size(20, 20);
            eyeIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            eyeIcon.TabIndex = 11;
            eyeIcon.TabStop = false;
            eyeIcon.Click += eyeIcon_Click;
            // 
            // StudentLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(375, 812);
            Controls.Add(eyeIcon);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(backBtn);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentLogin";
            Load += StudentLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyeIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox backBtn;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private PictureBox eyeIcon;
    }
}