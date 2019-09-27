using System.Collections.Generic;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu
{
    public class CretaceousCombo
    {
        public Entree Entree;
        public Drink Drink;
        public Side Side;
        private Size size = Size.Small;

        private CretaceousCombo() { }

        public CretaceousCombo(Entree e)
        {
            Entree = e;
            Side = new Fryceritops();
            Drink = new SodaSaurus();
        }

        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                this.size = value;
                this.Drink.Size = value;
                this.Side.Size = value;
            }
        }

        public double Price
        {
            get
            {
                return Drink.Price + Side.Price + Entree.Price - 0.25;
            }
        }

        public uint Calories
        {
            get
            {
                return Drink.Calories + Side.Calories + Entree.Calories;
            }
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> i = new List<string>();
                i.AddRange(Entree.Ingredients);
                i.AddRange(Side.Ingredients);
                i.AddRange(Drink.Ingredients);                           
                return i;
            }
        }
       
	}
}
