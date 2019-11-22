/* Menu.cs
 * Author: Donovan West
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
        //private List<IMenuItem> availableMenuItems = new List<IMenuItem>();

        //private List<IMenuItem> availabledrinks;

        //private List<IMenuItem> availableSides;

        //private List<IMenuItem> availableDrinks;

        //private List<IMenuItem> availableCombos;

        public Menu()
        {
            
/*
            availabledrinks.Add(new Brontowurst());
            availabledrinks.Add(new DinoNuggets());
            availabledrinks.Add(new PrehistoricPBJ());
            availabledrinks.Add(new PterodactylWings());
            availabledrinks.Add(new SteakosaurusBurger());
            availabledrinks.Add(new TRexKingBurger());
            availabledrinks.Add(new VelociWrap());

            availableSides.Add(new Fryceritops());
            availableSides.Add(new MeteorMacAndCheese());
            availableSides.Add(new MezzorellaSticks());
            availableSides.Add(new Triceritots());

            availableCombos.Add(new CretaceousCombo(new Brontowurst()));
            availableCombos.Add(new CretaceousCombo(new DinoNuggets()));
            availableCombos.Add(new CretaceousCombo(new PrehistoricPBJ()));
            availableCombos.Add(new CretaceousCombo(new PterodactylWings()));
            availableCombos.Add(new CretaceousCombo(new SteakosaurusBurger()));
            availableCombos.Add(new CretaceousCombo(new TRexKingBurger()));
            availableCombos.Add(new CretaceousCombo(new VelociWrap()));
            */
        }

        /// <summary>
        /// returns a list of all availiable menu items
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> menuItems = new List<IMenuItem>();
                menuItems.Add(new Brontowurst());
                menuItems.Add(new DinoNuggets());
                menuItems.Add(new PrehistoricPBJ());
                menuItems.Add(new PterodactylWings());
                menuItems.Add(new SteakosaurusBurger());
                menuItems.Add(new TRexKingBurger());
                menuItems.Add(new VelociWrap());

                menuItems.Add(new Fryceritops());
                menuItems.Add(new MeteorMacAndCheese());
                menuItems.Add(new MezzorellaSticks());
                menuItems.Add(new Triceritots());

                menuItems.Add(new JurassicJava());
                menuItems.Add(new Sodasaurus());
                menuItems.Add(new Tyrannotea());
                menuItems.Add(new Water());

                menuItems.Add(new CretaceousCombo(new Brontowurst()));
                menuItems.Add(new CretaceousCombo(new DinoNuggets()));
                menuItems.Add(new CretaceousCombo(new PrehistoricPBJ()));
                menuItems.Add(new CretaceousCombo(new PterodactylWings()));
                menuItems.Add(new CretaceousCombo(new SteakosaurusBurger()));
                menuItems.Add(new CretaceousCombo(new TRexKingBurger()));
                menuItems.Add(new CretaceousCombo(new VelociWrap()));
                return menuItems;
            }
        }
        /// <summary>
        /// returns a list of all availiable entrees
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> entrees = new List<IMenuItem>();
                foreach(IMenuItem item in AvailableMenuItems)
                {
                    if (item is Entree entree)
                        entrees.Add(entree);
                }
                return entrees;
            }
        }
        /// <summary>
        /// returns a list of all availiable sides
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> sides = new List<IMenuItem>();
                foreach (IMenuItem item in AvailableMenuItems)
                {
                    if (item is Side side)
                        sides.Add(side);
                }
                return sides;
            }
        }
        /// <summary>
        /// returns a list of all availiable drinks
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> drinks = new List<IMenuItem>();
                foreach (IMenuItem item in AvailableMenuItems)
                {
                    if (item is Drink drink)
                        drinks.Add(drink);
                }
                return drinks;
            }
        }
        /// <summary>
        /// returns a list of all availiable combos
        /// </summary>
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> combos = new List<IMenuItem>();
                foreach (IMenuItem item in AvailableMenuItems)
                {
                    if (item is CretaceousCombo combo)
                        combos.Add(combo);
                }
                return combos;
            }
        }
        /// <summary>
        /// returns a string of all availiable menu items
        /// </summary>
        public override string ToString()
        {
            string result = "";
            List<IMenuItem> items = AvailableMenuItems;
            foreach(IMenuItem i in items)
            {
                result += i.ToString();
                result += "\n";
            }
            return result;
        }

        public static List<IMenuItem> Search(List<IMenuItem> items, string search)
        {
            List<IMenuItem> i = new List<IMenuItem>();
            foreach(IMenuItem item in items)
            {
                if (item.ToString().ToLower().Contains(search.ToLower()))
                {
                    i.Add(item);
                }
            }
            return i;
        }

        public static List<IMenuItem> FilterByCategory(List<IMenuItem> items, List<string> categories)
        {
            List<IMenuItem> i = new List<IMenuItem>();
            foreach(IMenuItem item in items)
            {
                if (categories.Contains("Entree") && item is Entree)
                {
                    i.Add(item);
                }

                if (categories.Contains("Combo") && item is CretaceousCombo)
                {
                    i.Add(item);
                }

                if (categories.Contains("Side") && item is Side)
                {
                    i.Add(item);
                }

                if (categories.Contains("Drink") && item is Drink)
                {
                    i.Add(item);
                }
            }
            return i;
        }

        public static List<IMenuItem> FilterByMinPrice(List<IMenuItem> items, float? minPrice)
        {
            List<IMenuItem> i = new List<IMenuItem>();
            foreach (IMenuItem item in items)
            {
                if(item.Price > minPrice)
                {
                    i.Add(item);
                }
            }
            return i;
        }

        public static List<IMenuItem> FilterByMaxPrice(List<IMenuItem> items, float? maxPrice)
        {
            List<IMenuItem> i = new List<IMenuItem>();
            foreach (IMenuItem item in items)
            {
                if (item.Price < maxPrice)
                {
                    i.Add(item);
                }
            }
            return i;
        }
    }
}
