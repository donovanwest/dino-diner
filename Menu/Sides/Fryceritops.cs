/* Fryceritops.cs
 * Author: Donovan West
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Sides
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
    }
}
