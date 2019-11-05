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

namespace PointOfSale.Entree_Customization
{
    /// <summary>
    /// Interaction logic for SteakosaurusBurgerCustomization.xaml
    /// </summary>
    public partial class SteakosaurusBurgerCustomization : Page
    {
        private SteakosaurusBurger sb;       
        public SteakosaurusBurgerCustomization(SteakosaurusBurger sb)
        {
            this.sb = sb;
            InitializeComponent();
        }
        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            sb.HoldBun();
        }
        private void OnHoldKetchup(object sender, RoutedEventArgs e)
        {
            sb.HoldKetchup();
        }
        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {
            sb.HoldMustard();
        }
        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {
            sb.HoldPickle();
        }

        private void OnConfirm(object sender, RoutedEventArgs e)
        {
            if (App.PreviousPage == PreviousPages.EntreeSelection)
                NavigationService.Navigate(new MenuCategorySelection());
            else if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.GoBack();
        }
    }
}
