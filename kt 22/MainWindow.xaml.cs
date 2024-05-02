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

namespace kt_22
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
        }

        

        private void HeightUpdate(object sender, TextChangedEventArgs e)
        {
            //muuta ikkunan korkeutta
            Ikkuna.Height = double.Parse(Korkeus.Text);
        }

        private void WidthUpdate(object sender, TextChangedEventArgs e)
        {
            //muuta ikkunan leveyttä
            Ikkuna.Width = double.Parse(Leveys.Text);
        }

        private void UpdateTotal(object sender, RoutedEventArgs e)
        {
            //Laske pinta-ala
            if (int.TryParse(Korkeus.Text, out var i) && int.TryParse(Leveys.Text, out var j))
            {
                i = Int32.Parse(Korkeus.Text);
                j = Int32.Parse(Leveys.Text);
                var k = i * j;
                Total.Text = k.ToString()+" px^2";
            }
        }
    }
}