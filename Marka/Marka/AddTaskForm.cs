using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marka
{
    public partial class AddTaskForm : Form
    {
        public string TaskTitle { get; private set; }
        public DateTime TaskDeadline { get; private set; }
        private Form previousForm;

        public AddTaskForm(Form caller)
        {
            InitializeComponent();
            previousForm = caller;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if TaskTitle is empty
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text))
            {
                MessageBox.Show("Please enter a task title.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if title is empty
            }

            // Check if the DateTimePicker's value is the default value (not changed)
            if (dateTimePickerDeadline.Value == dateTimePickerDeadline.MinDate)
            {
                MessageBox.Show("Please select a valid deadline.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if deadline is not changed
            }

            // Set the TaskTitle and TaskDeadline properties if both are valid
            TaskTitle = textBoxTitle.Text;
            TaskDeadline = dateTimePickerDeadline.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide(); // or this.Close();
            previousForm.Show();
        }
    }
}
