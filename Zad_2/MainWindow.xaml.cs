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

namespace Zad_2
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
            int age = int.Parse(txtNumber1.Text);
            string OpisVozrast;
            int lastDigit = age % 10;
            switch (lastDigit)
            {
                case 1:
                    OpisVozrast = age + " год";
                    break;
                case 2:
                case 3:
                case 4:
                    OpisVozrast = age + " года";
                    break;
                default:
                    OpisVozrast = age + " Лет";
                    break;
            }

            lblResult.Content = $"{OpisVozrast}";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
