/*Water.cs
 * Author: Donovan West
 */ 
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Water : Drink
    {
        /// <summary>
        /// whether or not there is lemon
        /// </summary>
        public bool Lemon { get; set; }
        public override double Price
        {
            get
            {
                return 0.10;
            }
            set
            {

            }
        }
        public override uint Calories
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> i = new List<string>() { "Water" };
                if (Lemon) i.Add("Lemon");
                return i;
            }
        }

        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Returns the name of the menu item
        /// </summary>
        public override string ToString(){
            if (Size == Size.Large)
                return "Large Water";
            else if (Size == Size.Medium)
                return "Medium Water";
            else
                return "Small Water";
        }

        /// <summary>
        /// gets any special preparation instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                if (Lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }

        public override string Description { get { return this.ToString(); } }


    }
}
