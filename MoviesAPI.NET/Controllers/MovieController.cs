using Microsoft.AspNetCore.Mvc;
using MoviesAPI.NET.Models;

namespace MoviesAPI.NET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>();
        private static int id = 0;

        [HttpPost]
        public void AddMovie([FromBody]Movie movie)
        {            
            {
                movie.Id = id++;
                movies.Add(movie);
                Console.WriteLine(movie.Title);
                Console.WriteLine(movie.Duration);
            }
           
        }

        [HttpGet]
        public IEnumerable<Movie> ReadMovies()
        {
            return movies;
        }

        [HttpGet("{id}")]
        public Movie? ReadMovieId(int id)
        {
            return movies
                .FirstOrDefault(movie => movie.Id == id);
        }

    }
}
