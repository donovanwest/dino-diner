/* Brontowurst.cs
 * Author: Donovan West
 */

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class Brontowurst : Entree
    {
        private bool WholeWheatBun = true;
        private bool Peppers = true;
        private bool Onions = true;
        /// <summary>
        /// returns a list of all the ingredients"
        /// </summary>
        public override List<string> Ingredients
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

        /// <summary>
        /// gets any special preparation instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!WholeWheatBun) special.Add("Hold Bun");
                if (!Peppers) special.Add("Hold Peppers");
                if (!Onions) special.Add("Hold Onions");
                return special.ToArray();
            }
        }

        /// <summary>
        /// contructs the entree with the correct price and calories
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }
        /// <summary>
        /// removes the bun
        /// </summary>
        public void HoldBun()
        {
            this.WholeWheatBun = false;
        }
        /// <summary>
        /// removes the peppers
        /// </summary>
        public void HoldPeppers()
        {
            this.Peppers = false;
        }
        /// <summary>
        /// removes the onion
        /// </summary>
        public void HoldOnion()
        {
            this.Onions = false;
        }

        /// <summary>
        /// Returns the name of the menu item
        /// </summary>
        public override string ToString(){
            return "Brontowurst";
        }
    }
}