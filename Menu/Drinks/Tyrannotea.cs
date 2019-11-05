/*Tyrannotea.cs
 * Author: Donovan West
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// Whether or not there is a lemon
        /// </summary>
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// Whether or not the tea is sweet
        /// </summary>
        public bool Sweet { get; set; } = false;
        /// <summary>
        /// the price of the tea
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return 1.49;
                }
                else if (Size == Size.Small)
                {
                    return 0.99;
                }
                else
                {
                    return 1.99;
                }
            }
            set
            {

            }
        }
        /// <summary>
        /// the Calories of the tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint c = 1;
                if (Sweet) c = 2;
                if (Size == Size.Medium)
                {
                    return c*16;
                }
                else if (Size == Size.Small)
                {
                    return c*8;
                }
                else
                {
                    return c*32;
                }
            }
            set
            {

            }
        }
        /// <summary>
        /// the list of ingredients of the tea""
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> i = new List<string>() { "Water", "Tea" };
                if (Sweet) i.Add("Cane Sugar");
                if (Lemon) i.Add("Lemon");
                return i;
            }
        }
        /// <summary>
        /// Adds lemon
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChange("Special");
        }
        /// <summary>
        /// adds sweetener
        /// </summary>
        public void AddSweetener()
        {
            Sweet = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Description");
        }

        /// <summary>
        /// Returns the name of the menu item
        /// </summary>
        public override string ToString(){
            if (Sweet)
                return $"{Size} Sweet Tyrannotea";
            else
                return $"{Size} Tyrannotea";

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
                if (Sweet) special.Add("Add Sweetener");
                return special.ToArray();
            }
        }

        public override string Description { get { return this.ToString(); } }

    }
}
