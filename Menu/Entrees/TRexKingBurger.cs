/* TRexKingBurger.cs
 * Author: Donovan West
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class TRexKingBurger : Entree
    {
        private bool WholeWheatBun = true;
        private bool Pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool mayo = true;
        /// <summary>
        /// returns a list of all the ingredients"
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (WholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (Pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }
        /// <summary>
        /// contructs the entree with the correct price and calories
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }
        /// <summary>
        /// removes the bun
        /// </summary>
        public void HoldBun()
        {
            this.WholeWheatBun = false;
        }
        /// <summary>
        /// removes the pickles
        /// </summary>
        public void HoldPickle()
        {
            this.Pickle = false;
        }
        /// <summary>
        /// removes the catsup
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        /// <summary>
        /// removes the mustard
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
        /// <summary>
        /// removes the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        /// <summary>
        /// removes the tomato
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }
        /// <summary>
        /// removes the onion
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }
        /// <summary>
        /// removes the mayo
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }

        /// <summary>
        /// Returns the name of the menu item
        /// </summary>
        public override string ToString(){
            return "T-Rex King Burger";
        }
    }
}