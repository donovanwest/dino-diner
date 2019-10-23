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
        private Side Side;
        public SideSelection(Side side)
        {
            InitializeComponent();
            Side = side;
        }

        private void MeteorMacAndCheese_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                MeteorMacAndCheese mac;
                if (Side is MeteorMacAndCheese && Side != null)
                    mac = (MeteorMacAndCheese)Side;
                else
                    mac = new MeteorMacAndCheese();
                
                if (Small.IsChecked == true)
                    mac.Size = Size.Small;
                else if (Medium.IsChecked == true)
                    mac.Size = Size.Medium;
                else
                    mac.Size = Size.Large;
                order.Items.Add(mac);
            }

            App.currentSide = Sides.MeteorMacAndCheese;
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }

        private void Fryceritops_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                Fryceritops fr = new Fryceritops();
                if (Small.IsChecked == true)
                    fr.Size = Size.Small;
                else if (Medium.IsChecked == true)
                    fr.Size = Size.Medium;
                else
                    fr.Size = Size.Large;
                order.Items.Add(fr);
            }
            App.currentSide = Sides.Fryceritops;
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }

        private void Triceritots_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                Triceritots tots = new Triceritots();
                if (Small.IsChecked == true)
                    tots.Size = Size.Small;
                else if (Medium.IsChecked == true)
                    tots.Size = Size.Medium;
                else
                    tots.Size = Size.Large;
                order.Items.Add(tots);
            }

            App.currentSide = Sides.Triceritots;
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }

        private void MezzorellaSticks_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                MezzorellaSticks ms = new MezzorellaSticks();
                if (Small.IsChecked == true)
                    ms.Size = Size.Small;
                else if (Medium.IsChecked == true)
                    ms.Size = Size.Medium;
                else
                    ms.Size = Size.Large;
                order.Items.Add(ms);
            }

            App.currentSide = Sides.MezzorellaSticks;
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
