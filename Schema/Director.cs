using MovieStoreWebApi.Base;

namespace MovieStoreWebApi.Schema
{
    public class Director : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}
