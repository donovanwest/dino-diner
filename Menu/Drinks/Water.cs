using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {

        public bool Lemon { get; set; }
        public override double Price
        {
            get
            {
                return 0.10;
            }
            set
            {

            }
        }
        public override uint Calories
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> i = new List<string>() { "Water" };
                if (Lemon) i.Add("Lemon");
                return i;
            }
        }

        public void AddLemon()
        {
            Lemon = true;
        }

    }
}
