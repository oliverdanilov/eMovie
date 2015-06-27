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
    public class GenreController : Controller
    {
        private GenreService _genreService;
        public GenreController()
        {
            string cnnString = ConfigurationManager.ConnectionStrings["defaultCnn"].ToString();
            var dbContext = new eMovieDbContext(cnnString);
            var genreRepo =new GenreRepository(dbContext);
            _genreService = new GenreService(genreRepo);
        }
        // GET: Genre
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(GenreDto model)
        {
            _genreService.AddGenre(model);
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            List<GenreDto> list = _genreService.GetAll();
            return View(list);
        }
    }
}