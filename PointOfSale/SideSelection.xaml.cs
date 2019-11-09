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
        private Side side;
        private CretaceousCombo combo;
        /// <summary>
        /// Constructor used when modifying a side.
        /// </summary>
        /// <param name="side">the side to be modified</param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
            if (side.Size == Size.Small)
                Small.IsChecked = true;
            else if (side.Size == Size.Medium)
                Medium.IsChecked = true;
            else
                Large.IsChecked = true;
        }

        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            if (combo.Side.Size == Size.Small)
                Small.IsChecked = true;
            else if (combo.Side.Size == Size.Medium)
                Medium.IsChecked = true;
            else
                Large.IsChecked = true;
        }

        private void MeteorMacAndCheese_Click(object sender, RoutedEventArgs e)
        {
            if (side == null && combo == null)
            {
                if (DataContext is Order order)
                {
                    MeteorMacAndCheese mac = new MeteorMacAndCheese();
                    mac.Size = CheckSize();
                    order.Add(mac);
                }
            }
            else if(side != null && combo== null)
            {
                side = new MeteorMacAndCheese();
                side.Size = CheckSize();
            }
            else
            {           
                combo.Side = new MeteorMacAndCheese();
                combo.Side.Size = CheckSize();
            }
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization(combo));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }

        private void Fryceritops_Click(object sender, RoutedEventArgs e)
        {
            if (side == null && combo == null)
            {
                if (DataContext is Order order)
                {
                    Fryceritops fr = new Fryceritops();
                    fr.Size = CheckSize();
                    order.Add(fr);
                }
            }
            else if(side != null && combo == null)
            {
                side = new Fryceritops();
                side.Size = CheckSize();
            }
            else
            {
                combo.Side = new Fryceritops();
                combo.Side.Size = CheckSize();
            }
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization(combo));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }

        private void Triceritots_Click(object sender, RoutedEventArgs e)
        {
            if (side == null && combo == null)
            {
                if (DataContext is Order order)
                {
                    Triceritots tots = new Triceritots();
                    tots.Size = CheckSize();
                    order.Add(tots);
                }
            }
            else if(side != null && combo == null)
            {
                side = new Triceritots();
                side.Size = CheckSize();
            }
            else
            {
                combo.Side = new Triceritots();
                combo.Side.Size = CheckSize();
            }
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization(combo));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }

        private void MezzorellaSticks_Click(object sender, RoutedEventArgs e)
        {
            if (side == null && combo == null)
            {
                if (DataContext is Order order)
                {
                    MezzorellaSticks ms = new MezzorellaSticks();
                    ms.Size = CheckSize();
                    order.Add(ms);
                }
            }
            else if(side != null && combo == null)
            {
                side = new MezzorellaSticks();
                side.Size = CheckSize();
            }
            else
            {
                combo.Side = new MezzorellaSticks();
                combo.Side.Size = CheckSize();
            }
            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization(combo));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }

        private Size CheckSize()
        {
            if (Small.IsChecked == true)
                return Size.Small;
            if (Medium.IsChecked == true)
                return Size.Medium;
            return Size.Large;
        }

        private void Small_Click(object sender, RoutedEventArgs e)
        {
            if(side != null)
            {
                side.Size = Size.Small;
                
            }
            if(combo != null)
            {
                combo.Side.Size = Size.Small;
            }

        }

        private void Medium_Click(object sender, RoutedEventArgs e)
        {
            if (side != null)
            {
                side.Size = Size.Medium;
            }
            if (combo != null)
            {
                combo.Side.Size = Size.Medium;
            }
        }

        private void Large_Click(object sender, RoutedEventArgs e)
        {
            if (side != null)
            {
                side.Size = Size.Large;
            }
            if (combo != null)
            {
                combo.Side.Size = Size.Large;
            }
        }
    }
}
