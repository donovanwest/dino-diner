using System.Collections.Generic;

namespace DinoDiner.Menu.Sides
{
    public class MeteorMacAndCheese : Side
    {

        public MeteorMacAndCheese()
        {
           
        }

        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
            }
        }

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
    }
}
