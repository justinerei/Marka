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
    public partial class StudentProfile : Form
    {
        public StudentProfile()
        {
            InitializeComponent();
        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void subjectsIcon_Click(object sender, EventArgs e)
        {
            StudentSubjects subjects = new StudentSubjects();
            subjects.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            StudentAdd AddFriend = new StudentAdd(this);
            AddFriend.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            StudentAdd AddFriend = new StudentAdd(this);
            AddFriend.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            StudentAchievements achievements = new StudentAchievements();
            achievements.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            StudentNotif notif = new StudentNotif();
            notif.Show();
            this.Hide();
        }
    }
}
