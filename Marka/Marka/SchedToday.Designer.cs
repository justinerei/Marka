namespace Marka
{
    partial class SchedToday
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedToday));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            backBtn = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-27, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(402, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-12, 778);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 61);
            label1.Name = "label1";
            label1.Size = new Size(187, 37);
            label1.TabIndex = 9;
            label1.Text = "Schedule Today";
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
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(16, 114);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(pictureBox4);
            panel1.Location = new Point(0, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 610);
            panel1.TabIndex = 13;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(17, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(338, 806);
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // SchedToday
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 812);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(backBtn);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SchedToday";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SchedToday";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox backBtn;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox4;
    }
}