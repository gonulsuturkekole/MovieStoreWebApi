using MovieStoreWebApi.Base;

namespace MovieStoreWebApi.Schema
{
    public class CustomerGenre : BaseEntity
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
