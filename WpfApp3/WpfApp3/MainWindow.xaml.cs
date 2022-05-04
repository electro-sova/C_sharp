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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void res_hint_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (res.Text.Length == 0)
            {
                res_hint.Visibility = Visibility.Visible;
            }
            else
            {
                res_hint.Visibility = Visibility.Hidden;
            }
        }
        private void tboxx_hint_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxx.Text.Length == 0)
            {
                tboxx_hint.Visibility = Visibility.Visible;
            }
            else
            {
                tboxx_hint.Visibility = Visibility.Hidden;
            }
        }
        private void tboxn_hint_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxn.Text.Length == 0)
            {
                tboxn_hint.Visibility = Visibility.Visible;
            }
            else
            {
                tboxn_hint.Visibility = Visibility.Hidden;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            uint n;
            double x;
            while (!uint.TryParse(tboxn.Text, out n))
            {
                MessageBox.Show("Введите число!");
                return;
            }
            while (!double.TryParse(tboxx.Text, out x))
            {
                MessageBox.Show("Введите число!");
                return;
            }

            double result = 0;
            for (int i = 1; i <= n; i++)
                result += Math.Pow(x, i) / Fact(i);

            res.Text = result.ToString();
        }

        private int Fact(int n)
        {
            int res = 1;
            for (int i = 2; i <= n; i++)
                res *= i;
            return res;
        }
    }
}