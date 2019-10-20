using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }

        [Fact]
        public void HoldBunShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () => { trex.HoldBun(); });
        }

        [Fact]
        public void HoldKetchupShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex= new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () => { trex.HoldKetchup(); });
        }

        [Fact]
        public void HoldPickleShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex= new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () => { trex.HoldPickle(); });
        }

        [Fact]
        public void HoldMustardShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex= new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () => { trex.HoldMustard(); });
        }

        [Fact]
        public void HoldMayoShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () => { trex.HoldMayo(); });
        }

        [Fact]
        public void HoldOnionShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () => { trex.HoldOnion(); });
        }

        [Fact]
        public void HoldLettuceShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () => { trex.HoldLettuce(); });
        }

        [Fact]
        public void HoldTomatoShouldNotifyOfSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () => { trex.HoldTomato(); });
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            TRexKingBurger trex= new TRexKingBurger();
            Assert.Empty(trex.Special);
        }

        [Fact]
        public void SpecialShouldHoldBun()
        {
            TRexKingBurger trex= new TRexKingBurger();
            trex.HoldBun();
            Assert.Collection<string>(trex.Special,
                item => { Assert.Equal("Hold Bun", item); });
        }

        [Fact]
        public void SpecialShouldHoldMustard()
        {
            TRexKingBurger trex= new TRexKingBurger();
            trex.HoldMustard();
            Assert.Collection<string>(trex.Special,
                item => { Assert.Equal("Hold Mustard", item); });
        }
        [Fact]
        public void SpecialShouldHoldKetchup()
        {
            TRexKingBurger trex= new TRexKingBurger();
            trex.HoldKetchup();
            Assert.Collection<string>(trex.Special,
                item => { Assert.Equal("Hold Ketchup", item); });
        }
        [Fact]
        public void SpecialShouldHoldPickle()
        {
            TRexKingBurger trex= new TRexKingBurger();
            trex.HoldPickle();
            Assert.Collection<string>(trex.Special,
                item => { Assert.Equal("Hold Pickle", item); });
        }

        [Fact]
        public void SpecialShouldHoldMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.Collection<string>(trex.Special,
                item => { Assert.Equal("Hold Mayo", item); });
        }

        [Fact]
        public void SpecialShouldHoldLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.Collection<string>(trex.Special,
                item => { Assert.Equal("Hold Lettuce", item); });
        }

        [Fact]
        public void SpecialShouldHoldTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.Collection<string>(trex.Special,
                item => { Assert.Equal("Hold Tomato", item); });
        }

        [Fact]
        public void SpecialShouldHoldOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.Collection<string>(trex.Special,
                item => { Assert.Equal("Hold Onion", item); });
        }

        [Fact]
        public void SpecialShouldHoldAllItems()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            trex.HoldKetchup();
            trex.HoldMustard();
            trex.HoldPickle();
            trex.HoldTomato();
            trex.HoldOnion();
            trex.HoldMayo();
            trex.HoldLettuce();
            Assert.Contains<string>("Hold Ketchup", trex.Special);
            Assert.Contains<string>("Hold Mustard", trex.Special);
            Assert.Contains<string>("Hold Bun", trex.Special);
            Assert.Contains<string>("Hold Pickle", trex.Special);
            Assert.Contains<string>("Hold Tomato", trex.Special);
            Assert.Contains<string>("Hold Mayo", trex.Special);
            Assert.Contains<string>("Hold Onion", trex.Special);
            Assert.Contains<string>("Hold Lettuce", trex.Special);
            Assert.Equal<int>(8, trex.Special.Length);
        }

        [Fact]
        public void DescriptionMatchesToString()
        {
            TRexKingBurger trex= new TRexKingBurger();
            Assert.Equal(trex.Description, trex.ToString());
        }

    }

}
