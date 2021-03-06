﻿/*
 * Author: Justin Kingry
 * Class name: Menue.cs
 * Purpose: Stores all of the information and items on the menue.
 */

using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;
using System.Security;
using System.Linq;
using System.Threading.Tasks;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class for the Menu
    /// </summary>
    public class Menu
    {


        /// <summary>
        /// returns an IEnumerable list of every entree in the form of an IOrderItem
        /// </summary>
        /// <returns>IEnumerable list of every entree in the form of an IOrderItem</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new ThugsTBone());
            IEnumerable<IOrderItem> entrees2 = entrees;
            return entrees2;
            
        }

        /// <summary>
        /// returns an IEnumerable list of every side in the form of an IOrderItem
        /// </summary>
        /// <returns>IEnumerable list of every side in the form of an IOrderItem</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>() { };
            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries dwf = new DragonbornWaffleFries();
                FriedMiraak fm = new FriedMiraak();
                MadOtarGrits mog = new MadOtarGrits();
                VokunSalad vs = new VokunSalad();
                dwf.Size = size;
                fm.Size = size;
                mog.Size = size;
                vs.Size = size;
                sides.Add(dwf);
                sides.Add(fm);
                sides.Add(mog);
                sides.Add(vs);
            }
            IEnumerable<IOrderItem> sides2 = sides;
            return sides2;
        }

        /// <summary>
        /// returns an IEnumerable list of every drink in the form of an IOrderItem
        /// </summary>
        /// <returns>IEnumerable list of every drink in the form of an IOrderItem</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice aa = new AretinoAppleJuice();
                CandlehearthCoffee chc = new CandlehearthCoffee();
                MarkarthMilk mm = new MarkarthMilk();
                WarriorWater ww = new WarriorWater();
                aa.Size = size;
                chc.Size = size;
                mm.Size = size;
                ww.Size = size;
                drinks.Add(aa);
                drinks.Add(chc);
                drinks.Add(mm);
                drinks.Add(ww);
                foreach(SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda ss = new SailorSoda();
                    ss.Size = size;
                    ss.Flavor = flavor;
                    drinks.Add(ss);
                }
            }
            IEnumerable<IOrderItem> drinks2 = drinks;
            return drinks2;
        }

        /// <summary>
        /// returns an IEnumerable list of every item on the menu in the form of an IOrderItem
        /// </summary>
        /// <returns>IEnumerable list of every item on the menu in the form of an IOrderItem</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> all = new List<IOrderItem>();
            all.AddRange(Entrees());
            all.AddRange(Sides());
            all.AddRange(Drinks());
            IEnumerable<IOrderItem> all2 = all;
            return all2;
        }

        //                             read
        //                              |                                  
        //                              |
        //                             \ /
        //all search and filter functionality is in Website.FilterLogic.cs

        /*
        /// <summary>
        /// Searches the database for matching menu items
        /// </summary>
        /// <param name="terms">The terms to search for</param>
        /// <returns>A collection of menue items that match the search terms</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (terms == null) return Menu.FullMenu();

            foreach (IOrderItem item in Menu.FullMenu())
            {
                if (item.StringName != null && item.StringName.Contains(terms))
                {
                    results.Add(item);
                }
            }
            return results;
        }


        /// <summary>
        /// Filters the provided collection of menu items
        /// to those with prices falling within
        /// the specified range
        /// </summary>
        /// <param name="items">The collection of menu items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered menu item collection</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;

        }


        /// <summary>
        /// Filters the provided collection of menu items
        /// to those with Calories falling within
        /// the specified range
        /// </summary>
        /// <param name="items">The collection of menu items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered menu item collection</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, uint? min, uint? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;

        }

        /// <summary>
        /// Filters the provided collection of menu items
        /// </summary>
        /// <param name="items">The collection of menu items to filter</param>
        /// <param name="coursesLabel">The courses to include the labels of</param>
        /// <returns>A collection containing only menu items that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByItemType(IEnumerable<IOrderItem> items, IEnumerable<string> coursesLabel)
        {
            if (coursesLabel == null || coursesLabel.Count() == 0) return items;
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in items)
            {
                if ((item is Drink && coursesLabel.Contains("Drink")) || (item is Entree && coursesLabel.Contains("Entree")) || (item is Side && coursesLabel.Contains("Side")))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Gets the possible labels of the item courses
        /// </summary>
        public static string[] itemCoursesLabels
        {
            get => new string[]
            {
            "Drink",
            "Entree",
            "Side",
            };
        }

        */

    }
}
