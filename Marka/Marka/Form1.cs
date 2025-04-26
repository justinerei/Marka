using static Marka.Home;

namespace Marka
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void searchBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Font = new Font(checkBox1.Font.FontFamily, checkBox1.Font.Size, FontStyle.Strikeout);
                checkBox1.ForeColor = Color.Gray;

                date1.Font = new Font(date1.Font.FontFamily, date1.Font.Size, FontStyle.Strikeout);
                date1.ForeColor = Color.Gray;
            }
            else
            {
                checkBox1.Font = new Font(checkBox1.Font.FontFamily, checkBox1.Font.Size, FontStyle.Regular);
                checkBox1.ForeColor = Color.FromArgb(255, 167, 38);

                date1.Font = new Font(date1.Font.FontFamily, date1.Font.Size, FontStyle.Regular);
                date1.ForeColor = Color.Black;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Font = new Font(checkBox2.Font.FontFamily, checkBox2.Font.Size, FontStyle.Strikeout);
                checkBox2.ForeColor = Color.Gray;

                date2.Font = new Font(date2.Font.FontFamily, date2.Font.Size, FontStyle.Strikeout);
                date2.ForeColor = Color.Gray;
            }
            else
            {
                checkBox2.Font = new Font(checkBox2.Font.FontFamily, checkBox2.Font.Size, FontStyle.Regular);
                checkBox2.ForeColor = Color.FromArgb(255, 167, 38); 

                date2.Font = new Font(date2.Font.FontFamily, date2.Font.Size, FontStyle.Regular);
                date2.ForeColor = Color.Black;
            }
        }
    }
}
