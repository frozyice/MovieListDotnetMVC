using MovieListDotnetMVC.DatabaseContext;
using MovieListDotnetMVC.Models;
using MovieListDotnetMVC.Repositorys;
using MovieListDotnetMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieListDotnetMVC.Controllers
{
    public class HomeController : Controller
    {
        MovieService movieService = new MovieService();

        private MovieDbContext db = new MovieDbContext();

        public ActionResult Index()
        {
            ICollection<Movie> movies = movieService.ListOfMovies().Movies;
            return View(movies);
        }

        public ActionResult Details(Guid id)
        {
            Movie movie = movieService.DetailsOfMovie(id);
            return View(movie);
        }
        
    }
}