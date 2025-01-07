using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using movieapp.entity;

namespace movieapp.data.Concrete
{
    public class MovieContext :DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            
        }
        public MovieContext() : base() { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieActor>()
                .HasKey(c => new { c.ActorId, c.MovieId });
            modelBuilder.Entity<MovieDirector>()
               .HasKey(c => new { c.DirectorId, c.MovieId });
            modelBuilder.Entity<MovieGenre>()
               .HasKey(c => new { c.GenreId, c.MovieId });
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
        public DbSet<MovieDirector> MovieDirectors { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<Review> Reviews{ get; set; }
        public DbSet<User> Users{ get; set; }

    }
}
