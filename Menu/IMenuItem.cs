/* IMenuItem.cs
 * Author: Donovan West
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IMenuItem
    {
        /// <summary>
        /// returns the price of the menu item
        /// </summary>
        double Price { get; }
        /// <summary>
        /// returns the calories of the menu item
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// returns a list of the ingredients in the menu item
        /// </summary>
        List<string> Ingredients { get; }

    }
}
