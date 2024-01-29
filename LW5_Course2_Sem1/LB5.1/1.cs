using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LB5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a, b, c;
        int sum = 0;
        private void button1_Click(object sender, EventArgs e){textBox1.Text += "1";}

        private void button2_Click(object sender, EventArgs e){textBox1.Text += "2";}

        private void button3_Click(object sender, EventArgs e){textBox1.Text += "3";}

        private void button4_Click(object sender, EventArgs e){textBox1.Text += "4";}

        private void button5_Click(object sender, EventArgs e){textBox1.Text += "5";}

        private void button6_Click(object sender, EventArgs e){textBox1.Text += "6";}

        private void button7_Click(object sender, EventArgs e){textBox1.Text += "7";}

        private void button8_Click(object sender, EventArgs e){textBox1.Text += "8";}

        private void button9_Click(object sender, EventArgs e){textBox1.Text += "9";}

        private void button10_Click(object sender, EventArgs e){textBox1.Text += "0";}

        private void button11_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = 1;
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = 2;
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = 3;
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            a = 0;
            b = 0;
            c = 0;
            sum = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = 4;
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            c = Convert.ToInt32(textBox1.Text);
            switch (b)
            {
                case 1:
                    sum = a + c;
                    textBox1.Text = sum.ToString();
                    break;
                case 2:
                    sum = a - c;
                    textBox1.Text = sum.ToString();
                    break;
                case 3:
                    sum = a * c;
                    textBox1.Text = sum.ToString();
                    break;
                case 4:
                    sum = a / c;
                    textBox1.Text = sum.ToString();
                    break;
            }
        }
    }
}