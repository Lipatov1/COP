using System.ComponentModel;
using System.Windows.Forms;
using System;

namespace LipatovVisualComponents {
    public partial class LipatovTextBox : UserControl {
        private event EventHandler checkedTextBoxChanged;
        public int? maxLength = 15;
        public int? minLength = 10;

        public int? MaxLength {
            set {
                if (minLength != null) {
                    if (value >= minLength) {
                        maxLength = value;
                    }
                }
                else if (value != null) {
                    maxLength = value;
                }
            }
            get => maxLength;
        }

        public int? MinLength {
            set {
                if (maxLength != null) {
                    if (value <= maxLength) {
                        minLength = value;
                    }
                }
                else if (value != null) {
                    minLength = value;
                }
            }
            get => minLength;
        }

        public string error = "Ошибка! Текст вне диапазана!";

        public LipatovTextBox() {
            InitializeComponent();
            textBox.TextChanged += (sender, e) => checkedTextBoxChanged?.Invoke(sender, e);
        }

        [Category("Пользовательская категория"), Description("Введённое значение")]
        public string InputText {
            set {
                if (minLength.HasValue && maxLength.HasValue) {
                    if (value != null && value.Length >= minLength && value.Length <= maxLength) {
                        textBox.Text = value;
                    }
                }
            }
            //=> textBox.Text = value;

            get {
                if (minLength.HasValue && maxLength.HasValue) {
                    if (textBox.TextLength >= minLength && textBox.TextLength <= maxLength) {
                        return textBox.Text;
                    }
                    else {
                        return null;
                        //throw new ArgumentException("Строка не входит в границы диапазона");
                    }
                }
                else {
                    throw new ArgumentException("Границы диапазона не установлены");
                }
            }
        }

        [Category("Пользовательская категория"), Description("Событие изменение текста")]
        public event EventHandler CheckedTextBoxChanged {
            add { checkedTextBoxChanged += value; }
            remove { checkedTextBoxChanged -= value; }
        }
    }
}