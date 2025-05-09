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

        private User _registeredUser;
        public StudentLogin(User user)
        {
            InitializeComponent();
            _registeredUser = user;
        }

        private void StudentLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { 
            // Check if the email and password are correct
            if (tbEmail.Text == _registeredUser.Email &&
                tbPassword.Text == _registeredUser.Password)
            {
                Home home = new Home();
                home.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Email or Password.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
