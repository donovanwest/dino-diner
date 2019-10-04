/* Entree.cs
 * Author: Donovan West
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public abstract class Entree
    {
        /// <summary>
        /// the price of the entree
        /// </summary>
        public virtual double Price { get; set; }
        /// <summary>
        /// the calories of the entree
        /// </summary>
        public virtual uint Calories { get; set; }
        /// <summary>
        /// a list of all the ingredients
        /// </summary>
        public virtual List<string> Ingredients { get; }

    }
}
