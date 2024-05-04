using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.NET.Data;
using MoviesAPI.NET.Dtos;
using MoviesAPI.NET.Models;
using System.Reflection;

namespace MoviesAPI.NET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private MovieContext _context;
        

        public MovieController(MovieContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddMovie([FromBody] CreateMoviesDto movieDto)
        {
            Movie movie = new Movie
            {
                Title = movieDto.Title,
                Category = movieDto.Category,
                Duration = movieDto.Duration
            };
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ReadMovieId),
                new { id = movie.Id },
                movie);
        }

        [HttpGet]
        public IEnumerable<Movie> ReadMovies([FromQuery] int skip = 0, [FromQuery] int take = 50)
        {
            return _context.Movies
                .Skip(skip)
                .Take(take);
        }

        [HttpGet("{id}")]
        public IActionResult ReadMovieId(int id)
        {
            var movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);
            if (movie == null) return NotFound();
            return Ok(movie);

        }
        [HttpPut("{id}")]
        public IActionResult UpdateMovie(int id, [FromBody] UpdateMoviesDto movieDto)
        {

            var movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);

            if (movie != null)
            {
                movie.Title = movieDto.Title;
                movie.Category = movieDto.Category;
                movie.Duration = movieDto.Duration;

                _context.SaveChanges();
                return NoContent();
            }
            return NotFound();
        }
    }
}
