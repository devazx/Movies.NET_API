using AutoMapper;
using MoviesAPI.NET.Dtos;
using MoviesAPI.NET.Models;

namespace MoviesAPI.NET.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<CreateMoviesDto, Movie>();
            CreateMap<UpdateMoviesDto, Movie>();
        }
    }
}

