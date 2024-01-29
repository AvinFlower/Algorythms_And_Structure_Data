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

namespace LR5._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigureListViewColumns();

            listView1.SmallImageList = imageList1;
        }
        private void ConfigureListViewColumns()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Переписка", listView1.Width - 4);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Проверяем, что в ListBox1 есть элементы
            if (listBox1.Items.Count > 0)
            {
                // Указываем путь к файлу, в который хотим сохранить данные
                string filePath = "text.txt";
                // Создаем новый экземпляр StreamWriter для записи в файл
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Перебираем все элементы ListBox1 и записываем их в файл
                    foreach (var item in listBox1.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }
                // Вставляем строку "Привет!" между первой и второй строкой
                InsertHelloAsThirdLine(filePath);
                // Считываем из файла в список List
                List<string> linesList = ReadFileToList(filePath);
                // Сортируем строки списка
                linesList.Sort();
                // Перед методом BinarySearch() сохраняем количество строк в отдельную переменную
                int originalLinesCount = linesList.Count;
                // Используя метод BinarySearch(), определяем, есть ли строка «Привет!» в списке
                int index = linesList.BinarySearch("Привет!");
                if (index >= 0)
                {
                    // Восстанавливаем порядок строк, как было до сортировки
                    string helloKolyaLine = "Привет, Коля!";
                    linesList.RemoveAt(index);
                    linesList.Insert(1, helloKolyaLine);

                    File.WriteAllLines(filePath, linesList);

                    // Выводим сообщение об успешном добавлении
                    MessageBox.Show("Ура, добавили!");
                }
                else MessageBox.Show("Строка 'Привет!' не найдена в списке.");

                try
                {
                    Image image = Properties.Resources.image;
                    Image image2 = Properties.Resources.image2;

                    imageList1.Images.Add(image);
                    imageList1.Images.Add(image2);

                    for (int i = 0; i < linesList.Count; i++)
                    {
                        string line = linesList[i];
                        ListViewItem item = new ListViewItem(line, i % 2);
                        listView1.Items.Add(item);
                    }
                    MessageBox.Show("Данные успешно сохранены в файл!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка при добавлении данных в ListView: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("ListBox1 пуст. Нечего сохранять.");
            }
        }

        private void InsertHelloAsThirdLine(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath); // Читаем все строки из файла в массив строк
                List<string> newLines = new List<string>(); // Создаем список для новых строк
                if (lines.Length >= 1) newLines.Add(lines[0]); // Добавляем первую строку
                if (lines.Length >= 2) newLines.Add(lines[1]); // Проверяем, есть ли вторая строка

                // Проверяем, есть ли строка "Привет!" в оригинальных строках
                bool helloFound = false;
                foreach (var line in lines)
                {
                    if (line == "Привет!")
                    {
                        helloFound = true;
                        break;
                    }
                }

                if (!helloFound) newLines.Add("Привет!"); // Если строка "Привет!" не найдена, добавляем её

                for (int i = 2; i < lines.Length; i++) // Добавляем остальные строки, начиная с четвёртой
                {
                    newLines.Add(lines[i]);
                }
                File.WriteAllLines(filePath, newLines); // Записываем новые строки обратно в файл
                MessageBox.Show("Строка успешно обновлена в файле!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private List<string> ReadFileToList(string filePath)
        {
            List<string> linesList = new List<string>();
            try
            {
                // Читаем все строки из файла и добавляем их в список
                string[] lines = File.ReadAllLines(filePath);
                linesList.AddRange(lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при чтении файла: {ex.Message}");
            }
            return linesList;
        }
    }
}
