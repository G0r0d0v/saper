using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace сапер
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "1";
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "1";
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "БАХ!";
            button3.BackColor = Color.Red;
            button3.Enabled = false;
            MessageBox.Show("Вы разлетелись на кусочки!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "БАХ!";
            button4.BackColor = Color.Red;
            button4.Enabled = false;
            MessageBox.Show("Вы разлетелись на кусочки!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "1";
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "1";
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "1";
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "1";
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "БАХ!";
            button9.BackColor = Color.Red;
            button9.Enabled = false;
            MessageBox.Show("Вы разлетелись на кусочки!");
        }
    }
}
