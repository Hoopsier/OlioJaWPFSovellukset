/*
 * Renan Horuz
 */
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

namespace KT26_Finale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //variables
        double total = 0;
        List<IOstokset> groceryList;
        public MainWindow()
        {
            InitializeComponent();
            groceryList = new List<IOstokset>(); 

            LoadGroceryItems();
        }

        private void LoadGroceryItems()
        {
            groceryList = new List<IOstokset> 
            {
                new Ostokset("Apples", 1.20, 0),
                new Ostokset("Bananas", 0.50, 0),
                new Ostokset("Carrots", 0.30, 0)
            };
            lDG.ItemsSource = groceryList;
            UpdateList();
        }
            

        private double CalculateTotalCost()
        {
            total = 0;
            foreach (var item in groceryList) //remember for later
            {
                total += item.Price * item.Quantity;
            }
            return total;
        }
        private void UpdateList()
        {
            lDG.Items.Refresh(); // This line remains the same
            TotalTxt.Text = "Total: " + CalculateTotalCost().ToString("C2"); 
        }

        /*private void AddGroceryItem(IOstokset item) 
        {
            groceryList.Add(item);
            lDG.Items.Refresh(); // not used for this one
        }*/
        private void AddItemButton_Click(object sender, RoutedEventArgs e)
        {
            //check every text box for quantity to add
            if (int.TryParse(BanQuan.Text, out int quantity)) //I like this more than try catch
            {
                var name = "Bananas";
                UpdateGroceryItemQuantity(name, quantity);
                BanQuan.Text = "0";
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid price and quantity.");
            }
            if (int.TryParse(ApQuan.Text, out int quantity2))
            {
                var name = "Apples";
                UpdateGroceryItemQuantity(name, quantity2);
                ApQuan.Text = "0";
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid price and quantity.");
            }
            if (int.TryParse(CarQuan.Text, out int quantity3))
            {
                var name = "Carrots";
                UpdateGroceryItemQuantity(name, quantity3);
                CarQuan.Text = "0";
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid price and quantity.");
            }
            UpdateList();
        }
        private void UpdateGroceryItemQuantity(string name, int additionalQuantity) // so the list shows what you have even after adding some
        {
            var item = groceryList.Find(g => g.Name == name);
            if (item != null)
            {
                item.Quantity += additionalQuantity;
                if (item.Quantity < 0)
                {
                    item.Quantity = 0;
                }
                UpdateList(); // Update the total cost
            }
            else
            {
                MessageBox.Show($"Item {name} not found in the list.");
            }
        }
        // make numbers only textboxes
        private void BanQuan_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void ApQuan_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void CarQuan_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        // + & - buttons to change the textboxes' quantities
        private void ApMin_Click(object sender, RoutedEventArgs e)
        {
            var i = 0;
            if (int.TryParse(ApQuan.Text, out i))
            {
                i--;
                ApQuan.Text = i.ToString();
            }
        }

        private void CarMin_Click(object sender, RoutedEventArgs e)
        {
            var i = 0;
            if (int.TryParse(CarQuan.Text, out i))
            {
                i--;
                CarQuan.Text = i.ToString();
            }
        }

        private void BanMin_Click(object sender, RoutedEventArgs e)
        {
            var i = 0;
            if (int.TryParse(BanQuan.Text, out i))
            {
                i--;
                BanQuan.Text = i.ToString();
            }
        }

        private void BanPlus_Click(object sender, RoutedEventArgs e)
        {
            var i = 0;
            if (int.TryParse(BanQuan.Text, out i))
            {
                i++;
                BanQuan.Text = i.ToString();
            }
        }

        private void ApPlus_Click(object sender, RoutedEventArgs e)
        {
            var i = 0;
            if (int.TryParse(ApQuan.Text, out i))
            {
                i++;
                ApQuan.Text = i.ToString();
            }
        }

        private void CarPlus_Click(object sender, RoutedEventArgs e)
        {
            var i = 0;
            if (int.TryParse(CarQuan.Text, out i))
            {
                i++;
                CarQuan.Text = i.ToString();
            }
        }


    }
}
