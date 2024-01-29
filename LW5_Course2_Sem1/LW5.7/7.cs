using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW5._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs ex)
        {
            // Чтение списка из файла1
            List<string> lines = new List<string>();
            string filePath1 = "file.txt";
            try
            {
                using (StreamReader reader = new StreamReader(filePath1))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string modifiedLine = "изменения " + line;
                        lines.Add(modifiedLine);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ошибка при чтении файла1: " + e.Message);
                return;
            }
            // Запись измененных данных в файл2
            string filePath2 = "file2.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath2))
                {
                    foreach (string line in lines) { writer.WriteLine(line); }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ошибка при записи файла2: " + e.Message);
                return;
            }
            //Заполнение listBox
            listBox1.Items.Clear();
            string[] lines2 = File.ReadAllLines(filePath2);
            listBox1.Items.AddRange(lines2);
        }
    }
}

