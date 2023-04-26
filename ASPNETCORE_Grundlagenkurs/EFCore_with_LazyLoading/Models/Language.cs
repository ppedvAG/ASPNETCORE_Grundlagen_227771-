namespace EFCore_with_LazyLoading.Models
{
    public class Language
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public virtual ICollection<LanguageInCountry> LanguagesInCountries { get; set; }
    }
}
