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
using System.ComponentModel;
namespace PointOfSale.Entree_Customization
{
    /// <summary>
    /// Interaction logic for VelociwrapCustomization.xaml
    /// </summary>
    public partial class VelociwrapCustomization : Page, INotifyPropertyChanged
    {
        private VelociWrap wrap;

        public event PropertyChangedEventHandler PropertyChanged;

        public VelociwrapCustomization(VelociWrap wrap)
        {
            this.wrap = wrap;
            InitializeComponent();
        }
        private void OnHoldLettuce(object sender, RoutedEventArgs e)
        {
            wrap.HoldLettuce();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Special"));
        }

        private void OnHoldDressing(object sender, RoutedEventArgs e)
        {
            wrap.HoldDressing();
        }

        private void OnHoldCheese(object sender, RoutedEventArgs e)
        {
            wrap.HoldCheese();
        }

        private void OnConfirm(object sender, RoutedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Special"));
            if (App.PreviousPage == PreviousPages.EntreeSelection)
                NavigationService.Navigate(new MenuCategorySelection());
            else if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.GoBack();
        }
    }
}
