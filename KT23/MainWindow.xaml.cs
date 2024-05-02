using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace KT23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int check;
        int status;

        public MainWindow()
        {
            InitializeComponent();
        }
        //numpad buttons
        private void onClick(object sender, RoutedEventArgs e)
        {
            if (TxtResult.Text.Length < 3)
            {
                Button btn = (Button)sender;
                TxtResult.Text += btn.Content.ToString(); //add the button number to the textbox above
                
            }
        }

        private void eqClick(object sender, RoutedEventArgs e)
        {
            // mark down what exactly is in the text box
            check = Int32.Parse(TxtResult.Text);
            switch (status)
            {
                case 0: //Lämpötila
                    if (check >= 120)
                    {
                        TxtResult.Text = "120";
                    }
                    lamp.Text= "Lämpötila: " + TxtResult.Text;

                break;

                case 1: //Kosteus
                    if (check >= 100)
                    {
                        TxtResult.Text = "100";
                    }
                    kost.Text = "Kosteus: " + TxtResult.Text;
                break;
            }
            TxtResult.Text = null; //tyhjennä ruutu
        }
        
        private void CEClick(object sender, RoutedEventArgs e)
        {
            TxtResult.Text = null; //tyhjennä ruutu
        }

        private void Lampotila(object sender, RoutedEventArgs e)
        {
            status = 0;
        }
        // vaihda lämpötilan ja kosteuden muokkauksien välillä v^
        private void KosteusMode(object sender, RoutedEventArgs e)
        {
            status = 1;
        }

        private void numFieldValid(object sender, TextCompositionEventArgs e)
        {
            // sallitaan vain numerot 0-9
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
