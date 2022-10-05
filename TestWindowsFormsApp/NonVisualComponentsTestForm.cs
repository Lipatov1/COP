﻿using LipatovNonVisualComponents.HelperModels;
using LipatovNonVisualComponents.Enums;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace TestWindowsFormsApp {
    public partial class NonVisualComponentsTestForm : Form {
        private List<TableCell> firstColumn;
        private List<TableCell> secondColumn;
        private List<Employee> employees;

        public NonVisualComponentsTestForm() {
            InitializeComponent();

            employees = new List<Employee> {
                new Employee() {
                    Id = 1,
                    Status = "Нет",
                    FirstName = "Иван",
                    SecondName = "Иванов",
                    Age = 34,
                    Children = "Нет",
                    Car = "Есть",
                    Department = "Департамент 1",
                    Position = "Инженер",
                    Bonus = 2000.1
                },
                new Employee() {
                    Id = 2,
                    Status = "Нет",
                    FirstName = "Петр",
                    SecondName = "Петров",
                    Age = 44,
                    Children = "Есть",
                    Car = "Есть",
                    Department = "Департамент 1",
                    Position = "Инженер",
                    Bonus = 2000.1
                },
                new Employee() {
                    Id = 3,
                    Status = "Да",
                    FirstName = "Сергей",
                    SecondName = "Сергеев",
                    Age = 55,
                    Children = "Нет",
                    Car = "Есть",
                    Department = "Департамент 2",
                    Position = "Руководитель",
                    Bonus = 5000.5
                },
                new Employee() {
                    Id = 4,
                    Status = "Да",
                    FirstName = "Ольга",
                    SecondName = "Иванова",
                    Age = 34,
                    Children = "Есть",
                    Car = "Нет",
                    Department = "Бухгалтерия",
                    Position = "Бухгалтер",
                    Bonus = 2000.1
                },
                new Employee() {
                    Id = 5,
                    Status = "Да",
                    FirstName = "Татьяна",
                    SecondName = "Петрова",
                    Age = 44,
                    Children = "Нет",
                    Car = "Нет",
                    Department = "Бухгалтерия",
                    Position = "Старший бухгалтер",
                    Bonus = 7000.6
                }
            };

            firstColumn = new List<TableCell> {
                new TableCell() {
                    Name = "Id",
                    RowHeight = "1cm",
                    PropertyName = "Id"
                },
                new TableCell() {
                    Name = "Статус",
                    RowHeight = "1,5cm",
                    PropertyName = "Status"
                },
                new TableCell() {
                    Name = "Личные данные",
                    RowHeight = "2cm",
                    CountCells = 3,
                },
                new TableCell() {
                    Name = "Дети",
                    RowHeight = "1,5cm",
                    PropertyName = "Children"
                },
                new TableCell() {
                    Name = "Машина",
                    RowHeight = "1cm",
                    PropertyName = "Car"
                },
                new TableCell() {
                    Name = "Работа",
                    RowHeight = "2cm",
                    CountCells = 2
                },
                new TableCell() {
                    Name = "Премия",
                    RowHeight = "1,5cm",
                    PropertyName = "Bonus"
                }
            };

            secondColumn = new List<TableCell> {
                new TableCell() {
                    Name = "Имя",
                    PropertyName = "FirstName"
                },
                new TableCell() {
                    Name = "Фамилия",
                    PropertyName = "SecondName"
                },
                new TableCell() {
                    Name = "Возраст",
                    PropertyName = "Age"
                },
                new TableCell() {
                    Name = "Подразделение",
                    PropertyName = "Department"
                },
                new TableCell() {
                    Name = "Должность",
                    PropertyName = "Position"
                }
            };
        }

        private void buttonGenerateContext_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBoxTitleContext.Text)) {
                MessageBox.Show("Введите заголовок", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var ofd = new OpenFileDialog { Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" + "All files (*.*)|*.*", Multiselect = true } ) {
                if (ofd.ShowDialog() == DialogResult.OK) {
                    using (var sfd = new SaveFileDialog { Filter = "pdf|*.pdf" }) {
                        if (sfd.ShowDialog() == DialogResult.OK) {
                            if (lipatovContextPdf.CreateDocument(sfd.FileName, textBoxTitleContext.Text, ofd.FileNames)) {
                                MessageBox.Show("Документ сохранён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else {
                                MessageBox.Show(lipatovContextPdf.ErrorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }

            textBoxTitleContext.Clear();
        }

        private void buttonGenerateTable_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBoxTitleTable.Text)) {
                MessageBox.Show("Введите заголовок", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var sfd = new SaveFileDialog { Filter = "pdf|*.pdf" }) {
                if (sfd.ShowDialog() == DialogResult.OK) {
                    if (lipatovTablePdf.CreateDocument(new TableParameters<Employee>() {
                        Path = sfd.FileName,
                        Title = textBoxTitleTable.Text,
                        CellsFirstColumn = firstColumn,
                        CellsSecondColumn = secondColumn,
                        DataList = employees
                    })) {
                        MessageBox.Show("Документ сохранён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        MessageBox.Show(lipatovTablePdf.ErrorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            textBoxTitleTable.Clear();
        }

        private void buttonGenerateChart_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBoxTitleChart.Text)) {
                MessageBox.Show("Введите заголовок", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(textBoxNameChart.Text)) {
                MessageBox.Show("Введите название диаграммы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var sfd = new SaveFileDialog { Filter = "pdf|*.pdf" }) {
                if (sfd.ShowDialog() == DialogResult.OK) {
                    if (lipatovChartPdf.CreateDocument(new ChartParameters() {
                        Path = sfd.FileName,
                        Title = textBoxTitleChart.Text,
                        ChartName = textBoxNameChart.Text,
                        ChartLegendLocation = ChartLegendLocation.Right,
                        Data = new List<ChartData>() {
                            new ChartData() { Series = 4.2, XSeries = "1 серия" },
                            new ChartData() { Series = 10.5, XSeries = "2 серия" },
                            new ChartData() { Series = 1.3, XSeries = "3 серия" }
                        }
                    })) {
                        MessageBox.Show("Документ сохранён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        MessageBox.Show(lipatovChartPdf.ErrorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            textBoxTitleChart.Clear();
            textBoxNameChart.Clear();
        }
    }
}
