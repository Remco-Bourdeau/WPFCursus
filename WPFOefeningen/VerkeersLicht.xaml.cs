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
using System.Windows.Shapes;

namespace WPFOefeningen
{
    /// <summary>
    /// Interaction logic for VerkeersLicht.xaml
    /// </summary>
    public partial class VerkeersLicht : Window
    {
        public VerkeersLicht()
        {
            InitializeComponent();
        }
        private void ButtonGo_Click(object sender, RoutedEventArgs e)
        {
            OranjeLicht.Opacity = 0;
            GroenLicht.Opacity = 1;
            ButtonOpgelet.IsEnabled = true;
            ButtonGo.IsEnabled = false;
        }
        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            OranjeLicht.Opacity = 0;
            RoodLicht.Opacity = 1;
            ButtonOpgelet.IsEnabled = true;
            ButtonStop.IsEnabled = false;
        }
        private void ButtonOpgelet_Click(object sender, RoutedEventArgs e)
        {
            if (GroenLicht.Opacity == 1)
            {
                ButtonStop.IsEnabled = true;
                GroenLicht.Opacity = 0;
            }
            else
            {
                ButtonGo.IsEnabled = true;
                RoodLicht.Opacity = 0;
            }
            OranjeLicht.Opacity = 1;
            ButtonOpgelet.IsEnabled = false;
        }
    }
}