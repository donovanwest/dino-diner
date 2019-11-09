/* ComboSelection.xaml.cs
 * Author: Donovan West
 */ 
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using DinoDiner.Menu;

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
            CretaceousCombo combo = new CretaceousCombo(new Brontowurst());
            if (DataContext is Order order)
            {
                order.Add(combo);
            }
            NavigationService.Navigate(new ComboCustomization(combo));
        }
        private void DinoNuggetsCombo(object sender, RoutedEventArgs e)
        {            
            CretaceousCombo combo = new CretaceousCombo(new DinoNuggets());
            if (DataContext is Order order)
            {
                order.Add(combo);
            }
            NavigationService.Navigate(new ComboCustomization(combo));
        }
        private void SteakosaurusCombo(object sender, RoutedEventArgs e)
        {
            CretaceousCombo combo = new CretaceousCombo(new SteakosaurusBurger());
            if (DataContext is Order order)
            {
                order.Add(combo);
            }
            NavigationService.Navigate(new ComboCustomization(combo));
        }
        private void TRexKingBurgerCombo(object sender, RoutedEventArgs e)
        {
            CretaceousCombo combo = new CretaceousCombo(new TRexKingBurger());
            if(DataContext is Order order)
            {
                order.Add(combo);
            }
            NavigationService.Navigate(new ComboCustomization(combo));
        }
        private void PterodactylWingsCombo(object sender, RoutedEventArgs e)
        {
            CretaceousCombo combo = new CretaceousCombo(new PterodactylWings());
            if (DataContext is Order order)
            {
                order.Add(combo);
            }
            NavigationService.Navigate(new ComboCustomization(combo));
        }
        private void PBJCombo(object sender, RoutedEventArgs e)
        {
            CretaceousCombo combo = new CretaceousCombo(new PrehistoricPBJ());
            if (DataContext is Order order)
            {                
                order.Add(combo);
            }
            NavigationService.Navigate(new ComboCustomization(combo));
        }
        private void VelociwrapCombo(object sender, RoutedEventArgs e)
        {
            CretaceousCombo combo = new CretaceousCombo(new VelociWrap());
            if (DataContext is Order order)
            {            
                order.Add(combo);
            }
            NavigationService.Navigate(new ComboCustomization(combo));
        }
    }
}
