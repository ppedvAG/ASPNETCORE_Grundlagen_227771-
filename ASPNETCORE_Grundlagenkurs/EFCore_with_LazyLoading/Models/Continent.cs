namespace EFCore_with_LazyLoading.Models
{
    public class Continent
    {

        public int Id { get; set; }
        public string Name { get; set; }


        //Bei Lazy Loading müssen die Navigations als virtual markiert werden
        public virtual ICollection<Country> Countries { get; set; }


    }
}
