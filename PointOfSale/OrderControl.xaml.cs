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
