/*
 * Author: Justin Kingry
 * Class name: Index.cshtml.cs
 * Purpose: Models the index page
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    /// <summary>
    /// Model for the Index page of the website
    /// </summary>
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// constuctor for the IndexModel class
        /// </summary>
        /// <param name="logger">logs index model</param>
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// filters the menu to reflect the inputs of the user
        /// </summary>
        /// <param name="PriceMin">the minimum item price that the user wishes to see</param>
        /// <param name="PriceMax">the maximum item price thar the user wishes to see</param>
        /// <param name="CalMin">the minimum item calories that the user wishes to see</param>
        /// <param name="CalMax">the maximum item calories that the user wishes to see</param>
        public void OnGet(double? PriceMin, double? PriceMax, uint? CalMin, uint? CalMax)
        {
            SearchTerms = Request.Query["SearchTerms"];
            //SearchTermArray = SearchTerms.Split(' ');
            itemCoursesLabels = Request.Query["itemCoursesLabels"];
            Items = Menu.FullMenu();

            if (SearchTerms != null)
            {
                SearchTermArray = SearchTerms.Split(' ');
                //foreach (string searchTerm in SearchTermArray)
                //{
                    //Items = Items.Where(item => item.StringName != null && item.StringName.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase));
                    IEnumerable<IOrderItem> enumerable = Items.Where(item => item.StringName != null && (SearchTermArray.Any(item.StringName.Contains) || SearchTermArray.Any(item.Description.Contains)));
                    Items = enumerable;
                //}
            }
            //Items = FilterLogic.Search(SearchTerms);
            if (itemCoursesLabels != null && itemCoursesLabels.Length > 0)
            {
                IEnumerable<IOrderItem> enumerable = Items.Where(item => (item is Drink && itemCoursesLabels.Contains("Drink")) || (item is Entree && itemCoursesLabels.Contains("Entree")) || (item is Side && itemCoursesLabels.Contains("Side")));
                Items = enumerable;
            }
            //Items = FilterLogic.FilterByItemType(Items, itemCoursesLabels);
            if (PriceMax != null)
            {
                Items = Items.Where(item => item.Price != null && item.Price <= PriceMax);
            }
            if (PriceMin != null)
            {
                Items = Items.Where(item => item.Price != null && item.Price >= PriceMin);
            }
            //Items = FilterLogic.FilterByPrice(Items, PriceMin, PriceMax);
            if (CalMax != null)
            {
                Items = Items.Where(item => item.Calories != null && item.Calories <= CalMax);
            }
            if (CalMin != null)
            {
                Items = Items.Where(item => item.Calories != null && item.Calories >= CalMin);
            }
            //Items = FilterLogic.FilterByCalories(Items, CalMin, CalMax);
        }

        /// <summary>
        /// what the user typed in the search bar
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// each word that the user typed in the search bar in the form of a string array
        /// </summary>
        public string[] SearchTermArray
        {
            get;
            set;
        }

        /// <summary>
        /// the types of menu items that the user is filtering by with none being the same as all
        /// </summary>
        public string[] itemCoursesLabels { get; set; }

        /// <summary>
        /// the items that have made it through the filters thus far
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; protected set; }

    }
}
