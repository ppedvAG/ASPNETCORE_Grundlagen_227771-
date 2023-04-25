using System.ComponentModel.DataAnnotations;
using ValidierungsSamples.Models;

namespace ValidierungsSamples.Attributes
{
    public class ClassicMovieAttribute : ValidationAttribute
    {
        //Vorgabe, ab welchen Jahr  ist ein Film ein Klassiker
        public int Year { get; set; }

        public ClassicMovieAttribute(int year)
        {
            Year = year;
        }

        public string GetErrorMessage() =>
            $"Filmklassiker sind alle vor {Year} erschienen";

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {

            Movie movie = (Movie)validationContext.ObjectInstance;

            //Welches Jahr hat der Film eigentlich
            int releaseYear = (int)value;

            if (movie.Genre == GenreType.Classics && releaseYear > Year)
                return new ValidationResult(GetErrorMessage());

            return ValidationResult.Success;

        }
    }
}
