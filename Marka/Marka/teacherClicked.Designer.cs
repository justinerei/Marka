namespace Marka
{
    partial class TeacherClicked
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherClicked));
            pictureBox3 = new PictureBox();
            teacherCardClicked = new PictureBox();
            studentCard = new PictureBox();
            continueBtn = new PictureBox();
            backBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teacherCardClicked).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)continueBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-12, 778);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(400, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // teacherCardClicked
            // 
            teacherCardClicked.BackColor = Color.Transparent;
            teacherCardClicked.Image = (Image)resources.GetObject("teacherCardClicked.Image");
            teacherCardClicked.Location = new Point(11, 258);
            teacherCardClicked.Name = "teacherCardClicked";
            teacherCardClicked.Size = new Size(350, 130);
            teacherCardClicked.SizeMode = PictureBoxSizeMode.CenterImage;
            teacherCardClicked.TabIndex = 4;
            teacherCardClicked.TabStop = false;
            teacherCardClicked.Click += teacherCardClicked_Click;
            // 
            // studentCard
            // 
            studentCard.BackColor = Color.Transparent;
            studentCard.Image = (Image)resources.GetObject("studentCard.Image");
            studentCard.Location = new Point(11, 393);
            studentCard.Name = "studentCard";
            studentCard.Size = new Size(350, 130);
            studentCard.SizeMode = PictureBoxSizeMode.CenterImage;
            studentCard.TabIndex = 5;
            studentCard.TabStop = false;
            studentCard.Click += studentCard_Click;
            // 
            // continueBtn
            // 
            continueBtn.BackColor = Color.Transparent;
            continueBtn.Image = (Image)resources.GetObject("continueBtn.Image");
            continueBtn.Location = new Point(18, 730);
            continueBtn.Name = "continueBtn";
            continueBtn.Size = new Size(335, 65);
            continueBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            continueBtn.TabIndex = 6;
            continueBtn.TabStop = false;
            // 
            // backBtn
            // 
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(25, 66);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(24, 24);
            backBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            backBtn.TabIndex = 7;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // TeacherClicked
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(375, 812);
            Controls.Add(backBtn);
            Controls.Add(continueBtn);
            Controls.Add(studentCard);
            Controls.Add(teacherCardClicked);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TeacherClicked";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "teacherClicked";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)teacherCardClicked).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)continueBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox teacherCardClicked;
        private PictureBox studentCard;
        private PictureBox continueBtn;
        private PictureBox backBtn;
    }
}