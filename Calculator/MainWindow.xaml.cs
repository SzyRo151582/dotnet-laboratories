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

namespace Calculator
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

        private void Number1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Number2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var value1 = Number1.Text;
            var number1 = Int32.Parse(value1);
            var value2 = Number2.Text;
            var number2 = Int32.Parse(value2);
            var result = number1 + number2;
            Result.Content = result;
        }

        private void Substract_Click(object sender, RoutedEventArgs e)
        {
            var value1 = Number1.Text;
            var number1 = Int32.Parse(value1);
            var value2 = Number2.Text;
            var number2 = Int32.Parse(value2);
            var result = number1 - number2;
            Result.Content = result;
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            var value1 = Number1.Text;
            var number1 = Int32.Parse(value1);
            var value2 = Number2.Text;
            var number2 = Int32.Parse(value2);
            var result = number1 * number2;
            Result.Content = result;
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            var value1 = Number1.Text;
            var number1 = Int32.Parse(value1);
            var value2 = Number2.Text;
            var number2 = Int32.Parse(value2);
            var result = number1 / number2;
            Result.Content = result;
        }
    }
}
