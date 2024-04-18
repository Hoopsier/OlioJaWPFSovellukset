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

namespace KT_18
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    // followed tutorial https://www.youtube.com/watch?v=YG9X--yaR_A because it seemed too difficult to learn these things one by one
    public partial class MainWindow : Window
    {
        int first;
        int second;

        char op;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void onClick(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            TxtResult.Text += btn.Content.ToString();
            second = Int32.Parse(TxtResult.Text);
        }

        private void pClick(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TxtResult.Text);
            op = '+';
            TxtResult.Clear();
        }

        private void mClick(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TxtResult.Text);
            op = '-';
            TxtResult.Clear();
        }

        private void dClick(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TxtResult.Text);
            op = '/';
            TxtResult.Clear();
        }

        private void muClick(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TxtResult.Text);
            op = '*';
            TxtResult.Clear();
        }

        private void eqClick(object sender, RoutedEventArgs e)
        {
            int result = 0;
            second = Int32.Parse(TxtResult.Text);

            if (op == '+')
            {
                result = first + second;
            }
            else if (op == '-')
            {
                result = first - second;
            }
            else if (op == '/')
            {
                result = first / second;
            }
            else if (op == '*')
            {
                result = first * second;
            }
            if (TxtResult.Text == "0")
            {
                TxtResult.Clear();
            }
            TxtResult.Text = result.ToString();
        }

        private void CEClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
