using Xunit;
using DinoDiner.Menu;
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


        [Fact]
        public void ChangingToSmallShouldNotifyOfPricePropertyChange()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.PropertyChanged(tea, "Price", () => { tea.Size = Size.Small; });
        }

        [Fact]
        public void ChangingToSmallShouldNotifyOfDescriptionPropertyChange()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.PropertyChanged(tea, "Description", () => { tea.Size = Size.Small; });
        }

        [Fact]
        public void ChangingToMediumShouldNotifyOfPricePropertyChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Price", () => { tea.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingToMediumShouldNotifyOfDescriptionPropertyChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Description", () => { tea.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingToLargeShouldNotifyOfPricePropertyChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Price", () => { tea.Size = Size.Large; });
        }

        [Fact]
        public void ChangingToLargeShouldNotifyOfDescriptionPropertyChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Description", () => { tea.Size = Size.Large; });
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Empty(tea.Special);
        }

        [Fact]
        public void DescriptionMatchesToString()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal(tea.Description, tea.ToString());
        }

        [Fact]
        public void HoldingIceShouldNotifyOfSpecialPropertyChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () => { tea.HoldIce(); });
        }

        [Fact]
        public void AddingSweetnerShouldNotifyOfSpecialPropertyChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () => { tea.AddSweetener(); });
        }

        [Fact]
        public void AddingLemonShouldNotifyOfSpecialPropertyChange()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () => { tea.AddLemon(); });
        }

        [Fact]
        public void SpecialShouldHoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.Collection<string>(tea.Special,
                item => { Assert.Equal("Hold Ice", item); });
        }

        [Fact]
        public void SpecialShouldAddSweetner()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweetener();
            Assert.Collection<string>(tea.Special,
                item => { Assert.Equal("Add Sweetener", item); });
        }

        [Fact]
        public void SpecialShouldAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Collection<string>(tea.Special,
                item => { Assert.Equal("Add Lemon", item); });
        }

        [Fact]
        public void SpecialShouldAddAllItems()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            tea.AddSweetener();
            tea.HoldIce();
            Assert.Contains<string>("Add Lemon", tea.Special);
            Assert.Contains<string>("Add Sweetener", tea.Special);
            Assert.Contains<string>("Hold Ice", tea.Special);
            Assert.Equal<int>(3, tea.Special.Length);
        }
    }
}
