using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Marka
{
    public partial class TeacherHome : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect, int nTopRect,
        int nRightRect, int nBottomRect,
        int nWidthEllipse, int nHeightEllipse);

        private void RoundPanel(Panel panel, int radius)
        {
            panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, radius, radius));
        }
        public TeacherHome()
        {
            InitializeComponent();

            RoundPanel(btnPanel1, 6);
            RoundPanel(btnPanel2, 6);
            RoundPanel(btnPanel3, 6);
            RoundPanel(btnPanel4, 6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(102, 187, 106);
            button1.Text = "You're friends now!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(102, 187, 106);
            button2.Text = "You're friends now!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(102, 187, 106);
            button3.Text = "You're friends now!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(102, 187, 106);
            button4.Text = "You're friends now!";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TeacherSubjectHandled teacherSubjectHandled = new TeacherSubjectHandled();
            teacherSubjectHandled.ShowDialog();

            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Font = new Font(checkBox1.Font.FontFamily, checkBox1.Font.Size, FontStyle.Strikeout);
                checkBox1.ForeColor = Color.Gray;

                label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size, FontStyle.Strikeout);
                label1.ForeColor = Color.Gray;

                date1.Font = new Font(date1.Font.FontFamily, date1.Font.Size, FontStyle.Strikeout);
                date1.ForeColor = Color.Gray;
            }
            else
            {
                checkBox1.Font = new Font(checkBox1.Font.FontFamily, checkBox1.Font.Size, FontStyle.Regular);
                checkBox1.ForeColor = Color.White;

                label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size, FontStyle.Regular);
                label1.ForeColor = Color.White;

                date1.Font = new Font(date1.Font.FontFamily, date1.Font.Size, FontStyle.Regular);
                date1.ForeColor = Color.FromArgb(176, 176, 176);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Font = new Font(checkBox2.Font.FontFamily, checkBox2.Font.Size, FontStyle.Strikeout);
                checkBox2.ForeColor = Color.Gray;

                label2.Font = new Font(label2.Font.FontFamily, label2.Font.Size, FontStyle.Strikeout);
                label2.ForeColor = Color.Gray;

                date2.Font = new Font(date2.Font.FontFamily, date2.Font.Size, FontStyle.Strikeout);
                date2.ForeColor = Color.Gray;
            }
            else
            {
                checkBox2.Font = new Font(checkBox2.Font.FontFamily, checkBox2.Font.Size, FontStyle.Regular);
                checkBox2.ForeColor = Color.White;

                label2.Font = new Font(label2.Font.FontFamily, label2.Font.Size, FontStyle.Regular);
                label2.ForeColor = Color.White;

                date2.Font = new Font(date2.Font.FontFamily, date2.Font.Size, FontStyle.Regular);
                date2.ForeColor = Color.FromArgb(176, 176, 176);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox3.Font = new Font(checkBox3.Font.FontFamily, checkBox3.Font.Size, FontStyle.Strikeout);
                checkBox3.ForeColor = Color.Gray;

                label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size, FontStyle.Strikeout);
                label3.ForeColor = Color.Gray;

                date3.Font = new Font(date3.Font.FontFamily, date3.Font.Size, FontStyle.Strikeout);
                date3.ForeColor = Color.Gray;
            }
            else
            {
                checkBox3.Font = new Font(checkBox3.Font.FontFamily, checkBox3.Font.Size, FontStyle.Regular);
                checkBox3.ForeColor = Color.White;

                label3.Font = new Font(label3.Font.FontFamily, label3.Font.Size, FontStyle.Regular);
                label3.ForeColor = Color.White;

                date3.Font = new Font(date3.Font.FontFamily, date3.Font.Size, FontStyle.Regular);
                date3.ForeColor = Color.FromArgb(176, 176, 176);
            }
        }

        private void plusIcon_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm(this);

            if (addTaskForm.ShowDialog() == DialogResult.OK)
            {
                // Create a new panel
                Panel taskPanel = new Panel();
                taskPanel.Size = new Size(152, 53);
                taskPanel.BackColor = Color.Transparent;

                // Create a new checkbox
                CheckBox taskCheckBox = new CheckBox();
                taskCheckBox.Location = new Point(8, 10);
                taskCheckBox.Size = new Size(30, 30);

                // Create a label for the task title
                Label taskTitle = new Label();
                taskTitle.Text = addTaskForm.TaskTitle; // from user input
                taskTitle.Font = new Font("Poppins", 9, FontStyle.Bold);
                taskTitle.ForeColor = Color.White;
                taskTitle.Location = new Point(35, 5);
                taskTitle.AutoSize = true;

                // Create a label for the task date
                Label taskDate = new Label();
                taskDate.Text = addTaskForm.TaskDeadline.ToString("M/d/yy, HH:mm");
                taskDate.Font = new Font("Poppins", 6, FontStyle.Regular);
                taskDate.ForeColor = Color.FromArgb(176, 176, 176);
                taskDate.Location = new Point(40, 30);
                taskDate.AutoSize = true;

                // Strikeout if checkbox checked
                taskCheckBox.CheckedChanged += (s, args) =>
                {
                    if (taskCheckBox.Checked)
                    {
                        taskTitle.Font = new Font(taskTitle.Font, FontStyle.Strikeout);
                        taskDate.Font = new Font(taskDate.Font, FontStyle.Strikeout);
                    }
                    else
                    {
                        taskTitle.Font = new Font(taskTitle.Font, FontStyle.Bold);
                        taskDate.Font = new Font(taskDate.Font, FontStyle.Regular);
                    }
                };

                // Add into panel
                taskPanel.Controls.Add(taskCheckBox);
                taskPanel.Controls.Add(taskTitle);
                taskPanel.Controls.Add(taskDate);

                // Add panel into FlowLayoutPanel
                verticalScrolling.Controls.Add(taskPanel);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SchedToday schedToday = new SchedToday();
            schedToday.Show();

            this.Close();
        }
    }
}
