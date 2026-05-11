using Cars_Marketplace_System.Properties;
using System.Media;
namespace Cars_Marketplace_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer startplayer = new SoundPlayer(Properties.Resources.StartPlayer);
            startplayer.Play();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                User_info obj = new User_info();
                obj.Show();
            }
            if (radioButton2.Checked)
            {
                Admin_info obj = new Admin_info();
                obj.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
