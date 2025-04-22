using MovieStoreWebApi.Base;

namespace MovieStoreWebApi.Schema
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();

        public ICollection<CustomerGenre> FavoriteGenres { get; set; } = new List<CustomerGenre>();
    }
}
