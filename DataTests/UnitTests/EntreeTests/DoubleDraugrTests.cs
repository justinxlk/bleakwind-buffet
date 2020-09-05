﻿/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {   
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDrauger dd = new DoubleDrauger();
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDrauger dd = new DoubleDrauger();
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDrauger dd = new DoubleDrauger();
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDrauger dd = new DoubleDrauger();
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDrauger dd = new DoubleDrauger();
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDrauger dd = new DoubleDrauger();
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDrauger dd = new DoubleDrauger();
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDrauger dd = new DoubleDrauger();
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDrauger dd = new DoubleDrauger();
            dd.Bun = false;
            Assert.False(dd.Bun);
            dd.Bun = true;
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDrauger dd = new DoubleDrauger();
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDrauger dd = new DoubleDrauger();
            dd.Mustard = false;
            Assert.False(dd.Mustard);
            dd.Mustard = true;
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDrauger dd = new DoubleDrauger();
            dd.Pickle = false;
            Assert.False(dd.Pickle);
            dd.Pickle = true;
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDrauger dd = new DoubleDrauger();
            dd.Cheese = false;
            Assert.False(dd.Cheese);
            dd.Cheese = true;
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDrauger dd = new DoubleDrauger();
            dd.Tomato = false;
            Assert.False(dd.Tomato);
            dd.Tomato = true;
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDrauger dd = new DoubleDrauger();
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDrauger dd = new DoubleDrauger();
            dd.Mayo = false;
            Assert.False(dd.Mayo);
            dd.Mayo = true;
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDrauger dd = new DoubleDrauger();
            Assert.Equal(7.32, dd.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDrauger dd = new DoubleDrauger();
            Assert.Equal(843.0, dd.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDrauger dd = new DoubleDrauger();
            dd.Bun = includeBun;
            dd.Ketchup = includeKetchup;
            dd.Mustard = includeMustard;
            dd.Pickle = includePickle;
            dd.Cheese = includeCheese;
            dd.Tomato = includeMustard;
            dd.Lettuce = includePickle;
            dd.Mayo = includeCheese;
            if (includeBun == false) Assert.Contains("Hold bun", dd.SpecialInstructions);
            else Assert.DoesNotContain("Hold bun", dd.SpecialInstructions);
            if (includeKetchup == false) Assert.Contains("Hold ketchup", dd.SpecialInstructions);
            else Assert.DoesNotContain("Hold ketchup", dd.SpecialInstructions);
            if (includeMustard == false) Assert.Contains("Hold mustard", dd.SpecialInstructions);
            else Assert.DoesNotContain("Hold mustard", dd.SpecialInstructions);
            if (includePickle == false) Assert.Contains("Hold pickle", dd.SpecialInstructions);
            else Assert.DoesNotContain("Hold pickle", dd.SpecialInstructions);
            if (includeCheese == false) Assert.Contains("Hold cheese", dd.SpecialInstructions);
            else Assert.DoesNotContain("Hold cheese", dd.SpecialInstructions);
            if (includeLettuce == false) Assert.Contains("Hold lettuce", dd.SpecialInstructions);
            else Assert.DoesNotContain("Hold lettuce", dd.SpecialInstructions);
            if (includeTomato == false) Assert.Contains("Hold tomato", dd.SpecialInstructions);
            else Assert.DoesNotContain("Hold tomato", dd.SpecialInstructions);
            if (includeMayo == false) Assert.Contains("Hold mayo", dd.SpecialInstructions);
            else Assert.DoesNotContain("Hold mayo", dd.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDrauger dd = new DoubleDrauger();
            Assert.Equal("Double Drauger", dd.ToString());
        }
    }
}