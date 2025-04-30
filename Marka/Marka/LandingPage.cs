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
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {
            continueBtn.Parent = this; // since there's no panel
            continueBtn.BackColor = Color.Transparent;

            haveAccBtn.Parent = this; // since there's no panel
            haveAccBtn.BackColor = Color.Transparent;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            HelloMark helloMark = new HelloMark();
            helloMark.ShowDialog();

            this.Close();
        }
    }
}
