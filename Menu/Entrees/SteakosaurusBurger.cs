/* SteakosaurusBurger.cs
 * Author: Donovan West
 */
using System.Collections.Generic;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    public class SteakosaurusBurger : Entree, INotifyPropertyChanged
    {
        private bool WholeWheatBun = true;
        private bool Pickle = true;
        private bool Ketchup = true;
        private bool Mustard = true;

        public override event PropertyChangedEventHandler PropertyChanged;

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
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (WholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (Pickle) ingredients.Add("Pickle");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");
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
                if (!WholeWheatBun) special.Add("Hold Bun");
                if (!Pickle) special.Add("Hold Pickle");
                if (!Ketchup) special.Add("Hold Ketchup");
                if (!Mustard) special.Add("Hold Mustard");
                return special.ToArray();
            }
        }
        /// <summary>
        /// contructs the entree with the correct price and calories
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }
        /// <summary>
        /// removes the bun
        /// </summary>
        public void HoldBun()
        {
            this.WholeWheatBun = false;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// removes the pickles
        /// </summary>
        public void HoldPickle()
        {
            this.Pickle = false;
            NotifyOfPropertyChange("Special");

        }
        /// <summary>
        /// removes the catsup
        /// </summary>
        public void HoldKetchup()
        {
            this.Ketchup = false;
            NotifyOfPropertyChange("Special");

        }
        /// <summary>
        /// removes the mustard
        /// </summary>
        public void HoldMustard()
        {
            this.Mustard = false;
            NotifyOfPropertyChange("Special");

        }

        /// <summary>
        /// Returns the name of the menu item
        /// </summary>
        public override string ToString(){
            return "Steakosaurus Burger";
        }
    }

}