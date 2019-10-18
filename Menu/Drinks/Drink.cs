/*Drink.cs
 * Author: Donovan West
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        public virtual event PropertyChangedEventHandler PropertyChanged;

        // Helper funciton for notifiying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// size of the drink, either Small, Medium, or Large
        /// </summary>
        public Size Size { get; set; }
        /// <summary>
        /// the price of the drink
        /// </summary>
        public virtual double Price { get; set; }
        /// <summary>
        /// the calories of the drink
        /// </summary>
        public virtual uint Calories { get; set; }
        /// <summary>
        /// the list of ingredients included in the drink
        /// </summary>
        public virtual List<string> Ingredients { get; }
        /// <summary>
        /// whether or not there is ice in the drink
        /// </summary>
        public bool Ice = true;
        /// <summary>
        /// removes ice from the drink
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChange("Special");
        }

        public virtual string Description { get { return this.ToString(); } }

        public virtual string[] Special
        {
            get { return new string[0]; }
        }
    }
}
