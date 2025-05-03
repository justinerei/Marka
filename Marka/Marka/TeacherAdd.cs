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
    public partial class TeacherAdd : Form
    {
        public TeacherAdd()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            // Check if the email and password are correct
            if (tbTitle.Text == "" && tbDesc.Text == "")
            {
                MessageBox.Show("Input Task Title or Task Description. Please try again.", "Assigning Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddConfirm nextForm = new AddConfirm(); // Replace NextForm with your next form class
                nextForm.Show();
                // Optionally hide the current form
            }
        }
    }
}
