using MovieStoreWebApi.Schema;
using static MovieStoreWebApi.Dtos.MovieDto;

namespace MovieStoreWebApi.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CreateMovieRequest, Movie>();
            CreateMap<UpdateMovieRequest, Movie>();
            CreateMap<Movie, MovieResponse>()
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name))
                .ForMember(dest => dest.Director, opt => opt.MapFrom(src => src.Director.FirstName + " " + src.Director.LastName));
        }
    }
}
