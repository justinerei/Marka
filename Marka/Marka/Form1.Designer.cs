namespace Marka
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            statusBar = new PictureBox();
            trackIt = new Label();
            seeAll = new Label();
            horizontalScrolling = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            radioButton2 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)statusBar).BeginInit();
            horizontalScrolling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // statusBar
            // 
            statusBar.Image = (Image)resources.GetObject("statusBar.Image");
            statusBar.Location = new Point(-13, 0);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(402, 50);
            statusBar.SizeMode = PictureBoxSizeMode.CenterImage;
            statusBar.TabIndex = 1;
            statusBar.TabStop = false;
            // 
            // trackIt
            // 
            trackIt.AutoSize = true;
            trackIt.Font = new Font("Poppins", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            trackIt.ForeColor = Color.FromArgb(2, 2, 2);
            trackIt.Location = new Point(17, 264);
            trackIt.Name = "trackIt";
            trackIt.Size = new Size(92, 36);
            trackIt.TabIndex = 0;
            trackIt.Text = "Track it";
            // 
            // seeAll
            // 
            seeAll.AutoSize = true;
            seeAll.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            seeAll.ForeColor = Color.FromArgb(107, 114, 128);
            seeAll.Location = new Point(306, 269);
            seeAll.Name = "seeAll";
            seeAll.Size = new Size(61, 26);
            seeAll.TabIndex = 6;
            seeAll.Text = "See all";
            // 
            // horizontalScrolling
            // 
            horizontalScrolling.AllowDrop = true;
            horizontalScrolling.AutoScroll = true;
            horizontalScrolling.Controls.Add(pictureBox3);
            horizontalScrolling.Controls.Add(pictureBox5);
            horizontalScrolling.Controls.Add(pictureBox4);
            horizontalScrolling.Location = new Point(12, 303);
            horizontalScrolling.Name = "horizontalScrolling";
            horizontalScrolling.Size = new Size(363, 160);
            horizontalScrolling.TabIndex = 9;
            horizontalScrolling.WrapContents = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(220, 145);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(229, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(220, 145);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(455, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(220, 145);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(343, 156);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 499);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(375, 314);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.White;
            radioButton2.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = Color.FromArgb(5, 7, 9);
            radioButton2.Location = new Point(28, 601);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(286, 32);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "CODECHUM submission ITEC103";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(375, 812);
            ControlBox = false;
            Controls.Add(radioButton2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(horizontalScrolling);
            Controls.Add(seeAll);
            Controls.Add(trackIt);
            Controls.Add(statusBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "           ";
            Load += Home_Load_1;
            ((System.ComponentModel.ISupportInitialize)statusBar).EndInit();
            horizontalScrolling.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox statusBar;
        private Label trackIt;
        private Label seeAll;
        private FlowLayoutPanel horizontalScrolling;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private RadioButton radioButton2;
    }
}
