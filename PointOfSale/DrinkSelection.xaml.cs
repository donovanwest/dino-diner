/* DrinkSelection.xaml.cs
 * Author: Donovan West
 */
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Default constructor for most situations
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            
        }
        private SodasaurusFlavor sodaFlavor = SodasaurusFlavor.Cola;
        private Drink drink;

        public DrinkSelection(Drink d)
        {
            InitializeComponent();
            drink = d;
            if (drink.Size == Size.Small)
                Small.IsChecked = true;
            else if (drink.Size == Size.Medium)
                Medium.IsChecked = true;
            else
                Large.IsChecked = true;

            if (drink is Sodasaurus soda)
            {
                sodaFlavor = soda.Flavor;
                switch (soda.Flavor)
                {
                    case SodasaurusFlavor.Cola:
                        SodaFlavor.Content = "Sodasaurus \nFlavor \n(Cola)";
                        break;
                    case SodasaurusFlavor.RootBeer:
                        SodaFlavor.Content = "Sodasaurus \nFlavor \n(Root Beer)";
                        break;
                    case SodasaurusFlavor.Cherry:
                        SodaFlavor.Content = "Sodasaurus \nFlavor \n(Cherry)";
                        break;
                    case SodasaurusFlavor.Chocolate:
                        SodaFlavor.Content = "Sodasaurus \nFlavor \n(Chocolate)";
                        break;
                    case SodasaurusFlavor.Orange:
                        SodaFlavor.Content = "Sodasaurus \nFlavor \n(Orange)";
                        break;
                    case SodasaurusFlavor.Lime:
                        SodaFlavor.Content = "Sodasaurus \nFlavor \n(Lime)";
                        break;
                    case SodasaurusFlavor.Vanilla:
                        SodaFlavor.Content = "Sodasaurus \nFlavor \n(Vanilla)";
                        break;                 
                }
                SodaFlavor.FontSize = 30;
                Uncheck();
                Sodasaurus.IsChecked = true;
                JurrasicJava.IsChecked = false;
                Tyrannotea.IsChecked = false;
                Water.IsChecked = false;
                Ice.IsEnabled = true;
                Ice.IsChecked = soda.Ice;
                SodaFlavor.IsEnabled = true;
                Confirm.IsEnabled = true;
            }

            if(drink is JurassicJava java)
            {
                Uncheck();
                Sodasaurus.IsChecked = false;
                JurrasicJava.IsChecked = true;
                Tyrannotea.IsChecked = false;
                Water.IsChecked = false;
                Ice.IsEnabled = true;
                Ice.IsChecked = java.Ice;
                Decaf.IsEnabled = true;
                Decaf.IsChecked = java.Decaf;
                RoomForCream.IsEnabled = true;
                RoomForCream.IsChecked = java.RoomForCream;
                Confirm.IsEnabled = true;
            }

            if(drink is Tyrannotea tea)
            {
                Uncheck();
                Sodasaurus.IsChecked = false;
                JurrasicJava.IsChecked = false;
                Tyrannotea.IsChecked = true;
                Water.IsChecked = false;
                Ice.IsEnabled = true;
                Ice.IsChecked = tea.Ice;
                Lemon.IsEnabled = true;
                Lemon.IsChecked = tea.Lemon;
                Sweet.IsEnabled = true;
                Sweet.IsChecked = tea.Sweet;
                Confirm.IsEnabled = true;

            }

            if (drink is Water water)
            {
                Uncheck();
                Sodasaurus.IsChecked = false;
                JurrasicJava.IsChecked = false;
                Tyrannotea.IsChecked = false;
                Water.IsChecked = true;
                Ice.IsEnabled = true;
                Ice.IsChecked = water.Ice;
                Lemon.IsEnabled = true;
                Lemon.IsChecked = water.Lemon;
                Confirm.IsEnabled = true;
            }
        }

        private void SelectWater(object sender, RoutedEventArgs e)
        {
            App.currentDrink = Drinks.Water;
            JurrasicJava.IsChecked = false;
            Sodasaurus.IsChecked = false;
            Tyrannotea.IsChecked = false;
            if (Water.IsChecked == true)
            {
                Uncheck();
                Lemon.IsEnabled = true;
                Ice.IsEnabled = true;
                Ice.IsChecked = true;
                Confirm.IsEnabled = true;
            }
            else
            {
                Uncheck();
            }
        }
        private void SelectJurrasicJava(object sender, RoutedEventArgs e)
        {
            App.currentDrink = Drinks.JurrasicJava;
            Sodasaurus.IsChecked = false;
            Tyrannotea.IsChecked = false;
            Water.IsChecked = false;
            if(JurrasicJava.IsChecked == true)
            {
                Uncheck();
                Ice.IsChecked = false;
                Ice.IsEnabled = true;
                Decaf.IsEnabled = true;
                Confirm.IsEnabled = true;
                RoomForCream.IsEnabled = true;
            }
            else
            {
                Uncheck();
            }
        }
        private void SelectSodasaurus(object sender, RoutedEventArgs e)
        {
            App.currentDrink = Drinks.Sodasaurus;
            JurrasicJava.IsChecked = false;
            Tyrannotea.IsChecked = false;
            Water.IsChecked = false;
            if(Sodasaurus.IsChecked == true)
            {
                Uncheck();
                Ice.IsEnabled = true;
                Ice.IsChecked = true;
                SodaFlavor.IsEnabled = true;
                Confirm.IsEnabled = true;
            }
            else
            {
                Uncheck();
            }
        }
        private void SelectTyrannotea(object sender, RoutedEventArgs e)
        {
            App.currentDrink = Drinks.Tyrannotea;
            JurrasicJava.IsChecked = false;
            Sodasaurus.IsChecked = false;
            Water.IsChecked = false;
            if (Tyrannotea.IsChecked == true)
            {
                Uncheck();
                Lemon.IsEnabled = true;
                Ice.IsEnabled = true;
                Ice.IsChecked = true;
                Sweet.IsEnabled = true;
                Confirm.IsEnabled = true;
            }
            else
            {
                Uncheck();               
            }
        }

        private void Flavor_Click(object sender, RoutedEventArgs e)
        {
            Sodasaurus soda = new Sodasaurus();
            if (Small.IsChecked == true)
                soda.Size = Size.Small;
            else if (Medium.IsChecked == true)
                soda.Size = Size.Medium;
            else
                soda.Size = Size.Large;
            if (Ice.IsChecked == false)
                soda.HoldIce();
            NavigationService.Navigate(new SodasaurusFlavorSelection(soda));
        }


        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            Size size = Size.Small;
            if (drink == null)
            {
                if (Small.IsChecked == true)
                    size = Size.Small;
                else if (Medium.IsChecked == true)
                    size = Size.Medium;
                else
                    size = Size.Large;
            }
            else
            {
                if (Small.IsChecked == true)
                    drink.Size = Size.Small;
                else if (Medium.IsChecked == true)
                    drink.Size = Size.Medium;
                else
                    drink.Size = Size.Large;
            }
                  
            if (Water.IsChecked == true)
            {
                if (drink == null)
                {
                    Water water = new Water();
                    water.Size = size;
                    if (Lemon.IsChecked == true)
                        water.AddLemon();
                    if (Ice.IsChecked == false)
                        water.HoldIce();
                    if (DataContext is Order order)
                    {                       
                        order.Add(water);
                    }
                }
                else
                {
                    if (Ice.IsChecked == false)
                        ((Water)drink).HoldIce();
                    if (Lemon.IsChecked == true)
                        ((Water)drink).AddLemon();
                }
            }
            else if (Sodasaurus.IsChecked == true)
            {
                if (drink == null)
                {
                    Sodasaurus soda = new Sodasaurus();
                    soda.Size = size;
                    soda.Flavor = sodaFlavor;
                    if (Ice.IsChecked == false)
                        soda.HoldIce();
                    if (DataContext is Order order)
                    {                     
                        order.Add(soda);
                    }
                }
                else
                {
                    bool needToAdd = true;
                    if (DataContext is Order order)
                        if (order.Items.Contains(drink))
                            needToAdd = false;
                    if (needToAdd == false)
                    {
                        ((Sodasaurus)drink).Flavor = sodaFlavor;
                        if (Ice.IsChecked == false)
                            ((Sodasaurus)drink).HoldIce();
                    }
                    else
                    {
                        Sodasaurus s = new Sodasaurus();
                        s.Flavor = sodaFlavor;
                        if (Ice.IsChecked == false)
                            s.HoldIce();
                        if (DataContext is Order o)
                        {
                            o.Add(s);
                        }
                    }
                }
            }
            else if (Tyrannotea.IsChecked == true)
            {
                if (drink == null)
                {
                    Tyrannotea tea = new Tyrannotea();
                    tea.Size = size;
                    if (Ice.IsChecked == false)
                        tea.HoldIce();
                    if (Lemon.IsChecked == true)
                        tea.AddLemon();
                    if (Sweet.IsChecked == true)
                        tea.AddSweetener();
                    if (DataContext is Order order)
                    {
                        order.Add(tea);
                    }
                }
                else
                {
                    if (Ice.IsChecked == false)
                        ((Tyrannotea)drink).HoldIce();
                    if (Lemon.IsChecked == true)
                        ((Tyrannotea)drink).AddLemon();
                    if (Sweet.IsChecked == true)
                        ((Tyrannotea)drink).AddSweetener();
                }
            }
            else if (JurrasicJava.IsChecked == true)
            {
                if (drink == null)
                {
                    JurassicJava java = new JurassicJava();
                    java.Size = size;
                    if (Ice.IsChecked == true)
                        java.AddIce();
                    if (RoomForCream.IsChecked == true)
                        java.LeaveRoomForCream();
                    if (Decaf.IsChecked == true)
                        java.MakeDecaf();
                    if (DataContext is Order order)
                    {
                        order.Add(java);
                    }
                }
                else
                {
                    if (Ice.IsChecked == true)
                        ((JurassicJava)drink).AddIce();
                    if (RoomForCream.IsChecked == true)
                        ((JurassicJava)drink).LeaveRoomForCream();
                    if (Decaf.IsChecked == true)
                        ((JurassicJava)drink).MakeDecaf();
                }
            }

            if (App.PreviousPage == PreviousPages.ComboCustomization)
                NavigationService.Navigate(new ComboCustomization());
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// Unchecks and disables all the drink specific modifications to prepare for a new drink to be pressed
        /// </summary>
        private void Uncheck()
        {
            Lemon.IsChecked = false;
            Ice.IsChecked = false;
            Decaf.IsChecked = false;
            Sweet.IsChecked = false;
            RoomForCream.IsChecked = false;

            Lemon.IsEnabled = false;
            Ice.IsEnabled = false;
            Decaf.IsEnabled = false;
            SodaFlavor.IsEnabled = false;
            Sweet.IsEnabled = false;
            Confirm.IsEnabled = false;
            RoomForCream.IsEnabled = false;
        }

    }
}
