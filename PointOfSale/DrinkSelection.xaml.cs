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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
        }

        private void SelectWater(object sender, RoutedEventArgs e)
        {
            App.currentDrink = Drinks.Water;
            JurrasicJava.IsChecked = false;
            Sodasaurus.IsChecked = false;
            Tyrannotea.IsChecked = false;
            if (Water.IsChecked == true)
            {
                Uncheck();
                Lemon.IsEnabled = true;
                Ice.IsEnabled = true;
                Ice.IsChecked = true;
                Confirm.IsEnabled = true;
            }
            else
            {
                Uncheck();
            }
        }
        private void SelectJurrasicJava(object sender, RoutedEventArgs e)
        {
            App.currentDrink = Drinks.JurrasicJava;
            Sodasaurus.IsChecked = false;
            Tyrannotea.IsChecked = false;
            Water.IsChecked = false;
            if(JurrasicJava.IsChecked == true)
            {
                Uncheck();
                Ice.IsChecked = false;
                Ice.IsEnabled = true;
                Decaf.IsEnabled = true;
                Confirm.IsEnabled = true;
            }
            else
            {
                Uncheck();
            }
        }
        private void SelectSodasaurus(object sender, RoutedEventArgs e)
        {
            App.currentDrink = Drinks.Sodasaurus;
            JurrasicJava.IsChecked = false;
            Tyrannotea.IsChecked = false;
            Water.IsChecked = false;
            if(Sodasaurus.IsChecked == true)
            {
                Uncheck();
                Ice.IsEnabled = true;
                Ice.IsChecked = true;
                SodaFlavor.IsEnabled = true;
                Confirm.IsEnabled = true;
            }
            else
            {
                Uncheck();
            }
        }
        private void SelectTyrannotea(object sender, RoutedEventArgs e)
        {
            App.currentDrink = Drinks.Tyrannotea;
            JurrasicJava.IsChecked = false;
            Sodasaurus.IsChecked = false;
            Water.IsChecked = false;
            if (Tyrannotea.IsChecked == true)
            {
                Uncheck();
                Lemon.IsEnabled = true;
                Ice.IsEnabled = true;
                Ice.IsChecked = true;
                Sweet.IsEnabled = true;
                Confirm.IsEnabled = true;
            }
            else
            {
                Uncheck();               
            }
        }

        private void Lemon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Ice_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Decaf_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Flavor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SodasaurusFalavorSelection());
        }

        private void Sweet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Unchecks and disables all the drink specific modifications to prepare for a new drink to be pressed
        /// </summary>
        private void Uncheck()
        {
            Lemon.IsChecked = false;
            Ice.IsChecked = false;
            Decaf.IsChecked = false;
            Sweet.IsChecked = false;

            Lemon.IsEnabled = false;
            Ice.IsEnabled = false;
            Decaf.IsEnabled = false;
            SodaFlavor.IsEnabled = false;
            Sweet.IsEnabled = false;
            Confirm.IsEnabled = false;
        }
    }
}
