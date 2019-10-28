/* Order.cs
 * Author: Donovan West
 */ 
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// The subtotal for the whole order
        /// </summary>
        public double SubtotalCost { get
            {
                double subtotal = 0;
                foreach(IOrderItem p in Items){
                    subtotal += p.Price;
                }
                if (subtotal < 0)
                    subtotal = 0;
                return subtotal;
            }}
        /// <summary>
        /// The current sales tax rate. Defaults to 0.07
        /// </summary>
        public double SalesTaxRate { get; private set; } = 0.07;
        /// <summary>
        /// The cost added because of the sales tax
        /// </summary>
        public double SalesTaxCost { get { return Math.Round(SubtotalCost * SalesTaxRate,2); } }
        /// <summary>
        /// The total cost, the subtotal plus the sales tax
        /// </summary>
        public double TotalCost { get {
                return Math.Round(SubtotalCost + SalesTaxCost, 2); } }

        private List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// All of the items in the order
        /// </summary>
        public IOrderItem[] Items { get { return items.ToArray(); } }
        /// <summary>
        /// The PropertyChanged event hander, notifies when an order property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// constructor for the order class
        /// </summary>
        public Order()
        {
            //Items.CollectionChanged += OnCollectionChanged;
        }
        /// <summary>
        /// Adds and item to the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            PropertiesChanged();

        }
        /// <summary>
        /// Removes and item from the list
        /// </summary>
        /// <param name="item"></param>
        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed == true)
            {
                PropertiesChanged();
            }
            return removed;
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            PropertiesChanged();
        }

        private void PropertiesChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        public bool Contains(IOrderItem item)
        {
            return items.Contains(item);
        }
        /*
                /// <summary>
                /// Notifies that the sales tax, subtotal, and total properties have changed due to a change in the items
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="args"></param>
                private void OnCollectionChanged(object sender, EventArgs args)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
                }

                /// <summary>
                /// Adds an item to the items field
                /// </summary>
                /// <param name="item">the item to be added</param>
                public void Add(IOrderItem item)
                {
                    item.PropertyChanged += OnCollectionChanged;
                    Items.Add(item);
                }
        */
    }
}
