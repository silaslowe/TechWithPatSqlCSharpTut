using Microsoft.EntityFrameworkCore;

namespace MovieApp.Data
{
    public class MovieDataContext : DbContext
    {
        public MovieDataContext(DbContextOptions<MovieDataContext> options) :
            base(options)
        {
        }

        protected void OnModalCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
        
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
    }
}

