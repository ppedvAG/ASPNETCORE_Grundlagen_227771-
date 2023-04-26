using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EFCore_with_LazyLoading.Data;
using EFCore_with_LazyLoading.Models;

namespace EFCore_with_LazyLoading.Pages.LanguagesInCountries
{
    public class CreateModel : PageModel
    {
        private readonly EFCore_with_LazyLoading.Data.GeoDbContext _context;

        public CreateModel(EFCore_with_LazyLoading.Data.GeoDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "Name");
        ViewData["LanguageId"] = new SelectList(_context.Languages, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public LanguageInCountry LanguageInCountry { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            ModelState.Remove("LanguageInCountry.Language");
            ModelState.Remove("LanguageInCountry.Country");


            //languagePercentSum der bisher vergebene Sprachen in einem Land
            int languagePercentSum = _context.LanguagesInCountries.Where(c => c.CountryId == LanguageInCountry.CountryId).Sum(c => c.Percent);

            if (languagePercentSum + LanguageInCountry.Percent > 100)
            {
                ModelState.AddModelError("LanguageInCountry.Percent", $"Es kann höchsten noch {100 - languagePercentSum} % vergeben werden");
            }

            if (!ModelState.IsValid || _context.LanguagesInCountries == null || LanguageInCountry == null)
            {
                return Page();
            }

            _context.LanguagesInCountries.Add(LanguageInCountry);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
