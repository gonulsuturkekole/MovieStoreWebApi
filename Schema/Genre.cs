using MovieStoreWebApi.Base;
namespace MovieStoreWebApi.Schema
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
        public ICollection<CustomerGenre> CustomerGenres { get; set; } = new List<CustomerGenre>();
    }
}
