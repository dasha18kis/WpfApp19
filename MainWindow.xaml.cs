using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace WpfApp19
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(NewItemTextBox.Text))
            {
                List.Items.Add(NewItemTextBox.Text);
                NewItemTextBox.Clear();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (List.SelectedItem != null)
            {
                List.Items.Remove(List.SelectedItem);
            }
            else
            {
                MessageBox.Show("Выберите элемент для удаления.");
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            List.Items.Clear();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(RandomValueCountTextBox.Text, out int numValues))
            {
                Random random = new Random();
                for (int i = 0; i < numValues; i++)
                {
                    List.Items.Add(random.Next(100).ToString());
                }
            }
            else
            {
                MessageBox.Show("Введите целое число для количества значений.");
            }
            RandomValueCountTextBox.Clear();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            // Example calculation: Sum of the parsed integer values in the ListBox
            double sum = 0;
            foreach (var item in List.Items)
            {
                if (double.TryParse(item.ToString(), out double value))
                {
                    sum += value;
                }
            }
            OutputTextBox.Text = sum.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №19\nВыполнил: [Еремина Дарья Владимировна]\nГруппа: [ИСП-22]");
        }
    }
}
