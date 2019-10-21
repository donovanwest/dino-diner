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
using DinoDiner.Menu;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        public SideSelection()
        {
            InitializeComponent();
        }

        private void MeteorMacAndCheese_Click(object sender, RoutedEventArgs e)
        {
            App.currentSide = Sides.MeteorMacAndCheese;
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }

        private void Fryceritops_Click(object sender, RoutedEventArgs e)
        {
            Order order = (Order)DataContext;
            Fryceritops fr = new Fryceritops();
            if (Small.IsChecked == true)
                fr.Size = Size.Small;
            else if (Medium.IsChecked == true)
                fr.Size = Size.Medium;
            else
                fr.Size = Size.Large;
            order.Items.Add(fr);
            App.currentSide = Sides.Fryceritops;
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }

        private void Triceritots_Click(object sender, RoutedEventArgs e)
        {
            App.currentSide = Sides.Triceritots;
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }

        private void MezzorellaSticks_Click(object sender, RoutedEventArgs e)
        {
            App.currentSide = Sides.MezzorellaSticks;
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
