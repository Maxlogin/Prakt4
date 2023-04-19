using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZAD_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(txtNumber1.Text);
            bool hasDigitTwo = false; // флаг наличия цифры 2

            while (n > 0)
            {
                if (n % 10 == 2) // остаток от деления нацело на 10 равен 2
                {
                    hasDigitTwo = true; // устанавливаем флаг
                    break; // прерываем цикл
                }

                n /= 10; // удаляем последнюю цифру
            }
            lblResult.Content = $"{hasDigitTwo}";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
