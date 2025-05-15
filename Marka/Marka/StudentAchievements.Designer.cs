namespace Marka
{
    partial class StudentAchievements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentAchievements));
            homeIndicator = new PictureBox();
            pictureBox1 = new PictureBox();
            backBtn = new PictureBox();
            homeIcon = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            plusIcon = new PictureBox();
            subjectsIcon = new PictureBox();
            dot1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)homeIndicator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plusIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)subjectsIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dot1).BeginInit();
            SuspendLayout();
            // 
            // homeIndicator
            // 
            homeIndicator.BackColor = SystemColors.Control;
            homeIndicator.Image = (Image)resources.GetObject("homeIndicator.Image");
            homeIndicator.Location = new Point(-11, 778);
            homeIndicator.Name = "homeIndicator";
            homeIndicator.Size = new Size(400, 34);
            homeIndicator.SizeMode = PictureBoxSizeMode.CenterImage;
            homeIndicator.TabIndex = 26;
            homeIndicator.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(375, 537);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // backBtn
            // 
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(24, 69);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(24, 24);
            backBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            backBtn.TabIndex = 28;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // homeIcon
            // 
            homeIcon.BackColor = SystemColors.Control;
            homeIcon.Image = (Image)resources.GetObject("homeIcon.Image");
            homeIcon.Location = new Point(42, 753);
            homeIcon.Name = "homeIcon";
            homeIcon.Size = new Size(26, 26);
            homeIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            homeIcon.TabIndex = 29;
            homeIcon.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(309, 752);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Control;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(247, 752);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // plusIcon
            // 
            plusIcon.BackColor = SystemColors.Control;
            plusIcon.Image = (Image)resources.GetObject("plusIcon.Image");
            plusIcon.Location = new Point(171, 745);
            plusIcon.Name = "plusIcon";
            plusIcon.Size = new Size(38, 38);
            plusIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            plusIcon.TabIndex = 32;
            plusIcon.TabStop = false;
            // 
            // subjectsIcon
            // 
            subjectsIcon.BackColor = SystemColors.Control;
            subjectsIcon.Image = (Image)resources.GetObject("subjectsIcon.Image");
            subjectsIcon.Location = new Point(105, 753);
            subjectsIcon.Name = "subjectsIcon";
            subjectsIcon.Size = new Size(25, 25);
            subjectsIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            subjectsIcon.TabIndex = 31;
            subjectsIcon.TabStop = false;
            // 
            // dot1
            // 
            dot1.BackColor = Color.White;
            dot1.Image = (Image)resources.GetObject("dot1.Image");
            dot1.Location = new Point(319, 782);
            dot1.Name = "dot1";
            dot1.Size = new Size(5, 5);
            dot1.SizeMode = PictureBoxSizeMode.CenterImage;
            dot1.TabIndex = 30;
            dot1.TabStop = false;
            // 
            // StudentAchievements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 812);
            Controls.Add(homeIcon);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(plusIcon);
            Controls.Add(subjectsIcon);
            Controls.Add(dot1);
            Controls.Add(backBtn);
            Controls.Add(pictureBox1);
            Controls.Add(homeIndicator);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentAchievements";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentAchievements";
            Load += StudentAchievements_Load;
            ((System.ComponentModel.ISupportInitialize)homeIndicator).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)plusIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)subjectsIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dot1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox homeIndicator;
        private PictureBox pictureBox1;
        private PictureBox backBtn;
        private PictureBox homeIcon;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox plusIcon;
        private PictureBox subjectsIcon;
        private PictureBox dot1;
    }
}