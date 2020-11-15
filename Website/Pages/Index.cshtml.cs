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
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

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

        public string SearchTerms { get; set; }

        public string[] SearchTermArray
        {
            get;
            set;
        }

        public string[] itemCoursesLabels { get; set; }

        public IEnumerable<IOrderItem> Items { get; protected set; }

    }
}
