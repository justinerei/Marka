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
            panelProfile = new Panel();
            profilePic = new PictureBox();
            tasksPending = new Label();
            date = new Label();
            username = new Label();
            searchBar = new Panel();
            label1 = new Label();
            searchIcon = new PictureBox();
            homeIndicator = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)statusBar).BeginInit();
            panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePic).BeginInit();
            searchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIndicator).BeginInit();
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
            // panelProfile
            // 
            panelProfile.BackColor = SystemColors.ButtonHighlight;
            panelProfile.Controls.Add(profilePic);
            panelProfile.Controls.Add(tasksPending);
            panelProfile.Controls.Add(date);
            panelProfile.Controls.Add(username);
            panelProfile.Location = new Point(16, 68);
            panelProfile.Name = "panelProfile";
            panelProfile.Size = new Size(343, 129);
            panelProfile.TabIndex = 2;
            // 
            // profilePic
            // 
            profilePic.Image = (Image)resources.GetObject("profilePic.Image");
            profilePic.Location = new Point(239, 23);
            profilePic.Name = "profilePic";
            profilePic.Size = new Size(75, 75);
            profilePic.SizeMode = PictureBoxSizeMode.CenterImage;
            profilePic.TabIndex = 3;
            profilePic.TabStop = false;
            // 
            // tasksPending
            // 
            tasksPending.AutoSize = true;
            tasksPending.Font = new Font("Poppins", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tasksPending.ForeColor = Color.FromArgb(42, 45, 50);
            tasksPending.Location = new Point(32, 85);
            tasksPending.Name = "tasksPending";
            tasksPending.Size = new Size(84, 16);
            tasksPending.TabIndex = 2;
            tasksPending.Text = "10 tasks pending ";
            // 
            // date
            // 
            date.AutoSize = true;
            date.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date.ForeColor = Color.FromArgb(2, 3, 4);
            date.Location = new Point(32, 60);
            date.Name = "date";
            date.Size = new Size(91, 23);
            date.TabIndex = 1;
            date.Text = "Feb. 20, 2025";
            // 
            // username
            // 
            username.AutoSize = true;
            username.BackColor = SystemColors.ButtonHighlight;
            username.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username.ForeColor = Color.FromArgb(2, 2, 2);
            username.Location = new Point(29, 26);
            username.Name = "username";
            username.Size = new Size(163, 42);
            username.TabIndex = 0;
            username.Text = "Hello, Juan!";
            // 
            // searchBar
            // 
            searchBar.AutoScroll = true;
            searchBar.BackColor = Color.FromArgb(31, 44, 55);
            searchBar.Controls.Add(label1);
            searchBar.Controls.Add(searchIcon);
            searchBar.Location = new Point(93, 183);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(183, 30);
            searchBar.TabIndex = 3;
            searchBar.Paint += searchBar_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(31, 44, 55);
            label1.Font = new Font("Poppins SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(107, 114, 128);
            label1.Location = new Point(44, 7);
            label1.Name = "label1";
            label1.Size = new Size(124, 19);
            label1.TabIndex = 5;
            label1.Text = "Search for anything..";
            label1.Click += label1_Click;
            // 
            // searchIcon
            // 
            searchIcon.Image = (Image)resources.GetObject("searchIcon.Image");
            searchIcon.Location = new Point(27, 7);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(15, 15);
            searchIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            searchIcon.TabIndex = 4;
            searchIcon.TabStop = false;
            // 
            // homeIndicator
            // 
            homeIndicator.Image = (Image)resources.GetObject("homeIndicator.Image");
            homeIndicator.Location = new Point(-12, 778);
            homeIndicator.Name = "homeIndicator";
            homeIndicator.Size = new Size(400, 34);
            homeIndicator.SizeMode = PictureBoxSizeMode.CenterImage;
            homeIndicator.TabIndex = 4;
            homeIndicator.TabStop = false;
            homeIndicator.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(2, 2, 2);
            label2.Location = new Point(17, 264);
            label2.Name = "label2";
            label2.Size = new Size(92, 36);
            label2.TabIndex = 0;
            label2.Text = "Track it";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(107, 114, 128);
            label3.Location = new Point(306, 269);
            label3.Name = "label3";
            label3.Size = new Size(61, 26);
            label3.TabIndex = 6;
            label3.Text = "See all";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(375, 812);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(homeIndicator);
            Controls.Add(searchBar);
            Controls.Add(panelProfile);
            Controls.Add(statusBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)statusBar).EndInit();
            panelProfile.ResumeLayout(false);
            panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePic).EndInit();
            searchBar.ResumeLayout(false);
            searchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIndicator).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox statusBar;
        private Panel panelProfile;
        private Label username;
        private Label date;
        private Label tasksPending;
        private PictureBox profilePic;
        private Panel searchBar;
        private PictureBox searchIcon;
        private Label label1;
        private PictureBox homeIndicator;
        private Label label2;
        private Label label3;
    }
}
