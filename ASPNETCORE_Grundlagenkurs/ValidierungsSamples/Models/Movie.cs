using System.ComponentModel.DataAnnotations;
using ValidierungsSamples.Attributes;

namespace ValidierungsSamples.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required] //Mussfeld
        [MaxLength(50)]
        public string Title { get; set; }

        [MinLength(10)]
        public string Description { get; set; }

        [Range(0, 99.99)]
        public decimal Price { get; set; }

        [ClassicMovie(1960)]
        public int Year { get; set; }

        public GenreType Genre { get; set; }
    }

    public enum GenreType { Action, Drama, Comedy, Thriller, Crime, Horror, Romance, ScienceFiction, Biography, Docu, Animation, Classics }
}
