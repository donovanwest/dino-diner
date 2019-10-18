/* VelociWrap.cs
 * Author: Donovan West
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class VelociWrap : Entree, INotifyPropertyChanged
    {
        private bool RomaineLettuce = true;
        private bool CeasarDressing = true;
        private bool ParmesanCheese = true;

        public event PropertyChangedEventHandler PropertyChanged;

        // Helper funciton for notifiying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// returns a list of all the ingredients"
        /// </summary>
        public override List<string> Ingredients
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


        /// <summary>
        /// gets any special preparation instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!RomaineLettuce) special.Add("Hold Lettuce");
                if (!CeasarDressing) special.Add("Hold Dressing");
                if (!ParmesanCheese) special.Add("Hold Cheese");
                return special.ToArray();
            }
        }

        /// <summary>
        /// contructs the entree with the correct price and calories
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }
        /// <summary>
        /// removes the dressing
        /// </summary>
        public void HoldDressing()
        {
            this.CeasarDressing = false;
            NotifyOfPropertyChange("Special");

        }
        /// <summary>
        /// removes the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.RomaineLettuce = false;
            NotifyOfPropertyChange("Special");

        }
        /// <summary>
        /// removes the cheese
        /// </summary>
        public void HoldCheese()
        {
            this.ParmesanCheese = false;
            NotifyOfPropertyChange("Special");

        }

        /// <summary>
        /// Returns the name of the menu item
        /// </summary>
        public override string ToString(){
            return "Veloci-Wrap";
        }
    }
}