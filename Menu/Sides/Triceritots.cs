using System.Collections.Generic;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
    {

        public Triceritots()
        {


        }

        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
            }
        }
        public override uint Calories
        {
            get
            {
                if (this.Size == Size.Large)
                {
                    return 590;
                }
                else if (this.Size == Size.Medium)
                {
                    return 410;
                }
                else
                {
                    return 352;
                }
            }
            set => base.Calories = value;
        }
    }
}
