using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EFCore_with_LazyLoading.Data;
using EFCore_with_LazyLoading.Models;

namespace EFCore_with_LazyLoading.Pages.LanguagesInCountries
{
    public class DetailsModel : PageModel
    {
        private readonly EFCore_with_LazyLoading.Data.GeoDbContext _context;

        public DetailsModel(EFCore_with_LazyLoading.Data.GeoDbContext context)
        {
            _context = context;
        }

      public LanguageInCountry LanguageInCountry { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.LanguagesInCountries == null)
            {
                return NotFound();
            }

            var languageincountry = await _context.LanguagesInCountries.FirstOrDefaultAsync(m => m.Id == id);
            if (languageincountry == null)
            {
                return NotFound();
            }
            else 
            {
                LanguageInCountry = languageincountry;
            }
            return Page();
        }
    }
}
