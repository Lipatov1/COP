using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;
using System;

namespace LipatovVisualComponents {
    public partial class LipatovCheckedListBox : UserControl {
        private event EventHandler checkedListBoxItemChecked;

        public LipatovCheckedListBox() {
            InitializeComponent();
            checkedListBox.ItemCheck += (sender, e) => checkedListBoxItemChecked?.Invoke(sender, e);
        }

        public void AddItem(string item) {
            checkedListBox.Items.Add(item);
        }

        public void ClearItems() {
            checkedListBox.Items.Clear();
        }

        [Category("Пользовательская категория"), Description("Выбранные элементы")]
        public string[] CheckedItems {
            get => checkedListBox.CheckedItems.Cast<string>().ToArray();
            set {
                foreach (var item in value) {
                    int index = checkedListBox.Items.IndexOf(item);

                    if (index >= 0 && index < checkedListBox.Items.Count) {
                        checkedListBox.SetItemChecked(index, true);
                    }
                }
            }
        }

        [Category("Пользовательская категория"), Description("Событие выбора элемента из списка")]
        public event EventHandler CheckedListBoxItemChecked {
            add { checkedListBoxItemChecked += value; }
            remove { checkedListBoxItemChecked -= value; }
        }
    }
}