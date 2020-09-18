using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using Xunit;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class IOrderItemTests
    {

        [Theory]
        [InlineData(typeof(AretinoAppleJuice))]
        [InlineData(typeof(CandlehearthCoffee))]
        [InlineData(typeof(MarkarthMilk))]
        [InlineData(typeof(SailorSoda))]
        [InlineData(typeof(WarriorWater))]
        [InlineData(typeof(BriarheartBurger))]
        [InlineData(typeof(DoubleDraugr))]
        [InlineData(typeof(GardenOrcOmelette))]
        [InlineData(typeof(PhillyPoacher))]
        [InlineData(typeof(SmokehouseSkeleton))]
        [InlineData(typeof(ThalmorTriple))]
        [InlineData(typeof(ThugsTBone))]
        [InlineData(typeof(DragonbornWaffleFries))]
        [InlineData(typeof(FriedMiraak))]   
        [InlineData(typeof(MadOtarGrits))]
        [InlineData(typeof(VokunSalad))]
        public void AllItemsAreAssignableFromIOrderItem(Type itemType)
        {
            var itemInstance = Activator.CreateInstance(itemType);
            Assert.IsAssignableFrom<IOrderItem>(itemInstance);
        }
    }
}
