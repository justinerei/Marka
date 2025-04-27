namespace Marka
{
    partial class AddTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTaskForm));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBoxTitle = new TextBox();
            label2 = new Label();
            dateTimePickerDeadline = new DateTimePicker();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 167, 38);
            label1.Location = new Point(54, 19);
            label1.Name = "label1";
            label1.Size = new Size(184, 40);
            label1.TabIndex = 0;
            label1.Text = "Add New Task";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBoxTitle
            // 
            textBoxTitle.BorderStyle = BorderStyle.None;
            textBoxTitle.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTitle.Location = new Point(61, 83);
            textBoxTitle.Multiline = true;
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(245, 30);
            textBoxTitle.TabIndex = 2;
            textBoxTitle.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 59);
            label2.Name = "label2";
            label2.Size = new Size(62, 22);
            label2.TabIndex = 3;
            label2.Text = "Task Title";
            // 
            // dateTimePickerDeadline
            // 
            dateTimePickerDeadline.CustomFormat = "MM/dd/yyyy HH:mm";
            dateTimePickerDeadline.Format = DateTimePickerFormat.Custom;
            dateTimePickerDeadline.Location = new Point(62, 143);
            dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            dateTimePickerDeadline.Size = new Size(244, 23);
            dateTimePickerDeadline.TabIndex = 4;
            dateTimePickerDeadline.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 121);
            label3.Name = "label3";
            label3.Size = new Size(62, 22);
            label3.TabIndex = 5;
            label3.Text = "Task Title";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 167, 38);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 167, 10);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(272, 184);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 6;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(359, 221);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(dateTimePickerDeadline);
            Controls.Add(label2);
            Controls.Add(textBoxTitle);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddTaskForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddTaskForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBoxTitle;
        private Label label2;
        private DateTimePicker dateTimePickerDeadline;
        private Label label3;
        private Button button1;
    }
}