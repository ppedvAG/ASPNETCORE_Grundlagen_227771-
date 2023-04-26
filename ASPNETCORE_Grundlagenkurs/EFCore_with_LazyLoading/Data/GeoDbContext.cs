using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EFCore_with_LazyLoading.Models;

namespace EFCore_with_LazyLoading.Data
{
    public class GeoDbContext : DbContext
    {
        public GeoDbContext (DbContextOptions<GeoDbContext> options)
            : base(options)
        {
        }

        public DbSet<Continent> Continents { get; set; } = default!;
        public DbSet<Language> Languages { get; set; } = default!;

        public DbSet<Country> Countries { get; set; } = default!;

        public DbSet<LanguageInCountry> LanguagesInCountries { get; set; } = default!;

    }
}
