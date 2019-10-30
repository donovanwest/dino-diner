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
    /// Interaction logic for PrehistoricPBJCustomization.xaml
    /// </summary>
    public partial class PrehistoricPBJCustomization : Page
    {
        private PrehistoricPBJ pbj;
        public PrehistoricPBJCustomization(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
        }

        private void OnHoldPeanutButter(object sender, RoutedEventArgs e)
        {
            pbj.HoldPeanutButter();
        }

        private void OnHoldJelly(object sender, RoutedEventArgs e)
        {
            pbj.HoldJelly();
        }

        private void OnConfirm(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
