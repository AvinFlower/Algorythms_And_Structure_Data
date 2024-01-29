using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sw = new Stopwatch();
            sw.Start();
            double X = Convert.ToDouble(textBox1.Text);
            double Y = Convert.ToDouble(textBox2.Text);
            double sum = X - Y;
            double sum1 = Y - X;
            if (X > Y) richTextBox1.Text = $"X больше Y на {sum}";
            else if (Y > X) richTextBox1.Text = $"Y больше X на {sum1}";
            else richTextBox1.Text = "Значения равны";
            sw.Stop();
            label3.Text = $"Времени пройдено: {sw.Elapsed}";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
