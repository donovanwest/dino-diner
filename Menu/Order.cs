/* Order.cs
 * Author: Donovan West
 */ 
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    public class Order
    {
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

        public double SalesTaxRate { get; private set; } = 0.07;

        public double SalesTaxCost { get { return SubtotalCost * SalesTaxRate; } }

        public double TotalCost { get { return SubtotalCost + SalesTaxCost; } }

        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

    }
}
