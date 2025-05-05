namespace Marka
{
    partial class StudentClicked
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentClicked));
            continueBtn = new PictureBox();
            pictureBox3 = new PictureBox();
            teacherCard = new PictureBox();
            studentCardClicked = new PictureBox();
            backBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)continueBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teacherCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentCardClicked).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
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
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-12, 778);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(400, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // teacherCard
            // 
            teacherCard.BackColor = Color.Transparent;
            teacherCard.Image = (Image)resources.GetObject("teacherCard.Image");
            teacherCard.Location = new Point(11, 258);
            teacherCard.Name = "teacherCard";
            teacherCard.Size = new Size(350, 130);
            teacherCard.SizeMode = PictureBoxSizeMode.CenterImage;
            teacherCard.TabIndex = 9;
            teacherCard.TabStop = false;
            teacherCard.Click += teacherCard_Click;
            // 
            // studentCardClicked
            // 
            studentCardClicked.BackColor = Color.Transparent;
            studentCardClicked.Image = (Image)resources.GetObject("studentCardClicked.Image");
            studentCardClicked.Location = new Point(11, 393);
            studentCardClicked.Name = "studentCardClicked";
            studentCardClicked.Size = new Size(350, 130);
            studentCardClicked.SizeMode = PictureBoxSizeMode.CenterImage;
            studentCardClicked.TabIndex = 10;
            studentCardClicked.TabStop = false;
            // 
            // backBtn
            // 
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(25, 66);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(24, 24);
            backBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            backBtn.TabIndex = 11;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // StudentClicked
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(375, 812);
            Controls.Add(backBtn);
            Controls.Add(studentCardClicked);
            Controls.Add(teacherCard);
            Controls.Add(continueBtn);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentClicked";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentClicked";
            ((System.ComponentModel.ISupportInitialize)continueBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)teacherCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentCardClicked).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox continueBtn;
        private PictureBox pictureBox3;
        private PictureBox teacherCard;
        private PictureBox studentCardClicked;
        private PictureBox backBtn;
    }
}