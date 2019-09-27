using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public abstract class Drink
    {
        public Size Size { get; set; }

        public virtual double Price { get; set; }

        public virtual uint Calories { get; set; }

        public virtual List<string> Ingredients { get; }

        public bool Ice = true;

        public void HoldIce()
        {
            Ice = false;
        }
    }
}
