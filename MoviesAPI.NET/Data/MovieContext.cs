using Microsoft.EntityFrameworkCore;
using MoviesAPI.NET.Models;

namespace MoviesAPI.NET.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) 
            : base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
    }
}
