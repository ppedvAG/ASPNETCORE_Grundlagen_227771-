namespace EFCore_with_LazyLoading.Models
{
    public class Country
    {
        public int Id { get; set; }
        public int ContinentId { get; set; }
        public string Name { get; set; }



        public virtual Continent Continet { get; set; }
        public virtual ICollection<LanguageInCountry> LanguagesInCountries { get; set; }
    }
}
