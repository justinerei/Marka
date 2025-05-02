using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Diagnostics.Eventing.Reader;

namespace Marka
{
    public partial class TeacherLogin : Form
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



        public TeacherLogin()
        {
            InitializeComponent();
            RoundPanel(panel1, 25);
            RoundPanel(panel2, 25);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TeacherLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !tbPassword.UseSystemPasswordChar;

        }

        private void continueBtn_Click(object sender, EventArgs e)
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
                LandingPage nextForm = new LandingPage(); // Replace NextForm with your next form class
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

    }
}

