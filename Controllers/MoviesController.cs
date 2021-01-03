using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly1.Models;
using Vidly1.ViewModels;

namespace Vidly1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {

            var movie = new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }

            };


            var viewModel = new DetailsMovieViewModel
            {
                Movie = movie


            };
            return View(viewModel);

        }


        public ActionResult Details()
        {


            var movie = new List<Movie>
            {

            new Movie { Id = 1, Name = "Shrek" },
            new Movie { Id = 2, Name = "Wall-e" }


            };


            if (!movie.Any())
                return HttpNotFound();

            var viewModel = new DetailsMovieViewModel

            {
                Movie = movie

            };


            return View(viewModel);


        }



    }
}