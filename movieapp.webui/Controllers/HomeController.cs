using Microsoft.AspNetCore.Mvc;
using movieapp.business.Abstract;
using movieapp.entity;
using movieapp.webui.Models;
using movieapp.webui.ModelView;
using System.Diagnostics;

namespace movieapp.webui.Controllers
{
    public class HomeController : Controller
    {
        //private readonly HttpClient _httpClient;
        private IUserService _userService;
        private IMovieService _movieService;
        private IActorService _actorService;
        private IDirectorService _directorService;
        //private string apiKey = "f7b7f0ba";

        public HomeController(IUserService userService, IMovieService movieService,IActorService actorService,IDirectorService directorService)
        {
            _userService = userService;
            _movieService = movieService;
            _movieService = movieService;
            _actorService = actorService;
            _directorService = directorService;
            //_httpClient = httpClient;
        }

        public IActionResult Index()
        {
            MovieActorModelView model = new MovieActorModelView();
            List<Movie> movieList;
            List<Actor> actorList;
            List<Director> directorList;
            movieList = _movieService.GetMoviesWithFull();
            actorList = _actorService.GetActorsWithFull();
            directorList = _directorService.GetDirectorsWithFull();
            model.Movies = movieList;
            model.Actors = actorList;
            var tuple = (model, directorList);
            //try
            //{
            //    for(int i=0;i<5;i++)
            //    {
            //    string apiUrl = $"http://www.omdbapi.com/?apikey={apiKey}&i={"tt00"+HelperMethodRandom.Random()}";
            //    HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
            //    response.EnsureSuccessStatusCode();
            //    string jsonData = await response.Content.ReadAsStringAsync();
            //    movieList.Add(JsonSerializer.Deserialize<MovieViewModel>(jsonData) ?? new MovieViewModel());
            //    }
            //}
            //catch (HttpRequestException e)
            //{
            //    return BadRequest("API isteði baþarýsýz: " + e.Message);
            //}
                return View(tuple);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
