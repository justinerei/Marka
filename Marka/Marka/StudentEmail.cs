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
            string email = textBox1.Text.Trim();

            if (!email.EndsWith("@gmail.com") && !email.EndsWith("@yahoo.com"))
            {
                MessageBox.Show("Email must end with @gmail.com or @yahoo.com", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "";
                return;
            }
            else
            { 
                StudentPassword password = new StudentPassword();
                password.Show();

                this.Hide();
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
