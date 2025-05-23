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
    public partial class WhatUser : Form
    {
        public WhatUser()
        {
            InitializeComponent();
        }

        private void teacherCard_Click(object sender, EventArgs e)
        {
            TeacherClicked teacherClicked = new TeacherClicked();
            teacherClicked.ShowDialog();

            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            QuestionMark questionMark = new QuestionMark();
            questionMark.ShowDialog();
        }

        private void studentCard_Click(object sender, EventArgs e)
        {
            StudentClicked studentClicked = new StudentClicked();
            studentClicked.ShowDialog();

            this.Hide();
        }
    }
}
