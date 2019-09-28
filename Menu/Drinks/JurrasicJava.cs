/*JurrasicJava.cs
 * Author: Donovan West
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        public JurrasicJava()
        {
            this.HoldIce();
        }
        /// <summary>
        /// Whether or not there is room for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;
        /// <summary>
        /// Whether or not the coffe is decaf
        /// </summary>
        public bool Decaf { get; set; } = false;
        /// <summary>
        /// returns the price
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return 0.99;
                }
                else if (Size == Size.Small)
                {
                    return 0.59;
                }
                else
                {
                    return 1.49;
                }
            }
            set
            {

            }
        }
        /// <summary>
        /// the calories of the drink
        /// </summary>
        public override uint Calories
        {
            get
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
        /// the list of ingredients in the coffee
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Coffee" };
            }
        }
        /// <summary>
        /// leaves from for cream
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }
        /// <summary>
        /// adds ice
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }

    }
}
