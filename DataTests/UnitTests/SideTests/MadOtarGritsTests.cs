﻿/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void IsASide()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(mog);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.Equal(Size.Small, mog.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = Size.Large;
            Assert.Equal(Size.Large, mog.Size);
            mog.Size = Size.Medium;
            Assert.Equal(Size.Medium, mog.Size);
            mog.Size = Size.Small;
            Assert.Equal(Size.Small, mog.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits mog = new MadOtarGrits();
            Assert.Empty(mog.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = size;
            Assert.Equal(price, mog.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = size;
            Assert.Equal(calories, mog.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = size;
            Assert.Equal(name, mog.ToString());
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeNotifiesSizeProperty(Size size)
        {
            var mog = new MadOtarGrits();

            Assert.PropertyChanged(mog, "Size", () =>
            {
                mog.Size = size;
            });

            Assert.PropertyChanged(mog, "Size", () =>
            {
                mog.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeNotifiesPriceProperty(Size size)
        {
            var mog = new MadOtarGrits();

            Assert.PropertyChanged(mog, "Price", () =>
            {
                mog.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void ChangingSizeNotifiesCaloriesProperty(Size size)
        {
            var mog = new MadOtarGrits();

            Assert.PropertyChanged(mog, "Calories", () =>
            {
                mog.Size = size;
            });
        }

        [Fact]
        public void IsAssignableFromINotifyPropertyChanged()
        {
            var mog = new MadOtarGrits();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(mog);
        }

        [Fact]
        public void GivesCorrectDesciption()
        {
            var item = new MadOtarGrits();
            string idealDescription = "Cheesey Grits.";
            Assert.Equal(idealDescription, item.Description);
        }

    }
}