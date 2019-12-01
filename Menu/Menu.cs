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

        public List<string> PossibleIngredients
        {
            get
            {
                List<IMenuItem> menuItems = AvailableMenuItems;
                HashSet<string> ingredients = new HashSet<string>();
                foreach(IMenuItem item in menuItems)
                {
                    foreach(string ingredient in item.Ingredients)
                    {
                        ingredients.Add(ingredient);
                    }
                }
                List<string> i = new List<string>();
                foreach (string ingredient in ingredients)
                    i.Add(ingredient);
                return i;
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

        public static List<IMenuItem> FilterByIngredients(List<IMenuItem> items, List<string> ingredients)
        {
            List<IMenuItem> i = new List<IMenuItem>();
            foreach (IMenuItem item in items)
            {
                bool valid = true;
                foreach(string ingredient in item.Ingredients)
                {
                    if (ingredients.Contains(ingredient))
                        valid = false;
                }
                if (valid)
                    i.Add(item);
            }
            return i;
        }
    }
}
