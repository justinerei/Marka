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
    public partial class StudentNotif : Form
    {
        public StudentNotif()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            StudentProfile profile = new StudentProfile();
            profile.Show();
            this.Hide();
        }

        private void subjectsIcon_Click(object sender, EventArgs e)
        {
            StudentSubjects subjects = new StudentSubjects();
            subjects.Show();
            this.Hide();
        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();

        }
    }
}
