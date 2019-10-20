/*Jurrasicjava.cs
 * Author: Donovan West
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class JurassicJava : Drink, INotifyPropertyChanged
    {
        public JurassicJava()
        {
            this.HoldIce();
        }
        /// <summary>
        /// Whether or not there is room for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;
        /// <summary>
        /// Whether or not the coffe is decaf
        /// </summary>
        public bool Decaf { get; set; } = false;
        /// <summary>
        /// returns the price
        /// </summary>
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
        /// <summary>
        /// the calories of the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return 156;
                }
                else if (Size == Size.Small)
                {
                    return 112;
                }
                else
                {
                    return 208;
                }
            }
            set
            {

            }
        }
        /// <summary>
        /// the list of ingredients in the coffee
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Coffee" };
            }
        }
        /// <summary>
        /// leaves from for cream
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// adds ice
        /// </summary>
        public void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChange("Special");
        }

        public void MakeDecaf()
        {
            Decaf = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Returns the name of the menu item
        /// </summary>
        public override string ToString(){
            if (Size == Size.Large)
            {
                if (!Decaf)
                    return "Large Jurassic Java";
                else
                    return "Large Decaf Jurassic Java";
            }
            else if (Size == Size.Medium)
                if (!Decaf)
                    return "Medium Jurassic Java";
                else
                    return "Medium Decaf Jurassic Java";
            else
                if (!Decaf)
                return "Small Jurassic Java";
            else
                return "Small Decaf Jurassic Java";
        }

        /// <summary>
        /// gets any special preparation instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (RoomForCream) special.Add("Leave Room For Cream");
                if (Ice) special.Add("Add Ice");
                if (Decaf) special.Add("Decaf");
                return special.ToArray();
            }
        }

        public override string Description { get { return this.ToString(); } }
    }
}
