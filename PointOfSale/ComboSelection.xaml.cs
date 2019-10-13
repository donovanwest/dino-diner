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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }

        private void BrontosaurusCombo(object sender, RoutedEventArgs e)
        {
            App.currentEntree = Entrees.Brontowurst;
            App.currentSide = Sides.Fryceritops;
            App.currentDrink = Drinks.Sodasaurus;
            NavigationService.Navigate(new ComboCustomization());
        }
        private void DinoNuggetsCombo(object sender, RoutedEventArgs e)
        {
            App.currentEntree = Entrees.DinoNuggets;
            App.currentSide = Sides.Fryceritops;
            App.currentDrink = Drinks.Sodasaurus;
            NavigationService.Navigate(new ComboCustomization());
        }
        private void SteakosaurusCombo(object sender, RoutedEventArgs e)
        {
            App.currentEntree = Entrees.Steakosaurus;
            App.currentSide = Sides.Fryceritops;
            App.currentDrink = Drinks.Sodasaurus;
            NavigationService.Navigate(new ComboCustomization());
        }
        private void TRexKingBurgerCombo(object sender, RoutedEventArgs e)
        {
            App.currentEntree = Entrees.TRexKingBurger;
            App.currentSide = Sides.Fryceritops;
            App.currentDrink = Drinks.Sodasaurus;
            NavigationService.Navigate(new ComboCustomization());
        }
        private void PterodactylWingsCombo(object sender, RoutedEventArgs e)
        {
            App.currentEntree = Entrees.PterodactylWings;
            App.currentSide = Sides.Fryceritops;
            App.currentDrink = Drinks.Sodasaurus;
            NavigationService.Navigate(new ComboCustomization());
        }
        private void PBJCombo(object sender, RoutedEventArgs e)
        {
            App.currentEntree = Entrees.PrehistoricPBJ;
            App.currentSide = Sides.Fryceritops;
            App.currentDrink = Drinks.Sodasaurus;
            NavigationService.Navigate(new ComboCustomization());
        }
        private void VelociwrapCombo(object sender, RoutedEventArgs e)
        {
            App.currentEntree = Entrees.VelociWrap;
            App.currentSide = Sides.Fryceritops;
            App.currentDrink = Drinks.Sodasaurus;
            NavigationService.Navigate(new ComboCustomization());
        }
    }
}
