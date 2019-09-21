/* Side.cs
 * Author: Donovan West
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// enum describing the three sizes
    /// </summary>
    public enum Size
    {
        Small,
        Medium, 
        Large
    }

    public abstract class Side
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price {
            get
            {
                if (this.Size == Size.Large)
                {
                    return  1.95;
                }
                else if (this.Size == Size.Medium)
                {
                    return  1.45;
                }
                else
                {
                    return  0.99;
                }
            }
            set {

            } }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public virtual uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public Size Size { get; set; }

    }
}
