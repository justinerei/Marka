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
    public partial class StudentEmail : Form
    {
        public StudentEmail()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string txtEmail = this.txtEmail.Text.Trim();

            if (!txtEmail.EndsWith("@gmail.com") && !txtEmail.EndsWith("@yahoo.com"))
            {
                MessageBox.Show("Email must end with @gmail.com or @yahoo.com", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtEmail.Text = "";
                return;
            }
            else
            {
                User user = new User();
                user.Email = this.txtEmail.Text;

                StudentPassword passwordForm = new StudentPassword(user);
                passwordForm.Show();
                this.Hide(); // optional: hides the current form
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            StudentCreate studentCreate = new StudentCreate();
            studentCreate.Show();

            this.Hide();
        }
    }
}
