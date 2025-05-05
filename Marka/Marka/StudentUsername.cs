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
    public partial class StudentUsername : Form
    {

        public StudentUsername()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            bool hasMinimumLength = username.Length >= 4;

            if (!hasMinimumLength)
            {
                MessageBox.Show("Username must be at least 4 characters.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                username = "";
                return;
            }
            else
            {
                StudentLogin loginForm = new StudentLogin();
                loginForm.Show();
                this.Hide();

            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            StudentPassword password = new StudentPassword();
            password.Show();

            

            this.Hide();
        }
    }
}
