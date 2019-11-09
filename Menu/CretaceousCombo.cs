/* CretaceousCombo.cs
 * Author: Donovan West
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class CretaceousCombo : IMenuItem, IOrderItem
    {
        private Entree entree;
        private Drink drink;
        private Side side;
        public Entree Entree { get { return entree; } set
            {
                entree = value;
                PropsChanged();
            } }
        public Drink Drink
        {
            get { return drink; }
            set
            {
                drink = value;
                PropsChanged();
            }
        }
        public Side Side { get { return side; } set
            {
                side = value;
                PropsChanged();
            } }
        private Size size = Size.Small;

        public event PropertyChangedEventHandler PropertyChanged;

        private CretaceousCombo() { }

        public CretaceousCombo(Entree e)
        {
            entree = e;
            side = new Fryceritops();
            drink = new Sodasaurus();
        }

        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                this.size = value;
                this.Drink.Size = value;
                this.Side.Size = value;
                PropsChanged();
            }
        }

        public double Price
        {
            get
            {
                return Drink.Price + Side.Price + Entree.Price - 0.25;
            }
        }

        public uint Calories
        {
            get
            {
                return Drink.Calories + Side.Calories + Entree.Calories;
            }
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> i = new List<string>();
                i.AddRange(Entree.Ingredients);
                i.AddRange(Side.Ingredients);
                i.AddRange(Drink.Ingredients);                           
                return i;
            }
        }
        /// <summary>
        /// returns the name of the menu item
        /// </summary>
        public override string ToString()
        {
            if (Entree.GetType() == typeof(Brontowurst))
                return "Brontowurst Combo";
            if (Entree.GetType() == typeof(DinoNuggets))
                return "Dino-Nuggets Combo";
            if (Entree.GetType() == typeof(PrehistoricPBJ))
                return "Prehistoric PB&J Combo";
            if (Entree.GetType() == typeof(PterodactylWings))
                return "Pterodactyl Wings Combo";
            if (Entree.GetType() == typeof(SteakosaurusBurger))
                return "Steakosaurus Burger Combo";
            if (Entree.GetType() == typeof(TRexKingBurger))
                return "T-Rex King Burger Combo";
            if (Entree.GetType() == typeof(VelociWrap))
                return "Veloci-Wrap Combo";
            return "How did this happen?";         
        }

        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        public string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                foreach (string special in Entree.Special)
                    specials.Add("---" + special);
                specials.Add(Side.ToString());
                foreach (string special in Side.Special)
                    specials.Add("---" + special);
                specials.Add(Drink.ToString());
                foreach (string special in Side.Special)
                    specials.Add("---" + special);
                return specials.ToArray();
            }
        }

        private void PropsChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Special"));
        }
    }
}
