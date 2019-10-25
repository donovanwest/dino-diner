/* IOrderitem.cs
 * Author: Donovan West
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu 
{
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// The price of the order item
        /// </summary>
        double Price { get; }
        /// <summary>
        /// The description or name of the order item
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Any special changes to the order item
        /// </summary>
        string[] Special { get; }
    }
}
