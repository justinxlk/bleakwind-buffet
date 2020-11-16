/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void IsAnEntree()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(goo);
        }

        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = false;
            Assert.False(goo.Broccoli);
            goo.Broccoli = true;
            Assert.True(goo.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Mushrooms = false;
            Assert.False(goo.Mushrooms);
            goo.Mushrooms = true;
            Assert.True(goo.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Tomato = false;
            Assert.False(goo.Tomato);
            goo.Tomato = true;
            Assert.True(goo.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Cheddar = false;
            Assert.False(goo.Cheddar);
            goo.Cheddar = true;
            Assert.True(goo.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal(4.57, goo.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal(404.0, goo.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = includeBroccoli;
            if (includeBroccoli == false) Assert.Contains("Hold broccoli", goo.SpecialInstructions);
            else Assert.DoesNotContain("Hold broccoli", goo.SpecialInstructions);
            goo.Mushrooms = includeMushrooms;
            if (includeMushrooms == false) Assert.Contains("Hold mushrooms", goo.SpecialInstructions);
            else Assert.DoesNotContain("Hold mushrooms", goo.SpecialInstructions);
            goo.Tomato = includeTomato;
            if (includeTomato == false) Assert.Contains("Hold tomato", goo.SpecialInstructions);
            else Assert.DoesNotContain("Hold tomato", goo.SpecialInstructions);
            goo.Cheddar = includeCheddar;
            if (includeCheddar == false) Assert.Contains("Hold cheddar", goo.SpecialInstructions);
            else Assert.DoesNotContain("Hold cheddar", goo.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", goo.ToString());
        }

        [Fact]
        public void ChangingBroccoliNotifiesBroccoliProperty()
        {
            var goo = new GardenOrcOmelette();

            Assert.PropertyChanged(goo, "Broccoli", () =>
            {
                goo.Broccoli = true;
            });

            Assert.PropertyChanged(goo, "Broccoli", () =>
            {
                goo.Broccoli = false;
            });
        }

        [Fact]
        public void ChangingBroccoliNotifiesSpecialInstructionsProperty()
        {
            var goo = new GardenOrcOmelette();

            Assert.PropertyChanged(goo, "SpecialInstructions", () =>
            {
                goo.Broccoli = !goo.Broccoli;
            });
        }

        [Fact]
        public void ChangingCheddarNotifiesCheddarProperty()
        {
            var goo = new GardenOrcOmelette();

            Assert.PropertyChanged(goo, "Cheddar", () =>
            {
                goo.Cheddar = true;
            });

            Assert.PropertyChanged(goo, "Cheddar", () =>
            {
                goo.Cheddar = false;
            });
        }

        [Fact]
        public void ChangingCheddarNotifiesSpecialInstructionsProperty()
        {
            var goo = new GardenOrcOmelette();

            Assert.PropertyChanged(goo, "SpecialInstructions", () =>
            {
                goo.Cheddar = !goo.Cheddar;
            });
        }

        [Fact]
        public void ChangingMushroomsNotifiesMushroomsProperty()
        {
            var goo = new GardenOrcOmelette();

            Assert.PropertyChanged(goo, "Mushrooms", () =>
            {
                goo.Mushrooms = true;
            });

            Assert.PropertyChanged(goo, "Mushrooms", () =>
            {
                goo.Mushrooms = false;
            });
        }

        [Fact]
        public void ChangingMushroomsNotifiesSpecialInstructionsProperty()
        {
            var goo = new GardenOrcOmelette();

            Assert.PropertyChanged(goo, "SpecialInstructions", () =>
            {
                goo.Mushrooms = !goo.Mushrooms;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var goo = new GardenOrcOmelette();

            Assert.PropertyChanged(goo, "Tomato", () =>
            {
                goo.Tomato = true;
            });

            Assert.PropertyChanged(goo, "Tomato", () =>
            {
                goo.Tomato = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesSpecialInstructionsProperty()
        {
            var goo = new GardenOrcOmelette();

            Assert.PropertyChanged(goo, "SpecialInstructions", () =>
            {
                goo.Tomato = !goo.Tomato;
            });
        }

        [Fact]
        public void IsAssignableFromINotifyPropertyChanged()
        {
            var goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(goo);
        }

        [Fact]
        public void GivesCorrectDesciption()
        {
            var item = new GardenOrcOmelette();
            string idealDescription = "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";
            Assert.Equal(idealDescription, item.Description);
        }

    }
}