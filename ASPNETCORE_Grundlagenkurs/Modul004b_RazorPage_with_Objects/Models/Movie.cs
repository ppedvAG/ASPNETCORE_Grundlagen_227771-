namespace Modul004b_RazorPage_with_Objects.Models
{
    //POCO Object für EF-Core
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public GenreType Genre { get; set; }
    }

    public enum GenreType {  Action, Drame, Comedy, Thriller, Crime, Horror, Romance, ScienceFiction }
}
