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
    /// Interaction logic for DinoNuggetsCustomization.xaml
    /// </summary>
    public partial class DinoNuggetsCustomization : Page
    {
        DinoNuggets nuggs;
        public DinoNuggetsCustomization(DinoNuggets nuggets)
        {
            InitializeComponent();
            nuggs = nuggets;
        }

        private void OnAddNugget(object sender, RoutedEventArgs e)
        {
            nuggs.AddNugget();
        }

        private void OnConfirm(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
