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
    /// Interaction logic for TRexKingBurgerCustomization.xaml
    /// </summary>
    public partial class TRexKingBurgerCustomization : Page
    {
        private TRexKingBurger trex;
        public TRexKingBurgerCustomization(TRexKingBurger trex)
        {
            this.trex = trex;
            InitializeComponent();
        }
        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            trex.HoldBun();
        }
        private void OnHoldKetchup(object sender, RoutedEventArgs e)
        {
            trex.HoldKetchup();
        }
        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {
            trex.HoldMustard();
        }
        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {
            trex.HoldPickle();
        }

        private void OnHoldLettuce(object sender, RoutedEventArgs e)
        {
            trex.HoldLettuce();
        }

        private void OnHoldTomato(object sender, RoutedEventArgs e)
        {
            trex.HoldTomato();
        }

        private void OnHoldMayo(object sender, RoutedEventArgs e)
        {
            trex.HoldMayo();
        }

        private void OnHoldOnion(object sender, RoutedEventArgs e)
        {
            trex.HoldOnion();
        }

        private void OnConfirm(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
