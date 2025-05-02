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
    public partial class HelloMark : Form
    {
        public HelloMark()
        {
            InitializeComponent();
        }

        private void helloMark_Load(object sender, EventArgs e)
        {
            continueBtn.Parent = this; // since there's no panel
            continueBtn.BackColor = Color.Transparent;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            landingPage.Show();

            
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            QuestionMark questionMark = new QuestionMark();
            questionMark.ShowDialog();

            this.Hide();
        }
    }
}
