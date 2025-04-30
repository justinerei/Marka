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
    public partial class QuestionMark : Form
    {
        public QuestionMark()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            HelloMark helloMark = new HelloMark();
            helloMark.ShowDialog();
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            WhatUser whatUser = new WhatUser();
            whatUser.ShowDialog();

            this.Close();
        }
    }
}
