/* DinoNuggets.cs
 * Author: Donovan West
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets : Entree
    {
        private uint Nuggets = 6;
        /// <summary>
        /// returns a list of all the ingredients"
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for(int k = 0; k < Nuggets; k++)
                    ingredients.Add("Chicken Nugget");
                return ingredients;
            }
        }
        /// <summary>
        /// contructs the entree with the correct price and calories
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = Nuggets * 59;
        }
        /// <summary>
        /// adds a nugget
        /// </summary>
        public void AddNugget()
        {
            Nuggets++;
            this.Price += 0.25;
            this.Calories += 59;
        }
    }

}