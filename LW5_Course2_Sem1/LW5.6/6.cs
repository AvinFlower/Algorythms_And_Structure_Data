using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW5._6
{
    public partial class Form1 : Form
    {
        public Form1()//.. конструктор
        {
            InitializeComponent();
            // Свойства формы:
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "ListBox, richTextBox";
        }
        // поля класса Form1:
        string[] lines = new string[]
                    {"один","два","три","четыре","пять","шесть","семь" };
        string[] newLines = null;

        private void button1_Click_1(object sender, EventArgs e)
        {
            // показать исходный список:
            listBox1.Visible = true;    // показать listBox1
            listBox1.Items.Clear();     // очистить
            listBox1.Items.AddRange(lines); // поместить строки
            newLines = lines;            //
            button2.Visible = true;     // показать button2
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            // удалить выбранный элемент:
            int n = listBox1.SelectedIndex;    // Выделенная строка
            if (n == -1) return;    //.. ничего не выбрано
            string[] tempLines = new string[newLines.Length - 1];
            for (int k = 0, i = 0; i < newLines.Length; i++)
                if (i != n) tempLines[k++] = newLines[i];
            newLines = tempLines;
            listBox1.Items.Clear(); // очистить
            listBox1.Items.AddRange(newLines);  // поместить строки
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string inputText = richTextBox1.Text;  // Получаем текст из RichTextBox
            listBox1.Items.Clear();  // Очищаем ListBox перед добавлением новых элементов
            string[] array = inputText.Split('\n');  // Разделяем текст на отдельные строки по символу новой строки
            foreach (string item in array)
            {
                listBox1.Items.Add(item);  // Добавляем каждый элемент массива в ListBox
            }
        }
    }
}
