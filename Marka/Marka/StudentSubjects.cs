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
    public partial class StudentSubjects : Form
    {
        public StudentSubjects()
        {
            InitializeComponent();
        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            Home studhome = new Home();
            studhome.Show();
            this.Hide();
        }

        private void subjectsIcon_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            StudentProfile profile = new StudentProfile();
            profile.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            StudentNotif notif = new StudentNotif();
            notif.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StudentStats stats = new StudentStats();
            stats.Show();
            this.Hide();
        }
    }
}
