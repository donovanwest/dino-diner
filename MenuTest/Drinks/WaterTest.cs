using Xunit;
using DinoDiner.Menu.Drinks;
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
    }
}
