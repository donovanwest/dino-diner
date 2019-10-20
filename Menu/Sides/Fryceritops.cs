/* Fryceritops.cs
 * Author: Donovan West
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class Fryceritops : Side
    {
        /// <summary>
        /// blank constructor
        /// </summary>
        public Fryceritops()
        {
     
        }
        /// <summary>
        /// returns a list of all the ingredients"
        /// </summary>
        public override List<string> Ingredients {  get
            {
                return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
            } 
        }
        /// <summary>
        /// returns the calories
        /// </summary>
        public override uint Calories { get {
                if (this.Size == Size.Large)
                {
                    return 480;
                }
                else if (this.Size == Size.Medium)
                {
                    return 365;
                }
                else
                {
                    return 222;
                }
            } set => base.Calories = value; }

        /// <summary>
        /// Returns the name of the menu item
        /// </summary>
        public override string ToString(){
            if (Size == Size.Large)
                return "Large Fryceritops";
            else if (Size == Size.Medium)
                return "Medium Fryceritops";
            else
                return "Small Fryceritops";
        }

        public override string Description { get { return ToString(); } }

        public override string[] Special { get { return new string[0]; } }
    }
}
