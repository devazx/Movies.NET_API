﻿using Microsoft.AspNetCore.Mvc;
using MoviesAPI.NET.Models;

namespace MoviesAPI.NET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>();

        [HttpPost]
        public void AddMovie([FromBody]Movie movie)
        {
            movies.Add(movie);
            Console.WriteLine(movie.Title);
            Console.WriteLine(movie.Duration);
        }

    }
}
