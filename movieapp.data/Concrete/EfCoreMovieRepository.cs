using Microsoft.EntityFrameworkCore;
using movieapp.data.Abstract;
using movieapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieapp.data.Concrete
{
    public class EfCoreMovieRepository : EfCoreGenericRepository<Movie, MovieContext>, IMovieRepository
    {
        private MovieContext _context;
        public EfCoreMovieRepository(MovieContext context) : base(context)
        {
            _context = context;
        }
        public List<Movie> GetPopularMovies()
        {
           
            return _context.Movies.OrderBy(x=>x.Rating).Take(5).ToList();
        }
        public Movie GetMovieWithReviews(int movieId)
        {
            var movie = _context.Movies
                           .Include(m => m.Reviews)
                           .SingleOrDefault(m => m.Id == movieId);
            if (movie == null) 
            {
                throw new NullReferenceException();
            }
            return movie;
        }
        public Movie GetMovieWithFull(int movieId)
        {
            Movie movie = _context.Movies
                                .Include(m=>m.Reviews)
                                    .ThenInclude(m => m.User)
                                .Include(m => m.MovieGenres)
                                    .ThenInclude(m=>m.Genre)
                                .Include(m=>m.MovieActors)
                                    .ThenInclude(m=>m.Actor)
                                .Include(m=>m.MovieDirectors)
                                    .ThenInclude(m=>m.Director)
                                .SingleOrDefault(m=>m.Id == movieId) ?? new Movie();
            if (movie == null)
            {
                throw new NullReferenceException();
            }
            return movie;
        }
        public List<Movie> GetMoviesWithFull()
        {
            List<Movie> movieList = _context.Movies.Include(m => m.Reviews)
                                                   .ThenInclude(m => m.User)
                                                   .Include(m => m.MovieGenres)
                                                   .ThenInclude(m => m.Genre)
                                                   .ToList();
            return movieList;
        }

        public List<Movie> GetMoviesByGenreName(string genre)
        {
            Genre _genre = _context.Genres.FirstOrDefault(m => m.Name.ToLower() == genre.ToLower()) ?? new Genre();
            List<Movie> movieList = _context.Movies.Include(m => m.Reviews)
                                       .ThenInclude(m => m.User)
                                       .Include(m => m.MovieGenres)
                                       .ThenInclude(m => m.Genre)
                                       .Where(m => m.MovieGenres.Any(mg => mg.Genre == _genre)).ToList();
            return movieList;
        }

        public List<Movie> GetMoviesByGenreId(int genreId)
        {
            List<Movie> movieList = _context.Movies.Include(m => m.Reviews)
                           .ThenInclude(m => m.User)
                           .Include(m => m.MovieGenres)
                           .ThenInclude(m => m.Genre)
                           .Where(m=>m.MovieGenres.Any(m=>m.GenreId == genreId)).ToList();
            return movieList;
        }

        public Genre GetGenreById(int genreId)
        {
            Genre genre = _context.Genres.Find(genreId) ?? new Genre();
            return genre;
        }
    }
}
