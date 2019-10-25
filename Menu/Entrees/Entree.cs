/* Entree.cs
 * Author: Donovan West
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Entree : IMenuItem, IOrderItem
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

        public virtual string Description { get { return this.ToString(); } }

        public abstract string[] Special { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
