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
    public class OrderLogicTests
    {
        [Fact]
        public void SalesTaxRateGetsWhatIsSet()
        {
            OrderLogic ol = new OrderLogic();
            ol.SalesTaxRate = .15;
            Assert.Equal(.15, ol.SalesTaxRate);
        }

        [Fact]
        public void ShouldHaveCorrectSubtotalForItems()
        {
            OrderLogic ol = new OrderLogic();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            VokunSalad vs = new VokunSalad();
            vs.Size = Size.Medium;
            ol.Add(aj);
            ol.Add(bb);
            ol.Add(vs);

            Assert.Equal(aj.Price + bb.Price + vs.Price, ol.Subtotal);
        }

        [Fact]
        public void ShouldHaveCorrectTaxForItems()
        {
            OrderLogic ol = new OrderLogic();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            VokunSalad vs = new VokunSalad();
            vs.Size = Size.Medium;
            ol.Add(aj);
            ol.Add(bb);
            ol.Add(vs);

            Assert.Equal(Math.Round(ol.Subtotal * ol.SalesTaxRate, 2), ol.Tax);
        }

        [Fact]
        public void ShouldHaveCorrectTotalForItems()
        {
            OrderLogic ol = new OrderLogic();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            VokunSalad vs = new VokunSalad();
            vs.Size = Size.Medium;
            ol.Add(aj);
            ol.Add(bb);
            ol.Add(vs);

            Assert.Equal(Math.Round(ol.Subtotal + ol.Tax, 2), ol.Total);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForItems()
        {
            OrderLogic ol = new OrderLogic();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            VokunSalad vs = new VokunSalad();
            vs.Size = Size.Medium;
            ol.Add(aj);
            ol.Add(bb);
            ol.Add(vs);
            double totCal = aj.Calories + bb.Calories + vs.Calories;

            Assert.Equal(Math.Round(totCal, 2), ol.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectNumberForNumberOfOrderLogicsCreated()
        {
            OrderLogic ol = new OrderLogic();
            ol = new OrderLogic();
            ol = new OrderLogic();
            ol = new OrderLogic();
            Assert.Equal(4, ol.Number);
        }

        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Tax")]
        [InlineData("Total")]
        [InlineData("Calories")]
        [InlineData("TextForSubtotal")]
        [InlineData("TextForTax")]
        [InlineData("TextForTotal")]
        public void CollectionChangedListenerChangesPropertiesWhenCollectionChanges(string property)
        {
            OrderLogic ol = new OrderLogic();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            VokunSalad vs = new VokunSalad();
            vs.Size = Size.Medium;

            Assert.PropertyChanged(ol, property, () => { ol.Add(aj); } );
            Assert.PropertyChanged(ol, property, () => { ol.Remove(aj); });
        }

        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Tax")]
        [InlineData("Total")]
        [InlineData("Calories")]
        [InlineData("TextForSubtotal")]
        [InlineData("TextForTax")]
        [InlineData("TextForTotal")]
        public void CollectionItemChangedListenerChangesPropertiesWhenCollectionItemChanges(string property)
        {
            OrderLogic ol = new OrderLogic();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            VokunSalad vs = new VokunSalad();
            vs.Size = Size.Medium;

            //IOrderItem ioi = ol[0];
            //Assert.PropertyChanged(ol, property, () => { ioi.Price = 10; });

            if (aj is IOrderItem item)
            {
                Assert.PropertyChanged(ol, property, () => { aj.Size = Size.Large; });
            }
            
        }

        [Fact]
        public void OrderNumberReturnsTheProperString()
        {
            OrderLogic ol = new OrderLogic();
            ol = new OrderLogic();
            ol = new OrderLogic();
            ol = new OrderLogic();
            Assert.Equal($"Order #{ol.Number}", ol.OrderNumber);
        }

        [Fact]
        public void ShouldHaveCorrectTextForSubtotal()
        {
            OrderLogic ol = new OrderLogic();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            VokunSalad vs = new VokunSalad();
            vs.Size = Size.Medium;
            ol.Add(aj);
            ol.Add(bb);
            ol.Add(vs);

            Assert.Equal($"Subtotal: ${ol.Subtotal}", ol.TextForSubtotal);
        }

        [Fact]
        public void ShouldHaveCorrectTextForTax()
        {
            OrderLogic ol = new OrderLogic();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            VokunSalad vs = new VokunSalad();
            vs.Size = Size.Medium;
            ol.Add(aj);
            ol.Add(bb);
            ol.Add(vs);

            Assert.Equal($"Tax: ${ol.Tax}", ol.TextForTax);
        }

        [Fact]
        public void ShouldHaveCorrectTextForTotal()
        {
            OrderLogic ol = new OrderLogic();
            AretinoAppleJuice aj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            VokunSalad vs = new VokunSalad();
            vs.Size = Size.Medium;
            ol.Add(aj);
            ol.Add(bb);
            ol.Add(vs);

            Assert.Equal($"Total: ${ol.Total}", ol.TextForTotal);
        }


    }
}
