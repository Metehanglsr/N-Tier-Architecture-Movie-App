using movieapp.business.Abstract;
using movieapp.data.Abstract;
using movieapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieapp.business.Concrete
{
    public class MovieManager : IMovieService
    {
        private IMovieRepository _movieRepository;
        public MovieManager(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public void Create(Movie entity)
        {
            //İŞ KURALLARIM
            
            if(entity.MovieGenres == null || entity.MovieGenres.Count<=0)
            {
                throw new ArgumentException("Filmin Kategorisi olmalidir");
            }
            _movieRepository.Create(entity);
        }

        public void Delete(Movie entity)
        {
            if(entity==null)
            {
                throw new ArgumentNullException("Silmek istediğiniz film mevcut degil");
            }
            _movieRepository.Delete(entity);
        }

        public List<Movie> GetAll()
        {
            List<Movie> movieList = _movieRepository.GetAll();
            return movieList;
        }

        public Movie GetById(int id)
        {
            return _movieRepository.GetById(id);
        }

        public List<Movie> GetMoviesByGenreId(int genreId)
        {
            return _movieRepository.GetMoviesByGenreId(genreId);
        }

        public List<Movie> GetMoviesByGenreName(string genre)
        {
            return _movieRepository.GetMoviesByGenreName(genre);
        }

        public List<Movie> GetMoviesWithFull()
        {
            return _movieRepository.GetMoviesWithFull();
        }

        public Movie GetMovieWithFull(int movieId)
        {
            return _movieRepository.GetMovieWithFull(movieId);
        }

        public Movie GetMovieWithReviews(int movieId)
        {
            return _movieRepository.GetMovieWithReviews(movieId);
        }

        public List<Movie> GetTop5Movies()
        {
            var topList = _movieRepository.GetAll().OrderByDescending(x=>x.Rating).Take(5).Select(x=>new Movie
                {
                Id = x.Id,
                Duration = x.Duration,
                Rating = x.Rating,
                Title = x.Title,
            }).ToList();
            return topList;
        }

        public Genre GetGenreById(int genreId)
        {
            return _movieRepository.GetGenreById(genreId);
        }

        public void Update(Movie entity)
        {
            _movieRepository.Update(entity);
        }
    }
}
