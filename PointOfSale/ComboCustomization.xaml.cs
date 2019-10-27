/* ComboCustomization.xaml.cs
 * Author: Donovan West
 */ 
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboCustomization.xaml
    /// </summary>
    public partial class ComboCustomization : Page
    {
        public ComboCustomization()
        {
            InitializeComponent();
            App.PreviousPage = PreviousPages.ComboCustomization;

            switch (App.currentEntree) {
                case Entrees.Brontowurst:
                    Entree.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-01.png")));
                    break;
                case Entrees.DinoNuggets:
                    Entree.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-02.png")));
                    break;
                case Entrees.Steakosaurus:
                    Entree.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-05.png")));
                    break;
                case Entrees.TRexKingBurger:
                    Entree.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-06.png")));
                    break;
                case Entrees.PterodactylWings:
                    Entree.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-04.png")));
                    break;
                case Entrees.PrehistoricPBJ:
                    Entree.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-03.png")));
                    break;
                case Entrees.VelociWrap:
                    Entree.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-07.png")));
                    break;
            }

            switch (App.currentDrink)
            {
                case Drinks.Sodasaurus:
                    Drink.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-12.png")));
                    break;
                case Drinks.JurrasicJava:
                    Drink.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-13.png")));
                    break;
                case Drinks.Tyrannotea:
                    Drink.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-14.png")));
                    break;
                case Drinks.Water:
                    Drink.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-15.png")));
                    break;
            }

            switch (App.currentSide)
            {
                case Sides.Fryceritops:
                    Side.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-08.png")));
                    break;
                case Sides.MeteorMacAndCheese:
                    Side.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-09.png")));
                    break;
                case Sides.MezzorellaSticks:
                    Side.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-10.png")));
                    break;
                case Sides.Triceritots:
                    Side.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-11.png")));
                    break;

            }

        }

        private void ChangeEntree(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EntreeSelection());
        }

        private void ChangeSide(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection());
        }

        private void ChangeDrink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

    }
}
