/* PterodactylWings.cs
 * Author: Donovan West
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// returns a list of all the ingredients"
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }
        /// <summary>
        /// contructs the entree with the correct price and calories
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        /// <summary>
        /// Returns the name of the menu item
        /// </summary>
        public override string ToString(){
            return "Pterodactyl Wings";
        }

    }
}