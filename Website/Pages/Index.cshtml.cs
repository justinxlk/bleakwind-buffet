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
            itemCoursesLabels = Request.Query["itemCoursesLabels"];

            Items = FilterLogic.Search(SearchTerms);
            Items = FilterLogic.FilterByItemType(Items, itemCoursesLabels);
            Items = FilterLogic.FilterByPrice(Items, PriceMin, PriceMax);
            Items = FilterLogic.FilterByCalories(Items, CalMin, CalMax);
        }

        public string SearchTerms { get; set; }

        public string[] itemCoursesLabels { get; set; }

        public IEnumerable<IOrderItem> Items { get; protected set; }

    }
}
