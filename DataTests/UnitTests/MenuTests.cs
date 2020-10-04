using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data;
using System.Reflection.Metadata.Ecma335;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void ContainsAllEntrees()
        {
            Assert.Contains(Menu.Entrees(), (item) => { return item is BriarheartBurger; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is DoubleDraugr; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is GardenOrcOmelette; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is PhillyPoacher; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is SmokehouseSkeleton; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is ThalmorTriple; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is ThugsTBone; });
            //Assert.Contains<IOrderItem>(new BriarheartBurger(), Menu.Entrees());
            //Assert.Collection<IOrderItem>(Menu.Entrees(), )
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ContainsAllSides(Size size)
        {
            foreach (Side side in Menu.Sides())
            {
                side.Size = size;
                Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals($"{size} Dragonborn Waffle Fries"); });
                Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals($"{size} Fried Miraak"); });
                Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals($"{size} Mad Otar Grits"); });
                Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals($"{size} Vokun Salad"); });
                //Assert.Contains(Menu.Sides(), (item) => { return item is FriedMiraak; });
                //Assert.Contains(Menu.Sides(), (item) => { return item is MadOtarGrits; });
                //Assert.Contains(Menu.Sides(), (item) => { return item is VokunSalad; });
            }
            //Assert.Contains<IOrderItem>(new DragonbornWaffleFries(), Menu.Sides());
            //Assert.Collection<IOrderItem>(Menu.Entrees(), Assert.)
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ContainsAllDrinks(Size size)
        {
            foreach (Drink drink in Menu.Drinks())
            {
                drink.Size = size;
                Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals($"{size} Aretino Apple Juice"); });
                Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals($"{size} Candlehearth Coffee"); });
                Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals($"{size} Markarth Milk"); });
                Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals($"{size} Warrior Water"); });
                foreach (SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
                {
                    Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals($"{size} {flavor} Sailor Soda"); });
                }
            }
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ContainsAllItems(Size size)
        {
            IEnumerable<IOrderItem> fullMenu = Menu.FullMenu();
            foreach (Drink drink in Menu.Drinks())
            {
                drink.Size = size;
                Assert.Contains(fullMenu, (item) => { return item.ToString().Equals($"{size} Aretino Apple Juice"); });
                Assert.Contains(fullMenu, (item) => { return item.ToString().Equals($"{size} Candlehearth Coffee"); });
                Assert.Contains(fullMenu, (item) => { return item.ToString().Equals($"{size} Markarth Milk"); });
                Assert.Contains(fullMenu, (item) => { return item.ToString().Equals($"{size} Warrior Water"); });
                foreach (SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
                {
                    Assert.Contains(fullMenu, (item) => { return item.ToString().Equals($"{size} {flavor} Sailor Soda"); });
                }
            }

            foreach (Side side in Menu.Sides())
            {
                side.Size = size;
                Assert.Contains(fullMenu, (item) => { return item.ToString().Equals($"{size} Dragonborn Waffle Fries"); });
                Assert.Contains(fullMenu, (item) => { return item.ToString().Equals($"{size} Fried Miraak"); });
                Assert.Contains(fullMenu, (item) => { return item.ToString().Equals($"{size} Mad Otar Grits"); });
                Assert.Contains(fullMenu, (item) => { return item.ToString().Equals($"{size} Vokun Salad"); });
            }

            Assert.Contains(fullMenu, (item) => { return item is BriarheartBurger; });
            Assert.Contains(fullMenu, (item) => { return item is DoubleDraugr; });
            Assert.Contains(fullMenu, (item) => { return item is GardenOrcOmelette; });
            Assert.Contains(fullMenu, (item) => { return item is PhillyPoacher; });
            Assert.Contains(fullMenu, (item) => { return item is SmokehouseSkeleton; });
            Assert.Contains(fullMenu, (item) => { return item is ThalmorTriple; });
            Assert.Contains(fullMenu, (item) => { return item is ThugsTBone; });

        }


    }
}
