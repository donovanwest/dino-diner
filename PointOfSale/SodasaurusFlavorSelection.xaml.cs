/* SodasaurusFlavorSelection.xaml.cs
 * Author: Donovan West
 */ 
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SodasaurusFalavorSelection.xaml
    /// </summary>
    public partial class SodasaurusFlavorSelection : Page
    {
        private Sodasaurus soda;
        public SodasaurusFlavorSelection(Sodasaurus Soda)
        {
            InitializeComponent();
            soda = Soda;
        }

        private void Cola_Click(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Cola;
            NavigationService.Navigate(new DrinkSelection(SodasaurusFlavor.Cola));
        }
        private void RootBeer_Click(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.RootBeer;
            NavigationService.Navigate(new DrinkSelection(SodasaurusFlavor.RootBeer));
        }
        private void Cherry_Click(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Cherry;
            NavigationService.Navigate(new DrinkSelection(SodasaurusFlavor.Cherry));
        }
        private void Vanilla_Click(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Vanilla;
            NavigationService.Navigate(new DrinkSelection(SodasaurusFlavor.Vanilla));
        }
        private void Chocolate_Click(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Chocolate;
            NavigationService.Navigate(new DrinkSelection(SodasaurusFlavor.Chocolate));
        }
        private void Orange_Click(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Orange;
            NavigationService.Navigate(new DrinkSelection(SodasaurusFlavor.Orange));
        }
        private void Lime_Click(object sender, RoutedEventArgs e)
        {
            soda.Flavor = SodasaurusFlavor.Lime; 
            NavigationService.Navigate(new DrinkSelection(SodasaurusFlavor.Lime));
        }
    }
}
