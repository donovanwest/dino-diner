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
            NavigationService.GoBack();
        }
        private void DinoNuggets(object sender, RoutedEventArgs e)
        {
            App.currentEntree = Entrees.DinoNuggets;
            NavigationService.GoBack();
        }
        private void Steakosaurus(object sender, RoutedEventArgs e)
        {
            App.currentEntree = Entrees.Steakosaurus;
            NavigationService.GoBack();
        }
        private void TRexKingBurger(object sender, RoutedEventArgs e)
        {
            App.currentEntree = Entrees.TRexKingBurger;
            NavigationService.GoBack();
        }
        private void PterodactylWings(object sender, RoutedEventArgs e)
        {
            App.currentEntree = Entrees.PterodactylWings;
            NavigationService.GoBack();
        }
        private void PBJ(object sender, RoutedEventArgs e)
        {
            App.currentEntree = Entrees.PrehistoricPBJ;
            NavigationService.GoBack();
        }
        private void Velociwrap(object sender, RoutedEventArgs e)
        {
            App.currentEntree = Entrees.VelociWrap;
            NavigationService.GoBack();
        }
    }
}
