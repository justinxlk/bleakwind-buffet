﻿/*
 * Author: Zachery Brunner
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(mm);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.False(mm.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.Equal(Size.Small, mm.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Ice = false;
            Assert.False(mm.Ice);
            mm.Ice = true;
            Assert.True(mm.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = Size.Large;
            Assert.Equal(Size.Large, mm.Size);
            mm.Size = Size.Medium;
            Assert.Equal(Size.Medium, mm.Size);
            mm.Size = Size.Small;
            Assert.Equal(Size.Small, mm.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(price, mm.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(cal, mm.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Ice = includeIce;
            if (includeIce == true) Assert.Contains("Add ice", mm.SpecialInstructions);
            else Assert.DoesNotContain("Add ice", mm.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(name, mm.ToString());
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var mm = new MarkarthMilk();

            Assert.PropertyChanged(mm, "Ice", () =>
            {
                mm.Ice = true;
            });

            Assert.PropertyChanged(mm, "Ice", () =>
            {
                mm.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceNotifiesSpecialInstuctionsProperty()
        {
            var mm = new MarkarthMilk();

            Assert.PropertyChanged(mm, "SpecialInstructions", () =>
            {
                mm.Ice = !mm.Ice;
            });
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeNotifiesSizeProperty(Size size)
        {
            var mm = new MarkarthMilk();

            Assert.PropertyChanged(mm, "Size", () =>
            {
                mm.Size = size;
            });

            Assert.PropertyChanged(mm, "Size", () =>
            {
                mm.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeNotifiesPriceProperty(Size size)
        {
            var mm = new MarkarthMilk();

            Assert.PropertyChanged(mm, "Price", () =>
            {
                mm.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeNotifiesCaloriesProperty(Size size)
        {
            var mm = new MarkarthMilk();

            Assert.PropertyChanged(mm, "Calories", () =>
            {
                mm.Size = size;
            });
        }

        [Fact]
        public void IsAssignableFromINotifyPropertyChanged()
        {
            var mm = new MarkarthMilk();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(mm);
        }

        [Fact]
        public void GivesCorrectDesciption()
        {
            var item = new MarkarthMilk();
            string idealDescription = "Hormone-free organic 2% milk.";
            Assert.Equal(idealDescription, item.Description);
        }

    }
}