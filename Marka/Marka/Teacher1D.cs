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
    public partial class Teacher1D : Form
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

        public Teacher1D()
        {
            InitializeComponent();
            RoundPanel(scrollBar, 10);
        }

        private void Teacher1D_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FullList fullList = new FullList();
            fullList.ShowDialog();

            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            TeacherSectionsHandle teacherSectionsHandle = new TeacherSectionsHandle();
            teacherSectionsHandle.Show();

            this.Close();
        }
    }
}
