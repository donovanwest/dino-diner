/* Brontowurst.cs
 * Author: Donovan West
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Brontowurst : Entree, INotifyPropertyChanged
    {
        private bool WholeWheatBun = true;
        private bool Peppers = true;
        private bool Onions = true;

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
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (WholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (Peppers) ingredients.Add("Peppers");
                if (Onions) ingredients.Add("Onion");
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
                if (!Peppers) special.Add("Hold Peppers");
                if (!Onions) special.Add("Hold Onions");
                return special.ToArray();
            }
        }

        /// <summary>
        /// contructs the entree with the correct price and calories
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
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
        /// removes the peppers
        /// </summary>
        public void HoldPeppers()
        {
            this.Peppers = false;
            NotifyOfPropertyChange("Special");

        }
        /// <summary>
        /// removes the onion
        /// </summary>
        public void HoldOnion()
        {
            this.Onions = false;
            NotifyOfPropertyChange("Special");

        }

        /// <summary>
        /// Returns the name of the menu item
        /// </summary>
        public override string ToString(){
            return "Brontowurst";
        }
    }
}