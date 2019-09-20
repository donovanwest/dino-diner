using System.Collections.Generic;

namespace DinoDiner.Menu.Sides
{
    public class MezzorellaSticks : Side
    {

        public MezzorellaSticks()
        {

        }
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
            }
        }
        public override uint Calories
        {
            get
            {
                if (this.Size == Size.Large)
                {
                    return 720;
                }
                else if (this.Size == Size.Medium)
                {
                    return 610;
                }
                else
                {
                    return 540;
                }
            }
            set => base.Calories = value;
        }
    }
}
