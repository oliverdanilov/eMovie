using eMovie.AppServices;
using eMovie.AppServices.DTOs;
using eMovie.Infrastructure.Data;
using eMovie.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eMovie.Web.Controllers
{
    public class MovieController : Controller
    {
        private GenreService _genreService;
        private MovieService _movieService;
        public MovieController()
        {
            string cnnString = ConfigurationManager.ConnectionStrings["defaultCnn"].ToString();
            var dbContext = new eMovieDbContext(cnnString);
            var genreRepo = new GenreRepository(dbContext);
            var movieRepo = new MovieRepository(dbContext);
            _genreService = new GenreService(genreRepo);
            _movieService = new MovieService(movieRepo, genreRepo);
        }
        // GET: Movie
        public ActionResult Index()
        {
            var model = _movieService.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            MovieDto model = new MovieDto();
            model.Genres = _genreService.GetAll().Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            }).ToList();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create( MovieDto model)
        {
            _movieService.AddMovie(model);
            return RedirectToAction("Index");
        }
    }
}