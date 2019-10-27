/* OrderTests.cs
 * Author: Donovan West
 */
using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;
using System.ComponentModel;

namespace MenuTest.Entrees
{
    public class OrderTests
    {
        [Fact]
        public void ShouldBeAbleToCreateAnOrder()
        {
            Order o = new Order();
            o.Items.Add(new Brontowurst());
            o.Items.Add(new JurassicJava());
            o.Items.Add(new Fryceritops());
            o.Items.Add(new CretaceousCombo(new DinoNuggets()));
        }

        [Fact]
        public void ShouldHaveCorrectSubtotal()
        {
            Order o = new Order();
            o.Items.Add(new Brontowurst());
            o.Items.Add(new JurassicJava());
            o.Items.Add(new Fryceritops());
            o.Items.Add(new CretaceousCombo(new DinoNuggets()));
            Assert.Equal<double>(13.43, o.SubtotalCost);
        }

        [Fact]
        public void ShouldHaveCorrectSalesTax()
        {
            Order o = new Order();
            o.Items.Add(new Brontowurst());
            o.Items.Add(new JurassicJava());
            o.Items.Add(new Fryceritops());
            o.Items.Add(new CretaceousCombo(new DinoNuggets()));
            Assert.Equal<double>(13.43*o.SalesTaxRate, o.SalesTaxCost);
        }

        [Fact]
        public void ShouldHaveCorrectTotal()
        {
            Order o = new Order();
            o.Items.Add(new Brontowurst());
            o.Items.Add(new JurassicJava());
            o.Items.Add(new Fryceritops());
            o.Items.Add(new CretaceousCombo(new DinoNuggets()));
            Assert.Equal<double>(13.43 + o.SalesTaxCost, o.TotalCost);
        }

        [Fact]
        public void SubtotalCantBeNegative()
        {
            Order order = new Order();
            order.Items.Add(new Brontowurst());
            order.Items.Add(new TestCoupon());
            Assert.True(order.SubtotalCost >= 0);
        }


    }

    class TestCoupon : IOrderItem
    {
        public double Price { get; } = -1000;
        public string Description => throw new System.NotImplementedException();
        public string[] Special => throw new System.NotImplementedException();

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
