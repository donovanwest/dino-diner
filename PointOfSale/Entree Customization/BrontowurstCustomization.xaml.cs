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
    /// Interaction logic for BrontosaurusCustomization.xaml
    /// </summary>
    public partial class BrontowurstCustomization : Page
    {
        private Brontowurst brontowurst;
        public BrontowurstCustomization(Brontowurst brontowurst)
        {
            this.brontowurst = brontowurst;
            InitializeComponent();
        }

        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            brontowurst.HoldBun();
        }

        private void OnHoldOnions(object sender, RoutedEventArgs e)
        {
            brontowurst.HoldOnion();
        }

        private void OnHoldPeppers(object sender, RoutedEventArgs e)
        {
            brontowurst.HoldPeppers();
        }

        private void OnConfirm(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
