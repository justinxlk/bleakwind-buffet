﻿/*
 * Author: Zachery Brunner
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(chc);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.False(chc.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.False(chc.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.False(chc.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            Assert.Equal(Size.Small, chc.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Ice = true;
            Assert.True(chc.Ice);
            chc.Ice = false;
            Assert.False(chc.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Decaf = true;
            Assert.True(chc.Decaf);
            chc.Decaf = false;
            Assert.False(chc.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.RoomForCream = true;
            Assert.True(chc.RoomForCream);
            chc.RoomForCream = false;
            Assert.False(chc.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Size = Size.Large;
            Assert.Equal(Size.Large, chc.Size);
            chc.Size = Size.Medium;
            Assert.Equal(Size.Medium, chc.Size);
            chc.Size = Size.Small;
            Assert.Equal(Size.Small, chc.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Size = size;
            Assert.Equal(price, chc.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Size = size;
            Assert.Equal(cal, chc.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Ice = includeIce;
            chc.RoomForCream = includeCream;
            if (includeIce == true) Assert.Contains("Add ice", chc.SpecialInstructions);
            else Assert.DoesNotContain("Add ice", chc.SpecialInstructions);
            if (includeCream == true) Assert.Contains("Add cream", chc.SpecialInstructions);
            else Assert.DoesNotContain("Add cream", chc.SpecialInstructions);
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee chc = new CandlehearthCoffee();
            chc.Decaf = decaf;
            chc.Size = size;
            Assert.Equal(name, chc.ToString());
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var chc = new CandlehearthCoffee();

            Assert.PropertyChanged(chc, "Ice", () =>
            {
                chc.Ice = true;
            });

            Assert.PropertyChanged(chc, "Ice", () =>
            {
                chc.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceNotifiesSpecialInstuctionsProperty()
        {
            var chc = new CandlehearthCoffee();

            Assert.PropertyChanged(chc, "SpecialInstructions", () =>
            {
                chc.Ice = !chc.Ice;
            });
        }

        [Fact]
        public void ChangingRoomForCreamNotifiesRoomForCreamProperty()
        {
            var chc = new CandlehearthCoffee();

            Assert.PropertyChanged(chc, "RoomForCream", () =>
            {
                chc.RoomForCream = true;
            });

            Assert.PropertyChanged(chc, "RoomForCream", () =>
            {
                chc.RoomForCream = false;
            });
        }

        [Fact]
        public void ChangingRoomForCreamNotifiesSpecialInstructionsProperty()
        {
            var chc = new CandlehearthCoffee();

            Assert.PropertyChanged(chc, "SpecialInstructions", () =>
            {
                chc.RoomForCream = !chc.RoomForCream;
            });
        }

        [Fact]
        public void ChangingDecafNotifiesDecafProperty()
        {
            var chc = new CandlehearthCoffee();

            Assert.PropertyChanged(chc, "Decaf", () =>
            {
                chc.Decaf = true;
            });

            Assert.PropertyChanged(chc, "Decaf", () =>
            {
                chc.Decaf = false;
            });
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeNotifiesSizeProperty(Size size)
        {
            var chc = new CandlehearthCoffee();

            Assert.PropertyChanged(chc, "Size", () =>
            {
                chc.Size = size;
            });

            Assert.PropertyChanged(chc, "Size", () =>
            {
                chc.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeNotifiesPriceProperty(Size size)
        {
            var chc = new CandlehearthCoffee();

            Assert.PropertyChanged(chc, "Price", () =>
            {
                chc.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeNotifiesCaloriesProperty(Size size)
        {
            var chc = new CandlehearthCoffee();

            Assert.PropertyChanged(chc, "Calories", () =>
            {
                chc.Size = size;
            });
        }

        [Fact]
        public void IsAssignableFromINotifyPropertyChanged()
        {
            var chc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chc);
        }

    }
}
