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
    public partial class StudentClicked : Form
    {
        public StudentClicked()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            QuestionMark questionMark = new QuestionMark();
            questionMark.ShowDialog();
        }

        private void teacherCard_Click(object sender, EventArgs e)
        {
            TeacherClicked teacherClicked = new TeacherClicked();
            teacherClicked.ShowDialog();

            this.Hide();
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            StudentCreate studentCreate = new StudentCreate();
            studentCreate.ShowDialog();

            this.Show();
        }
    }
}
