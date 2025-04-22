using MovieStoreWebApi.Base;

namespace MovieStoreWebApi.Schema
{
    public class Actor : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<ActorMovie> ActorMovies { get; set; } = new List<ActorMovie>();

    }
}
