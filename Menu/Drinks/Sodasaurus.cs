/*Sodasaurus.cs
 * Author: Donovan West
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// The flavor of the soda. can be Cola, Cherry, Vanilla, Chocolate, Lime, Orange, or Rootbeer.
        /// </summary>
        public SodasaurusFlavor Flavor;
        /// <summary>
        /// the price of the soda
        /// </summary>
        public override double Price { get
            {
                if (Size == Size.Medium)
                {
                    return 2;
                }
                else if (Size == Size.Small)
                {
                    return 1.50;
                }
                else
                {
                    return 2.50;
                }
            }
            set
            {

            }
        }
        /// <summary>
        /// the calories of the soda
        /// </summary>
        public override uint Calories { get
            {
                if (Size == Size.Medium)
                {
                    return 156;
                }
                else if (Size == Size.Small)
                {
                    return 112;
                }
                else
                {
                    return 208;
                }
            }
            set
            {

            }
        }
        /// <summary>
        /// the list of ingredients in the soda
        /// </summary>
        public override List<string> Ingredients { get
            {
                return new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            } }

        /// <summary>
        /// Returns the name of the menu item
        /// </summary>
        public override string ToString(){
            if (Size == Size.Large)
                return "Large Sodasaurus";
            else if (Size == Size.Medium)
                return "Medium Sodasaurus";
            else
                return "Small Sodasaurus";
        }
    }
}
