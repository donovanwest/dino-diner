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
        }
        private void SelectJurrasicJava(object sender, RoutedEventArgs e)
        {
            App.currentDrink = Drinks.JurrasicJava;
        }
        private void SelectSodasaurus(object sender, RoutedEventArgs e)
        {
            App.currentDrink = Drinks.Sodasaurus;
        }
        private void SelectTyrannotea(object sender, RoutedEventArgs e)
        {
            App.currentDrink = Drinks.Tyrannotea;
        }
    }
}
