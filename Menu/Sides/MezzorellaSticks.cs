/* MezzorellaSticks.cs
 * Author: Donovan West
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Sides
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
    }
}
