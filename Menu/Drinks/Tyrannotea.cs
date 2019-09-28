using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        public bool Lemon { get; set; } = false;
        public bool Sweet { get; set; } = false;
        public override double Price
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return 1.49;
                }
                else if (Size == Size.Small)
                {
                    return 0.99;
                }
                else
                {
                    return 1.99;
                }
            }
            set
            {

            }
        }
        public override uint Calories
        {
            get
            {
                uint c = 1;
                if (Sweet) c = 2;
                if (Size == Size.Medium)
                {
                    return c*16;
                }
                else if (Size == Size.Small)
                {
                    return c*8;
                }
                else
                {
                    return c*32;
                }
            }
            set
            {

            }
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> i = new List<string>() { "Water", "Tea" };
                if (Sweet) i.Add("Cane Sugar");
                if (Lemon) i.Add("Lemon");
                return i;
            }
        }

        public void AddLemon()
        {
            Lemon = true;
        }

        public void AddSweetener()
        {
            Sweet = true;
        }
    }
}
