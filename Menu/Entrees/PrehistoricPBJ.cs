/* PrehistoricPBJ.cs
 * Author: Nathan Bean
 * Modified by: Donovan West
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entree
    {
        private bool peanutButter = true;
        private bool jelly = true;
        /// <summary>
        /// returns a list of all the ingredients"
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }
        /// <summary>
        /// contructs the entree with the correct price and calories
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }
        /// <summary>
        /// removes the peanut butter
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }
        /// <summary>
        /// removes the jelly
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }

        /// <summary>
        /// Returns the name of the menu item
        /// </summary>
        public override string ToString(){
            return "Prehistoric PB&J";
        }
    }
}
