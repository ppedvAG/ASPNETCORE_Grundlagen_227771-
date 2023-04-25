using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPages_Advanced.Models;

namespace RazorPages_Advanced.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext (DbContextOptions<MovieDbContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPages_Advanced.Models.Movie> Movie { get; set; } = default!;
    }
}
