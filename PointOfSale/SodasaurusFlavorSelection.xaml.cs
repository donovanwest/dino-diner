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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SodasaurusFalavorSelection.xaml
    /// </summary>
    public partial class SodasaurusFalavorSelection : Page
    {
        public SodasaurusFalavorSelection()
        {
            InitializeComponent();
        }

        private void Cola_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        private void RootBeer_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        private void Cherry_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        private void Vanilla_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        private void Chocolate_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        private void Orange_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        private void Lime_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
