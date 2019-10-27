/* MainWIndow.xaml.cs
 * Author: Donovan West
 */ 
using System.Windows;
using System.Windows.Navigation;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OrderList.NavigationService = OrderInterface.NavigationService;
        }

        private void BindDataContextToPage()
        {
            if(OrderInterface.Content is FrameworkElement element)
            {
                element.DataContext = OrderInterface.DataContext;
            }
        }

        private void OrderInterface_LoadCompleted(object sender, NavigationEventArgs e)
        {
            BindDataContextToPage();
        }

        private void OrderInterface_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            BindDataContextToPage();
        }
    }
}
