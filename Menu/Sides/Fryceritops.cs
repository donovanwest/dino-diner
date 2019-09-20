using System.Collections.Generic;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {

        public Fryceritops()
        {
     
        }

        public override List<string> Ingredients {  get
            {
                return new List<string>() { "Potato", "Salt", "Vegetable Oil" };
            } 
        }

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
