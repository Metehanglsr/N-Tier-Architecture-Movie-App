using Microsoft.AspNetCore.Mvc;
using movieapp.business.Abstract;
using movieapp.entity;

namespace movieapp.webui.Controllers
{
    public class MoviesController : Controller
    {
        private HttpClient _httpClient;
        private IUserService _userService;
        private IMovieService _movieService;
        private IActorService _actorService;
        private IDirectorService _directorService;

        //private string apiKey = "f7b7f0ba";
        public MoviesController(HttpClient httpClient, IUserService userService, IMovieService movieService, IActorService actorService, IDirectorService directorService)
        {
            _httpClient = httpClient;
            _userService = userService;
            _movieService = movieService;
            _actorService = actorService;
            _directorService = directorService;
        }
        public IActionResult Index()
        {
            var movie = _movieService.GetMovieWithFull(1);
            List<Movie> movieList = new List<Movie>();
            movieList = _movieService.GetAll();
            return View(movieList);
        }
        public IActionResult MovieDetails(string? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var movie = _movieService.GetMovieWithFull(int.Parse(id));
            return View(movie);
        }
        public IActionResult ActorDetails(string id)
        {
            var actorList = _actorService.GetActorsWithFull();
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var actor = _actorService.GetActorWithFull(int.Parse(id));
            var tuple = (actor, actorList);
            return View(tuple);
        }
        public IActionResult DirectorDetails(string id)
        {
            var directorList = _directorService.GetDirectorsWithFull();
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var director = _directorService.GetDirectorWithFull(int.Parse(id));
            var tuple = (director, directorList);
            return View(tuple);
        }
        public IActionResult GenreDetails(string id)
        {
            var movieList = _movieService.GetMoviesByGenreId(int.Parse(id));
            var genre = _movieService.GetGenreById(int.Parse(id));
            var tuple = (movieList, genre);
            return View(tuple);
        }
    }
}
