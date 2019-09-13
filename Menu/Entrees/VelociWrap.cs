using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap
    {
        private bool FlourTortilla = true;
        private bool ChickenBreast = true;
        private bool RomaineLettuce = true;
        private bool CeasarDressing = true;
        private bool ParmesanCheese = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (RomaineLettuce) ingredients.Add("Romaine Lettuce");
                if (CeasarDressing) ingredients.Add("Ceasar Dressing");
                if (ParmesanCheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        public void HoldDressing()
        {
            this.CeasarDressing = false;
        }

        public void HoldLettuce()
        {
            this.RomaineLettuce = false;
        }

        public void HoldCheese()
        {
            this.ParmesanCheese = false;
        }
    }
}