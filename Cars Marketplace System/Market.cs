using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_Marketplace_System
{
    public partial class Market : Form
    {
        Buy_Cars Car =new Buy_Cars();
        Spare_Parts Parts=new Spare_Parts();

        public Market()
        {
            InitializeComponent();
        }

        private void Market_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Car.Show();
            }
            if (radioButton2.Checked)
            {
                Parts.Show();

            }
        }
    }
}
