using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    public class Order
    {
        public double SubtotalCost { get; private set; }

        public double SalesTaxRate { get; private set; }

        public double SalesTaxCost { get { return SubtotalCost * SalesTaxRate; } }

        public double TotalCost { get { return SubtotalCost + SalesTaxCost; } }
        //ObservableCollection<IOrderItem>
    }
}
