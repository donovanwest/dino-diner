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
        /// <summary>
        /// All of the items in the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// constructor for the order class
        /// </summary>
        public Order()
        {
            Items.CollectionChanged += OnCollectionChanged;
        }

        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            Items.Add(item);
        }
    }
}
