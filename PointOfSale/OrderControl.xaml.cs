/* OrderControl.xaml.cs
 * Author: Donovan West
 */ 
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public NavigationService NavigationService { get; set; }
        public OrderControl()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrderItems.SelectedItem is Side side)
                NavigationService?.Navigate(new SideSelection(side));
            if (OrderItems.SelectedItem is Drink drink)
                NavigationService?.Navigate(new DrinkSelection(drink));
            if(OrderItems.SelectedItem is Entree entree)
            {
                if (entree is Brontowurst br)
                    NavigationService?.Navigate(new Entree_Customization.BrontowurstCustomization(br));
                if (entree is DinoNuggets dn)
                    NavigationService?.Navigate(new Entree_Customization.DinoNuggetsCustomization(dn));
                if (entree is PrehistoricPBJ pbj)
                    NavigationService?.Navigate(new Entree_Customization.PrehistoricPBJCustomization(pbj));
                if (entree is SteakosaurusBurger sb)
                    NavigationService?.Navigate(new Entree_Customization.SteakosaurusBurgerCustomization(sb));
                if (entree is TRexKingBurger trex)
                    NavigationService?.Navigate(new Entree_Customization.TRexKingBurgerCustomization(trex));
                if (entree is VelociWrap wrap)
                    NavigationService?.Navigate(new Entree_Customization.VelociwrapCustomization(wrap));             
            }
            if(OrderItems.SelectedItem is CretaceousCombo combo)
                NavigationService?.Navigate(new ComboCustomization(combo));
        }
        /// <summary>
        /// removes an order item from the list when the X is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnRemoveItem(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(sender is FrameworkElement element)
                    if(element.DataContext is IOrderItem item)
                        order.Remove(item);
            }
        }
    }
}
