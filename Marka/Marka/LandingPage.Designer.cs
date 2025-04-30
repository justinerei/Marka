namespace Marka
{
    partial class LandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            pictureBox3 = new PictureBox();
            continueBtn = new PictureBox();
            haveAccBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)continueBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)haveAccBtn).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-12, 778);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(400, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // continueBtn
            // 
            continueBtn.BackColor = Color.Transparent;
            continueBtn.Image = (Image)resources.GetObject("continueBtn.Image");
            continueBtn.Location = new Point(18, 668);
            continueBtn.Name = "continueBtn";
            continueBtn.Size = new Size(335, 65);
            continueBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            continueBtn.TabIndex = 4;
            continueBtn.TabStop = false;
            continueBtn.Click += pictureBox4_Click;
            // 
            // haveAccBtn
            // 
            haveAccBtn.BackColor = Color.Transparent;
            haveAccBtn.Image = (Image)resources.GetObject("haveAccBtn.Image");
            haveAccBtn.Location = new Point(18, 726);
            haveAccBtn.Name = "haveAccBtn";
            haveAccBtn.Size = new Size(335, 65);
            haveAccBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            haveAccBtn.TabIndex = 5;
            haveAccBtn.TabStop = false;
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(59, 130, 246);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(375, 812);
            Controls.Add(haveAccBtn);
            Controls.Add(continueBtn);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LandingPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LandingPage";
            Load += LandingPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)continueBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)haveAccBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox3;
        private PictureBox continueBtn;
        private PictureBox haveAccBtn;
    }
}