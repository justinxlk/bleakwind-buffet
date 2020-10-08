﻿/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        [Fact]
        public void IsAnEntree()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(bb);
        }
        
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Bun = false;
            Assert.False(bb.Bun);
            bb.Bun = true;
            Assert.True(bb.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Ketchup = false;
            Assert.False(bb.Ketchup);
            bb.Ketchup = true;
            Assert.True(bb.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Mustard = false;
            Assert.False(bb.Mustard);
            bb.Mustard = true;
            Assert.True(bb.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Pickle = false;
            Assert.False(bb.Pickle);
            bb.Pickle = true;
            Assert.True(bb.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Cheese = false;
            Assert.False(bb.Cheese);
            bb.Cheese = true;
            Assert.True(bb.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal(6.32, bb.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal(743.0, bb.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Bun = includeBun;
            bb.Ketchup = includeKetchup;
            bb.Mustard = includeMustard;
            bb.Pickle = includePickle;
            bb.Cheese = includeCheese;
            if (includeBun == false) Assert.Contains("Hold bun", bb.SpecialInstructions);
            else Assert.DoesNotContain("Hold bun", bb.SpecialInstructions);
            if (includeKetchup == false) Assert.Contains("Hold ketchup", bb.SpecialInstructions);
            else Assert.DoesNotContain("Hold ketchup", bb.SpecialInstructions);
            if (includeMustard == false) Assert.Contains("Hold mustard", bb.SpecialInstructions);
            else Assert.DoesNotContain("Hold mustard", bb.SpecialInstructions);
            if (includePickle == false) Assert.Contains("Hold pickle", bb.SpecialInstructions);
            else Assert.DoesNotContain("Hold pickle", bb.SpecialInstructions);
            if (includeCheese == false) Assert.Contains("Hold cheese", bb.SpecialInstructions);
            else Assert.DoesNotContain("Hold cheese", bb.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", bb.ToString());
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "Bun", () =>
            {
                bb.Bun = true;
            });

            Assert.PropertyChanged(bb, "Bun", () =>
            {
                bb.Bun = false;
            });
        }

        [Fact]
        public void ChangingBunNotifiesSpecialInstructionsProperty()
        {
            var bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Bun = !bb.Bun;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "Ketchup", () =>
            {
                bb.Ketchup = true;
            });

            Assert.PropertyChanged(bb, "Ketchup", () =>
            {
                bb.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesSpecialInstructionsProperty()
        {
            var bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Ketchup = !bb.Ketchup;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "Mustard", () =>
            {
                bb.Mustard = true;
            });

            Assert.PropertyChanged(bb, "Mustard", () =>
            {
                bb.Mustard = false;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesSpecialInstructionsProperty()
        {
            var bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Mustard = !bb.Mustard;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "Pickle", () =>
            {
                bb.Pickle = true;
            });

            Assert.PropertyChanged(bb, "Pickle", () =>
            {
                bb.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesSpecialInstructionsProperty()
        {
            var bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Pickle = !bb.Pickle;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "Cheese", () =>
            {
                bb.Cheese = true;
            });

            Assert.PropertyChanged(bb, "Cheese", () =>
            {
                bb.Cheese = false;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesSpecialInstructionsProperty()
        {
            var bb = new BriarheartBurger();

            Assert.PropertyChanged(bb, "SpecialInstructions", () =>
            {
                bb.Cheese = !bb.Cheese;
            });
        }

        [Fact]
        public void IsAssignableFromINotifyPropertyChanged()
        {
            var bb = new BriarheartBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(bb);
        }

    }
}