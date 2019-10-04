/* VelociWrap.cs
 * Author: Donovan West
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class VelociWrap : Entree
    {
        private bool RomaineLettuce = true;
        private bool CeasarDressing = true;
        private bool ParmesanCheese = true;
        /// <summary>
        /// returns a list of all the ingredients"
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (RomaineLettuce) ingredients.Add("Romaine Lettuce");
                if (CeasarDressing) ingredients.Add("Ceasar Dressing");
                if (ParmesanCheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }
        /// <summary>
        /// contructs the entree with the correct price and calories
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }
        /// <summary>
        /// removes the dressing
        /// </summary>
        public void HoldDressing()
        {
            this.CeasarDressing = false;
        }
        /// <summary>
        /// removes the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.RomaineLettuce = false;
        }
        /// <summary>
        /// removes the cheese
        /// </summary>
        public void HoldCheese()
        {
            this.ParmesanCheese = false;
        }

        /// <summary>
        /// Returns the name of the menu item
        /// </summary>
        public override string ToString(){
            return "VelociWrap";
        }
    }
}