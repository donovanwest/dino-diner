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

        public List<IMenuItem> Items { get; set; }

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
                Items = Menu.Search(Items, Search);

            if (CategoryFilter.Count > 0)
                Items = Menu.FilterByCategory(Items, CategoryFilter);

            if (MinPrice != null)
                Items = Menu.FilterByMinPrice(Items, MinPrice);

            if (MaxPrice != null)
                Items = Menu.FilterByMaxPrice(Items, MaxPrice);
            if (IngredientFilter.Count > 0)
                Items = Menu.FilterByIngredients(Items, IngredientFilter);

            
            
            
        }
    }
}