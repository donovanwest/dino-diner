/* MezzorellaSticks.cs
 * Author: Donovan West
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// blank constructor
        /// </summary>
        public MezzorellaSticks()
        {

        }
        /// <summary>
        /// returns a list of all the ingredients"
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
            }
        }
        /// <summary>
        /// returns the calories
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (this.Size == Size.Large)
                {
                    return 720;
                }
                else if (this.Size == Size.Medium)
                {
                    return 610;
                }
                else
                {
                    return 540;
                }
            }
            set => base.Calories = value;
        }

        /// <summary>
        /// Returns the name of the menu item
        /// </summary>
        public override string ToString(){
            if (Size == Size.Large)
                return "Large Mezzorella Sticks";
            else if (Size == Size.Medium)
                return "Medium Mezzorella Sticks";
            else
                return "Small Mezzorella Sticks";
        }

        public override string Description { get { return ToString(); } }

        public override string[] Special { get { return new string[0]; } }
    }
}
