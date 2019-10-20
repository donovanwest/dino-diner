using Xunit;
using DinoDiner.Menu;
using System.Collections.Generic;
namespace MenuTest.Drinks
{
    public class WaterTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal<double>(0.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<double>(0.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(0.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(0.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }

        [Fact]
        public void ShouldBeAbleToRemoveIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Water water = new Water();
            Assert.False(water.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }


        [Fact]
        public void ShouldHaveCorrectDefaultIngredientsList()
        {
            Water water = new Water();
            List<string> ingredients = water.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Single(ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectIngredientsListAfterChange()
        {
            Water water = new Water();
            water.AddLemon();
            List<string> ingredients = water.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Lemon", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<double>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<double>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(0, water.Calories);
        }


        [Fact]
        public void ChangingToSmallShouldNotifyOfDescriptionPropertyChange()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.PropertyChanged(water, "Description", () => { water.Size = Size.Small; });
        }


        [Fact]
        public void ChangingToMediumShouldNotifyOfDescriptionPropertyChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Description", () => { water.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingToLargeShouldNotifyOfDescriptionPropertyChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Description", () => { water.Size = Size.Large; });
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            Water water = new Water();
            Assert.Empty(water.Special);
        }

        [Fact]
        public void DescriptionMatchesToString()
        {
            Water water = new Water();
            Assert.Equal(water.Description, water.ToString());
        }

        [Fact]
        public void HoldingIceShouldNotifyOfSpecialPropertyChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Special", () => { water.HoldIce(); });
        }

        [Fact]
        public void AddingLemonShouldNotifyOfSpecialPropertyChange()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Special", () => { water.AddLemon(); });
        }

        [Fact]
        public void SpecialShouldHoldIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.Collection<string>(water.Special,
                item => { Assert.Equal("Hold Ice", item); });
        }

        [Fact]
        public void SpecialShouldAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Collection<string>(water.Special,
                item => { Assert.Equal("Add Lemon", item); });
        }

        [Fact]
        public void SpecialShouldAddAllItems()
        {
            Water water = new Water();
            water.AddLemon();
            water.HoldIce();
            Assert.Contains<string>("Add Lemon", water.Special);
            Assert.Contains<string>("Hold Ice", water.Special);
            Assert.Equal<int>(2, water.Special.Length);
        }
    }
}
