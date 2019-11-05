/* EntreeSelection.xaml.cs
 * Author: Donovan West
 */ 
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        public EntreeSelection()
        {
            App.PreviousPage = PreviousPages.EntreeSelection;
            InitializeComponent();
        }

        private void Brontowurst_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                Brontowurst br = new Brontowurst();              
                order.Add(br);
                NavigationService.Navigate(new Entree_Customization.BrontowurstCustomization(br));
            }

        }
        private void DinoNuggets_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DinoNuggets nuggies = new DinoNuggets();
                order.Add(nuggies);
                NavigationService.Navigate(new Entree_Customization.DinoNuggetsCustomization(nuggies));
            }
            
        }
        private void Steakosaurus_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger s = new SteakosaurusBurger();
                order.Add(s);
                NavigationService.Navigate(new Entree_Customization.SteakosaurusBurgerCustomization(s));
            }
            
        }
        private void TRexKingBurger_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger trex = new TRexKingBurger();
                order.Add(trex);
                NavigationService.Navigate(new Entree_Customization.TRexKingBurgerCustomization(trex));
            }
            
        }
        private void PterodactylWings_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                PterodactylWings wings = new PterodactylWings();
                order.Add(wings);
            }
            App.currentEntree = Entrees.PterodactylWings;        
            NavigationService.Navigate(new MenuCategorySelection());
        }
        private void PBJ_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new Entree_Customization.PrehistoricPBJCustomization(pbj));
            }
        }
        private void Velociwrap_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                VelociWrap wrap = new VelociWrap();
                order.Add(wrap);
                NavigationService.Navigate(new Entree_Customization.VelociwrapCustomization(wrap));
            }

        }
    }
}
