using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Marka
{
   

    public partial class StudentPassword : Form
    {
  
        public StudentPassword()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string password = tbPassword.Text;

            bool hasNumber = password.Any(char.IsDigit);
            bool hasMinimumLength = password.Length >= 8;

            if (!hasMinimumLength || !hasNumber)
            {
                MessageBox.Show("Password must be at least 8 characters long and contain at least one number.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPassword.Text = "";
                return;
            }
            else
            {


                StudentUsername username = new StudentUsername();
                username.Show();

                this.Hide();
            }
        }

        private void eyeIcon_Click(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !tbPassword.UseSystemPasswordChar;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            StudentEmail studentEmail = new StudentEmail();
            studentEmail.Show();

            this.Hide();
        }
    }
}
