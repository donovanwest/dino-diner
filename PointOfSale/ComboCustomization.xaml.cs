/* ComboCustomization.xaml.cs
 * Author: Donovan West
 */ 
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using DinoDiner.Menu;
using System.ComponentModel;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboCustomization.xaml
    /// </summary>
    public partial class ComboCustomization : Page, INotifyPropertyChanged
    {
       // private Entree entree;
        //private Drink drink;
        //private Side side;
        private CretaceousCombo combo;

        public event PropertyChangedEventHandler PropertyChanged;

        public ComboCustomization(CretaceousCombo c)
        {
            InitializeComponent();
            App.PreviousPage = PreviousPages.ComboCustomization;
            combo = c;
            //combo.Side = side;
            //combo.Drink = drink;
           
    
            if(combo.Entree is Brontowurst)
                Entree.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-01.png")));
            else if(combo.Entree is DinoNuggets)    
                Entree.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-02.png")));
            else if(combo.Entree is SteakosaurusBurger)
                Entree.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-05.png")));
            else if(combo.Entree is TRexKingBurger)
                Entree.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-06.png")));
            else if(combo.Entree is PterodactylWings)
                Entree.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-04.png")));
            else if(combo.Entree is PrehistoricPBJ)
                Entree.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-03.png")));
            else if(combo.Entree is VelociWrap)
                Entree.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-07.png")));

            if(combo.Drink is Sodasaurus)
                Drink.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-12.png")));
            else if(combo.Drink is JurassicJava)
                Drink.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-13.png")));
            else if(combo.Drink is Tyrannotea)
                Drink.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-14.png")));
            else if(combo.Drink is Water)
                Drink.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-15.png")));

            if(combo.Side is Fryceritops)
                Side.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-08.png")));
            else if(combo.Side is MeteorMacAndCheese)
                Side.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-09.png")));
            else if(combo.Side is MezzorellaSticks)
                Side.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-10.png")));
            else if(combo.Side is Triceritots)
                Side.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Assets/DinoDiner-11.png")));
        }

        private void ChangeEntree(object sender, RoutedEventArgs e)
        {
            if (combo.Entree is Brontowurst)
                NavigationService.Navigate(new Entree_Customization.BrontowurstCustomization(combo));
            if (combo.Entree is DinoNuggets)
                NavigationService.Navigate(new Entree_Customization.DinoNuggetsCustomization((DinoNuggets)combo.Entree));
            if (combo.Entree is PrehistoricPBJ)
                NavigationService.Navigate(new Entree_Customization.PrehistoricPBJCustomization((PrehistoricPBJ)combo.Entree));
            if (combo.Entree is PterodactylWings)
                MessageBox.Show("Can't Customize Pterodactyl Wings");
            if (combo.Entree is SteakosaurusBurger)
                NavigationService.Navigate(new Entree_Customization.SteakosaurusBurgerCustomization((SteakosaurusBurger)combo.Entree));
            if (combo.Entree is TRexKingBurger)
                NavigationService.Navigate(new Entree_Customization.TRexKingBurgerCustomization((TRexKingBurger)combo.Entree));
            if (combo.Entree is VelociWrap)
                NavigationService.Navigate(new Entree_Customization.VelociwrapCustomization((VelociWrap)combo.Entree));
        }

        private void ChangeSide(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection(combo));
        }

        private void ChangeDrink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection(combo));
        }
        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            //if (DataContext is Order order)
            //{

            //    order.Add(combo);
            //}
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void Small_Click(object sender, RoutedEventArgs e)
        {
            if (combo != null)
            {
                combo.Size = Size.Small;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Special"));
            }

        }

        private void Medium_Click(object sender, RoutedEventArgs e)
        {
            if (combo != null)
            {
                combo.Size = Size.Medium;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Special"));
            }
        }

        private void Large_Click(object sender, RoutedEventArgs e)
        {
            if (combo != null)
            {
                combo.Size = Size.Large;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Special"));
            }
        }

    }
}
