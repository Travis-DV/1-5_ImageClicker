using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageClicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            centerlb("1");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            centerlb("2");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            centerlb("3");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            centerlb("4");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            centerlb("5");
        }

        private void centerlb(string messige)
        {
            numbLB.Text = $"Number {messige}";
            int heightbuffer = 35;
            int width = 325 - (numbLB.Width/2);
            int height = 125 - (numbLB.Height/2) + heightbuffer;
            numbLB.Location = new System.Drawing.Point(width, height);
            numbLB.Visible = true;
        }
    }
}
