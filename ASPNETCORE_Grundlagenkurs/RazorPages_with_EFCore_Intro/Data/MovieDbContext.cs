using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPages_with_EFCore_Intro.Models;

namespace RazorPages_with_EFCore_Intro.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext (DbContextOptions<MovieDbContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPages_with_EFCore_Intro.Models.Movie> Movies { get; set; } = default!;
    }
}
