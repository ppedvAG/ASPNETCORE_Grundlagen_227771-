using RazorPages_with_EFCore_Intro.Models;

namespace RazorPages_with_EFCore_Intro.Data
{
    public static class DataSeeder
    {
        public static void SeedMoviesInDb(MovieDbContext ctx)
        {
            if(!ctx.Movies.Any())
            {
                ctx.Movies.Add(new Movie { Title = "Coda", Description = "Singtalent", Price = 10, Year = 2021, Genre = GenreType.Drama });
                ctx.Movies.Add(new Movie { Title = "Coda 2", Description = "Singtalent", Price = 10, Year = 2021, Genre = GenreType.Drama });
                ctx.Movies.Add(new Movie { Title = "Coda 3", Description = "Singtalent", Price = 10, Year = 2021, Genre = GenreType.Drama });


                ctx.SaveChanges(); //Hier wird das SQL erstellt. = Wenn wir ein "Muss"-Feld nicht ausgefüllt haben, bekommen wir in SaveChange eine Exception 

            }
        }
    }
}
