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

namespace Talo_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        float lämpötila = 20;
        bool keittiöValot;
        bool olohuoneenValot;
        bool oviLukossa;
        bool oviAuki;
        int x = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LSwitch_Click(object sender, RoutedEventArgs e)
        {
            if (olohuoneenValot)
            {
                oValo.Fill = Brushes.Black;
                olohuoneenValot = false;
            }
            else
            {
                oValo.Fill = Brushes.LightGoldenrodYellow;
                olohuoneenValot = true;
            }
        }

        private void LSwitchKeit_Click(object sender, RoutedEventArgs e)
        {
            if (keittiöValot)
            {
                kValo.Fill = Brushes.Black;
                keittiöValot = false;
            }
            else
            {
                kValo.Fill = Brushes.LightGoldenrodYellow;
                keittiöValot = true;
            }
        }
        private void mTempTask(object sender, RoutedEventArgs e)
        {
            lämpötila -= x;
            ocTemp.Text = lämpötila.ToString();
        }

        private void pTempTask(object sender, RoutedEventArgs e)
        {
            lämpötila += x;
            ocTemp.Text = lämpötila.ToString();
        }

        private void DoorFunct2(object sender, RoutedEventArgs e)
        {
            if (oviLukossa)
            {
                oviLukossa = false;
            }
            else { oviLukossa = true;}
        }

        private void DoorFunct(object sender, RoutedEventArgs e)
        {
            if (oviLukossa&&oviAuki)
            {
                Dor.Width = 90;
                oviAuki = false;
            }
            else if (oviLukossa&&!oviAuki)
            {
                Dor.Width = 45;
                oviAuki = true;
            }
            
        }


    }
}
