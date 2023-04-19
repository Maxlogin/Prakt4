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

namespace Prakt_4
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
            int month = int.Parse(txtNumber1.Text);
            int dni;
            switch(month)
            {
                case 2://fevral
                    dni = 28;
                    break;
                case 4: //aprel
                case 6://june
                case 9://september
                case 11://November
                    dni = 30;
                    break;
                default://ost month
                    dni = 31;
                    break;
            }
            
            lblResult.Content = $"В месяце {month}, дней={dni}";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
