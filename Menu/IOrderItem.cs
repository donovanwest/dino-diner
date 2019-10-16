using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IOrderItem
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
