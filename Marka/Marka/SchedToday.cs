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
    public partial class SchedToday : Form
    {
        public SchedToday()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            TeacherHome teacherHome = new TeacherHome();
            teacherHome.Show();

            this.Close();
        }
    }
}
