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
            completeCard = new PictureBox();
            progressCard = new PictureBox();
            inactiveCard = new PictureBox();
            userPanel = new PictureBox();
            pendingPanel = new PictureBox();
            checkBox2 = new CheckBox();
            date2 = new Label();
            homeIcon = new PictureBox();
            dot1 = new PictureBox();
            verticalScrolling = new FlowLayoutPanel();
            panel2 = new Panel();
            date1 = new Label();
            checkBox1 = new CheckBox();
            panel1 = new Panel();
            panel3 = new Panel();
            date3 = new Label();
            checkBox3 = new CheckBox();
            homeIndicator = new PictureBox();
            subjectsIcon = new PictureBox();
            plusIcon = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)statusBar).BeginInit();
            horizontalScrolling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)completeCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)progressCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inactiveCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pendingPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dot1).BeginInit();
            verticalScrolling.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)homeIndicator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)subjectsIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plusIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            horizontalScrolling.Controls.Add(completeCard);
            horizontalScrolling.Controls.Add(progressCard);
            horizontalScrolling.Controls.Add(inactiveCard);
            horizontalScrolling.Location = new Point(12, 303);
            horizontalScrolling.Name = "horizontalScrolling";
            horizontalScrolling.Size = new Size(363, 168);
            horizontalScrolling.TabIndex = 9;
            horizontalScrolling.WrapContents = false;
            // 
            // completeCard
            // 
            completeCard.Image = (Image)resources.GetObject("completeCard.Image");
            completeCard.Location = new Point(3, 3);
            completeCard.Name = "completeCard";
            completeCard.Size = new Size(220, 145);
            completeCard.SizeMode = PictureBoxSizeMode.CenterImage;
            completeCard.TabIndex = 0;
            completeCard.TabStop = false;
            // 
            // progressCard
            // 
            progressCard.Image = (Image)resources.GetObject("progressCard.Image");
            progressCard.Location = new Point(229, 3);
            progressCard.Name = "progressCard";
            progressCard.Size = new Size(220, 145);
            progressCard.SizeMode = PictureBoxSizeMode.CenterImage;
            progressCard.TabIndex = 2;
            progressCard.TabStop = false;
            // 
            // inactiveCard
            // 
            inactiveCard.Image = (Image)resources.GetObject("inactiveCard.Image");
            inactiveCard.Location = new Point(455, 3);
            inactiveCard.Name = "inactiveCard";
            inactiveCard.Size = new Size(220, 145);
            inactiveCard.SizeMode = PictureBoxSizeMode.CenterImage;
            inactiveCard.TabIndex = 1;
            inactiveCard.TabStop = false;
            // 
            // userPanel
            // 
            userPanel.Image = (Image)resources.GetObject("userPanel.Image");
            userPanel.Location = new Point(8, 65);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(359, 169);
            userPanel.SizeMode = PictureBoxSizeMode.AutoSize;
            userPanel.TabIndex = 4;
            userPanel.TabStop = false;
            // 
            // pendingPanel
            // 
            pendingPanel.BackColor = Color.FromArgb(243, 244, 246);
            pendingPanel.Image = (Image)resources.GetObject("pendingPanel.Image");
            pendingPanel.Location = new Point(0, 499);
            pendingPanel.Name = "pendingPanel";
            pendingPanel.Size = new Size(375, 314);
            pendingPanel.SizeMode = PictureBoxSizeMode.CenterImage;
            pendingPanel.TabIndex = 10;
            pendingPanel.TabStop = false;
            pendingPanel.Click += pendingPanel_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.White;
            checkBox2.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox2.ForeColor = Color.FromArgb(255, 167, 38);
            checkBox2.Location = new Point(4, 4);
            checkBox2.Margin = new Padding(4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(245, 32);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "TRUTH assignment ITEP102";
            checkBox2.TextAlign = ContentAlignment.BottomCenter;
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // date2
            // 
            date2.AutoSize = true;
            date2.BackColor = Color.White;
            date2.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date2.Location = new Point(23, 27);
            date2.Name = "date2";
            date2.Size = new Size(104, 23);
            date2.TabIndex = 12;
            date2.Text = "02/25/25, 14:00";
            // 
            // homeIcon
            // 
            homeIcon.BackColor = Color.White;
            homeIcon.Image = (Image)resources.GetObject("homeIcon.Image");
            homeIcon.Location = new Point(39, 756);
            homeIcon.Name = "homeIcon";
            homeIcon.Size = new Size(26, 26);
            homeIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            homeIcon.TabIndex = 15;
            homeIcon.TabStop = false;
            // 
            // dot1
            // 
            dot1.BackColor = Color.White;
            dot1.Image = (Image)resources.GetObject("dot1.Image");
            dot1.Location = new Point(50, 785);
            dot1.Name = "dot1";
            dot1.Size = new Size(5, 5);
            dot1.SizeMode = PictureBoxSizeMode.CenterImage;
            dot1.TabIndex = 16;
            dot1.TabStop = false;
            // 
            // verticalScrolling
            // 
            verticalScrolling.AutoScroll = true;
            verticalScrolling.BackColor = Color.White;
            verticalScrolling.Controls.Add(panel2);
            verticalScrolling.Controls.Add(panel1);
            verticalScrolling.Controls.Add(panel3);
            verticalScrolling.FlowDirection = FlowDirection.TopDown;
            verticalScrolling.Location = new Point(27, 600);
            verticalScrolling.Name = "verticalScrolling";
            verticalScrolling.Size = new Size(332, 141);
            verticalScrolling.TabIndex = 17;
            verticalScrolling.WrapContents = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(date1);
            panel2.Controls.Add(checkBox1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 53);
            panel2.TabIndex = 13;
            // 
            // date1
            // 
            date1.AutoSize = true;
            date1.BackColor = Color.White;
            date1.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date1.Location = new Point(23, 27);
            date1.Name = "date1";
            date1.Size = new Size(107, 23);
            date1.TabIndex = 12;
            date1.Text = "02/24/25, 23:59";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.White;
            checkBox1.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.FromArgb(255, 167, 38);
            checkBox1.Location = new Point(4, 4);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(287, 32);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "CODECHUM submission ITEC103";
            checkBox1.TextAlign = ContentAlignment.BottomCenter;
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(date2);
            panel1.Controls.Add(checkBox2);
            panel1.Location = new Point(3, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 53);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(date3);
            panel3.Controls.Add(checkBox3);
            panel3.Location = new Point(3, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(304, 53);
            panel3.TabIndex = 14;
            // 
            // date3
            // 
            date3.AutoSize = true;
            date3.Font = new Font("Poppins", 9.75F);
            date3.Location = new Point(23, 27);
            date3.Name = "date3";
            date3.Size = new Size(104, 23);
            date3.TabIndex = 1;
            date3.Text = "02/25/25, 15:00";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            checkBox3.ForeColor = Color.FromArgb(255, 167, 38);
            checkBox3.Location = new Point(6, 6);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(243, 32);
            checkBox3.TabIndex = 0;
            checkBox3.Text = "ABSTRAK assigment FILDIS";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // homeIndicator
            // 
            homeIndicator.BackColor = Color.White;
            homeIndicator.Image = (Image)resources.GetObject("homeIndicator.Image");
            homeIndicator.Location = new Point(-1, 778);
            homeIndicator.Name = "homeIndicator";
            homeIndicator.Size = new Size(400, 34);
            homeIndicator.SizeMode = PictureBoxSizeMode.CenterImage;
            homeIndicator.TabIndex = 18;
            homeIndicator.TabStop = false;
            // 
            // subjectsIcon
            // 
            subjectsIcon.BackColor = Color.White;
            subjectsIcon.Image = (Image)resources.GetObject("subjectsIcon.Image");
            subjectsIcon.Location = new Point(102, 756);
            subjectsIcon.Name = "subjectsIcon";
            subjectsIcon.Size = new Size(25, 25);
            subjectsIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            subjectsIcon.TabIndex = 19;
            subjectsIcon.TabStop = false;
            // 
            // plusIcon
            // 
            plusIcon.BackColor = Color.White;
            plusIcon.Image = (Image)resources.GetObject("plusIcon.Image");
            plusIcon.Location = new Point(168, 748);
            plusIcon.Name = "plusIcon";
            plusIcon.Size = new Size(38, 38);
            plusIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            plusIcon.TabIndex = 20;
            plusIcon.TabStop = false;
            plusIcon.Click += plusIcon_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(244, 755);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(306, 755);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(375, 812);
            ControlBox = false;
            Controls.Add(homeIcon);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(plusIcon);
            Controls.Add(subjectsIcon);
            Controls.Add(dot1);
            Controls.Add(homeIndicator);
            Controls.Add(verticalScrolling);
            Controls.Add(pendingPanel);
            Controls.Add(userPanel);
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
            ((System.ComponentModel.ISupportInitialize)completeCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)progressCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)inactiveCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)userPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pendingPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dot1).EndInit();
            verticalScrolling.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)homeIndicator).EndInit();
            ((System.ComponentModel.ISupportInitialize)subjectsIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)plusIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox statusBar;
        private Label trackIt;
        private Label seeAll;
        private FlowLayoutPanel horizontalScrolling;
        private PictureBox userPanel;
        private PictureBox completeCard;
        private PictureBox progressCard;
        private PictureBox inactiveCard;
        private PictureBox pendingPanel;
        private CheckBox checkBox2;
        private Label date2;
        private PictureBox homeIcon;
        private PictureBox dot1;
        private FlowLayoutPanel verticalScrolling;
        private Panel panel2;
        private Label date1;
        private CheckBox checkBox1;
        private Panel panel1;
        private Panel panel3;
        private CheckBox checkBox3;
        private Label date3;
        private PictureBox homeIndicator;
        private PictureBox subjectsIcon;
        private PictureBox plusIcon;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
