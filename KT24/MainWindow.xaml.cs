/*
 * Renan Horuz      Note: tää ei oo varmaan täysin mitä haluttiin, mutta en haluu ees tietää miten lotto toimii vielä.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace KT24
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int lMode;
        int count;
        int iCheck;
        Random rnd = new Random();
        /*int[] pool = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 
            25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49 };*/
        public MainWindow()
        {
            InitializeComponent();
            
        }



        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) //amount of rows
        {
            if (int.TryParse(Amount.Text, out count))
            {
                if (count > 6)
                {
                    count = 6;
                }
                else if (count < 1)
                {
                    count = 1;
                }
            }
                
        }

            
    

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e) //only numbers (and spaces I guess)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (lMode)
            {
                case 0: //lotto
                    for (int i = 0; i < count; i++)
                    {
                        for (int x = 0; x < 7; x++)
                        {

                            var k = 0;
                            var j = rnd.Next(1, 40);
                            while (k == j)
                            {
                                j = rnd.Next(1, 40);
                            }
                            k = j;
                            rNum.Text += j + ", ";
                        }
                        rNum.Text += "\n\n";
                    }


                    break;
                case 1: //Viking
                    for (int i = 0; i < count; i++)
                    {
                        for (int x = 0; x < 6; x++)
                        {
                            
                            var k = 0;
                            var j = rnd.Next(1, 48);
                            while (k == j)
                            {
                                j = rnd.Next(1, 48);
                            }
                            k = j;
                            rNum.Text += j + ", ";
                        }
                        rNum.Text += "\n\n";
                    }

                break;
                case 2: //EJP
                    for (int i = 0; i < count; i++)
                    {
                        for (int x = 0; x < 5; x++)
                        {

                            var k = 0;
                            var j = rnd.Next(1, 50);
                            while (k == j)
                            {
                                j = rnd.Next(1, 50);
                            }
                            k = j;
                            rNum.Text += j + " ";
                        }
                        rNum.Text += "\n";
                        for (int x = 1; x <= 2; x++)
                        {
                            var k = 0;
                            var j = rnd.Next(1, 50);
                            while (k == j)
                            {
                                j = rnd.Next(1, 50);
                            }
                            k = j;
                            rNum.Text += "Tähtinumero "+x+" on "+j + "\n";
                        }
                        rNum.Text += "\n";
                    }

                    break;
            }
        }

        private void choice(object sender, SelectionChangedEventArgs e) //Chooses type of lottery
        {
            lMode = Choice.SelectedIndex;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //Clear results
        {
            rNum.Text = "";
        }
    }
}
