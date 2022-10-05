using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace TestWindowsFormsApp {
    public partial class VisualComponentsTestForm : Form {
        public VisualComponentsTestForm() {
            InitializeComponent();
            lipatovTreeView.SetHierarchy(new List<string> { "Category", "Manufacturer", "Name" });
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            string item1 = "Продукт 1";
            string item2 = "Продукт 2";
            string item3 = "Продукт 3";

            lipatovCheckedListBox.AddItem(item1);
            lipatovCheckedListBox.AddItem(item2);
            lipatovCheckedListBox.AddItem(item3);
        }

        private void buttonClear_Click(object sender, EventArgs e) {
            lipatovCheckedListBox.ClearItems();
        }

        private void buttonOutput_Click(object sender, EventArgs e) {
            MessageBox.Show(string.Join(", ", lipatovCheckedListBox.CheckedItems));
        }

        private void buttonSetCheckedItems_Click(object sender, EventArgs e) {
            lipatovCheckedListBox.CheckedItems = new[] { "Продукт 1", "Продукт 2" };
        }

        private void buttonGetText_Click(object sender, EventArgs e) {
            string text = lipatovTextBox.InputText;

            if (text == null) {
                MessageBox.Show(lipatovTextBox.error);
            }
            else {
                MessageBox.Show(text);
            }


            //MessageBox.Show(lipatovTextBox.InputText);
        }

        private void buttonSetText_Click(object sender, EventArgs e) {
            lipatovTextBox.InputText = "Новый текст";
        }

        private void buttonSetBadText_Click(object sender, EventArgs e) {
            lipatovTextBox.InputText = "Новый текст 123456";
        }

        [Serializable]
        class Product {
            public string Category { get; set; }
            public string Manufacturer { get; set; }
            public string Name { get; set; }

            public Product (string category, string manufacturer, string name) {
                Category = category;
                Manufacturer = manufacturer;
                Name = name;
            }
        }

        private void buttonAddObjects_Click(object sender, EventArgs e) {
            lipatovTreeView.AddItem(new Product("Категория 1", "Производитель 1", "Название 1"));
            lipatovTreeView.AddItem(new Product("Категория 2", "Производитель 2", "Название 2"));
            lipatovTreeView.AddItem(new Product("Категория 3", "Производитель 3", "Название 3"));
            lipatovTreeView.AddItem(new Product("Категория 1", "Производитель 4", "Название 4"));
            lipatovTreeView.AddItem(new Product("Категория 1", "Производитель 1", "Название 5"));
            lipatovTreeView.AddItem(new Product("Категория 3", "Производитель 2", "Название 6"));
        }

        private void buttonSelectNode_Click(object sender, EventArgs e) {
            lipatovTreeView.SelectedBranchIndex = 1;
        }
    }
}