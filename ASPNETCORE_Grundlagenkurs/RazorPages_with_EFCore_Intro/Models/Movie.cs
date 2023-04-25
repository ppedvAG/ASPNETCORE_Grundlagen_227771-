﻿namespace RazorPages_with_EFCore_Intro.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public int? Rating { get; set; }
        public int Year { get; set; }
        public GenreType Genre { get; set; }
    }

    public enum GenreType { Action, Drama, Comedy, Thriller, Crime, Horror, Romance, ScienceFiction, Biography, Docu, Animation, Classics }
}
