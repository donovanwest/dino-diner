using Xunit;
using DinoDiner.Menu;
using System.Collections.Generic;
namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        //tests the ability to set flavor to cola
        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);
        }

        //tests the ability to set flavor to Cherry
        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);
        }

        //tests the ability to set flavor to Chocolate
        [Fact]
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.Flavor);
        }

        //tests the ability to set flavor to Root Beer
        [Fact]
        public void ShouldBeAbleToSetFlavorToRootBeer()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, soda.Flavor);
        }

        //tests the ability to set flavor to Vanilla
        [Fact]
        public void ShouldBeAbleToSetFlavorToVanilla()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, soda.Flavor);
        }

        //tests the ability to set flavor to Orange
        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, soda.Flavor);
        }

        //tests the ability to set flavor to Lime
        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, soda.Flavor);
        }


        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }

        [Fact]
        public void ShouldBeAbleToRemoveIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }

        [Fact]
        public void ShouldHaveCoreectIngredientsList()
        {
            Sodasaurus soda = new Sodasaurus();
            List<string> ingredients = soda.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Natural Flavors", ingredients);
            Assert.Contains<string>("Cane Sugar", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(112, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(112, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(156, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(208, soda.Calories);
        }

        [Fact]
        public void ChangingToSmallShouldNotifyOfPricePropertyChange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.PropertyChanged(soda, "Price", () => { soda.Size = Size.Small; });
        }

        [Fact]
        public void ChangingToSmallShouldNotifyOfDescriptionPropertyChange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.PropertyChanged(soda, "Description", () => { soda.Size = Size.Small; });
        }

        [Fact]
        public void ChangingToMediumShouldNotifyOfPricePropertyChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Price", () => { soda.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingToMediumShouldNotifyOfDescriptionPropertyChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Description", () => { soda.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingToLargeShouldNotifyOfPricePropertyChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Price", () => { soda.Size = Size.Large; });
        }

        [Fact]
        public void ChangingToLargeShouldNotifyOfDescriptionPropertyChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Description", () => { soda.Size = Size.Large; });
        }

        [Fact]
        public void SettingFlavorToColaShouldNotifyOfDescriptionPropertyChange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.PropertyChanged(soda, "Description", () => { soda.Flavor = SodasaurusFlavor.Cola; });
        }

        [Fact]
        public void SettingFlavorToRootBeerShouldNotifyOfDescriptionPropertyChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Description", () => { soda.Flavor = SodasaurusFlavor.RootBeer; });
        }
        [Fact]
        public void SettingFlavorToCherryShouldNotifyOfDescriptionPropertyChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Description", () => { soda.Flavor = SodasaurusFlavor.Cherry; });
        }
        [Fact]
        public void SettingFlavorToVanillaShouldNotifyOfDescriptionPropertyChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Description", () => { soda.Flavor = SodasaurusFlavor.Vanilla; });
        }
        [Fact]
        public void SettingFlavorToChocolateShouldNotifyOfDescriptionPropertyChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Description", () => { soda.Flavor = SodasaurusFlavor.Chocolate; });
        }
        [Fact]
        public void SettingFlavorToOrangeShouldNotifyOfDescriptionPropertyChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Description", () => { soda.Flavor = SodasaurusFlavor.Orange; });
        }
        [Fact]
        public void SettingFlavorToLimeShouldNotifyOfDescriptionPropertyChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Description", () => { soda.Flavor = SodasaurusFlavor.Lime; });
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Empty(soda.Special);
        }

        [Fact]
        public void DescriptionMatchesToString()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal(soda.Description, soda.ToString());
        }



        [Fact]
        public void SpecialShouldRemoveIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.Collection<string>(soda.Special,
                item => { Assert.Equal("Hold Ice", item); });
        }

    }
}
