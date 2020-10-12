using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {

        [Fact]
        public void PriceShouldBeTotalOfThe3Items()
        {
            Combo c = new Combo();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            c.Drink = aj;
            DoubleDraugr dd = new DoubleDraugr();
            c.Entree = dd;
            FriedMiraak fm = new FriedMiraak();
            c.Side = fm;
            Assert.Equal(aj.Price + dd.Price + fm.Price - 1, c.Price);
        }

        [Fact]
        public void CaloriesShouldBeTotalOfThe3Items()
        {
            Combo c = new Combo();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            c.Drink = aj;
            DoubleDraugr dd = new DoubleDraugr();
            c.Entree = dd;
            FriedMiraak fm = new FriedMiraak();
            c.Side = fm;
            Assert.Equal(aj.Calories + dd.Calories + fm.Calories, c.Calories);
        }

        [Theory]
        [InlineData("Drink")]
        [InlineData("Price")]
        [InlineData("Calories")]
        [InlineData("SpecialInstructions")]
        public void ChangingDrinkNotifiesProperties(string property)
        {
            var c = new Combo();

            Assert.PropertyChanged(c, property, () =>
            {
                c.Drink = new AretinoAppleJuice();
            });
        }

        [Fact]
        public void ChangingDrinkChangesDrink()
        {
            var c = new Combo();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            c.Drink = aj;

            Assert.Equal(aj, c.Drink);
        }

        [Theory]
        [InlineData("Entree")]
        [InlineData("Price")]
        [InlineData("Calories")]
        [InlineData("SpecialInstructions")]
        public void ChangingEntreeNotifiesProperties(string property)
        {
            var c = new Combo();

            Assert.PropertyChanged(c, property, () =>
            {
                c.Entree = new ThalmorTriple();
            });
        }

        [Fact]
        public void ChangingEntreeChangesEntree()
        {
            var c = new Combo();
            BriarheartBurger bb = new BriarheartBurger();
            c.Entree = bb;

            Assert.Equal(bb, c.Entree);
        }

        [Theory]
        [InlineData("Side")]
        [InlineData("Price")]
        [InlineData("Calories")]
        [InlineData("SpecialInstructions")]
        public void ChangingSideNotifiesProperties(string property)
        {
            var c = new Combo();

            Assert.PropertyChanged(c, property, () =>
            {
                c.Side = new MadOtarGrits();
            });
        }

        [Fact]
        public void ChangingSideChangesSide()
        {
            var c = new Combo();
            FriedMiraak fm = new FriedMiraak();
            c.Side = fm;

            Assert.Equal(fm, c.Side);
        }

        [Fact]
        public void SpecialInstructionsMatchCombinationOfEachItems()
        {
            Combo c = new Combo();
            SailorSoda ss= new SailorSoda();
            GardenOrcOmelette goo = new GardenOrcOmelette();
            VokunSalad vs = new VokunSalad();
            ss.Flavor = SodaFlavor.Lemon;
            goo.Broccoli = true;
            goo.Cheddar = false;
            vs.Size = Size.Small;
            c.Drink = ss;
            c.Entree = goo;
            c.Side = vs;

            List<string> specialInstructions = new List<string>();
            specialInstructions.Add(ss.ToString());
            specialInstructions.AddRange(ss.SpecialInstructions);
            specialInstructions.Add(goo.ToString());
            specialInstructions.AddRange(goo.SpecialInstructions);
            specialInstructions.Add(vs.ToString());
            specialInstructions.AddRange(vs.SpecialInstructions);

            Assert.Equal(specialInstructions, c.SpecialInstructions);
        }


    }
}
