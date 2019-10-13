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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        public EntreeSelection()
        {
            InitializeComponent();
        }

        private void Brontosaurus(object sender, RoutedEventArgs e)
        {
            App.currentEntree = Entrees.Brontowurst;
            if(App.PreviousPage == PreviousPages.ComboCustomization)          
                NavigationService.Navigate(new ComboCustomization());          
            else           
                NavigationService.Navigate(new MenuCategorySelection());
        }
        private void DinoNuggets(object sender, RoutedEventArgs e)
        {
            App.currentEntree = Entrees.DinoNuggets;
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
        private void Steakosaurus(object sender, RoutedEventArgs e)
        {
            App.currentEntree = Entrees.Steakosaurus;
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
        private void TRexKingBurger(object sender, RoutedEventArgs e)
        {
            App.currentEntree = Entrees.TRexKingBurger;
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
        private void PterodactylWings(object sender, RoutedEventArgs e)
        {
            App.currentEntree = Entrees.PterodactylWings;
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
        private void PBJ(object sender, RoutedEventArgs e)
        {
            App.currentEntree = Entrees.PrehistoricPBJ;
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
        private void Velociwrap(object sender, RoutedEventArgs e)
        {
            App.currentEntree = Entrees.VelociWrap;
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
