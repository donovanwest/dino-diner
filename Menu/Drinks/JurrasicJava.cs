using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        public JurrasicJava()
        {
            Ice = false;
        }

        public bool RoomForCream { get; set; } = false;
        public bool Decaf { get; set; } = false;
        public override double Price
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return 0.99;
                }
                else if (Size == Size.Small)
                {
                    return 0.59;
                }
                else
                {
                    return 1.49;
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
                if (Size == Size.Medium)
                {
                    return 4;
                }
                else if (Size == Size.Small)
                {
                    return 2;
                }
                else
                {
                    return 8;
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
                return new List<string>() { "Water", "Coffee" };
            }
        }

        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        public void AddIce()
        {
            Ice = true;
        }

    }
}
