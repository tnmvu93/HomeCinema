using AutoMapper;
using HomeCinema.Api.ViewModel;
using HomeCinema.Data.Entities;
using System.Linq;

namespace HomeCinema.Api.Infrastructure.Mappings
{
    public class EntityToViewModelMappingProfile : Profile
    {
        public EntityToViewModelMappingProfile()
        {
            CreateMap<Movie, MovieViewModel>()
                .ForMember(d => d.Genre, exp => exp.MapFrom(s => s.Genre.Name))
                .ForMember(d => d.GenreId, exp => exp.MapFrom(s => s.Genre.Id))
                .ForMember(d => d.IsAvailable, exp => exp.MapFrom(s => s.Stocks.Any(x => x.IsAvailable)))
                .ForMember(d => d.NumberOfStocks, exp => exp.MapFrom(s => s.Stocks.Count))
                .ForMember(d => d.Image, exp => exp.MapFrom(s =>string.IsNullOrEmpty(s.Image) == true ? "unknown.jpg" : s.Image));

            CreateMap<Genre, GenreViewModel>()
                .ForMember(d => d.NumberOfMovies, exp => exp.MapFrom(s => s.Movies.Count));
        }
    }
}