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

namespace WPFCursus
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

        private void ButtonKleur_Click(object sender, RoutedEventArgs e)
        {
            Button knop = (Button)sender;
            string kleur = knop.Tag.ToString();
            BrushConverter brushConverter = new BrushConverter();
            SolidColorBrush kleurBrush =
    (SolidColorBrush)brushConverter.ConvertFromString(kleur);
            this.Background = kleurBrush;
        }
        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            ButtonOK.Content = "OK geklikt";
            ButtonCancel.Content = "Cancel";
        }
        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            ButtonOK.Content = "OK";
            ButtonCancel.Content = "Cancel geklikt";
        }


    }
}
