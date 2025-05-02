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
            label1 = new Label();
            panel1 = new Panel();
            tbEmail = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            eyeIcon = new PictureBox();
            tbPassword = new TextBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            continueBtn = new PictureBox();
            backBtn = new PictureBox();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eyeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)continueBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 128);
            label1.Name = "label1";
            label1.Size = new Size(88, 42);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(28, 204);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 50);
            panel1.TabIndex = 1;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(45, 13);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(256, 20);
            tbEmail.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(eyeIcon);
            panel2.Controls.Add(tbPassword);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(28, 290);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 50);
            panel2.TabIndex = 4;
            // 
            // eyeIcon
            // 
            eyeIcon.BackColor = Color.White;
            eyeIcon.Image = (Image)resources.GetObject("eyeIcon.Image");
            eyeIcon.Location = new Point(286, 13);
            eyeIcon.Name = "eyeIcon";
            eyeIcon.Size = new Size(20, 20);
            eyeIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            eyeIcon.TabIndex = 4;
            eyeIcon.TabStop = false;
            eyeIcon.Click += pictureBox3_Click;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(45, 13);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(235, 20);
            tbPassword.TabIndex = 3;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(107, 114, 128);
            label2.Location = new Point(29, 179);
            label2.Name = "label2";
            label2.Size = new Size(45, 23);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(107, 114, 128);
            label3.Location = new Point(29, 264);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 6;
            label3.Text = "Password";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Poppins", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(107, 114, 128);
            label4.Location = new Point(38, 345);
            label4.Name = "label4";
            label4.Size = new Size(197, 16);
            label4.TabIndex = 9;
            label4.Text = "Note: Log in using the institutional account.";
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
            // TeacherLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(375, 812);
            Controls.Add(label4);
            Controls.Add(backBtn);
            Controls.Add(continueBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TeacherLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)eyeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)continueBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox tbEmail;
        private Panel panel2;
        private TextBox tbPassword;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private PictureBox eyeIcon;
        private PictureBox continueBtn;
        private PictureBox backBtn;
        private Label label4;
        private PictureBox pictureBox3;
    }
}