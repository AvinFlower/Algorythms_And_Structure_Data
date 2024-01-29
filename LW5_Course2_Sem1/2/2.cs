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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace _2
{
    public partial class Form1 : Form
    {

        List<Task> tasks = new List<Task>();
        public Form1()
        {
            InitializeComponent();
            InitializeShoppingList();
        }

        private void InitializeShoppingList()
        {
            // Добавим элементы в ComboBox с продуктами
            comboBox1.Items.Add("Хлеб");
            comboBox1.Items.Add("Молоко");
            comboBox1.Items.Add("Яйца");
            comboBox1.Items.Add("Фрукты");

            // Настроим ListView для отображения списка покупок
            listView1.View = View.Details;
            listView1.Columns.Add("Продукт", 100);
            listView1.Columns.Add("Количество", 100);
            listView1.Columns.Add("Дата покупки", 150);

            // Добавим элементы в DomainUpDown для выбора даты покупки
            DateTime currentDate = DateTime.Now;
            domainUpDown1.Text = currentDate.ToString("dd.MM.yyyy");

            // Добавление узлов в TreeView
            TreeNode rootNode = new TreeNode("Категории продуктов");
            treeView1.Nodes.Add(rootNode);

            TreeNode fruitsNode = new TreeNode("Фрукты");
            rootNode.Nodes.Add(fruitsNode);

            TreeNode dairyNode = new TreeNode("Молочные продукты");
            rootNode.Nodes.Add(dairyNode);

            // Добавление элементов в CheckedListBox
            checkedListBox1.Items.Add("Хлеб");
            checkedListBox1.Items.Add("Молоко");
            checkedListBox1.Items.Add("Яйца");
            checkedListBox1.Items.Add("Фрукты");
        }


        private void addProductButton_Click_1(object sender, EventArgs e)
        {
            // Получим значения из элементов управления
            string product = comboBox1.Text;
            int quantity = (int)numericUpDown1.Value;
            string purchaseDate = domainUpDown1.Text;

            // Добавим продукт в ListView
            ListViewItem item = new ListViewItem(product);
            item.SubItems.Add(quantity.ToString());
            item.SubItems.Add(purchaseDate);
            listView1.Items.Add(item);
        }
    }
}
