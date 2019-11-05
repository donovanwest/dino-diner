/* DinoNuggets.cs
 * Author: Donovan West
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree, INotifyPropertyChanged
    {

        public override event PropertyChangedEventHandler PropertyChanged;

        // Helper funciton for notifiying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private uint Nuggets = 6;
        /// <summary>
        /// returns a list of all the ingredients"
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for(int k = 0; k < Nuggets; k++)
                    ingredients.Add("Chicken Nugget");
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
                if (Nuggets != 6) special.Add((Nuggets - 6) + " Extra Nugget(s)");               
                return special.ToArray();
            }
        }

        /// <summary>
        /// contructs the entree with the correct price and calories
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = Nuggets * 59;
        }
        /// <summary>
        /// adds a nugget
        /// </summary>
        public void AddNugget()
        {
            Nuggets++;
            this.Price += 0.25;
            this.Calories += 59;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Returns the name of the menu item
        /// </summary>
        public override string ToString(){
            return "Dino-Nuggets";
        }
    }
}