using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {
        private bool Brautwurst = true;
        private bool WholeWheatBun = true;
        private bool Peppers = true;
        private bool Onions = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (WholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (Peppers) ingredients.Add("Peppers");
                if (Onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public void HoldBun()
        {
            this.WholeWheatBun = false;
        }

        public void HoldPeppers()
        {
            this.Peppers = false;
        }

        public void HoldOnion()
        {
            this.Onions = false;
        }
    }
}