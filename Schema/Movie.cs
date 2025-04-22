using MovieStoreWebApi.Base;
using System.IO;

namespace MovieStoreWebApi.Schema
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public int GenreId { get; set; }

        public int DirectorId { get; set; }
        public Director Director { get; set; }
        public Genre Genre { get; set; }

        public ICollection<ActorMovie> ActorMovies { get; set; } = new List<ActorMovie>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
