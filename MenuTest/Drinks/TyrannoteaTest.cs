using Xunit;
using DinoDiner.Menu.Drinks;
using System.Collections.Generic;
namespace MenuTest.Drinks
{
    public class TyannoteaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<double>(0.99, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        [Fact]
        public void ShouldBeAbleToRemoveIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
        }     

        [Fact]
        public void ShouldBeAbleToAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSweetener()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Sweet);
        }

        [Fact]
        public void ShouldBeAbleToAddSweetener()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweetener();
            Assert.True(tea.Sweet);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIngredientsList()
        {
            Tyrannotea tea = new Tyrannotea();
            List<string> ingredients = tea.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Tea", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectIngredientsListAfterChange()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            tea.AddSweetener();
            List<string> ingredients = tea.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Tea", ingredients);
            Assert.Contains<string>("Lemon", ingredients);
            Assert.Contains<string>("Cane Sugar", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<double>(8, tea.Calories);
            tea.AddSweetener();
            Assert.Equal<double>(16, tea.Calories);
            

        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(16, tea.Calories);
            tea.AddSweetener();
            Assert.Equal<double>(32, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(32, tea.Calories);
            tea.AddSweetener();
            Assert.Equal<double>(64, tea.Calories);
        }
    }
}
