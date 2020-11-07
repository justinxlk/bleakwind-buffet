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
//using BleakwindBuffet.Website.FilterLogic;
using Website;
using System.Linq;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class FilterLogicTests
    {
        [Fact]
        public void SearchReturnsOnlyReleatedResults()
        {
            IOrderItem bb = new BriarheartBurger();
            //Assert.Contains(bb, FilterLogic.Search("burger"));
            foreach (IOrderItem item in FilterLogic.Search("burger"))
            {
                Assert.Equal(bb.GetType(), item.GetType());
            }
            IOrderItem dd = new DoubleDraugr();
            IOrderItem dwf = new DragonbornWaffleFries();
            List<IOrderItem> items = (List<IOrderItem>)FilterLogic.Search("dr");
            Assert.Equal(dd.ToString(), items[0].ToString());
            Assert.Equal(dwf.ToString(), items[1].ToString());
            DragonbornWaffleFries dwf2 = new DragonbornWaffleFries();
            dwf2.Size = Size.Medium;
            Assert.Equal(dwf2.ToString(), items[2].ToString());
            DragonbornWaffleFries dwf3 = new DragonbornWaffleFries();
            dwf3.Size = Size.Large;
            Assert.Equal(dwf3.ToString(), items[3].ToString());
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData(null, 5.00)]
        [InlineData(2.50, null)]
        [InlineData(2.00, 3.00)]
        public void FilterByPriceReturnsOnlyResultsWithinRange(double? min, double? max)
        {
            List<IOrderItem> items = (List<IOrderItem>)Menu.FullMenu();
            var results = new List<IOrderItem>();
            if (min == null && max == null)
            {
                foreach (IOrderItem item in items)
                {
                    results.Add(item);
                    Assert.Contains(item, FilterLogic.FilterByPrice(items, min, max));
                }
                //Assert.Equal(results, FilterLogic.FilterByPrice(items, min, max));
            }
            results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                Assert.Equal(results, FilterLogic.FilterByPrice(items, min, max));
            }
            results = new List<IOrderItem>();
            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                Assert.Equal(results, FilterLogic.FilterByPrice(items, min, max));
            }
            results = new List<IOrderItem>();
            if (min != null && max != null)
            {
                // Both minimum and maximum specified
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min && item.Price <= max)
                    {
                        results.Add(item);
                    }
                }
                Assert.Equal(results, FilterLogic.FilterByPrice(items, min, max));
            }
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData(null, 700)]
        [InlineData(500, null)]
        [InlineData(500, 700)]
        public void FilterByCaloriesReturnsOnlyResultsWithinRange(uint? min, uint? max)
        {
            IEnumerable<IOrderItem> items = Menu.FullMenu();
            var results = new List<IOrderItem>();
            if (min == null && max == null)
            {
                foreach (IOrderItem item in items)
                {
                    results.Add(item);
                }
                Assert.Equal(results, FilterLogic.FilterByCalories(items, min, max));
            }
            results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max)
                    {
                        results.Add(item);
                        Assert.Contains(item, FilterLogic.FilterByCalories(items, min, max));
                    }
                }
                //Assert.Equal(results, FilterLogic.FilterByCalories(items, min, max));
            }
            results = new List<IOrderItem>();
            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min)
                    {
                        results.Add(item);
                        Assert.Contains(item, FilterLogic.FilterByCalories(items, min, max));
                    }
                }
                //Assert.Equal(results, FilterLogic.FilterByCalories(items, min, max));
            }
            results = new List<IOrderItem>();
            if (min != null && max != null)
            {
                // Both minimum and maximum specified
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min && item.Calories <= max)
                    {
                        results.Add(item);
                        Assert.Contains(item, FilterLogic.FilterByCalories(items, min, max));
                    }
                }
                //Assert.Equal(results, FilterLogic.FilterByCalories(items, min, max));
            }
        }

        [Theory]
        [InlineData("Drink", "Entree", "Side")]
        [InlineData("", "Side", "")]
        public void FilterByItemTypeReturnsOnlyResultsOfDesiredType(string courseLabel1, string courselabel2, string courselabel3)
        {
            IEnumerable<IOrderItem> items = Menu.FullMenu();
            string[] coursesLabel = new string[] { courseLabel1, courselabel2, courselabel3 };
            if (coursesLabel == null || coursesLabel.Count() == 0)
            {
                Assert.Equal(items, FilterLogic.FilterByItemType(items, coursesLabel));
            }
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in items)
            {
                if ((item is Drink && coursesLabel.Contains("Drink")) || (item is Entree && coursesLabel.Contains("Entree")) || (item is Side && coursesLabel.Contains("Side")))
                {
                    results.Add(item);
                    Assert.Contains(item, FilterLogic.FilterByItemType(items, coursesLabel));
                }
                else
                {
                    Assert.DoesNotContain(item, FilterLogic.FilterByItemType(items, coursesLabel));
                }
            }
            
            
        }


    }
}
