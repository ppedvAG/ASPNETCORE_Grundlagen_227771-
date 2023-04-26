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
    public class IndexModel : PageModel
    {
        private readonly EFCore_with_LazyLoading.Data.GeoDbContext _context;

        public IndexModel(EFCore_with_LazyLoading.Data.GeoDbContext context)
        {
            _context = context;
        }

        public IList<LanguageInCountry> LanguageInCountry { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.LanguagesInCountries != null)
            {
                LanguageInCountry = await _context.LanguagesInCountries
                .Include(l => l.Country)
                .Include(l => l.Language).ToListAsync();
            }
        }
    }
}
