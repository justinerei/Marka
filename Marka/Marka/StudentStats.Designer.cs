namespace Marka
{
    partial class StudentStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentStats));
            pictureBox6 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(-11, 778);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(400, 34);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 35;
            pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(375, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 66);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(-10, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 660);
            panel1.TabIndex = 44;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(7, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(382, 706);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // StudentStats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 812);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentStats";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentStats";
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
    }
}