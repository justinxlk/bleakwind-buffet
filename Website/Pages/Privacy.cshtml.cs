/*
 * Author: Justin Kingry
 * Class name: Privacy.cshtml.cs
 * Purpose: Models the privacy page
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    /// <summary>
    /// Model for the Privacy page
    /// </summary>
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        /// <summary>
        /// constructor for the PrivacyModel class sets the _logger
        /// </summary>
        /// <param name="logger">the privacy model logger</param>
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// 
        /// </summary>
        public void OnGet()
        {
        }
    }
}
