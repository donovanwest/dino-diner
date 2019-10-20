using Xunit;
using DinoDiner.Menu;
using System.Collections.Generic;
namespace MenuTest.Drinks
{
    public class JurrasicjavaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(0.59, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<double>(0.59, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(0.99, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }

        [Fact]
        public void ShouldBeAbleToAddIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIngredientsList()
        {
            JurassicJava java = new JurassicJava();
            List<string> ingredients = java.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Coffee", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.RoomForCream);
        }

        [Fact]
        public void ShouldChangeRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(112, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<double>(112, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(156, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(208, java.Calories);
        }

        [Fact]
        public void ChangingToSmallShouldNotifyOfPricePropertyChange()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.PropertyChanged(java, "Price", () => { java.Size = Size.Small; });
        }

        [Fact]
        public void ChangingToSmallShouldNotifyOfDescriptionPropertyChange()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.PropertyChanged(java, "Description", () => { java.Size = Size.Small; });
        }

        [Fact]
        public void ChangingToMediumShouldNotifyOfPricePropertyChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Price", () => { java.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingToMediumShouldNotifyOfDescriptionPropertyChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Description", () => { java.Size = Size.Medium; });
        }

        [Fact]
        public void ChangingToLargeShouldNotifyOfPricePropertyChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Price", () => { java.Size = Size.Large; });
        }

        [Fact]
        public void ChangingToLargeShouldNotifyOfDescriptionPropertyChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Description", () => { java.Size = Size.Large; });
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            JurassicJava java = new JurassicJava();
            Assert.Empty(java.Special);
        }

        [Fact]
        public void DescriptionMatchesToString()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal(java.Description, java.ToString());
        }

        [Fact]
        public void AddingIceShouldNotifyOfSpecialPropertyChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () => {java.AddIce();});
        }

        [Fact]
        public void MakingDecafShouldNotifyOfSpecialPropertyChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () => { java.MakeDecaf(); });
        }

        [Fact]
        public void LeavingRoomForCreamShouldNotifyOfSpecialPropertyChange()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () => { java.LeaveRoomForCream(); });
        }

        [Fact]
        public void SpecialShouldAddIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.Collection<string>(java.Special,
                item => { Assert.Equal("Add Ice", item); });
        }

        [Fact]
        public void SpecialShouldMakeDecaf()
        {
            JurassicJava java = new JurassicJava();
            java.MakeDecaf();
            Assert.Collection<string>(java.Special,
                item => { Assert.Equal("Decaf", item); });
        }

        [Fact]
        public void SpecialShouldLeaveRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.Collection<string>(java.Special,
                item => { Assert.Equal("Leave Room For Cream", item); });
        }

        [Fact]
        public void SpecialShouldHoldAllItems()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            java.MakeDecaf();
            java.LeaveRoomForCream();
            Assert.Contains<string>("Add Ice",java.Special);
            Assert.Contains<string>("Decaf",java.Special);
            Assert.Contains<string>("Leave Room For Cream",java.Special);
            Assert.Equal<int>(3,java.Special.Length);
        }
    }
}
