﻿using System;
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
    public partial class StudentStats : Form
    {
        public StudentStats()
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StudentSubjects subjects = new StudentSubjects();
            subjects.Show();
            this.Hide();
        }
    }
}
