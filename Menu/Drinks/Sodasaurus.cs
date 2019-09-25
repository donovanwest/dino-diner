using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Sides;
namespace DinoDiner.Menu.Drinks
{
    public class SodaSaurus
    {
        public SodaSaurusFlavor Flavor;
        private Size size;
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                if (size == Size.Medium)
                {
                    Price = 2;
                    Calories = 156;
                }
                if (size == Size.Small)
                {
                    Price = 1.50;
                    Calories = 112;
                }
                if (size == Size.Large)
                {
                    Price = 2.50;
                    Calories = 208;
                }
            }
        }
        public double Price = 1.50;
        public uint Calories = 112;

    }
}
