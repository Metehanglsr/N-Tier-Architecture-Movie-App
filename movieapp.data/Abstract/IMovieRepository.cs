using movieapp.entity;

namespace movieapp.data.Abstract
{
    public interface IMovieRepository : IRepository<Movie>
    {
        List<Movie> GetPopularMovies();
        public Movie GetMovieWithReviews(int movieId);
        public Movie GetMovieWithFull(int movieId);
        public List<Movie> GetMoviesWithFull();
        public List<Movie> GetMoviesByGenreName(string genre);
        public List<Movie> GetMoviesByGenreId(int genreId);
        public Genre GetGenreById(int genreId);


    }
}
