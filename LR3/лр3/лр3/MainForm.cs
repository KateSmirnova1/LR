using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр3
{
    public partial class MainForm : Form
    {
        // Словарь для хранения групп блюд и списка блюд в каждой группе
        private Dictionary<string, List<string>> menuGroups;

        // Словарь для хранения выбранных блюд и их количества
        private Dictionary<string, Dictionary<string, int>> selectedDishes;

        public MainForm()
        {
            InitializeComponent();

            // Инициализация данных
            InitializeMenu();
            InitializeForm();
        }
        private void InitializeMenu()
        {
            menuGroups = new Dictionary<string, List<string>>
            {
                { "Завтраки", new List<string> { "Омлет", "Блинчики", "Каша" } },
                { "Обеды", new List<string> { "Суп", "Плов", "Салат" } },
                { "Ужины", new List<string> { "Стейк", "Рыба", "Паста" } }
            };

            // Инициализация словаря для хранения выбранных блюд
            selectedDishes = new Dictionary<string, Dictionary<string, int>>();
            foreach (var group in menuGroups.Keys)
            {
                selectedDishes[group] = new Dictionary<string, int>();
            }
        }

        private void InitializeForm()
        {
            // Заполнение ComboBox группами блюд
            foreach (var group in menuGroups.Keys)
            {
                comboBox1.Items.Add(group);
            }

            // Установка обработчика события выбора группы
            comboBox1.SelectedIndexChanged += ComboBoxMenuGroups_SelectedIndexChanged;

            // Установка обработчика события нажатия на кнопку "Заказать"
            button1.Click += Button1_Click;
        }

        private void ComboBoxMenuGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Очистка предыдущих элементов
            flowLayoutPanel1.Controls.Clear();

            // Получение выбранной группы
            string selectedGroup = comboBox1.SelectedItem.ToString();

            // Добавление CheckBox и NumericUpDown для каждого блюда в выбранной группе
            foreach (var dish in menuGroups[selectedGroup])
            {
                CheckBox checkBox = new CheckBox { Text = dish };
                NumericUpDown numericUpDown = new NumericUpDown { Minimum = 0, Maximum = 10, Width = 50 };

                // Установка значения NumericUpDown, если блюдо уже было выбрано ранее,то извлекается кол-во и отмечается галочкой 
                if (selectedDishes[selectedGroup].ContainsKey(dish))
                {
                    numericUpDown.Value = selectedDishes[selectedGroup][dish];
                    checkBox.Checked = true;
                }

                // Обработчик изменения состояния CheckBox
                checkBox.CheckedChanged += (s, ev) =>
                {
                    if (checkBox.Checked)
                    {
                        selectedDishes[selectedGroup][dish] = (int)numericUpDown.Value;
                    }
                    else
                    {
                        selectedDishes[selectedGroup].Remove(dish);
                    }
                };

                // Обработчик изменения значения NumericUpDown
                numericUpDown.ValueChanged += (s, ev) =>
                {
                    if (checkBox.Checked)
                    {
                        selectedDishes[selectedGroup][dish] = (int)numericUpDown.Value;
                    }
                };

                flowLayoutPanel1.Controls.Add(checkBox);
                flowLayoutPanel1.Controls.Add(numericUpDown);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Формирование заказа
            string order= "Ваш заказ:\n";

            foreach (var group in menuGroups.Keys)
            {
                order += $"{group}:\n";

                // Если в группе есть выбранные блюда
                if (selectedDishes[group].Count > 0)
                {
                    foreach (var dish in selectedDishes[group])
                    {
                        order += $"- {dish.Key} x {dish.Value}\n";
                    }
                }
                else
                {
                    // Если блюда не выбраны, добавляем прочерк
                    order += "- \n";
                }
            }

            // Вывод заказа на форму
            label1.Text = order;
        }
    }
}
