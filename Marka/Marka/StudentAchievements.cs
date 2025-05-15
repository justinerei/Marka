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
    public partial class StudentAchievements : Form
    {
        public StudentAchievements()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            StudentProfile profile = new StudentProfile();
            profile.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void StudentAchievements_Load(object sender, EventArgs e)
        {

        }
    }
}
