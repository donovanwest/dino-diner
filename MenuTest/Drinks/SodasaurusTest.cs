using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Sides;
namespace DinoDiner.MenuTest.Sides
{
    public class SodasaurusTest
    {
        //tests the ability to set flavor to cola
        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Flavor = SodaSaurusFlavor.Cola;
            Assert.Equal<SodaSaurusFlavor>(SodaSaurusFlavor.Cola, soda.Flavor);
        }

        //tests the ability to set flavor to Cherry
        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Flavor = SodaSaurusFlavor.Cherry;
            Assert.Equal<SodaSaurusFlavor>(SodaSaurusFlavor.Cherry, soda.Flavor);
        }

        //tests the ability to set flavor to Chocolate
        [Fact]
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Flavor = SodaSaurusFlavor.Chocolate;
            Assert.Equal<SodaSaurusFlavor>(SodaSaurusFlavor.Chocolate, soda.Flavor);
        }

        //tests the ability to set flavor to Root Beer
        [Fact]
        public void ShouldBeAbleToSetFlavorToRootBeer()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Flavor = SodaSaurusFlavor.RootBeer;
            Assert.Equal<SodaSaurusFlavor>(SodaSaurusFlavor.RootBeer, soda.Flavor);
        }

        //tests the ability to set flavor to Vanilla
        [Fact]
        public void ShouldBeAbleToSetFlavorToVanilla()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Flavor = SodaSaurusFlavor.Vanilla;
            Assert.Equal<SodaSaurusFlavor>(SodaSaurusFlavor.Vanilla, soda.Flavor);
        }

        //tests the ability to set flavor to Orange
        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Flavor = SodaSaurusFlavor.Orange;
            Assert.Equal<SodaSaurusFlavor>(SodaSaurusFlavor.Orange, soda.Flavor);
        }

        //tests the ability to set flavor to Lime
        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Flavor = SodaSaurusFlavor.Lime;
            Assert.Equal<SodaSaurusFlavor>(SodaSaurusFlavor.Lime, soda.Flavor);
        }


        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SodaSaurus soda = new SodaSaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            SodaSaurus soda = new SodaSaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
        }
    }
}
