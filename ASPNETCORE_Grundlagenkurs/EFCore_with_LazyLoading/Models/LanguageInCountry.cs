using System.ComponentModel;

namespace EFCore_with_LazyLoading.Models
{
    public class LanguageInCountry
    {
        public int Id { get; set; }

        public int CountryId { get; set; }
        public int LanguageId { get; set; }
        public int Percent { get; set; }

        //Navigation
        [DisplayName("Sprache")]
        public virtual Language Language { get; set; }


        [DisplayName("Land")]
        public virtual Country Country { get; set; }
    }
}
