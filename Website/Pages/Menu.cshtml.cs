using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        //public Menu Menu { get; private set; }

        public IEnumerable<IMenuItem> Items { get; set; }

        public List<string> PossibleIngredients { get; set; }

        [BindProperty]
        public List<string> CategoryFilter { get; set; } = new List<string>();

        [BindProperty]
        public string Search { get; set; }

        [BindProperty]
        public float? MinPrice { get; set; }

        [BindProperty]
        public float? MaxPrice { get; set; }

        [BindProperty]
        public List<string> IngredientFilter { get; set; } = new List<string>();
        


        public void OnGet()
        {
            Items = new Menu().AvailableMenuItems;
            PossibleIngredients = new Menu().PossibleIngredients;
        }

        public void OnPost()
        {
            Items = new Menu().AvailableMenuItems;
            PossibleIngredients = new Menu().PossibleIngredients;

            if (Search != null)
                Items = Items.Where(item => item.ToString().Contains(Search, StringComparison.InvariantCultureIgnoreCase));
            //Items = Menu.Search(Items, Search);

            if (CategoryFilter.Count > 0)
                Items = Items.Where(item => (item is Entree && CategoryFilter.Contains("Entree")) || (item is CretaceousCombo && CategoryFilter.Contains("Combo")) || (item is Side && CategoryFilter.Contains("Side")) || (item is Drink && CategoryFilter.Contains("Drink")));
            //Items = Menu.FilterByCategory(Items, CategoryFilter);

            if (MinPrice != null)
                Items = Items.Where(item => item.Price >= MinPrice);
                //Items = Menu.FilterByMinPrice(Items, MinPrice);

            if (MaxPrice != null)
                Items = Items.Where(item => item.Price <= MaxPrice);

            //Items = Menu.FilterByMaxPrice(Items, MaxPrice);

            if (IngredientFilter.Count > 0)
            {
                foreach (string i in IngredientFilter) {
                    Items = Items.Where(item => !item.Ingredients.Contains(i));
                }

            }
                //Items = Menu.FilterByIngredients(Items, IngredientFilter);

            
            
            
        }
    }
}