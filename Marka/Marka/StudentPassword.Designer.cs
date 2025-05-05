namespace Marka
{
    partial class StudentPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentPassword));
            tbPassword = new TextBox();
            eyeIcon = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            backBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)eyeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            SuspendLayout();
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(65, 166);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(232, 18);
            tbPassword.TabIndex = 11;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // eyeIcon
            // 
            eyeIcon.BackColor = Color.White;
            eyeIcon.Image = (Image)resources.GetObject("eyeIcon.Image");
            eyeIcon.Location = new Point(312, 165);
            eyeIcon.Name = "eyeIcon";
            eyeIcon.Size = new Size(20, 20);
            eyeIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            eyeIcon.TabIndex = 12;
            eyeIcon.TabStop = false;
            eyeIcon.Click += eyeIcon_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-12, 778);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(400, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 730);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // backBtn
            // 
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(25, 66);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(24, 24);
            backBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            backBtn.TabIndex = 15;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // StudentPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(375, 812);
            Controls.Add(backBtn);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(eyeIcon);
            Controls.Add(tbPassword);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentPassword";
            ((System.ComponentModel.ISupportInitialize)eyeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPassword;
        private PictureBox eyeIcon;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox backBtn;
    }
}