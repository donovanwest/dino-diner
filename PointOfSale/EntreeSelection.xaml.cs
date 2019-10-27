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
            InitializeComponent();
        }

        private void Brontowurst_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                Brontowurst br = new Brontowurst();              
                order.Add(br);
            }

            App.currentEntree = Entrees.Brontowurst;
            if(App.PreviousPage == PreviousPages.ComboCustomization)          
                NavigationService.Navigate(new ComboCustomization());          
            else           
                NavigationService.Navigate(new MenuCategorySelection());
        }
        private void DinoNuggets_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DinoNuggets nuggies = new DinoNuggets();
                order.Add(nuggies);
            }

            App.currentEntree = Entrees.DinoNuggets;
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
        private void Steakosaurus_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger s = new SteakosaurusBurger();
                order.Add(s);
            }
            App.currentEntree = Entrees.Steakosaurus;
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
        private void TRexKingBurger_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger trex = new TRexKingBurger();
                order.Add(trex);
            }
            App.currentEntree = Entrees.TRexKingBurger;
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
        private void PterodactylWings_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                PterodactylWings wings = new PterodactylWings();
                order.Add(wings);
            }
            App.currentEntree = Entrees.PterodactylWings;
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
        private void PBJ_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
            }
            App.currentEntree = Entrees.PrehistoricPBJ;
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
        private void Velociwrap_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                VelociWrap wrap = new VelociWrap();
                order.Add(wrap);
            }
            App.currentEntree = Entrees.VelociWrap;
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
