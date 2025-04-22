namespace MovieStoreWebApi.Dtos
{
    public class MovieDto
    {
        public class CreateMovieRequest
        {
            public string Title { get; set; }
            public int Year { get; set; }
            public int GenreId { get; set; }
            public int DirectorId { get; set; }
            public decimal Price { get; set; }
        }

        public class UpdateMovieRequest
        {
            public string Title { get; set; }
            public int Year { get; set; }
            public int GenreId { get; set; }
            public int DirectorId { get; set; }
            public decimal Price { get; set; }
        }

        public class MovieResponse
        {
            public string Title { get; set; }
            public int Year { get; set; }
            public string Genre { get; set; }
            public string Director { get; set; }
            public decimal Price { get; set; }
        }
    }
}
