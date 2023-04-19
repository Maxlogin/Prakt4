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

namespace ZAD_3
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
            double x = double.Parse(txtNumber1.Text);
            int n = int.Parse(txtNumber2.Text);
            double a, h, s, c;
            switch (n)
            {
                case 1:
                    a = x;
                    c = a * Math.Sqrt(2);
                    h = c / 2;
                    s = c * h / 2;
                    lblResult.Content = $"Высота равна:{h:N2}\n" +
                                        $"Площадь равна:{s:N2}\n" +
                                        $"Длина катета равна:{a:N2}\n" +
                                        $"Гипатенуза равна:{c:N2}";
                break;
                case 2:
                    c = x;
                    a = c / Math.Sqrt(2);
                    h = c / 2;
                    s = c * h / 2;
                    lblResult.Content = $"Высота равна:{h:N2}\n" +
                                        $"Площадь равна:{s:N2}\n" +
                                        $"Гипатенуза равна:{c:N2}\n" +
                                        $"Длина катета равна:{a:N2}";
                    break;
                case 3:
                    h = x;
                    c = 2 * h;
                    a = c / Math.Sqrt(2);
                    s = c * h / 2;
                    lblResult.Content = $"Гипатенуза равна:{c:N2}\n" +
                                        $"Высота равна:{h:N2}\n" +
                                        $"Площадь равна:{s:N2}\n" +
                                        $"Длина катета равна:{a:N2}";
                    break;
                case 4:
                    s = x;
                    h = Math.Sqrt(s);
                    c = 2 * h;
                    a = c / Math.Sqrt(2);
                    lblResult.Content = $"Гипатенуза равна:{c:N2}\n" +
                                        $"Высота равна:{h:N2}\n" +
                                        $"Длина катета равна:{a:N2}\n"+
                                        $"Площадь равна:{s:N2}";
                    break;
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
