/* SideSelection.xaml.cs
 * Author: Donovan West
 */ 
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
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
        /// <summary>
        /// Constructor used when modifying a side.
        /// </summary>
        /// <param name="side">the side to be modified</param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            Side = side;
            if (side.Size == Size.Small)
                Small.IsChecked = true;
            else if (side.Size == Size.Medium)
                Medium.IsChecked = true;
            else
                Large.IsChecked = true;
        }

        private void MeteorMacAndCheese_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                MeteorMacAndCheese mac = new MeteorMacAndCheese();             
                if (Small.IsChecked == true)
                    mac.Size = Size.Small;
                else if (Medium.IsChecked == true)
                    mac.Size = Size.Medium;
                else
                    mac.Size = Size.Large;
                
                order.Add(mac);
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
                order.Add(fr);
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
                order.Add(tots);
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
                order.Add(ms);
            }

            App.currentSide = Sides.MezzorellaSticks;
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }

        private void Small_Click(object sender, RoutedEventArgs e)
        {
            if(Side != null)
            {
                Side.Size = Size.Small;
                
            }

        }

        private void Medium_Click(object sender, RoutedEventArgs e)
        {
            if (Side != null)
            {
                Side.Size = Size.Medium;
            }
        }

        private void Large_Click(object sender, RoutedEventArgs e)
        {
            if (Side != null)
            {
                Side.Size = Size.Large;
            }
        }
    }
}
