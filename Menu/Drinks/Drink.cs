/*Drink.cs
 * Author: Donovan West
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public abstract class Drink : IMenuItem
    {
        /// <summary>
        /// size of the drink, either Small, Medium, or Large
        /// </summary>
        public Size Size { get; set; }
        /// <summary>
        /// the price of the drink
        /// </summary>
        public virtual double Price { get; set; }
        /// <summary>
        /// the calories of the drink
        /// </summary>
        public virtual uint Calories { get; set; }
        /// <summary>
        /// the list of ingredients included in the drink
        /// </summary>
        public virtual List<string> Ingredients { get; }
        /// <summary>
        /// whether or not there is ice in the drink
        /// </summary>
        public bool Ice = true;
        /// <summary>
        /// removes ice from the drink
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }
    }
}
