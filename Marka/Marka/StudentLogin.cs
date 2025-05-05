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
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }

        private void StudentLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string correctEmail = "admin";
            string correctPassword = "admin123";

            // Get entered values
            string enteredEmail = tbEmail.Text;
            string enteredPassword = tbPassword.Text;

            // Check if the email and password are correct
            if (enteredEmail == correctEmail && enteredPassword == correctPassword)
            {
                // If correct, open the next form
                Home nextForm = new Home(); // Replace NextForm with your next form class
                nextForm.Show();
                this.Hide(); // Optionally hide the current form
            }
            else
            {
                // If incorrect, show an error message
                MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbEmail.Text = "";
                tbPassword.Text = "";
            }
        }

        private void eyeIcon_Click(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !tbPassword.UseSystemPasswordChar;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            StudentCreate studentCreate = new StudentCreate();
            studentCreate.Show();
            this.Hide();
        }
    }
}
