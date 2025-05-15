using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marka
{
    public partial class StudentAdd : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect, int nTopRect,
        int nRightRect, int nBottomRect,
        int nWidthEllipse, int nHeightEllipse);

        private void RoundPanel(Panel panel, int radius)
        {
            panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, radius, radius));
        }

        private Form previousForm;

        public StudentAdd(Form caller)
        {
            InitializeComponent();
            RoundPanel(btnPanel1, 6);
            RoundPanel(btnPanel2, 6);
            RoundPanel(btnPanel3, 6);
            RoundPanel(btnPanel4, 6);
            RoundPanel(rmvPanel1, 6);
            RoundPanel(rmvPanel2, 6);
            RoundPanel(rmvPanel3, 6);
            RoundPanel(rmvPanel4, 6);
            previousForm = caller;
        }

        private void addBtn1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(102, 187, 106);
            button2.Text = "You're friends now!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(102, 187, 106);
            button1.Text = "You're friends now!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(102, 187, 106);
            button3.Text = "You're friends now!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(102, 187, 106);
            button4.Text = "You're friends now!";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(102, 187, 106);
            button6.Text = "Removed!";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(102, 187, 106);
            button7.Text = "Removed!";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(102, 187, 106);
            button5.Text = "Removed!";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(102, 187, 106);
            button8.Text = "Removed!";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // or this.Close();
            previousForm.Show();
        }
    }
}
