using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace LB2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "Ваши ответы:" + Environment.NewLine;
            int count = 0;
            if (checkBox6.Checked)
            {
                textBox1.Text += "№1 - 1" + Environment.NewLine;
                count++;
            }
            if (checkBox5.Checked)
            {
                textBox1.Text += "№1 - 2" + Environment.NewLine;
            }
            if (checkBox4.Checked)
            {
                textBox1.Text += "№1 - 3" + Environment.NewLine;
            }


            if (checkBox9.Checked)
            {
                textBox1.Text += "№2 - 1" + Environment.NewLine;
                count++;
            }
            if (checkBox8.Checked) textBox1.Text += "№2 - 2" + Environment.NewLine;
            if (checkBox7.Checked) textBox1.Text += "№2 - 3" + Environment.NewLine;


            if (checkBox12.Checked)
            {
                textBox1.Text += "№3 - 1" + Environment.NewLine;
                count++;
            }
            if (checkBox11.Checked) textBox1.Text += "№3 - 2" + Environment.NewLine;
            if (checkBox10.Checked) textBox1.Text += "№3 - 3" + Environment.NewLine;


            if (checkBox15.Checked)
            {
                textBox1.Text += "№4 - 1" + Environment.NewLine;
                count++;
            }
            if (checkBox14.Checked) textBox1.Text += "№4 - 2" + Environment.NewLine;
            if (checkBox13.Checked) textBox1.Text += "№4 - 3" + Environment.NewLine;


            if (checkBox18.Checked) textBox1.Text += "№5 - 1" + Environment.NewLine;
            if (checkBox17.Checked)
            {
                textBox1.Text += "№5 - 2" + Environment.NewLine;
                count++;
            }
            if (checkBox16.Checked) textBox1.Text += "№5 - 3" + Environment.NewLine;


            textBox1.Text += $"Количество правильных ответов: {count}, ваша оценка {count}" + Environment.NewLine;
            if (count > 2) textBox1.Text += "Тест успешно пройден!" + Environment.NewLine;
            else textBox1.Text += "Тест не пройден" + Environment.NewLine;

            if (radioButton1.Checked || (radioButton1.Checked == false && radioButton2.Checked == false)) 
                textBox1.Text += "Правильные ответы:" + Environment.NewLine +
                    "№1 - 1" + Environment.NewLine +
                    "№2 - 1" + Environment.NewLine +
                    "№3 - 1" + Environment.NewLine +
                    "№4 - 1" + Environment.NewLine +
                    "№5 - 2";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void checkBox5_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox6.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox6.Checked = false;
                checkBox5.Checked = false;
            }
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox5.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox9_Click(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                checkBox8.Checked = false;
                checkBox7.Checked = false;
            }
        }

        private void checkBox8_Click(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                checkBox9.Checked = false;
                checkBox7.Checked = false;
            }
        }

        private void checkBox7_Click(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox8.Checked = false;
                checkBox9.Checked = false;
            }
        }

        private void checkBox12_Click(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                checkBox11.Checked = false;
                checkBox10.Checked = false;
            }
        }

        private void checkBox11_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                checkBox12.Checked = false;
                checkBox10.Checked = false;
            }
        }

        private void checkBox10_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                checkBox12.Checked = false;
                checkBox11.Checked = false;
            }
        }

        private void checkBox15_Click(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                checkBox14.Checked = false;
                checkBox13.Checked = false;
            }
        }

        private void checkBox14_Click(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                checkBox15.Checked = false;
                checkBox13.Checked = false;
            }
        }

        private void checkBox13_Click(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                checkBox14.Checked = false;
                checkBox15.Checked = false;
            }
        }

        private void checkBox18_Click(object sender, EventArgs e)
        {
            if (checkBox18.Checked)
            {
                checkBox17.Checked = false;
                checkBox16.Checked = false;
            }
        }

        private void checkBox17_Click(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
            {
                checkBox18.Checked = false;
                checkBox16.Checked = false;
            }
        }

        private void checkBox16_Click(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                checkBox17.Checked = false;
                checkBox18.Checked = false;
            }
        }
    }
}
