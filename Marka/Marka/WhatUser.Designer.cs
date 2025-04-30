namespace Marka
{
    partial class WhatUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhatUser));
            teacherCard = new PictureBox();
            studentCard = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)teacherCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentCard).BeginInit();
            SuspendLayout();
            // 
            // teacherCard
            // 
            teacherCard.BackColor = Color.Transparent;
            teacherCard.Image = (Image)resources.GetObject("teacherCard.Image");
            teacherCard.Location = new Point(11, 258);
            teacherCard.Name = "teacherCard";
            teacherCard.Size = new Size(350, 130);
            teacherCard.SizeMode = PictureBoxSizeMode.CenterImage;
            teacherCard.TabIndex = 0;
            teacherCard.TabStop = false;
            // 
            // studentCard
            // 
            studentCard.BackColor = Color.Transparent;
            studentCard.Image = (Image)resources.GetObject("studentCard.Image");
            studentCard.Location = new Point(11, 393);
            studentCard.Name = "studentCard";
            studentCard.Size = new Size(350, 130);
            studentCard.SizeMode = PictureBoxSizeMode.CenterImage;
            studentCard.TabIndex = 1;
            studentCard.TabStop = false;
            // 
            // WhatUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(375, 812);
            Controls.Add(studentCard);
            Controls.Add(teacherCard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WhatUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WhatUser";
            ((System.ComponentModel.ISupportInitialize)teacherCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentCard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox teacherCard;
        private PictureBox studentCard;
    }
}