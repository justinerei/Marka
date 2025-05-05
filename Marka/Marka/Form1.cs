using System.Windows.Forms;
using static Marka.Home;

namespace Marka
{
    public partial class Home : Form
    {
        

        public Home()
        {
            InitializeComponent();
        }


        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void searchBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Font = new Font(checkBox2.Font.FontFamily, checkBox2.Font.Size, FontStyle.Strikeout);
                checkBox2.ForeColor = Color.Gray;

                date2.Font = new Font(date2.Font.FontFamily, date2.Font.Size, FontStyle.Strikeout);
                date2.ForeColor = Color.Gray;
            }
            else
            {
                checkBox2.Font = new Font(checkBox2.Font.FontFamily, checkBox2.Font.Size, FontStyle.Regular);
                checkBox2.ForeColor = Color.FromArgb(255, 167, 38);

                date2.Font = new Font(date2.Font.FontFamily, date2.Font.Size, FontStyle.Regular);
                date2.ForeColor = Color.Black;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void date2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Font = new Font(checkBox1.Font.FontFamily, checkBox1.Font.Size, FontStyle.Strikeout);
                checkBox1.ForeColor = Color.Gray;

                date1.Font = new Font(date1.Font.FontFamily, date1.Font.Size, FontStyle.Strikeout);
                date1.ForeColor = Color.Gray;
            }
            else
            {
                checkBox1.Font = new Font(checkBox1.Font.FontFamily, checkBox1.Font.Size, FontStyle.Regular);
                checkBox1.ForeColor = Color.FromArgb(255, 167, 38);

                date1.Font = new Font(date1.Font.FontFamily, date1.Font.Size, FontStyle.Regular);
                date1.ForeColor = Color.Black;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox3.Font = new Font(checkBox3.Font.FontFamily, checkBox3.Font.Size, FontStyle.Strikeout);
                checkBox3.ForeColor = Color.Gray;

                date3.Font = new Font(date3.Font.FontFamily, date3.Font.Size, FontStyle.Strikeout);
                date3.ForeColor = Color.Gray;
            }
            else
            {
                checkBox3.Font = new Font(checkBox3.Font.FontFamily, checkBox3.Font.Size, FontStyle.Regular);
                checkBox3.ForeColor = Color.FromArgb(255, 167, 38);

                date3.Font = new Font(date3.Font.FontFamily, date3.Font.Size, FontStyle.Regular);
                date3.ForeColor = Color.Black;
            }
        }

        private void plusIcon_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm(this);

            if (addTaskForm.ShowDialog() == DialogResult.OK)
            {
                // Create a new panel
                Panel taskPanel = new Panel();
                taskPanel.Size = new Size(304, 53);
                taskPanel.BackColor = Color.Transparent;
                taskPanel.Margin = new Padding(5);

                // Create a new checkbox
                CheckBox taskCheckBox = new CheckBox();
                taskCheckBox.Location = new Point(10, 10);
                taskCheckBox.Size = new Size(30, 30);

                // Create a label for the task title
                Label taskTitle = new Label();
                taskTitle.Text = addTaskForm.TaskTitle; // from user input
                taskTitle.Font = new Font("Poppins", 12, FontStyle.Bold);
                taskTitle.ForeColor = Color.FromArgb(255, 167, 38);
                taskTitle.Location = new Point(40, 5);
                taskTitle.AutoSize = true;

                // Create a label for the task date
                Label taskDate = new Label();
                taskDate.Text = addTaskForm.TaskDeadline.ToString("M/d/yy, HH:mm");
                taskDate.Font = new Font("Poppins", 10, FontStyle.Regular);
                taskDate.ForeColor = Color.Gray;
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
    }
}
