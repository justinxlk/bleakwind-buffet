/*
 * Author: Justin Kingry
 * Class name: FilterLogic.cs
 * Purpose: Handles all of the logic for the filters and search features
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace Website
{
    /// <summary>
    /// a class for all of the logic for the filters and search features
    /// </summary>
    public static class FilterLogic
    {
        private static List<IOrderItem> menuitems = new List<IOrderItem>();
        /// <summary>
        /// constructor for the class
        /// </summary>
        static FilterLogic()
        {
            foreach (IOrderItem orderItem in Menu.FullMenu())
            {
                menuitems.Add(orderItem);
            }
        }

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
                if (item.StringName != null && item.StringName.Contains(terms, StringComparison.InvariantCultureIgnoreCase))
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

    }
}
