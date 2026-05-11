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
    public partial class User_info : Form
    {
        public User_info()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            if (String.IsNullOrWhiteSpace(Name))
            {
                MessageBox.Show("Enter again Please!");
                return;
            }
            foreach (char c in Name)
            {
                if (char.IsDigit(c) || char.IsPunctuation(c))
                {
                    MessageBox.Show("Enter Valid Name!");
                    return;
                }
            }
            bool Checkpass = long.TryParse(textBox2.Text, out long Pass);
            if (Checkpass == false)
            {
                MessageBox.Show("Enter Numbers Please!");
                return;
            }
            Market obj = new Market();
            obj.Show();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void User_info_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;  
        }
    }
}
