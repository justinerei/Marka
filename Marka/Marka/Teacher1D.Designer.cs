namespace Marka
{
    partial class Teacher1D
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher1D));
            pictureBox2 = new PictureBox();
            pictureBox8 = new PictureBox();
            backBtn = new PictureBox();
            header = new PictureBox();
            topStudCard = new PictureBox();
            scrollBar = new Panel();
            topPerformer = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)header).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topStudCard).BeginInit();
            scrollBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)topPerformer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-17, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(402, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(-12, 778);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(400, 34);
            pictureBox8.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox8.TabIndex = 15;
            pictureBox8.TabStop = false;
            // 
            // backBtn
            // 
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(25, 66);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(24, 24);
            backBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            backBtn.TabIndex = 16;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // header
            // 
            header.Image = (Image)resources.GetObject("header.Image");
            header.Location = new Point(66, 66);
            header.Name = "header";
            header.Size = new Size(309, 51);
            header.SizeMode = PictureBoxSizeMode.AutoSize;
            header.TabIndex = 17;
            header.TabStop = false;
            // 
            // topStudCard
            // 
            topStudCard.Image = (Image)resources.GetObject("topStudCard.Image");
            topStudCard.Location = new Point(6, 143);
            topStudCard.Name = "topStudCard";
            topStudCard.Size = new Size(363, 360);
            topStudCard.SizeMode = PictureBoxSizeMode.AutoSize;
            topStudCard.TabIndex = 18;
            topStudCard.TabStop = false;
            // 
            // scrollBar
            // 
            scrollBar.AutoScroll = true;
            scrollBar.BackColor = Color.White;
            scrollBar.Controls.Add(topPerformer);
            scrollBar.Location = new Point(16, 203);
            scrollBar.Name = "scrollBar";
            scrollBar.Size = new Size(344, 272);
            scrollBar.TabIndex = 19;
            // 
            // topPerformer
            // 
            topPerformer.Image = (Image)resources.GetObject("topPerformer.Image");
            topPerformer.Location = new Point(0, 0);
            topPerformer.Name = "topPerformer";
            topPerformer.Size = new Size(532, 252);
            topPerformer.SizeMode = PictureBoxSizeMode.AutoSize;
            topPerformer.TabIndex = 0;
            topPerformer.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 490);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(320, 507);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(18, 730);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(340, 65);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Teacher1D
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 812);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(scrollBar);
            Controls.Add(topStudCard);
            Controls.Add(header);
            Controls.Add(backBtn);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Teacher1D";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "                    ";
            Load += Teacher1D_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)header).EndInit();
            ((System.ComponentModel.ISupportInitialize)topStudCard).EndInit();
            scrollBar.ResumeLayout(false);
            scrollBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)topPerformer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox8;
        private PictureBox backBtn;
        private PictureBox header;
        private PictureBox topStudCard;
        private Panel scrollBar;
        private PictureBox topPerformer;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}