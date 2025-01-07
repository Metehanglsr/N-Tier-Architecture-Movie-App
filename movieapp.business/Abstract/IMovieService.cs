using movieapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieapp.business.Abstract
{
    public interface IMovieService
    {
        Movie GetById(int id);
        List<Movie> GetAll();
        void Create(Movie entity);
        void Update(Movie entity);
        void Delete(Movie entity);
        List<Movie> GetTop5Movies();
        public Movie GetMovieWithReviews(int movieId);
        public Movie GetMovieWithFull(int movieId);
        public List<Movie> GetMoviesWithFull();
        public List<Movie> GetMoviesByGenreName(string genre);
        public List<Movie> GetMoviesByGenreId(int genreId);
        public Genre GetGenreById(int genreId);

    }
}
