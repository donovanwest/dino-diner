/* Side.cs
 * Author: Donovan West
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Side : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // Helper funciton for notifiying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price {
            get
            {
                if (this.Size == Size.Large)
                {
                    return  1.95;
                }
                else if (this.Size == Size.Medium)
                {
                    return  1.45;
                }
                else
                {
                    return  0.99;
                }
            }
            set {

            } }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public virtual uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public Size Size { get { return size; } set
            {
                size = value;
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
            }
        }

        private Size size;

        public virtual string Description { get; }

        public virtual string[] Special
        {
            get { return new string[0]; }
        }
    }
}
