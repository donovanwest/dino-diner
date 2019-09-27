using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu.Drinks
{
    public class SodaSaurus : Drink
    {
        public SodaSaurusFlavor Flavor;
        public override double Price { get
            {
                if (Size == Size.Medium)
                {
                    return 2;
                }
                else if (Size == Size.Small)
                {
                    return 1.50;
                }
                else
                {
                    return 2.50;
                }
            }
            set
            {

            }
        }
        public override uint Calories { get
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

        public override List<string> Ingredients { get
            {
                return new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            } }

    }
}
