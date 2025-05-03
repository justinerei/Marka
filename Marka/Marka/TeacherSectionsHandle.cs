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
    public partial class TeacherSectionsHandle : Form
    {
        public TeacherSectionsHandle()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            TeacherSubjectHandled teacherSubjectHandled = new TeacherSubjectHandled();
            teacherSubjectHandled.Show();

            this.Close();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Teacher1D teacher1D = new Teacher1D();
            teacher1D.Show();

            this.Close();
        }
    }
}
