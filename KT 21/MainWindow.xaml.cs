using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace KT_21 //Heavily assisted by AI, hence the mainwindow is empty. This sucks for learn it yourself
{
    public partial class MainWindow : Window
    {
        private StackPanel stackPanel;
        private TextBox txtItem;
        private Button btnAdd;
        private Button btnClear;
        private List<string> itemsList;

        public MainWindow()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Vertical;

            txtItem = new TextBox();
            txtItem.Width = 200;
            txtItem.Margin = new Thickness(5);

            btnAdd = new Button();
            btnAdd.Content = "Add";
            btnAdd.Click += AddItem_Click;
            btnAdd.Margin = new Thickness(5);

            btnClear = new Button();
            btnClear.Content = "Clear";
            btnClear.Click += ClearItems_Click;
            btnClear.Margin = new Thickness(5);

            itemsList = new List<string>();

            stackPanel.Children.Add(txtItem);
            stackPanel.Children.Add(btnAdd);
            stackPanel.Children.Add(btnClear);

            // Apply RadialGradientBrush to the background of MainWindow
            RadialGradientBrush gradientBrush = new RadialGradientBrush();
            gradientBrush.GradientStops.Add(new GradientStop(Color.FromArgb(0xFF, 0xC5, 0xC5, 0xC5), 0.12));
            gradientBrush.GradientStops.Add(new GradientStop(Color.FromArgb(0xFF, 0x00, 0xFF, 0x62), 1));
            gradientBrush.GradientStops.Add(new GradientStop(Color.FromArgb(0xFF, 0x4E, 0xA0, 0x6F), 0.407));
            gradientBrush.GradientStops.Add(new GradientStop(Color.FromArgb(0xFF, 0x6F, 0xF9, 0x00), 0.934));
            gradientBrush.GradientStops.Add(new GradientStop(Colors.Black, 0.04));

            this.Background = gradientBrush;

            this.Content = stackPanel;
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            string newItemName = txtItem.Text;
            if (!string.IsNullOrEmpty(newItemName))
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Content = newItemName;
                stackPanel.Children.Insert(stackPanel.Children.Count - 1, checkBox); // Insert checkbox before the Clear button
                itemsList.Add(newItemName);
                txtItem.Text = ""; // Clear the textbox after adding
            }
        }

        private void ClearItems_Click(object sender, RoutedEventArgs e)
        {
            stackPanel.Children.RemoveRange(0, stackPanel.Children.Count - 1); // Remove all children except the last one (Clear button)
            itemsList.Clear();
            txtItem.Text = ""; // Clear the textbox
        }
    }
}
