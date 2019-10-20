/* MeteorMacAndCheese.cs
 * Author: Donovan West
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// blank constructor
        /// </summary>
        public MeteorMacAndCheese()
        {
           
        }
        /// <summary>
        /// returns a list of all the ingredients"
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
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
                    return 520;
                }
                else if (this.Size == Size.Medium)
                {
                    return 490;
                }
                else
                {
                    return 420;
                }
            }
            set => base.Calories = value;
        }

        /// <summary>
        /// Returns the name of the menu item
        /// </summary>
        public override string ToString(){
            if (Size == Size.Large)
                return "Large Meteor Mac and Cheese";
            else if (Size == Size.Medium)
                return "Medium Meteor Mac and Cheese";
            else
                return "Small Meteor Mac and Cheese";
        }

        public override string Description { get { return ToString(); } }

        public override string[] Special { get { return new string[0]; } }
    }
}
