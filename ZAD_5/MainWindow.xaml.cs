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

namespace ZAD_5
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
            double p = double.Parse(txtNumber1.Text);
            double distance = 10;// 1 day
            double sum = distance;//obsjiy probeg
            int day = 1;//dni
            while (sum<200)
            {
                distance = distance * (1 + p / 100);
                sum += distance;
                day++;
            }
            lblResult.Content = $"После {day} дней общий пробег будет равен\n+"+
                                $" {sum:N3} км";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
